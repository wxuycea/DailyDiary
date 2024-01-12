using System;
using System.Data;
using System.Security.Authentication;

namespace DailyDiary {
    internal class ModeChange {
        ReadMode readMode = new ReadMode();
        WriteMode writeMode = new WriteMode();

        public void Mode() {
            Console.Clear();
            Console.WriteLine("모드를 선택해주세요.");
            Console.WriteLine("[1] 읽기모드");
            Console.WriteLine("[2] 쓰기모드");

            string input = Console.ReadLine();
            int mode = Convert.ToInt32(input);

            try {
                switch(mode) {
                    case 1:
                        readMode.Run();
                        break;
                    case 2:
                        WriteMode.Run();
                        break;
                    default:
                        Console.WriteLine("1과 2 중에 선택해주세요.");
                        break;
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

    }
}
