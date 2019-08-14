import { Component } from "@angular/core";



@Component({
templateUrl: "./login.component.html",
styleUrls: []

})

export class LoginComponent {

    _userName = '';
    get userName(): string {
      return this._userName;
    }
    set userName(value: string) {
      this._userName = value;
      //this.filteredProducts = this.listFilter ? this.performFilter(this.listFilter) : this.products;
    }

    _password = '';
    get password(): string {
      return this._password;
    }
    set password(value: string) {
      this._password = value;
      //this.filteredProducts = this.listFilter ? this.performFilter(this.listFilter) : this.products;
    }
  
    //filteredProducts: IProduct[] = [];

DoLogin(): void{


}
}
