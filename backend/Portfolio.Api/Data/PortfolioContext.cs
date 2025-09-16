using Microsoft.EntityFrameworkCore;
using Portfolio.Api.Models;

namespace Portfolio.Api.Data;

public class PortfolioContext : DbContext
{
    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
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
            .HasOne(t => t.Project)
            .WithMany(p => p.Tech)
            .HasForeignKey(t => t.ProjectId);

        modelBuilder.Entity<ExperienceBullet>()
            .HasOne(b => b.Experience)
            .WithMany(e => e.Bullets)
            .HasForeignKey(b => b.ExperienceId);

        modelBuilder.Entity<ExperienceTech>()
            .HasOne(t => t.Experience)
            .WithMany(e => e.Tech)
            .HasForeignKey(t => t.ExperienceId);

        modelBuilder.Entity<EducationDetail>()
            .HasOne(d => d.Education)
            .WithMany(e => e.Details)
            .HasForeignKey(d => d.EducationId);

        modelBuilder.Entity<EducationLink>()
            .HasOne(l => l.Education)
            .WithMany(e => e.Links)
            .HasForeignKey(l => l.EducationId);

        modelBuilder.Entity<Skill>()
            .HasOne(s => s.SkillGroup)
            .WithMany(g => g.Skills)
            .HasForeignKey(s => s.SkillGroupId);
    }
}
