import { LetterListComponent } from './letter-list/letter-list.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LetterFormComponent } from './letter-form/letter-form.component';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full'
  },
  {
    path: 'list',
    component: LetterListComponent,
    data: {
      title: $localize`Letter`
    }
  },
  {
    path: 'form',
    component: LetterFormComponent,
    data: {
      title: $localize`Letter`
    }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LetterRoutingModule {
}
