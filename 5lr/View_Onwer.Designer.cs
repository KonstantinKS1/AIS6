
namespace _5lr
{
    partial class View_Onwer
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
            this.Delete_click3 = new System.Windows.Forms.Button();
            this.Change_click3 = new System.Windows.Forms.Button();
            this.Add_click3 = new System.Windows.Forms.Button();
            this.t_status = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.t_data_open = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.t_tel_num = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.t_FIO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.t_name_onwer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.t_ID_onwer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tab_onwer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tab_onwer)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_click3
            // 
            this.Delete_click3.Location = new System.Drawing.Point(7, 324);
            this.Delete_click3.Name = "Delete_click3";
            this.Delete_click3.Size = new System.Drawing.Size(75, 23);
            this.Delete_click3.TabIndex = 15;
            this.Delete_click3.Text = "DELETE";
            this.Delete_click3.UseVisualStyleBackColor = true;
            this.Delete_click3.Click += new System.EventHandler(this.Delete_click3_Click);
            // 
            // Change_click3
            // 
            this.Change_click3.Location = new System.Drawing.Point(7, 294);
            this.Change_click3.Name = "Change_click3";
            this.Change_click3.Size = new System.Drawing.Size(75, 23);
            this.Change_click3.TabIndex = 14;
            this.Change_click3.Text = "CHANGE";
            this.Change_click3.UseVisualStyleBackColor = true;
            this.Change_click3.Click += new System.EventHandler(this.Change_click3_Click);
            // 
            // Add_click3
            // 
            this.Add_click3.Location = new System.Drawing.Point(7, 264);
            this.Add_click3.Name = "Add_click3";
            this.Add_click3.Size = new System.Drawing.Size(75, 23);
            this.Add_click3.TabIndex = 13;
            this.Add_click3.Text = "ADD";
            this.Add_click3.UseVisualStyleBackColor = true;
            this.Add_click3.Click += new System.EventHandler(this.Add_click3_Click);
            // 
            // t_status
            // 
            this.t_status.Location = new System.Drawing.Point(7, 237);
            this.t_status.Name = "t_status";
            this.t_status.Size = new System.Drawing.Size(100, 20);
            this.t_status.TabIndex = 12;
            this.t_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_onwer_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "id status";
            // 
            // t_data_open
            // 
            this.t_data_open.Location = new System.Drawing.Point(7, 197);
            this.t_data_open.Mask = "0000/00/00";
            this.t_data_open.Name = "t_data_open";
            this.t_data_open.Size = new System.Drawing.Size(100, 20);
            this.t_data_open.TabIndex = 10;
            this.t_data_open.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Date open";
            // 
            // t_tel_num
            // 
            this.t_tel_num.Location = new System.Drawing.Point(7, 153);
            this.t_tel_num.Name = "t_tel_num";
            this.t_tel_num.Size = new System.Drawing.Size(100, 20);
            this.t_tel_num.TabIndex = 8;
            this.t_tel_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_onwer_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "telephone number";
            // 
            // t_FIO
            // 
            this.t_FIO.Location = new System.Drawing.Point(7, 109);
            this.t_FIO.Name = "t_FIO";
            this.t_FIO.Size = new System.Drawing.Size(100, 20);
            this.t_FIO.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "FIO";
            // 
            // t_name_onwer
            // 
            this.t_name_onwer.Location = new System.Drawing.Point(7, 65);
            this.t_name_onwer.Name = "t_name_onwer";
            this.t_name_onwer.Size = new System.Drawing.Size(100, 20);
            this.t_name_onwer.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "name";
            // 
            // t_ID_onwer
            // 
            this.t_ID_onwer.Location = new System.Drawing.Point(7, 21);
            this.t_ID_onwer.Name = "t_ID_onwer";
            this.t_ID_onwer.Size = new System.Drawing.Size(100, 20);
            this.t_ID_onwer.TabIndex = 2;
            this.t_ID_onwer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_onwer_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "id onwer";
            // 
            // tab_onwer
            // 
            this.tab_onwer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_onwer.Location = new System.Drawing.Point(113, 0);
            this.tab_onwer.Name = "tab_onwer";
            this.tab_onwer.Size = new System.Drawing.Size(682, 445);
            this.tab_onwer.TabIndex = 0;
            // 
            // View_Onwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 406);
            this.Controls.Add(this.Delete_click3);
            this.Controls.Add(this.Change_click3);
            this.Controls.Add(this.Add_click3);
            this.Controls.Add(this.t_status);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.t_data_open);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.t_tel_num);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.t_FIO);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.t_name_onwer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.t_ID_onwer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tab_onwer);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "View_Onwer";
            this.Text = "APP";
            ((System.ComponentModel.ISupportInitialize)(this.tab_onwer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView tab_onwer;
        private System.Windows.Forms.TextBox t_status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox t_data_open;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox t_tel_num;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox t_FIO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox t_name_onwer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox t_ID_onwer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Delete_click3;
        private System.Windows.Forms.Button Change_click3;
        private System.Windows.Forms.Button Add_click3;
        #endregion
    }
}