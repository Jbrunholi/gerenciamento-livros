import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LivroListaComponent } from './components/livro-lista/livro-lista.component';
import { LivroFormComponent } from './components/livro-form/livro-form.component';

const routes: Routes = [
  { path: '', redirectTo: '/livro-lista', pathMatch: 'full' },
  { path: 'livro-lista', component: LivroListaComponent },
  { path: 'livro-form', component: LivroFormComponent },
  { path: 'livro-form/:id', component: LivroFormComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
