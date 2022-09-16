
namespace HotKeys
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblNote = new System.Windows.Forms.Label();
            this.edtCommandNote = new System.Windows.Forms.TextBox();
            this.cbbSuggestCommand = new System.Windows.Forms.ComboBox();
            this.edtCommand = new System.Windows.Forms.TextBox();
            this.edtInputHotKey = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblNote);
            this.splitContainer1.Panel2.Controls.Add(this.edtCommandNote);
            this.splitContainer1.Panel2.Controls.Add(this.cbbSuggestCommand);
            this.splitContainer1.Panel2.Controls.Add(this.edtCommand);
            this.splitContainer1.Panel2.Controls.Add(this.edtInputHotKey);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemove);
            this.splitContainer1.Size = new System.Drawing.Size(563, 450);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNote.Location = new System.Drawing.Point(0, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(258, 94);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "sdf sd fds sf \r\nsdfsdf\r\nsdfsdf";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edtCommandNote
            // 
            this.edtCommandNote.Location = new System.Drawing.Point(2, 184);
            this.edtCommandNote.Multiline = true;
            this.edtCommandNote.Name = "edtCommandNote";
            this.edtCommandNote.Size = new System.Drawing.Size(252, 137);
            this.edtCommandNote.TabIndex = 5;
            // 
            // cbbSuggestCommand
            // 
            this.cbbSuggestCommand.FormattingEnabled = true;
            this.cbbSuggestCommand.Location = new System.Drawing.Point(2, 155);
            this.cbbSuggestCommand.Name = "cbbSuggestCommand";
            this.cbbSuggestCommand.Size = new System.Drawing.Size(252, 23);
            this.cbbSuggestCommand.TabIndex = 4;
            // 
            // edtCommand
            // 
            this.edtCommand.Location = new System.Drawing.Point(3, 126);
            this.edtCommand.Name = "edtCommand";
            this.edtCommand.Size = new System.Drawing.Size(252, 23);
            this.edtCommand.TabIndex = 3;
            // 
            // edtInputHotKey
            // 
            this.edtInputHotKey.Location = new System.Drawing.Point(3, 97);
            this.edtInputHotKey.Name = "edtInputHotKey";
            this.edtInputHotKey.Size = new System.Drawing.Size(252, 23);
            this.edtInputHotKey.TabIndex = 2;
            this.edtInputHotKey.TextChanged += new System.EventHandler(this.edtInput_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(6, 389);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox edtInputHotKey;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox edtCommandNote;
        private System.Windows.Forms.ComboBox cbbSuggestCommand;
        private System.Windows.Forms.TextBox edtCommand;
        private System.Windows.Forms.Label lblNote;
    }
}

