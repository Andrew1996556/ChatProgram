
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatController
    {
        public static List<Answer> Answers { get; set; } = new List<Answer>();



        public byte[] PostMessage(string message, string userName)
        {
            if (!String.IsNullOrEmpty(message) && !String.IsNullOrEmpty(userName))
            {
                Answers.Add(new Answer() { message = message, userName = userName });
            }
            return new byte[0];
        }
        public byte[] GetSerializableAnswers()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Answers.ForEach(a => stringBuilder.AppendLine($"{a.userName.Replace("%20"," ")}: {a.message.Replace("%20"," ")}"));
            return Encoding.UTF8.GetBytes(stringBuilder.ToString());
        }

        public byte[] HelloWorld()
        {
            return Encoding.UTF8.GetBytes("Hello World");
        }
    }
}
