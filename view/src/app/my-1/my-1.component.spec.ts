import { ComponentFixture, TestBed } from '@angular/core/testing';

import { My1Component } from './my-1.component';

describe('My1Component', () => {
  let component: My1Component;
  let fixture: ComponentFixture<My1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [My1Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(My1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
