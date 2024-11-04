import {Injectable, signal} from '@angular/core';
import {Idle, DEFAULT_INTERRUPTSOURCES} from '@ng-idle/core';
import {IdleMessages, IdleStatus, IdleUserTimes} from '../models';
import {BehaviorSubject, Observable, Subject} from 'rxjs';


@Injectable({
  providedIn: 'root',
})
export class IdleUserService {
  private idleStatusSubject = new BehaviorSubject<string>("");
  idleStatus$ = this.idleStatusSubject.asObservable();

  constructor(private _idle: Idle) {
    // sets an idle timeout of 5 seconds, use value from enum
    this._idle.setIdle(IdleUserTimes.IDLE_TIME);
    // sets a timeout period of 5 seconds, use value from enum
    this._idle.setTimeout(IdleUserTimes.TIMEOUT);
    // sets the default interrupts, in this case, things like clicks, scrolls, touches to the document
    this._idle.setInterrupts(DEFAULT_INTERRUPTSOURCES);


    window.addEventListener('storage', (event) => {
      if (event.key === 'idleState' && event.newValue === 'Started') {
        this.startWatching();
      }

      if (event.key === 'idleState' && event.newValue === 'Stopped') {
        this.stopWatching();
      }
    });

    this._idle.onIdleEnd.subscribe(() => {
      this.idleStatusSubject.next(IdleMessages.IDLE_END)
    })
    this._idle.onIdleStart.subscribe(() => {
      this.idleStatusSubject.next(IdleMessages.IDLE_STARTED);
    })
    this._idle.onInterrupt.subscribe(() => {
      this.idleStatusSubject.next(IdleMessages.IDLE_INTERRUPTED);
    })
    this._idle.onTimeout.subscribe(() => {
      this.idleStatusSubject.next(IdleMessages.IDLE_TIMEOUT);
    })
    this._idle.onTimeoutWarning.subscribe((countdown) => {
      this.idleStatusSubject.next(IdleMessages.IDLE_TIMEOUT_WARNING.replace('%time%', countdown.toString()));
    })
  }

  // Provide a getter to access the private idle field from outside the service
  get idle() {
    return this._idle;
  }

  startWatching() {
    this._idle.watch();
    this.idleStatusSubject.next(IdleMessages.IDLE_STARTED);
    localStorage.setItem('idleState', IdleStatus.IDLE_STARTED);
  }

  setInterrupts() {
    this._idle.setInterrupts(DEFAULT_INTERRUPTSOURCES);
  }

  stopWatching() {
    this._idle.stop();
    localStorage.setItem('idleState', IdleStatus.IDLE_STOPPED);
  }
}
