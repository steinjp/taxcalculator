using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//MS-Access-OLEDB Database Libraries
using System.Data.OleDb;

namespace 税計算機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void keisanButton_Click(object sender, EventArgs e)
        {
            double tax1;
            double tax2;
            double sagaku1;
            double sagaku2;

            double money = double.Parse(ValueInput.Text);
            
            tax1 = 1.08 * money; //Eight percent tax
            eightPercOut.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", tax1);
            sagaku1 = tax1 - money;
            sagakuEight.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", sagaku1); //Adding decimals = C2 = .00 C1 = .0

            tax2 = 1.10 * money; //ten percent tax
            tenPercOut.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", tax2);
            sagaku2 = tax2 - money;
            sagakuTen.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", sagaku2); //Adding decimals = C2 = .00 C1 = .0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentdate2 = DateTime.Now.ToString("yyyy-MM-dd"); //date format for database input

            if (no_taxradioButton.Checked == true)
            {
                if (ValueInput.Text == "")
                {
                    MessageBox.Show("金額を入れてください・・・","エラー");
                    return;
                }
                    double tax1;
                    double tax2;
                    double sagaku1;
                    double sagaku2;

                    double money = double.Parse(ValueInput.Text);

                    tax1 = money / 1.08; //Eight percent tax
                    eightPercOut.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", tax1);
                    sagaku1 = money - tax1;
                    sagakuEight.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", sagaku1); //Adding decimals = C2 = .00 C1 = .0

                    tax2 = money / 1.10; //ten percent tax
                    tenPercOut.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", tax2);
                    sagaku2 = money - tax2;
                    sagakuTen.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", sagaku2); //Adding decimals = C2 = .00 C1 = .0
            }

            else if (yes_taxradioButton.Checked == true)
            {
                if (ValueInput.Text == "")
                {
                    MessageBox.Show("金額を入れてください・・・", "エラー");
                    return;
                }
                double tax1;
                double tax2;
                double sagaku1;
                double sagaku2;

                double money = double.Parse(ValueInput.Text);

                tax1 = 1.08 * money; //Eight percent tax
                eightPercOut.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", tax1);
                sagaku1 = tax1 - money;
                sagakuEight.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", sagaku1); //Adding decimals = C2 = .00 C1 = .0

                tax2 = 1.10 * money; //ten percent tax
                tenPercOut.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", tax2);
                sagaku2 = tax2 - money;
                sagakuTen.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C}", sagaku2); //Adding decimals = C2 = .00 C1 = .0
            }
            else
            {
                MessageBox.Show("何も選択していません・・・", "エラー");
            }

            //database record
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = \\\\192.168.10.100\\Public\\税計算機データ\\taxcalculations.accdb";

            try
            {

                conn.Open();
                string my_querry = "INSERT INTO calculations(InputDate,InputValue,10perc,uchi10perc,8perc,uchi8perc)VALUES('" + currentdate2 + "','" + ValueInput.Text + "','" + tenPercOut.Text + "','" + sagakuTen.Text + "','" + eightPercOut.Text + "','" + sagakuEight.Text + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("失敗：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
