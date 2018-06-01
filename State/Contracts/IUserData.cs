using System.Collections.Generic;

namespace State.Contracts
{
    public interface IUserData
    {
        IUserData SetName(string newName);
        IUserData AddPost(string newPost);

        IEnumerable<string> Posts { get; }
        string Name { get; }
    }
}