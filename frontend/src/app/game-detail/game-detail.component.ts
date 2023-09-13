import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';
import { ActivatedRoute, Router } from '@angular/router';
import { Game, DLC } from '../game-models';  

@Component({
  selector: 'app-game-detail',
  templateUrl: './game-detail.component.html',
  styleUrls: ['./game-detail.component.css']
})
export class GameDetailComponent implements OnInit {
  selectedGame: Game | undefined;
  errorMessage: string | undefined;

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
              dlcs: data.dlcs ? this.processDLCs(data.dlcs.$values) : [],
          };
      }
      
    } catch (error) {
        console.error('There was an error fetching the game:', error);
        this.handleError(error);
    }
  }

  private processDLCs(dlcs: any[]): DLC[] {
    return dlcs.map(dlc => ({
        id: dlc.id,
        dlcName: dlc.dlcName,
        releaseDate: new Date(dlc.releaseDate),
        price: dlc.price,
        description: dlc.description,
        gameId: dlc.gameId,
        dlcImages: dlc.dlcImages.$values,  
        game: dlc.game
    }));
  }

  private handleError(error: any) {
    this.errorMessage = 'There was an issue fetching the game. Please try again later.';
  }

  getSafeUrl(videoId: string): SafeResourceUrl {
    return this.sanitizer.bypassSecurityTrustResourceUrl(`https://www.youtube.com/embed/${videoId}`);
  }
}
