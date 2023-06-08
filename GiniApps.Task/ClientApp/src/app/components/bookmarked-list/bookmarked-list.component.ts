import { Component, OnInit } from '@angular/core';
import { SearchItemDTO } from 'src/app/infrastructure/dtos/search-item.dto';
import { GithubBackendService } from 'src/app/services/github-backend.service';

@Component({
  selector: 'app-bookmarked-list',
  templateUrl: './bookmarked-list.component.html',
  styleUrls: ['./bookmarked-list.component.css']
})
export class BookmarkedListComponent implements OnInit {
  searchValue: string = "";
  data: SearchItemDTO[] = [];
  loading: boolean = true;

  constructor(
    private githubBackendService: GithubBackendService
  ) { }

  ngOnInit(): void {
    this.githubBackendService.getBookmarks().subscribe(result => {
      this.data = result;
      this.loading = false;
    });
  }

  onBookmarkClick(item: SearchItemDTO) {
    item.bookmarked = !item.bookmarked;
    this.githubBackendService.setBookmark(item).subscribe();
  }
}
