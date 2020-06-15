import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  // to pass uernmae and password
  // this is an empty object setted by {}
  model: any = {};

  constructor(public authService: AuthService, private alertify: AlertifyService, 
    private router: Router) { }

  ngOnInit() {
  }

// make a method named login

  login(){
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success('logged in successfully');
    }, error => {this.alertify.error(error);
    }, () => {
      this.router.navigate(['/members']);
    });

}

loggedIn(){
  return this.authService.loggedIn();
}

logout(){
localStorage.removeItem('token');
console.log('logged out successfully');
this.router.navigate(['/home']);
}





}
