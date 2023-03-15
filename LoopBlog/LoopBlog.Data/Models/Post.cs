using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoopBlog.Data.Models {
    public class Post {
        public int Id { get; set; }
        public ApplicationUser Creator { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Published { get; set; }// yayınlamak ister yada istemez diye

        public bool Approved { get; set; }// onaylanması gerekenler için // iptal edildi ama yapıının bozulmaması için tutuluyor
        // üst rol eklendiği zaman çektiği veriler ile çakışma yaşanıyor ve erişim izni hatası veriyor
        public ApplicationUser Approver { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }// 1 den fazla yorum yapılabilmesi için
    }
}