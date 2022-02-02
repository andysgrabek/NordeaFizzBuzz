import { Component } from '@angular/core';
import {Title} from "@angular/platform-browser";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';

  //inject only for constructor scope
  constructor(titleService: Title) {
    //set webpage title so it looks nice
    titleService.setTitle('Nordea Fizz Buzz')
  }
}
