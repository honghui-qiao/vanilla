using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Vanilla.Model;

namespace Vanilla.Repository.EF.Mapping
{
    public class FolderMap : EntityTypeConfiguration<Folder>
    {
        public FolderMap()
        {
            ToTable("Folder");

            HasKey(c => c.Id)
                .Property(c => c.Id)
                .HasColumnName("FolderId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.FolderName).IsRequired().HasMaxLength(256);
            Property(c => c.Description).HasMaxLength(256);
            Property(c => c.AddedDate);
            Property(c => c.ModifiedDate);

            HasOptional(c => c.ParentFolder)
                .WithMany(c => c.ChildFolders)
                .HasForeignKey(c => c.ParentFolderId);

            HasRequired(c => c.Project)
                .WithMany(c => c.Folders)
                .HasForeignKey(c => c.ProjectId);
        }
    }
}
