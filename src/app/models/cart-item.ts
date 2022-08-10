import { Product } from "./product";

export class CartItem
{
  id_Producto: number;
  nombreProducto: string;
  precio: number;
  cantidad: number;


  constructor(Id = 0, Nombre='' , Cantidad=0, Precio=0,)
  {
    this.id_Producto= Id
    this.nombreProducto = Nombre
    this.precio = Precio
    this.cantidad = Cantidad
  }
}
