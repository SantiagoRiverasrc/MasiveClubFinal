import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/product';

const apiUrl = 'https://localhost:44350/api/Producto' //Llamo el api que quiero trabajar

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  /*products: Product[]=
  [
    new Product(1,'Product1','Producto 1 prueba',1500),
    new Product(2,'Product2','Producto 2 prueba',25000),
    new Product(3,'Product3','Producto 3 prueba',50),
    new Product(4,'Product4','Producto 4 prueba',1000),
    new Product(5,'Product5','Producto 5 prueba',100),
    new Product(6,'Product6','Producto 6 prueba',185000),
    new Product(7,'Product7','Producto 7 prueba',15000),
    new Product(8,'Product8','Producto 8 prueba',15000),
  ]*/

  constructor( private http: HttpClient ) { }

  getProducts(): Observable<Product[]>{
    return this.http.get<Product[]>(apiUrl);
  }
}
