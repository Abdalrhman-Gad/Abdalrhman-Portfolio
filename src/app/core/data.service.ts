import { Injectable, signal } from '@angular/core';
import { EducationItem, ExperienceItem, Link, ProjectItem, SkillGroup } from './models';

@Injectable({ providedIn: 'root' })
export class DataService {
  name = 'Abdalrhman Gad';
  title = '.NET Developer';
  summary = `Results-driven Full Stack Developer with strong experience in .NET Core, ASP.NET MVC, Angular, and SQL Server. I build scalable, high-performance web apps using SOLID, Clean Architecture, and EF Core—covering front-end, back-end, API design, and database work.`;

  location = 'Cairo, Egypt';
  email = 'gadwork44@gmail.com';
  phone = '+201095725810';
  links: Link[] = [
    { label: 'GitHub', url: 'https://github.com/Abdalrhman-Gad', icon: 'fa-brands fa-github' },
    { label: 'LinkedIn', url: 'https://linkedin.com/in/abdalrhman-gad', icon: 'fa-brands fa-linkedin' },
    { label: 'EF SET C1', url: 'https://cert.efset.org/en/3fUhiH', icon: 'fa-solid fa-award' }
  ];

  skillGroups: SkillGroup[] = [
    {
      title: 'Backend',
      items: ['.NET Core', '.NET Framework', 'ASP.NET MVC', 'Web Forms (ASPX)', 'ASP.NET Core Web API', 'EF Core', 'ADO.NET', 'C#', 'VB.NET', 'LINQ', 'JWT', 'UnitOfWork', 'Unit Testing', 'MediatR', 'CQRS']
    },
    {
      title: 'Frontend',
      items: ['Angular v9–v19', 'TypeScript', 'JavaScript (ES6+)', 'HTML5', 'CSS3', 'Bootstrap', 'jQuery', 'Blazor']
    },
    {
      title: 'Databases',
      items: ['SQL Server', 'MySQL', 'Database Design', 'Stored Procedures', 'Functions']
    },
    { title: 'Reporting', items: ['SSRS'] },
    {
      title: 'Tools & Process',
      items: ['Git', 'GitHub', 'Trello', 'Jira', 'Postman', 'Swagger', 'Agile', 'Scrum']
    },
    {
      title: 'Design & Architecture',
      items: ['SOLID', 'OOP', 'Data Structures', 'Algorithms', 'Clean Architecture', 'Onion Architecture', 'Design Patterns']
    }
  ];

  projects: ProjectItem[] = [
    {
      name: 'Digital Notes Manager',
      description: 'Windows & Web solution with Identity, Onion architecture, MDI; secure notes and organization.',
      tech: ['.NET', 'C#', 'SQL Server', 'ASP.NET Core Identity', 'Onion', 'SOLID'],
      url: 'https://github.com/Abdalrhman-Gad/Digital-Notes-Manager'
    },
    {
      name: 'Examination System DB',
      description: 'SQL Server database with CLR, ERD mapping, and Stored Procedures.',
      tech: ['SQL Server', 'CLR', 'Stored Procedures'],
      url: 'https://github.com/Abdalrhman-Gad/Examination_System'
    },
    {
      name: 'E-commerce API',
      description: 'Production-ready Web API with EF Core, JWT Auth, Identity, and Repository pattern.',
      tech: ['ASP.NET Core Web API', 'EF Core', 'SQL Server', 'JWT', 'Onion'],
      url: 'https://github.com/Abdalrhman-Gad/E-Commerce'
    },
    {
      name: 'Khatawat-Tanqia',
      description: 'Dynamic services website with responsive UI.',
      tech: ['HTML', 'CSS', 'JavaScript', 'Bootstrap'],
      url: 'https://khatawattanqia.store/'
    },
    {
      name: 'Home Mart',
      description: 'E-commerce mobile app with Flutter & GetX; REST API integration.',
      tech: ['Flutter', 'Dart', 'GetX', 'REST'],
      url: 'https://www.linkedin.com/posts/abdalrhman-gad_flutter-ecommerce-ecommerceapp-activity-7101988715840888832-NjXd'
    },
    {
      name: 'Cozy Corner (Graduation Project)',
      description: 'Real-estate app for listing, browsing, comparing, and reserving properties.',
      tech: ['Flutter', 'GetX', 'Firebase', 'Dart'],
      url: 'https://www.linkedin.com/posts/abdalrhman-gad_flutter-flutterdevelopment-appdevelopment-activity-7087511003256516608--8g1'
    }
  ];

  experiences: ExperienceItem[] = [
    {
      role: 'Full-stack .NET Developer',
      company: 'Smart Galaxy Solutions (SGS)',
      period: 'Aug 2025 – Present',
      description: 'Enterprise web applications across .NET Core & .NET Framework.',
      bullets: [
        'Built ASP.NET Web Forms (ASPX) modules with VB.NET & ADO.NET.',
        'Heavy SQL Server Stored Procedures & SSRS reporting.',
        'Angular (v9–v19) frontend with scalable component architecture.'
      ],
      tech: ['ASP.NET', 'VB.NET', 'ADO.NET', 'SQL Server', 'SSRS', 'Angular']
    },
    {
      role: 'Full-stack .NET Developer',
      company: 'Lfeen',
      period: 'May 2025 – Aug 2025',
      bullets: [
        'Identity and business/location verification via Nafath, Shomos, SPL.',
        'Clean Architecture with .NET Core & SQL Server.',
        'Focused on API performance and reliability.'
      ],
      tech: ['.NET Core', 'Clean Architecture', 'SQL Server']
    },
    {
      role: 'English Customer Support Agent',
      company: 'VXI Global Solutions',
      period: 'Apr 2025 – Aug 2025',
      bullets: [
        'Customer Security Assurance Team; native English support.',
        'Ranked among Top Achievers for quality & satisfaction.'
      ]
    },
    {
      role: 'Coding Instructor',
      company: 'iSchool',
      period: 'Feb 2025 – Apr 2025',
      bullets: ['Taught Python & game dev; simplified concepts and guided projects.']
    },
    {
      role: 'Freelance Software Developer',
      company: 'Self-Employed',
      period: '2023 – Present',
      bullets: ['Full-stack .NET Core, Angular, Flutter; delivered secure, scalable apps.']
    },
    {
      role: 'Search Engine Evaluator',
      company: 'Appen (Yukon Project)',
      period: 'May 2023 – Jul 2023',
      bullets: ['Rated results for relevance and quality per strict guidelines.']
    },
    {
      role: 'Full Stack Web Development using .NET (Internship)',
      company: 'ITI – Intensive Training Program',
      period: 'Nov 2024 – Apr 2025',
      bullets: [
        'Hands-on .NET, C#, SQL Server, Identity, Onion.',
        'Projects: Digital Notes Manager, Examination System DB, E-commerce API.'
      ]
    }
  ];

  education: EducationItem[] = [
    {
      degree: 'BSc in Computers and Information',
      school: 'Assiut University – Computer Science',
      period: 'Sep 2019 – Jun 2023',
      gpa: '3.23/4.0',
      honor: 'Graduated with Honors',
      details: [
        'Graduation Project: Cozy Corner – A+',
        'Real-estate app for renting/selling properties: listing, browsing, comparing, reserving.'
      ],
      links: [
        { label: 'Cozy Corner', url: 'https://www.linkedin.com/posts/abdalrhman-gad_flutter-flutterdevelopment-appdevelopment-activity-7087511003256516608--8g1' }
      ]
    }
  ];

  languages = ['Arabic (Native)', 'English (C1)'];
  softSkills = ['Collaboration', 'Problem-Solving', 'Attention to Detail', 'Issue Resolution', 'Communication', 'Innovation', 'Critical Thinking', 'Teamwork', 'Adaptability', 'Fast Learning', 'Time Management', 'Leadership', 'Decision-Making'];
  availability = 'Open to remote and on-site positions';
  interests = ['Continuous learning', 'Exploring new technologies', 'Football', 'Gym', 'Traveling'];
  military = 'Completed (Aug 2023 – Dec 2024)';

  activeSection = signal<'home'|'skills'|'experience'|'projects'|'education'|'contact'>('home');
}