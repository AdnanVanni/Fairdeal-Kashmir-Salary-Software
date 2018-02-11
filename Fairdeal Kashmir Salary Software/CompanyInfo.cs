using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fairdeal_Kashmir_Salary_Software
{
    public partial class CompanyInfo : Form
    {
        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void btnCreateDb_Click(object sender, EventArgs e)
        {
            //                    private void CreateDatabase(DatabaseParam DBParam)
        }
        //    {
        //        System.Data.SqlClient.SqlConnection tmpConn;
        //        string sqlCreateDBQuery;
        //        tmpConn = new SqlConnection();
        //        tmpConn.ConnectionString = "SERVER = " + DBParam.ServerName +
        //                             "; DATABASE = master; User ID = sa; Pwd = sa";
        //        sqlCreateDBQuery = " CREATE DATABASE "
        //                           + DBParam.DatabaseName
        //                           + " ON PRIMARY "
        //                           + " (NAME = " + DBParam.DataFileName + ", "
        //                           + " FILENAME = '" + DBParam.DataPathName + "', "
        //                           + " SIZE = 2MB,"
        //                           + " FILEGROWTH =" + DBParam.DataFileGrowth + ") "
        //                           + " LOG ON (NAME =" + DBParam.LogFileName + ", "
        //                           + " FILENAME = '" + DBParam.LogPathName + "', "
        //                           + " SIZE = 1MB, "
        //                           + " FILEGROWTH =" + DBParam.LogFileGrowth + ") ";
        //        SqlCommand myCommand = new SqlCommand(sqlCreateDBQuery, tmpConn);
        //        try
        //        {
        //            tmpConn.Open();
        //            MessageBox.Show(sqlCreateDBQuery);
        //            myCommand.ExecuteNonQuery();
        //            MessageBox.Show("Database has been created successfully!",
        //                              "Create Database", MessageBoxButtons.OK,
        //                                          MessageBoxIcon.Information);
        //        }
        //        catch (System.Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString(), "Create Database",
        //                                        MessageBoxButtons.OK,
        //                                 MessageBoxIcon.Information);
        //        }
        //        finally
        //        {
        //            tmpConn.Close();
        //        }
        //        return;
        //    }
        //}

    }
}