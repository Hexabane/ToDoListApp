
namespace ToDoListApp
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.buttonViewList = new System.Windows.Forms.Button();
            this.buttonEditLists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO DO LIST APP";
            // 
            // buttonAddList
            // 
            this.buttonAddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddList.Location = new System.Drawing.Point(245, 181);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(161, 63);
            this.buttonAddList.TabIndex = 1;
            this.buttonAddList.Text = "Add List";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // buttonViewList
            // 
            this.buttonViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewList.Location = new System.Drawing.Point(245, 275);
            this.buttonViewList.Name = "buttonViewList";
            this.buttonViewList.Size = new System.Drawing.Size(161, 63);
            this.buttonViewList.TabIndex = 2;
            this.buttonViewList.Text = "View List";
            this.buttonViewList.UseVisualStyleBackColor = true;
            this.buttonViewList.Click += new System.EventHandler(this.buttonViewList_Click);
            // 
            // buttonEditLists
            // 
            this.buttonEditLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditLists.Location = new System.Drawing.Point(245, 365);
            this.buttonEditLists.Name = "buttonEditLists";
            this.buttonEditLists.Size = new System.Drawing.Size(161, 63);
            this.buttonEditLists.TabIndex = 3;
            this.buttonEditLists.Text = "Edit Lists";
            this.buttonEditLists.UseVisualStyleBackColor = true;
            this.buttonEditLists.Click += new System.EventHandler(this.buttonEditLists_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.buttonEditLists);
            this.Controls.Add(this.buttonViewList);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Button buttonViewList;
        private System.Windows.Forms.Button buttonEditLists;
    }
}

