import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataService } from '../../core/data.service';
import { InViewDirective } from '../../shared/in-view.directive';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [CommonModule, InViewDirective],
  templateUrl: './projects.html',
  styleUrls: ['./projects.scss']
})
export class ProjectsComponent implements OnInit, OnDestroy {
  ds = inject(DataService);
  private obs?: IntersectionObserver;
  ngOnInit(): void {
    const sec = document.getElementById('projects')!;
    this.obs = new IntersectionObserver(es => es.forEach(e => e.isIntersecting && this.ds.activeSection.set('projects')), { threshold: .35 });
    this.obs.observe(sec);
  }
  ngOnDestroy(): void { this.obs?.disconnect(); }

  open(url?: string) { if (url) window.open(url, '_blank'); }
}
