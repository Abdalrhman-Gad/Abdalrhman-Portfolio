export interface Link { label: string; url: string; icon?: string; }
export interface ExperienceItem {
  role: string;
  company: string;
  period: string;
  description?: string;
  bullets?: string[];
  tech?: string[];
}
export interface ProjectItem {
  name: string;
  description: string;
  tech: string[];
  url?: string;
}
export interface EducationItem {
  degree: string;
  school: string;
  period: string;
  gpa?: string;
  honor?: string;
  details?: string[];
  links?: Link[];
}
export interface SkillGroup { title: string; items: string[]; }

export interface ProfileResponse {
  name: string;
  title: string;
  summary: string;
  location: string;
  email: string;
  phone: string;
  availability: string;
  military: string;
  links: Link[];
  skillGroups: SkillGroup[];
  projects: ProjectItem[];
  experiences: Array<ExperienceItem & { bullets: string[]; tech: string[] }>;
  education: Array<EducationItem & { details: string[]; links: Link[] }>;
  languages: string[];
  softSkills: string[];
  interests: string[];
}
