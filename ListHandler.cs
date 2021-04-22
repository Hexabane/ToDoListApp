using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class ListHandler
    {
        public static List<ListData> userList()
        {
            StreamReader file = new StreamReader("D:\\C# Projects\\ToDoListApp\\ToDoList.txt");

            List<ListData> output = new List<ListData>();

            string line;

            

            while ((line = file.ReadLine()) != null)
            {

                string[] ListInfo = line.Split(',');

                output.Add(new ListData {EventName = ListInfo[0], EventType = ListInfo[1], DateTime = ListInfo[2]});

            }

            file.Close();

            return output;

            

        }

            


    }
}
