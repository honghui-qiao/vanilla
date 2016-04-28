using Vanilla.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vanilla.Repository.EF.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            ToTable("Comment");

            HasKey(c => c.Id)
                .Property(c => c.Id)
                .HasColumnName("CommentId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Body).IsRequired().HasMaxLength(256);
            Property(c => c.AddedDate).IsOptional();

            HasOptional(c => c.ParentComment)
                .WithMany(c => c.ChildComments)
                .HasForeignKey(c => c.ParentCommentId);

            HasRequired(c => c.Item)
                .WithMany(c => c.Comments)
                .HasForeignKey(c => c.ItemId);
        }
    }
}
