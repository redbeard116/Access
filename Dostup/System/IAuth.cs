using System.Threading.Tasks;

namespace Dostup
{
    public interface IAuth
    {
       Task<Users> Authorization(string _login, string _password);
    }
}
