import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertarVehiculosComponent } from './insertar-vehiculos.component';

describe('InsertarVehiculosComponent', () => {
  let component: InsertarVehiculosComponent;
  let fixture: ComponentFixture<InsertarVehiculosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertarVehiculosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsertarVehiculosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
