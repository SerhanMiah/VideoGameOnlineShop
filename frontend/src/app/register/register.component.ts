import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { HttpClient } from '@angular/common/http'; 
import { catchError } from 'rxjs/operators'; 
import { throwError } from 'rxjs'; 
import { environment } from 'src/environment/environment';
import { setToken, setId } from '../helper/auth.helper';

interface RegistrationResponse {
  token: string;
  id: string;
}

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  registerForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private toastr: ToastrService,
    private http: HttpClient  // <-- Inject HttpClient
    ) {
    this.registerForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required],
      firstName: [''],
      lastName: [''],
      address: [''],
      city: [''],
      state: [''],
      postalCode: [''],
      country: ['']
    }, { validator: this.checkPasswords });
  }

  checkPasswords(group: FormGroup) {
    let pass = group.controls['password'].value;
    let confirmPass = group.controls['confirmPassword'].value;
    return pass === confirmPass ? null : { notSame: true }
  }

  onSubmit() {
    if (this.registerForm.valid) {
        const registrationData = this.registerForm.value;

        this.http.post<RegistrationResponse>(`${environment.apiBaseUrl}/api/account/register`, registrationData)
        .pipe(
              catchError(error => {
                console.error('Registration error', error);
                this.toastr.error('Registration failed. Please try again.');
                return throwError(error); 
              })
            )
            .subscribe(response => {
              console.log('Registration successful', response);
              if (response && response.token) {
                  setToken(response.token); 
              }
              if (response && response.id) {
                  setId(response.id); 
              }
    
              this.toastr.success('Successfully registered!'); 
            });
    }
  }
}
