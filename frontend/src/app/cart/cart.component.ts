import { Component, OnInit, ChangeDetectorRef } from '@angular/core'; // Import ChangeDetectorRef
import { ToastrService } from 'ngx-toastr';
import { getId } from '../helper/auth.helper';
import { CartService } from './CartService';
import { BehaviorSubject, Observable } from 'rxjs';
import { environment } from 'src/environment/environment';
import { HttpClient } from '@angular/common/http'; // Import HttpClient

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
  cartItemsCount$: Observable<CartItem[]> = this.cartItemsSubject.asObservable();

  constructor(
    private cdr: ChangeDetectorRef, // Inject ChangeDetectorRef
    private toastr: ToastrService,
    public cartService: CartService,
    private http: HttpClient // Inject HttpClient service
  ) {}

  ngOnInit(): void {
    this.cartService.cartItems$.subscribe((items) => {
        this.cartItems = items;
        this.calculateTotalAmount();
        this.cdr.markForCheck(); // Mark component for check
    });
    this.fetchCartItems();
  }

  fetchCartItems(): void {
    this.http.get<CartItem[]>(`${environment.apiBaseUrl}/api/Cart/GetCartItems?userId=${this.userId}`)
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
    console.log(newItem)
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
