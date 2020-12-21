using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KursachVladdd
{
    public class MessagesDAO
    {
        //List<Message> allMessages = new List<Message>();

       // public List<Message> AllMessages => allMessages;

        public List<Message> MessagesReader()
        {
            List<Message> allMessages = new List<Message>();
            foreach (string line in File.ReadLines("F:\\ВУЗ\\Курсач\\KursachVladdd\\Messages.txt"))
            {
                allMessages.Add(GetMessage(line));
            }
            return allMessages;
        }

        public Message GetMessage(string str)
        {
            string[] oneLine = str.Split('/');
            Message oneMessage = new Message();

            oneMessage.UserId = int.Parse(oneLine[0]);
            oneMessage.ThemeMessage = oneLine[1];
            oneMessage.Text = oneLine[2];

            if (oneLine.Length > 3)
            {
                oneMessage.EmployeeAnswer = oneLine[3];
            }

            return oneMessage;
        }
        public void MessageWriter(int id, string theme, string text)
        {
            File.AppendAllText("F:\\ВУЗ\\Курсач\\KursachVladdd\\Messages.txt", id + "/" + theme + "/" + text + "\n");
        }
    }
}