import { Injectable } from '@angular/core';
import { Review } from '../game-models';
import { Observable, throwError } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { environment } from '../../environment/environment';  

const AUTH_TOKEN_KEY = 'local-user-Token';

@Injectable({
  providedIn: 'root',
})
export class ReviewService {
  private apiUrl = environment.apiBaseUrl; 

  constructor(private http: HttpClient) {}

  private getAuthToken(): string | null {
    return window.localStorage.getItem(AUTH_TOKEN_KEY);
  }

  private getAuthHeaders(): HttpHeaders {
    const token = this.getAuthToken();
    if (token) {
      return new HttpHeaders({
        Authorization: `Bearer ${token}`,
      });
    }
    return new HttpHeaders();
  }

  getReviewsForGame(gameId: number): Observable<Review[]> {
    return this.http.get<Review[]>(`${this.apiUrl}/api/Game/${gameId}/reviews`, {
      headers: this.getAuthHeaders()
    }).pipe(
      catchError(this.handleError)
    );
  }
  

  addReview(review: Review): Observable<Review> {
    return this.http.post<Review>(`${this.apiUrl}/api/Review`, review, {
        headers: this.getAuthHeaders()
    }).pipe(
        catchError(this.handleError)
    );
}


  editReview(review: Review): Observable<Review> {
    return this.http.put<Review>(`${this.apiUrl}/api/review/${review.id}`, review, {
      headers: this.getAuthHeaders()
    }).pipe(
      catchError(this.handleError)
    );
  }

  deleteReview(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/api/review/${id}`, {
      headers: this.getAuthHeaders()
    }).pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: any) {
    console.error('Error occurred', error);
    return throwError(error || 'Server error');
  }
}
