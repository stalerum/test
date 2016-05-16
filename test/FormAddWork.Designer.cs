namespace test
{
    partial class FormAddWork
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
            System.Windows.Forms.TabPage tabPage_Like;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Mass = new System.Windows.Forms.TabPage();
            this.btn_mass_add = new System.Windows.Forms.Button();
            tabPage_Like = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage_Mass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage_Mass);
            this.tabControl1.Controls.Add(tabPage_Like);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 120);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 279);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage_Mass
            // 
            this.tabPage_Mass.Controls.Add(this.btn_mass_add);
            this.tabPage_Mass.Location = new System.Drawing.Point(124, 4);
            this.tabPage_Mass.Name = "tabPage_Mass";
            this.tabPage_Mass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mass.Size = new System.Drawing.Size(511, 271);
            this.tabPage_Mass.TabIndex = 0;
            this.tabPage_Mass.Text = "Подписки";
            this.tabPage_Mass.UseVisualStyleBackColor = true;
            // 
            // tabPage_Like
            // 
            tabPage_Like.Location = new System.Drawing.Point(124, 4);
            tabPage_Like.Name = "tabPage_Like";
            tabPage_Like.Padding = new System.Windows.Forms.Padding(3);
            tabPage_Like.Size = new System.Drawing.Size(511, 271);
            tabPage_Like.TabIndex = 1;
            tabPage_Like.Text = "Лайкинг";
            tabPage_Like.UseVisualStyleBackColor = true;
            // 
            // btn_mass_add
            // 
            this.btn_mass_add.Location = new System.Drawing.Point(160, 218);
            this.btn_mass_add.Name = "btn_mass_add";
            this.btn_mass_add.Size = new System.Drawing.Size(216, 33);
            this.btn_mass_add.TabIndex = 0;
            this.btn_mass_add.Text = "Добавить задание и закрыть";
            this.btn_mass_add.UseVisualStyleBackColor = true;
            // 
            // FormAddWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 303);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAddWork";
            this.Text = "Добавление задания";
            this.Load += new System.EventHandler(this.FormAddWork_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Mass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Mass;
        private System.Windows.Forms.Button btn_mass_add;
    }
}