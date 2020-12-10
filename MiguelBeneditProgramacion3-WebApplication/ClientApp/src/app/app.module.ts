import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { EmpireComponent } from './empire/empire.component';
import { UserComponent } from './user/user.component';
import { UserFormComponent } from './user/user-form/user-form.component';
import { EmpireFormComponent } from './empire/empire-form/empire-form.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    UserComponent,
    UserFormComponent,
    EmpireComponent,
    EmpireFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'users', component: UserComponent, pathMatch: 'full' },
      { path: 'user/:id', component: UserFormComponent, pathMatch: 'full' },
      { path: 'user-create', component: UserFormComponent, pathMatch: 'full' },
      { path: 'empires', component: EmpireComponent, pathMatch: 'full' },
      { path: 'empire/:id', component: EmpireFormComponent, pathMatch: 'full' },
      { path: 'empire-create', component: EmpireFormComponent, pathMatch: 'full' },
      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
