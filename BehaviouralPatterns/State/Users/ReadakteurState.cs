using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class ReadakteurState : IUserState
    {
        private readonly UserData _userData;

        public ReadakteurState(UserData data)
        {
            _userData = data;
        }

        public IUserState Publish(string postToPublish)
        {
            return new ReadakteurState(_userData.AddPost(postToPublish));
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
            return new ReadakteurState(_userData.PinPost(id));
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public int PinnedPost  => _userData.PinnedPost;
        public string Name => _userData.Name;
    }
}