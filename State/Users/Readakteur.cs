using System.Collections.Generic;
using State.Contracts;

namespace State.Users
{
    public class Readakteur : IUser
    {
        private readonly IUserData _state;

        public Readakteur(IUserData data)
        {
            _state = data;
        }

        public IUser Publish(string postToPublish)
        {
            return new Readakteur(_state.AddPost(postToPublish));
        }

        public IUser Ban()
        {
            return new BannedUser(_state);
        }

        public IEnumerable<string> Posts => _state.Posts;
        public string Name => _state.Name;
    }
}