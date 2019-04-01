using ParsingTool.ResponseParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParsingTool.ResponseReader;
using ParsingTool.Validation;
using bitb.Business.Objects.Entity;
using ParsingTool.Commands;

namespace ParsingTool
{
    public partial class frmMain : Form
    {
        public string FileToParse { get; set; }

        CustomResponseParser responseParser;

        public frmMain()
        {
            InitializeComponent();
            
        }


        private void SetStatusText(string parsingStatus)
        {
            statusParsingProgress.Text = parsingStatus;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openShowFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileToParse = openShowFileDialog.FileName;

            }
        }



        private void btnParse_Click(object sender, EventArgs e)
        {

            responseParser = new CustomResponseParser();

            responseParser.ClearAllLists();

            if (string.IsNullOrEmpty(FileToParse))
            {
                MessageBox.Show("Please select a file for parsing");
                return;
            }


            #region Declare local variables here

            string response = string.Empty;
            

            List<DeviceInterface> lstOfDeviceInterface = new List<DeviceInterface>();

            #endregion
            CustomResponseReader responseReader = new CustomResponseReader(FileToParse);

            CustomValidation dataValidation = new CustomValidation();

            SetStatusText("START - Parsing of data");

           
            #region Interface Entries
            response = responseReader.ReadCommandResponse(CiscoSendCommands.CISCO_SHOWINTERFACE);

            // #DEVELOPERTASK Populate the method ParseInterfaceResponse
            lstOfDeviceInterface = responseParser.ParseInterfaceResponse(response);

            if (lstOfDeviceInterface.Any())
            {
                List<DeviceInterface> validatedList = new List<DeviceInterface>();

                validatedList = dataValidation.ValidateInterfaceData(lstOfDeviceInterface);

                responseParser.InterfaceList.AddRange(validatedList);

            }

            #endregion

            SetStatusText("END - Parsing of data");
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();

            CreateInterfaceTable(ref dt);

            for (int i = 0; i < responseParser.InterfaceList.Count; i++)
            {
                DeviceInterface item = responseParser.InterfaceList[i];

                DataRow _dataRow = dt.NewRow();

                _dataRow["IfDescr"] = item.IfDescr;

                _dataRow["IfType"] = item.IfType.HasValue ? item.IfType : default(int);

                _dataRow["IfMtu"] = item.IfMtu.HasValue ? item.IfMtu : default(int);

                _dataRow["IfSpeed"] = item.IfSpeed.HasValue ? item.IfSpeed : default(decimal);

                _dataRow["IfPhysAddress"] = item.IfPhysAddress;
               
                dt.Rows.Add(_dataRow);
            }

            DataForm dataForm = new DataForm();
            dataForm.ValidatedGrid.DataSource = dt;
            if (dataForm.ShowDialog() == DialogResult.OK)
                dt.Clear();
        }

        private void CreateInterfaceTable(ref DataTable dtInterfaceTable)
        {           
            dtInterfaceTable.Columns.Add("IfDescr", typeof(string));

            dtInterfaceTable.Columns.Add("IfType", typeof(int));

            dtInterfaceTable.Columns.Add("IfMtu", typeof(int));

            dtInterfaceTable.Columns.Add("IfSpeed", typeof(decimal));

            dtInterfaceTable.Columns.Add("IfPhysAddress", typeof(string));           
        }
    }
}
