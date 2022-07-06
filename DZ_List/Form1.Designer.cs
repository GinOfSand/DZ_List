namespace DZ_List
{
    partial class Form1
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
            this.StudentsList = new System.Windows.Forms.CheckedListBox();
            this.ListTrue = new System.Windows.Forms.ListBox();
            this.listFalse = new System.Windows.Forms.ListBox();
            this.FunctionSelect = new System.Windows.Forms.ComboBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentsList
            // 
            this.StudentsList.CheckOnClick = true;
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.Items.AddRange(new object[] {
            "Иван Золомов",
            "Соня Лосева",
            "Александра Дыба",
            "Дмитрий Йорков",
            "Степан Яков",
            "Янгур Симадзил",
            "Нозинисо Махмахилова",
            "Альберт Сохов",
            "Роман Римов",
            "Шивал Щазмиьлиов"});
            this.StudentsList.Location = new System.Drawing.Point(235, 80);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(184, 289);
            this.StudentsList.TabIndex = 0;
            // 
            // ListTrue
            // 
            this.ListTrue.FormattingEnabled = true;
            this.ListTrue.Location = new System.Drawing.Point(23, 80);
            this.ListTrue.Name = "ListTrue";
            this.ListTrue.Size = new System.Drawing.Size(184, 290);
            this.ListTrue.TabIndex = 1;
            // 
            // listFalse
            // 
            this.listFalse.FormattingEnabled = true;
            this.listFalse.Location = new System.Drawing.Point(448, 80);
            this.listFalse.Name = "listFalse";
            this.listFalse.Size = new System.Drawing.Size(184, 290);
            this.listFalse.TabIndex = 2;
            // 
            // FunctionSelect
            // 
            this.FunctionSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "Отсутствует",
            "Присутствует"});
            this.FunctionSelect.FormattingEnabled = true;
            this.FunctionSelect.Items.AddRange(new object[] {
            "Отсутствует",
            "Присутствует"});
            this.FunctionSelect.Location = new System.Drawing.Point(734, 80);
            this.FunctionSelect.Name = "FunctionSelect";
            this.FunctionSelect.Size = new System.Drawing.Size(163, 21);
            this.FunctionSelect.TabIndex = 4;
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(734, 280);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(163, 40);
            this.RunBtn.TabIndex = 5;
            this.RunBtn.Text = "Применить";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(734, 339);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(163, 31);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Присутствуют";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список студентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отсутствуют";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Действия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.FunctionSelect);
            this.Controls.Add(this.listFalse);
            this.Controls.Add(this.ListTrue);
            this.Controls.Add(this.StudentsList);
            this.Name = "Form1";
            this.Text = "Список пресутствия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox StudentsList;
        private System.Windows.Forms.ListBox ListTrue;
        private System.Windows.Forms.ListBox listFalse;
        private System.Windows.Forms.ComboBox FunctionSelect;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

