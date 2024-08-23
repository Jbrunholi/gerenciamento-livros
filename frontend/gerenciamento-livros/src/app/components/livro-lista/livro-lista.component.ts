import { Component, OnInit } from '@angular/core';
import { LivroService } from './../../service/livro.service';
import { Livro } from '../../models/livro.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-livro-lista',
  templateUrl: './livro-lista.component.html',
  styleUrls: ['./livro-lista.component.scss']
})
export class LivroListaComponent implements OnInit {
  livros: Livro[] = [];

  constructor(private livroService: LivroService, private router: Router) { }

  ngOnInit(): void {
    this.livroService.getLivros().subscribe(data => {
      this.livros = data;
    });
  }

  deleteLivro(id: number): void {
    this.livroService.deleteLivro(id).subscribe(() => {
      this.livros = this.livros.filter(livro => livro.id !== id);
    });
  }

  editLivro(id: number): void {
    this.router.navigate(['/livro-form', id]);
  }

  addLivro(): void {
    this.router.navigate(['/livro-form']);
  }
}
