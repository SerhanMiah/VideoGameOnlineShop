import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-star-rating',
  templateUrl: './star-rating.component.html',
  styleUrls: ['./star-rating.component.css']
})
export class StarRatingComponent {
  @Input() rating: number = 0;
  @Output() ratingChange = new EventEmitter<number>();
  hoveredRating: number = 0;

hoverRating(value: number): void {
  this.hoveredRating = value;
}

setRating(value: number): void {
  this.rating = value;
  this.hoveredRating = 0; // reset hover rating
}



}
