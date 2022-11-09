using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise1Weekdays
{
    class Methods
    {
        public ArrayList PopulateDays()
        {
            ArrayList days = new ArrayList {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };

            return days;
        }
        public string ReadFile(string day)
        {
            string path = @"..\..\Files\";
            FileStream fs = new FileStream(path + day + ".txt",FileMode.Open);
            BufferedStream bs = new BufferedStream(fs);
            StreamReader reader = new StreamReader(bs);
            

            string content = reader.ReadToEnd();
            reader.Close();

           
            
            return content;
        }
        public void Save(string tbVal, string day)
        {
            string path = @"..\..\Files\";
            FileStream fs = new FileStream(path + day + ".txt", FileMode.Truncate);
            BufferedStream bs = new BufferedStream(fs);
            StreamWriter writer = new StreamWriter(bs);

            writer.Write(tbVal);
            writer.Close();


        }

    }
}
