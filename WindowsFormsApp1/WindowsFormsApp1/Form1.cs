using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addCall1.setForm1(this); 
           
        }

        private void NewCallBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            
            addCall1.Visible = true; 
            
        }
        
    }
}
