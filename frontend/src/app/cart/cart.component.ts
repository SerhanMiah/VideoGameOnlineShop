import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { getId } from '../helper/auth.helper';
import { CartService } from './CartService';
import { BehaviorSubject } from 'rxjs';
import { HttpClient } from '@angular/common/http'; 

interface CartItem {
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
  private cartItemsSubject = new BehaviorSubject<CartItem[]>([]);

  constructor(
    private toastr: ToastrService,
    public cartService: CartService,
    private http: HttpClient  
  ) {}

  ngOnInit(): void {
    this.cartService.cartItems$.subscribe((items) => {
      this.cartItems = items;
      this.calculateTotalAmount();
    });
    this.fetchCartItems();
  }

  fetchCartItems(): void {
    this.http.get<CartItem[]>(`http://localhost:5177/api/shoppingCart/GetCartItems?userId=${this.userId}`)
      .subscribe(
        response => {
          if (Array.isArray(response)) {
            this.cartService.setCartItems(response);
          } else {
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
    const currentItems = this.cartItemsSubject.value || [];
    this.cartItemsSubject.next([...currentItems, newItem]);
  }
  
  removeFromCart(gameId: number): void {
    this.cartService.removeFromCart(gameId);
  }

  calculateTotalAmount(): void {
    this.totalAmount = this.cartService.getTotalAmount();
  }

  updateQuantity(gameId: number, newQuantity: number): void {
    this.cartService.updateQuantity(gameId, newQuantity);
    this.toastr.info('Item quantity updated!');
  }

  incrementQuantity(gameId: number): void {
    const item = this.cartItems.find(cartItem => cartItem.GameId === gameId);
    if (item) {
      item.Quantity += 1;
      this.cartService.updateQuantity(gameId, item.Quantity);
    }
  }

  decrementQuantity(gameId: number): void {
    const item = this.cartItems.find(cartItem => cartItem.GameId === gameId);
    if (item && item.Quantity > 1) {
      item.Quantity -= 1;
      this.cartService.updateQuantity(gameId, item.Quantity);
    }
  }
}
