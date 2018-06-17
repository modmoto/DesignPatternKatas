using System;
using System.Collections.Generic;

namespace State.Contracts
{
    public interface IUserState
    {
        IUserState Publish(string postToPublish);
        IUserState Ban();
        IUserState Downgrade();
        IUserState Upgrade();
        IUserState PinPost(int id);

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