using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_ResultManagementSystem
{
    public partial class messageForm : Form
    {
        private static string messageString = "";
        public static string MessageString { get => messageString; set => messageString = value; }

        public messageForm()
        {
            InitializeComponent();
            messageLabel.Text = MessageString;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
