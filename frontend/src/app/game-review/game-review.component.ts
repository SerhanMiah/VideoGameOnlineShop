import { Component, OnInit, Input } from '@angular/core';
import { Review } from '../game-models';
import { ToastrService } from 'ngx-toastr';
import { ReviewService } from './review.service';
import { userIsAuthenticated } from '../helper/auth.helper';
import { ActivatedRoute } from '@angular/router';

interface RatingChangeEvent {
  rating: number;
}

@Component({
  selector: 'app-game-review',
  templateUrl: './game-review.component.html',
  styleUrls: ['./game-review.component.css'],
})
export class GameReviewComponent implements OnInit {
  @Input() gameId: number | null = null;
  reviews: Review[] = [];
  newReview: Review = this.initializeNewReview();
  currentUserId: number = 1;  // Assuming this is hardcoded for now.

  constructor(
    private route: ActivatedRoute,
    private toastr: ToastrService,
    private reviewService: ReviewService 
  ) {}

  ngOnInit(): void {
    if (!this.gameId) {
      const gameIdStr = this.route.snapshot.paramMap.get('id');
      if (gameIdStr) {
        this.gameId = +gameIdStr;
      } else {
        this.toastr.error('No game ID provided in route.');
        return;
      }
    }

    this.newReview.gameId = this.gameId;
    this.fetchReviewsForGame(this.gameId);
  }

  private initializeNewReview(): Review {
    return {
      id: 0,
      rating: 0,
      comment: '',
      gameId: this.gameId || 0
    };
  }

  get isUserAuthenticated(): boolean {
    return userIsAuthenticated();
  }

  public async fetchReviewsForGame(gameId: number): Promise<void> {
    try {
      const reviews = await this.reviewService.getReviewsForGame(gameId)?.toPromise();
      this.reviews = reviews || [];
    } catch (error) {
      this.toastr.error('Error fetching reviews. Please try again.');
    }
  }

  handleNewReview(addedReview: Review): void {
    this.reviews.push(addedReview);
    if (this.gameId) {
        this.fetchReviewsForGame(this.gameId);
    }
  }

  async deleteReview(id: number): Promise<void> {
    if (!this.isUserAuthenticated) {
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

  isReviewOwner(reviewUserId: number | undefined): boolean {
    if (reviewUserId === undefined) return false;
    return this.currentUserId === reviewUserId;
  }
  

  handleRatingChange(event: RatingChangeEvent): void {
    this.newReview.rating = event.rating;
  }

  getHalfStarVisible(rating: number): boolean {
    return rating % 1 > 0;
  }
}
