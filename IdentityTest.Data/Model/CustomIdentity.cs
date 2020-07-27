using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityTest.Data.Model
{
    public class CustomIdentity : IdentityUser<Guid>
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }

        public string CustomTag { get; set; }
    }
}
