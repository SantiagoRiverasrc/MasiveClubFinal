import { Component, OnInit, Input} from '@angular/core';
import { Product } from 'src/app/models/product';
import { MessengerService } from 'src/app/services/messenger.service';


@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.css']
})
export class ProductItemComponent implements OnInit {

 @Input()
  ProductItem!: Product;

  constructor( private msg: MessengerService) { }

  ngOnInit(): void {

  }

  AgregarProductos() 
  {
    this.msg.sendMsg(this.ProductItem)
  }

}
