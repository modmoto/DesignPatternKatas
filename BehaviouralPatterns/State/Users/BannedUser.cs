using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class BannedUser : IUser
    {
        private readonly IUserData _userData;

        public BannedUser(IUserData userData)
        {
            _userData = userData;
        }

        public IUser Publish(string postToPublish)
        {
            throw new UserCanNotPublishException();
        }

        public IUser Ban()
        {
            return this;
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
            throw new UserCanNotPinPostsException();
        }

        public IEnumerable<string> Posts => new List<string>();
        public int PinnedPost  => 0;
        public string Name => "BannedUser";
    }
}