import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { LivroService } from './../../service/livro.service';
import { Livro } from '../../models/livro.model';

@Component({
  selector: 'app-livro-form',
  templateUrl: './livro-form.component.html',
  styleUrls: ['./livro-form.component.scss']
})
export class LivroFormComponent implements OnInit {
  livroForm: FormGroup;
  id: number | null = null;

  constructor(
    private fb: FormBuilder,
    private livroService: LivroService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.livroForm = this.fb.group({
      id: [null],
      titulo: [''],
      autor: [''],
      genero: [''],
      ano: ['']
    });
  }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id') ? +this.route.snapshot.paramMap.get('id')! : null;
    if (this.id) {
      this.livroService.getLivro(this.id).subscribe(livro => {
        this.livroForm.patchValue(livro);
      });
    }
  }

  saveLivro(): void {
    const livro: Livro = this.livroForm.value;

    if (!this.id) {
        delete livro.id;
    }

    if (this.id) {
        this.livroService.updateLivro(this.id, livro).subscribe(() => {
            this.router.navigate(['/']);
        });
    }
    else
    {
        this.livroService.addLivro(livro).subscribe(() => {
            this.router.navigate(['/']);
        });
    }
  }

  cancel(): void {
    this.router.navigate(['/']);
  }
}
