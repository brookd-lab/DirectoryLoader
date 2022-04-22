
namespace FileViewer
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnLoadDirectory = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDirectoryPath = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(377, 438);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // btnLoadDirectory
            // 
            this.btnLoadDirectory.Location = new System.Drawing.Point(6, 511);
            this.btnLoadDirectory.Name = "btnLoadDirectory";
            this.btnLoadDirectory.Size = new System.Drawing.Size(89, 23);
            this.btnLoadDirectory.TabIndex = 2;
            this.btnLoadDirectory.Text = "Load Directory";
            this.btnLoadDirectory.UseVisualStyleBackColor = true;
            this.btnLoadDirectory.Click += new System.EventHandler(this.btnLoadDirectory_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 511);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(693, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(210, 12);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(330, 20);
            this.txtDirectoryPath.TabIndex = 4;
            this.txtDirectoryPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDirectoryPath_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Directory";
            // 
            // btnDirectoryPath
            // 
            this.btnDirectoryPath.Location = new System.Drawing.Point(546, 10);
            this.btnDirectoryPath.Name = "btnDirectoryPath";
            this.btnDirectoryPath.Size = new System.Drawing.Size(31, 23);
            this.btnDirectoryPath.TabIndex = 6;
            this.btnDirectoryPath.Text = "...";
            this.btnDirectoryPath.UseVisualStyleBackColor = true;
            this.btnDirectoryPath.Click += new System.EventHandler(this.btnDirectoryPath_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(366, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 438);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDirectoryPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLoadDirectory);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Directory Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnLoadDirectory;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDirectoryPath;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

