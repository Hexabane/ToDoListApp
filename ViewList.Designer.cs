
namespace ToDoListApp
{
    partial class ViewList
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
            this.lbListNames = new System.Windows.Forms.ListBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListNames
            // 
            this.lbListNames.FormattingEnabled = true;
            this.lbListNames.ItemHeight = 16;
            this.lbListNames.Location = new System.Drawing.Point(12, 113);
            this.lbListNames.Name = "lbListNames";
            this.lbListNames.Size = new System.Drawing.Size(255, 308);
            this.lbListNames.TabIndex = 0;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(306, 223);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(121, 36);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = ">>";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 16;
            this.lbData.Location = new System.Drawing.Point(479, 113);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(271, 308);
            this.lbData.TabIndex = 2;
            // 
            // ViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 532);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.lbListNames);
            this.Name = "ViewList";
            this.Text = "ViewList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListNames;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.ListBox lbData;
    }
}