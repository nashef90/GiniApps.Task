import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { SearchItemDTO } from '../infrastructure/dtos/search-item.dto';

@Injectable({
  providedIn: 'root'
})
export class GithubBackendService {
  protected readonly baseAPIUrl: string;
  protected readonly client: HttpClient;

  constructor(http: HttpClient) {
    this.baseAPIUrl = environment.baseAPIUrl;
    this.client = http;
  }

  search(value: string) {
    return this.client.get<SearchItemDTO[]>(`${this.baseAPIUrl}/github/search?value=${value}`);
  }

  setBookmark(item: SearchItemDTO) {
    return this.client.post(`${this.baseAPIUrl}/github/SetBookmark`, item);
  }

  getBookmarks() {
    return this.client.get<SearchItemDTO[]>(`${this.baseAPIUrl}/github/Bookmarks`);
  }
}
