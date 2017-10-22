using System.Threading.Tasks;

namespace MeiLian.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
