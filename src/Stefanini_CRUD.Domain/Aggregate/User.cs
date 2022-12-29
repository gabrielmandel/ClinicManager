using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stefanini_CRUD.Domain.Aggregate
{
    public class User
    {
        public User(string username, byte[] passwordHash, byte[] passwordSalt)
        {
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }

        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        public static User Create(string username, byte[] passwordHash, byte[] passwordSalt)
        {
            return new User(username,passwordHash,passwordSalt);
        }
    }
}