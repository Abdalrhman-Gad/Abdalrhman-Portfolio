import { Component, OnInit, inject, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataService } from '../../core/data.service';

@Component({
  selector: 'app-hero',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './hero.html',
  styleUrls: ['./hero.scss']
})
export class HeroComponent implements OnInit, OnDestroy {
  ds = inject(DataService);

  private observer?: IntersectionObserver;

  ngOnInit(): void {
    // Track active section
    const sec = document.getElementById('home')!;
    this.observer = new IntersectionObserver(
      es => es.forEach(e => e.isIntersecting && this.ds.activeSection.set('home')),
      { threshold: 0.35 }
    );
    this.observer.observe(sec);
  }
  ngOnDestroy(): void { this.observer?.disconnect(); }

  get yearExp(): number {
    // Rough experience starting 2023
    const start = new Date(2023, 0, 1).getTime();
    return Math.max(1, Math.round((Date.now() - start)/(1000*60*60*24*365)));
  }
}
