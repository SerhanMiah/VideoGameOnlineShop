import { Component, OnInit } from '@angular/core';
import { Profile } from '../game-models';
import { getToken, userIsAuthenticated } from '../helper/auth.helper';
import axios from 'axios';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  userProfile!: Profile;

  constructor() { }

  ngOnInit(): void {
    this.fetchUserProfile();
  }

  fetchUserProfile(): void {
    if (userIsAuthenticated()) {
        const token = getToken();
        console.log('this is the token ->', token)
        if (token) {
            axios.get('http://localhost:5177/api/account/profile', {
                headers: { 'Authorization': 'Bearer ' + token }
            })
            .then(response => {
                this.userProfile = response.data;
                console.log('User Profile:', this.userProfile); // Log the user profile details
            })
            .catch(error => {
                console.error('Error fetching user profile:', error);
            });
        }
    } else {
        console.error('User not authenticated.');
    }
}
  }

