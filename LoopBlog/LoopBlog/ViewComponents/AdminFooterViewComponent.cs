using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoopBlog.ViewComponents {
    public class AdminFooterViewComponent : ViewComponent {
        public async Task<IViewComponentResult> InvokeAsync() {
            return await Task.Factory.StartNew(() => { return View(); });//components içinde bulunan default görünümleri çağırması için oluşturuldu 
        }
    }
}