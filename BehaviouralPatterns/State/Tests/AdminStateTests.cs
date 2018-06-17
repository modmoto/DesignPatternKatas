using State.Contracts;
using State.Users;
using Xunit;

namespace State.Tests
{
    public class AdminStateTests
    {
        [Fact]
        public void AdminBan()
        {
            var userData = UserData.Create("Peter");
            var administrator = new AdministratorState(userData);
            Assert.Throws<AdministratorCanNotBeBannedException>(() => administrator.Ban());
        }

        [Fact]
        public void AdminDownGrade()
        {
            var userData = UserData.Create("Peter");
            var administrator = new AdministratorState(userData);
            var user = administrator.Downgrade();
            Assert.Equal(user.GetType(), typeof(ReadakteurState));
        }

        [Fact]
        public void AdminUpGrade()
        {
            var userData = UserData.Create("Peter");
            var administrator = new AdministratorState(userData);
            var user = administrator.Upgrade();
            Assert.Equal(user.GetType(), typeof(AdministratorState));
        }

        [Fact]
        public void AdminPinPost()
        {
            var userData = UserData.Create("Peter").AddPost("Post1").AddPost("Post2");
            var administrator = new AdministratorState(userData);
            var user = administrator.PinPost(1);
            Assert.Equal(1, user.PinnedPost);
        }
    }
}