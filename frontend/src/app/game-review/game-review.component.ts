import { Component, OnInit, Input } from '@angular/core';
import { Review } from './review.model';
import axios from 'axios';
import { getToken, userIsAuthenticated } from '../helper/auth.helper';
import { ToastrService } from 'ngx-toastr';

interface RatingChangeEvent {
  rating: number;
  // add other properties if needed
}
console.log(userIsAuthenticated());


@Component({
  selector: 'app-game-review',
  templateUrl: './game-review.component.html',
  styleUrls: ['./game-review.component.css']
})
export class GameReviewComponent implements OnInit {
  @Input() gameId: number | undefined;
  reviews: Review[] = [];
  newReview!: Review;

  
  constructor(private toastr: ToastrService) { }

  ngOnInit(): void {
    this.newReview = {
      id: 0,
      rating: 0,
      comment: '',
      gameId: this.gameId ? this.gameId : 0
    };

    if (this.gameId) {
      this.fetchReviewsForGame(this.gameId);
    }
  }

  

  get isUserAuthenticated(): boolean {
    const authenticated = userIsAuthenticated();
    console.log('User authenticated:', authenticated);
    return authenticated;
 }
 
  
  

  private async fetchReviewsForGame(gameId: number) {
    try {
      const { data } = await axios.get<Review[]>(`http://localhost:5177/api/review/${gameId}`);
      this.reviews = data;
    } catch (error) {
      console.error('Error fetching reviews:', error);
      this.toastr.error('Error fetching reviews. Please try again.');
    }
  }

  async addReview() {
    if (!userIsAuthenticated()) {
      console.error('User is not authenticated. Cannot add review.');
      this.toastr.warning('You must be authenticated to add a review.');
      return;
    }

    const token = getToken();

    try {
      const { data } = await axios.post<Review>('http://localhost:5177/api/review', this.newReview, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });
      this.reviews.push(data);
      this.newReview = {
        id: 0,
        rating: 0,
        comment: '',
        gameId: this.gameId ? this.gameId : 0
      };
      this.toastr.success('Review added successfully!');
    } catch (error) {
      console.error('Error posting review:', error);
      this.toastr.error('Error while adding the review. Please try again.');
    }
  }

  async deleteReview(id: number) {
    if (!userIsAuthenticated()) {
      console.error('User is not authenticated. Cannot delete review.');
      this.toastr.warning('You must be authenticated to delete a review.');
      return;
    }

    const token = getToken();

    try {
      await axios.delete(`http://localhost:5177/api/Review/${id}`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });
      this.reviews = this.reviews.filter(r => r.id !== id);
      this.toastr.warning('Review deleted!');
    } catch (error) {
      console.error('Error deleting review:', error);
      this.toastr.error('Error while deleting the review. Please try again.');
    }
  }

  handleRatingChange(event: RatingChangeEvent) {
    this.newReview.rating = event.rating;
}


  getHalfStarVisible(rating: number): boolean {
    return rating % 1 > 0;
  }
}
