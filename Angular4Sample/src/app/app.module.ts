import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { CategoryComponent } from './category/category.component';
import { CartComponent } from './cart/cart.component';
import { AccountComponent } from './account/account.component';
import { ShippingDetailComponent } from './shipping-detail/shipping-detail.component';
import { CartSummaryComponent } from './cart/cart-summary/cart-summary.component';
import { LoggedComponent } from './account/logged/logged.component';
import { NotFoundComponent } from './not-found/not-found.component';

//Eklenenler
import { HttpModule } from '@angular/http'
import { SimpleNotificationsModule, NotificationsService } from 'angular2-notifications'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { VatAddedPipe } from './product/vat-added.pipe';
import { ProductFilterPipe } from './product/product-filter.pipe'
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router'
import { LoginGuard } from './account/login.guard';
import { PendingChangesGuard } from './guards/pending-changes.guard';

import { CartService } from './cart/cart.service'
import { AccountService } from './account/account.service'

const appRoutes: Routes = [
  {
    path: "",
    redirectTo: "products",
    pathMatch: "full" //tam olarak yazana gider
  },
  {
    path: "products",
    component: ProductComponent
  },
  {
    path: "products/:seoUrl",
    component: ProductComponent
  },
  {
    path: "my-cart",
    component: CartComponent
  }
  ,
  {
    path: "shipping-detail",
    component: ShippingDetailComponent, canActivate: [LoginGuard], canDeactivate: [PendingChangesGuard]
  }
  ,
  {
    path: "account",
    component: AccountComponent
  }
];

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    CategoryComponent,
    CartComponent,
    AccountComponent,
    ShippingDetailComponent,
    CartSummaryComponent,
    LoggedComponent,
    NotFoundComponent,
    VatAddedPipe,
    ProductFilterPipe
  ],
  imports: [
    BrowserModule,
    HttpModule, // eklendi
    SimpleNotificationsModule.forRoot(),  // eklendi
    BrowserAnimationsModule, //eklendi
    FormsModule, //eklendi
    RouterModule.forRoot(appRoutes) //ekledi
  ],
  providers: [
    { provide: "apiUrl", useValue: "http://northwindapi.azurewebsites.net/api" },
    NotificationsService,
    CartService,
    AccountService,
    LoginGuard,
    PendingChangesGuard
  ],//burada yazarsa singleton olur service
  bootstrap: [AppComponent]
})
export class AppModule { }
