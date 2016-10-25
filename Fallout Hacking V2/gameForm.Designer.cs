namespace Fallout_Hacking_V2
{
    partial class gameForm
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
            this.components = new System.ComponentModel.Container();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gameListBox
            // 
            this.gameListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.gameListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameListBox.ForeColor = System.Drawing.Color.Lime;
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(0, 5);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(243, 273);
            this.gameListBox.TabIndex = 1;
            // 
            // inputListBox
            // 
            this.inputListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.inputListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputListBox.ForeColor = System.Drawing.Color.Lime;
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.Location = new System.Drawing.Point(241, 5);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(155, 273);
            this.inputListBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(241, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 234);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Quit";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 280);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputListBox);
            this.Controls.Add(this.gameListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gameForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}