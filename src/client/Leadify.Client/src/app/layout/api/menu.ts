export interface MenuConfig {
  id?: string;
  label?: string;
  icon?: string;
  routerLink?: string[];
  url?: string[];
  target?: string;
  items?: MenuConfig[];
  parentId?: string;
  hierarchy?: number;
}
