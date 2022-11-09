using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1Weekdays
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Methods m = new Methods();
            ArrayList days = m.PopulateDays();

            foreach (var item in days)
            {
                DayList.Items.Add(item);
            }


        }

        private void DayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Methods m = new Methods();
            TextBoxFile.Text = m.ReadFile(DayList.SelectedItem.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.Save(TextBoxFile.Text, DayList.SelectedItem.ToString());
        }
    }
}
