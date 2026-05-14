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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        public static Users Enter_User;

        private void button1_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model = new Model1();
            Enter_User = model.Users.FirstOrDefault(x => x.Login == textBox1.Text && x.Password == textBox2.Text);
            if (Enter_User != null)
            {
                switch (Enter_User.RoleID)
                {
                    case 1:
                        FormManager formManager = new FormManager();
                        formManager.ShowDialog();
                        break;
                    case 2:
                        FormDirector formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                    case 3:
                        FormSeller formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            
        }
    }
}
