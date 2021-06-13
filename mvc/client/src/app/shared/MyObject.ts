import { MyObjectItem } from "./MyObjectItem";

export class MyObject {
    id: number = 0;
    name: string = "";
    description: string = "";
    lastUpdatedBy: string = "";
    lastUpdated: Date = new Date();
    myObjectItems: MyObjectItem[] = [];
}




