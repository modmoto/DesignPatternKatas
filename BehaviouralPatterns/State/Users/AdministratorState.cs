using System.Collections.Generic;
using System.Linq;
using State.Contracts;

namespace State.Users
{
    public class AdministratorState : IUserState
    {
        private readonly UserData _userData;

        public AdministratorState(UserData userData)
        {
            _userData = userData;
        }

        public IUserState Publish(string postToPublish)
        {
            return new AdministratorState(_userData.AddPost(postToPublish));
        }

        public IUserState Ban()
        {
            throw new AdministratorCanNotBeBannedException();
        }

        public IUserState Downgrade()
        {
            return new ReadakteurState(_userData);
        }

        public IUserState Upgrade()
        {
            return new AdministratorState(_userData);
        }

        public IUserState PinPost(int id)
        {
            return new AdministratorState(_userData.PinPost(id));
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public int PinnedPost  => _userData.PinnedPost;
        public string Name => _userData.Name;
    }
}