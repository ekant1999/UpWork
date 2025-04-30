using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UpWork.Core.Entities.Identity;
using UpWork.Core.Entities.Skills;
using UpWork.Core.Entities.Jobs;
using UpWork.Core.Entities.Proposals;
using UpWork.Core.Entities.Contracts;
using UpWork.Core.Entities.Payments;
using UpWork.Core.Entities.Notifications;
using UpWork.Core.Entities.Communication;
using UpWork.Core.Entities.Disputes;
using UpWork.Core.Entities.Job;

namespace UpWork.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Identity
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ClientUser> ClientUsers { get; set; }
        public DbSet<FreelancerUser> FreelancerUsers { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        // Skills
        public DbSet<Skill> Skills { get; set; }
        public DbSet<FreelancerSkill> FreelancerSkills { get; set; }

        // Jobs
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobSkill> JobSkills { get; set; }
        public DbSet<SavedJob> SavedJobs { get; set; }

        // Proposals
        public DbSet<Proposal> Proposals { get; set; }

        // Contracts
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Dispute> Disputes { get; set; }

        // Payments
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        // Messaging
        public DbSet<ChatRoom> ChatRooms { get; set; }
        public DbSet<ChatRoomUser> ChatRoomUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<FileAttachment> FileAttachments { get; set; }

        // Notifications
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationPreference> NotificationPreferences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Composite Keys
            modelBuilder.Entity<JobSkill>().HasKey(js => new { js.JobId, js.SkillId });
            modelBuilder.Entity<FreelancerSkill>().HasKey(fs => new { fs.FreelancerId, fs.SkillId });
            modelBuilder.Entity<SavedJob>().HasKey(sj => new { sj.UserId, sj.JobId });
            modelBuilder.Entity<ChatRoomUser>().HasKey(cru => new { cru.ChatRoomId, cru.UserId });

            // ApplicationUser → ClientUser / FreelancerUser (1:1)
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.ClientUser)
                .WithOne(c => c.User)
                .HasForeignKey<ClientUser>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.FreelancerUser)
                .WithOne(f => f.User)
                .HasForeignKey<FreelancerUser>(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // ApplicationUser → Related Entities
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.SavedJobs)
                .WithOne(sj => sj.User)
                .HasForeignKey(sj => sj.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.RefreshTokens)
                .WithOne(rt => rt.User)
                .HasForeignKey(rt => rt.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.MessagesSent)
                .WithOne(m => m.Sender)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Notifications)
                .WithOne(n => n.User)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.NotificationPreferences)
                .WithOne(np => np.User)
                .HasForeignKey(np => np.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // ClientUser
            modelBuilder.Entity<ClientUser>()
                .HasMany(c => c.Jobs)
                .WithOne(j => j.Client)
                .HasForeignKey(j => j.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClientUser>()
                .HasMany(c => c.Contracts)
                .WithOne(cn => cn.ClientUser)
                .HasForeignKey(cn => cn.ClientUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // FreelancerUser
            modelBuilder.Entity<FreelancerUser>()
                .HasMany(f => f.Proposals)
                .WithOne(p => p.FreelancerUser)
                .HasForeignKey(p => p.FreelancerUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FreelancerUser>()
                .HasMany(f => f.Contracts)
                .WithOne(cn => cn.FreelancerUser)
                .HasForeignKey(cn => cn.FreelancerUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FreelancerUser>()
                .HasMany(f => f.Skills)
                .WithOne(fs => fs.FreelancerUser)
                .HasForeignKey(fs => fs.FreelancerId)
                .OnDelete(DeleteBehavior.Cascade);

            // FreelancerSkill ↔ Skill
            modelBuilder.Entity<FreelancerSkill>()
                .HasOne(fs => fs.Skill)
                .WithMany(s => s.FreelancerSkills)
                .HasForeignKey(fs => fs.SkillId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
