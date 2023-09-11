import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { ToastrService } from 'ngx-toastr';
import { getId } from '../helper/auth.helper'; 
interface CartItem {
  Id: number;
  GameId: number;
  Game?: any; // Placeholder for Game object.
  Quantity: number;
}

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  cartItems: CartItem[] = [];
  userId = getId(); 
  
  constructor(private toastr: ToastrService) {}

  ngOnInit(): void {
    this.fetchCartItems();
  }

  fetchCartItems(): void {
    axios.get<CartItem[]>(`http://localhost:5177/api/ShoppingCart/GetCartItems?userId=${this.userId}`)
      .then(response => {
        this.cartItems = response.data;
      })
      .catch(error => {
        console.error('Error fetching cart items:', error);
        this.toastr.error('Error fetching cart items. Please try again.');
      });
  }

  addToCart(gameId: number, quantity: number): void {
    axios.post('http://localhost:5177/api/ShoppingCart/AddToCart', {
      UserId: this.userId,
      GameId: gameId,
      Quantity: quantity
    })
    .then(() => {
      this.toastr.success('Item added to cart!');
      this.fetchCartItems();
    })
    .catch(error => {
      console.error('Error adding to cart:', error);
      this.toastr.error('Error adding item to cart. Please try again.');
    });
  }

  removeFromCart(cartItemId: number): void {
    axios.delete(`http://localhost:5177/api/ShoppingCart/RemoveFromCart/${cartItemId}`)
      .then(() => {
        this.toastr.warning('Item removed from cart!');
        this.fetchCartItems();
      })
      .catch(error => {
        console.error('Error removing from cart:', error);
        this.toastr.error('Error removing item from cart. Please try again.');
      });
  }

  updateQuantity(cartItemId: number, newQuantity: number): void {
    axios.put('http://localhost:5177/api/ShoppingCart/UpdateQuantity', {
      CartItemId: cartItemId,
      NewQuantity: newQuantity
    })
    .then(() => {
      this.toastr.info('Item quantity updated!');
      this.fetchCartItems();
    })
    .catch(error => {
      console.error('Error updating item quantity:', error);
      this.toastr.error('Error updating item quantity. Please try again.');
    });
  }
}
