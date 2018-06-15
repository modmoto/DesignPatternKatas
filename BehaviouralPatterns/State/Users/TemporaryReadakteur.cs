
using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class TemporaryReadakteur : IUser
    {
        private readonly UserData _userData;
        private int _freePosts;

        public TemporaryReadakteur(UserData data)
        {
            _userData = data;
            _freePosts = 3;
        }

        private TemporaryReadakteur(UserData data, int freePosts)
        {
            _userData = data;
            _freePosts = freePosts;
        }

        public IUser Publish(string postToPublish)
        {
            if (_freePosts > 1)
            {
                return new TemporaryReadakteur(_userData.AddPost(postToPublish), _freePosts --);
            }

            return new ReadOnlyUser(_userData.AddPost(postToPublish));
        }

        public IUser Ban()
        {
            return new BannedUser(_userData);
        }

        public IUser Downgrade()
        {
            return new ReadOnlyUser(_userData);
        }

        public IUser Upgrade()
        {
            return new Readakteur(_userData);
        }

        public IUser PinPost(int id)
        {
            return new TemporaryReadakteur(_userData.PinPost(id), _freePosts);
        }

        public IEnumerable<string> Posts => _userData.Posts;
        public int PinnedPost  => _userData.PinnedPost;
        public string Name => _userData.Name;
    }
}