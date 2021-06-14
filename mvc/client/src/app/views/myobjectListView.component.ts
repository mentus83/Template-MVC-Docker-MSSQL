import { Component, OnInit } from "@angular/core";
import { environment } from "src/environments/environment";
import { Client } from "../services/client.service";
import * as $ from "jquery";
import { MyObject } from "../models/MyObject";

@Component({
    selector: "my-objects",
    templateUrl: "myobjectListView.component.html",
    styleUrls: [ "myobjectListView.component.css" ]
})
export default class MyObjectListView implements OnInit {
    constructor(public client: Client){
    }
    
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

    // TODO
    public addNewObject() {
        console.log("posting object", this.newMyObjectToAdd);
        this.client.addNewMyObject(this.newMyObjectToAdd)
        .subscribe(() => {
            // success
        }, error => {
            // error
        });
    }
}