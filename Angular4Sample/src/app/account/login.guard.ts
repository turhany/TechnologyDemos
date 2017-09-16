import { Injectable } from '@angular/core'
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router'
import { AccountService } from './account.service'
import { Observable } from 'rxjs/Observable';

@Injectable()
export class LoginGuard implements CanActivate {

    constructor(private accountService: AccountService, private router: Router) { }

    //ActivatedRouteSnapshot > gidilmek istenen
    //RouterStateSnapshot > gelinen
    canActivate(next:ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
        let logged = this.accountService.isLoggedIn();
        if (logged) {
            return true;
        }

        this.router.navigate(["account"], { queryParams: { returnUrl: state.url } });
        return false;
    }

}