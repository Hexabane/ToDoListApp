using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class ListData
    {
        private string eventName;
        private string eventType;
        private string dateTime;

        public ListData()
        {

        }
        public ListData(string eventName, string eventType, string dateTime)
        {
            this.EventName = eventName;
            this.EventType = eventType;
            this.DateTime = dateTime;
        }

        public string EventName { get => eventName; set => eventName = value; }
        public string EventType { get => eventType; set => eventType = value; }
        public string DateTime { get => dateTime; set => dateTime = value; }

        public void populatingTextFile()
        {
            string filepath = "D:\\C# Projects\\ToDoListApp\\ToDoList.txt";

            string dataInput = EventName + "," +  EventType  + "," + DateTime;

            StreamWriter write = new StreamWriter(filepath, true);
            write.WriteLine(dataInput);

            write.Close();
        }
    }
}
