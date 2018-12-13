using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.SQL; 

namespace WindowsFormsApp1
{
    public partial class AddCall : UserControl
    {

        private Form1 f { get; set; }

        public AddCall()
        { 
            InitializeComponent();
            Time.CustomFormat = "HH:mm";
        }

        public void setForm1(Form1 form)
        {
            f = form; 
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            ExecuteQuery c = new ExecuteQuery();
            c.addCall(Date.Text, Time.Text, callerName.Text, callerPhone.Text, callerCompany.Text, askingFor.Text, "Testing details", branch.Text);
            f.dashboard1.Visible = true;
            resetFields();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            f.dashboard1.Visible = true; 
            resetFields();
        }

        private void resetFields()
        {
            callerName.Text = "";
            callerPhone.Text = "";
            callerCompany.Text = "";
            askingFor.Text = "";
            branch.Text = ""; 
        }
    }
}
