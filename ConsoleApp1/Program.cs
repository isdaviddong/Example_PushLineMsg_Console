using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string token = "___換成你的token___"; //換成你的token
            const string AdminUserId = "___換成你的UserId___"; //換成你的UserId

            //建立bot物件
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
            //發送文字
            bot.PushMessage(AdminUserId, "測試訊息");
            //發送貼圖
            bot.PushMessage(AdminUserId, 1, 2);
            //指定圖片位置
            Uri imgURL = new Uri("https://arock.blob.core.windows.net/blogdata201706/22-124357-ad3c87d6-b9cc-488a-8150-1c2fe642d237.png");
            //發送圖片
            bot.PushMessage(AdminUserId, imgURL);
            //顯示訊息
            Console.WriteLine("發送完成...");
            Console.ReadKey();
        }
    }
}
