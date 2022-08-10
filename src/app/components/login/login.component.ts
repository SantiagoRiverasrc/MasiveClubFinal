import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { style } from '@angular/animations';
import { NgStyle } from '@angular/common';
import { Usuario } from 'src/app/models/Usuario';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {


  ngOnInit(): void {
  }

  User: Usuario[] = [];
  constructor(private usuarioservice: UsuarioService){
    this.usuarioservice.getUsuario().subscribe(usuarios=>{
      this.User = usuarios
      console.log(usuarios)

    })
  }

  resultado!:string;

  formularioContact = new FormGroup({
    Nombre: new FormControl('', [Validators.required]),
    Apellidos: new FormControl('', [Validators.required]),
    Email: new FormControl('',[Validators.required, Validators.email]),
    Contrasena: new FormControl('',[Validators.required]),
  })

  submit(usuario: Usuario): void{
    if (this.formularioContact.valid){
      this.resultado = "Registro exitoso";
      //alert("todos los datos son validos");
    }else{
      this.resultado = "todos los datos deben de ser requeridos";
      //alert("los datos deben de ser obligatorios");
    }
    console.log(usuario);
    this.usuarioservice.PostUsuario(usuario).subscribe(data =>{
      //this.getUsuario();
      console.log(data);
    })
  }



  Login =
  {
    email:'',
    password:'',
  }
  Register=
  {
    nombre:'',
    apellido:'',
    email:'',
    password:'',
  }


  IniciarSesion()
  {
    console.log("hola");
  }

  Registro()
  {

  }

  onLogin()
  {
    console.log(this.Login)
  }

  onRegister()
  {
    console.log(this.Register)
  }
}
