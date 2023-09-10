import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  games: any[] = []
  onHover(event: Event) {
    // Add any interactivity or effect when a game card is hovered
  }

  onLeave(event: Event) {
    // Revert any effects when the hover effect ends
  }

}
