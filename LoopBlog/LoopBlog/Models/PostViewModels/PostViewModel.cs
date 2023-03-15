using LoopBlog.Data.Models;

namespace LoopBlog.Models.PostViewModels {
    public class PostViewModel {
        public Post Post { get; set; }
        public Comment Comment { get; set; }
    }
}