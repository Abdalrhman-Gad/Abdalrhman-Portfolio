import { Component, OnDestroy, inject, AfterViewInit, PLATFORM_ID, ElementRef } from '@angular/core';
import { CommonModule, isPlatformBrowser } from '@angular/common';
import { DataService } from '../../core/data.service';
import { InViewDirective } from '../../shared/in-view.directive';

@Component({
  selector: 'app-experience',
  standalone: true,
  imports: [CommonModule, InViewDirective],
  templateUrl: './experience.html',
  styleUrls: ['./experience.scss']
})
export class ExperienceComponent implements AfterViewInit, OnDestroy {
  ds = inject(DataService);
  private platformId = inject(PLATFORM_ID);
  private host = inject<ElementRef<HTMLElement>>(ElementRef);
  private obs?: IntersectionObserver;

  ngAfterViewInit(): void {
    if (!isPlatformBrowser(this.platformId) || typeof IntersectionObserver === 'undefined') {
      return;
    }

    const hostElement = this.host.nativeElement;
    const target = hostElement.closest('section') ?? hostElement;

    this.obs = new IntersectionObserver(
      entries =>
        entries.forEach(entry => entry.isIntersecting && this.ds.activeSection.set('experience')),
      { threshold: 0.35 }
    );
    this.obs.observe(target);
  }
  ngOnDestroy(): void { this.obs?.disconnect(); }
}
