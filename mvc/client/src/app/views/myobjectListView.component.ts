import { Component, OnInit } from "@angular/core";
import { environment } from "src/environments/environment";
import { Client } from "../services/client.service";
import * as $ from "jquery";
import { MyObject } from "../models/MyObject";
import { NotificationService } from "../services/notification.service";
import { Toast } from "bootstrap";

@Component({
    selector: "my-objects",
    templateUrl: "myobjectListView.component.html",
    styleUrls: [ 
        "myobjectListView.component.css", 
        "../../../node_modules/ngx-toastr/toastr.css"  // This does not work! still needs toasrt.css file to be added to the main html file
    ]
})
export default class MyObjectListView implements OnInit {
    constructor(public client: Client, private notify: NotificationService){ }
    
    public newMyObjectToAdd: MyObject = new MyObject();

    ngOnInit(): void {
        this.client.loadMyObjects()
            .subscribe();
    }

    public filter = "";
    public event:any;

    public valueContainsFilter(o:{}, filter:string): boolean {
        return Object.values(o).some(x => String(x).includes(filter));
    }

    public isProduction(): boolean {
        return environment.production;
    }

    public toggleMyObjectItems(event:any): void {
        $(event.target).closest('tr').next('.myObjectItems').toggle(200);
    }

    public toggleAddNewMyObject(event:any): void {
        $(event.target).closest('div.row').next('div.addNewMyObjectDiv').toggle(200);
    }

    public addNewObject() {
        this.client.addNewMyObject(this.newMyObjectToAdd)
        .subscribe(addedObjId => {
            this.notify.showSuccess(`New object was successfully added to the database.</br>id=${addedObjId}`, "Upload Success");
        }, errorResp => {
            console.error(errorResp);
            this.notify.showError(`${errorResp.error.errors.Name[0]}`, "Upload Failed");
        });
    }
}