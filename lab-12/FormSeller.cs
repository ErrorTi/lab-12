using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab_12.NewFolder;

namespace lab_12
{
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }

        private void FormSeller_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            label2.Text = Autorization.Enter_User.First_Name + " " + Autorization.Enter_User.Second_Name;
            label3.Text = model.Roles.First(x => x.ID == Autorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + Autorization.Enter_User.Pictures);
        }
    }
}
