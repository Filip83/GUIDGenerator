namespace GUIDGenerator
{
    partial class MainForm
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
            this.guidTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GUIDGen = new System.Windows.Forms.Button();
            this.GUIDarray = new System.Windows.Forms.RichTextBox();
            this.tochar = new System.Windows.Forms.Button();
            this.towchar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enbraces = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // guidTxt
            // 
            this.guidTxt.Location = new System.Drawing.Point(12, 27);
            this.guidTxt.Name = "guidTxt";
            this.guidTxt.Size = new System.Drawing.Size(378, 20);
            this.guidTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GUID";
            // 
            // GUIDGen
            // 
            this.GUIDGen.Location = new System.Drawing.Point(420, 27);
            this.GUIDGen.Name = "GUIDGen";
            this.GUIDGen.Size = new System.Drawing.Size(114, 23);
            this.GUIDGen.TabIndex = 2;
            this.GUIDGen.Text = "Generate";
            this.GUIDGen.UseVisualStyleBackColor = true;
            this.GUIDGen.Click += new System.EventHandler(this.GenerateGUID);
            // 
            // GUIDarray
            // 
            this.GUIDarray.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GUIDarray.Location = new System.Drawing.Point(12, 72);
            this.GUIDarray.Name = "GUIDarray";
            this.GUIDarray.Size = new System.Drawing.Size(378, 211);
            this.GUIDarray.TabIndex = 3;
            this.GUIDarray.Text = "";
            // 
            // tochar
            // 
            this.tochar.Location = new System.Drawing.Point(420, 72);
            this.tochar.Name = "tochar";
            this.tochar.Size = new System.Drawing.Size(114, 23);
            this.tochar.TabIndex = 4;
            this.tochar.Text = "To char array";
            this.tochar.UseVisualStyleBackColor = true;
            this.tochar.Click += new System.EventHandler(this.ToCharArry);
            // 
            // towchar
            // 
            this.towchar.Location = new System.Drawing.Point(420, 111);
            this.towchar.Name = "towchar";
            this.towchar.Size = new System.Drawing.Size(114, 23);
            this.towchar.TabIndex = 5;
            this.towchar.Text = "To wchar array";
            this.towchar.UseVisualStyleBackColor = true;
            this.towchar.Click += new System.EventHandler(this.ToWcharArray);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "C hex char array";
            // 
            // enbraces
            // 
            this.enbraces.AutoSize = true;
            this.enbraces.Location = new System.Drawing.Point(420, 163);
            this.enbraces.Name = "enbraces";
            this.enbraces.Size = new System.Drawing.Size(83, 17);
            this.enbraces.TabIndex = 7;
            this.enbraces.Text = "With braces";
            this.enbraces.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 315);
            this.Controls.Add(this.enbraces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.towchar);
            this.Controls.Add(this.tochar);
            this.Controls.Add(this.GUIDarray);
            this.Controls.Add(this.GUIDGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guidTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "GUID Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guidTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GUIDGen;
        private System.Windows.Forms.RichTextBox GUIDarray;
        private System.Windows.Forms.Button tochar;
        private System.Windows.Forms.Button towchar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox enbraces;
    }
}

