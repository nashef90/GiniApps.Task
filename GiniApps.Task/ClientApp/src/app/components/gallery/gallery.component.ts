import { Component } from '@angular/core';
import { catchError, throwError } from 'rxjs';
import { SearchItemDTO } from 'src/app/infrastructure/dtos/search-item.dto';
import { GithubBackendService } from 'src/app/services/github-backend.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent {
  searchValue: string = "";
  data: SearchItemDTO[] = [];
  loading: boolean = false;

  constructor(
    private githubBackendService: GithubBackendService
  ) { }

  search() {
    this.loading = true;
    this.githubBackendService.search(this.searchValue).subscribe(result => {
      this.data = result;
      this.loading = false;
    });
  }

  onBookmarkClick(item: SearchItemDTO) {
    item.bookmarked = !item.bookmarked;
    this.githubBackendService.setBookmark(item).subscribe();
  }
}
