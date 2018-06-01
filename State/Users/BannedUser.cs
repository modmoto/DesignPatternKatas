using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class BannedUser : IUser
    {
        private readonly IUserData _state;

        public BannedUser(IUserData state)
        {
            _state = state;
        }

        public IUser Publish(string postToPublish)
        {
            throw new UserIsBannedException();
        }

        public IUser Ban()
        {
            return this;
        }

        public IEnumerable<string> Posts => new List<string>();
        public string Name => "BannedUser";
    }
}