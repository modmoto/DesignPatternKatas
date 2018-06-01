using System;
using System.Collections.Generic;

namespace State.Contracts
{
    public interface IUser
    {
        IUser Publish(string postToPublish);
        IUser Ban();

        IEnumerable<string> Posts { get; }
        string Name { get; }
    }

    public class UserIsBannedException : Exception
    {
    }

    public class UserCanNotPublishPostsException : Exception
    {
    }
}