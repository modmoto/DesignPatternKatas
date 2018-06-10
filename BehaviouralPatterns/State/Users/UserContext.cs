using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class UserContext
    {
        public IUser UserState { get; private set; }

        public UserContext(IUser userState)
        {
            UserState = userState;
        }

        public void Publish(string postToPublish)
        {
            UserState = UserState.Publish(postToPublish);
        }

        public void Ban()
        {
            UserState = UserState.Ban();
        }

        public IEnumerable<string> Posts => UserState.Posts;
        public string Name => UserState.Name;
    }
}