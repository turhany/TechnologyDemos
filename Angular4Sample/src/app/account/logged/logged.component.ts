import { Component, OnInit, DoCheck } from '@angular/core';

//eklenen
import { AccountService } from '../account.service'
import { Router } from '@angular/router'

@Component({
  selector: 'app-logged',
  templateUrl: './logged.component.html',
  styleUrls: ['./logged.component.css']
})
export class LoggedComponent implements DoCheck {

  isLogged = false;

  constructor(private accountService: AccountService,
    private router: Router) { }

  ngDoCheck(): void {
    this.isLogged = this.accountService.isLoggedIn();
  }

  logOut() {
    this.accountService.logOut();
    this.router.navigate(["account"]);
  }
}
