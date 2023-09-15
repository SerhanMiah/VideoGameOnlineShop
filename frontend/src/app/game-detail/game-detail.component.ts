import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';
import { ActivatedRoute, Router } from '@angular/router';
import { Game, DLC } from '../game-models';
import { CartService } from '../CartService'

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

  constructor(
    private route: ActivatedRoute,
    private sanitizer: DomSanitizer,
    private router: Router,
    private cartService: CartService // Inject the CartService
  ) {}

  newReview = {
    rating: 0,
      // any other properties for the review
  };

  async ngOnInit(): Promise<void> {
    const id = this.route.snapshot.paramMap.get('id');
    if (id === null) {
      console.error('No game ID provided in route.');
      return;
    }
    const gameId = +id;

    try {
      const { data } = await axios.get(`http://localhost:5177/api/game/${gameId}`);
      if (data) {
        this.selectedGame = {
          ...data,
          gameImages: data.gameImages ? data.gameImages.$values : [],
          dlcs: data.dlcs ? this.processDLCs(data.dlcs.$values) : [],
        };
      }
    } catch (error) {
      console.error('There was an error fetching the game:', error);
      this.handleError(error);
    }
  }

  private processDLCs(dlcs: any[]): DLC[] {
    return dlcs.map((dlc) => ({
      id: dlc.id,
      dlcName: dlc.dlcName,
      releaseDate: new Date(dlc.releaseDate),
      price: dlc.price,
      description: dlc.description,
      gameId: dlc.gameId,
      dlcImages: dlc.dlcImages.$values,
      game: dlc.game,
    }));
  }

  private handleError(error: any) {
    this.errorMessage = 'There was an issue fetching the game. Please try again later.';
  }

  getSafeUrl(videoId: string): SafeResourceUrl {
    return this.sanitizer.bypassSecurityTrustResourceUrl(`https://www.youtube.com/embed/${videoId}`);
  }

  addToCart(gameId: number, quantity: number): void {
    if (this.selectedGame) {
      // Add the selected game to the cart service
      this.cartService.addToCart({
        Id: this.selectedGame.id,
        GameId: gameId,
        Quantity: quantity,
        Game: this.selectedGame
      });

      console.log(`Added game with id: ${gameId} and quantity: ${quantity} to cart.`);
    }
}


  directPurchase(gameId: number, quantity: number): void {
    // Your logic to make a direct purchase goes here
    console.log(`Directly purchased game with id: ${gameId} and quantity: ${quantity}.`);
  }

  // Calculate the number of items in the cart
  get cartItemsCount(): number {
    return this.cartService.getCartItems().length;
  }
}
