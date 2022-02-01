import {Component, Inject} from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']

})
export class HomeComponent {

  result: string[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  onClick() {
    this.http.get<string[]>(this.baseUrl + 'api/fizzbuzz').subscribe(result => {
      this.result = result;
    }, error => console.error(error));
  }

}
