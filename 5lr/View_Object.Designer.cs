
namespace _5lr
{
    partial class View_Object
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete_click = new System.Windows.Forms.Button();
            this.Change_click = new System.Windows.Forms.Button();
            this.Add_click = new System.Windows.Forms.Button();
            this.t_onwer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_event = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_obj_pop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_num_of_Seats = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_address_Obj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_type_Obj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_ID_obj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_name_obj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Object = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objPopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusOnwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Object)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete_click
            // 
            this.Delete_click.Location = new System.Drawing.Point(6, 449);
            this.Delete_click.Name = "Delete_click";
            this.Delete_click.Size = new System.Drawing.Size(75, 23);
            this.Delete_click.TabIndex = 19;
            this.Delete_click.Text = "DELETE";
            this.Delete_click.UseVisualStyleBackColor = true;
            this.Delete_click.Click += new System.EventHandler(this.Delete_click_Click);
            // 
            // Change_click
            // 
            this.Change_click.Location = new System.Drawing.Point(6, 419);
            this.Change_click.Name = "Change_click";
            this.Change_click.Size = new System.Drawing.Size(75, 23);
            this.Change_click.TabIndex = 18;
            this.Change_click.Text = "CHANGE";
            this.Change_click.UseVisualStyleBackColor = true;
            this.Change_click.Click += new System.EventHandler(this.Change_click_Click);
            // 
            // Add_click
            // 
            this.Add_click.Location = new System.Drawing.Point(6, 389);
            this.Add_click.Name = "Add_click";
            this.Add_click.Size = new System.Drawing.Size(75, 23);
            this.Add_click.TabIndex = 17;
            this.Add_click.Text = "ADD";
            this.Add_click.UseVisualStyleBackColor = true;
            this.Add_click.Click += new System.EventHandler(this.Add_click_Click);
            // 
            // t_onwer
            // 
            this.t_onwer.Location = new System.Drawing.Point(6, 362);
            this.t_onwer.Name = "t_onwer";
            this.t_onwer.Size = new System.Drawing.Size(100, 20);
            this.t_onwer.TabIndex = 16;
            this.t_onwer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_obj_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "id onwer";
            // 
            // t_event
            // 
            this.t_event.Location = new System.Drawing.Point(6, 318);
            this.t_event.Name = "t_event";
            this.t_event.Size = new System.Drawing.Size(100, 20);
            this.t_event.TabIndex = 14;
            this.t_event.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_obj_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "id event";
            // 
            // t_obj_pop
            // 
            this.t_obj_pop.Location = new System.Drawing.Point(6, 274);
            this.t_obj_pop.Name = "t_obj_pop";
            this.t_obj_pop.Size = new System.Drawing.Size(100, 20);
            this.t_obj_pop.TabIndex = 12;
            this.t_obj_pop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_obj_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "id object pop";
            // 
            // t_num_of_Seats
            // 
            this.t_num_of_Seats.Location = new System.Drawing.Point(6, 230);
            this.t_num_of_Seats.Name = "t_num_of_Seats";
            this.t_num_of_Seats.Size = new System.Drawing.Size(100, 20);
            this.t_num_of_Seats.TabIndex = 10;
            this.t_num_of_Seats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_obj_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "number of seats";
            // 
            // t_address_Obj
            // 
            this.t_address_Obj.Location = new System.Drawing.Point(6, 186);
            this.t_address_Obj.Name = "t_address_Obj";
            this.t_address_Obj.Size = new System.Drawing.Size(100, 20);
            this.t_address_Obj.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address object";
            // 
            // t_type_Obj
            // 
            this.t_type_Obj.Location = new System.Drawing.Point(6, 142);
            this.t_type_Obj.Name = "t_type_Obj";
            this.t_type_Obj.Size = new System.Drawing.Size(100, 20);
            this.t_type_Obj.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type object";
            // 
            // t_ID_obj
            // 
            this.t_ID_obj.Location = new System.Drawing.Point(6, 53);
            this.t_ID_obj.Name = "t_ID_obj";
            this.t_ID_obj.Size = new System.Drawing.Size(100, 20);
            this.t_ID_obj.TabIndex = 4;
            this.t_ID_obj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_obj_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name object";
            // 
            // t_name_obj
            // 
            this.t_name_obj.Location = new System.Drawing.Point(6, 102);
            this.t_name_obj.Name = "t_name_obj";
            this.t_name_obj.Size = new System.Drawing.Size(100, 20);
            this.t_name_obj.TabIndex = 2;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Object";
            // 
            // tab_Object
            // 
            this.tab_Object.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_Object.Location = new System.Drawing.Point(112, 30);
            this.tab_Object.Name = "tab_Object";
            this.tab_Object.Size = new System.Drawing.Size(682, 445);
            this.tab_Object.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEventToolStripMenuItem,
            this.objPopToolStripMenuItem,
            this.onwerToolStripMenuItem,
            this.statusOnwerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewEventToolStripMenuItem
            // 
            this.viewEventToolStripMenuItem.Name = "viewEventToolStripMenuItem";
            this.viewEventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.viewEventToolStripMenuItem.Text = "Event";
            this.viewEventToolStripMenuItem.Click += new System.EventHandler(this.viewEventToolStripMenuItem_Click);
            // 
            // objPopToolStripMenuItem
            // 
            this.objPopToolStripMenuItem.Name = "objPopToolStripMenuItem";
            this.objPopToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.objPopToolStripMenuItem.Text = "Obj_Pop";
            this.objPopToolStripMenuItem.Click += new System.EventHandler(this.objPopToolStripMenuItem_Click);
            // 
            // onwerToolStripMenuItem
            // 
            this.onwerToolStripMenuItem.Name = "onwerToolStripMenuItem";
            this.onwerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.onwerToolStripMenuItem.Text = "Onwer";
            this.onwerToolStripMenuItem.Click += new System.EventHandler(this.onwerToolStripMenuItem_Click);
            // 
            // statusOnwerToolStripMenuItem
            // 
            this.statusOnwerToolStripMenuItem.Name = "statusOnwerToolStripMenuItem";
            this.statusOnwerToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.statusOnwerToolStripMenuItem.Text = "Status_Onwer";
            this.statusOnwerToolStripMenuItem.Click += new System.EventHandler(this.statusOnwerToolStripMenuItem_Click);
            // 
            // View_Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.Delete_click);
            this.Controls.Add(this.Change_click);
            this.Controls.Add(this.Add_click);
            this.Controls.Add(this.t_onwer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t_event);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_obj_pop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_num_of_Seats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_address_Obj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_type_Obj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_ID_obj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_name_obj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_Object);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(4, 22);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "View_Object";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "APP";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ID_obj_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tab_Object)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

         }

        //#endregion

        //                private System.Windows.Forms.TabControl tabControl1;
        //              private System.Windows.Forms.TabPage View_Object;
        private System.Windows.Forms.DataGridView tab_Object;
        //               private System.Windows.Forms.TabPage View_Obj_Pop;
        //        private System.Windows.Forms.DataGridView tab_Obj_pop;
        //             private System.Windows.Forms.TabPage View_Onwer;
        //         private System.Windows.Forms.DataGridView tab_onwer;
        //            private System.Windows.Forms.TabPage View_Status_Onwer;
        //                private System.Windows.Forms.DataGridView tab_status_onwer;
        //          private System.Windows.Forms.TabPage View_Event;
        //                  private System.Windows.Forms.DataGridView tab_event;
        private System.Windows.Forms.TextBox t_num_of_Seats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_address_Obj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_type_Obj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_ID_obj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_name_obj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Change_click;
        private System.Windows.Forms.Button Add_click;
        private System.Windows.Forms.TextBox t_onwer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_event;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_obj_pop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete_click;
        //        private System.Windows.Forms.Label label9;
        //        private System.Windows.Forms.Button Delete_click2;
        //        private System.Windows.Forms.Button Change_click2;
        //        private System.Windows.Forms.Button Add_click2;
        //        private System.Windows.Forms.TextBox t_num_pop;
        //        private System.Windows.Forms.Label label11;
        //       private System.Windows.Forms.MaskedTextBox t_data_e;
        //        private System.Windows.Forms.Label label10;
        //        private System.Windows.Forms.TextBox t_ID_Obj_pop;
        /*                   private System.Windows.Forms.TextBox t_status;
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
                           private System.Windows.Forms.Button Add_click3;*/
        /*    private System.Windows.Forms.Button Delete_click4;
            private System.Windows.Forms.Button Change_click4;
            private System.Windows.Forms.Button Add_click4;
            private System.Windows.Forms.TextBox t_name_st;
            private System.Windows.Forms.Label label19;
            private System.Windows.Forms.TextBox t_ID_status;
            private System.Windows.Forms.Label label18;
//                   private System.Windows.Forms.TextBox t_type_event;
//                   private System.Windows.Forms.Label label23;
////                   private System.Windows.Forms.MaskedTextBox t_data_event;
//                   private System.Windows.Forms.Label label22;
//                   private System.Windows.Forms.TextBox t_name_event;
//                   private System.Windows.Forms.Label label21;
////                   private System.Windows.Forms.TextBox t_ID_event;
//                   private System.Windows.Forms.Label label20;
//                   private System.Windows.Forms.Button Delete_click5;
//                   private System.Windows.Forms.Button Change_click5;
//                   private System.Windows.Forms.Button Add_click5;*/
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objPopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusOnwerToolStripMenuItem;
    }
    }


