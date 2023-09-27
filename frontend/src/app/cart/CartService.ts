import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { CartItem } from './cart.component';


@Injectable({
  providedIn: 'root',
})
export class CartService {
  private cartItemsSubject: BehaviorSubject<CartItem[]> = new BehaviorSubject<CartItem[]>([]);
  cartItems$: Observable<CartItem[]> = this.cartItemsSubject.asObservable();

  constructor() {}

  addToCart(item: CartItem): void {
    console.log("Adding item to cart:", item);
    const currentCartItems = [...this.cartItemsSubject.value];
    const existingItem = currentCartItems.find(cartItem => cartItem.GameId === item.GameId);

    if (existingItem) {
      existingItem.Quantity += item.Quantity;
    } else {
      currentCartItems.push(item);
    }

    this.cartItemsSubject.next(currentCartItems);
  }

  removeFromCart(gameId: number): void {
    const updatedCartItems = this.cartItemsSubject.value.filter(cartItem => cartItem.GameId !== gameId);
    this.cartItemsSubject.next(updatedCartItems);
  }

  updateQuantity(gameId: number, newQuantity: number): void {
    const currentCartItems = [...this.cartItemsSubject.value];
    const itemToUpdate = currentCartItems.find(item => item.GameId === gameId);
    
    if (itemToUpdate) {
      itemToUpdate.Quantity = newQuantity;
    }

    this.cartItemsSubject.next(currentCartItems);
  }

  incrementQuantity(gameId: number): void {
    this.updateQuantity(gameId, this.getGameQuantity(gameId) + 1);
  }

  decrementQuantity(gameId: number): void {
    const currentQuantity = this.getGameQuantity(gameId);
    if (currentQuantity > 1) {
      this.updateQuantity(gameId, currentQuantity - 1);
    } else {
      this.removeFromCart(gameId); 
    }
  }

  clearCart(): void {
    this.cartItemsSubject.next([]);
  }

  getCartItems(): CartItem[] {
    return this.cartItemsSubject.value;
  }

  getTotalAmount(): number {
    const currentCartItems = this.cartItemsSubject.value;
    return currentCartItems.reduce(
      (total, cartItem) => total + cartItem.Quantity * (cartItem.Game?.price || 0),
      0
    );
  }

  setCartItems(items: CartItem[]): void {
    console.log("Setting cart items:", items);
    this.cartItemsSubject.next(items);
  }
  

  // Helper function to get the quantity of a particular game
  private getGameQuantity(gameId: number): number {
    const gameItem = this.cartItemsSubject.value.find(item => item.GameId === gameId);
    return gameItem ? gameItem.Quantity : 0;
  }
}


