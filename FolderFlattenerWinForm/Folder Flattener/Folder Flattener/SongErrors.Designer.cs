namespace Folder_Flattener
{
    partial class SongErrors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongErrors));
            this.sc_TableAndOK = new System.Windows.Forms.SplitContainer();
            this.dgv_Errors = new System.Windows.Forms.DataGridView();
            this.b_OK = new System.Windows.Forms.Button();
            this.p_Text = new System.Windows.Forms.Panel();
            this.l_Text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sc_TableAndOK)).BeginInit();
            this.sc_TableAndOK.Panel1.SuspendLayout();
            this.sc_TableAndOK.Panel2.SuspendLayout();
            this.sc_TableAndOK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Errors)).BeginInit();
            this.p_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_TableAndOK
            // 
            this.sc_TableAndOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_TableAndOK.Location = new System.Drawing.Point(0, 0);
            this.sc_TableAndOK.Name = "sc_TableAndOK";
            this.sc_TableAndOK.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_TableAndOK.Panel1
            // 
            this.sc_TableAndOK.Panel1.Controls.Add(this.dgv_Errors);
            // 
            // sc_TableAndOK.Panel2
            // 
            this.sc_TableAndOK.Panel2.Controls.Add(this.b_OK);
            this.sc_TableAndOK.Size = new System.Drawing.Size(1038, 613);
            this.sc_TableAndOK.SplitterDistance = 546;
            this.sc_TableAndOK.TabIndex = 3;
            // 
            // dgv_Errors
            // 
            this.dgv_Errors.AllowUserToAddRows = false;
            this.dgv_Errors.AllowUserToDeleteRows = false;
            this.dgv_Errors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Errors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Errors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Errors.Location = new System.Drawing.Point(0, 0);
            this.dgv_Errors.MultiSelect = false;
            this.dgv_Errors.Name = "dgv_Errors";
            this.dgv_Errors.ReadOnly = true;
            this.dgv_Errors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Errors.Size = new System.Drawing.Size(1038, 546);
            this.dgv_Errors.TabIndex = 0;
            // 
            // b_OK
            // 
            this.b_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_OK.Location = new System.Drawing.Point(951, 28);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 0;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            // 
            // p_Text
            // 
            this.p_Text.Controls.Add(this.l_Text);
            this.p_Text.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Text.Location = new System.Drawing.Point(0, 0);
            this.p_Text.Name = "p_Text";
            this.p_Text.Size = new System.Drawing.Size(1038, 49);
            this.p_Text.TabIndex = 4;
            // 
            // l_Text
            // 
            this.l_Text.AutoSize = true;
            this.l_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Text.Location = new System.Drawing.Point(0, 0);
            this.l_Text.Name = "l_Text";
            this.l_Text.Size = new System.Drawing.Size(547, 20);
            this.l_Text.TabIndex = 0;
            this.l_Text.Text = "There seems a few songs that didn\'t make it to their destination. Take a look.";
            // 
            // SongErrors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1038, 613);
            this.Controls.Add(this.p_Text);
            this.Controls.Add(this.sc_TableAndOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "SongErrors";
            this.Text = "Something Went Wrong...";
            this.sc_TableAndOK.Panel1.ResumeLayout(false);
            this.sc_TableAndOK.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_TableAndOK)).EndInit();
            this.sc_TableAndOK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Errors)).EndInit();
            this.p_Text.ResumeLayout(false);
            this.p_Text.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer sc_TableAndOK;
        private System.Windows.Forms.DataGridView dgv_Errors;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Panel p_Text;
        private System.Windows.Forms.Label l_Text;
    }
}