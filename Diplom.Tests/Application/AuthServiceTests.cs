using Diplom.Application.Interfaces;
using Diplom.Application.Models.Requests;
using Diplom.Application.Services;
using Diplom.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Diplom.Tests.Application
{
    [ExcludeFromCodeCoverage]
    public class AuthServiceTests
    {
        [Fact]
        public void Login()
        {
            // arrange
           
            var diplomContextMock = new Mock<IDiplomContext>();
            diplomContextMock.Setup(context=>context.Users.FirstOrDefault()).Returns(GetTestUser());
            var userServiceMock = new Mock<IUserService>();
            userServiceMock.Setup(userService => userService.VerifyPasswordHash("12341234", GetTestUser().PasswordSalt, GetTestUser().PasswordHash)).Returns(true);
            var configuration = new Mock<IConfiguration>();
            configuration.Setup(conf => conf.GetSection("AppSettings:Token").Value).Returns("Test Secret Token For JWT");


            var authService = new AuthService(diplomContextMock.Object, userServiceMock.Object, configuration.Object);

            LoginRequest request = new() {UserName  = "Tom", Password = "password" };
            // act

            var result = authService.Login(request);


            //assert


            
        }
        private List<User> GetTestUsers()
        {
            var userService = new UserService();
            userService.CreatePasswordHash("12341234", out byte[] hash, out byte[] salt);
         

            var users = new List<User>
            {
                new User {UserName="Tom", Age=35, PasswordHash = hash, PasswordSalt = salt, Role = "Client"},
                new User {UserName="Mark", Age=17, PasswordHash = hash, PasswordSalt = salt, Role = "Client"},
                new User {UserName="Rob", Age=22, PasswordHash = hash, PasswordSalt = salt, Role = "Client"},
              
            };
            return users;
        }
        private User GetTestUser()
        {
            var userService = new UserService();
            userService.CreatePasswordHash("12341234", out byte[] hash, out byte[] salt);
            var user = new User { UserName = "Tom", Age = 35, PasswordHash = hash, PasswordSalt = salt, Role = "Client"};

            return user;
        }
    }
}
