using Microsoft.AspNetCore.Mvc;
using LoopBlog.Data.Models;
using LoopBlog.Models.HomeViewModels;
using LoopBlog.Models.PostViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LoopBlog.BusinessManagers.Interfaces {
    public interface IPostBusinessManager {

        // kullanılacak task lar yazılacak
        IndexViewModel GetIndexViewModel(string searchString, int? page);
        Task<ActionResult<PostViewModel>> GetPostViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<Post> CreatePost(CreateViewModel createViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<Comment>> CreateComment(PostViewModel postViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdatePost(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
    }
}