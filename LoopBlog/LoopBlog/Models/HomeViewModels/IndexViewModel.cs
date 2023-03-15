using PagedList.Core;
using LoopBlog.Data.Models;

namespace LoopBlog.Models.HomeViewModels {
    public class IndexViewModel {
        public IPagedList<Post> Posts { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}