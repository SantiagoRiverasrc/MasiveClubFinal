import { NonNullableFormBuilder } from "@angular/forms";

export class Product{
  id_Producto: number;
  nombre: string;
  descripcion: string;
  precio: number;
  img: string;
  cantidad:number;

  constructor(id = 0, Nombre='' , Descripcion="", Precio=0, Img="",Cantidad=0)
  {
    this.id_Producto= id
    this.nombre = Nombre
    this.descripcion =Descripcion
    this.precio = Precio
    this.img = Img
    this.cantidad = Cantidad
  }

}
