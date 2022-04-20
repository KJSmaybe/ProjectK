using AppRating.EntityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRating
{
    public partial class FormStudent : Form
    {
        int _id;
        public FormStudent(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            using (var db = new EntityContext())
            {

                //подгружаем данные из БД
                var classes = db.Classes.ToList();
                db.ExamInfos.ToList();


                var student = db.Students.Find(_id);
                if (student.currentClass == null)
                    return;
                this.Text = student.fullName;
                var examInfosList = db.ExamInfoClasses.Where(ex => ex.@class.id == student.currentClass.id).ToList();
                List<ExamResult> examResults = new List<ExamResult>();
                foreach (ExamInfoClasses examInfo in examInfosList)
                {
                    var examResult = db.ExamResults.Where(exR => exR.exam.id == examInfo.exam.id && exR.student.id == student.id).FirstOrDefault();
                    if (examResult == null)
                        examResult = new ExamResult() { exam = examInfo.exam, student = student };
                    examResults.Add(examResult);
                }
                dataGridViewExam.DataSource = examResults;

            }
        }
    }
}
