namespace RentACarDataManagement.Forms
{
    partial class CategoriesInsert
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
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.Gray);
            this.gradientPanel3.Controls.Add(this.panel2);
            this.gradientPanel3.Controls.Add(this.label2);
            this.gradientPanel3.Controls.Add(this.label1);
            this.gradientPanel3.Controls.Add(this.textBox2);
            this.gradientPanel3.Controls.Add(this.textBox1);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(549, 366);
            this.gradientPanel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 157);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Insert);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(345, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 157);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(91, 104);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 43);
            this.btn_Exit.TabIndex = 20;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(91, 6);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(99, 43);
            this.btn_Insert.TabIndex = 17;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Location = new System.Drawing.Point(91, 55);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(99, 43);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(10, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cat Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cat Label :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // CategoriesInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 366);
            this.Controls.Add(this.gradientPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesInsert";
            this.Text = "CategoriesInsert";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}