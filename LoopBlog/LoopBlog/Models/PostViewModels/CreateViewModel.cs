using Microsoft.AspNetCore.Http;

using LoopBlog.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace LoopBlog.Models.PostViewModels {
    public class CreateViewModel {
        //post oluştururken kullanılacak resim için formfile kullanıldı ve içeriği posttan çekmesi (datadaki post) için post tipinde değişken verildi
        [Required, Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}