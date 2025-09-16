using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Models;

namespace Portfolio.Api.Data;

public class DataSeeder
{
    private readonly PortfolioContext _context;

    public DataSeeder(PortfolioContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();

        if (await _context.Profiles.AnyAsync())
        {
            return;
        }

        var profile = new Profile
        {
            Name = "Abdalrhman Gad",
            Title = ".NET Developer & Full-Stack Engineer",
            Summary = "Results-driven Full Stack Developer with strong experience in .NET Core, ASP.NET MVC, Angular, and SQL Server. I build scalable, high-performance web apps using SOLID, Clean Architecture, and EF Core—covering front-end, back-end, API design, and database work.",
            Location = "Cairo, Egypt",
            Email = "gadwork44@gmail.com",
            Phone = "+201095725810",
            Availability = "Available for full-time roles and freelance projects — open to remote and on-site positions.",
            Military = "Completed (Aug 2023 – Dec 2024)",
            Links = new List<Link>
            {
                new() { Label = "GitHub", Url = "https://github.com/Abdalrhman-Gad", Icon = "fa-brands fa-github" },
                new() { Label = "LinkedIn", Url = "https://linkedin.com/in/abdalrhman-gad", Icon = "fa-brands fa-linkedin" },
                new() { Label = "EF SET C1", Url = "https://cert.efset.org/en/3fUhiH", Icon = "fa-solid fa-award" }
            },
            SkillGroups = new List<SkillGroup>
            {
                new()
                {
                    Title = "Backend",
                    Skills = new List<Skill>
                    {
                        new() { Name = ".NET Core" },
                        new() { Name = ".NET Framework" },
                        new() { Name = "ASP.NET MVC" },
                        new() { Name = "Web Forms (ASPX)" },
                        new() { Name = "ASP.NET Core Web API" },
                        new() { Name = "EF Core" },
                        new() { Name = "ADO.NET" },
                        new() { Name = "C#" },
                        new() { Name = "VB.NET" },
                        new() { Name = "LINQ" },
                        new() { Name = "JWT" },
                        new() { Name = "UnitOfWork" },
                        new() { Name = "Unit Testing" },
                        new() { Name = "MediatR" },
                        new() { Name = "CQRS" }
                    }
                },
                new()
                {
                    Title = "Frontend",
                    Skills = new List<Skill>
                    {
                        new() { Name = "Angular v9–v19" },
                        new() { Name = "TypeScript" },
                        new() { Name = "JavaScript (ES6+)" },
                        new() { Name = "HTML5" },
                        new() { Name = "CSS3" },
                        new() { Name = "Bootstrap" },
                        new() { Name = "jQuery" },
                        new() { Name = "Blazor" }
                    }
                },
                new()
                {
                    Title = "Databases",
                    Skills = new List<Skill>
                    {
                        new() { Name = "SQL Server" },
                        new() { Name = "MySQL" },
                        new() { Name = "Database Design" },
                        new() { Name = "Stored Procedures" },
                        new() { Name = "Functions" }
                    }
                },
                new()
                {
                    Title = "Reporting",
                    Skills = new List<Skill>
                    {
                        new() { Name = "SSRS" }
                    }
                },
                new()
                {
                    Title = "Tools & Process",
                    Skills = new List<Skill>
                    {
                        new() { Name = "Git" },
                        new() { Name = "GitHub" },
                        new() { Name = "Trello" },
                        new() { Name = "Jira" },
                        new() { Name = "Postman" },
                        new() { Name = "Swagger" },
                        new() { Name = "Agile" },
                        new() { Name = "Scrum" }
                    }
                },
                new()
                {
                    Title = "Design & Architecture",
                    Skills = new List<Skill>
                    {
                        new() { Name = "SOLID" },
                        new() { Name = "OOP" },
                        new() { Name = "Data Structures" },
                        new() { Name = "Algorithms" },
                        new() { Name = "Clean Architecture" },
                        new() { Name = "Onion Architecture" },
                        new() { Name = "Design Patterns" }
                    }
                }
            },
            Projects = new List<Project>
            {
                new()
                {
                    Name = "Digital Notes Manager",
                    Description = "Windows & Web solution with Identity, Onion architecture, MDI; secure notes and organization.",
                    Url = "https://github.com/Abdalrhman-Gad/Digital-Notes-Manager",
                    Tech = new List<ProjectTech>
                    {
                        new() { Name = ".NET" },
                        new() { Name = "C#" },
                        new() { Name = "SQL Server" },
                        new() { Name = "ASP.NET Core Identity" },
                        new() { Name = "Onion" },
                        new() { Name = "SOLID" }
                    }
                },
                new()
                {
                    Name = "Examination System DB",
                    Description = "SQL Server database with CLR, ERD mapping, and Stored Procedures.",
                    Url = "https://github.com/Abdalrhman-Gad/Examination_System",
                    Tech = new List<ProjectTech>
                    {
                        new() { Name = "SQL Server" },
                        new() { Name = "CLR" },
                        new() { Name = "Stored Procedures" }
                    }
                },
                new()
                {
                    Name = "E-commerce API",
                    Description = "Production-ready Web API with EF Core, JWT Auth, Identity, and Repository pattern.",
                    Url = "https://github.com/Abdalrhman-Gad/E-Commerce",
                    Tech = new List<ProjectTech>
                    {
                        new() { Name = "ASP.NET Core Web API" },
                        new() { Name = "EF Core" },
                        new() { Name = "SQL Server" },
                        new() { Name = "JWT" },
                        new() { Name = "Onion" }
                    }
                },
                new()
                {
                    Name = "Khatawat-Tanqia",
                    Description = "Dynamic services website with responsive UI.",
                    Url = "https://khatawattanqia.store/",
                    Tech = new List<ProjectTech>
                    {
                        new() { Name = "HTML" },
                        new() { Name = "CSS" },
                        new() { Name = "JavaScript" },
                        new() { Name = "Bootstrap" }
                    }
                },
                new()
                {
                    Name = "Home Mart",
                    Description = "E-commerce mobile app with Flutter & GetX; REST API integration.",
                    Url = "https://www.linkedin.com/posts/abdalrhman-gad_flutter-ecommerce-ecommerceapp-activity-7101988715840888832-NjXd",
                    Tech = new List<ProjectTech>
                    {
                        new() { Name = "Flutter" },
                        new() { Name = "Dart" },
                        new() { Name = "GetX" },
                        new() { Name = "REST" }
                    }
                },
                new()
                {
                    Name = "Cozy Corner (Graduation Project)",
                    Description = "Real-estate app for listing, browsing, comparing, and reserving properties.",
                    Url = "https://www.linkedin.com/posts/abdalrhman-gad_flutter-flutterdevelopment-appdevelopment-activity-7087511003256516608--8g1",
                    Tech = new List<ProjectTech>
                    {
                        new() { Name = "Flutter" },
                        new() { Name = "GetX" },
                        new() { Name = "Firebase" },
                        new() { Name = "Dart" }
                    }
                }
            },
            Experiences = new List<Experience>
            {
                new()
                {
                    Role = "Full-stack .NET Developer",
                    Company = "Smart Galaxy Solutions (SGS)",
                    Period = "Aug 2025 – Present",
                    Description = "Enterprise web applications across .NET Core & .NET Framework.",
                    Bullets = new List<ExperienceBullet>
                    {
                        new() { Text = "Built ASP.NET Web Forms (ASPX) modules with VB.NET & ADO.NET." },
                        new() { Text = "Heavy SQL Server Stored Procedures & SSRS reporting." },
                        new() { Text = "Angular (v9–v19) frontend with scalable component architecture." }
                    },
                    Tech = new List<ExperienceTech>
                    {
                        new() { Name = "ASP.NET" },
                        new() { Name = "VB.NET" },
                        new() { Name = "ADO.NET" },
                        new() { Name = "SQL Server" },
                        new() { Name = "SSRS" },
                        new() { Name = "Angular" }
                    }
                },
                new()
                {
                    Role = "Full-stack .NET Developer",
                    Company = "Lfeen",
                    Period = "May 2025 – Aug 2025",
                    Bullets = new List<ExperienceBullet>
                    {
                        new() { Text = "Identity and business/location verification via Nafath, Shomos, SPL." },
                        new() { Text = "Clean Architecture with .NET Core & SQL Server." },
                        new() { Text = "Focused on API performance and reliability." }
                    },
                    Tech = new List<ExperienceTech>
                    {
                        new() { Name = ".NET Core" },
                        new() { Name = "Clean Architecture" },
                        new() { Name = "SQL Server" }
                    }
                },
                new()
                {
                    Role = "English Customer Support Agent",
                    Company = "VXI Global Solutions",
                    Period = "Apr 2025 – Aug 2025",
                    Bullets = new List<ExperienceBullet>
                    {
                        new() { Text = "Customer Security Assurance Team; native English support." },
                        new() { Text = "Ranked among Top Achievers for quality & satisfaction." }
                    }
                },
                new()
                {
                    Role = "Coding Instructor",
                    Company = "iSchool",
                    Period = "Feb 2025 – Apr 2025",
                    Bullets = new List<ExperienceBullet>
                    {
                        new() { Text = "Taught Python & game dev; simplified concepts and guided projects." }
                    }
                },
                new()
                {
                    Role = "Freelance Software Developer",
                    Company = "Self-Employed",
                    Period = "2023 – Present",
                    Bullets = new List<ExperienceBullet>
                    {
                        new() { Text = "Full-stack .NET Core, Angular, Flutter; delivered secure, scalable apps." }
                    }
                },
                new()
                {
                    Role = "Search Engine Evaluator",
                    Company = "Appen (Yukon Project)",
                    Period = "May 2023 – Jul 2023",
                    Bullets = new List<ExperienceBullet>
                    {
                        new() { Text = "Rated results for relevance and quality per strict guidelines." }
                    }
                },
                new()
                {
                    Role = "Full Stack Web Development using .NET (Internship)",
                    Company = "ITI – Intensive Training Program",
                    Period = "Nov 2024 – Apr 2025",
                    Bullets = new List<ExperienceBullet>
                    {
                        new() { Text = "Hands-on .NET, C#, SQL Server, Identity, Onion." },
                        new() { Text = "Projects: Digital Notes Manager, Examination System DB, E-commerce API." }
                    }
                }
            },
            Education = new List<Education>
            {
                new()
                {
                    Degree = "BSc in Computers and Information",
                    School = "Assiut University – Computer Science",
                    Period = "Sep 2019 – Jun 2023",
                    Gpa = "3.23/4.0",
                    Honor = "Graduated with Honors",
                    Details = new List<EducationDetail>
                    {
                        new() { Text = "Graduation Project: Cozy Corner – A+" },
                        new() { Text = "Real-estate app for renting/selling properties: listing, browsing, comparing, reserving." }
                    },
                    Links = new List<EducationLink>
                    {
                        new() { Label = "Cozy Corner", Url = "https://www.linkedin.com/posts/abdalrhman-gad_flutter-flutterdevelopment-appdevelopment-activity-7087511003256516608--8g1" }
                    }
                }
            },
            Languages = new List<Language>
            {
                new() { Name = "Arabic (Native)" },
                new() { Name = "English (C1)" }
            },
            SoftSkills = new List<SoftSkill>
            {
                new() { Name = "Collaboration" },
                new() { Name = "Problem-Solving" },
                new() { Name = "Attention to Detail" },
                new() { Name = "Issue Resolution" },
                new() { Name = "Communication" },
                new() { Name = "Innovation" },
                new() { Name = "Critical Thinking" },
                new() { Name = "Teamwork" },
                new() { Name = "Adaptability" },
                new() { Name = "Fast Learning" },
                new() { Name = "Time Management" },
                new() { Name = "Leadership" },
                new() { Name = "Decision-Making" }
            },
            Interests = new List<Interest>
            {
                new() { Name = "Continuous learning" },
                new() { Name = "Exploring new technologies" },
                new() { Name = "Football" },
                new() { Name = "Gym" },
                new() { Name = "Traveling" }
            }
        };

        _context.Profiles.Add(profile);
        await _context.SaveChangesAsync();
    }
}
