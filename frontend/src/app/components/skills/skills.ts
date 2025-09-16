import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataService } from '../../core/data.service';
import { InViewDirective } from '../../shared/in-view.directive';

@Component({
  selector: 'app-skills',
  standalone: true,
  imports: [CommonModule, InViewDirective],
  templateUrl: './skills.html',
  styleUrls: ['./skills.scss']
})
export class SkillsComponent implements OnInit, OnDestroy {
  ds = inject(DataService);
  private obs?: IntersectionObserver;

  ngOnInit(): void {
    const sec = document.getElementById('skills')!;
    this.obs = new IntersectionObserver(es => es.forEach(e => e.isIntersecting && this.ds.activeSection.set('skills')), { threshold: .35 });
    this.obs.observe(sec);
  }
  ngOnDestroy(): void { this.obs?.disconnect(); }
}
