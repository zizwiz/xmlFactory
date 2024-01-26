using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;
using CenteredMessagebox;
using xmlFactory.Properties;

namespace xmlFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data.xml"))
            {
                File.WriteAllText("data.xml", Resources.data);
            }

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            PopulateComplianceDataCmboBx(); //Add aircraft names to combobox

            grpbx_aircraftname_combobx.Visible = true;
            grpbx_aircraftname_new.Visible = false;
        }

        /// <summary>
        /// Populate the combobox in the compliance data from the xml file.
        /// </summary>
        private void PopulateComplianceDataCmboBx()
        {
            cmbobx_aircraftName.Items.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            XmlNode root = doc.DocumentElement;
            XmlNodeList nodeList = root.SelectNodes("aircraft_info");

            foreach (XmlNode aircraft in nodeList)
            {
                cmbobx_aircraftName.Items.Add(aircraft["aircraft_name"].InnerText);
            }

            cmbobx_aircraftName.SelectedIndex = 0;

            GetData(cmbobx_aircraftName.Text);
        }

        private void GetData(string myAircraftName)
        {
            string xQryStr = "//aircraft_info[aircraft_name ='" + myAircraftName + "']";

            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            XmlNodeList listOfNodes = doc.SelectNodes(xQryStr);

            foreach (XmlNode node in listOfNodes)
            {
                txtbx_AftMomentArm.Text = node.SelectSingleNode("AftMomentArm").InnerText;
                txtbx_FwdMomentArm.Text = node.SelectSingleNode("FwdMomentArm").InnerText;
                txtbx_AftCGLimit.Text = node.SelectSingleNode("AftCGLimit").InnerText;
                txtbx_FwdCGLimit.Text = node.SelectSingleNode("FwdCGLimit").InnerText;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbobx_aircraftName_SelectedValueChanged(object sender, EventArgs e)
        {
            GetData(cmbobx_aircraftName.Text);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btn_add.Text == "Add") //If it is add then we ask for a name
            {
                //create a dialog and get the name entered on it
                var aircraftNameForm = new AircraftName();
                aircraftNameForm.ShowDialog();
                string myAircraftName = aircraftNameForm.myAircraftName;

                btn_delete.Visible = false;
                btn_update.Visible = false;
                btn_reset.Visible = false;

                // Check if the name already exists. If it does let user know and do nothing
                //If name does not exist then we can do some work to add it.

                if (myAircraftName == "error")
                {
                    return; //Something wrong so do nothing
                }
                else
                {
                    if (CheckIfAircraftNamExists(myAircraftName))
                    {
                        MsgBox.Show("Cannot add as named aircraft already exists\rChoose aircraft and use update",
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grpbx_aircraftname_combobx.Visible = true;
                        grpbx_aircraftname_new.Visible = false;
                    }
                    else
                    {
                        lbl_new_aircraft.Text = myAircraftName;
                        grpbx_aircraftname_combobx.Visible = false;
                        grpbx_aircraftname_new.Visible = true;
                    }
                }

                GC.Collect();
                btn_add.Text = "Save";
            }
            else if (btn_add.Text == "Save")// if it is save then we save the new aircraft and its information
            {
                btn_delete.Visible = true;
                btn_update.Visible = true;
                btn_reset.Visible = true;
                SaveData(lbl_new_aircraft.Text);
                btn_add.Text = "Add";
                
            }
        }

        private void AddData(string myAircraftName)
        {
            XDocument doc = XDocument.Load("data.xml");
            XElement root = new XElement("aircraft_info");

            root.Add(new XElement("aircraft_name", myAircraftName));
            root.Add(new XElement("AftMomentArm", txtbx_AftMomentArm.Text));
            root.Add(new XElement("FwdMomentArm", txtbx_FwdMomentArm.Text));
            root.Add(new XElement("AftCGLimit", txtbx_AftCGLimit.Text));
            root.Add(new XElement("FwdCGLimit", txtbx_FwdCGLimit.Text));


            doc.Element("compliance_data").Add(root);
            doc.Save("data.xml");
        }

        private bool CheckIfAircraftNamExists(string myAircraftName)
        {
            bool result = true;

            XDocument doc = XDocument.Load("data.xml");

            var matches = doc
                .Descendants("aircraft_info")
                .Where(ft => ((string)ft.Element("aircraft_name")) == myAircraftName);

            if (matches.Count() == 0)
            {
                result = false;
            }

            return result;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData(lbl_new_aircraft.Text);
        }

        private void SaveData(string myAircraftName)
        {
            AddData(myAircraftName);
            PopulateComplianceDataCmboBx();

            cmbobx_aircraftName.SelectedIndex = cmbobx_aircraftName.Items.Count - 1;
            grpbx_aircraftname_combobx.Visible = true;
            grpbx_aircraftname_new.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteData(cmbobx_aircraftName.Text);

            PopulateComplianceDataCmboBx();
            cmbobx_aircraftName.SelectedIndex = 0;
        }

        private bool DeleteData(string myAircraftName)
        {
            bool areYouSure = true;

            if (grpbx_aircraftname_new.Visible)
            {
                //create a dialog to ask if user is sure they want to delete aircraft
                var AreYouSureForm = new AreYouSure(myAircraftName);
                AreYouSureForm.ShowDialog();
                areYouSure = AreYouSureForm.areYouSureToDelete;
            }

            if (areYouSure) //Only delete is yes else ignore
            {
                // create the XML, load the contents
                XmlDocument doc = new XmlDocument();
                doc.Load("data.xml");

                string xQryStr = "//aircraft_info[aircraft_name ='" + myAircraftName + "']";

                XmlNode node = doc.SelectSingleNode(xQryStr);

                // if found....
                if (node != null)
                {
                    // get its parent node
                    XmlNode parent = node.ParentNode;

                    // remove the child node
                    parent.RemoveChild(node);

                    // verify the new XML structure
                    string newXML = doc.OuterXml;

                    // save to file
                    doc.Save(@"data.xml");
                }
            }

            return true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Get hold of the data because we will delete this node next
            string myAircraftName = cmbobx_aircraftName.Text;
            string AftMomentArm = txtbx_AftMomentArm.Text;
            string FwdMomentArm = txtbx_FwdMomentArm.Text;
            string AftCGLimit = txtbx_AftCGLimit.Text;
            string FwdCGLimit = txtbx_FwdCGLimit.Text;

            if (DeleteData(myAircraftName)) //Delete the node
            {
                //Re-add the node with stored information
                XDocument doc = XDocument.Load("data.xml");
                XElement root = new XElement("aircraft_info");

                root.Add(new XElement("aircraft_name", myAircraftName));
                root.Add(new XElement("AftMomentArm", AftMomentArm));
                root.Add(new XElement("FwdMomentArm", FwdMomentArm));
                root.Add(new XElement("AftCGLimit", AftCGLimit));
                root.Add(new XElement("FwdCGLimit", FwdCGLimit));

                doc.Element("compliance_data").Add(root);
                doc.Save("data.xml");

                PopulateComplianceDataCmboBx(); //rebuild the combobox

                cmbobx_aircraftName.SelectedIndex = cmbobx_aircraftName.Items.Count - 1;

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MsgBox.Show("All data will revert to default\rYou will lose any aircraft you have entered", "Information",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (MsgBox.Show("Do you want to backup original files?",
                        "Information",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string ID = DateTime.Now.ToString("dd_MM_yy_H_mm_ss"); //Create a unique ID
                    File.Copy("Data.xml", "Data_" + ID + ".xml"); //save file with unique ID
                }

                if (File.Exists("Data.xml")) File.Delete("Data.xml");
                File.WriteAllText("data.xml", Resources.data);
                PopulateComplianceDataCmboBx();
                cmbobx_aircraftName.SelectedIndex = 0;
            }
            
            btn_delete.Visible = true;
            btn_update.Visible = true;
            btn_reset.Visible = true;
            grpbx_aircraftname_combobx.Visible = true;
            grpbx_aircraftname_new.Visible = false;
        }
    }
}
