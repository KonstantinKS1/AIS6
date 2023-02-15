
namespace _5lr
{
    partial class View_Obj_Pop
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
            this.Delete_click2 = new System.Windows.Forms.Button();
            this.Change_click2 = new System.Windows.Forms.Button();
            this.Add_click2 = new System.Windows.Forms.Button();
            this.t_num_pop = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.t_data_e = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.t_ID_Obj_pop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tab_Obj_pop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Obj_pop)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_click2
            // 
            this.Delete_click2.Location = new System.Drawing.Point(8, 198);
            this.Delete_click2.Name = "Delete_click2";
            this.Delete_click2.Size = new System.Drawing.Size(75, 23);
            this.Delete_click2.TabIndex = 9;
            this.Delete_click2.Text = "DELETE";
            this.Delete_click2.UseVisualStyleBackColor = true;
            this.Delete_click2.Click += new System.EventHandler(this.Delete_click2_Click);
            // 
            // Change_click2
            // 
            this.Change_click2.Location = new System.Drawing.Point(8, 168);
            this.Change_click2.Name = "Change_click2";
            this.Change_click2.Size = new System.Drawing.Size(75, 23);
            this.Change_click2.TabIndex = 8;
            this.Change_click2.Text = "CHANGE";
            this.Change_click2.UseVisualStyleBackColor = true;
            this.Change_click2.Click += new System.EventHandler(this.Change_click2_Click);
            // 
            // Add_click2
            // 
            this.Add_click2.Location = new System.Drawing.Point(8, 138);
            this.Add_click2.Name = "Add_click2";
            this.Add_click2.Size = new System.Drawing.Size(75, 23);
            this.Add_click2.TabIndex = 7;
            this.Add_click2.Text = "ADD";
            this.Add_click2.UseVisualStyleBackColor = true;
            this.Add_click2.Click += new System.EventHandler(this.Add_click2_Click);
            // 
            // t_num_pop
            // 
            this.t_num_pop.Location = new System.Drawing.Point(8, 111);
            this.t_num_pop.Name = "t_num_pop";
            this.t_num_pop.Size = new System.Drawing.Size(100, 20);
            this.t_num_pop.TabIndex = 6;
            this.t_num_pop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_Obj_pop_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "number population";
            // 
            // t_data_e
            // 
            this.t_data_e.Location = new System.Drawing.Point(8, 67);
            this.t_data_e.Mask = "0000/00/00";
            this.t_data_e.Name = "t_data_e";
            this.t_data_e.Size = new System.Drawing.Size(100, 20);
            this.t_data_e.TabIndex = 4;
            this.t_data_e.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "date event";
            // 
            // t_ID_Obj_pop
            // 
            this.t_ID_Obj_pop.Location = new System.Drawing.Point(8, 23);
            this.t_ID_Obj_pop.Name = "t_ID_Obj_pop";
            this.t_ID_Obj_pop.Size = new System.Drawing.Size(100, 20);
            this.t_ID_Obj_pop.TabIndex = 2;
            this.t_ID_Obj_pop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_Obj_pop_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "id object pop";
            // 
            // tab_Obj_pop
            // 
            this.tab_Obj_pop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_Obj_pop.Location = new System.Drawing.Point(114, 6);
            this.tab_Obj_pop.Name = "tab_Obj_pop";
            this.tab_Obj_pop.Size = new System.Drawing.Size(682, 438);
            this.tab_Obj_pop.TabIndex = 0;
            // 
            // View_Obj_Pop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 451);
            this.Controls.Add(this.Delete_click2);
            this.Controls.Add(this.Change_click2);
            this.Controls.Add(this.Add_click2);
            this.Controls.Add(this.t_num_pop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.t_data_e);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t_ID_Obj_pop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tab_Obj_pop);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "View_Obj_Pop";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "APP";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_Obj_pop_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tab_Obj_pop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataGridView tab_Obj_pop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Delete_click2;
        private System.Windows.Forms.Button Change_click2;
        private System.Windows.Forms.Button Add_click2;
        private System.Windows.Forms.TextBox t_num_pop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox t_data_e;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_ID_Obj_pop;
        

    }
}