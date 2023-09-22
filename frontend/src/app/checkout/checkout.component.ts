import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../game-models';
import { environment } from 'src/environment/environment';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {
  order?: Order;

  constructor(private http: HttpClient, private route: ActivatedRoute) {}


  ngOnInit(): void {
    const idString = this.route.snapshot.paramMap.get('id');
    if (idString) {
        const id = +idString;
        this.fetchOrder(id);
    } else {
        console.error('No ID found in route parameters');
        // Handle this case as appropriate for your application
    }

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
