import { Component, OnInit } from "@angular/core";
import { environment } from "src/environments/environment";
import { Client } from "../services/client.service";
import * as $ from "jquery";
import { MyObject } from "../models/MyObject";
import { NotificationService } from "../services/notification.service";

@Component({
    selector: "my-objects",
    templateUrl: "myobjectListView.component.html",
    styleUrls: [ "myobjectListView.component.css" ]
})
export default class MyObjectListView implements OnInit {
    constructor(public client: Client, private notify: NotificationService){ }
    
    public newMyObjectToAdd: MyObject = new MyObject();

    ngOnInit(): void {
        this.GetMyObjectsData();
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
        $(event.target).closest('tr').next('.myObjectItems').fadeToggle(200);
    }

    public toggleAddNewMyObject(event:any): void {
        $('#div_addNewMyObject').fadeToggle(200);
    }

    public refreshTableData(): void {
        this.GetMyObjectsData();
    }

    public addNewObject() {
        this.client.addNewMyObject(this.newMyObjectToAdd)
            .subscribe(addedObjId => {
                this.notify.showSuccess(`New object was successfully added to the database.</br>id=${addedObjId}`, "Upload Success");
                this.client.loadMyObjects().subscribe();
            }, errorResp => {
                if (errorResp.error && errorResp.error.errors && errorResp.error.errors.Name)
                    this.notify.showError(`${errorResp?.error?.errors?.Name[0]}`, "Upload Failed");
                else 
                    this.notify.showError(`${errorResp?.error}`, "Upload Failed");
            });
    }

    GetMyObjectsData() {
        this.client.loadMyObjects()
            .subscribe(
                () => {
                    this.notify.showSuccess("Data retreived from database", "Download Success", 1000, false, false, false);
                },
                errorResp => {
                    this.notify.showError(`${errorResp?.error}`, "Failed to retreive data!");
                });
    }
}


