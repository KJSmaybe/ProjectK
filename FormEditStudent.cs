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
    public partial class FormEditStudent : Form
    {
        public FormEditStudent()
        {
            InitializeComponent();
            dateTimePickerDateExpelled.Value = DateTime.Now;
            using (var db = new EntityContext())
            {
                comboBoxClasses.DataSource = db.Classes.ToList();
            }
        }

        private void checkBoxIsExpelled_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxExpelled.Visible = checkBoxIsExpelled.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //если заполнены не все поля
            if (textBoxName.Text == "" || textBoxAdress.Text == "" ||
            (checkBoxIsExpelled.Checked && textBoxNumOrder.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены");
                DialogResult = DialogResult.None;
            }
                
            

        }
    }
}
