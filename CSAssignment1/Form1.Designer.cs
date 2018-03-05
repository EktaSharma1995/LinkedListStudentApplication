namespace CSAssignment1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.textScore = new System.Windows.Forms.TextBox();
            this.textMaxScore = new System.Windows.Forms.TextBox();
            this.add_Btn_Click = new System.Windows.Forms.Button();
            this.display_Btn_Click = new System.Windows.Forms.Button();
            this.remove_Btn_Click = new System.Windows.Forms.Button();
            this.update_Btn_Click = new System.Windows.Forms.Button();
            this.stu_List = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TestId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maximum Test Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(140, 20);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 6;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(140, 66);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 7;
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(140, 118);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(100, 20);
            this.textScore.TabIndex = 8;
            // 
            // textMaxScore
            // 
            this.textMaxScore.Location = new System.Drawing.Point(140, 165);
            this.textMaxScore.Name = "textMaxScore";
            this.textMaxScore.Size = new System.Drawing.Size(100, 20);
            this.textMaxScore.TabIndex = 9;
            // 
            // add_Btn_Click
            // 
            this.add_Btn_Click.Location = new System.Drawing.Point(27, 226);
            this.add_Btn_Click.Name = "add_Btn_Click";
            this.add_Btn_Click.Size = new System.Drawing.Size(75, 23);
            this.add_Btn_Click.TabIndex = 12;
            this.add_Btn_Click.Text = "Add";
            this.add_Btn_Click.UseVisualStyleBackColor = true;
            this.add_Btn_Click.Click += new System.EventHandler(this.add_Btn_Click_Click);
            // 
            // display_Btn_Click
            // 
            this.display_Btn_Click.Location = new System.Drawing.Point(182, 226);
            this.display_Btn_Click.Name = "display_Btn_Click";
            this.display_Btn_Click.Size = new System.Drawing.Size(75, 23);
            this.display_Btn_Click.TabIndex = 13;
            this.display_Btn_Click.Text = "Display";
            this.display_Btn_Click.UseVisualStyleBackColor = true;
            this.display_Btn_Click.Click += new System.EventHandler(this.display_Btn_Click_Click);
            // 
            // remove_Btn_Click
            // 
            this.remove_Btn_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_Btn_Click.Location = new System.Drawing.Point(354, 226);
            this.remove_Btn_Click.Name = "remove_Btn_Click";
            this.remove_Btn_Click.Size = new System.Drawing.Size(75, 23);
            this.remove_Btn_Click.TabIndex = 14;
            this.remove_Btn_Click.Text = "Remove";
            this.remove_Btn_Click.UseVisualStyleBackColor = true;
            this.remove_Btn_Click.Click += new System.EventHandler(this.remove_Btn_Click_Click);
            // 
            // update_Btn_Click
            // 
            this.update_Btn_Click.Location = new System.Drawing.Point(531, 226);
            this.update_Btn_Click.Name = "update_Btn_Click";
            this.update_Btn_Click.Size = new System.Drawing.Size(75, 23);
            this.update_Btn_Click.TabIndex = 15;
            this.update_Btn_Click.Text = "Update";
            this.update_Btn_Click.UseVisualStyleBackColor = true;
            this.update_Btn_Click.Click += new System.EventHandler(this.Update_Click);
            // 
            // stu_List
            // 
            this.stu_List.FormattingEnabled = true;
            this.stu_List.Location = new System.Drawing.Point(332, 20);
            this.stu_List.Name = "stu_List";
            this.stu_List.Size = new System.Drawing.Size(289, 173);
            this.stu_List.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(94, 264);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 289);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.stu_List);
            this.Controls.Add(this.update_Btn_Click);
            this.Controls.Add(this.remove_Btn_Click);
            this.Controls.Add(this.display_Btn_Click);
            this.Controls.Add(this.add_Btn_Click);
            this.Controls.Add(this.textMaxScore);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.TextBox textMaxScore;
        private System.Windows.Forms.Button add_Btn_Click;
        private System.Windows.Forms.Button display_Btn_Click;
        private System.Windows.Forms.Button remove_Btn_Click;
        private System.Windows.Forms.Button update_Btn_Click;
        private System.Windows.Forms.ListBox stu_List;
        private System.Windows.Forms.Label lblMessage;
    }
}

