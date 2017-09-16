import { Component, OnInit } from '@angular/core';

//Eklenenler
import { Product } from './product'
import { ProductService } from './product.service'
import { NotificationsService } from 'angular2-notifications'
import { CartService } from '../cart/cart.service'
import { ActivatedRoute } from '@angular/router'
import { Pager } from "../app-pager";

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css'],
  providers: [ProductService] //her bir product component için bir servis oluşturulur, component bazında singleton olur 
})
export class ProductComponent implements OnInit {

  products: Product[];
  addedProduct: string;
  pager:Pager = new Pager();

  constructor(
    private activatedRoute: ActivatedRoute,
    private productService: ProductService,
    private notificationsService: NotificationsService,
    private cartService: CartService) {

  }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => { this.getProducts(params["seoUrl"]) });
    //this.getProducts();
  }

  getProducts(seoCategory: string) {
    this.productService.getProducts(seoCategory).subscribe(p => { 
      this.products = p ;
      this.pager = this.getPager(p.length);
    });
  }

  addToCart(product: Product) {
    //alert(product.productName +  " added to cart!");
    this.cartService.addToCart(product);
    this.addedProduct = product.productName;
    this.notificationsService.success("Successfull", product.productName + " added to cart!");
  }

  getPager(totalItems: number, currentPage: number = 1, pageSize: number = 3): Pager {
    let totalPages = Math.ceil(totalItems / pageSize);
    let pages: Array<number> = [];

    for (let i = 1; i <= totalPages; i++) {
      pages.push(i);
    }

    var pager = new Pager();
    pager.currentPage = currentPage;
    pager.pageList = pages;
    pager.pageSize = pageSize;

    return pager;
  }

  setPage(page:number){
      this.pager.currentPage = page;
  }
}
