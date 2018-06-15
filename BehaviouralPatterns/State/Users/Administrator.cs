using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class Administrator : IUser
    {
        private readonly UserData _userData;

        public Administrator(UserData userData)
        {
            _userData = userData;
        }

        public IUser Publish(string postToPublish)
        {
            return new Administrator(_userData.AddPost(postToPublish));
        }

        public IUser Ban()
        {
            throw new AdministratorCanNotBeBannedException();
        }

        public IUser Downgrade()
        {
            throw new AdministratorCanNotBeDisabledException();
        }

        public IUser Upgrade()
        {
            return new Administrator(_userData);
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