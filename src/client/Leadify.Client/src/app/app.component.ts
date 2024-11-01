import {ChangeDetectionStrategy, ChangeDetectorRef, Component, OnDestroy, OnInit} from '@angular/core';
import {PrimeNGConfig} from 'primeng/api';
import {Router, RouterOutlet} from '@angular/router';
import {IdleUserService} from "./utils/services/idle-user.service";
import {Keepalive, NgIdleKeepaliveModule} from '@ng-idle/keepalive';
import {IdleExpiry, SimpleExpiry} from '@ng-idle/core';
import {IdleMessages, IdleStatus, IdleUserTimes} from "./utils/models";
import {Subscription} from 'rxjs';
import {AuthService} from "./crm/components/auth/auth.service";

const SERVICES: any[] = [IdleUserService];

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: true,
  imports: [RouterOutlet, NgIdleKeepaliveModule],
  changeDetection: ChangeDetectionStrategy.OnPush,
  providers: [
    // Add Keepalive to providers
    Keepalive,
    {
      provide: IdleExpiry,
      useClass: SimpleExpiry,
    },
    SERVICES,
  ],
})
export class AppComponent implements OnInit, OnDestroy {

  subscription: Subscription[] = [];
  idleStatus: string = IdleMessages.IDLE_NO_STARTED;

  constructor(private primengConfig: PrimeNGConfig,
              private idleUserService: IdleUserService,
              private keepalive: Keepalive,
              private cd: ChangeDetectorRef,
              private authService: AuthService
  ) {
  }

  ngOnInit() {

    this.subscription.push(this.idleUserService.idleStatus$.subscribe(status => {
      console.log('@@@', status)
      if (status === IdleMessages.IDLE_TIMEOUT) {
        this.authService.logout();
      }
    }));
    this.subscription.push(this.authService.isLoggedIn$.subscribe(status => {
      if (status) {
        console.log('@@@ User has Logged In')
        this.idleUserService.setInterrupts();
        this.idleUserService.startWatching();
        this.idleStatus = IdleMessages.IDLE_STARTED;
        this.cd.detectChanges();
        window.localStorage.setItem('loggedIn', 'true');
      }
    }));

    this.primengConfig.ripple = true;

    // //It will call when user is idle, and it shows the message 'Timeout!'
    // this.idleUserService.idle.onTimeout.subscribe(() => {
    //   this.idleUserService.updateIdleStatus(IdleMessages.IDLE_TIMEOUT);
    // });
    //
    // this.idleUserService.idle.onIdleStart.subscribe(() => {
    //   this.idleUserService.updateIdleStatus(IdleMessages.IDLE_ENDED);
    //
    // });
    //
    // this.idleUserService.idle.onInterrupt.subscribe(() => {
    //   const message = IdleMessages.IDLE_INTERRUPTED;
    //   this.idleUserService.updateIdleStatus(IdleMessages.IDLE_INTERRUPTED);
    //
    //   this.cd.detectChanges();
    //   localStorage.setItem('idleState', IdleStatus.IDLE_INTERRUPTED);
    // });
    //
    // this.idleUserService.idle.onIdleEnd.subscribe(() => {
    //   const message = IdleMessages.IDLE_END;
    //   this.idleUserService.updateIdleStatus(IdleMessages.IDLE_END);
    //
    //   localStorage.setItem('idleState', IdleStatus.IDLE_USER_ACTIVE);
    //   this.cd.detectChanges();
    // });
    //
    // this.idleUserService.idle.onTimeoutWarning.subscribe((countdown) => {
    //   const message = IdleMessages.IDLE_TIMEOUT_WARNING.replace(
    //     '%time%',
    //     countdown.toString()
    //   );
    //
    //   this.idleUserService.updateIdleStatus(message);
    //   //'You will time out in ' + countdown + ' seconds!';
    //   localStorage.setItem('idleState', IdleStatus.IDLE_TIMEOUT_STARTED);
    //   this.cd.detectChanges();
    // });

    // Set keepalive interval to 15 seconds
    this.keepalive.interval(10); //15

    // Start watching for idle user
    // this.idleUserService.startWatching();

    // // Handle idle user
    // this.idleUserService.idle.onTimeout.subscribe(() => {
    //   this.idleUserService.idle.clearInterrupts();
    //   const message = IdleMessages.IDLE_TIMEOUTPUT_MESSAGE;
    //
    //   this.idleUserService.updateIdleStatus(IdleMessages.IDLE_TIMEOUTPUT_MESSAGE);
    //
    //   // Perform necessary actions, such as logging the user out
    //   this.authService.logout();
    //   this.cd.detectChanges();
    // });
  }

  reset() {
    this.idleUserService.setInterrupts();
    this.idleUserService.startWatching();
    this.idleStatus = IdleMessages.IDLE_STARTED;
    this.cd.detectChanges();
    window.localStorage.setItem('loggedIn', 'true');
  }

  ngOnDestroy() {
    this.idleUserService.stopWatching();
    this.subscription.forEach(sub => sub.unsubscribe());
  }

}
