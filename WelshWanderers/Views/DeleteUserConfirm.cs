using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelshWanderers.Views
{
    public partial class DeleteUserConfirm : Form
    {
        public static string userID;
        public DeleteUserConfirm(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void DeleteUserConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
