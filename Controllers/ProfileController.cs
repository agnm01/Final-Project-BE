using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FE_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public Profile GetProfileById(string username)
        {
            if (username == null || username == string.Empty)
            {
                return null;
            }

            var profile = this.db.Profile
                          .Include(p => p.Skills)
                          .Include(p => p.Schools)
                          .Include(p => p.Workplaces)
                          .Include(p => p.Tools)
                          .First(p => p.Username == username);
            if (profile == null)
            {
                return null;
            }

            return profile;
        }

        public Profile Login(string username, string password)
        {
            if (username == null || username == string.Empty || password == null || password == string.Empty)
            {
                return null;
            }

            var profile = this.db.Profile
                          .Include(p => p.Skills)
                          .Include(p => p.Schools)
                          .Include(p => p.Workplaces)
                          .Include(p => p.Tools)
                          .Where(p => p.Username == username && p.Password == password).FirstOrDefault();
            if (profile == null)
            {
                return null;
            }

            return profile;
        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            var profiles = this.db.Profile
                           .Include(p => p.Skills)
                           .Include(p => p.Schools)
                           .Include(p => p.Workplaces)
                           .Include(p => p.Tools)
                           .ToArray();

            if (profiles == null)
            {
                return null;
            }

            return profiles;
        }
        //[HttpPut]
        //public Profile EditProfile([FromBody] Profile profile)
        //{
        //    if (profile == null)
        //    {
        //        return null;
        //    }

        //    var dbProfile = this.db.Profile.First(p => p.Username == profile.Username);

        //    if (dbProfile != null)
        //    {
        //        dbProfile.Phone = profile.Phone;
        //        this.db.Profile.Update(dbProfile);
        //        this.db.SaveChanges();
        //    }

        //    return dbProfile;
        //}

        [HttpPut]
        public Profile EditAbout(string username, string title, string description, DateTime birthdate, string universityName, string phone, string city, string state, int age, string degree, string email, string website)
        {
            var dbProfile = this.db.Profile.Include(p => p.Schools).First(p => p.Username == username);

            if (dbProfile != null)
            {
                dbProfile.Title = title;
                dbProfile.Description = description;
                dbProfile.Birthdate = birthdate;
                dbProfile.Schools.First().Name = universityName;
                dbProfile.Phone = phone;
                dbProfile.City = city;
                dbProfile.State = state;
                dbProfile.Age = age;
                dbProfile.Degree = degree;
                dbProfile.Email = email;
                dbProfile.Website = website;

                this.db.Profile.Update(dbProfile);
                this.db.SaveChanges();
            }

            return dbProfile;
        }

        [HttpPut]
        public Profile EditSkills(string username, string skillName, int level)
        {
            var dbProfile = this.db.Profile.Include(p => p.Skills).First(p => p.Username == username);

            if (dbProfile != null)
            {
                var dbSkill = dbProfile.Skills.First(p => p.Name == skillName);
                if (dbSkill != null)
                {
                    dbSkill.Level = level;

                    this.db.Skill.Update(dbSkill);
                    this.db.SaveChanges();
                }
            }

            return dbProfile;
        }

        [HttpPut]
        public Profile EditSchool(string username, string schoolName, string schoolPeriod, string specialization, string description)
        {
            var dbProfile = this.db.Profile.Include(p => p.Schools).First(p => p.Username == username);

            if (dbProfile != null)
            {
                foreach (School s in dbProfile.Schools)
                {
                    s.Name = schoolName;
                    s.SchoolPeriod = schoolPeriod;
                    s.Specialization = specialization;
                    s.Description = description;
                }

                this.db.Profile.Update(dbProfile);
                this.db.SaveChanges();
            }

            return dbProfile;
        }

        [HttpPut]
        public Profile EditWorkplace(string username, string workplaceName, string workplacePeriod, string role, string description)
        {
            var dbProfile = this.db.Profile.Include(p => p.Workplaces).First(p => p.Username == username);

            if (dbProfile != null)
            {
                foreach (Workplace w in dbProfile.Workplaces)
                {
                    w.CompanyName = workplaceName;
                    w.WorkPeriod = workplacePeriod;
                    w.RoleName = role;
                    w.Description = description;
                }

                this.db.Profile.Update(dbProfile);
                this.db.SaveChanges();
            }

            return dbProfile;
        }

        [HttpPut]
        public Profile EditTools(string username, string toolName, string description)
        {
            var dbProfile = this.db.Profile.Include(p => p.Tools).First(p => p.Username == username);

            if (dbProfile != null)
            {
                var dbTool = dbProfile.Tools.First(p => p.Name == toolName);
                if (dbTool != null)
                {
                    dbTool.Name = toolName;
                    dbTool.Description = description;

                    this.db.Tool.Update(dbTool);
                    this.db.SaveChanges();
                }
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
