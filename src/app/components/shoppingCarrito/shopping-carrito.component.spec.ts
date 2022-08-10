import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShoppingCarritoComponent } from './shopping-carrito.component';

describe('ShoppingCarritoComponent', () => {
  let component: ShoppingCarritoComponent;
  let fixture: ComponentFixture<ShoppingCarritoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShoppingCarritoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShoppingCarritoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
