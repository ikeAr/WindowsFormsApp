using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [Collection("WinFormUser")]
    public class UserModel : DomainModel
    {
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Gender { get; set; }
        public string Team { get; set; }
        public string GitHub { get; set; }
    }

}
