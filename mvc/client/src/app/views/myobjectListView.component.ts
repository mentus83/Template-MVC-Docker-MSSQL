import { Component, OnInit } from "@angular/core";
import { environment } from "src/environments/environment";
import { Client } from "../services/client.service";

@Component({
    selector: "my-objects",
    templateUrl: "myobjectListView.component.html",
    styleUrls: [ "myobjectListView.component.css" ]
})
export default class MyObjectListView implements OnInit {
    constructor(public client: Client){
    }
    
    ngOnInit(): void {
        this.client.loadMyObjects()
            .subscribe();
    }

    public filter = "";

    public valueContainsFilter(o:{}, filter:string): boolean {
        return Object.values(o).some(x => String(x).includes(filter));
    }

    public isProduction(): boolean {
        return environment.production;
    }
}