using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class ReadOnlyUser : IUser
    {
        private readonly UserData _userData;

        public ReadOnlyUser(UserData data)
        {
            _userData = data;
        }

        public IUser Publish(string postToPublish)
        {
            throw new UserCanNotPublishPostsException();
        }

        public IUser Ban()
        {
            return new BannedUser(_userData);
        }

        public IUser Degrade()
        {
            return this;
        }

        public IUser Upgrade()
        {
            return new Readakteur(_userData);
        }

        public IUser PinPost(int id)
        {
            return new Administrator(_userData.PinPost(id));
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public int PinnedPost  => _userData.PinnedPost;
        public string Name => _userData.Name;
    }
}