import { Component, OnInit } from '@angular/core';
import { Frame } from '../warframes/frame';
import { FrameService } from '../warframes/frame.service';

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
         .subscribe(frames => {
            this.frames = frames.slice(0, this.min(frames.length, 5));
            console.log(frames);
            console.log(this.frames);
         });
   }

   private min(a: number, b: number):number {
      return a < b ? a : b;
   }
}