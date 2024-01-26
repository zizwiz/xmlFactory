
namespace xmlFactory
{
    partial class AircraftName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AircraftName));
            this.btn_aircraftName_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_aircraftName = new System.Windows.Forms.TextBox();
            this.btn_aircraftName_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_aircraftName_exit
            // 
            this.btn_aircraftName_exit.Location = new System.Drawing.Point(25, 146);
            this.btn_aircraftName_exit.Name = "btn_aircraftName_exit";
            this.btn_aircraftName_exit.Size = new System.Drawing.Size(153, 56);
            this.btn_aircraftName_exit.TabIndex = 7;
            this.btn_aircraftName_exit.Text = "Exit";
            this.btn_aircraftName_exit.UseVisualStyleBackColor = true;
            this.btn_aircraftName_exit.Click += new System.EventHandler(this.btn_aircraftName_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aircraft Name:";
            // 
            // txtbx_aircraftName
            // 
            this.txtbx_aircraftName.Location = new System.Drawing.Point(148, 72);
            this.txtbx_aircraftName.Name = "txtbx_aircraftName";
            this.txtbx_aircraftName.Size = new System.Drawing.Size(604, 26);
            this.txtbx_aircraftName.TabIndex = 5;
            // 
            // btn_aircraftName_go
            // 
            this.btn_aircraftName_go.Location = new System.Drawing.Point(599, 146);
            this.btn_aircraftName_go.Name = "btn_aircraftName_go";
            this.btn_aircraftName_go.Size = new System.Drawing.Size(153, 56);
            this.btn_aircraftName_go.TabIndex = 6;
            this.btn_aircraftName_go.Text = "Go";
            this.btn_aircraftName_go.UseVisualStyleBackColor = true;
            this.btn_aircraftName_go.Click += new System.EventHandler(this.btn_aircraftName_go_Click);
            // 
            // AircraftName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 220);
            this.Controls.Add(this.btn_aircraftName_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_aircraftName);
            this.Controls.Add(this.btn_aircraftName_go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AircraftName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aircraft Name ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aircraftName_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_aircraftName;
        private System.Windows.Forms.Button btn_aircraftName_go;
    }
}