using CAPSPOL.API.Data;
using CAPSPOL.API.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAPSPOL.API.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DataContext _context;



        public UserHelper(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, DataContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;

        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            //TODO: [_userManager.CreateAsync] te devuelve una tarea si esta paso sin ningun error entonces la propiedad Succeeded es Verdadero de lo contrario False
            //var resultado = await _userManager.CreateAsync(user, password);
            //return resultado;
            return await _userManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
            }
        }

        public async Task<User> GetUserAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> IUserInRoleAsync(User user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }

    }
}
