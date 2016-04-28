using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Vanilla.Model;

namespace Vanilla.Repository.EF.Mapping
{
    public class ItemMap : EntityTypeConfiguration<Item>
    {
        public ItemMap()
        {
            ToTable("Item");

            HasKey(c => c.Id)
                .Property(c => c.Id)
                .HasColumnName("ItemId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Title).IsRequired().HasMaxLength(256);
            Property(c => c.Description).HasMaxLength(256);
            Property(c => c.AddedDate).IsOptional();
            Property(c => c.ModifiedDate).IsOptional();

            HasRequired(c => c.Folder)
                .WithMany(c => c.Items)
                .HasForeignKey(c => c.FolderId);
        }
    }
}
