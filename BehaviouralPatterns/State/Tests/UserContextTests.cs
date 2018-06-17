using System.Linq;
using State.Users;
using Xunit;

namespace State.Tests
{
    public class UserContextTests
    {
        [Fact]
        public void ContextAddPost()
        {
            var userData = UserData.Create("Peter");
            var administrator = new AdministratorState(userData);

            var userContext = new UserContext(administrator);

            userContext.Publish("new Post");

            Assert.Equal("new Post", userContext.Posts.Single());
        }
    }
}