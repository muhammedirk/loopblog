using LoopBlog.Models.AdminViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LoopBlog.BusinessManagers.Interfaces {
    public interface IAdminBusinessManager {
        Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimsPrincipal);
        Task<AboutViewModel> GetAboutViewModel(ClaimsPrincipal claimsPrincipal);
        Task UpdateAbout(AboutViewModel aboutViewModel, ClaimsPrincipal claimsPrincipal);
    }
}