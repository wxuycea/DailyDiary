using System;


namespace DailyDiary {
    internal class WriteMode {
        public void WriteNote() {
            Console.Clear();
            string dateTime = DateTime.Now.ToString("YYYY-MM-DD");

            string path = @"\desktop";
            string textfile = $@"{path}\{dateTime}.txt";

            if(!File.Exists(textfile)) {
                try {
                    using(StreamWriter sw = new StreamWriter(textfile)) {
                        Console.WriteLine("제목을 입력하세요:");
                        string? title = Console.ReadLine();
                        Console.WriteLine("내용을 입력하세요:");
                        string? content = Console.ReadLine();

                        sw.WriteLine($"시간: {dateTime}");
                        sw.WriteLine($"제목: {title}");
                        sw.WriteLine($"내용: {content}");
                    }
                } catch(Exception e) { Console.WriteLine(e.Message); }
            }
        }
    }
}