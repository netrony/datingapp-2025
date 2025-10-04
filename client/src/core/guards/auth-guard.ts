import { CanActivateFn } from '@angular/router';
import { ToastService } from '../services/toast-service';
import { inject } from '@angular/core/primitives/di';
import { AccountService } from '../services/account-service';

export const authGuard: CanActivateFn = () => {
  const accountService = inject(AccountService);
  const toast = inject(ToastService);
  if (accountService.currentUser()) {
    return true;
  } else {
    toast.error('You must be logged in to access this page.');
    return false;
  }
};
