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
            this.btn_AddAccs = new System.Windows.Forms.Button();
            this.tB_log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_saveProj = new System.Windows.Forms.Button();
            this.btn_AddWork = new System.Windows.Forms.Button();
            this.btn_AccDel = new System.Windows.Forms.Button();
            this.Col_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Accs)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Accs
            // 
            this.dGV_Accs.AllowUserToAddRows = false;
            this.dGV_Accs.AllowUserToDeleteRows = false;
            this.dGV_Accs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Accs.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dGV_Accs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV_Accs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Check,
            this.Col_Login,
            this.Col_pass,
            this.Col_proxy,
            this.Col_Progress,
            this.Col_Status,
            this.Col_work});
            this.dGV_Accs.Location = new System.Drawing.Point(12, 92);
            this.dGV_Accs.Name = "dGV_Accs";
            this.dGV_Accs.RowHeadersVisible = false;
            this.dGV_Accs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Accs.Size = new System.Drawing.Size(678, 125);
            this.dGV_Accs.TabIndex = 0;
            this.dGV_Accs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Accs_CellClick);
            this.dGV_Accs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccEdit);
            this.dGV_Accs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Accs_CellValueChanged);
            // 
            // btn_AddAccs
            // 
            this.btn_AddAccs.Location = new System.Drawing.Point(12, 53);
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
            this.tB_log.Location = new System.Drawing.Point(12, 285);
            this.tB_log.Multiline = true;
            this.tB_log.Name = "tB_log";
            this.tB_log.Size = new System.Drawing.Size(678, 82);
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
            this.openFileDialog1.FileName = "accounts";
            this.openFileDialog1.Filter = "Текстовые файлы|*.txt";
            // 
            // btn_saveProj
            // 
            this.btn_saveProj.Location = new System.Drawing.Point(573, 12);
            this.btn_saveProj.Name = "btn_saveProj";
            this.btn_saveProj.Size = new System.Drawing.Size(117, 23);
            this.btn_saveProj.TabIndex = 4;
            this.btn_saveProj.Text = "Сохранить проект";
            this.btn_saveProj.UseVisualStyleBackColor = true;
            this.btn_saveProj.Click += new System.EventHandler(this.btn_saveProj_Click);
            // 
            // btn_AddWork
            // 
            this.btn_AddWork.Location = new System.Drawing.Point(12, 246);
            this.btn_AddWork.Name = "btn_AddWork";
            this.btn_AddWork.Size = new System.Drawing.Size(75, 23);
            this.btn_AddWork.TabIndex = 5;
            this.btn_AddWork.Text = "Задание";
            this.btn_AddWork.UseVisualStyleBackColor = true;
            this.btn_AddWork.Click += new System.EventHandler(this.btn_AddWork_Click);
            // 
            // btn_AccDel
            // 
            this.btn_AccDel.Location = new System.Drawing.Point(93, 246);
            this.btn_AccDel.Name = "btn_AccDel";
            this.btn_AccDel.Size = new System.Drawing.Size(75, 23);
            this.btn_AccDel.TabIndex = 6;
            this.btn_AccDel.Text = "Удалить";
            this.btn_AccDel.UseVisualStyleBackColor = true;
            this.btn_AccDel.Click += new System.EventHandler(this.btn_AccDel_Click);
            // 
            // Col_Check
            // 
            this.Col_Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_Check.FillWeight = 50.76142F;
            this.Col_Check.HeaderText = "";
            this.Col_Check.Name = "Col_Check";
            this.Col_Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_Check.Width = 25;
            // 
            // Col_Login
            // 
            this.Col_Login.FillWeight = 112.3096F;
            this.Col_Login.HeaderText = "Аккаунт";
            this.Col_Login.Name = "Col_Login";
            this.Col_Login.ReadOnly = true;
            // 
            // Col_pass
            // 
            this.Col_pass.HeaderText = "Пароль";
            this.Col_pass.Name = "Col_pass";
            this.Col_pass.ReadOnly = true;
            this.Col_pass.Visible = false;
            // 
            // Col_proxy
            // 
            this.Col_proxy.HeaderText = "Прокси";
            this.Col_proxy.Name = "Col_proxy";
            this.Col_proxy.ReadOnly = true;
            this.Col_proxy.Visible = false;
            // 
            // Col_Progress
            // 
            this.Col_Progress.FillWeight = 112.3096F;
            this.Col_Progress.HeaderText = "Прогресс";
            this.Col_Progress.Name = "Col_Progress";
            this.Col_Progress.ReadOnly = true;
            // 
            // Col_Status
            // 
            this.Col_Status.FillWeight = 112.3096F;
            this.Col_Status.HeaderText = "Статус";
            this.Col_Status.Name = "Col_Status";
            this.Col_Status.ReadOnly = true;
            // 
            // Col_work
            // 
            this.Col_work.FillWeight = 112.3096F;
            this.Col_work.HeaderText = "Задание";
            this.Col_work.Name = "Col_work";
            this.Col_work.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выделено аккаунтов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AccDel);
            this.Controls.Add(this.btn_AddWork);
            this.Controls.Add(this.btn_saveProj);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_saveProj;
        private System.Windows.Forms.Button btn_AddWork;
        private System.Windows.Forms.Button btn_AccDel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_work;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

