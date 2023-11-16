using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewApp_Porgramming_Assessment
{
    public partial class Login : Form
    {
       static User currentUser;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            newUser.GetUsername(txbUsername.Text);
            newUser.GetPassword(txbPassword.Text);

            currentUser = newUser;

            ClearAllTextBoxes();
        }

        private void ClearAllTextBoxes()
        {
            txbUsername.Clear();
            txbPassword.Clear();
        }
    }
}
