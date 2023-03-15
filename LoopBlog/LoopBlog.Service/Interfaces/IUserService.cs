using LoopBlog.Data.Models;
using System.Threading.Tasks;

namespace LoopBlog.Service.Interfaces {
    public interface IUserService {
        ApplicationUser Get(string id);
        Task<ApplicationUser> Update(ApplicationUser applicationUser);
    }
}