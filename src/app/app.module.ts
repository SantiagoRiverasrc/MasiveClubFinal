import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { NavComponent } from './components/shared/nav/nav.component';
import { ShoppingCarritoComponent } from './components/shoppingCarrito/shopping-carrito.component';
import { FiltersComponent } from './components/shoppingCarrito/filters/filters.component';
import { ProductListComponent } from './components/shoppingCarrito/product-list/product-list.component';
import { CartComponent } from './components/shoppingCarrito/cart/cart.component';
import { CartItemComponent } from './components/shoppingCarrito/cart/cart-item/cart-item.component';
import { ProductItemComponent } from './components/shoppingCarrito/product-list/product-item/product-item.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { AppRoutingModule } from './app.routing.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    ShoppingCarritoComponent,
    FiltersComponent,
    ProductListComponent,
    CartComponent,
    CartItemComponent,
    ProductItemComponent,
    HomeComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
