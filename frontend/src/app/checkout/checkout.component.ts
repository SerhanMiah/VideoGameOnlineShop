import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../game-models';
import { environment } from 'src/environment/environment';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {
  order?: Order;

  constructor(private http: HttpClient) {

  }

  ngOnInit(): void {
    this.fetchOrder(1);  
  }

  fetchOrder(id: number): void {
    this.http.get<Order>(`${environment.apiBaseUrl}/api/Checkout/${id}`).subscribe(
      data => {
        this.order = data;
      },
      error => {
        console.error('There was an error fetching the order!', error);
      }
    );
  }

}
