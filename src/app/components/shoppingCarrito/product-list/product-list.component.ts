import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/services/product.service'
import { Product } from 'src/app/models/product';

@Component({
  selector: 'app-product-list',
  templateUrl:'./product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  productList: Product[] = []
  wishlist: number[] = []
  constructor(

    private productService: ProductService

    ) { }

  ngOnInit()
  {
    this.productService.getProducts().subscribe((Product) =>
    {
      this.productList = Product;
      console.log(Product)
    })
  }

}
