
namespace _5lr
{
    partial class View_Status_Onwer
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
            this.Delete_click4 = new System.Windows.Forms.Button();
            this.Change_click4 = new System.Windows.Forms.Button();
            this.Add_click4 = new System.Windows.Forms.Button();
            this.t_name_st = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.t_ID_status = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tab_status_onwer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tab_status_onwer)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_click4
            // 
            this.Delete_click4.Location = new System.Drawing.Point(7, 152);
            this.Delete_click4.Name = "Delete_click4";
            this.Delete_click4.Size = new System.Drawing.Size(75, 23);
            this.Delete_click4.TabIndex = 7;
            this.Delete_click4.Text = "DELETE";
            this.Delete_click4.UseVisualStyleBackColor = true;
            this.Delete_click4.Click += new System.EventHandler(this.Delete_click4_Click);
            // 
            // Change_click4
            // 
            this.Change_click4.Location = new System.Drawing.Point(7, 122);
            this.Change_click4.Name = "Change_click4";
            this.Change_click4.Size = new System.Drawing.Size(75, 23);
            this.Change_click4.TabIndex = 6;
            this.Change_click4.Text = "CHANGE";
            this.Change_click4.UseVisualStyleBackColor = true;
            this.Change_click4.Click += new System.EventHandler(this.Change_click4_Click);
            // 
            // Add_click4
            // 
            this.Add_click4.Location = new System.Drawing.Point(7, 92);
            this.Add_click4.Name = "Add_click4";
            this.Add_click4.Size = new System.Drawing.Size(75, 23);
            this.Add_click4.TabIndex = 5;
            this.Add_click4.Text = "ADD";
            this.Add_click4.UseVisualStyleBackColor = true;
            this.Add_click4.Click += new System.EventHandler(this.Add_click4_Click);
            // 
            // t_name_st
            // 
            this.t_name_st.Location = new System.Drawing.Point(7, 65);
            this.t_name_st.Name = "t_name_st";
            this.t_name_st.Size = new System.Drawing.Size(100, 20);
            this.t_name_st.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "name status";
            // 
            // t_ID_status
            // 
            this.t_ID_status.Location = new System.Drawing.Point(7, 21);
            this.t_ID_status.Name = "t_ID_status";
            this.t_ID_status.Size = new System.Drawing.Size(100, 20);
            this.t_ID_status.TabIndex = 2;
            this.t_ID_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_status_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "id status";
            // 
            // tab_status_onwer
            // 
            this.tab_status_onwer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_status_onwer.Location = new System.Drawing.Point(113, 0);
            this.tab_status_onwer.Name = "tab_status_onwer";
            this.tab_status_onwer.Size = new System.Drawing.Size(682, 445);
            this.tab_status_onwer.TabIndex = 0;
            // 
            // View_Status_Onwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_click4);
            this.Controls.Add(this.Change_click4);
            this.Controls.Add(this.Add_click4);
            this.Controls.Add(this.t_name_st);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.t_ID_status);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tab_status_onwer);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "View_Status_Onwer";
            this.Text = "View_Status_Onwer";
            ((System.ComponentModel.ISupportInitialize)(this.tab_status_onwer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView tab_status_onwer;
        private System.Windows.Forms.Button Delete_click4;
        private System.Windows.Forms.Button Change_click4;
        private System.Windows.Forms.Button Add_click4;
        private System.Windows.Forms.TextBox t_name_st;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox t_ID_status;
        private System.Windows.Forms.Label label18;
        #endregion
    }
}