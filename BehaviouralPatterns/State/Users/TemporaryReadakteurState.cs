
using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class TemporaryReadakteurState : IUserState
    {
        private readonly UserData _userData;
        private int _freePosts;

        public TemporaryReadakteurState(UserData data)
        {
            _userData = data;
            _freePosts = 3;
        }

        private TemporaryReadakteurState(UserData data, int freePosts)
        {
            _userData = data;
            _freePosts = freePosts;
        }

        public IUserState Publish(string postToPublish)
        {
            if (_freePosts > 1)
            {
                return new TemporaryReadakteurState(_userData.AddPost(postToPublish), _freePosts --);
            }

            return new ReadOnlyUserState(_userData.AddPost(postToPublish));
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
            return new ReadakteurState(_userData);
        }

        public IUserState PinPost(int id)
        {
            return new TemporaryReadakteurState(_userData.PinPost(id), _freePosts);
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public int PinnedPost  => _userData.PinnedPost;
        public string Name => _userData.Name;
    }
}