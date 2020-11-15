import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { IUser } from '../models/user';
import { BaseHttpService } from './base-http.service';

@Injectable({
  providedIn: 'root',
})
export class UserService extends BaseHttpService<IUser> {
  constructor(httpClient: HttpClient,@Inject('BASE_URL') private baseUrl: string) {
    super(httpClient,baseUrl,'api/v1/user');
  }

  getUsers() {
    return this.get();
  }
}
