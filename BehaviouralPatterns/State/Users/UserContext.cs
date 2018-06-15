using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class UserContext
    {
        public IUser UserState { get; private set; }
        public IEnumerable<string> Posts => UserState.Posts;
        public int PinnedPost => UserState.PinnedPost;
        public string Name => UserState.Name;

        public UserContext(IUser userState)
        {
            UserState = userState;
        }

        public void Publish(string postToPublish)
        {
            UserState = UserState.Publish(postToPublish);
        }

        public void Downgrade()
        {
            UserState = UserState.Downgrade();
        }

        public void Upgrade()
        {
            UserState = UserState.Upgrade();
        }

        public void PinPost(int id)
        {
            UserState = UserState.PinPost(id);
        }

        public void Ban()
        {
            UserState = UserState.Ban();
        }

    }
}