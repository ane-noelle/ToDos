// Services/IUserService.cs
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Microsoft.AspNetCore.Identity;
using ToDoPlatform.ViewModels;

namespace ToDoPlatform.Services;
public interface IUserService
{
Task<UserVM> GetLoggedUser();
Task<SignInResult> Login(LoginVM login);
Task Logout();
Task<List<String>> Register(RegisterVM register);
}
