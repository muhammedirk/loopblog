﻿using Microsoft.AspNetCore.Http;
using LoopBlog.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace LoopBlog.Models.PostViewModels {
    public class EditViewModel {
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}