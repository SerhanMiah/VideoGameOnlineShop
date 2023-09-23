// game-models.ts

export interface Game {
    id: number;
    title: string;
    price: number;
    releaseDate: Date;
    description?: string;
    gameGenres: GameGenre[];
    gamePlatforms: GamePlatform[];
    gameImages: GameImage[];
    trailerUrl?: string;
    developer?: string;
    publisher?: string;
    averageRating?: number;
    minimumSystemRequirements?: string;
    recommendedSystemRequirements?: string;
    hasMultiplayerSupport: boolean;
    numberOfLocalPlayers: number;
    dlcs: DLC[];
    discountedPrice?: number;
    supportedLanguages: Language[];
    ageRating: AgeRating;
    esrbContentDescriptions?: string;
    orderItems: OrderItem[];
    coverImage: string;
    gameGameTags?: Array<{ gameTag: { tagName: string } }>;
    gameLanguages: { language: string }[];

}

export interface GameGenre {
    gameId: number;
    genre: Genre;
}

export interface GamePlatform {
    gameId: number;
    platform: Platform;
}

export interface Genre {
    id: number;
    name: string;
}

export interface Platform {
    id: number;
    name: string;
}

export interface GameImage {
    id: number;
    url: string;
    gameId: number;
}

export interface DLC {
    id: number;
    dlcName: string;
    releaseDate: Date;
    price: number;
    description: string;
    gameId: number;
    dlcImages: DLCImage[];
    game: GameRef;
}

export interface DLCImage {
    $id: string;
    $values: any[];
}

export interface GameRef {
    $ref: string;
}

export interface Language {
    id: number;
    languageName: string;
}

export interface AgeRating {
    id: number;
    rating: string;
    games: Game[];
}

export interface OrderItem {
    id: number;
    orderId: number;
    game: Game;
    quantity: number;
}

export interface RegisterRequest {
    email: string;
    password: string;
    confirmPassword?: string;
    firstName?: string;
    lastName?: string;
    address?: string;
    city?: string;
    state?: string;
    postalCode?: string;
    country?: string;
}

export interface LoginRequest {
    email: string;
    password: string;
}

export interface LoginResponse {
    token: string;
}

export interface ErrorResponse {
    message: string;
}

export interface Profile {
    id: string;
    email: string;
    userName: string;
    firstName: string;
    lastName: string;
    address: string;
    city: string;
    state: string;
    postalCode: string;
    country: string;
    favoriteGame?: string;
    totalGamesPlayed?: number; 
    achievements?: string[]; 
    gameLibrary?: string[];
    friends?: ApplicationUser[]; 
    bio?: string; 
}

export interface ApplicationUser {
    id: string;
    userName: string;
    email?: string;
    firstName?: string;
    lastName?: string;
    address?: string;
    city?: string;
    state?: string;
    postalCode?: string;
    country?: string;
    cart?: Cart;
    orders?: Order[];
    reviews?: Review[];
    wishLists?: WishList[];
}

export interface Cart {
    id: number;
    userId?: string;
    user?: ApplicationUser;
    cartItems?: CartItem[];
}

export enum OrderStatus {
    Placed,
    Approved,
    Shipped,
    Delivered,
    Cancelled
}

export interface Order {
    id: number;
    applicationUserId?: string;
    applicationUser?: ApplicationUser;
    orderItems?: OrderItem[];
    status: OrderStatus;
    shippingAddress?: string;
    billingId?: number;  
    billing?: Billing;   
}

// Billing 
export interface Billing {
    id: number;
    fullName: string;
    address: string;
    city: string;
    state: string;
    zipCode: string;
    phoneNumber: string;
    email: string;
    userId?: string;
    user?: ApplicationUser;
}


export interface Review {
    id: number;
    rating: number;
    comment?: string;
    gameId: number;
    game?: Game;
    userId?: string;
    user?: ApplicationUser;
}

export interface WishList {
    id: number;
    userId?: string;
    user?: ApplicationUser;
    wishlistItems?: WishlistItem[];
}

export interface CartItem {
    id: number;
    cartId: number;
    cart?: Cart;
    gameId: number;
    game?: Game;
    quantity: number;
}

export interface WishlistItem {
    id: number;
    wishlistId: number;
    wishlist?: WishList;
    gameId: number;
    game?: Game;
}


