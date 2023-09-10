import { Component, OnInit } from '@angular/core';
import axios from 'axios'; // Import Axios
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { setToken, setId } from '../helper/auth.helper';
import { LoginRequest, LoginResponse, ErrorResponse } from './login.model';

import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private router: Router,
    private toastr: ToastrService

  ) { }

  ngOnInit() {
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.required],
    });
  }

  onSubmit() {
    if (this.loginForm.valid) {
      const loginData = this.loginForm.value;

      axios.post('http://localhost:5177/api/account/login', loginData)
        .then((response) => {
          console.log('Login successful', response.data);
          if (response.data && response.data.token) {
            setToken(response.data.token);
          }
          if (response.data && response.data.id) {
            setId(response.data.id); 
          }

          this.toastr.success('Logged in successfully!');  
          console.log('I have successfully logged in');
          this.router.navigate(['/']);
        })
        .catch((error) => {
          console.error('Login error', error);
          this.toastr.error('Login failed. Please try again.');  
        });
    }
}

}
