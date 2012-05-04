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
using System.IO;
using System.Xml;
using System.Security;



namespace Notes
{
    public partial class Form1 : Form
    {       
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

        }

        private void drpPrefabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int myIndex = drpPrefabs.SelectedIndex;
            if (myIndex!=0)
            {
                txtIssue.Text = values[myIndex, 1];
                txtTrouble.Text = values[myIndex, 2];
                txtResolution.Text = values[myIndex, 3];
            }
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
            drpPrefabs.SelectedIndex = 0;
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
