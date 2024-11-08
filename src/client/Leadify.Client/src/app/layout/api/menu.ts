export interface MenuConfig {
  label?: string;
  icon?: string;
  routerLink?: string[];
  url?: string[];
  target?: string;
  items?: MenuConfig[];
}
