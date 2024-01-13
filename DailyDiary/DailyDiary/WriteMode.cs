using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyDiary {
    internal class WriteMode {
        public void WriteNote() {
            Console.Clear();
            string dateTime = DateTime.Now.ToString("YYYY-MM-DD");

            string path = @"\desktop";
            string textfile = $@"{path}\{dateTime}.txt";

            if(!File.Exists(textfile)) {
                try {
                } finally {
                }
            }
        }
}
