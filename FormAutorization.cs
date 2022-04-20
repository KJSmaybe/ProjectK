using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRating.EntityClasses;

namespace AppRating
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (EntityContext db = new EntityContext())
            {
                var User = db.Users.Where(u => u.login == textBoxLogin.Text && u.password == textBoxPass.Text)
                    .FirstOrDefault();
                if (User == null)
                    MessageBox.Show("Неверные Логин/Пароль");
                else if(User.typeUser==User.TypeUser.Admin)
                {
                    Program.Context.MainForm = new FormAdmin();
                    this.Close();
                    // покажет вторую форму и оставит приложение живым до ее закрытия
                    Program.Context.MainForm.Show();
                }
                else
                {
                    db.Users.ToList();
                    db.Students.ToString();
                    Student student = User.student;
                    Program.Context.MainForm = new FormStudent(User.student.id);
                    this.Close();
                    // покажет вторую форму и оставит приложение живым до ее закрытия
                    Program.Context.MainForm.Show();
                }
                  
            }
        }
    }
}
