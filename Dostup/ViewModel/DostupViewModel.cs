using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dostup
{
    public class DostupViewModel : INotifyPropertyChanged
    {
        public DostupViewModel(IAuth auth)
        {
            Users = new ObservableCollection<Users>
           {
               new Users{Id = 1, Name = "Ivan", Login = "ivan", Password = "ivan", FirstFile = 1, SecondFile = 0, ThirdFile = 2, FourthFile = 4, FifthFile = 3, SixthFile = 5 },
               new Users{Id = 2, Name = "Sidor", Login = "sidor", Password = "sidor", FirstFile = 1, SecondFile = 0, ThirdFile = 2, FourthFile = 4, FifthFile = 3, SixthFile = 5 },
               new Users{Id = 3, Name = "Pitr", Login = "pitr", Password = "pitr", FirstFile = 1, SecondFile = 0, ThirdFile = 2, FourthFile = 4, FifthFile = 3, SixthFile = 5 },
               new Users{Id = 4, Name = "Alina", Login = "alina", Password = "alina", FirstFile = 1, SecondFile = 0, ThirdFile = 2, FourthFile = 4, FifthFile = 3, SixthFile = 5 },
               new Users{Id = 5, Name = "Alisa", Login = "alisa", Password = "alisa", FirstFile = 1, SecondFile = 0, ThirdFile = 2, FourthFile = 4, FifthFile = 3, SixthFile = 5 },
               new Users{Id = 6, Name = "Karina", Login = "karina", Password = "karina", FirstFile = 1, SecondFile = 0, ThirdFile = 2, FourthFile = 4, FifthFile = 3, SixthFile = 5 },
           };

            _auth = auth;
            AuthCommandCmd = new AuthCommand(auth, this);
        }

        public IAuth _auth;
        public AuthCommand AuthCommandCmd { get; }
        public ObservableCollection<Users> Users { get; set; }

        public string Login { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPC(string field)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(field));
        }
    }
}
