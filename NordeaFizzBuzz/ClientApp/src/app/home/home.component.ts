import {Component, Inject} from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']

})
export class HomeComponent {

  result: string[];

  //make injections for class (component) scope by using private
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  /*
  Handle event where user presses the button to begin the computation of the fizzbuzz task
  Fetches the list of numbers and fizzbuzz string tuples by subscribing to the promise
   */
  onClick() {
    this.http.get<string[]>(this.baseUrl + 'api/fizzbuzz').subscribe(result => {
      this.result = result;
    }, error => console.error(error));
  }

}
