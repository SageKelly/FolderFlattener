namespace Folder_Flattener
{
    partial class ConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationForm));
            this.b_Yes = new System.Windows.Forms.Button();
            this.b_No = new System.Windows.Forms.Button();
            this.p_label = new System.Windows.Forms.Panel();
            this.l_Question = new System.Windows.Forms.Label();
            this.p_buttons = new System.Windows.Forms.Panel();
            this.p_label.SuspendLayout();
            this.p_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Yes
            // 
            this.b_Yes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_Yes.Location = new System.Drawing.Point(12, 21);
            this.b_Yes.Name = "b_Yes";
            this.b_Yes.Size = new System.Drawing.Size(95, 32);
            this.b_Yes.TabIndex = 0;
            this.b_Yes.Text = "Yes";
            this.b_Yes.UseVisualStyleBackColor = true;
            // 
            // b_No
            // 
            this.b_No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_No.Location = new System.Drawing.Point(155, 21);
            this.b_No.Name = "b_No";
            this.b_No.Size = new System.Drawing.Size(95, 32);
            this.b_No.TabIndex = 1;
            this.b_No.Text = "No";
            this.b_No.UseVisualStyleBackColor = true;
            // 
            // p_label
            // 
            this.p_label.Controls.Add(this.l_Question);
            this.p_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_label.Location = new System.Drawing.Point(0, 0);
            this.p_label.Name = "p_label";
            this.p_label.Size = new System.Drawing.Size(262, 66);
            this.p_label.TabIndex = 2;
            // 
            // l_Question
            // 
            this.l_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Question.AutoSize = true;
            this.l_Question.Location = new System.Drawing.Point(0, 0);
            this.l_Question.Name = "l_Question";
            this.l_Question.Size = new System.Drawing.Size(57, 13);
            this.l_Question.TabIndex = 0;
            this.l_Question.Text = "Something";
            this.l_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_buttons
            // 
            this.p_buttons.Controls.Add(this.b_No);
            this.p_buttons.Controls.Add(this.b_Yes);
            this.p_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_buttons.Location = new System.Drawing.Point(0, 72);
            this.p_buttons.Name = "p_buttons";
            this.p_buttons.Size = new System.Drawing.Size(262, 65);
            this.p_buttons.TabIndex = 3;
            // 
            // ConfirmationForm
            // 
            this.AcceptButton = this.b_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.b_No;
            this.ClientSize = new System.Drawing.Size(262, 137);
            this.Controls.Add(this.p_buttons);
            this.Controls.Add(this.p_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmationForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.p_label.ResumeLayout(false);
            this.p_label.PerformLayout();
            this.p_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Yes;
        private System.Windows.Forms.Button b_No;
        private System.Windows.Forms.Panel p_label;
        private System.Windows.Forms.Panel p_buttons;
        private System.Windows.Forms.Label l_Question;
    }
}