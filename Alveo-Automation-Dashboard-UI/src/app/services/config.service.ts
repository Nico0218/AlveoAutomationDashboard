import { APP_BASE_HREF } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AppConfig } from '../classes/app-config';
import { Environment } from '../classes/environment';

@Injectable()
export class ConfigurationService {
  applicationPath = '../../';
  constructor(
    private httpClient: HttpClient,
    @Inject(APP_BASE_HREF) baseHref: string
  ) {
    if (baseHref && baseHref != '/') {
      this.applicationPath = baseHref;
    }
  }

  public get controllerURL(): string {
    return `${Environment.apiUrl}/Configuration`;
  }

  public loadAppSettings(): Promise<boolean> {
    return this.httpClient
      .get(this.applicationPath + 'assets/appsettings.json')
      .pipe(
        map((result) => {
          let appConfig = result as AppConfig;
          Environment.apiUrl = appConfig.apiUrl;
          Environment.production = appConfig.production;
          return true;
        })
      )
      .toPromise();
  }

  public IsConfigured(): Observable<boolean> {
    return this.httpClient.get(`${this.controllerURL}/IsConfigured`).pipe(
      map(
        (ii) => {
          return ii as boolean;
        }
      )
    );
  }
}
