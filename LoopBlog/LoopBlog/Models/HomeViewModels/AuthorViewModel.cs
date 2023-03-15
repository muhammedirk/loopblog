using PagedList.Core;
using LoopBlog.Data.Models;

namespace LoopBlog.Models.HomeViewModels {
    public class AuthorViewModel {
        public ApplicationUser Author { get; set; }
        public IPagedList<Post> Posts { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}