namespace RPG_forms
{
    partial class MainScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClassBtn = new System.Windows.Forms.Button();
            this.NewCharBtn = new System.Windows.Forms.Button();
            this.dAOclassBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassBtn
            // 
            this.ClassBtn.Location = new System.Drawing.Point(601, 353);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.Size = new System.Drawing.Size(131, 28);
            this.ClassBtn.TabIndex = 0;
            this.ClassBtn.Text = "New Class";
            this.ClassBtn.UseVisualStyleBackColor = true;
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // NewCharBtn
            // 
            this.NewCharBtn.Location = new System.Drawing.Point(601, 387);
            this.NewCharBtn.Name = "NewCharBtn";
            this.NewCharBtn.Size = new System.Drawing.Size(130, 28);
            this.NewCharBtn.TabIndex = 1;
            this.NewCharBtn.Text = "Create New Character";
            this.NewCharBtn.UseVisualStyleBackColor = true;
            this.NewCharBtn.Click += new System.EventHandler(this.NewCharBtn_Click);
            // 
            // dAOclassBaseBindingSource
            // 
            this.dAOclassBaseBindingSource.DataSource = typeof(RPG_forms.DAOs.ClassBase.DAOclassBase);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewCharBtn);
            this.Controls.Add(this.ClassBtn);
            this.Name = "MainScreen";
            this.Text = "RPG";
            ((System.ComponentModel.ISupportInitialize)(this.dAOclassBaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClassBtn;
        private System.Windows.Forms.BindingSource dAOclassBaseBindingSource;
        private System.Windows.Forms.Button NewCharBtn;
    }
}

