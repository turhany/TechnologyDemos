import { Component, OnInit } from '@angular/core';

//eklenenler
import { Category } from './category'
import { CategoryService } from './category.service'

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css'],
  providers: [CategoryService] //category servis sadece buraya hizmet edeceği için burada tanımlanır
})
export class CategoryComponent implements OnInit {

  constructor(private categoryService: CategoryService) { }

  categories: Category[];
  selectedCategory: Category;

  getCategories() {
    this.categoryService.getCategories().subscribe(response => this.categories = response)
  }

  ngOnInit() {
    this.getCategories();
  }

  onselect(category?: Category) {
    if (category) {
      this.selectedCategory = category;
    } else {
      this.selectedCategory = null;
    }
  }

}
