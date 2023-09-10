// review.model.ts
export interface Review {
    id: number;
    rating: number;
    comment?: string; 
    gameId: number;
    game?: any; 
    userId?: string;
    user?: any; 
  }
  