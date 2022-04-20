
namespace AppRating
{
    partial class FormAdmin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxAllStudents = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.examDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.currentClassDataGridViewTextBoxColumn});
            this.dataGridViewStudents.DataSource = this.studentBindingSource;
            this.dataGridViewStudents.Location = new System.Drawing.Point(-2, 39);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(493, 382);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentClassDataGridViewTextBoxColumn
            // 
            this.currentClassDataGridViewTextBoxColumn.DataPropertyName = "currentClass";
            this.currentClassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.currentClassDataGridViewTextBoxColumn.Name = "currentClassDataGridViewTextBoxColumn";
            this.currentClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentClassDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(AppRating.EntityClasses.Student);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Студенты";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxAllStudents
            // 
            this.checkBoxAllStudents.AutoSize = true;
            this.checkBoxAllStudents.Location = new System.Drawing.Point(336, 450);
            this.checkBoxAllStudents.Name = "checkBoxAllStudents";
            this.checkBoxAllStudents.Size = new System.Drawing.Size(266, 17);
            this.checkBoxAllStudents.TabIndex = 4;
            this.checkBoxAllStudents.Text = "Показать всех студентов (в т.ч. и отчисленных)";
            this.checkBoxAllStudents.UseVisualStyleBackColor = true;
            this.checkBoxAllStudents.CheckedChanged += new System.EventHandler(this.checkBoxAllStudents_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить экзамен";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.AutoGenerateColumns = false;
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridViewExam.DataSource = this.examResultBindingSource;
            this.dataGridViewExam.Location = new System.Drawing.Point(534, 39);
            this.dataGridViewExam.MultiSelect = false;
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.ReadOnly = true;
            this.dataGridViewExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExam.Size = new System.Drawing.Size(346, 382);
            this.dataGridViewExam.TabIndex = 6;
            this.dataGridViewExam.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExam_CellValueChanged);
            // 
            // examDataGridViewTextBoxColumn
            // 
            this.examDataGridViewTextBoxColumn.DataPropertyName = "exam";
            this.examDataGridViewTextBoxColumn.HeaderText = "Экзамен";
            this.examDataGridViewTextBoxColumn.Name = "examDataGridViewTextBoxColumn";
            this.examDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // examResultBindingSource
            // 
            this.examResultBindingSource.DataSource = typeof(AppRating.EntityClasses.ExamResult);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(632, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Экзамены";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewExam);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBoxAllStudents);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "FormAdmin";
            this.Text = "Админка";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxAllStudents;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewExam;
        private System.Windows.Forms.BindingSource examResultBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
    }
}

