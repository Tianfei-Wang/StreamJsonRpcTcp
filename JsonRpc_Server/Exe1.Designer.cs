namespace JsonRpc_Server
{
    partial class Exe1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAgvShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTranId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAgvId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAgvShow
            // 
            this.textBoxAgvShow.Location = new System.Drawing.Point(228, 123);
            this.textBoxAgvShow.Name = "textBoxAgvShow";
            this.textBoxAgvShow.Size = new System.Drawing.Size(125, 27);
            this.textBoxAgvShow.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form Exe2:";
            // 
            // textBoxTranId
            // 
            this.textBoxTranId.Location = new System.Drawing.Point(325, 335);
            this.textBoxTranId.Name = "textBoxTranId";
            this.textBoxTranId.Size = new System.Drawing.Size(152, 27);
            this.textBoxTranId.TabIndex = 2;
            this.textBoxTranId.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exe1 to Exe2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "args2";
            // 
            // textBoxAgvId
            // 
            this.textBoxAgvId.Location = new System.Drawing.Point(325, 302);
            this.textBoxAgvId.Name = "textBoxAgvId";
            this.textBoxAgvId.Size = new System.Drawing.Size(152, 27);
            this.textBoxAgvId.TabIndex = 6;
            this.textBoxAgvId.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "args1";
            // 
            // FormServerAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAgvId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTranId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAgvShow);
            this.Name = "Exe1";
            this.Text = "Exe1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAgvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTranId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAgvId;
        private System.Windows.Forms.Label label4;
    }
}
