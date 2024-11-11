import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MenuConfig } from '../../../../../layout/api/menu';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MenuSettingService {
  constructor(private http: HttpClient) {}

  newMenu(parentId: string, menu: MenuConfig): Observable<any> {
    menu.parentId = parentId;

    return this.http.post<any>('/api/App/newMenu', menu).pipe(
      map((res) => {
        return res;
      }),
    );
  }

  deleteMenu(menuId: string): Observable<any> {
    return this.http.post<any>(`/api/App/deleteMenu/${menuId}`, {}).pipe(
      map((res) => {
        return res;
      }),
    );
  }
}
