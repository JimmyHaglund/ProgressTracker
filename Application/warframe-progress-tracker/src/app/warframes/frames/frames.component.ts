import { Component, OnInit } from '@angular/core';
import { Frame } from '../frame';
import { FrameService } from '../frame.service';

@Component({
   selector: 'app-frames',
   templateUrl: './frames.component.html',
   styleUrls: ['./frames.component.scss']
})
export class FramesComponent implements OnInit {
   frames: Frame[] = [];
   displayedColumns = ['name', 'obtained'];

   constructor(private frameService: FrameService) { }
   
   ngOnInit(): void {
      this.getFrames();
   }

   getFrames(): void {
      this.frameService.getFrames()
         .subscribe(frames => this.frames = frames);
   }

   delete(frame: Frame): void {
      this.frames = this.frames.filter(h => h !== frame);
      this.frameService.deleteFrame(frame.name).subscribe();
   }

   add(name: string): void {
      name = name.trim();
      if (!name) { return; }
      this.frameService.addFrame({ name } as Frame)
         .subscribe(frame => {
            this.frames.push(frame);
         });
   }

   addObtained(frame: Frame): void {
      frame.obtained = true;
      this.frameService.obtainFrame(frame)
         .subscribe(result => frame = result);
   }
}