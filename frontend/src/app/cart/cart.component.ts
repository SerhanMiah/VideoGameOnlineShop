import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { ToastrService } from 'ngx-toastr';
import { getId } from '../helper/auth.helper';
import { CartService } from './CartService';
import { BehaviorSubject, Observable, Subscribable } from 'rxjs';

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
  cartItemsCount$: Observable<unknown> | Subscribable<unknown> | Promise<unknown> | undefined;


  constructor(
    private toastr: ToastrService,
    public cartService: CartService // Change private to public
  ) {}

  ngOnInit(): void {
    this.cartService.cartItems$.subscribe((items) => {
      this.cartItems = items;
      this.calculateTotalAmount();
    });
    this.fetchCartItems();
  }

  fetchCartItems(): void {
    axios
      .get<CartItem[]>(`http://localhost:5177/api/shoppingCart/GetCartItems?userId=${this.userId}`)
      .then((response) => {
        if (Array.isArray(response.data)) {
          this.cartService.setCartItems(response.data);
        } else {
          console.error('API did not return an array:', response.data);
        }
      })
      .catch((error) => {
        console.error('Error fetching cart items:', error);
        this.toastr.error('Error fetching cart items. Please try again.');
      });
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