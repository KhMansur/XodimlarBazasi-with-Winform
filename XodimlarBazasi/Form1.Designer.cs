namespace XodimlarBazasi
{
    partial class Xodimlar
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdOlish = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OlishBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Fio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Passport = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Manzil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.Malumoti = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.Mutaxassislik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.KirganSana = new System.Windows.Forms.DateTimePicker();
            this.QoshishBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TahrirlashBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OchirishBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GridBaza = new System.Windows.Forms.DataGridView();
            this.TugilganSana = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.QidirishTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.QidirishBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Yangilash = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBaza)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.30942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.69058F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 802);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OchirishBtn);
            this.panel1.Controls.Add(this.TahrirlashBtn);
            this.panel1.Controls.Add(this.QoshishBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 796);
            this.panel1.TabIndex = 0;
            // 
            // IdOlish
            // 
            this.IdOlish.Depth = 0;
            this.IdOlish.Enabled = false;
            this.IdOlish.Hint = "";
            this.IdOlish.Location = new System.Drawing.Point(33, 66);
            this.IdOlish.MouseState = MaterialSkin.MouseState.HOVER;
            this.IdOlish.Name = "IdOlish";
            this.IdOlish.PasswordChar = '\0';
            this.IdOlish.SelectedText = "";
            this.IdOlish.SelectionLength = 0;
            this.IdOlish.SelectionStart = 0;
            this.IdOlish.Size = new System.Drawing.Size(263, 23);
            this.IdOlish.TabIndex = 1;
            this.IdOlish.UseSystemPasswordChar = false;
            // 
            // OlishBtn
            // 
            this.OlishBtn.Depth = 0;
            this.OlishBtn.Enabled = false;
            this.OlishBtn.Location = new System.Drawing.Point(341, 66);
            this.OlishBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OlishBtn.Name = "OlishBtn";
            this.OlishBtn.Primary = true;
            this.OlishBtn.Size = new System.Drawing.Size(132, 33);
            this.OlishBtn.TabIndex = 2;
            this.OlishBtn.Text = "Olish";
            this.OlishBtn.UseVisualStyleBackColor = true;
            this.OlishBtn.Click += new System.EventHandler(this.OlishBtn_Click);
            // 
            // UpdateCheckBox
            // 
            this.UpdateCheckBox.AutoSize = true;
            this.UpdateCheckBox.Depth = 0;
            this.UpdateCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.UpdateCheckBox.Location = new System.Drawing.Point(29, 21);
            this.UpdateCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UpdateCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateCheckBox.Name = "UpdateCheckBox";
            this.UpdateCheckBox.Ripple = true;
            this.UpdateCheckBox.Size = new System.Drawing.Size(280, 30);
            this.UpdateCheckBox.TabIndex = 3;
            this.UpdateCheckBox.Text = "Mavjud xodimni ma\'lumotlarini tahrirlash";
            this.UpdateCheckBox.UseVisualStyleBackColor = true;
            this.UpdateCheckBox.Click += new System.EventHandler(this.UpdateCheckBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.UpdateCheckBox);
            this.panel2.Controls.Add(this.OlishBtn);
            this.panel2.Controls.Add(this.IdOlish);
            this.panel2.Location = new System.Drawing.Point(47, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 142);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(33, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bu yerga xodimning ID raqami kiritiladi";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.TugilganSana);
            this.panel3.Controls.Add(this.KirganSana);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Mutaxassislik);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Malumoti);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Manzil);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Passport);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Fio);
            this.panel3.Location = new System.Drawing.Point(47, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 480);
            this.panel3.TabIndex = 5;
            // 
            // Fio
            // 
            this.Fio.Depth = 0;
            this.Fio.Hint = "";
            this.Fio.Location = new System.Drawing.Point(48, 60);
            this.Fio.MouseState = MaterialSkin.MouseState.HOVER;
            this.Fio.Name = "Fio";
            this.Fio.PasswordChar = '\0';
            this.Fio.SelectedText = "";
            this.Fio.SelectionLength = 0;
            this.Fio.SelectionStart = 0;
            this.Fio.Size = new System.Drawing.Size(437, 23);
            this.Fio.TabIndex = 0;
            this.Fio.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passport seriyasi va raqami";
            // 
            // Passport
            // 
            this.Passport.Depth = 0;
            this.Passport.Hint = "";
            this.Passport.Location = new System.Drawing.Point(48, 139);
            this.Passport.MouseState = MaterialSkin.MouseState.HOVER;
            this.Passport.Name = "Passport";
            this.Passport.PasswordChar = '\0';
            this.Passport.SelectedText = "";
            this.Passport.SelectionLength = 0;
            this.Passport.SelectionStart = 0;
            this.Passport.Size = new System.Drawing.Size(196, 23);
            this.Passport.TabIndex = 3;
            this.Passport.UseSystemPasswordChar = false;
            // 
            // Manzil
            // 
            this.Manzil.Depth = 0;
            this.Manzil.Hint = "";
            this.Manzil.Location = new System.Drawing.Point(48, 214);
            this.Manzil.MouseState = MaterialSkin.MouseState.HOVER;
            this.Manzil.Name = "Manzil";
            this.Manzil.PasswordChar = '\0';
            this.Manzil.SelectedText = "";
            this.Manzil.SelectionLength = 0;
            this.Manzil.SelectionStart = 0;
            this.Manzil.Size = new System.Drawing.Size(437, 23);
            this.Manzil.TabIndex = 5;
            this.Manzil.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Manzili";
            // 
            // Malumoti
            // 
            this.Malumoti.Depth = 0;
            this.Malumoti.Hint = "";
            this.Malumoti.Location = new System.Drawing.Point(48, 288);
            this.Malumoti.MouseState = MaterialSkin.MouseState.HOVER;
            this.Malumoti.Name = "Malumoti";
            this.Malumoti.PasswordChar = '\0';
            this.Malumoti.SelectedText = "";
            this.Malumoti.SelectionLength = 0;
            this.Malumoti.SelectionStart = 0;
            this.Malumoti.Size = new System.Drawing.Size(437, 23);
            this.Malumoti.TabIndex = 7;
            this.Malumoti.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ma\'lumoti";
            // 
            // Mutaxassislik
            // 
            this.Mutaxassislik.Depth = 0;
            this.Mutaxassislik.Hint = "";
            this.Mutaxassislik.Location = new System.Drawing.Point(48, 363);
            this.Mutaxassislik.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mutaxassislik.Name = "Mutaxassislik";
            this.Mutaxassislik.PasswordChar = '\0';
            this.Mutaxassislik.SelectedText = "";
            this.Mutaxassislik.SelectionLength = 0;
            this.Mutaxassislik.SelectionStart = 0;
            this.Mutaxassislik.Size = new System.Drawing.Size(437, 23);
            this.Mutaxassislik.TabIndex = 9;
            this.Mutaxassislik.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(44, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mutaxassisligi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(285, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tug\'ilgan sanasi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(44, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ishga kirgan sanasi";
            // 
            // KirganSana
            // 
            this.KirganSana.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KirganSana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KirganSana.Location = new System.Drawing.Point(210, 407);
            this.KirganSana.Name = "KirganSana";
            this.KirganSana.Size = new System.Drawing.Size(275, 26);
            this.KirganSana.TabIndex = 13;
            // 
            // QoshishBtn
            // 
            this.QoshishBtn.Depth = 0;
            this.QoshishBtn.Location = new System.Drawing.Point(448, 724);
            this.QoshishBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.QoshishBtn.Name = "QoshishBtn";
            this.QoshishBtn.Primary = true;
            this.QoshishBtn.Size = new System.Drawing.Size(132, 33);
            this.QoshishBtn.TabIndex = 5;
            this.QoshishBtn.Text = "Qo\'shish";
            this.QoshishBtn.UseVisualStyleBackColor = true;
            this.QoshishBtn.Click += new System.EventHandler(this.QoshishBtn_Click);
            // 
            // TahrirlashBtn
            // 
            this.TahrirlashBtn.Depth = 0;
            this.TahrirlashBtn.Enabled = false;
            this.TahrirlashBtn.Location = new System.Drawing.Point(310, 724);
            this.TahrirlashBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TahrirlashBtn.Name = "TahrirlashBtn";
            this.TahrirlashBtn.Primary = true;
            this.TahrirlashBtn.Size = new System.Drawing.Size(132, 33);
            this.TahrirlashBtn.TabIndex = 6;
            this.TahrirlashBtn.Text = "Tahrirlash";
            this.TahrirlashBtn.UseVisualStyleBackColor = true;
            this.TahrirlashBtn.Click += new System.EventHandler(this.TahrirlashBtn_Click);
            // 
            // OchirishBtn
            // 
            this.OchirishBtn.Depth = 0;
            this.OchirishBtn.Enabled = false;
            this.OchirishBtn.Location = new System.Drawing.Point(172, 724);
            this.OchirishBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OchirishBtn.Name = "OchirishBtn";
            this.OchirishBtn.Primary = true;
            this.OchirishBtn.Size = new System.Drawing.Size(132, 33);
            this.OchirishBtn.TabIndex = 7;
            this.OchirishBtn.Text = "O\'chirish";
            this.OchirishBtn.UseVisualStyleBackColor = true;
            this.OchirishBtn.Click += new System.EventHandler(this.OchirishBtn_Click);
            // 
            // GridBaza
            // 
            this.GridBaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBaza.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridBaza.Location = new System.Drawing.Point(0, 71);
            this.GridBaza.Name = "GridBaza";
            this.GridBaza.Size = new System.Drawing.Size(699, 725);
            this.GridBaza.TabIndex = 1;
            // 
            // TugilganSana
            // 
            this.TugilganSana.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TugilganSana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TugilganSana.Location = new System.Drawing.Point(289, 136);
            this.TugilganSana.Name = "TugilganSana";
            this.TugilganSana.Size = new System.Drawing.Size(196, 26);
            this.TugilganSana.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Yangilash);
            this.panel4.Controls.Add(this.QidirishBtn);
            this.panel4.Controls.Add(this.QidirishTxtBox);
            this.panel4.Controls.Add(this.GridBaza);
            this.panel4.Location = new System.Drawing.Point(636, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 796);
            this.panel4.TabIndex = 8;
            // 
            // QidirishTxtBox
            // 
            this.QidirishTxtBox.Depth = 0;
            this.QidirishTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QidirishTxtBox.Hint = "";
            this.QidirishTxtBox.Location = new System.Drawing.Point(74, 27);
            this.QidirishTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.QidirishTxtBox.Name = "QidirishTxtBox";
            this.QidirishTxtBox.PasswordChar = '\0';
            this.QidirishTxtBox.SelectedText = "";
            this.QidirishTxtBox.SelectionLength = 0;
            this.QidirishTxtBox.SelectionStart = 0;
            this.QidirishTxtBox.Size = new System.Drawing.Size(315, 23);
            this.QidirishTxtBox.TabIndex = 2;
            this.QidirishTxtBox.UseSystemPasswordChar = false;
            // 
            // QidirishBtn
            // 
            this.QidirishBtn.Depth = 0;
            this.QidirishBtn.Location = new System.Drawing.Point(408, 17);
            this.QidirishBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.QidirishBtn.Name = "QidirishBtn";
            this.QidirishBtn.Primary = true;
            this.QidirishBtn.Size = new System.Drawing.Size(143, 33);
            this.QidirishBtn.TabIndex = 5;
            this.QidirishBtn.Text = "Qidirish";
            this.QidirishBtn.UseVisualStyleBackColor = true;
            this.QidirishBtn.Click += new System.EventHandler(this.QidirishBtn_Click);
            // 
            // Yangilash
            // 
            this.Yangilash.Depth = 0;
            this.Yangilash.Location = new System.Drawing.Point(564, 17);
            this.Yangilash.MouseState = MaterialSkin.MouseState.HOVER;
            this.Yangilash.Name = "Yangilash";
            this.Yangilash.Primary = true;
            this.Yangilash.Size = new System.Drawing.Size(121, 33);
            this.Yangilash.TabIndex = 6;
            this.Yangilash.Text = "Yangilash";
            this.Yangilash.UseVisualStyleBackColor = true;
            this.Yangilash.Click += new System.EventHandler(this.Yangilash_Click);
            // 
            // Xodimlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 802);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Xodimlar";
            this.Text = "Xodimlar Bazasi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBaza)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialCheckBox UpdateCheckBox;
        private MaterialSkin.Controls.MaterialRaisedButton OlishBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField IdOlish;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker KirganSana;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField Mutaxassislik;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField Malumoti;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField Manzil;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField Passport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Fio;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton OchirishBtn;
        private MaterialSkin.Controls.MaterialRaisedButton TahrirlashBtn;
        private MaterialSkin.Controls.MaterialRaisedButton QoshishBtn;
        private System.Windows.Forms.DataGridView GridBaza;
        private System.Windows.Forms.DateTimePicker TugilganSana;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRaisedButton QidirishBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField QidirishTxtBox;
        private MaterialSkin.Controls.MaterialRaisedButton Yangilash;
    }
}

