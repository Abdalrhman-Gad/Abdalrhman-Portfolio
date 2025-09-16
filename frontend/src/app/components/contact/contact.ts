import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { DataService } from '../../core/data.service';
import { InViewDirective } from '../../shared/in-view.directive';
import { mailto } from '../../shared/utils';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, InViewDirective],
  templateUrl: './contact.html',
  styleUrls: ['./contact.scss']
})
export class ContactComponent implements OnInit, OnDestroy {
  ds = inject(DataService);
  private obs?: IntersectionObserver;

  form = new FormGroup({
    name: new FormControl<string>('', { nonNullable: true, validators: [Validators.required, Validators.minLength(2)] }),
    email: new FormControl<string>('', { nonNullable: true, validators: [Validators.required, Validators.email] }),
    message: new FormControl<string>('', { nonNullable: true, validators: [Validators.required, Validators.minLength(10)] })
  });

  ngOnInit(): void {
    const sec = document.getElementById('contact')!;
    this.obs = new IntersectionObserver(es => es.forEach(e => e.isIntersecting && this.ds.activeSection.set('contact')), { threshold: .35 });
    this.obs.observe(sec);
  }
  ngOnDestroy(): void { this.obs?.disconnect(); }

  submit() {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }
    const v = this.form.getRawValue();
    const subject = `Portfolio Contact from ${v.name}`;
    const body = `From: ${v.name} (${v.email})

${v.message}`;
    window.location.href = mailto(this.ds.email, subject, body);
  }
}
