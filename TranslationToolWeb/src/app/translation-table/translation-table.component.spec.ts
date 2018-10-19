import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TranslationTableComponent } from './translation-table.component';

describe('TranslationTableComponent', () => {
  let component: TranslationTableComponent;
  let fixture: ComponentFixture<TranslationTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TranslationTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TranslationTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
