using Insight.Database;
using StudyProject.Doman;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace StudyProject.DAL
{
    public class UsersRepository: IUserRepository
    {
        private readonly IUserRepository _userRepository;
        public IDbConnection _dBConnection { get; }

        public UsersRepository(IDbConnection dbConnection)
        {
            _dBConnection = dbConnection;
            _userRepository = dbConnection.As<IUserRepository>();
        }

        public async Task<List<Users>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();
            return users;
        }

        public async Task AddUser(Users user)
        {
            await _userRepository.AddUser(user);
        }

        public async Task UpdateUser(Users user)
        {
            await _userRepository.UpdateUser(user);
        }
    }
}
