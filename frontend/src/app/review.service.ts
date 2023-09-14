import { Injectable } from '@angular/core';
import { Review } from './game-models';
import { Observable } from 'rxjs';
import axios from 'axios';

const AUTH_TOKEN_KEY = 'local-user-Token';


@Injectable({
  providedIn: 'root',
})
export class ReviewService {
  constructor() {}

  private getAuthToken(): string | null {
    return window.localStorage.getItem(AUTH_TOKEN_KEY);
  }
  private getAuthHeaders(): {} {
    const token = this.getAuthToken();
    if (token) {
      return {
        Authorization: `Bearer ${token}`,
      };
    }
    return {};
  }


  getReviewsForGame(gameId: number): Observable<Review[]> {
    return new Observable<Review[]>((observer) => {
      axios
        .get<Review[]>(`http://localhost:5177/api/review/${gameId}`, {
          headers: this.getAuthHeaders()
        })
        .then((response) => {
          observer.next(response.data);
          observer.complete();
        })
        .catch((error) => {
          observer.error(error);
        });
    });
  }

  addReview(review: Review): Observable<Review> {
    return new Observable<Review>((observer) => {
      axios
        .post<Review>('http://localhost:5177/api/review', review, {
          headers: this.getAuthHeaders()
        })
        .then((response) => {
          observer.next(response.data);
          observer.complete();
        })
        .catch((error) => {
          observer.error(error);
        });
    });
  }

  deleteReview(id: number): Observable<void> {
    return new Observable<void>((observer) => {
      axios
        .delete(`http://localhost:5177/api/review/${id}`, {
          headers: this.getAuthHeaders()
        })
        .then(() => {
          observer.next();
          observer.complete();
        })
        .catch((error) => {
          observer.error(error);
        });
    });
  }
}