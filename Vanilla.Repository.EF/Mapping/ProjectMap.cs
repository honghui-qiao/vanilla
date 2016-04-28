using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Vanilla.Model;

namespace Vanilla.Repository.EF.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            ToTable("Project");

            HasKey(c => c.Id)
                .Property(c => c.Id)
                .HasColumnName("ProjectId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasOptional(c => c.ParentProject)
                .WithMany(c => c.ChildProjects)
                .HasForeignKey(c => c.ParentProjectId);

            Property(c => c.ProjectName)
                .IsRequired()
                .HasMaxLength(256);

            Property(c => c.Description)
                .HasMaxLength(256);
        }
    }
}
