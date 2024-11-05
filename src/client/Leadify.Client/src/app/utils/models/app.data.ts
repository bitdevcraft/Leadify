export enum IdleUserTimes {
  //idle/Inactive Time in seconds
  IDLE_TIME = 900, //1800,
  //Amount of time (in seconds) that idle dialog is shown until logout the user if not response is made.
  TIMEOUT = 15, //60,
}

export enum IdleMessages {
  IDLE_ENDED = "You've gone idle!",
  IDLE_STARTED = 'Idle Started',
  IDLE_END = 'The user has returned from being idle.',
  IDLE_INTERRUPTED = 'idle interrupted',
  IDLE_PURPOSE = 'The purpose of this code is try to explain the use of ng-idle library',
  IDLE_NO_STARTED = 'Not started.',
  IDLE_TIMEOUTPUT_MESSAGE = 'User is idle! - user should be log out',
  IDLE_TIMEOUT = 'Timeout!',
  IDLE_TIMEOUT_WARNING = 'You will time out in %time% seconds!',
}

export enum IdleStatus {
  IDLE_ENDED = 'Ended',
  IDLE_INTERRUPTED = 'Interrupted',
  IDLE_USER_ACTIVE = 'userActive',
  IDLE_STARTED = 'started',
  IDLE_STOPPED = 'stopped',
  IDLE_TIMEOUT_STARTED = 'TimeoutStarted',
}
