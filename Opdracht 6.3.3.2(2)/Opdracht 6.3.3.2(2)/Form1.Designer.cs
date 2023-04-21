namespace Opdracht_6._3._3._2_2_
{
    partial class OpdrachtZesDrieDrieTwee
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
            this.pbProgress = new Opdracht_6._3._3._2_2_.CustomProgressBar();
            this.btnProgress = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(153, 66);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(400, 56);
            this.pbProgress.TabIndex = 0;
            this.pbProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProgress.Location = new System.Drawing.Point(153, 168);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(151, 45);
            this.btnProgress.TabIndex = 1;
            this.btnProgress.Text = "Bereken";
            this.btnProgress.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProgress.Location = new System.Drawing.Point(360, 138);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(180, 20);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Aantal tussen 1 en 100";
            // 
            // txtProgress
            // 
            this.txtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtProgress.Location = new System.Drawing.Point(153, 128);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(201, 34);
            this.txtProgress.TabIndex = 3;
            this.txtProgress.TextChanged += new System.EventHandler(this.txtProgress_TextChanged);
            // 
            // OpdrachtZesDrieDrieTwee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.pbProgress);
            this.Name = "OpdrachtZesDrieDrieTwee";
            this.Text = "Opdracht 6.3.3.2";
            this.Load += new System.EventHandler(this.OpdrachtZesDrieDrieTwee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox txtProgress;
    }
}

