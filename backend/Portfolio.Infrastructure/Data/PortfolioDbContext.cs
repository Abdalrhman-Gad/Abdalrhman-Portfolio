namespace Portfolio.Infrastructure.Data;

using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Entities.Education;
using Portfolio.Domain.Entities.Experience;
using Portfolio.Domain.Entities.ProfileAggregate;
using Portfolio.Domain.Entities.Projects;
using Portfolio.Domain.Entities.Skills;

public class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
        : base(options)
    {
    }

    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<Link> Links => Set<Link>();
    public DbSet<SkillGroup> SkillGroups => Set<SkillGroup>();
    public DbSet<Skill> Skills => Set<Skill>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<ProjectTech> ProjectTech => Set<ProjectTech>();
    public DbSet<Experience> Experiences => Set<Experience>();
    public DbSet<ExperienceBullet> ExperienceBullets => Set<ExperienceBullet>();
    public DbSet<ExperienceTech> ExperienceTech => Set<ExperienceTech>();
    public DbSet<Education> Education => Set<Education>();
    public DbSet<EducationDetail> EducationDetails => Set<EducationDetail>();
    public DbSet<EducationLink> EducationLinks => Set<EducationLink>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<SoftSkill> SoftSkills => Set<SoftSkill>();
    public DbSet<Interest> Interests => Set<Interest>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProjectTech>()
            .HasOne(tech => tech.Project)
            .WithMany(project => project.Tech)
            .HasForeignKey(tech => tech.ProjectId);

        modelBuilder.Entity<ExperienceBullet>()
            .HasOne(bullet => bullet.Experience)
            .WithMany(experience => experience.Bullets)
            .HasForeignKey(bullet => bullet.ExperienceId);

        modelBuilder.Entity<ExperienceTech>()
            .HasOne(tech => tech.Experience)
            .WithMany(experience => experience.Tech)
            .HasForeignKey(tech => tech.ExperienceId);

        modelBuilder.Entity<EducationDetail>()
            .HasOne(detail => detail.Education)
            .WithMany(education => education.Details)
            .HasForeignKey(detail => detail.EducationId);

        modelBuilder.Entity<EducationLink>()
            .HasOne(link => link.Education)
            .WithMany(education => education.Links)
            .HasForeignKey(link => link.EducationId);

        modelBuilder.Entity<Skill>()
            .HasOne(skill => skill.SkillGroup)
            .WithMany(group => group.Skills)
            .HasForeignKey(skill => skill.SkillGroupId);
    }
}
