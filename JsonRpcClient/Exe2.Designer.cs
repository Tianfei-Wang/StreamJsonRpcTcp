namespace JsonRpcClient
{
    partial class Exe2
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
            this.textBoxSendToExe1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.args1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAgvId = new System.Windows.Forms.Label();
            this.args2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSendToAgv
            // 
            this.textBoxSendToExe1.Location = new System.Drawing.Point(194, 102);
            this.textBoxSendToExe1.Name = "textBoxSendToAgv";
            this.textBoxSendToExe1.Size = new System.Drawing.Size(224, 27);
            this.textBoxSendToExe1.TabIndex = 0;
            this.textBoxSendToExe1.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exe2 to Exe1:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTransactionFinishedId
            // 
            this.args1.Location = new System.Drawing.Point(252, 306);
            this.args1.Name = "textBoxTransactionFinishedId";
            this.args1.Size = new System.Drawing.Size(125, 27);
            this.args1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "args1";
            // 
            // labelAgvId
            // 
            this.labelAgvId.AutoSize = true;
            this.labelAgvId.Location = new System.Drawing.Point(193, 364);
            this.labelAgvId.Name = "labelAgvId";
            this.labelAgvId.Size = new System.Drawing.Size(49, 20);
            this.labelAgvId.TabIndex = 6;
            this.labelAgvId.Text = "args2";
            // 
            // textBoxAgvId
            // 
            this.args2.Location = new System.Drawing.Point(252, 357);
            this.args2.Name = "textBoxAgvId";
            this.args2.Size = new System.Drawing.Size(125, 27);
            this.args2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Form Exe1:";
            // 
            // FormClientTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAgvId);
            this.Controls.Add(this.args2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.args1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSendToExe1);
            this.Name = "Exe2";
            this.Text = "Exe2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSendToExe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox args1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAgvId;
        private System.Windows.Forms.TextBox args2;
        private System.Windows.Forms.Label label3;
    }
}
