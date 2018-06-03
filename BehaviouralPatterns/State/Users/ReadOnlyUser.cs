using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class ReadOnlyUser : IUser
    {
        private readonly IUserData _state;

        public ReadOnlyUser(IUserData data)
        {
            _state = data;
        }

        public IUser Publish(string postToPublish)
        {
            throw new UserCanNotPublishPostsException();
        }

        public IUser Ban()
        {
            return new BannedUser(_state);
        }

        public IEnumerable<string> Posts => _state.Posts;
        public string Name => _state.Name;
    }
}