import { Component, OnInit } from "@angular/core";
import { Client } from "../services/client.service";

@Component({
    selector: "my-objects",
    templateUrl: "myobjectListView.component.html",
    styleUrls: []
})
export default class MyObjectListView implements OnInit {
    constructor(public client: Client){
    }
    
    ngOnInit(): void {
        this.client.loadMyObjects()
            .subscribe();
    }
}