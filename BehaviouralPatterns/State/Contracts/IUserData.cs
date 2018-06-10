using System.Collections.Generic;

namespace State.Contracts
{
    public interface IUserData
    {
        IUserData SetName(string newName);
        IUserData AddPost(string newPost);
        IUserData PinPost(int id);

        IEnumerable<string> Posts { get; }
        int PinnedPost { get; }
        string Name { get; }
    }
}