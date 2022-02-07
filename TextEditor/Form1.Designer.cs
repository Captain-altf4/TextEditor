
namespace TextEditor
{
    partial class ms_MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rtb_Editor = new System.Windows.Forms.RichTextBox();
            this.mb_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rtb_Editor
            // 
            this.rtb_Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Editor.Location = new System.Drawing.Point(12, 27);
            this.rtb_Editor.Name = "rtb_Editor";
            this.rtb_Editor.Size = new System.Drawing.Size(318, 359);
            this.rtb_Editor.TabIndex = 1;
            this.rtb_Editor.Text = "";
            // 
            // mb_File
            // 
            this.mb_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_Open,
            this.mb_Save,
            this.mb_SaveAs,
            this.mb_Close});
            this.mb_File.Name = "mb_File";
            this.mb_File.Size = new System.Drawing.Size(48, 20);
            this.mb_File.Text = "Файл";
            // 
            // mb_Open
            // 
            this.mb_Open.Name = "mb_Open";
            this.mb_Open.Size = new System.Drawing.Size(180, 22);
            this.mb_Open.Text = "Открыть";
            // 
            // mb_Save
            // 
            this.mb_Save.Name = "mb_Save";
            this.mb_Save.Size = new System.Drawing.Size(180, 22);
            this.mb_Save.Text = "Сохранить";
            // 
            // mb_SaveAs
            // 
            this.mb_SaveAs.Name = "mb_SaveAs";
            this.mb_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.mb_SaveAs.Text = "Сохранить как...";
            // 
            // mb_Close
            // 
            this.mb_Close.Name = "mb_Close";
            this.mb_Close.Size = new System.Drawing.Size(180, 22);
            this.mb_Close.Text = "Закрыть";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ms_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 398);
            this.Controls.Add(this.rtb_Editor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ms_MainMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox rtb_Editor;
        private System.Windows.Forms.ToolStripMenuItem mb_File;
        private System.Windows.Forms.ToolStripMenuItem mb_Open;
        private System.Windows.Forms.ToolStripMenuItem mb_Save;
        private System.Windows.Forms.ToolStripMenuItem mb_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem mb_Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

