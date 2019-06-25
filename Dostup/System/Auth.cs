using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Dostup
{
    public class Auth : IAuth
    {
        public ObservableCollection<Users> User { get; set; }

        public async Task<Users> Authorization(string _login, string _password)
        {
            for (int i = 0; i < User.Count; i++)
            {
                var list = User.ToList();
                foreach (Users _users in list)
                {
                    if (_users.Login == _login)
                    {
                        if (_users.Password == _password)
                        {
                            return _users;
                        }
                    }
                }
            }
        }
    }
}
