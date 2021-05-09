import { Component, OnInit } from '@angular/core';
import { Frame } from '../frame';
import { FrameService } from '../frame.service';

@Component({
   selector: 'app-dashboard',
   templateUrl: './dashboard.component.html',
   styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
   frames: Frame[] = [];

   constructor(private frameService: FrameService) { }

   ngOnInit() {
      this.getFrames();
   }

   getFrames(): void {
      this.frameService.getFrames()
         .subscribe(frames => this.frames = frames.slice(1, 5));
   }
}