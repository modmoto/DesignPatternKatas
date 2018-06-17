using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class ReadOnlyUserState : IUserState
    {
        private readonly UserData _userData;

        public ReadOnlyUserState(UserData data)
        {
            _userData = data;
        }

        public IUserState Publish(string postToPublish)
        {
            throw new UserCanNotPublishPostsException();
        }

        public IUserState Ban()
        {
            return new BannedUserState(_userData);
        }

        public IUserState Downgrade()
        {
            return new ReadOnlyUserState(_userData);
        }

        public IUserState Upgrade()
        {
            return new TemporaryReadakteurState(_userData);
        }

        public IUserState PinPost(int id)
        {
            throw new UserCanNotPinPostsException();
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public int PinnedPost  => _userData.PinnedPost;
        public string Name => _userData.Name;
    }
}