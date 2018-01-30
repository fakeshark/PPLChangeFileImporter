using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader.Core;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Threading;

namespace PPLChangeFileImporter
{
    public partial class FrmPPLChangeImporter : Form
    {
        OpenFileDialog pplFileSelected;
        string lineCode = String.Empty;
        string[] columnNames;
        int newRowsAdded = 0;
        string pplFileName;
        string pplFilePath;
        List<ChangedPart> changePartsObjectList = new List<ChangedPart>();
        List<ChangedPart> changePartsObjectAppendList = new List<ChangedPart>();
        List<string[]> partsChangeList = new List<string[]>();
        List<int> changeRowsIndex = new List<int>();
        List<DataGridViewRow> allRows = new List<DataGridViewRow>();
        List<string[]> changedParts = new List<string[]>();
        List<string[]> preChangeRowData = new List<string[]>();
        List<string[]> postChangeRowData = new List<string[]>();
        string currentPN = string.Empty;
        OpenFileDialog changeFileSelected;
        string[] changeLines;

        //ExcelPackage newPpl = new ExcelPackage();

        //struct DataParameter
        //{
        //    public int Process;
        //    public int Delay;
        //}

        //private DataParameter _inputparameter;

        public FrmPPLChangeImporter()
        {
            InitializeComponent();
        }

        private void BtnImportPPL_Click(object sender, EventArgs e)
        {
            try
            {
                //user browses to folder and selects ppl file
                pplFileSelected = new OpenFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    Multiselect = false
                };

                if (pplFileSelected.ShowDialog() == DialogResult.OK)
                {
                    pplFileName = pplFileSelected.FileName;
                    pplFilePath = Path.GetFullPath(pplFileName);
                    pplFilePath = Directory.GetParent(pplFilePath).FullName;
                    UpdateLog("Importing Spreadsheet: " + pplFileName);

                    //pull data from excel file and display it on datagridview
                    using (var stream = File.Open(pplFileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            var result = reader.AsDataSet();

                            dgvExcelImport.DataSource = result.Tables[0];

                            List<string> ColNamesList = new List<string>();
                            foreach (DataGridViewRow row in dgvExcelImport.Rows)
                            {
                                if (row.Index == 0)
                                {
                                    //Assign 1st row values  as column headers, then remove 1st row
                                    foreach (DataGridViewColumn col in dgvExcelImport.Columns)
                                    {
                                        dgvExcelImport.Columns[col.Index].HeaderText = row.Cells["Column" + col.Index].Value.ToString();
                                        ColNamesList.Add(dgvExcelImport.Columns[col.Index].HeaderText);
                                    }
                                }

                                // format 'UM Price' column to currency formatted string
                                try
                                {
                                    double currFormat = Math.Round((Double)row.Cells[19].Value, 2);
                                    row.Cells[19].Value = String.Format("{0:n}", currFormat);
                                }
                                catch (Exception f)
                                {
                                    Console.WriteLine("{0} Exception caught.", f);
                                }

                                // format 'UI price' column to currency formatted string
                                try
                                {
                                    double currFormat = Math.Round((Double)row.Cells[21].Value, 2);
                                    row.Cells[21].Value = String.Format("{0:n}", currFormat);
                                }
                                catch (Exception f)
                                {
                                    Console.WriteLine("{0} Exception caught.", f);
                                }
                            }

                            columnNames = ColNamesList.ToArray();

                            dgvExcelImport.Rows.RemoveAt(0);
                            UpdateLog("Added " + dgvExcelImport.RowCount + " rows to dataset.");

                        }
                    }
                }
                // enable the user to click import change file button
                btnImportChangeFile.Enabled = true;

                // make a List of string arrays full of the cell data for each row
                preChangeRowData = MakeListOfRowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error!\n\n" + ex.Message, "Error!");
                ResetForm();
            }
        }

        private void BtnImportChangeFile_Click(object sender, EventArgs e)
        {
            try
            {
                //user browses to folder and selects change file
            changeFileSelected = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt",
                Multiselect = false
            };

                if (changeFileSelected.ShowDialog() == DialogResult.OK)
                {
                    changeLines = File.ReadAllLines(changeFileSelected.FileName);

                    UpdateLog("Imported change file: " + changeFileSelected.FileName + ".");

                    partsChangeList = ParseChangeLines(changeLines);
                    partsChangeList = PreFormatPartsChangeList(partsChangeList);
                    changePartsObjectAppendList = MakeChangePartsObjectList(partsChangeList);
                    changePartsObjectList.AddRange(changePartsObjectAppendList);
                    changePartsObjectAppendList.Clear();

                    InsertChangeRows();

                    RefreshDGV(postChangeRowData);
                    MessageBox.Show("Change file imported and applied successfully.", "Message:");
                    UpdateLog("Added " + newRowsAdded + " new rows based on imported changes.");
                    btnExportChanges.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error!\n\n" + ex.Message, "Error!");
                ResetForm();
            }
        }

        private List<string[]> PreFormatPartsChangeList(List<string[]> partsChangeList)
        {
            // this preformatter is needed to handle the occurances of multiple NSN matches for the same part
            List<string> tempPart = new List<string> { };
            List<string[]> tempPartsChangeList = new List<string[]> { };

            foreach (string[] part in partsChangeList)
            {
                //remove multiple lines from part array
                string[] partArray;
                List<string> partList = new List<string> { };
                int KMRsFound = 0;
                for (int i = 0; i < part.Length; i++)
                {
                    if (GetLineCode(part[i]) == "KMR")
                    {
                        if (KMRsFound == 0)
                        {
                            partList.Add(part[i]);
                            KMRsFound++;
                        }
                    }
                    else
                    {
                        partList.Add(part[i]);
                    }
                }
                partArray = partList.ToArray();

                for (int i = 0; i < partArray.Length; i++)
                {
                    lineCode = GetLineCode(partArray[i]);
                    if (lineCode == "KMR" && tempPart.Count > 0)
                    {
                        //Add tempPart to tempPartsChangeList
                        tempPartsChangeList.Add(tempPart.ToArray());
                        tempPart.Clear();
                        tempPart.Add(partArray[i]);
                    }
                    else
                    {
                        tempPart.Add(partArray[i]);
                    }
                }
            }
            return tempPartsChangeList;
        }

        private List<string[]> ParseChangeLines(string[] changeLines)
        {
            //Initialize list of lines in each part
            List<string> partLines = new List<string>();

            for (int i = 0; i < changeLines.Length; i++)
            {
                // a line with KSR as it's line code is a delimiter between parts
                lineCode = GetLineCode(changeLines[i]);

                if (lineCode == "KSR")
                {
                    // make sure we're not trying to add an empty array to the list
                    // this is done to handle the first KSR line in the list
                    if (partLines.Count > 0)
                    {

                        /*  a delimiter is reached, so add line(s) that came before the delimiter
                             and then clear the list to start building the next part without
                             adding the delimiter line to the part. */

                        changedParts.Add(partLines.ToArray());
                        partLines.Clear();
                    }
                }
                else
                {
                    // don't add any blank lines
                    if (changeLines[i].Length > 0)
                    {
                        // don't add  lines
                        if (lineCode != "KNR")
                        {
                            partLines.Add(changeLines[i]);
                        }
                    }

                    // make sure to add last part as it will not have a delimiter at the end
                    if (i + 1 == changeLines.Length)
                    {
                        if (partLines.Count > 0)
                        {
                            changedParts.Add(partLines.ToArray());
                        }
                    }
                }
            }

            return changedParts;
        }

        private List<ChangedPart> MakeChangePartsObjectList(List<string[]> changeLines)
        {
            // build list of change parts objects
            List<ChangedPart> changePartsObjectList = new List<ChangedPart>();
            foreach (string[] part in changeLines)
            {
                changePartsObjectList.Add(new ChangedPart(part));
            }
            return changePartsObjectList;
        }

        private List<string[]> MakeListOfRowData()
        {
            // build list of type string array to hold the data in each cell or each row in the datatable
            List<string[]> allRows = new List<string[]>();
            foreach (DataGridViewRow row in dgvExcelImport.Rows)
            {
                string[] rowDataArray = new string[215];
                string emptyCheck = string.Empty;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    rowDataArray[i] = row.Cells[i].FormattedValue.ToString();
                }
                allRows.Add(rowDataArray);
            }
            return allRows;
        }

        public string GetLineCode(string pplChangeFileLine)
        {
            // return the first 3 charaters (line code) of a given string from the change file
            string lineCode = string.Empty;
            char[] pplChar = pplChangeFileLine.ToCharArray();
            if (pplChangeFileLine.Length > 3)
            {
                lineCode = (pplChar[0].ToString() + pplChar[1].ToString() + pplChar[2].ToString());
            }
            return lineCode;
        }

        private void InsertChangeRows()
        {
            // this method looks at each PN (part number) in the list generated from the PPL spreadsheet
            // and iterates through the ChangedParts data that was derived from the imported change file.
            // If it finds a match it will add the matching data below the part from the PPL spreadsheet
            foreach (string[] pplIItem in preChangeRowData)
            {
                postChangeRowData.Add(pplIItem);
                foreach (ChangedPart chngPart in changePartsObjectList)
                {
                    if (pplIItem[4] == chngPart.OriginalPN)
                    {
                        postChangeRowData.Add(chngPart.rowData);
                        newRowsAdded++;
                    }
                }
            }
        }

        private void RefreshDGV(List<string[]> postChangeRowData)
        {
            // clear out datagridview
            dgvExcelImport.DataSource = null;

            //creat new data table from the postchangerowdata List
            System.Data.DataTable postChangesTable = new System.Data.DataTable();

            //set the column header names
            foreach (string columnName in columnNames)
            {
                postChangesTable.Columns.Add(columnName);
            }

            //add the row data to the table
            dgvExcelImport.DataSource = postChangesTable;
            foreach (string[] row in postChangeRowData)
            {
                postChangesTable.Rows.Add(row);
            }
        }

        private void UpdateLog(string logMessage)
        {
            // adds new lines to the activity log text box
            lbxChangeLog.Items.Add(logMessage);
        }

        private void BtnExportChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Initiate the creation of an excel spreadsheet based off of the PPL list with the added changefile
                SaveFileDialog exportExcelFile = new SaveFileDialog
                {
                    InitialDirectory = pplFilePath,
                    FileName = "UpdatedPPL.xlsx",
                    DefaultExt = "xlsx",
                    Filter = "xlsx files (*.xlsx) | *.xlsx"
                };

                if (exportExcelFile.ShowDialog() == DialogResult.OK)
                {
                    string spreadsheetPath = exportExcelFile.FileName;
                    FileInfo spreadsheetInfo = new FileInfo(spreadsheetPath);
                    File.Delete(spreadsheetPath);
                    ExcelPackage newPpl = new ExcelPackage(spreadsheetInfo);
                    // name the sheet for the new spreadsheet
                    var pplWorksheet = newPpl.Workbook.Worksheets.Add("LSA-036");

                    // set column headers and styling
                    for (int i = 0; i < columnNames.Length; i++)
                    {
                        pplWorksheet.Cells[GetExcelColumn(i + 1, 1)].Value = columnNames[i];
                        pplWorksheet.Cells[GetExcelColumn(i + 1, 1)].Style.Font.Bold = true;
                        pplWorksheet.Cells[GetExcelColumn(i + 1, 1)].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                    }

                    //freeze top row of spreadsheet for headers names
                    pplWorksheet.View.FreezePanes(2, 1);

                    int counter = 2;
                    // Add ppl data rows
                    foreach (string[] row in postChangeRowData)
                    {
                        for (int i = 0; i < row.Length; i++)
                        {
                            // check the TEMP1 cell for spaces
                            // if the TEMP1 contains three spaces it is an added change row and should be shaded green
                            if (row[211] == "   ")
                            {
                                pplWorksheet.Cells[GetExcelColumn(i + 1, counter)].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                pplWorksheet.Cells[GetExcelColumn(i + 1, counter)].Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                            }
                            // if the TEMP1 contains four spaces it is an added change row and should be shaded green 
                            // and the UI & UI PRICE should be shaded red
                            else if (row[211] == "    ")
                            {
                                pplWorksheet.Cells[GetExcelColumn(i + 1, counter)].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                pplWorksheet.Cells[GetExcelColumn(i + 1, counter)].Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                                pplWorksheet.Cells[GetExcelColumn(21, counter) + ":" + GetExcelColumn(22, counter)].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                pplWorksheet.Cells[GetExcelColumn(21, counter) + ":" + GetExcelColumn(22, counter)].Style.Fill.BackgroundColor.SetColor(Color.OrangeRed);
                            }
                            pplWorksheet.Cells[GetExcelColumn(i + 1, counter)].Value = row[i];
                        }
                        counter++;
                    }
                    var UIPriceRange = pplWorksheet.Cells[2, 22, postChangeRowData.Count, 22];
                    var UMPriceRange = pplWorksheet.Cells[2, 20, postChangeRowData.Count, 20];
                    UIPriceRange.Style.Numberformat.Format = "$0.00";
                    UMPriceRange.Style.Numberformat.Format = "$0.00";
                    UIPriceRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    UMPriceRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;

                    var range = pplWorksheet.Cells[1, 1, postChangeRowData.Count, columnNames.Length];
                    range.Style.Font.Name = "Courier New";
                    range.Style.Font.Size = (float)11.0;
                    range.AutoFitColumns();

                    newPpl.Save();

                    //if (!bgWorker.IsBusy)
                    //{
                    //    _inputparameter.Delay = 100;
                    //    _inputparameter.Process = 1200;
                    //    bgWorker.RunWorkerAsync(_inputparameter);
                    //}

                    MessageBox.Show("Updated PPL Spreadsheet has been saved.", "Message:");
                    UpdateLog("Updated PPL spreadsheet export successful.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error!\n\n" + ex.Message, "Error!");
            }
        }

        private string GetExcelColumn(int ColumnNum, int RowNum)
        {
            string[] Alphabet = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string cell = string.Empty;

            //todo: refactor this!!

            /*
             * get the number, if it's 26 or less use that number minus 1 to get the alphabet array index you need.
             * 
             * if the number is over 26, count backwards from that number until you find a multiple of 26 using the modulus operator
             * once you have reached a multiple of 26 take the number and divide by 26, subtract 1 from the result to get the index
             * of the first character, and take the number of times you had to count backwards to fine the multiple, and that is the index of the second character
             */


            //if (ColumnNum <= 26)
            //{
            //    cell = Alphabet[ColumnNum - 1];
            //}
            //else
            //{
            //    int firstCharacterIndex;
            //    int secondCharacterIndex;

            //    int counter = 0;
            //    for (int i = 0; i < 26; i++)
            //    {
            //        if ((ColumnNum - counter) % 26 == 0)
            //        {
            //            firstCharacterIndex = ((ColumnNum - counter) / 26);
            //            secondCharacterIndex = (ColumnNum - (26 * (firstCharacterIndex))) + 1;
            //            //secondCharacterIndex = (((ColumnNum - counter) * (firstCharacterIndex + 1)) - ColumnNum) + counter;
            //            cell = Alphabet[(firstCharacterIndex -1)] + Alphabet[(secondCharacterIndex)];
            //            break;
            //        }
            //        counter++;
            //    }
            //}

            if (ColumnNum <= 26)
            {
                cell = Alphabet[ColumnNum - 1];
            }
            else
            {
                if (ColumnNum >= 27 && ColumnNum <= 52)
                {
                    cell = Alphabet[0] + Alphabet[ColumnNum - 27];
                }

                if (ColumnNum >= 53 && ColumnNum <= 78)
                {
                    cell = Alphabet[1] + Alphabet[ColumnNum - 53];
                }

                if (ColumnNum >= 79 && ColumnNum <= 104)
                {
                    cell = Alphabet[2] + Alphabet[ColumnNum - 79];
                }

                if (ColumnNum >= 105 && ColumnNum <= 130)
                {
                    cell = Alphabet[3] + Alphabet[ColumnNum - 105];
                }

                if (ColumnNum >= 131 && ColumnNum <= 156)
                {
                    cell = Alphabet[4] + Alphabet[ColumnNum - 131];
                }

                if (ColumnNum >= 157 && ColumnNum <= 182)
                {
                    cell = Alphabet[5] + Alphabet[ColumnNum - 157];
                }

                if (ColumnNum >= 183 && ColumnNum <= 208)
                {
                    cell = Alphabet[6] + Alphabet[ColumnNum - 183];
                }

                if (ColumnNum >= 209 && ColumnNum <= 234)
                {
                    cell = Alphabet[7] + Alphabet[ColumnNum - 209];
                }

                if (ColumnNum >= 235 && ColumnNum <= 260)
                {
                    cell = Alphabet[8] + Alphabet[ColumnNum - 235];
                }
            }

            cell += RowNum;
            return cell;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            lbxChangeLog.Items.Clear();
            btnImportChangeFile.Enabled = false;
            btnExportChanges.Enabled = false;

            lineCode = String.Empty;
            columnNames = new string[] { };
            newRowsAdded = 0;
            changePartsObjectList.Clear();
            partsChangeList.Clear();
            changeRowsIndex.Clear();
            allRows.Clear();
            changedParts.Clear();
            preChangeRowData.Clear();
            postChangeRowData.Clear();
            string currentPN = string.Empty;
            changeLines = new string[] { };
            dgvExcelImport.DataSource = null;
        }

        //private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    int process = ((DataParameter)e.Argument).Process;
        //    int delay = ((DataParameter)e.Argument).Delay;
        //    int index = 1;
        //    try
        //    {
        //        for (int i = 0; i < process; process++)
        //        {
        //            if (!bgWorker.CancellationPending)
        //            {
        //                bgWorker.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        bgWorker.CancelAsync();
        //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    pgbProgressBar.Value = e.ProgressPercentage;
        //    lblPercentComplete.Text = string.Format("Processing...{0}%", e.ProgressPercentage);
        //    pgbProgressBar.Update();
        //}

        //private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    MessageBox.Show("PPL Spreadsheet has been successfully imported.", "Message:");
        //}
    }
}
