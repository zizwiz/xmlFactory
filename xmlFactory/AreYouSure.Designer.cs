﻿
namespace xmlFactory
{
    partial class AreYouSure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreYouSure));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_areyousure_delete_aircraft = new System.Windows.Forms.Label();
            this.btn_areyousure_no = new System.Windows.Forms.Button();
            this.btn_areyousure_yes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to delete the following aircraft: ";
            // 
            // lbl_areyousure_delete_aircraft
            // 
            this.lbl_areyousure_delete_aircraft.AutoSize = true;
            this.lbl_areyousure_delete_aircraft.Location = new System.Drawing.Point(411, 44);
            this.lbl_areyousure_delete_aircraft.Name = "lbl_areyousure_delete_aircraft";
            this.lbl_areyousure_delete_aircraft.Size = new System.Drawing.Size(25, 20);
            this.lbl_areyousure_delete_aircraft.TabIndex = 1;
            this.lbl_areyousure_delete_aircraft.Text = "....";
            // 
            // btn_areyousure_no
            // 
            this.btn_areyousure_no.Location = new System.Drawing.Point(48, 119);
            this.btn_areyousure_no.Name = "btn_areyousure_no";
            this.btn_areyousure_no.Size = new System.Drawing.Size(118, 46);
            this.btn_areyousure_no.TabIndex = 2;
            this.btn_areyousure_no.Text = "No";
            this.btn_areyousure_no.UseVisualStyleBackColor = true;
            this.btn_areyousure_no.Click += new System.EventHandler(this.btn_areyousure_no_Click);
            // 
            // btn_areyousure_yes
            // 
            this.btn_areyousure_yes.Location = new System.Drawing.Point(464, 119);
            this.btn_areyousure_yes.Name = "btn_areyousure_yes";
            this.btn_areyousure_yes.Size = new System.Drawing.Size(118, 46);
            this.btn_areyousure_yes.TabIndex = 3;
            this.btn_areyousure_yes.Text = "Yes";
            this.btn_areyousure_yes.UseVisualStyleBackColor = true;
            this.btn_areyousure_yes.Click += new System.EventHandler(this.btn_areyousure_yes_Click);
            // 
            // AreYouSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 194);
            this.Controls.Add(this.btn_areyousure_yes);
            this.Controls.Add(this.btn_areyousure_no);
            this.Controls.Add(this.lbl_areyousure_delete_aircraft);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AreYouSure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Are You Sure?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_areyousure_delete_aircraft;
        private System.Windows.Forms.Button btn_areyousure_no;
        private System.Windows.Forms.Button btn_areyousure_yes;
    }
}