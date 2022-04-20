
namespace AppRating
{
    partial class FormEditStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxIsExpelled = new System.Windows.Forms.CheckBox();
            this.groupBoxExpelled = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateExpelled = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxExpelled.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxClasses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxIsExpelled);
            this.groupBox1.Controls.Add(this.groupBoxExpelled);
            this.groupBox1.Controls.Add(this.textBoxAdress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студент";
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(6, 114);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasses.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Класс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО";
            // 
            // checkBoxIsExpelled
            // 
            this.checkBoxIsExpelled.AutoSize = true;
            this.checkBoxIsExpelled.Location = new System.Drawing.Point(6, 153);
            this.checkBoxIsExpelled.Name = "checkBoxIsExpelled";
            this.checkBoxIsExpelled.Size = new System.Drawing.Size(74, 17);
            this.checkBoxIsExpelled.TabIndex = 3;
            this.checkBoxIsExpelled.Text = "Отчислен";
            this.checkBoxIsExpelled.UseVisualStyleBackColor = true;
            this.checkBoxIsExpelled.CheckedChanged += new System.EventHandler(this.checkBoxIsExpelled_CheckedChanged);
            // 
            // groupBoxExpelled
            // 
            this.groupBoxExpelled.Controls.Add(this.dateTimePickerDateExpelled);
            this.groupBoxExpelled.Controls.Add(this.label5);
            this.groupBoxExpelled.Controls.Add(this.textBoxNumOrder);
            this.groupBoxExpelled.Controls.Add(this.label4);
            this.groupBoxExpelled.Location = new System.Drawing.Point(6, 191);
            this.groupBoxExpelled.Name = "groupBoxExpelled";
            this.groupBoxExpelled.Size = new System.Drawing.Size(204, 114);
            this.groupBoxExpelled.TabIndex = 2;
            this.groupBoxExpelled.TabStop = false;
            this.groupBoxExpelled.Visible = false;
            // 
            // dateTimePickerDateExpelled
            // 
            this.dateTimePickerDateExpelled.Location = new System.Drawing.Point(3, 88);
            this.dateTimePickerDateExpelled.Name = "dateTimePickerDateExpelled";
            this.dateTimePickerDateExpelled.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerDateExpelled.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата отчисления";
            // 
            // textBoxNumOrder
            // 
            this.textBoxNumOrder.Location = new System.Drawing.Point(3, 32);
            this.textBoxNumOrder.Name = "textBoxNumOrder";
            this.textBoxNumOrder.Size = new System.Drawing.Size(149, 20);
            this.textBoxNumOrder.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер приказа";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(6, 74);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(149, 20);
            this.textBoxAdress.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(202, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 383);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditStudent";
            this.Text = "Редактирование студента";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxExpelled.ResumeLayout(false);
            this.groupBoxExpelled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxExpelled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.TextBox textBoxName;
        protected internal System.Windows.Forms.TextBox textBoxAdress;
        protected internal System.Windows.Forms.ComboBox comboBoxClasses;
        protected internal System.Windows.Forms.CheckBox checkBoxIsExpelled;
        protected internal System.Windows.Forms.TextBox textBoxNumOrder;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerDateExpelled;
    }
}