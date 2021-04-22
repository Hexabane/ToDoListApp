using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class EditLists : Form
    {
        public EditLists()
        {
            InitializeComponent();
            populateListBox();
            dtpWhen.Format = DateTimePickerFormat.Custom;
            dtpWhen.CustomFormat = "dd/MMMM/yyyy";
        }

        public void populateListBox()
        {
            List<ListData> viewListInfo = ListHandler.userList();

            foreach (ListData item in viewListInfo)
            {
                lbViewList.Items.Add(item.EventName);
            }

        }


        private void lbViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = lbViewList.SelectedItem.ToString();

            List<ListData> viewListInfo = ListHandler.userList();

            viewListInfo = viewListInfo.Where(t => t.EventName == selectedItem).ToList();



            foreach (ListData item in viewListInfo)
            {

                tbEventName.Text = (item.EventName);
                tbEventType.Text = (item.EventType);
                dtpWhen.Value = Convert.ToDateTime(item.DateTime);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbViewList.SelectedIndex;


            ListHandler.userList()[selectedIndex].EventName = tbEventName.Text;
            ListHandler.userList()[selectedIndex].EventType = tbEventType.Text;
            ListHandler.userList()[selectedIndex].DateTime = dtpWhen.Text;

           

            string filepath = "D:\\C# Projects\\ToDoListApp\\ToDoList.txt";
            StreamWriter write = new StreamWriter(filepath);

            foreach  (ListData item in ListHandler.userList())
            {
                write.WriteLine(item.EventName + "," + item.EventType + "," + item.DateTime);
                

            }

            write.Close();
           






        }


    }
}
