using Mineware.Systems.OCRWebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheet.Common;

namespace OCRWebApiAccess
{
    public partial class Form1 : Form
    {
        private Forms _Forms;
        private PrintedForm _PrintedForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetFormInfo_Click(object sender, EventArgs e)
        {
            string GetFormInfoURL = string.Format(@"/api/Forms/GetFormInfo/");
            var client = new ClientConnect();
            var param = new Dictionary<string, string>();
            param.Add("FormID", "18");

            var response = Task.Run(() => client.GetWithParameters(GetFormInfoURL, param)).Result;

            _Forms = JsonConvert.DeserializeObject<Forms>(response);

            txtFormName.Text = _Forms.Name;
            txtFromID.Text = _Forms.FormsID.ToString();
            _Forms.UniqueDataStructure.TableName = _Forms.TableName;
            dgvDataStructure.DataSource = _Forms.UniqueDataStructure;

        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            btnGetReport.Enabled = false;
            string GetReportRL = string.Format(@"/api/Report/GetReport/");
            var client = new ClientConnect();
            var param = new Dictionary<string, string>();
            var header = new Dictionary<string, string>();
            param.Add("FormsID", "18");
            _Forms.UniqueDataStructure.AcceptChanges();
            DataSet TheData = new DataSet();
            TheData.Tables.Add(_Forms.UniqueDataStructure);
            string JSOResult;
            JSOResult = JsonConvert.SerializeObject(TheData, Formatting.Indented);
            try
            {


                var response = Task.Run(() => client.PostWithBodyAndParameters(GetReportRL, param, JSOResult)).Result;
                _PrintedForm = JsonConvert.DeserializeObject<PrintedForm>(response);
                txtPDF.Text = _PrintedForm.PDFLocation;
                txtFormPrintID.Text = _PrintedForm.PrintedFromID;
                if (_PrintedForm.Success)
                {
                    txtError.Text = "NO ERROR";
                }
                else
                {
                    txtError.Text = _PrintedForm.Error;

                }
            }
            catch (Exception error)
            {
                txtError.Text = error.Message;

            }
            btnGetReport.Enabled = true;

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            string GetFormInfoURL = string.Format(@"/api/Report/PrintReport/");
            var client = new ClientConnect();
            var param = new Dictionary<string, string>();
            param.Add("PrintedFromID", _PrintedForm.PrintedFromID);
            param.Add("PrintedByName", "Dolf");

            var response = Task.Run(() => client.GetWithParameters(GetFormInfoURL, param)).Result;

        }
    }
}
