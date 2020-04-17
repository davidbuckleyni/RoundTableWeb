using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
namespace RoundTableWeb.Api.Classes {
    public static class AuthenticationExtension {
        public static IServiceCollection AddTokenAuthentication(this IServiceCollection services, IConfiguration config) {
            var secret = config.GetSection("JwtConfig").GetSection("secret").Value;
            var keySecret = Base64UrlEncoder.DecodeBytes(secret);

            var key = Encoding.ASCII.GetBytes(keySecret.ToString());
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    RequireExpirationTime = false,
                    ValidateLifetime = true,
                    ValidateAudience = false,
                  
                };
            });

            return services;
        }
    }
}
