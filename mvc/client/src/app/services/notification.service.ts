
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  constructor(private toastr: ToastrService) { }

  config = { closeButton: true, timeOut: 5000, progressBar: true, enableHtml: true };

  showSuccess(message:string, title:string) {
    this.toastr.success(message, title, this.config)
  }

  showError(message:string, title:string) {
    this.toastr.error(message, title, this.config)
  }

  showInfo(message:string, title:string) {
    this.toastr.info(message, title, this.config)
  }

  showWarning(message:string, title:string) {
    this.toastr.warning(message, title, this.config)
  }
}
