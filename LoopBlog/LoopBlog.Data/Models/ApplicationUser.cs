using Microsoft.AspNetCore.Identity;

namespace LoopBlog.Data.Models {
    public class ApplicationUser : IdentityUser {
        // kullanıcının özel dataları oluşturulacak
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        public string SubHeader { get; set; }
        public string AboutContent { get; set; }
    }
}