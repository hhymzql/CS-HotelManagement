using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DecComponents.DotNetBar;

namespace HotelServer_1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            sj.Text = DateTime.Now.DayOfWeek.ToString() + DateTime.Now.ToString();
            //tabControlPanel4.TabItem = tabItem10;
            //mypanel.TabIndex = 13;

            tabControl1.Controls.Add(tabControlPanel1);
            tabItem7.AttachedControl = tabControlPanel1;
            tabControlPanel1.TabItem = tabItem7;
        }
        private void skrz_Click(object sender, EventArgs e)
        {
           // this.mypanel.Visible = true;
            //mypanel.TabIndex = 1;
            tabControl1.Controls.Add(tabControlPanel1);
            tabItem7.AttachedControl = tabControlPanel1;
            tabItem7.CloseButtonVisible = true;
            tabControlPanel1.TabItem = tabItem7;
        }

        private void ttrz_Click(object sender, EventArgs e)
        {
           // this.mypanel.Visible = true;
           // mypanel.TabIndex = 5;
            tabControl1.Controls.Add(tabControlPanel4);
            tabItem10.AttachedControl = tabControlPanel4;
            tabItem10.CloseButtonVisible = true;
            tabControlPanel4.TabItem = tabItem7;
        }

        private void spgl_Click(object sender, EventArgs e)
        {
           // this.mypanel.Visible = true;
            //mypanel.TabIndex=9;
            tabControl1.Controls.Add(tabControlPanel3);
            tabItem9.AttachedControl = tabControlPanel3;
            tabItem9.CloseButtonVisible = true;
            tabControlPanel3.TabItem = tabItem9;
        }
    }
}
