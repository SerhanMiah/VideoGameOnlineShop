import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'; 
<<<<<<< HEAD
import { HttpClient } from '@angular/common/http'; 
=======
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environment/environment';
>>>>>>> e668194

interface Game {
  id: number;
  title: string;
  description: string;
  price: number;
  coverImageUrl?: string; 
}

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.css']
})
export class GameListComponent implements OnInit {
  games: Game[] = [];

<<<<<<< HEAD
  constructor(private router: Router, private http: HttpClient) {} // Inject HttpClient here

  async ngOnInit(): Promise<void> {
    try {
        const data: any = await this.http.get('http://localhost:5177/api/Game').toPromise();
=======
  constructor(private router: Router, private http: HttpClient) {}

  async ngOnInit(): Promise<void> {
    try {
      const data: any = await this.http.get(`${environment.apiBaseUrl}/api/Game`).toPromise();
>>>>>>> e668194

      // Check if data exists
      if (!data) {
          console.error('Received no data from API.');
          return;
      }

      // Check if $values exists and is an array
      if (!data.$values || !Array.isArray(data.$values)) {
          console.error('Data does not contain a valid $values array:', data);
          return;
      }
      console.log(data)

      // Map the games from the $values property
      this.games = data.$values.map((gameData: {
        id: number;
        title: string;
        description: string;
        price: number;
        GameImage: { path: string; } 
      }) => ({
        id: gameData.id,
        title: gameData.title,
        description: gameData.description,
        price: gameData.price,
        coverImageUrl: gameData.GameImage?.path, 
      }));
      

<<<<<<< HEAD
        console.log('Mapped games:', this.games);
=======
      // Log the mapped games for verification
      console.log('Mapped games:', this.games);
>>>>>>> e668194

    } catch (error) {
      console.error('There was an error fetching the games', error);
    }
  }

<<<<<<< HEAD
=======

>>>>>>> e668194
  onSelect(game: Game): void {
    this.router.navigate(['/game', game.id]);
  }
}
