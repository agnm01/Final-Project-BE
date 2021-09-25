using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FE_FinalProject.Models;

namespace FE_FinalProject.Services
{
    public interface IProfileService
    {
        Profile GetProfileById(string id);

        IEnumerable<Profile> GetAllProfiles();

        void EditProfile(Profile profile);
    }
}
