import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { MyObject } from "../shared/MyObject";
import { map } from "rxjs/operators";

@Injectable()
export class Client {
    public myobjects: MyObject[] = [];

    constructor(private http: HttpClient){
    }

    loadMyObjects(){
        return this.http.get<MyObject[]>("/api/myobject")
            .pipe(map(data => {
                this.myobjects = data;
            }));
    }
}