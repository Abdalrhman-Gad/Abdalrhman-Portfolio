import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataService } from '../../core/data.service';
import { InViewDirective } from '../../shared/in-view.directive';

@Component({
  selector: 'app-experience',
  standalone: true,
  imports: [CommonModule, InViewDirective],
  templateUrl: './experience.html',
  styleUrls: ['./experience.scss']
})
export class ExperienceComponent implements OnInit, OnDestroy {
  ds = inject(DataService);
  private obs?: IntersectionObserver;

  ngOnInit(): void {
    const sec = document.getElementById('experience')!;
    this.obs = new IntersectionObserver(es => es.forEach(e => e.isIntersecting && this.ds.activeSection.set('experience')), { threshold: .35 });
    this.obs.observe(sec);
  }
  ngOnDestroy(): void { this.obs?.disconnect(); }
}
