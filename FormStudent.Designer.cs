
namespace AppRating
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewExam = new System.Windows.Forms.DataGridView();
            this.examDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Экзамены";
            // 
            // dataGridViewExam
            // 
            this.dataGridViewExam.AutoGenerateColumns = false;
            this.dataGridViewExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridViewExam.DataSource = this.examResultBindingSource;
            this.dataGridViewExam.Location = new System.Drawing.Point(10, 77);
            this.dataGridViewExam.MultiSelect = false;
            this.dataGridViewExam.Name = "dataGridViewExam";
            this.dataGridViewExam.ReadOnly = true;
            this.dataGridViewExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExam.Size = new System.Drawing.Size(345, 341);
            this.dataGridViewExam.TabIndex = 4;
            // 
            // examDataGridViewTextBoxColumn
            // 
            this.examDataGridViewTextBoxColumn.DataPropertyName = "exam";
            this.examDataGridViewTextBoxColumn.HeaderText = "Экзамен";
            this.examDataGridViewTextBoxColumn.Name = "examDataGridViewTextBoxColumn";
            this.examDataGridViewTextBoxColumn.ReadOnly = true;
            this.examDataGridViewTextBoxColumn.Width = 150;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Width = 150;
            // 
            // examResultBindingSource
            // 
            this.examResultBindingSource.DataSource = typeof(AppRating.EntityClasses.ExamResult);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewExam);
            this.Name = "FormStudent";
            this.Text = "Студент";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewExam;
        private System.Windows.Forms.BindingSource examResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
    }
}