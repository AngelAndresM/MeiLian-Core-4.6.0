using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MeiLian.Authentication.TwoFactor.Google;
using MeiLian.Authorization;
using MeiLian.Authorization.Roles;
using MeiLian.Authorization.Users;
using MeiLian.Editions;
using MeiLian.MultiTenancy;

namespace MeiLian.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddAbpSignInManager<SignInManager>()
                .AddDefaultTokenProviders();
        }
    }
}
