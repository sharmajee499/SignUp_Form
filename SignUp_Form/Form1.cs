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
        public int count = 0;
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
            //********************************************************************************************************************

            //string path = @"C:\Users\Sunnation\Desktop\SignUp_Form\SignUp_Form\bin\Debug\data.txt";
            //StreamWriter sw = new StreamWriter(path, true);
            //sw.WriteLine(txtbox_first_name.Text+","+txtbox_last_name.Text+","+txtbox_address.Text+","+ txtbox_city.Text+","+ cmbox_state.SelectedItem+","+ txtbox_zip.Text+","+ cmbox_gender.SelectedItem+","+ txtbox_DOB.Text+","+ txtbox_phone_no.Text);
            //sw.Close();

            //*******************************************************************************************************************************

            var result=MessageBox.Show(txtbox_first_name.Text + " " +
                txtbox_last_name.Text + " " +
                txtbox_address.Text + " " +
                txtbox_city.Text +
                cmbox_state.SelectedItem + " " +
                txtbox_zip.Text + " " +
                cmbox_gender.SelectedItem + " " +
                txtbox_DOB.Text + " " +
                txtbox_phone_no.Text, "Do you want to save?",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (result==DialogResult.Yes)
            {
                string path = @"C:\Users\Sunnation\Desktop\SignUp_Form\SignUp_Form\bin\Debug\data.txt";
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(txtbox_first_name.Text + "," + txtbox_last_name.Text + "," + txtbox_address.Text + "," + txtbox_city.Text + "," + cmbox_state.SelectedItem + "," + txtbox_zip.Text + "," + cmbox_gender.SelectedItem + "," + txtbox_DOB.Text + "," + txtbox_phone_no.Text);
                sw.Close();

                //clearing the form items ********************************
                txtbox_first_name.Clear();
                txtbox_last_name.Clear();
                txtbox_address.Clear();
                txtbox_city.Clear();
                cmbox_state.Text="";
                txtbox_zip.Clear();
                cmbox_gender.Text = "";
                txtbox_DOB.Clear();
                txtbox_phone_no.Clear();
                //************************************************************

                MessageBox.Show("Your data is SAVED");

            }
            else
            {
                txtbox_first_name.Clear();
                txtbox_last_name.Clear();
                txtbox_address.Clear();
                txtbox_city.Clear();
                cmbox_state.Text="";
                txtbox_zip.Clear();
                cmbox_gender.Text="";
                txtbox_DOB.Clear();
                txtbox_phone_no.Clear();

                MessageBox.Show("Your data IS NOT SAVED");
            }


            

           

        }
    }
}
