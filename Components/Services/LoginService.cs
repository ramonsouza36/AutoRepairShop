
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace AutoRepairShop.Components.Services;
public partial class LoginService
{
    private readonly AutoRepairDataContext context;

    private readonly UserManager<IdentityUser> userManager;
    private readonly SignInManager<IdentityUser> signInManager;

    public LoginService(AutoRepairDataContext ctx, UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInManager/*, HttpContext _httpContext*/)
    {
        this.context = ctx;
        userManager = _userManager;
        signInManager = _signInManager;
    }

    public async Task<SignInResult> LoginAsync(string username, string password)
    {
        return await signInManager.PasswordSignInAsync(username,password,false,false);
    }

    public async Task<bool> AuthenticateUser(IdentityUser user, string password)
    {
        var identity = new ClaimsIdentity("password");
        var roles = await userManager.GetRolesAsync(user!);
        identity.AddClaim(new Claim(ClaimTypes.Name, user!.UserName!));
        if(roles.Count() > 0)
        {
            foreach(var role in roles)
                identity.AddClaim(new Claim(ClaimTypes.Role, role));
        }
        var principal = new ClaimsPrincipal(identity);
        var authProperties = new AuthenticationProperties();
        var res = await signInManager.PasswordSignInAsync(user!.UserName!, password,false,false);
        return true;
    }
}