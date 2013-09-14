namespace The_Dir
{
    partial class frm_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_path = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbx_findrec = new System.Windows.Forms.CheckBox();
            this.txt_mask1 = new System.Windows.Forms.ComboBox();
            this.cbx_fullpath = new System.Windows.Forms.CheckBox();
            this.dialog_browse = new System.Windows.Forms.FolderBrowserDialog();
            this.dialog_save = new System.Windows.Forms.SaveFileDialog();
            this.btn_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.BackColor = System.Drawing.Color.White;
            this.txt_path.Location = new System.Drawing.Point(12, 25);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(528, 20);
            this.txt_path.TabIndex = 0;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(12, 103);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_result.Size = new System.Drawing.Size(600, 298);
            this.txt_result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Маска:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вывод:";
            // 
            // btn_apply
            // 
            this.btn_apply.Image = global::The_Dir.Properties.Resources.play;
            this.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apply.Location = new System.Drawing.Point(546, 63);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(66, 23);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Поиск";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Image = global::The_Dir.Properties.Resources.dir;
            this.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Location = new System.Drawing.Point(546, 23);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(66, 23);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Обзор";
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::The_Dir.Properties.Resources.save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(525, 407);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Сохранить";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbx_findrec
            // 
            this.cbx_findrec.AutoSize = true;
            this.cbx_findrec.Location = new System.Drawing.Point(71, 411);
            this.cbx_findrec.Name = "cbx_findrec";
            this.cbx_findrec.Size = new System.Drawing.Size(125, 17);
            this.cbx_findrec.TabIndex = 9;
            this.cbx_findrec.Text = "Искать рекурсивно";
            this.cbx_findrec.UseVisualStyleBackColor = true;
            // 
            // txt_mask1
            // 
            this.txt_mask1.FormattingEnabled = true;
            this.txt_mask1.Items.AddRange(new object[] {
            "*.*"});
            this.txt_mask1.Location = new System.Drawing.Point(12, 64);
            this.txt_mask1.Name = "txt_mask1";
            this.txt_mask1.Size = new System.Drawing.Size(528, 21);
            this.txt_mask1.TabIndex = 10;
            this.txt_mask1.SelectedIndexChanged += new System.EventHandler(this.txt_mask1_SelectedIndexChanged);
            // 
            // cbx_fullpath
            // 
            this.cbx_fullpath.AutoSize = true;
            this.cbx_fullpath.Location = new System.Drawing.Point(202, 411);
            this.cbx_fullpath.Name = "cbx_fullpath";
            this.cbx_fullpath.Size = new System.Drawing.Size(142, 17);
            this.cbx_fullpath.TabIndex = 11;
            this.cbx_fullpath.Text = "Выводить полный путь";
            this.cbx_fullpath.UseVisualStyleBackColor = true;
            // 
            // dialog_save
            // 
            this.dialog_save.Filter = "Текстовые файлы (*.txt)|*.txt|Pron файлы (*.pron)|*.pron|Все файлы (*.*)|*.*";
            this.dialog_save.RestoreDirectory = true;
            this.dialog_save.SupportMultiDottedExtensions = true;
            // 
            // btn_about
            // 
            this.btn_about.Image = global::The_Dir.Properties.Resources.info;
            this.btn_about.Location = new System.Drawing.Point(12, 407);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(28, 23);
            this.btn_about.TabIndex = 12;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.cbx_fullpath);
            this.Controls.Add(this.txt_mask1);
            this.Controls.Add(this.cbx_findrec);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "code name: the dir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_main_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox cbx_findrec;
        private System.Windows.Forms.ComboBox txt_mask1;
        private System.Windows.Forms.CheckBox cbx_fullpath;
        private System.Windows.Forms.FolderBrowserDialog dialog_browse;
        private System.Windows.Forms.SaveFileDialog dialog_save;
        private System.Windows.Forms.Button btn_about;
    }
}

