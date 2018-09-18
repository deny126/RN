import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Product } from '../../../models/product';


@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {

    //constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
    //    http.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
    //        this.forecasts = result.json() as WeatherForecast[];
    //    }, error => console.error(error));
    //}
   public  products:Product[];

    constructor(http: Http,@Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl +'api/products/GetProducts').subscribe(result => {
          this.products = result.json() as Product[];
          console.log("Result ="+result);
        }, error => console.error(error));
       
    }

    public forecasts: WeatherForecast[];
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}
//interface Product {
//    id: number;
//    productname: string;
//    price: number;
//    unitsinstock: number;

//}