import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from '../components/home-component/home.component';
import { LoginComponent } from '../components/login-component/login.component';
import { MissingPageComponent } from '../components/missing-page-component/missing-page.component';
import { AuthGuard } from '../helpers/auth.guard';
import { ConfigGuard } from '../helpers/config.guard';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent,
    canActivate: [AuthGuard, ConfigGuard],
  },
  { path: 'login', component: LoginComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', component: MissingPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
