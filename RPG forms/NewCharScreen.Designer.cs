namespace RPG_forms
{
    partial class NewCharScreen
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
            this.TxtBxClassName = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SelClassCombox = new System.Windows.Forms.ComboBox();
            this.CharPic = new System.Windows.Forms.PictureBox();
            this.LoadPicBtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RaceCombox = new System.Windows.Forms.ComboBox();
            this.tableUpdateStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelStr = new System.Windows.Forms.Label();
            this.labelIntell = new System.Windows.Forms.Label();
            this.labelChar = new System.Windows.Forms.Label();
            this.labelSpd = new System.Windows.Forms.Label();
            this.dataGridClassTest = new System.Windows.Forms.DataGridView();
            this.dAOclassBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAOclassBaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dAOclassBaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CharPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBxClassName
            // 
            this.TxtBxClassName.AccessibleName = "TbxClassName";
            this.TxtBxClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxClassName.Location = new System.Drawing.Point(12, 47);
            this.TxtBxClassName.Name = "TxtBxClassName";
            this.TxtBxClassName.Size = new System.Drawing.Size(258, 20);
            this.TxtBxClassName.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 239);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(257, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // SelClassCombox
            // 
            this.SelClassCombox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAOclassBaseBindingSource, "ClasseNome", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SelClassCombox.FormattingEnabled = true;
            this.SelClassCombox.Location = new System.Drawing.Point(13, 90);
            this.SelClassCombox.Name = "SelClassCombox";
            this.SelClassCombox.Size = new System.Drawing.Size(257, 21);
            this.SelClassCombox.TabIndex = 4;
            this.SelClassCombox.SelectedValueChanged += new System.EventHandler(this.SelClassCombox_SelectedValueChanged);
            // 
            // CharPic
            // 
            this.CharPic.Location = new System.Drawing.Point(565, 47);
            this.CharPic.Name = "CharPic";
            this.CharPic.Size = new System.Drawing.Size(210, 183);
            this.CharPic.TabIndex = 5;
            this.CharPic.TabStop = false;
            // 
            // LoadPicBtt
            // 
            this.LoadPicBtt.Location = new System.Drawing.Point(597, 363);
            this.LoadPicBtt.Name = "LoadPicBtt";
            this.LoadPicBtt.Size = new System.Drawing.Size(178, 28);
            this.LoadPicBtt.TabIndex = 6;
            this.LoadPicBtt.Text = "Load Character Picture";
            this.LoadPicBtt.UseVisualStyleBackColor = true;
            this.LoadPicBtt.Click += new System.EventHandler(this.LoadPicBtt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Personagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Classe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Raça";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Strengh";
            // 
            // RaceCombox
            // 
            this.RaceCombox.FormattingEnabled = true;
            this.RaceCombox.Location = new System.Drawing.Point(12, 134);
            this.RaceCombox.Name = "RaceCombox";
            this.RaceCombox.Size = new System.Drawing.Size(257, 21);
            this.RaceCombox.TabIndex = 13;
            // 
            // tableUpdateStatementBindingSource
            // 
            this.tableUpdateStatementBindingSource.DataSource = typeof(MySqlX.XDevAPI.Relational.TableUpdateStatement);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Intelligence";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Charisma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Speed";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(456, 31);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(13, 13);
            this.labelHP.TabIndex = 17;
            this.labelHP.Text = "0";
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Location = new System.Drawing.Point(456, 65);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(13, 13);
            this.labelStr.TabIndex = 18;
            this.labelStr.Text = "0";
            // 
            // labelIntell
            // 
            this.labelIntell.AutoSize = true;
            this.labelIntell.Location = new System.Drawing.Point(456, 93);
            this.labelIntell.Name = "labelIntell";
            this.labelIntell.Size = new System.Drawing.Size(13, 13);
            this.labelIntell.TabIndex = 19;
            this.labelIntell.Text = "0";
            // 
            // labelChar
            // 
            this.labelChar.AutoSize = true;
            this.labelChar.Location = new System.Drawing.Point(456, 118);
            this.labelChar.Name = "labelChar";
            this.labelChar.Size = new System.Drawing.Size(13, 13);
            this.labelChar.TabIndex = 20;
            this.labelChar.Text = "0";
            // 
            // labelSpd
            // 
            this.labelSpd.AutoSize = true;
            this.labelSpd.Location = new System.Drawing.Point(456, 142);
            this.labelSpd.Name = "labelSpd";
            this.labelSpd.Size = new System.Drawing.Size(13, 13);
            this.labelSpd.TabIndex = 21;
            this.labelSpd.Text = "0";
            // 
            // dataGridClassTest
            // 
            this.dataGridClassTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClassTest.Location = new System.Drawing.Point(291, 223);
            this.dataGridClassTest.Name = "dataGridClassTest";
            this.dataGridClassTest.Size = new System.Drawing.Size(268, 202);
            this.dataGridClassTest.TabIndex = 22;
            // 
            // dAOclassBaseBindingSource
            // 
            this.dAOclassBaseBindingSource.DataSource = typeof(RPG_forms.DAOs.ClassBase.DAOclassBase);
            // 
            // dAOclassBaseBindingSource1
            // 
            this.dAOclassBaseBindingSource1.DataSource = typeof(RPG_forms.DAOs.ClassBase.DAOclassBase);
            // 
            // dAOclassBaseBindingSource2
            // 
            this.dAOclassBaseBindingSource2.DataSource = typeof(RPG_forms.DAOs.ClassBase.DAOclassBase);
            // 
            // NewCharScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridClassTest);
            this.Controls.Add(this.labelSpd);
            this.Controls.Add(this.labelChar);
            this.Controls.Add(this.labelIntell);
            this.Controls.Add(this.labelStr);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RaceCombox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadPicBtt);
            this.Controls.Add(this.CharPic);
            this.Controls.Add(this.SelClassCombox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtBxClassName);
            this.Name = "NewCharScreen";
            this.Text = " ";
            this.Load += new System.EventHandler(this.NewCharScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CharPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxClassName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox SelClassCombox;
        private System.Windows.Forms.PictureBox CharPic;
        private System.Windows.Forms.Button LoadPicBtt;
        private System.Windows.Forms.BindingSource dAOclassBaseBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RaceCombox;
        private System.Windows.Forms.BindingSource tableUpdateStatementBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Label labelIntell;
        private System.Windows.Forms.Label labelChar;
        private System.Windows.Forms.Label labelSpd;
        private System.Windows.Forms.DataGridView dataGridClassTest;
        private System.Windows.Forms.BindingSource dAOclassBaseBindingSource1;
        private System.Windows.Forms.BindingSource dAOclassBaseBindingSource2;
    }
}