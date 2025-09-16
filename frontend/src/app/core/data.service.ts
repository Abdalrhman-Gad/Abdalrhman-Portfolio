import { Injectable, signal, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';
import { environment } from '../../environments/environment';
import { EducationItem, ExperienceItem, Link, ProfileResponse, ProjectItem, SkillGroup } from './models';

@Injectable({ providedIn: 'root' })
export class DataService {
  private readonly http = inject(HttpClient);

  name = '';
  title = '';
  summary = '';
  location = '';
  email = '';
  phone = '';
  links: Link[] = [];
  skillGroups: SkillGroup[] = [];
  projects: ProjectItem[] = [];
  experiences: ExperienceItem[] = [];
  education: EducationItem[] = [];
  languages: string[] = [];
  softSkills: string[] = [];
  availability = '';
  interests: string[] = [];
  military = '';

  readonly loading = signal(true);
  readonly error = signal<string | null>(null);

  activeSection = signal<'home' | 'skills' | 'experience' | 'projects' | 'education' | 'contact'>('home');

  constructor() {
    this.http
      .get<ProfileResponse>(`${environment.apiUrl}/profile`)
      .pipe(takeUntilDestroyed())
      .subscribe({
        next: profile => this.applyProfile(profile),
        error: err => {
          console.error('Failed to load profile', err);
          this.error.set('Unable to load profile data.');
          this.loading.set(false);
        }
      });
  }

  get phoneHref(): string {
    return this.phone ? `tel:${this.phone.replace(/\s+/g, '')}` : '';
  }

  private applyProfile(profile: ProfileResponse) {
    this.name = profile.name;
    this.title = profile.title;
    this.summary = profile.summary;
    this.location = profile.location;
    this.email = profile.email;
    this.phone = profile.phone;
    this.availability = profile.availability;
    this.military = profile.military;

    this.links = profile.links.map(link => ({ ...link }));
    this.skillGroups = profile.skillGroups.map(group => ({
      title: group.title,
      items: [...group.items]
    }));
    this.projects = profile.projects.map(project => ({
      name: project.name,
      description: project.description,
      tech: [...project.tech],
      url: project.url ?? undefined
    }));
    this.experiences = profile.experiences.map(exp => ({
      role: exp.role,
      company: exp.company,
      period: exp.period,
      description: exp.description ?? undefined,
      bullets: exp.bullets.length ? [...exp.bullets] : undefined,
      tech: exp.tech.length ? [...exp.tech] : undefined
    }));
    this.education = profile.education.map(edu => ({
      degree: edu.degree,
      school: edu.school,
      period: edu.period,
      gpa: edu.gpa ?? undefined,
      honor: edu.honor ?? undefined,
      details: edu.details.length ? [...edu.details] : undefined,
      links: edu.links.length
        ? edu.links.map(link => ({ label: link.label, url: link.url }))
        : undefined
    }));
    this.languages = [...profile.languages];
    this.softSkills = [...profile.softSkills];
    this.interests = [...profile.interests];

    this.loading.set(false);
  }
}
