import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-trendingcard',
  templateUrl: './trendingcard.component.html',
  styleUrls: ['./trendingcard.component.css']
})
export class TrendingcardComponent {
  @Input() TreblogImageSrc: string = '';
  @Input() label: string = '';
}
