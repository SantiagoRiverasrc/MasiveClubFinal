import { Component, OnInit } from '@angular/core';
import { Carousel } from 'src/app/models/Carousel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  Carousel: Carousel[] = [
    {id:1,descripcion: "Productos con la mejor calidad del mercado", url:"https://i.picsum.photos/id/10/1980/500.jpg?hmac=JgHZXVX0Hmp6oYYrmztsYFa8HuAuxtHyK4M1N_bVby0" },
    {id:2, descripcion:"Compra ya, Precio super economicos", url:"https://i.picsum.photos/id/453/1980/500.jpg?hmac=EjyYg2MN1F_XBknoaO5_HtMvc_1r9NITDXte9v-CsVQ" },
    {id:3, descripcion: "Es tu hora de mostrar tu talento", url:"https://i.picsum.photos/id/274/1980/500.jpg?hmac=LPdAjmOXifHBAWrUPyDQVWWnpyz-SeJD3Ve3Mgco4o0" },
  ]


  ngOnInit(): void {
    
  }  

}
