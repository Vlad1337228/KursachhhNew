using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachVladdd
{
    public class Administration
    {
        private string login;
        private string passWord;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public void AutorizationPass(User u)
        {
           if(ProverkaStringUpper(u.Name)==false|| ProverkaStringUpper(u.SurName) == false || ProverkaStringUpper(u.Patronimyc) == false || ProverkaStringUpper(u.Location) == false || ProverkaString(u.Login) == false )
            {
                u.Confirmed = false;
            }
           
        }
        public bool ProverkaStringUpper(string s)
        {
            if(!Char.IsUpper(s[0]))
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsLetter(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool ProverkaString(string s)
        {   
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsLetter(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
