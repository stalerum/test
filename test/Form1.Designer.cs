namespace test
{
    partial class Form1
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
            this.dGV_Accs = new System.Windows.Forms.DataGridView();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddAccs = new System.Windows.Forms.Button();
            this.tB_log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Accs)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Accs
            // 
            this.dGV_Accs.AllowUserToAddRows = false;
            this.dGV_Accs.AllowUserToDeleteRows = false;
            this.dGV_Accs.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_Accs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_Accs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Name,
            this.Col_pass,
            this.Col_proxy,
            this.Col_Progress,
            this.Col_Status});
            this.dGV_Accs.Location = new System.Drawing.Point(12, 54);
            this.dGV_Accs.Name = "dGV_Accs";
            this.dGV_Accs.Size = new System.Drawing.Size(678, 125);
            this.dGV_Accs.TabIndex = 0;
            this.dGV_Accs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccEdit);
            // 
            // Col_Name
            // 
            this.Col_Name.HeaderText = "Аккаунт";
            this.Col_Name.Name = "Col_Name";
            // 
            // Col_pass
            // 
            this.Col_pass.HeaderText = "Пароль";
            this.Col_pass.Name = "Col_pass";
            this.Col_pass.Visible = false;
            // 
            // Col_proxy
            // 
            this.Col_proxy.HeaderText = "Прокси";
            this.Col_proxy.Name = "Col_proxy";
            this.Col_proxy.Visible = false;
            // 
            // Col_Progress
            // 
            this.Col_Progress.HeaderText = "Прогресс";
            this.Col_Progress.Name = "Col_Progress";
            // 
            // Col_Status
            // 
            this.Col_Status.HeaderText = "Статус";
            this.Col_Status.Name = "Col_Status";
            // 
            // btn_AddAccs
            // 
            this.btn_AddAccs.Location = new System.Drawing.Point(12, 12);
            this.btn_AddAccs.Name = "btn_AddAccs";
            this.btn_AddAccs.Size = new System.Drawing.Size(174, 23);
            this.btn_AddAccs.TabIndex = 1;
            this.btn_AddAccs.Text = "Добавить аккаунты";
            this.btn_AddAccs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddAccs.UseVisualStyleBackColor = true;
            this.btn_AddAccs.Click += new System.EventHandler(this.btn_AddAccs_Click);
            // 
            // tB_log
            // 
            this.tB_log.Location = new System.Drawing.Point(12, 185);
            this.tB_log.Multiline = true;
            this.tB_log.Name = "tB_log";
            this.tB_log.Size = new System.Drawing.Size(678, 132);
            this.tB_log.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB_log);
            this.Controls.Add(this.btn_AddAccs);
            this.Controls.Add(this.dGV_Accs);
            this.Name = "Form1";
            this.Text = "Тестовая";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Accs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Accs;
        private System.Windows.Forms.Button btn_AddAccs;
        private System.Windows.Forms.TextBox tB_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

