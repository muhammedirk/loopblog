﻿using LoopBlog.Data;
using LoopBlog.Data.Models;
using LoopBlog.Service.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace LoopBlog.Service {
    public class UserService : IUserService {
        private readonly ApplicationDbContext applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }

        public ApplicationUser Get(string id) {
            return applicationDbContext.Users
                .FirstOrDefault(user => user.Id == id);
        }

        public async Task<ApplicationUser> Update(ApplicationUser applicationUser) {
            applicationDbContext.Update(applicationUser);
            await applicationDbContext.SaveChangesAsync();
            return applicationUser;
        }
    }
}