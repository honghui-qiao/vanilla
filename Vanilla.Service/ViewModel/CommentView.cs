using System;
using System.Collections.Generic;

namespace Vanilla.Service.ViewModel
{
    public class CommentView
    {
        public CommentView()
        {
            ChildComments = new List<CommentView>();
        }

        public int ItemId { get; set; }
        public int Id { get; set; }
        public int? ParentCommentId { get; set; }
        public string Body { get; set; }
        public DateTime AddedDate { get; set; }

        public CommentView ParentComment { get; set; }
        public IList<CommentView> ChildComments { get; set; }
    }
}
