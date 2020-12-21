using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KursachVladdd
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            User uu = new User();
            User uuu = new User();
            UserDAO us = new UserDAO();

            u.Name = "fdgsfg";
            u.SurName = "fdgsfg";
            u.Patronimyc = "fdgsfg";
            u.Birthday = "fdgsfg";
            u.Location= "fdgsfg";
            u.Login= "fdgsfg";
            u.PassWord= 123;
            u.ID= 1;
            u.Confirmed = true;
            us.SaveUser(u);


            uu.Name = "alalal";
            uu.SurName = "fdgsfg";
            uu.Patronimyc = "fdgsfg";
            uu.Birthday = "fdgsfg";
            uu.Location = "fdgsfg";
            uu.Login = "fdgsfg";
            uu.PassWord = 123;
            uu.ID = 2;
            uu.Confirmed = true;
            us.SaveUser(uu);

            uuu = us.LoadUser(1);
            Console.WriteLine(uuu.Name);
            uuu = us.LoadUser(3);
            Console.WriteLine(uuu.Name);

              MessagesDAO messages = new MessagesDAO();
              messages.MessageWriter(123, "theme", "text");
              messages.MessagesReader();
              foreach (var oneMessage in messages.MessagesReader())
              {
                  Console.WriteLine(oneMessage.UserId);
                  Console.WriteLine(oneMessage.ThemeMessage);
                  Console.WriteLine(oneMessage.Text);
                  Console.WriteLine();
              }
        }
    }
}
