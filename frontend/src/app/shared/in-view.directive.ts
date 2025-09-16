import { Directive, ElementRef, Input, OnDestroy, OnInit, Renderer2 } from '@angular/core';

@Directive({
  selector: '[inView]',
  standalone: true
})
export class InViewDirective implements OnInit, OnDestroy {
  private revealClass = 'reveal';
  @Input('inView')
  set revealClassInput(value: string | null | undefined) {
    this.revealClass = (value ?? '').trim() || 'reveal';
  }
  private observer?: IntersectionObserver;

  constructor(private el: ElementRef, private r: Renderer2) {}

  ngOnInit(): void {
    const native = this.el.nativeElement as HTMLElement;
    this.r.addClass(native, this.revealClass);

    this.observer = new IntersectionObserver(
      entries => {
        entries.forEach(entry => {
          if (entry.isIntersecting) {
            this.r.addClass(native, 'in-view');
            this.observer?.unobserve(native);
          }
        });
      },
      { rootMargin: '0px 0px -10% 0px', threshold: 0.12 }
    );

    this.observer.observe(native);
  }

  ngOnDestroy(): void {
    this.observer?.disconnect();
  }
}
