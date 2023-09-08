import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'; // Import Router from Angular's router module, not 'axios'
import axios from 'axios';

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

  constructor(private router: Router) {}
  async ngOnInit(): Promise<void> {
    try {
        const { data } = await axios.get('http://localhost:5177/api/Game');

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
          GameImage: { path: string; } // Assuming 'path' is a property of GameImage that contains the URL or relative path
        }) => ({
          id: gameData.id,
          title: gameData.title,
          description: gameData.description,
          price: gameData.price,
          coverImageUrl: gameData.GameImage?.path, // Using optional chaining in case GameImage is null
        }));
        

        // Log the mapped games for verification
        console.log('Mapped games:', this.games);

    } catch (error) {
        console.error('There was an error fetching the games', error);
    }
  }

  // Updated onSelect to use the router to navigate to the game details page
  onSelect(game: Game): void {
    this.router.navigate(['/game', game.id]);
  }
}