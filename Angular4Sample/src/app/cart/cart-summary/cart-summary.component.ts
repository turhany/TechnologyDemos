import { Component, OnInit, DoCheck } from '@angular/core';

//eklenenler
import { CartService } from '../cart.service'
import { CartItem } from '../cart-item'
import { Product } from "../../product/product";

@Component({
  selector: 'app-cart-summary',
  templateUrl: './cart-summary.component.html',
  styleUrls: ['./cart-summary.component.css']
})
export class CartSummaryComponent implements OnInit, DoCheck {


  constructor(private cartService: CartService) { }

  totalCartItem: number;
  totalCartItemPrice: number;
  cartItems: CartItem[];

  ngOnInit() {
    // this.totalCartItem = this.cartService.list().reduce((a, b) => a + b.quantity, 0);
    // this.totalCartItemPrice = this.cartService.list().reduce((a, b) => a + b.quantity * b.product.unitPrice, 0);

    this.cartItems = this.cartService.list();
  }

  //herhangi bir yerde bu kısım ile ilgili bir değişiklik olduğunda bu event tetiklenir
  ngDoCheck(): void {
    this.totalCartItem = this.cartService.list().reduce((a, b) => a + b.quantity, 0);
    this.totalCartItemPrice = this.cartService.list().reduce((a, b) => a + b.quantity * b.product.unitPrice, 0);
  }

  removeFromCart(product: Product) {
    this.cartService.removeFromCart(product);
  }
}
