using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FE_FinalProject.Models;

namespace FE_FinalProject.Services
{
    public class ProfileService : IProfileService
    {
        private readonly ApplicationDbContext db;

        public ProfileService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Profile GetProfileById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            throw new NotImplementedException();
        }

        public void EditProfile(Profile profile)
        {
            throw new NotImplementedException();
        }
    }
}
