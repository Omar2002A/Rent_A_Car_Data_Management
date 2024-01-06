namespace RentACarDataManagement.Forms
{
    partial class PhonesViews
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
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btn_addmore = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1.Location = new System.Drawing.Point(0, 0);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(796, 366);
            this.DGV1.TabIndex = 2;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.Gray);
            this.gradientPanel1.Controls.Add(this.DGV1);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel1.TabIndex = 3;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.gradientPanel2.Controls.Add(this.btn_addmore);
            this.gradientPanel2.Controls.Add(this.btn_close);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 366);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(796, 80);
            this.gradientPanel2.TabIndex = 1;
            // 
            // btn_addmore
            // 
            this.btn_addmore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_addmore.FlatAppearance.BorderSize = 0;
            this.btn_addmore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addmore.Location = new System.Drawing.Point(586, 0);
            this.btn_addmore.Name = "btn_addmore";
            this.btn_addmore.Size = new System.Drawing.Size(103, 76);
            this.btn_addmore.TabIndex = 0;
            this.btn_addmore.Text = "ADD MORE...";
            this.btn_addmore.UseVisualStyleBackColor = true;
            this.btn_addmore.Click += new System.EventHandler(this.btn_addmore_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(689, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(103, 76);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PhonesViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhonesViews";
            this.Text = "PhonesViews";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private System.Windows.Forms.Button btn_addmore;
        private System.Windows.Forms.Button btn_close;
    }
}