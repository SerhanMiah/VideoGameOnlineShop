import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';
import { ActivatedRoute, Router } from '@angular/router';


// game.ts
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
  // ... and any other properties you want
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


@Component({
  selector: 'app-game-detail',
  templateUrl: './game-detail.component.html',
  styleUrls: ['./game-detail.component.css']
})
export class GameDetailComponent implements OnInit {
  selectedGame: Game | undefined;
  errorMessage: string | undefined;
  gameData: any;

  constructor(
    private route: ActivatedRoute,
    private sanitizer: DomSanitizer,
    private router: Router 
  ) { }
  async ngOnInit(): Promise<void> {
    const id = this.route.snapshot.paramMap.get('id');
    if (id === null) {
        console.error('No game ID provided in route.');
        return;
    }
    const gameId = +id;

    try {
        const { data } = await axios.get(`http://localhost:5177/api/game/${gameId}`);
        console.log(data);
        if (data) {
          this.selectedGame = {
              ...data,
              gameImages: data.gameImages ? data.gameImages.$values : [],  
              dlcs: data.dlcs ? data.dlcs.$values : [],

          };
      }
      
    } catch (error) {
        console.error('There was an error fetching the game:', error);
        this.handleError(error);
    }
}

  private handleError(error: any) {
    this.errorMessage = 'There was an issue fetching the game. Please try again later.';
  }

  getSafeUrl(videoId: string): SafeResourceUrl {
    return this.sanitizer.bypassSecurityTrustResourceUrl(`https://www.youtube.com/embed/${videoId}`);
}

}