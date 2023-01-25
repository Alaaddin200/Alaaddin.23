using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "select * from EmployeeTb1";
            EmpCb.DisplayMember = Con.GetData(Query).Columns("EmpName").ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);

        }

        int DSal = 0;
        string period = "";
        private void GetSalary()
        {
            string Query = "select EmpSal from EmployeeTb1 where EmpId={0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());

            foreach (DataRow dr in Con.GetDate(Query).Rows)
            {

                DSal = Convert.ToInt32(dr["EmpSal"].ToString());

            }

            if (DaysTb.Text == "")
            {
                AmountTb.Text = "Rs " + (d * DSal);
            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days Can not Be Greater then 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "Rs " + (d * DSal);
            }
            