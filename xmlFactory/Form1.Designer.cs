
namespace xmlFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbobx_aircraftName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_AftMomentArm = new System.Windows.Forms.TextBox();
            this.txtbx_AftCGLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_FwdMomentArm = new System.Windows.Forms.TextBox();
            this.txtbx_FwdCGLimit = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_new_aircraft = new System.Windows.Forms.Label();
            this.grpbx_aircraftname_combobx = new System.Windows.Forms.GroupBox();
            this.grpbx_aircraftname_new = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.grpbx_aircraftname_combobx.SuspendLayout();
            this.grpbx_aircraftname_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbobx_aircraftName
            // 
            this.cmbobx_aircraftName.FormattingEnabled = true;
            this.cmbobx_aircraftName.Location = new System.Drawing.Point(168, 20);
            this.cmbobx_aircraftName.Name = "cmbobx_aircraftName";
            this.cmbobx_aircraftName.Size = new System.Drawing.Size(315, 28);
            this.cmbobx_aircraftName.TabIndex = 1;
            this.cmbobx_aircraftName.SelectedValueChanged += new System.EventHandler(this.cmbobx_aircraftName_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aircraft Names";
            // 
            // txtbx_AftMomentArm
            // 
            this.txtbx_AftMomentArm.Location = new System.Drawing.Point(170, 111);
            this.txtbx_AftMomentArm.Name = "txtbx_AftMomentArm";
            this.txtbx_AftMomentArm.Size = new System.Drawing.Size(125, 26);
            this.txtbx_AftMomentArm.TabIndex = 3;
            // 
            // txtbx_AftCGLimit
            // 
            this.txtbx_AftCGLimit.Location = new System.Drawing.Point(170, 175);
            this.txtbx_AftCGLimit.Name = "txtbx_AftCGLimit";
            this.txtbx_AftCGLimit.Size = new System.Drawing.Size(125, 26);
            this.txtbx_AftCGLimit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "AftMomentArm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "AftCGLimit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "FwdMomentArm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "FwdCGLimit";
            // 
            // txtbx_FwdMomentArm
            // 
            this.txtbx_FwdMomentArm.Location = new System.Drawing.Point(453, 111);
            this.txtbx_FwdMomentArm.Name = "txtbx_FwdMomentArm";
            this.txtbx_FwdMomentArm.Size = new System.Drawing.Size(125, 26);
            this.txtbx_FwdMomentArm.TabIndex = 11;
            // 
            // txtbx_FwdCGLimit
            // 
            this.txtbx_FwdCGLimit.Location = new System.Drawing.Point(453, 172);
            this.txtbx_FwdCGLimit.Name = "txtbx_FwdCGLimit";
            this.txtbx_FwdCGLimit.Size = new System.Drawing.Size(125, 26);
            this.txtbx_FwdCGLimit.TabIndex = 12;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(482, 249);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 38);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(54, 249);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 38);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(161, 249);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 38);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(268, 249);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 38);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_new_aircraft
            // 
            this.lbl_new_aircraft.AutoSize = true;
            this.lbl_new_aircraft.Location = new System.Drawing.Point(174, 23);
            this.lbl_new_aircraft.Name = "lbl_new_aircraft";
            this.lbl_new_aircraft.Size = new System.Drawing.Size(141, 20);
            this.lbl_new_aircraft.TabIndex = 18;
            this.lbl_new_aircraft.Text = "New Aircraft Name";
            // 
            // grpbx_aircraftname_combobx
            // 
            this.grpbx_aircraftname_combobx.Controls.Add(this.label1);
            this.grpbx_aircraftname_combobx.Controls.Add(this.cmbobx_aircraftName);
            this.grpbx_aircraftname_combobx.Location = new System.Drawing.Point(58, 12);
            this.grpbx_aircraftname_combobx.Name = "grpbx_aircraftname_combobx";
            this.grpbx_aircraftname_combobx.Size = new System.Drawing.Size(519, 73);
            this.grpbx_aircraftname_combobx.TabIndex = 19;
            this.grpbx_aircraftname_combobx.TabStop = false;
            // 
            // grpbx_aircraftname_new
            // 
            this.grpbx_aircraftname_new.Controls.Add(this.label6);
            this.grpbx_aircraftname_new.Controls.Add(this.lbl_new_aircraft);
            this.grpbx_aircraftname_new.Location = new System.Drawing.Point(54, 18);
            this.grpbx_aircraftname_new.Name = "grpbx_aircraftname_new";
            this.grpbx_aircraftname_new.Size = new System.Drawing.Size(517, 67);
            this.grpbx_aircraftname_new.TabIndex = 20;
            this.grpbx_aircraftname_new.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Now adding aircraft = ";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(375, 249);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(101, 38);
            this.btn_reset.TabIndex = 21;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 321);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.grpbx_aircraftname_new);
            this.Controls.Add(this.grpbx_aircraftname_combobx);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txtbx_FwdCGLimit);
            this.Controls.Add(this.txtbx_FwdMomentArm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_AftCGLimit);
            this.Controls.Add(this.txtbx_AftMomentArm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xmlFactory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbx_aircraftname_combobx.ResumeLayout(false);
            this.grpbx_aircraftname_combobx.PerformLayout();
            this.grpbx_aircraftname_new.ResumeLayout(false);
            this.grpbx_aircraftname_new.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbobx_aircraftName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_AftMomentArm;
        private System.Windows.Forms.TextBox txtbx_AftCGLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_FwdMomentArm;
        private System.Windows.Forms.TextBox txtbx_FwdCGLimit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_new_aircraft;
        private System.Windows.Forms.GroupBox grpbx_aircraftname_combobx;
        private System.Windows.Forms.GroupBox grpbx_aircraftname_new;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reset;
    }
}

