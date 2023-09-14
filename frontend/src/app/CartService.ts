import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  private cartItemsSubject: BehaviorSubject<CartItem[]> = new BehaviorSubject<CartItem[]>([]);
  cartItems$: Observable<CartItem[]> = this.cartItemsSubject.asObservable();

  constructor() {}

  // Add an item to the cart
  addToCart(item: CartItem): void {
    const currentCartItems = this.cartItemsSubject.value;
    const existingItem = currentCartItems.find((cartItem) => cartItem.GameId === item.GameId);

    if (existingItem) {
      // If the item already exists in the cart, update its quantity
      existingItem.Quantity += item.Quantity;
    } else {
      // If it's a new item, add it to the cart
      currentCartItems.push(item);
    }

    this.cartItemsSubject.next([...currentCartItems]);
  }

  // Remove an item from the cart
  removeFromCart(gameId: number): void {
    const currentCartItems = this.cartItemsSubject.value;
    const updatedCartItems = currentCartItems.filter((cartItem) => cartItem.GameId !== gameId);

    this.cartItemsSubject.next([...updatedCartItems]);
  }

  // Update the quantity of an item in the cart
  updateQuantity(gameId: number, newQuantity: number): void {
    const currentCartItems = this.cartItemsSubject.value;
    const updatedCartItems = currentCartItems.map((cartItem) => {
      if (cartItem.GameId === gameId) {
        cartItem.Quantity = newQuantity;
      }
      return cartItem;
    });

    this.cartItemsSubject.next([...updatedCartItems]);
  }

  // Clear the entire cart
  clearCart(): void {
    this.cartItemsSubject.next([]);
  }

  // Get the current cart items
  getCartItems(): CartItem[] {
    return this.cartItemsSubject.value;
  }

  // Calculate the total amount of items in the cart
  getTotalAmount(): number {
    const currentCartItems = this.cartItemsSubject.value;
    return currentCartItems.reduce(
      (total, cartItem) => total + cartItem.Quantity * (cartItem.Game?.price || 0),
      0
    );
  }
}

// Define your CartItem interface
interface CartItem {
  Id?: number;
  GameId: number;
  Game?: any; // Placeholder for Game object.
  Quantity: number;
}

