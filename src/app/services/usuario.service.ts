import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Usuario } from '../models/Usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  usuario:Usuario[] = [];

  constructor(private htpp: HttpClient) { }

  getUsuario(): Observable<Usuario[]>
  {
    let respuesta = this.htpp.get('').pipe(map((usuario:any)=>usuario))
    return respuesta
  }
  PostUsuario(usuario:Usuario): Observable<any>{
    let resx = this.htpp.post('', usuario)
    return resx
  }
}
