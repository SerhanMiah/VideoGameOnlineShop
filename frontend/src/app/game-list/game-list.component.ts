import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'; 
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environment/environment';

interface Game {
  id: number;
  title: string;
  description: string;
  price: number;
  coverImage?: string; 
}

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.css']
})
export class GameListComponent implements OnInit {
  games: Game[] = [];

  constructor(private router: Router, private http: HttpClient) {}
  async ngOnInit(): Promise<void> {
    try {
      const data = await this.http.get<any[]>(`${environment.apiBaseUrl}/api/Game`).toPromise();

      // Check if data exists and is an array
      if (!data || !Array.isArray(data)) {
          console.error('Received no data or invalid data from API.', data);
          return;
      }

      console.log('Raw API data:', data);

      // Map the games directly from the data array
      this.games = data.map((gameData: {
        id: number;
        title: string;
        description: string;
        price: number;
        GameImage: { path: string };
        coverImage: string
      }) => ({
        id: gameData.id,
        title: gameData.title,
        description: gameData.description,
        price: gameData.price,
        coverImage: gameData.coverImage,
      }));

      // Log the mapped games for verification
      console.log('Mapped games:', this.games);

    } catch (error) {
      console.error('There was an error fetching the games', error);
    }
  }


  onSelect(game: Game): void {
    this.router.navigate(['/game', game.id]);
  }
}