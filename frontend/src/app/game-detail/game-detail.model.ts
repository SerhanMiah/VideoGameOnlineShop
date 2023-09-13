// export interface Game {
//     id: number;
//     title: string;
//     price: number;
//     releaseDate: Date;
//     description?: string;
//     gameGenres: GameGenre[];
//     gamePlatforms: GamePlatform[];
//     gameImages: GameImage[];
//     trailerUrl?: string;
//     developer?: string;
//     publisher?: string;
//     averageRating?: number;
//     minimumSystemRequirements?: string;
//     recommendedSystemRequirements?: string;
//     hasMultiplayerSupport: boolean;
//     numberOfLocalPlayers: number;
//     dlcs: DLC[];
//     discountedPrice?: number;
//     supportedLanguages: Language[];
//     ageRating: AgeRating;
//     esrbContentDescriptions?: string;
//     orderItems: OrderItem[];
//     coverImage: string;
//   }
  
//   export interface GameGenre {
//     gameId: number;
//     genre: Genre;
//   }
  
//   export interface GamePlatform {
//     gameId: number;
//     platform: Platform;
//   }
  
//   export interface Genre {
//     id: number;
//     name: string;
//   }
  
//   export interface Platform {
//     id: number;
//     name: string;
//   }
  
//   export interface GameImage {
//     id: number;
//     url: string;
//     gameId: number;
//   }
  
//   export interface DLC {
//     id: number;
//     dlcName: string;
//     releaseDate: Date;
//     price: number;
//     description: string;
//     gameId: number;
//     dlcImages: DLCImage[];
//     game: GameRef;
// }

// export interface DLCImage {
//     $id: string;
//     $values: any[]; 
// }
// export interface GameRef {
//     $ref: string;
// }


//   export interface Language {
//     id: number;
//     languageName: string;
//   }
  
//   export interface AgeRating {
//     id: number;
//     rating: string;
//     games: Game[];
//   }
  
//   export interface OrderItem {
//     id: number;
//     orderId: number;
//     game: Game;
//     quantity: number;
//   }
  