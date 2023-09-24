import { Component, Output, EventEmitter, OnInit, Input } from '@angular/core';
import { Review } from '../game-models';
import { ToastrService } from 'ngx-toastr';
import { userIsAuthenticated } from '../helper/auth.helper';
import { ReviewService } from '../game-review/review.service';

@Component({
  selector: 'app-add-review',
  templateUrl: './add-review.component.html',
  styleUrls: ['./add-review.component.css']
})
export class AddReviewComponent implements OnInit {
  @Output() reviewAdded = new EventEmitter<Review>();
  @Input() gameId: number | undefined;

  newReview: Review = {
    id: 0,
    rating: 0,
    comment: '',
    gameId: 0  // This will be updated when the component initializes
  };

  constructor(
    private reviewService: ReviewService,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {
    if (this.gameId) {
      this.newReview.gameId = this.gameId;
    }
    // Additional initialization logic can be placed here if required.
  }

  get isUserAuthenticated(): boolean {
    return userIsAuthenticated();
  }
  
  async addReview() {
    if (!this.isUserAuthenticated) {
      this.toastr.warning('You must be authenticated to add a review.');
      return;
    }
  
    try {
      const addedReview = await this.reviewService.addReview(this.newReview).toPromise();
      if (addedReview) {
        // Log the added review to the console
        console.log('Added Review:', addedReview);
  
        this.toastr.success('Review added successfully!');
        this.reviewAdded.emit(addedReview);  // Emitting the review here
        this.resetReviewForm();
      } else {
        this.toastr.error('Failed to add the review. Please try again.');
      }
    } catch (error) {
      this.toastr.error('Error while adding the review. Please try again.');
    }
  }
  

  resetReviewForm() {
    this.newReview = {
      id: 0,
      rating: 0,
      comment: '',
      gameId: this.gameId ? this.gameId : 0
    };
  }
}
