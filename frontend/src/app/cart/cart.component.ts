import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { getId } from '../helper/auth.helper';
import { CartService } from './CartService';
import { Observable } from 'rxjs';
import { environment } from 'src/environment/environment';
import { HttpClient } from '@angular/common/http';
import { tap } from 'rxjs/operators';

export interface CartItem {
  Id?: number;
  GameId: number;
  Game?: any;
  Quantity: number;
}


@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
})
export class CartComponent implements OnInit {
  cartItems: CartItem[] = [];
  userId = getId();
  totalAmount: number = 0;
  cartItems$: Observable<CartItem[]> = this.cartService.cartItems$;

  constructor(
    private cdr: ChangeDetectorRef, 
    private toastr: ToastrService,
    public cartService: CartService,
    private http: HttpClient 
  ) {}

  ngOnInit(): void {
    this.fetchCartItems();
    this.cartService.cartItems$
      .pipe(tap(items => console.log('Emission:', items)))
      .subscribe((items) => {
        this.cartItems = items;
        this.calculateTotalAmount();
        this.cdr.markForCheck();
      });
  }
  

  fetchCartItems(): void {
    this.http.get<CartItem[]>(`${environment.apiBaseUrl}/api/Cart/GetCartItems?userId=${this.userId}`)
      .subscribe(
        response => {
          console.log("API Response:", response);
          if (Array.isArray(response) && response.length > 0) {
            this.cartService.setCartItems(response);
          } else if (!Array.isArray(response)) {
            console.error('API did not return an array:', response);
          }
        },
        error => {
          console.error('Error fetching cart items:', error);
          this.toastr.error('Error fetching cart items. Please try again.');
        }
      );
  }
  
  
  addToCart(newItem: CartItem): void {
    this.cartService.addToCart(newItem); 
  }

  removeFromCart(gameId: number): void {
    this.cartService.removeFromCart(gameId);
  }

  calculateTotalAmount(): void {
    this.totalAmount = this.cartItems.reduce((sum, item) => {
      return sum + (item.Game?.price || 0) * item.Quantity;
    }, 0);
  }
  updateQuantity(gameId: number, newQuantity: number): void {
    this.cartService.updateQuantity(gameId, newQuantity);
    this.toastr.info('Item quantity updated!');
  }

  incrementQuantity(gameId: number): void {
    this.cartService.incrementQuantity(gameId);
  }

  decrementQuantity(gameId: number): void {
    this.cartService.decrementQuantity(gameId);
  }
}
