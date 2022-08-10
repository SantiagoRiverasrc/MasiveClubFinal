import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';
import { MessengerService } from 'src/app/services/messenger.service';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit
{

   cartItem: any = [
  ]

  cartTotal:number = 0
  nombreProducto = ''
  cantidad: number = 0;
  


  constructor( private msg:MessengerService) { }

  ngOnInit(){//El utlimo  de esta fila se borra

    this.msg.getMsg().subscribe(Product =>{
     this.AgregarProductos(Product)
    })
  }

    AgregarProductos(Product:Product){
      this.cartItem.push({
        nombreProducto: Product.nombre,
        cantidad: Product.cantidad,
        precio: Product.precio,
        /*_contador: this.contador++*/
       })

       this.cartTotal += Product.precio; 
    }


  /*AgregarProductos_Carrito()
  {
    this.cartItem.push({ id_Producto: Product.id_Producto,
      NombreProducto: Product.Nombre,
      Cantidad: 1,
      Precio: Product.Precio
    })

      this.cartTotal = 0
      this.cartItem.forEach((item: { Cantidad: number; precio: number; }) =>{this.cartTotal += (item.Cantidad * item.precio)}
  }*/

}

