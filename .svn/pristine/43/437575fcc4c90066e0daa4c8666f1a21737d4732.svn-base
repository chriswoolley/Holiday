using HolidayWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolidayWeb.Core
{
    public class ApplicationUserManager : UserManager<HolidayUser>
    {
        public ApplicationUserManager(IUserStore<HolidayUser> store, IOptions<Microsoft.AspNetCore.Identity.IdentityOptions> optionsAccessor, IPasswordHasher<HolidayUser> passwordHasher,
            IEnumerable<IUserValidator<HolidayUser>> userValidators, IEnumerable<IPasswordValidator<HolidayUser>> passwordValidators, ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<HolidayUser>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger) { }

        public override Task<HolidayUser> FindByIdAsync(string userId)
        {
            return Users.Include(c => c.Department).Include(c => c.DepartmentManager).FirstOrDefaultAsync(u => u.Id == userId);
        }
    }
}