using System.ComponentModel;

namespace Dostup
{
    public class Users : INotifyPropertyChanged
    {
        public int _id;
        public string _name;
        public string _login;
        public string _password;
        public int _firstFile;
        public int _secondFile;
        public int _thirdFile;
        public int _fourthFile;
        public int _fifthFile;
        public int _sixthFile;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPC("Id");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = Name;
                OnPC("Id");
            }
        }
        public string Login
        {
            get { return _login; }
            set { _login = value;
                OnPC("Login");
            }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value;
                OnPC("Password");
            }
        }
        public int FirstFile
        {
            get { return _fifthFile; }
            set
            {
                _fifthFile = value;
                OnPC("FirstFile");
            }
        }
        public int SecondFile
        {
            get { return _secondFile; }
            set
            {
                _secondFile = value;
                OnPC("SecondFile");
            }
        }
        public int ThirdFile
        {
            get { return _thirdFile; }
            set
            {
                _thirdFile = value;
                OnPC("ThirdFile");
            }
        }
        public int FourthFile
        {
            get { return _fourthFile; }
            set
            {
                _fourthFile = value;
                OnPC("FourthFile");
            }
        }
        public int FifthFile
        {
            get { return FifthFile; }
            set
            {
                _fifthFile = value;
                OnPC("FifthFile");
            }
        }
        public int SixthFile
        {
            get { return _sixthFile; }
            set
            {
                _sixthFile = value;
                OnPC("SixthFile");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPC(string field)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(field));
        }
    }
}
