using System;
using System.Windows.Forms;

namespace xmlFactory
{
    public partial class AircraftName : Form
    {
        public AircraftName()
        {
            InitializeComponent();
        }
        public string myAircraftName
        {
            get
            {
                if (txtbx_aircraftName.Text == "")
                {
                    return "error";
                }
                else
                {
                    return txtbx_aircraftName.Text;
                }

            }
        }

        private void btn_aircraftName_go_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_aircraftName_exit_Click(object sender, EventArgs e)
        {
            txtbx_aircraftName.Text = "error";
            Close();
        }
    }
}
