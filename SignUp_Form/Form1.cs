using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel=Microsoft.Office.Interop.Excel;
using OfficeOpenXml;


namespace SignUp_Form
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            //reading the state name from txt file

            StreamReader sr = new StreamReader(@".\state_name.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');

            // added all the state name in drop down list
            foreach (var s in y)
            {
                cmbox_state.Items.Add(s);
            }
            //********************************************************************************************************************************
            



        }

        private void Btn_save_form_Click(object sender, EventArgs e)
        {

            //******************************************************************************************************************************

            string fileTest = @"C:\Users\Sunnation\Desktop\SignUp_Form\more.xlsx";

            if (File.Exists(fileTest))
            {
                File.Delete(fileTest);
            }

            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;

            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
            oSheet.Cells[1, 1] = txtbox_first_name.Text;


            oBook.SaveAs(fileTest);
            oBook.Close();
            oApp.Quit();







            //*******************************************************************************************************************************


            MessageBox.Show(txtbox_first_name.Text + " " +
                txtbox_last_name.Text + " " +
                txtbox_address.Text + " " +
                txtbox_city.Text +
                cmbox_state.SelectedItem + " " +
                txtbox_zip.Text + " " +
                cmbox_gender.SelectedItem + " " +
                txtbox_DOB.Text+" "+
                txtbox_phone_no.Text);

           

        }
    }
}
