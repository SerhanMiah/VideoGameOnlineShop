// import { Game } from "../game-detail/game-detail.model";

// export interface Profile {
//   id: string;
//   email: string;
//   userName: string;
//   firstName: string;
//   lastName: string;
//   address: string;
//   city: string;
//   state: string;
//   postalCode: string;
//   country: string;
// }


// export interface ApplicationUser {
//   id: string;
//   userName: string; 
//   email?: string; 
//   firstName?: string;
//   lastName?: string;
//   address?: string;
//   city?: string;
//   state?: string;
//   postalCode?: string;
//   country?: string;
//   cart?: Cart; // Assuming you have a Cart interface elsewhere
//   orders?: Order[]; // Assuming you have an Order interface elsewhere
//   reviews?: Review[]; // Assuming you have a Review interface elsewhere
//   wishLists?: WishList[]; // Assuming you have a WishList interface elsewhere
// }

// // Optionally, you might also want to define or import the Cart, Order, Review, and WishList interfaces if they are not already defined in your codebase.
// // Cart.ts
// export interface Cart {
//   id: number;
//   userId?: string;
//   user?: ApplicationUser; // Assuming you've already imported this
//   cartItems?: CartItem[]; // Assuming you'll define or import the CartItem interface
// }

// // Order.ts
// export enum OrderStatus {
//   Placed,
//   Approved,
//   Shipped,
//   Delivered,
//   Cancelled
// }

// export interface Order {
//   id: number;
//   applicationUserId?: string;
//   applicationUser?: ApplicationUser; // Assuming you've already imported this
//   orderItems?: OrderItem[]; // Assuming you'll define or import the OrderItem interface
//   status: OrderStatus;
//   shippingAddress?: string;
// }

// // Review.ts
// export interface Review {
//   id: number;
//   rating: number;
//   comment?: string;
//   gameId: number;
//   game?: Game; // Assuming you'll define or import the Game interface
//   userId?: string;
//   user?: ApplicationUser; // Assuming you've already imported this
// }

// // WishList.ts
// export interface WishList {
//   id: number;
//   userId?: string;
//   user?: ApplicationUser; // Assuming you've already imported this
//   wishlistItems?: WishlistItem[]; // Assuming you'll define or import the WishlistItem interface
// }

// // CartItem.ts
// export interface CartItem {
//   id: number;
//   cartId: number;
//   cart?: Cart;  // Assuming you've already imported the Cart interface
//   gameId: number;
//   game?: Game;  // Assuming you've already imported or defined the Game interface
//   quantity: number;
// }

// // WishlistItem.ts
// export interface WishlistItem {
//   id: number;
//   wishlistId: number;
//   wishlist?: WishList;  // Assuming you've already imported the WishList interface
//   gameId: number;
//   game?: Game;  // Assuming you've already imported or defined the Game interface
// }

// // OrderItem.ts
// export interface OrderItem {
//   id: number;
//   orderId: number;
//   order?: Order;  // Assuming you've already imported the Order interface
//   gameId: number;
//   game?: Game;  // Assuming you've already imported or defined the Game interface
//   quantity: number;
// }
