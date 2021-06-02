
namespace kyrsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ENDV = new System.Windows.Forms.Button();
            this.IFED = new System.Windows.Forms.Label();
            this.eas = new System.Windows.Forms.Button();
            this.NStran = new System.Windows.Forms.Label();
            this.Vodst = new System.Windows.Forms.DataGridView();
            this.KolSB = new System.Windows.Forms.Button();
            this.KolA = new System.Windows.Forms.TextBox();
            this.KolS = new System.Windows.Forms.TextBox();
            this.KolAB = new System.Windows.Forms.Button();
            this.KOLAL = new System.Windows.Forms.Label();
            this.Stran1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dal2 = new System.Windows.Forms.Button();
            this.Vodat = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.attaps = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.itprot = new System.Windows.Forms.DataGridView();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vodst)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vodat)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attaps)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itprot)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.ENDV);
            this.tabPage1.Controls.Add(this.IFED);
            this.tabPage1.Controls.Add(this.eas);
            this.tabPage1.Controls.Add(this.NStran);
            this.tabPage1.Controls.Add(this.Vodst);
            this.tabPage1.Controls.Add(this.KolSB);
            this.tabPage1.Controls.Add(this.KolA);
            this.tabPage1.Controls.Add(this.KolS);
            this.tabPage1.Controls.Add(this.KolAB);
            this.tabPage1.Controls.Add(this.KOLAL);
            this.tabPage1.Controls.Add(this.Stran1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввод стран";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ENDV
            // 
            this.ENDV.Location = new System.Drawing.Point(435, 363);
            this.ENDV.Name = "ENDV";
            this.ENDV.Size = new System.Drawing.Size(286, 23);
            this.ENDV.TabIndex = 13;
            this.ENDV.Text = "Завершить ввод стран";
            this.ENDV.UseVisualStyleBackColor = true;
            this.ENDV.Visible = false;
            this.ENDV.Click += new System.EventHandler(this.ENDV_Click);
            // 
            // IFED
            // 
            this.IFED.AutoSize = true;
            this.IFED.Location = new System.Drawing.Point(24, 268);
            this.IFED.Name = "IFED";
            this.IFED.Size = new System.Drawing.Size(307, 13);
            this.IFED.TabIndex = 11;
            this.IFED.Text = "ВЫ УВЕРЕНЫ В ПРАВИЬНОСТИ ВВЕДЕННЫХ ДАННЫХ?";
            this.IFED.Visible = false;
            this.IFED.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // eas
            // 
            this.eas.Location = new System.Drawing.Point(117, 300);
            this.eas.Name = "eas";
            this.eas.Size = new System.Drawing.Size(75, 23);
            this.eas.TabIndex = 10;
            this.eas.Text = "ДА";
            this.eas.UseVisualStyleBackColor = true;
            this.eas.Visible = false;
            this.eas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NStran
            // 
            this.NStran.AutoSize = true;
            this.NStran.Location = new System.Drawing.Point(494, 3);
            this.NStran.Name = "NStran";
            this.NStran.Size = new System.Drawing.Size(126, 13);
            this.NStran.TabIndex = 4;
            this.NStran.Text = "Ведите названия стран";
            this.NStran.Visible = false;
            this.NStran.Click += new System.EventHandler(this.label3_Click);
            // 
            // Vodst
            // 
            this.Vodst.AllowUserToAddRows = false;
            this.Vodst.AllowUserToDeleteRows = false;
            this.Vodst.BackgroundColor = System.Drawing.Color.OldLace;
            this.Vodst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vodst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vodst.ColumnHeadersVisible = false;
            this.Vodst.Location = new System.Drawing.Point(414, 19);
            this.Vodst.Name = "Vodst";
            this.Vodst.Size = new System.Drawing.Size(321, 400);
            this.Vodst.TabIndex = 9;
            this.Vodst.Visible = false;
            this.Vodst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KolSB
            // 
            this.KolSB.BackColor = System.Drawing.SystemColors.Window;
            this.KolSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KolSB.Location = new System.Drawing.Point(24, 107);
            this.KolSB.Name = "KolSB";
            this.KolSB.Size = new System.Drawing.Size(139, 23);
            this.KolSB.TabIndex = 8;
            this.KolSB.Text = "ВВОД\r\n";
            this.KolSB.UseVisualStyleBackColor = false;
            this.KolSB.Click += new System.EventHandler(this.KollSB_Click);
            // 
            // KolA
            // 
            this.KolA.Location = new System.Drawing.Point(24, 184);
            this.KolA.Name = "KolA";
            this.KolA.Size = new System.Drawing.Size(141, 20);
            this.KolA.TabIndex = 7;
            this.KolA.Visible = false;
            this.KolA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // KolS
            // 
            this.KolS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KolS.Location = new System.Drawing.Point(24, 68);
            this.KolS.Name = "KolS";
            this.KolS.Size = new System.Drawing.Size(141, 20);
            this.KolS.TabIndex = 2;
            this.KolS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KolAB
            // 
            this.KolAB.BackColor = System.Drawing.SystemColors.Window;
            this.KolAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KolAB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KolAB.Location = new System.Drawing.Point(24, 214);
            this.KolAB.Name = "KolAB";
            this.KolAB.Size = new System.Drawing.Size(141, 23);
            this.KolAB.TabIndex = 6;
            this.KolAB.Text = "ВВОД\r\n";
            this.KolAB.UseVisualStyleBackColor = false;
            this.KolAB.Visible = false;
            this.KolAB.Click += new System.EventHandler(this.button2_Click);
            // 
            // KOLAL
            // 
            this.KOLAL.AutoSize = true;
            this.KOLAL.Location = new System.Drawing.Point(24, 153);
            this.KOLAL.Name = "KOLAL";
            this.KOLAL.Size = new System.Drawing.Size(154, 13);
            this.KOLAL.TabIndex = 5;
            this.KOLAL.Text = "Введите колличество этапов";
            this.KOLAL.Visible = false;
            this.KOLAL.Click += new System.EventHandler(this.label4_Click);
            // 
            // Stran1
            // 
            this.Stran1.AutoSize = true;
            this.Stran1.Location = new System.Drawing.Point(24, 39);
            this.Stran1.Name = "Stran1";
            this.Stran1.Size = new System.Drawing.Size(148, 13);
            this.Stran1.TabIndex = 0;
            this.Stran1.Text = "Введите колличество стран";
            this.Stran1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dal2);
            this.tabPage2.Controls.Add(this.Vodat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ввод этапов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Убедитесь в правильности\r\n введеной информации и\r\n нажмите далее";
            this.label1.Visible = false;
            // 
            // dal2
            // 
            this.dal2.Location = new System.Drawing.Point(671, 376);
            this.dal2.Name = "dal2";
            this.dal2.Size = new System.Drawing.Size(75, 23);
            this.dal2.TabIndex = 10;
            this.dal2.Text = "Далее";
            this.dal2.UseVisualStyleBackColor = true;
            this.dal2.Visible = false;
            this.dal2.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Vodat
            // 
            this.Vodat.AllowUserToAddRows = false;
            this.Vodat.AllowUserToDeleteRows = false;
            this.Vodat.BackgroundColor = System.Drawing.Color.OldLace;
            this.Vodat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vodat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vodat.ColumnHeadersVisible = false;
            this.Vodat.Dock = System.Windows.Forms.DockStyle.Left;
            this.Vodat.Location = new System.Drawing.Point(0, 0);
            this.Vodat.MultiSelect = false;
            this.Vodat.Name = "Vodat";
            this.Vodat.Size = new System.Drawing.Size(611, 424);
            this.Vodat.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.OldLace;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.attaps);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Результаты этапов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Перейти к Итоговому протоколу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attaps
            // 
            this.attaps.AllowUserToAddRows = false;
            this.attaps.AllowUserToDeleteRows = false;
            this.attaps.BackgroundColor = System.Drawing.Color.OldLace;
            this.attaps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attaps.ColumnHeadersVisible = false;
            this.attaps.Location = new System.Drawing.Point(3, 0);
            this.attaps.MultiSelect = false;
            this.attaps.Name = "attaps";
            this.attaps.ReadOnly = true;
            this.attaps.Size = new System.Drawing.Size(661, 424);
            this.attaps.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.OldLace;
            this.tabPage4.Controls.Add(this.itprot);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Итоговый протокол";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // itprot
            // 
            this.itprot.BackgroundColor = System.Drawing.Color.OldLace;
            this.itprot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itprot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itprot.ColumnHeadersVisible = false;
            this.itprot.Location = new System.Drawing.Point(18, 14);
            this.itprot.Name = "itprot";
            this.itprot.ReadOnly = true;
            this.itprot.Size = new System.Drawing.Size(749, 393);
            this.itprot.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Велогонка Тур Де Франц";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vodst)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vodat)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attaps)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itprot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ENDV;
        private System.Windows.Forms.Label IFED;
        private System.Windows.Forms.Label NStran;
        private System.Windows.Forms.DataGridView Vodst;
        private System.Windows.Forms.Button KolSB;
        private System.Windows.Forms.TextBox KolA;
        private System.Windows.Forms.TextBox KolS;
        private System.Windows.Forms.Button KolAB;
        private System.Windows.Forms.Label KOLAL;
        private System.Windows.Forms.Label Stran1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button eas;
        private System.Windows.Forms.DataGridView Vodat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dal2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView attaps;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView itprot;
    }
}

