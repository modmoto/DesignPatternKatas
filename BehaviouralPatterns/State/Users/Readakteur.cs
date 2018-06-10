using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class Readakteur : IUser
    {
        private readonly IUserData _userData;

        public Readakteur(IUserData data)
        {
            _userData = data;
        }

        public IUser Publish(string postToPublish)
        {
            return new Readakteur(_userData.AddPost(postToPublish));
        }

        public IUser Ban()
        {
            return new BannedUser(_userData);
        }

        public IUser Degrade()
        {
            return new ReadOnlyUser(_userData);
        }

        public IUser Upgrade()
        {
            return new Administrator(_userData);
        }

        public IUser PinPost(int id)
        {
            return new Readakteur(_userData.PinPost(id));
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public string PinnedPost => _userData.Posts.ToList()[_userData.PinnedPost];
        public string Name => _userData.Name;
    }
}