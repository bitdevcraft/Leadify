import { Injectable } from '@angular/core';
import { Message } from 'primeng/api';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AppToastService {
  private messageSubject = new BehaviorSubject<Message | null>(null);
  message$ = this.messageSubject.asObservable();

  constructor() {}

  sendToast(msg: Message) {
    this.messageSubject.next(msg);
  }
}
