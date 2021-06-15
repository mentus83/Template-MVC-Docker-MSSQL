
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  constructor(private toastr: ToastrService) { }

  showSuccess(message:string, title:string, timeout:number=4000, closeButton:boolean=true, progressBar:boolean=true, enableHtml:boolean=true) {
    let config = { timeOut: timeout, closeButton: closeButton, progressBar: progressBar, enableHtml: enableHtml };
    this.toastr.success(message, title, config)
  }

  showError(message:string, title:string, timeout:number=4000, closeButton:boolean=true, progressBar:boolean=true, enableHtml:boolean=true) {
    let config = { timeOut: timeout, closeButton: closeButton, progressBar: progressBar, enableHtml: enableHtml };
    this.toastr.error(message, title, config)
  }

  showInfo(message:string, title:string, timeout:number=4000, closeButton:boolean=true, progressBar:boolean=true, enableHtml:boolean=true) {
    let config = { timeOut: timeout, closeButton: closeButton, progressBar: progressBar, enableHtml: enableHtml };
    this.toastr.info(message, title, config)
  }

  showWarning(message:string, title:string, timeout:number=4000, closeButton:boolean=true, progressBar:boolean=true, enableHtml:boolean=true) {
    let config = { timeOut: timeout, closeButton: closeButton, progressBar: progressBar, enableHtml: enableHtml };
    this.toastr.warning(message, title, config)
  }
}
