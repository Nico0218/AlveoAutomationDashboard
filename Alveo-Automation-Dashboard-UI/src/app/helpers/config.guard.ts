import { Injectable } from '@angular/core';
import {
    ActivatedRouteSnapshot,
    CanActivate,
    Router,
    RouterStateSnapshot
} from '@angular/router';
import { first } from 'rxjs/operators';
import { ConfigurationService } from '../services/config.service';

@Injectable({ providedIn: 'root' })
export class ConfigGuard implements CanActivate {
  constructor(
    private router: Router,
    private configService: ConfigurationService
  ) {}

  async canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const isConfigured = await this.configService
      .IsConfigured()
      .pipe(first())
      .toPromise()
      .catch((err) => false);
    if (isConfigured === true) {
      return true;
    }
    this.router.navigate(['settings']);
    return false;
  }
}
