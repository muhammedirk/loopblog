using LoopBlog.Data.Models;
using System.Collections.Generic;

namespace LoopBlog.Models.AdminViewModels {
    public class IndexViewModel {
        public IEnumerable<Post> Posts { get; set; }
    }
}