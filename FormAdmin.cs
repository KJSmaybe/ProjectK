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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            InitializeStudents();
        }
        void InitializeStudents()
        {
            using(var db = new EntityContext())
            {
                db.Classes.ToList();
                if(checkBoxAllStudents.Checked)
                    dataGridViewStudents.DataSource=db.Students.ToList();
                else
                    dataGridViewStudents.DataSource = db.Students.Where(s => !s.isExpelled).ToList();
            }
        }


        // добавление
        private void button1_Click(object sender, EventArgs e)
        {
            //Вызываем форму добавления студента
            FormEditStudent formEditStudent = new FormEditStudent();
            DialogResult result = formEditStudent.ShowDialog(this);
            
            if (result == DialogResult.Cancel)
                return;

            //Если ок то сохраняем его и обновляем грид
            Student student = new Student();
            student.fullName = formEditStudent.textBoxName.Text;
            student.address = formEditStudent.textBoxAdress.Text;
            if(formEditStudent.checkBoxIsExpelled.Checked)
            {
                student.isExpelled = true;
                student.expelledInfo = new ExpelledInfo
                {
                    dateExpelled = formEditStudent.dateTimePickerDateExpelled.Value,
                    numOrderExpelled = formEditStudent.textBoxNumOrder.Text
                };
            }
            using (var db = new EntityContext())
            {
                student.currentClass = db.Classes.Find(((Class)formEditStudent.comboBoxClasses.SelectedItem).id);
                db.Students.Add(student);
                db.SaveChanges();
            }
            InitializeStudents();

        }

        private void checkBoxAllStudents_CheckedChanged(object sender, EventArgs e)
        {
            InitializeStudents(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Вызываем форму редактирования студента и заполняем её
            FormEditStudent formEditStudent = new FormEditStudent();
            using (var db = new EntityContext())
            {
                if (dataGridViewStudents.SelectedRows.Count == 0)
                    return;
                //получаем первую попавшуюся строку
                int index = dataGridViewStudents.SelectedRows[0].Index;
                int id = 0;
                if (!Int32.TryParse(dataGridViewStudents[0, index].Value.ToString(), out id))
                        return;
                var student=db.Students.Find(id);

                formEditStudent.textBoxName.Text = student.fullName;
                formEditStudent.textBoxAdress.Text = student.address;
                if (student.isExpelled)
                {
                    db.ExpelledInfos.ToList();
                    formEditStudent.checkBoxIsExpelled.Checked = true;
                    formEditStudent.dateTimePickerDateExpelled.Value = student.expelledInfo.dateExpelled;
                    formEditStudent.textBoxNumOrder.Text = student.expelledInfo.numOrderExpelled;
                }
                DialogResult result = formEditStudent.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;


                //Если ок то сохраняем его и обновляем грид
                student.fullName = formEditStudent.textBoxName.Text;
                student.address = formEditStudent.textBoxAdress.Text;
                if (formEditStudent.checkBoxIsExpelled.Checked)
                {
                    student.isExpelled = true;
                    student.expelledInfo = new ExpelledInfo
                    {
                        dateExpelled = formEditStudent.dateTimePickerDateExpelled.Value,
                        numOrderExpelled = formEditStudent.textBoxNumOrder.Text
                    };
                }
                else
                {
                    student.isExpelled = false;
                    if(student.expelledInfo!=null)
                    {
                        ExpelledInfo expelledInfo = student.expelledInfo;
                        student.expelledInfo = null;
                        db.ExpelledInfos.Remove(expelledInfo);
                    }  
                }
              
                student.currentClass = db.Classes.Find(((Class)formEditStudent.comboBoxClasses.SelectedItem).id);
                db.SaveChanges();
            }
            InitializeStudents();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            
            using (var db = new EntityContext())
            {
                if (dataGridViewStudents.SelectedRows.Count == 0)
                    return;
                //подгружаем данные из БД
                var classes=db.Classes.ToList();
                db.ExamInfos.ToList();

                //получаем первую попавшуюся строку
                int index = dataGridViewStudents.SelectedRows[0].Index;
                int id = 0;

                if (!Int32.TryParse(dataGridViewStudents[0, index].Value.ToString(), out id))
                    return;
                var student = db.Students.Find(id);
                if (student.currentClass == null)
                    return;
                var examInfosList=db.ExamInfoClasses.Where(ex=>ex.@class.id==student.currentClass.id).ToList();
                List<ExamResult> examResults= new List<ExamResult>();
                foreach(ExamInfoClasses examInfo in examInfosList)
                {
                    var examResult= db.ExamResults.Where(exR=>exR.exam.id==examInfo.exam.id && exR.student.id==student.id).FirstOrDefault();
                    if (examResult == null) 
                    {
                        examResult = new ExamResult() { exam = examInfo.exam, student = student,id=0 };
                    }
                        
                    examResults.Add(examResult);
                }
                dataGridViewExam.DataSource = examResults;

            }
            dataGridViewExam.ReadOnly = false;
            dataGridViewExam.Columns["gradeDataGridViewTextBoxColumn"].ReadOnly = false;
        }
        
        private void dataGridViewExam_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dataGridViewExam.Columns[e.ColumnIndex].DataPropertyName != "grade")
                return;
            var examResult = (ExamResult)dataGridViewExam.Rows[e.RowIndex].DataBoundItem;
            using (var db = new EntityContext())
            {
                if (examResult.id != 0)
                    examResult = db.ExamResults.Find(examResult.id);
                else
                {
                    var student = db.Students.Find(examResult.student.id);
                    var examInfo = db.ExamInfos.Find(examResult.exam.id);
                    examResult.exam = examInfo;
                    examResult.student = student;
                    db.ExamResults.Add(examResult);
                }

                examResult.grade = (int)dataGridViewExam.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                db.SaveChanges();
                //dataGridViewExam.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null;
            }
        }
    }
}
