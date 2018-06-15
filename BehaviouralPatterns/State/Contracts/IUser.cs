using System;
using System.Collections.Generic;

namespace State.Contracts
{
    public interface IUser
    {
        IUser Publish(string postToPublish);
        IUser Ban();
        IUser Downgrade();
        IUser Upgrade();
        IUser PinPost(int id);

        IEnumerable<string> Posts { get; }
        int PinnedPost { get; }
        string Name { get; }
    }

    public class UserCanNotPublishException : Exception
    {
    }

    public class UserCanNotPublishPostsException : Exception
    {
    }

    public class AdministratorCanNotBeBannedException : Exception
    {
    }

    public class AdministratorCanNotBeDisabledException : Exception
    {
    }

    public class UserCanNotPinPostsException : Exception
    {
    }
}