import { Component, EventEmitter, Input, Output } from '@angular/core';
import { SearchItemDTO } from 'src/app/infrastructure/dtos/search-item.dto';

@Component({
  selector: 'app-gallery-item',
  templateUrl: './gallery-item.component.html',
  styleUrls: ['./gallery-item.component.css']
})
export class GalleryItemComponent {
  @Input() item: SearchItemDTO | null = null;
  @Output() onBookmarkClick: EventEmitter<SearchItemDTO> = new EventEmitter();

}
