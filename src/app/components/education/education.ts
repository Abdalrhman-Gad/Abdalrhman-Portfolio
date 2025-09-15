import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataService } from '../../core/data.service';
import { InViewDirective } from '../../shared/in-view.directive';

@Component({
  selector: 'app-education',
  standalone: true,
  imports: [CommonModule, InViewDirective],
  templateUrl: './education.html',
  styleUrls: ['./education.scss']
})
export class EducationComponent implements OnInit, OnDestroy {
  ds = inject(DataService);
  private obs?: IntersectionObserver;

  ngOnInit(): void {
    const sec = document.getElementById('education')!;
    this.obs = new IntersectionObserver(es => es.forEach(e => e.isIntersecting && this.ds.activeSection.set('education')), { threshold: .35 });
    this.obs.observe(sec);
  }
  ngOnDestroy(): void { this.obs?.disconnect(); }
}
