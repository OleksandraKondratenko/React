using StudyProject.Doman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.BLL
{
    public interface IUsesrService
    {
        public Task<List<Users>> GetAllUsers();
        public Task AddUser(Users user);
        public Task UpdateUser(List<Users> users);
    }
}
