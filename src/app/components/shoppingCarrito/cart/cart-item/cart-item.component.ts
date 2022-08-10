import { Component, Input, OnInit } from '@angular/core';
import { ProductListComponent } from '../../product-list/product-list.component';
import { Product } from 'src/app/models/product';

@Component({
  selector: 'app-cart-item',
  templateUrl: './cart-item.component.html',
  styleUrls: ['./cart-item.component.css']
})
export class CartItemComponent implements OnInit {

  
  
  @Input() cartItem: any

  constructor() { }

  ngOnInit(){
  }

  

}
