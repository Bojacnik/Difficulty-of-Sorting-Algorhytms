
namespace DifficultyOfSortingAlgorithms;
    partial class OperationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Generated Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLaunchExcel = new System.Windows.Forms.Button();
            this.btnDrawGraphDifficulty = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaunchExcel
            // 
            this.btnLaunchExcel.Location = new System.Drawing.Point(13, 13);
            this.btnLaunchExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaunchExcel.Name = "btnLaunchExcel";
            this.btnLaunchExcel.Size = new System.Drawing.Size(252, 89);
            this.btnLaunchExcel.TabIndex = 0;
            this.btnLaunchExcel.Text = "Launch Excel";
            this.btnLaunchExcel.UseVisualStyleBackColor = true;
            this.btnLaunchExcel.Click += new System.EventHandler(this.btnLaunchExcel_Click);
            // 
            // btnDrawGraphDifficulty
            // 
            this.btnDrawGraphDifficulty.Enabled = false;
            this.btnDrawGraphDifficulty.Location = new System.Drawing.Point(13, 138);
            this.btnDrawGraphDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawGraphDifficulty.Name = "btnDrawGraphDifficulty";
            this.btnDrawGraphDifficulty.Size = new System.Drawing.Size(252, 84);
            this.btnDrawGraphDifficulty.TabIndex = 2;
            this.btnDrawGraphDifficulty.Text = "Draw Graph";
            this.btnDrawGraphDifficulty.UseVisualStyleBackColor = true;
            this.btnDrawGraphDifficulty.Click += new System.EventHandler(this.btnDrawGraphDifficulty_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 109);
            this.numericUpDown1.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(163, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown1.Value = new decimal(new int[] { 13, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iterations:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnDrawGraphDifficulty);
            this.Controls.Add(this.btnLaunchExcel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperationForm";
            this.Text = "Difficulty Graph";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        #endregion

        private System.Windows.Forms.Button btnLaunchExcel;
        private System.Windows.Forms.Button btnDrawGraphDifficulty;
    }
    