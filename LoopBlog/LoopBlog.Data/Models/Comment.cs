using System;
using System.Collections.Generic;

namespace LoopBlog.Data.Models {
    public class Comment {
        public int Id { get; set; }

        public Post Post { get; set; }
        public ApplicationUser Author { get; set; }// yorum yazanın belirli olması için
        public string Content { get; set; }
        public Comment Parent { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }// yorumun yorumuda olabilir
    }
}