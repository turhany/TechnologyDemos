import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

//videodan bakarak eklendi
import { FormsModule } from '@angular/forms'
import { HttpModule } from '@angular/http'
import { RouterModule, Routes } from '@angular/router'

import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { ProductsfilterPipe } from './product/productsfilter.pipe';
import { TodoComponent } from './todo/todo.component';
import { TodoDetailComponent } from './todo/todo-detail/todo-detail.component';

const appRoutes: Routes = [
  {
    path: 'products',//url adresi
    component: ProductComponent,
    data: { //ekstra data göndermek istersek
      title: 'Product List'
    }
  },
  {
    path: '',
    component: TodoComponent
  },
  {
    path: 'todos',
    component: TodoComponent
  },
  {
    path: 'todos/:id',
    component: TodoDetailComponent
  }
];


@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    ProductsfilterPipe,
    TodoComponent,
    TodoDetailComponent
  ],
  imports: [
    BrowserModule,
    FormsModule, //model binding için gerekli
    HttpModule, //http module çalışması için eklenmesi gerek
    RouterModule.forRoot(appRoutes) //routing için gerekli konfigürasyon
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
