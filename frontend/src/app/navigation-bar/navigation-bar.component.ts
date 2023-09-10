import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { setToken, userIsAuthenticated, getToken } from '../helper/auth.helper'; // Adjust the path according to your project structure.

@Component({
  selector: 'app-navigation-bar',
  templateUrl: './navigation-bar.component.html',
  styleUrls: ['./navigation-bar.component.css']
})
export class NavigationBarComponent {
  constructor(public router: Router) {}

  handleLogOut() {
    console.log('Logging out...');
    setToken(''); 
    this.router.navigateByUrl('/');
  }
  
  userIsAuthenticated() {
    return userIsAuthenticated(); 
  }
}
