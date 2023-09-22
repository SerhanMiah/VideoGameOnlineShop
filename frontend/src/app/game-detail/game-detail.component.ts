import { Component, OnInit } from '@angular/core';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';
import { ActivatedRoute, Router } from '@angular/router';
import { Game, DLC, DLCImage } from '../game-models';
import { CartService } from '../cart/CartService';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environment/environment';



@Component({
  selector: 'app-game-detail',
  templateUrl: './game-detail.component.html',
  styleUrls: ['./game-detail.component.css'],
})
export class GameDetailComponent implements OnInit {
  selectedGame: Game | undefined;
  errorMessage: string | undefined;
  selectedQuantity: number = 1;
  cartItems: Array<{ Game: Game; Quantity: number }> = [];
  currentIndex: number = 0;

  constructor(
    private route: ActivatedRoute,
    private sanitizer: DomSanitizer,
    private router: Router,
    private cartService: CartService,
    private http: HttpClient,
  ) {}

  newReview = {
    rating: 0,
    // any other properties for the review
  };

  get currentImage(): string {
    return this.selectedGame?.gameImages[this.currentIndex]?.url || '';
  }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    if (id === null) {
      console.error('No game ID provided in route.');
      return;
    }
    const gameId = +id;

    

    

    this.http.get<any>(`${environment.apiBaseUrl}/api/Game/${gameId}`)
      .subscribe(
        data => {
          console.log(data)
          this.selectedGame = {

            ...data,
            gameImages: data.gameImages ? data.gameImages.$values : [],
            dlcs: data.dlcs ? this.processDLCs(data.dlcs.$values) : [],
          };
        },
        error => {
          console.error('There was an error fetching the game:', error);
          this.handleError(error);
        }
      );
  }

  private processDLCs(dlcs: any[]): DLC[] {
    return dlcs.map((dlc) => ({
      id: dlc.id,
      dlcName: dlc.dlcName,
      releaseDate: new Date(dlc.releaseDate),
      price: dlc.price,
      description: dlc.description,
      gameId: dlc.gameId,
      dlcImages: dlc.dlcGallery && dlc.dlcGallery.$values ? dlc.dlcGallery.$values : [],
      game: dlc.game,
    }));
}


  private handleError(error: any) {
    this.errorMessage = 'There was an issue fetching the game. Please try again later.';
  }

  getSafeUrl(videoId: string): SafeResourceUrl {
    const youtubeEmbedUrl = videoId.replace('watch?v=', 'embed/');
    return this.sanitizer.bypassSecurityTrustResourceUrl(youtubeEmbedUrl);
}


  addToCart(gameId: number, quantity: number): void {
    if (this.selectedGame) {
      this.cartService.addToCart({
        Id: this.selectedGame.id,
        GameId: gameId,
        Quantity: quantity,
        Game: this.selectedGame
      });

      console.log(`Added game with id: ${gameId} and quantity: ${quantity} to cart.`);
    }
  }
  prevImage(): void {
    const prevIndex = this.currentIndex - 1;
    if (prevIndex >= 0) {
      this.currentIndex = prevIndex;
    }
  }

  nextImage(): void {
    if (this.currentIndex < (this.selectedGame?.gameImages.length || 0) - 1) {
      this.currentIndex++;
    }
  }

  directPurchase(gameId: number, quantity: number): void {
    console.log(`Directly purchased game with id: ${gameId} and quantity: ${quantity}.`);
  }

  get cartItemsCount(): number {
    return this.cartService.getCartItems().length;
  }
}
