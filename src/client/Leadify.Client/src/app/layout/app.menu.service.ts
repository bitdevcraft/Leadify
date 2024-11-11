import { Injectable, signal } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';
import { MenuChangeEvent } from './api/menuchangeevent';
import { MenuConfig } from './api/menu';

@Injectable({
  providedIn: 'root',
})
export class MenuService {
  private menuSource = new Subject<MenuChangeEvent>();
  private resetSource = new Subject();

  menuSource$ = this.menuSource.asObservable();
  resetSource$ = this.resetSource.asObservable();

  onMenuStateChange(event: MenuChangeEvent) {
    this.menuSource.next(event);
  }
}
