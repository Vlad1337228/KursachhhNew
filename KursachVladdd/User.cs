using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachVladdd
{
    public class User
    {
        private string name; //только буквы
        private string surName; //только буквы
        private string patronimyc;
        private string birthday;
        private string location;
        private string login;
        private int passWord;

        private int iD;
        private bool confirmed;       

        public string Name
        { get { return name; }
          set { name = value; }
        }
        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }
        public string Patronimyc
        {
            get { return patronimyc; }
            set { patronimyc = value; }
        }
        public string Location
        {
            get { return location; }
            set { location= value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public int PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public bool Confirmed
        {
            get { return confirmed; }
            set {confirmed = value; }
        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
      
    }
}
