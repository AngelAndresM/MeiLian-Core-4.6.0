using System.Threading.Tasks;
using MeiLian.Security.Recaptcha;

namespace MeiLian.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
