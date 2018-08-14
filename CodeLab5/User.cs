using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab5
{
    internal class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public UserCode UserCode { get; set; }
        public string Email { get; set; }

        public User(string userId, string name, int age, UserCode userCode, string email)
        {
            UserId = userId;
            Name = name;
            Age = age;
            UserCode = userCode;
            Email = email;
        }
    }

    public enum UserCode
    {
        NORMAL, PREMIUM, BLACKLIST
    }
}