import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'gerenciamento-livros';
  constructor(private http: HttpClient){
    this.http.get('url_da_sua_api').subscribe(data => {
      console.log(data);
    });
  }
}
