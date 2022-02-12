﻿
namespace TextEditor
{
    partial class F_TextEditor
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
            this.components = new System.ComponentModel.Container();
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mb_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_Editor = new System.Windows.Forms.RichTextBox();
            this.contextMenu_RTB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ms_MainMenu.SuspendLayout();
            this.contextMenu_RTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_File});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(342, 24);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "menuStrip1";
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
            this.mb_Open.Size = new System.Drawing.Size(163, 22);
            this.mb_Open.Text = "Открыть";
            this.mb_Open.Click += new System.EventHandler(this.mb_Open_Click);
            // 
            // mb_Save
            // 
            this.mb_Save.Enabled = false;
            this.mb_Save.Name = "mb_Save";
            this.mb_Save.Size = new System.Drawing.Size(163, 22);
            this.mb_Save.Text = "Сохранить";
            this.mb_Save.Click += new System.EventHandler(this.mb_Save_Click);
            // 
            // mb_SaveAs
            // 
            this.mb_SaveAs.Enabled = false;
            this.mb_SaveAs.Name = "mb_SaveAs";
            this.mb_SaveAs.Size = new System.Drawing.Size(163, 22);
            this.mb_SaveAs.Text = "Сохранить как...";
            this.mb_SaveAs.Click += new System.EventHandler(this.mb_SaveAs_Click);
            // 
            // mb_Close
            // 
            this.mb_Close.Enabled = false;
            this.mb_Close.Name = "mb_Close";
            this.mb_Close.Size = new System.Drawing.Size(163, 22);
            this.mb_Close.Text = "Закрыть";
            this.mb_Close.Click += new System.EventHandler(this.mb_Close_Click);
            // 
            // rtb_Editor
            // 
            this.rtb_Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Editor.ContextMenuStrip = this.contextMenu_RTB;
            this.rtb_Editor.Location = new System.Drawing.Point(12, 27);
            this.rtb_Editor.Name = "rtb_Editor";
            this.rtb_Editor.Size = new System.Drawing.Size(318, 359);
            this.rtb_Editor.TabIndex = 1;
            this.rtb_Editor.Text = "";
            // 
            // contextMenu_RTB
            // 
            this.contextMenu_RTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cm_Copy,
            this.cm_Cut,
            this.cm_Paste});
            this.contextMenu_RTB.Name = "contextMenu_RTB";
            this.contextMenu_RTB.Size = new System.Drawing.Size(181, 92);
            // 
            // cm_Copy
            // 
            this.cm_Copy.Name = "cm_Copy";
            this.cm_Copy.Size = new System.Drawing.Size(180, 22);
            this.cm_Copy.Text = "Копировать";
            this.cm_Copy.Click += new System.EventHandler(this.cm_Copy_Click);
            // 
            // cm_Cut
            // 
            this.cm_Cut.Name = "cm_Cut";
            this.cm_Cut.Size = new System.Drawing.Size(180, 22);
            this.cm_Cut.Text = "Вырезать";
            this.cm_Cut.Click += new System.EventHandler(this.cm_Cut_Click);
            // 
            // cm_Paste
            // 
            this.cm_Paste.Name = "cm_Paste";
            this.cm_Paste.Size = new System.Drawing.Size(180, 22);
            this.cm_Paste.Text = "Вставить";
            this.cm_Paste.Click += new System.EventHandler(this.cm_Paste_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt files|*.txt| all files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt files|*.txt| all files|*.*";
            // 
            // F_TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 398);
            this.Controls.Add(this.rtb_Editor);
            this.Controls.Add(this.ms_MainMenu);
            this.MainMenuStrip = this.ms_MainMenu;
            this.Name = "F_TextEditor";
            this.Text = "Form1";
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.contextMenu_RTB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.RichTextBox rtb_Editor;
        private System.Windows.Forms.ToolStripMenuItem mb_File;
        private System.Windows.Forms.ToolStripMenuItem mb_Open;
        private System.Windows.Forms.ToolStripMenuItem mb_Save;
        private System.Windows.Forms.ToolStripMenuItem mb_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem mb_Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenu_RTB;
        private System.Windows.Forms.ToolStripMenuItem cm_Copy;
        private System.Windows.Forms.ToolStripMenuItem cm_Cut;
        private System.Windows.Forms.ToolStripMenuItem cm_Paste;
    }
}

