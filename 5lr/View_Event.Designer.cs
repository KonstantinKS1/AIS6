
namespace _5lr
{
    partial class View_Event
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
            this.Delete_click5 = new System.Windows.Forms.Button();
            this.Change_click5 = new System.Windows.Forms.Button();
            this.Add_click5 = new System.Windows.Forms.Button();
            this.t_type_event = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.t_data_event = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.t_name_event = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.t_ID_event = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tab_event = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tab_event)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_click5
            // 
            this.Delete_click5.Location = new System.Drawing.Point(7, 284);
            this.Delete_click5.Name = "Delete_click5";
            this.Delete_click5.Size = new System.Drawing.Size(75, 23);
            this.Delete_click5.TabIndex = 13;
            this.Delete_click5.Text = "DELETE";
            this.Delete_click5.UseVisualStyleBackColor = true;
            this.Delete_click5.Click += new System.EventHandler(this.Delete_click5_Click);
            // 
            // Change_click5
            // 
            this.Change_click5.Location = new System.Drawing.Point(7, 254);
            this.Change_click5.Name = "Change_click5";
            this.Change_click5.Size = new System.Drawing.Size(75, 23);
            this.Change_click5.TabIndex = 12;
            this.Change_click5.Text = "CHANGE";
            this.Change_click5.UseVisualStyleBackColor = true;
            this.Change_click5.Click += new System.EventHandler(this.Change_click5_Click);
            // 
            // Add_click5
            // 
            this.Add_click5.Location = new System.Drawing.Point(7, 224);
            this.Add_click5.Name = "Add_click5";
            this.Add_click5.Size = new System.Drawing.Size(75, 23);
            this.Add_click5.TabIndex = 11;
            this.Add_click5.Text = "ADD";
            this.Add_click5.UseVisualStyleBackColor = true;
            this.Add_click5.Click += new System.EventHandler(this.Add_click5_Click);
            // 
            // t_type_event
            // 
            this.t_type_event.Location = new System.Drawing.Point(7, 153);
            this.t_type_event.Name = "t_type_event";
            this.t_type_event.Size = new System.Drawing.Size(100, 20);
            this.t_type_event.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "type event";
            // 
            // t_data_event
            // 
            this.t_data_event.Location = new System.Drawing.Point(7, 109);
            this.t_data_event.Mask = "0000/00/00";
            this.t_data_event.Name = "t_data_event";
            this.t_data_event.Size = new System.Drawing.Size(100, 20);
            this.t_data_event.TabIndex = 6;
            this.t_data_event.ValidatingType = typeof(System.DateTime);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "date";
            // 
            // t_name_event
            // 
            this.t_name_event.Location = new System.Drawing.Point(7, 65);
            this.t_name_event.Name = "t_name_event";
            this.t_name_event.Size = new System.Drawing.Size(100, 20);
            this.t_name_event.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "name event";
            // 
            // t_ID_event
            // 
            this.t_ID_event.Location = new System.Drawing.Point(7, 21);
            this.t_ID_event.Name = "t_ID_event";
            this.t_ID_event.Size = new System.Drawing.Size(100, 20);
            this.t_ID_event.TabIndex = 2;
            this.t_ID_event.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_event_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "id event";
            // 
            // tab_event
            // 
            this.tab_event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_event.Location = new System.Drawing.Point(113, 0);
            this.tab_event.Name = "tab_event";
            this.tab_event.Size = new System.Drawing.Size(682, 445);
            this.tab_event.TabIndex = 0;
            // 
            // View_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 406);
            this.Controls.Add(this.Delete_click5);
            this.Controls.Add(this.Change_click5);
            this.Controls.Add(this.Add_click5);
            this.Controls.Add(this.t_type_event);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.t_data_event);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.t_name_event);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.t_ID_event);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tab_event);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "View_Event";
            this.Text = "APP";
            ((System.ComponentModel.ISupportInitialize)(this.tab_event)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView tab_event;
        private System.Windows.Forms.TextBox t_type_event;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox t_data_event;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox t_name_event;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox t_ID_event;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button Delete_click5;
        private System.Windows.Forms.Button Change_click5;
        private System.Windows.Forms.Button Add_click5;
        #endregion
    }
}