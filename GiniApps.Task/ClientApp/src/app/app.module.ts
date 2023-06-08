import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { GalleryComponent } from './components/gallery/gallery.component';
import { BookmarkedListComponent } from './components/bookmarked-list/bookmarked-list.component';
import { GalleryItemComponent } from './components/gallery-item/gallery-item.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { LayoutComponent } from './components/layout/layout.component';


const routes: Routes = [
  { path: '', component: GalleryComponent, pathMatch: 'full' },
  { path: 'bookmarked', component: BookmarkedListComponent },
];

@NgModule({
  declarations: [
    LayoutComponent,
    NavMenuComponent,
    GalleryComponent,
    GalleryItemComponent,
    BookmarkedListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule,
    MatIconModule,
    MatFormFieldModule,
    MatInputModule,
  ],
  providers: [],
  bootstrap: [LayoutComponent]
})
export class AppModule { }
