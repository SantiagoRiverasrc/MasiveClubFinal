import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Product } from '../models/product';

@Injectable({
  providedIn: 'root'
})
export class MessengerService {

  subject = new Subject<Product>()

  constructor() { }

  sendMsg(products: Product) //Me permite ingresar los productos al product-Item
  {
    console.log(products)
    this.subject.next(products)
  }

  getMsg(){
    return this.subject.asObservable()
  }


}
