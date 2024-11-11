import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../../demo/api/product';

@Injectable({
  providedIn: 'root',
})
export class IconsService {
  constructor(private http: HttpClient) {}

  getIcons() {
    return this.http
      .get<any>('assets/crm/data/icons.json')
      .toPromise()
      .then((res) => res.data)
      .then((data) => data);
  }
}
