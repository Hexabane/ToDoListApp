
namespace ToDoListApp
{
    partial class EditLists
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
            this.lbViewList = new System.Windows.Forms.ListBox();
            this.tbEventType = new System.Windows.Forms.TextBox();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.dtpWhen = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbViewList
            // 
            this.lbViewList.FormattingEnabled = true;
            this.lbViewList.ItemHeight = 16;
            this.lbViewList.Location = new System.Drawing.Point(38, 86);
            this.lbViewList.Name = "lbViewList";
            this.lbViewList.Size = new System.Drawing.Size(189, 388);
            this.lbViewList.TabIndex = 0;
            this.lbViewList.SelectedIndexChanged += new System.EventHandler(this.lbViewList_SelectedIndexChanged);
            // 
            // tbEventType
            // 
            this.tbEventType.Location = new System.Drawing.Point(574, 210);
            this.tbEventType.Name = "tbEventType";
            this.tbEventType.Size = new System.Drawing.Size(200, 22);
            this.tbEventType.TabIndex = 13;
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(574, 139);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(200, 22);
            this.tbEventName.TabIndex = 12;
            // 
            // dtpWhen
            // 
            this.dtpWhen.Location = new System.Drawing.Point(574, 281);
            this.dtpWhen.Name = "dtpWhen";
            this.dtpWhen.Size = new System.Drawing.Size(200, 22);
            this.dtpWhen.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Do It by When : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type Of Activity/Event : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Acttivity/Event Name : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "EDIT LIST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEventType);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.dtpWhen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbViewList);
            this.Name = "EditLists";
            this.Text = "EditLists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbViewList;
        private System.Windows.Forms.TextBox tbEventType;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.DateTimePicker dtpWhen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}