using System.Data.Entity;
using Vanilla.Model;
using Vanilla.Repository.EF.Mapping;

namespace Vanilla.Repository.EF
{
    public class VanillaContext : DbContext
    {
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Project> Projects { get; set; }

        public VanillaContext()
            : base("name=VanillaConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new FolderMap());
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new ProjectMap());
        }
    }
}
