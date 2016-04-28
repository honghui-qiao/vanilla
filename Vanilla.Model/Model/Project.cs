using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Model
{
    public class Project : EntityBase<int>, IAggregateRoot
    {
        public Project()
        {
            ChildProjects = new List<Project>();
            Items = new List<Item>();
            Folders = new List<Folder>();
        }

        public int? ParentProjectId { get; set; }

        public string ProjectName { get; set; }
        public string Description { get; set; }

        public Project ParentProject { get; set; }

        public IList<Project> ChildProjects { get; set; }
        public IList<Item> Items { get; set; }
        public IList<Folder> Folders { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
