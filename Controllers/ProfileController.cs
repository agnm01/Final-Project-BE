using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FE_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FE_FinalProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProfileController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Profile GetProfileById(string id)
        {
            if (id == null || id == string.Empty)
            {
                return null;
            }

            var profile = this.db.Profile.First(p => p.Id == id);

            if (profile == null)
            {
                return null;
            }

            return profile;
        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            var profiles = this.db.Profile.ToArray();

            if (profiles == null)
            {
                return null;
            }

            return profiles;
        }

        public Profile EditProfile([FromBody] Profile profile)
        {
            if (profile == null)
            {
                return null;
            }

            var dbProfile = this.db.Profile.First(p => p.Id == profile.Id);

            if (dbProfile != null)
            {
                dbProfile.Phone = profile.Phone;
                this.db.Profile.Update(dbProfile);
                this.db.SaveChanges();
            }

            return dbProfile;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
