import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { ToastrService } from 'ngx-toastr';
import { getId } from '../helper/auth.helper';
import { CartService } from '../CartService';

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
        this.cartItems = response.data;
        this.calculateTotalAmount();
      })
      .catch((error) => {
        console.error('Error fetching cart items:', error);
        this.toastr.error('Error fetching cart items. Please try again.');
      });
  }

  addToCart(gameId: number, quantity: number): void {
    // Assuming you want to add a new cart item without an Id.
    this.cartService.addToCart({ GameId: gameId, Quantity: quantity });
    this.toastr.success('Item added to cart!');
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
