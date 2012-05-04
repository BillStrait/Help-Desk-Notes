using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
<<<<<<< HEAD
using System.IO;
using System.Xml;
using System.Security;
=======

>>>>>>> a649b4c37807889e279882f9c96323aebec7c276



namespace Notes
{
    public partial class Form1 : Form
    {       
<<<<<<< HEAD
        //this int is to keep tabs on how many prefabs were loaded from our xml document
        int numOfPrefabs = 0;
        string[,] values = new string[100,4];

        public Form1()
        {
            InitializeComponent();
            starter();
        }

        private void starter()
        {
            //literalPath is just to the folder.
            string literalPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Notes\\";
            //path is to the xml file.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Notes\\prefabs.xml";

            if (!File.Exists(path))
            {
                if (!File.Exists(literalPath))
                {
                    Directory.CreateDirectory(literalPath);
                }

                //create an xml document
                StreamWriter writer = File.CreateText(path);

                //write the default value to it.
                writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                writer.WriteLine("<item>");
                writer.WriteLine("<name>Default</name>");
                writer.WriteLine("<issue>Hello! This is the default prefab documentation. You can make your own by following the steps below!</issue>");
                writer.WriteLine("<trouble>Open " + SecurityElement.Escape(path) + ". You'll see this text is already in there. You can delete it and add whatever you want. Each issue must be in the same format as this item.</trouble>");
                writer.WriteLine("<resolution>It's that easy!</resolution>");
                writer.WriteLine("</item>");
                writer.Close();
            }

            //this is where we load our xml into the array to populate the prefab boxes.
            XmlTextReader reader = new XmlTextReader(path);
            reader.WhitespaceHandling = WhitespaceHandling.None;

            try
            {
                int placeCounter = 0;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name.ToLower() == "item")
                        {
                            numOfPrefabs++;
                        }
                    }
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        values[numOfPrefabs, placeCounter] = reader.Value;
                        placeCounter++;
                        if (placeCounter == 4)
                        {
                            placeCounter = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The formatting of " + path + " is incorrect. Please correct the problem. Delete the file and restart the application to get an example file.");
                //we only want to show this once.
                return;
            }

            //a counter
            int i = 0;

            while (i < numOfPrefabs)
            {
                drpPrefabs.Items.Add(values[numOfPrefabs,0]);
                i++;
            }

=======
        public Form1()
        {
            InitializeComponent();
>>>>>>> a649b4c37807889e279882f9c96323aebec7c276
        }

        private void drpPrefabs_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int myIndex = drpPrefabs.SelectedIndex;
            if (myIndex!=0)
            {
                txtIssue.Text = values[myIndex, 1];
                txtTrouble.Text = values[myIndex, 2];
                txtResolution.Text = values[myIndex, 3];
            }
=======
            switch (drpPrefabs.SelectedIndex)
            {
                case 0:
                    //do nothing, the value is set to null.
                    break;
                case 1:
                    //aircard setup
                    txtIssue.Text = "Client has a new air card which needs to be configured.";
                    txtTrouble.Text = "Walked client through seperating the air card from the adaptor. Assisted them with locating the proper port on the right side of their PC. Ran Wizard in VZ Access Manager, configured to use PC card.";
                    txtResolution.Text = "Connected to the internet via VZ Access Manager.";
                    break;
                case 2:
                    //android email setup
                    txtIssue.Text = "Client has a new Android based cell phone, and they would like it to be configured for SJM email.";
                    txtTrouble.Text = "Walked client through configuring Android email following the documented procedure.";
                    txtResolution.Text = "Verified emails were synchronized to the phone.";
                    break;
                case 3:
                    //Beyond Trust Repair
                    txtIssue.Text = "The 'PM - Run Elevated...' option is missing when right clicking on applications.";
                    txtTrouble.Text = "Ran deleted the Beyond Trust Channel. Rebooted the PC. Updated policy service channel, verified Beyond Trust installed again. Rebooted pc.";
                    txtResolution.Text = "Right clicked an executable, 'PM - Run Elevated...' was present.";
                    break;
                case 4:
                    //Blackberry Activation
                    txtIssue.Text = "Client has a new blackberry that needs to be activated.";
                    txtTrouble.Text = "Verified user following the standard password reset policy. Set activation Password. Walked client through activating the phone.";
                    txtResolution.Text = "Verified contacts and calendars loaded onto the phone.";
                    break;
                case 5:
                    //ESS Portal Prompts for Password
                    txtIssue.Text = "When accessing the ESS portal the user is prompted for a user name and password.";
                    txtTrouble.Text = "Had client close all open Internet Explorer windows. Instructed the user to right click on 'Secude' and choose 'Enroll for Default.'";
                    txtResolution.Text = "Had client access https://ess.sjm.com, verified it prompted for the last four of their Social Security Number.";
                    break;
                case 6:
                    //Guest Wireless Password
                    txtIssue.Text = "User is requesting the guest wifi password.";
                    txtTrouble.Text = "Provided user with the guest wifi password. Offered to assist with logging in to the guest network.";
                    txtResolution.Text = "Verified client was able to access the network.";
                    break;
                case 7:
                    //HP 460/470 Installation
                    txtIssue.Text = "User is trying to set up their SJM issued printer.";
                    txtTrouble.Text = "Remoted to user's PC, configured bluetooth to connect to the printer using drivers already installed on the system. Had client plug printer in via USB.";
                    txtResolution.Text = "Printed test page over bluetooth.";
                    break;
                case 8:
                    //Windows Password
                    txtIssue.Text = "User needs their NT account password reset.";
                    txtTrouble.Text = "Verified the user following the standard password reset policy. Reset the password in DRA.";
                    txtResolution.Text = "Verified user was able to log in and reset their password.";
                    break;
            }

>>>>>>> a649b4c37807889e279882f9c96323aebec7c276
        }

        //copy data to the clipboard and reset the form
        private void btnCopy_Click(object sender, EventArgs e)
        {
            string dataToBeCopied = "Issue:\n" + txtIssue.Text.ToString() + "\n\nTroubleshooting:\n" + txtTrouble.Text.ToString() + "\n\nResolution:\n" + txtResolution.Text.ToString();
            Clipboard.SetText(dataToBeCopied);
            reset();
        }

        //manually reset the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        //reset the form
        private void reset()
        {
            drpPrefabs.SelectedItem = 0;
<<<<<<< HEAD
            drpPrefabs.SelectedIndex = 0;
=======
>>>>>>> a649b4c37807889e279882f9c96323aebec7c276
            txtIssue.Text = "";
            txtTrouble.Text = "";
            txtResolution.Text = "";
        }


        private void chkSpell_Click(object sender, EventArgs e)
        {
            Word.Application app = new Word.Application();

            int errors = 0;

            //don't show word doing all the work
            app.Visible = false;

            //setting variables that are equivalent to null.
            object template = Missing.Value;
            object newTemplate = Missing.Value;
            object documentType = Missing.Value;
            object visible = true;

            //initalize a document
            Word._Document doc1 = app.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);

            //a counter token
            int i = 0;

            //a variable to hold the output
            string[] holder = Regex.Split(txtIssue.Text, "\r\n");
            

            while (holder.Length > i)
            {
                doc1.Words.First.InsertBefore(holder[i]);

                Word.ProofreadingErrors spellErrorsColl = doc1.SpellingErrors;
                errors = spellErrorsColl.Count;

                object optional = Missing.Value;

                doc1.CheckSpelling(ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);

                object first = 0;
                object last = doc1.Characters.Count - 1;

                holder[i] = doc1.Range(ref first, ref last).Text;
                Word.Range deleteme = doc1.Range(ref first, ref last);
                deleteme.Delete(ref optional, ref optional);

                i = i+1;
            }
            txtIssue.Text = "";
            foreach (string line in holder){
                txtIssue.Text += line + "\r\n";
            }

            

            object saveChanges = false;
            object originalFormat = Missing.Value;
            object routeDocument = Missing.Value;

            app.Quit(ref saveChanges, ref originalFormat, ref routeDocument);
            
        }
    }
}
