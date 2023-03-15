using Microsoft.AspNetCore.Mvc;
using LoopBlog.Models.HomeViewModels;

namespace LoopBlog.BusinessManagers.Interfaces {
    public interface IHomeBusinessManager {
        ActionResult<AuthorViewModel> GetAuthorViewModel(string authorId, string searchString, int? page);
    }
}