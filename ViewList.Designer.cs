
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbListNames
            // 
            this.lbListNames.FormattingEnabled = true;
            this.lbListNames.ItemHeight = 20;
            this.lbListNames.Location = new System.Drawing.Point(14, 141);
            this.lbListNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbListNames.Name = "lbListNames";
            this.lbListNames.Size = new System.Drawing.Size(286, 384);
            this.lbListNames.TabIndex = 0;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(344, 279);
            this.buttonProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(136, 45);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = ">>";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 20;
            this.lbData.Location = new System.Drawing.Point(539, 141);
            this.lbData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(304, 384);
            this.lbData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "VIEW LISTS";
            // 
            // ViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.lbListNames);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewList";
            this.Text = "ViewList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListNames;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Label label1;
    }
}