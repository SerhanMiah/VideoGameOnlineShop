import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http'; // <-- Import HttpClient
import { setToken, setId } from '../helper/auth.helper';
import { LoginRequest, LoginResponse, ErrorResponse } from './login.model';
import { environment } from 'src/environment/environment';
import { ToastrService } from 'ngx-toastr';
import { catchError } from 'rxjs/operators'; 
import { throwError } from 'rxjs'; 

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
    private toastr: ToastrService,
    private http: HttpClient // <-- Inject HttpClient
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
  
      this.http.post<LoginResponse>(`${environment.apiBaseUrl}/api/account/login`, loginData)
        .pipe(
          catchError(error => {
            console.error('Login error', error);
            this.toastr.error('Login failed. Please try again.');
            return throwError(error); 
          })
        )
        .subscribe(response => {
          console.log('Login successful', response);
          if (response && response.token) {
            setToken(response.token);
          }
          if (response && response.id) {
            setId(response.id);
          }
  
          this.toastr.success('Logged in successfully!');
          console.log('I have successfully logged in');
          this.router.navigate(['/']);
        });
    }
  }
  
  }

