using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Collections.Specialized;
using SHDocVw;
using System.Net;
using System.Collections;

namespace KPGminer
{
    public partial class Form1 : Form
    {
        //Dictionary<String, String> allOrganisms = new Dictionary<string, string>();
        //Dictionary<String, String> allPathways = new Dictionary<string, string>();

        BindingList<KeyValuePair<String, String>> allPathways = new BindingList<KeyValuePair<string, string>>();


        BindingList<KeyValuePair<String, String>> lb1_list = new BindingList<KeyValuePair<string, string>>();
        BindingList<KeyValuePair<String, String>> lb2_list = new BindingList<KeyValuePair<string, string>>();

        RestImpl ri = new RestImpl();

        string outputDirectory = "";
        string outputText = "";
        string organismID = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region fill the combo box with all the organisms
                
                comBoxOrganism.DataSource = new BindingSource(SplashForm .allOrganisms, null);
                comBoxOrganism.DisplayMember = "Value";
                comBoxOrganism.ValueMember = "Key";
                toolStripStatusLabel1.Text = "Organisms have been Loaded Successfully!";
                #endregion
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Organism loading failed: " + ex.Message;
            }
        }

        
        private void comBoxOrganism_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String organismName = ((ComboBox)sender).SelectedText.ToString();
            String organismPrefix = ((ComboBox)sender).SelectedValue.ToString();

            try
            {
                #region get all the pathways of the selected organism and pathway ID
                allPathways = GetAllPathways4anOrganism(organismPrefix);
                lblChosePathwayFrom.Text = "Choose from " + allPathways.Count + " pathway(s)";
                lblSelectedPathways.Text = "Selected Pathway(s): 0";
                dataGridView1.DataSource = null;
                dataGridView1.Visible = false;
                #endregion

                #region initialize and populate pathway listboxes
                lbxAll.DataSource = null;
                lboxSelected.DataSource = null;
                lbxAll.Items.Clear();
                lboxSelected.Items.Clear();

                lbxAll.DataSource = new BindingSource(allPathways, null);
                lbxAll.DisplayMember = "Value";
                lbxAll.ValueMember = "Key";
                toolStripStatusLabel1.Text = "Pathways have been Loaded Successfully!";
                #endregion
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Pathway loading failed: " + ex.Message;
            }

            //MessageBox.Show(organismPrefix);
        }

        private BindingList<KeyValuePair< string, string>> GetAllPathways4anOrganism(string organismPrefix)
        {
            organismID = organismPrefix;

            BindingList<KeyValuePair<string, string>> retDic = new BindingList<KeyValuePair<string, string>>();
            IDictionary<String, String> paramList = new Dictionary<String, String>();
            string target_url = "http://rest.kegg.jp/list/pathway/"+organismPrefix;
            HttpWebRequest webRequest = ri.CreateRequest(target_url, paramList);

            string response = ri.GetResponse(webRequest);

            #region parse the response
            string[] lines = response.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (String line in lines)
            {
                string[] parts = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string pathwayID = parts[0].Trim().Split(":".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)[1].Trim();
                string pathwayName = parts[1].Trim().Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                
                retDic.Add(new KeyValuePair<string, string>(pathwayID, pathwayName));
            }
            #endregion

            return retDic;
        }

        private void btnSingleInclusion_Click(object sender, EventArgs e)
        {
            #region Single inclusion button
            if (lbxAll.SelectedItems.Count > 0) {
                List<KeyValuePair<string, string>> itemsToRemove = new List<KeyValuePair<string, string>>();

                #region update (add to) right listbox
                lboxSelected.BeginUpdate();
                BindingSource bsRight = (BindingSource)lboxSelected.DataSource;
                BindingList<KeyValuePair<string, string>> bsRList = new BindingList<KeyValuePair<string, string>>();
                if (bsRight != null)
                    bsRList = (BindingList<KeyValuePair<string, string>>)bsRight.List;
                foreach(var elem in lbxAll.SelectedItems)
                {
                    bsRList.Add((KeyValuePair<string, string>) elem);
                    itemsToRemove.Add(((KeyValuePair<string, string>)elem));

                }

                lboxSelected.DataSource = null;
                lboxSelected.DataSource = new BindingSource(bsRList, null);
                lboxSelected.DisplayMember = "Value";
                lboxSelected.ValueMember = "Key";
                lboxSelected.EndUpdate();
                #endregion

                #region update (remove from) left listbox
                BindingSource bsLeft = (BindingSource)lbxAll.DataSource;
                BindingList<KeyValuePair<string, string>> bsLList = (BindingList<KeyValuePair<string, string>>)bsLeft.List;

                lbxAll.BeginUpdate();
                foreach(KeyValuePair<string,string> elem in itemsToRemove)
                {
                    bsLList.Remove(elem);
                }
                lbxAll.EndUpdate();
                lblChosePathwayFrom.Text = "Choose from " + lbxAll.Items.Count.ToString() + " pathway(s)";
                lblSelectedPathways.Text = "Selected Pathway(s): " + lboxSelected.Items.Count.ToString();
                #endregion
            }
            #endregion
        }

        private void btnBatchInclusion_Click(object sender, EventArgs e)
        {
            #region Batch inclusion button
            if (lbxAll.Items.Count > 0) {
                List<KeyValuePair<string, string>> itemsToRemove = new List<KeyValuePair<string, string>>();

                #region update (add to) right listbox
                lboxSelected.BeginUpdate();
                
                BindingSource bsRight = (BindingSource)lboxSelected.DataSource;
                BindingList<KeyValuePair<string, string>> bsRList = new BindingList<KeyValuePair<string, string>>();
                BindingSource bsLeft = (BindingSource)lbxAll.DataSource;
                BindingList<KeyValuePair<string, string>> bsLList = (BindingList<KeyValuePair<string, string>>)bsLeft.List;
                IEnumerator<KeyValuePair<string, string>> tempElem = bsLList.GetEnumerator();

                if (bsRight != null)
                    bsRList = (BindingList<KeyValuePair<string, string>>)bsRight.List;
                while(tempElem.MoveNext())
                {
                    KeyValuePair<string, string> elem = tempElem.Current;
                    bsRList.Add((KeyValuePair<string, string>) elem);
                    itemsToRemove.Add(((KeyValuePair<string, string>)elem));
                }

                lboxSelected.DataSource = null;
                lboxSelected.DataSource = new BindingSource(bsRList, null);
                lboxSelected.DisplayMember = "Value";
                lboxSelected.ValueMember = "Key";
                lboxSelected.EndUpdate();
                #endregion

                #region update (remove from) left listbox
                
                lbxAll.BeginUpdate();
                foreach(KeyValuePair<string,string> elem in itemsToRemove)
                {
                    bsLList.Remove(elem);
                }
                lbxAll.EndUpdate();
                lblChosePathwayFrom.Text = "Choose from " + lbxAll.Items.Count.ToString() + " pathway(s)";
                lblSelectedPathways.Text = "Selected Pathway(s): " + lboxSelected.Items.Count.ToString();
                #endregion
            }
            #endregion

        }

        private void btnSingleExclusion_Click(object sender, EventArgs e)
        {
            #region single Exclusion button
            if (lboxSelected.SelectedItems.Count > 0)
            {
                List<KeyValuePair<string, string>> itemsToRemove = new List<KeyValuePair<string, string>>();

                #region update (i.e. add to) left listbox
                lbxAll.BeginUpdate();
                BindingSource bsLeft = (BindingSource)lbxAll.DataSource;
                BindingList<KeyValuePair<string, string>> bsLList = new BindingList<KeyValuePair<string, string>>();
                if (bsLeft != null)
                    bsLList = (BindingList<KeyValuePair<string, string>>)bsLeft.List;
                foreach (var elem in lboxSelected.SelectedItems)
                {
                    bsLList.Add((KeyValuePair<string, string>)elem);
                    itemsToRemove.Add(((KeyValuePair<string, string>)elem));

                }

                lbxAll.DataSource = null;
                lbxAll.DataSource = new BindingSource(bsLList, null);
                lbxAll.DisplayMember = "Value";
                lbxAll.ValueMember = "Key";
                lbxAll.EndUpdate();
                #endregion

                #region update (i.e. remove from) right listbox
                BindingSource bsRight = (BindingSource)lboxSelected.DataSource;
                BindingList<KeyValuePair<string, string>> bsRList = (BindingList<KeyValuePair<string, string>>)bsRight.List;

                lboxSelected.BeginUpdate();
                foreach (KeyValuePair<string, string> elem in itemsToRemove)
                {
                    bsRList.Remove(elem);
                }
                lboxSelected.EndUpdate();
                lblChosePathwayFrom.Text = "Choose from " + lbxAll.Items.Count.ToString() + " pathway(s)";
                lblSelectedPathways.Text = "Selected Pathway(s): " + lboxSelected.Items.Count.ToString();
                #endregion
            }
            #endregion
        }

        private void btnBatchExclusion_Click(object sender, EventArgs e)
        {
            #region Batch Exclusion button
            if (lboxSelected.Items.Count > 0)
            {
                List<KeyValuePair<string, string>> itemsToRemove = new List<KeyValuePair<string, string>>();
                BindingSource bsLeft = (BindingSource)lbxAll.DataSource;
                BindingList<KeyValuePair<string, string>> bsLList = new BindingList<KeyValuePair<string, string>>();
                BindingSource bsRight = (BindingSource)lboxSelected.DataSource;
                BindingList<KeyValuePair<string, string>> bsRList = (BindingList<KeyValuePair<string, string>>)bsRight.List;
                IEnumerator<KeyValuePair<string, string>> enumElem = bsRList.GetEnumerator();

                #region update (i.e. add to) left listbox
                lbxAll.BeginUpdate();
                if (bsLeft != null)
                    bsLList = (BindingList<KeyValuePair<string, string>>)bsLeft.List;
                while (enumElem.MoveNext())
                {
                    KeyValuePair<string, string> elem = enumElem.Current;
                    bsLList.Add((KeyValuePair<string, string>)elem);
                    itemsToRemove.Add(((KeyValuePair<string, string>)elem));
                }

                lbxAll.DataSource = null;
                lbxAll.DataSource = new BindingSource(bsLList, null);
                lbxAll.DisplayMember = "Value";
                lbxAll.ValueMember = "Key";
                lbxAll.EndUpdate();
                #endregion

                #region update (i.e. remove from) right listbox
                
                lboxSelected.BeginUpdate();
                foreach (KeyValuePair<string, string> elem in itemsToRemove)
                {
                    bsRList.Remove(elem);
                }
                lboxSelected.EndUpdate();
                lblChosePathwayFrom.Text = "Choose from " + lbxAll.Items.Count.ToString() + " pathway(s)";
                lblSelectedPathways.Text = "Selected Pathway(s): " + lboxSelected.Items.Count.ToString();
                #endregion
            }
            #endregion
        }

        private void btnGetGenes_Click(object sender, EventArgs e)
        {
            
            if (lboxSelected.Items.Count > 0)
            {
                toolStripStatusLabel1.Text = "Pathway genes are being retrieved from KEGG database. This might take few minutes. Please wait.!!";
                IDictionary<String, String> paramList = new Dictionary<String, String>();
                //NameValueCollection OutputList = new NameValueCollection();

                DataTable dTable = new DataTable();
                dTable.Columns.Add("Pathway", typeof(string));
                dTable.Columns.Add("Description", typeof(string));
                dTable.Columns.Add("Genes", typeof(string));
                //dTable.Columns.Add("Genes", typeof(List<LinkLabel>));
                

                #region get Pathway ids to make REST queries
                //List<KeyValuePair<string, string>> qPathways = new List<KeyValuePair<string, string>>();
                //foreach (var elem in lboxSelected.SelectedItems)
                //    qPathways.Add(((KeyValuePair<string, string>)elem));
                BindingSource bsRight = (BindingSource)lboxSelected.DataSource;
                BindingList<KeyValuePair<string, string>> bsRList = (BindingList<KeyValuePair<string, string>>)bsRight.List;
                IEnumerator<KeyValuePair<string, string>> enumElem = bsRList.GetEnumerator();
                #endregion


                while(enumElem.MoveNext())
                {
                    KeyValuePair<string, string> hsa = enumElem.Current;
                    /* make web-request and get response*/
                    string target_url = "http://rest.kegg.jp/get/" + hsa.Key;
                    HttpWebRequest webRequest = ri.CreateRequest(target_url, paramList);

                    string response = ri.GetResponse(webRequest);

                    #region parse it and save it
                    string line = "";
                    

                    /* parse the pathway name */
                    string[] stall = response.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    //string stt = stall[1].Replace("NAME        ", "").Replace(" - Homo sapiens (human)", "").Replace(" ", "_").ToUpper();
                    string pathwayName = hsa.Value;
                    string dummyText = "dummytext";
                    line += pathwayName + "\t" + dummyText + "\t";

                    /* parse gene names */
                    bool start = false;
                    string geneNames = "";
                    List<LinkLabel> lLinkLabels = new List<LinkLabel>();

                    for (int i = 2; i < stall.Count(); i++)
                    {
                        if (!start && stall[i].StartsWith("GENE"))
                        {
                            string temp = stall[i].Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0];
                            string[] tempAll = temp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            string geneName = tempAll[tempAll.Count() - 1];
                            LinkLabel tempLLabel = new LinkLabel();
                            tempLLabel.Text = geneName;
                            tempLLabel.LinkClicked += TempLLabel_LinkClicked;
                            lLinkLabels.Add(tempLLabel);

                            geneNames += geneName + ", ";
                            line += geneName + "\t";
                            start = true;
                        }
                        if (start && stall[i].StartsWith("            "))
                        {
                            string temp = stall[i].Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0];
                            string[] tempAll = temp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            string geneName = tempAll[tempAll.Count() - 1];
                            geneNames += geneName + ", ";

                            LinkLabel tempLLabel = new LinkLabel();
                            tempLLabel.Text = geneName;
                            tempLLabel.LinkClicked += TempLLabel_LinkClicked;
                            lLinkLabels.Add(tempLLabel);

                            line += geneName + "\t";
                        }
                        else if (start && !stall[i].StartsWith("GENE"))
                            break;
                    }
                    //OutputList.Add(hsa.Key, geneNames);
                    dTable.Rows.Add(hsa.Value, dummyText, geneNames);
                    //dTable.Rows.Add(hsa.Value, dummyText, lLinkLabels);
                    outputText += line + "\n";
                    #endregion

                    
                }
                #region output texts
                //richTextBox1.Text = "";
                //foreach (string key in OutputList.AllKeys)
                //    richTextBox1.Text += OutputList[key];
                
                dataGridView1.DataSource = new BindingSource(dTable, null);
                dataGridView1.Visible = Enabled;
                
                
                toolStripStatusLabel1.Text = "Pathway genes are downloaded successfully !!";
                #endregion
            }
        }

        private void TempLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Select Pathway and Get genes first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = folderBrowserDialog_OutputDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputDirectory = folderBrowserDialog_OutputDir.SelectedPath;
                if (!outputText.Equals(""))
                {
                    TextWriter tw = new StreamWriter(outputDirectory + @"\KEGG_Pathway_genes_" + organismID + ".gmt");
                    tw.WriteLine(outputText);
                    tw.Close();
                    toolStripStatusLabel1.Text = "Output file exported successfully !!";
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KPGminer v1.0.0\nDeveloped by A. K. M. Azad @UNSW");
        }
    }
}
