import { Component, OnInit, Input } from '@angular/core';
import { Review } from '../game-models';
import { ToastrService } from 'ngx-toastr';
import { ReviewService } from '../review.service';
import { userIsAuthenticated } from '../helper/auth.helper';

interface RatingChangeEvent {
  rating: number;
}

@Component({
  selector: 'app-game-review',
  templateUrl: './game-review.component.html',
  styleUrls: ['./game-review.component.css'],
})
export class GameReviewComponent implements OnInit {
  @Input() gameId: number | undefined;
  reviews: Review[] = [];
  newReview!: Review;

  constructor(
    private toastr: ToastrService,
    private reviewService: ReviewService // Inject ReviewService
  ) {}

  ngOnInit(): void {
    this.newReview = {
      id: 0,
      rating: 0,
      comment: '',
      gameId: this.gameId ? this.gameId : 0,
    };

    if (this.gameId) {
      this.fetchReviewsForGame(this.gameId);
    }
  }

  get isUserAuthenticated(): boolean {
    return userIsAuthenticated();
  }

  private async fetchReviewsForGame(gameId: number) {
    try {
      const reviews = await this.reviewService.getReviewsForGame(gameId)?.toPromise();
      if (reviews) {
        this.reviews = reviews;
      } else {
        this.reviews = []; // Set a default value or handle the case where reviews is undefined.
      }
    } catch (error) {
      this.toastr.error('Error fetching reviews. Please try again.');
    }
  }
  

  async addReview() {
    if (!userIsAuthenticated()) {
      this.toastr.warning('You must be authenticated to add a review.');
      return;
    }
  
    try {
      const addedReview = await this.reviewService.addReview(this.newReview)?.toPromise();
      if (addedReview) {
        this.reviews.push(addedReview);
      } else {
        // Handle the case where addedReview is undefined.
      }
      this.newReview = {
        id: 0,
        rating: 0,
        comment: '',
        gameId: this.gameId ? this.gameId : 0,
      };
      this.toastr.success('Review added successfully!');
    } catch (error) {
      this.toastr.error('Error while adding the review. Please try again.');
    }
  }
  

  async deleteReview(id: number) {
    if (!userIsAuthenticated()) {
      this.toastr.warning('You must be authenticated to delete a review.');
      return;
    }

    try {
      await this.reviewService.deleteReview(id).toPromise();
      this.reviews = this.reviews.filter((r) => r.id !== id);
      this.toastr.warning('Review deleted!');
    } catch (error) {
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
