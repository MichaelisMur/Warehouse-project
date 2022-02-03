using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Message : Form
    {
        // Форма с сообщением и кнопкой.
        public Message(bool success, string message)
        {
            InitializeComponent();
            CenterToScreen();
            messageButton.Text = success ? "OK" : "Cancel";
            messageText.Text = message;
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
