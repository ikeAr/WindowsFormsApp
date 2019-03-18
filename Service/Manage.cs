using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class Manage
    {
        private Repo handler = new Repo();
        public void AddUser(UserModel user)
        {
            this.handler.Add(user);
        }
        public IEnumerable<UserModel> GetAllUser()
        {
            return this.handler.GetAll();
        }
        public void DeleteUser(string name)
        {
            this.handler.DeleteMany(x => x.Name == name);
        }
        public void UpdateUser(UserModel user)
        {
            this.handler.Update(user);
        }
        public UserModel FindUser(string name)
        {
            return this.handler.Get(x => x.Name == name);
        }
    }
}
