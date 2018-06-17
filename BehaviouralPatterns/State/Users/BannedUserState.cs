using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class BannedUserState : IUserState
    {
        private readonly UserData _userData;

        public BannedUserState(UserData userData)
        {
            _userData = userData;
        }

        public IUserState Publish(string postToPublish)
        {
            throw new UserCanNotPublishException();
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
            return new AdministratorState(_userData);
        }

        public IUserState PinPost(int id)
        {
            throw new UserCanNotPinPostsException();
        }

        public IEnumerable<string> Posts => new List<string>();
        public int PinnedPost  => 0;
        public string Name => "BannedUser";
    }
}