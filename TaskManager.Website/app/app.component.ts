import { Component } from '@angular/core'; 

@Component({
    selector: 'main-app', 
    template: '<h2>{{pageTitle}}</h2>'
})
export class AppComponent {

    pageTitle: string;

    constructor() {
        this.pageTitle = "Hello test";
    }

}


