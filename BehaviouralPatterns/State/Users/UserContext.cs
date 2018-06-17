using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class UserContext
    {
        public IUserState UserStateState { get; private set; }
        public IEnumerable<string> Posts => UserStateState.Posts;
        public int PinnedPost => UserStateState.PinnedPost;
        public string Name => UserStateState.Name;

        public UserContext(IUserState userStateState)
        {
            UserStateState = userStateState;
        }

        public void Publish(string postToPublish)
        {
            UserStateState = UserStateState.Publish(postToPublish);
        }

        public void Downgrade()
        {
            UserStateState = UserStateState.Downgrade();
        }

        public void Upgrade()
        {
            UserStateState = UserStateState.Upgrade();
        }

        public void PinPost(int id)
        {
            UserStateState = UserStateState.PinPost(id);
        }

        public void Ban()
        {
            UserStateState = UserStateState.Ban();
        }

    }
}