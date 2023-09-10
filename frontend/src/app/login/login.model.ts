// Interface for the registration request model.
export interface RegisterRequest {
    email: string;
    password: string;
    confirmPassword?: string;  
    firstName?: string;        
    lastName?: string;
    address?: string;
    city?: string;
    state?: string;
    postalCode?: string;
    country?: string;
  }
  
  export interface LoginRequest {
    email: string;
    password: string;
  }
  
  export interface LoginResponse {
    token: string;
  }
  
  export interface ErrorResponse {
    message: string;
  }
  