using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            AddList form = new AddList();
            form.Show();

        }

        private void buttonViewList_Click(object sender, EventArgs e)
        {
            ViewList form = new ViewList();
            form.Show();
        }

        private void buttonEditLists_Click(object sender, EventArgs e)
        {
            EditLists form = new EditLists();
            form.Show();
        }
    }
}
