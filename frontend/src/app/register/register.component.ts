import { Component } from '@angular/core';
import axios from 'axios'; // Import Axios
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { setToken, setId } from '../helper/auth.helper';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  registerForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private toastr: ToastrService  
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

        axios.post('http://localhost:5177/api/account/register', registrationData)
            .then((response) => {
                console.log('Registration successful', response.data);
                if (response.data && response.data.token) {
                    setToken(response.data.token); // Store the token
                }
                if (response.data && response.data.id) {
                    setId(response.data.id); // Store the user id
                }
                
                this.toastr.success('Successfully registered!');  // Show success toaster message
                
            })
            .catch((error) => {
                console.error('Registration error', error);
                this.toastr.error('Registration failed. Please try again.');  // Optionally show an error toaster here
            });
    }
}

  }

