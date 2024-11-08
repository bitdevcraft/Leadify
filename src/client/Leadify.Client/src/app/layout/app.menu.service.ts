import { Injectable, signal } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';
import { MenuChangeEvent } from './api/menuchangeevent';
import { MenuConfig } from './api/menu';

@Injectable({
  providedIn: 'root',
})
export class MenuService {
  _menu: MenuConfig[] = [
    {
      label: 'Home',
      items: [
        { label: 'Dashboard', icon: 'pi pi-fw pi-home', routerLink: ['/'] },
      ],
    },
  ];

  menu = signal<MenuConfig[]>(this._menu);

  private menuData = new BehaviorSubject<MenuConfig[]>(this._menu);
  menuData$ = this.menuData.asObservable();

  updateMenu(menu: MenuConfig[]) {
    this.menuData.next(menu);
    localStorage.setItem('menu', JSON.stringify(menu));
  }

  private menuSource = new Subject<MenuChangeEvent>();
  private resetSource = new Subject();

  menuSource$ = this.menuSource.asObservable();
  resetSource$ = this.resetSource.asObservable();

  onMenuStateChange(event: MenuChangeEvent) {
    this.menuSource.next(event);
  }

  reset() {
    this.resetSource.next(true);
  }
}
