using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab5
{
    internal class UserManager
    {
        private User[] users;

        public UserManager()
        {
            users = new User[10]
            {
                new User("dla6425", "임근혁", 24, UserCode.NORMAL, "dla6425@naver.com"),
                new User("gorloom6425", "김순돌", 30, UserCode.PREMIUM, "gorloom6425@naver.com"),
                new User("limkeunhak", "임근학", 28, UserCode.NORMAL, "limkeunhak@gmail.com"),
                new User("sunboy643", "배한성", 21, UserCode.NORMAL, "sunboy643@hanmail.com"),
                new User("wkdrudqo", "장경배", 20, UserCode.NORMAL, "jangcs@naver.com"),
                new User("jangcs6885", "장경임", 40, UserCode.BLACKLIST, "imimim@naver.com"),
                new User("soriori", "권소리", 24, UserCode.NORMAL, "sorisori@naver.com"),
                new User("changchang", "김창렬", 52, UserCode.PREMIUM, "lalala@naver.com"),
                new User("4uri", "사유리", 43, UserCode.NORMAL, "4uri@gmail.com"),
                new User("5dengtang", "오뎅탕", 61, UserCode.PREMIUM, "5dengtang@gmail.com")
            };
        }

        public User[] GetAllUsers()
        {
            return users;
        }

        public User[] GetUsers(UserCode type)
        {
            throw new NotImplementedException();
        }

        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(string id, User user)
        {
            throw new NotImplementedException();
        }
    }
}