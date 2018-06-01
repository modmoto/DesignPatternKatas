using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class UserData : IUserData
    {
        private UserData(string name, IEnumerable<string> posts)
        {
            Name = name;
            Posts = posts;
        }

        public static UserData Create(string name)
        {
            return new UserData(name, new List<string>());
        }

        public IUserData SetName(string newName)
        {
            return new UserData(newName, Posts);
        }

        public IUserData AddPost(string newPost)
        {
            var list = Posts.ToList();
            list.Add(newPost);
            return new UserData(Name, list);
        }

        public IEnumerable<string> Posts { get; }
        public string Name { get; }
    }
}