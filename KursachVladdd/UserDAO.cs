using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursachVladdd
{
    
    public class UserDAO
    {
       
        public List<User> LoadAllUser()
        {
            List<string> l = new List<string>();
            StreamReader sr = new StreamReader("F:\\ВУЗ\\Курсач\\KursachVladdd\\User.txt");
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                l.Add(s);
            }
            
            List<User> user = new List<User>();
            for (int i = 0; i < l.Count; i+=9)
            {
                User u = new User();         
                u.Name = l[0+i];
                u.SurName = l[1 + i];
                u.Patronimyc = l[2 + i];
                u.Birthday = l[3 + i];
                u.Location = l[4 + i];
                u.Login = l[5 + i];
                u.PassWord = int.Parse(l[6 + i]);               
                u.ID =int.Parse( l[7 + i]);
                u.Confirmed =bool.Parse( l[8 + i]);
                user.Add(u);
            }
            sr.Close();
            return user;

        }
        public User LoadUser(int Id)
        {
            List<User> u= LoadAllUser();
            int posicion=-1;
            for(int i=0;i<u.Count;i++)
            {
                if(u[i].ID==Id)
                {
                    posicion = i;
                }
            }
            User e;
            if (posicion != -1)
                 e = u[posicion];
            else
                throw new Exception("A negative argument");
            return e;
        }
        public void SaveUser(User u)
        {
           File.AppendAllText("F:\\ВУЗ\\Курсач\\KursachVladdd\\User.txt",            
               u.Name + "\n" +
               u.SurName + "\n" +
               u.Patronimyc + "\n" +
               u.Birthday + "\n" +
               u.Location + "\n" +
               u.Login + "\n" +
               u.PassWord + "\n" +
               u.ID + "\n" +
               u.Confirmed + "\n" );
            
        }
    }
}
