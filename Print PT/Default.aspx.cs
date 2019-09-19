using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
/*using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Text;*/

namespace Print_PT
{
    public partial class _Default : System.Web.UI.Page
    {
        string total;
        DataTable custdata = new DataTable();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataTable dataTable4 = new DataTable();
        DataTable copyDataTable = new DataTable();
        DataTable dataTable3 = new DataTable();
        DataTable cdata = new DataTable();
        DataTable mergedDataTable = new DataTable();
        DataTable dtAll = new DataTable();
        DataTable OldUID = new DataTable();
        OleDbConnection con = new OleDbConnection();
        //private OleDbCommand oleDbCmd = new OleDbCommand();
        String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=W:\test\access\Tablas.mdb";
        //String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\CSK\Tablas.mdb";
        //DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(connParam);
            Label10.Visible = false;
            Label11.Visible = false;
            Label13.Visible = false;

            //Process p = new Process();
            //p.StartInfo.FileName = @"W:\Software\CSK\Project\JobcardApplication (QR Code AWS-1)\JobcardApplication\bin\Debug\JobcardApplication.exe";
            //p.Start();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label11.Visible = false;
            //Label10.Visible = true;
            if (TextBox1.Text != "")
            {
                CustDetails();
            }
            else
            {
                string script = "Alert('Plz Enter Order No...!!!')";
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(Button1, this.GetType(), "Test", script, true);
            }

            /*************************Carbide Details********************************************************
            //TextBox1.Text = TextBox2.Text;
            //DataTable dt = new DataTable();
            OleDbCommand oleDbCmd = con.CreateCommand();
            //con.Open();
           oleDbCmd = new OleDbCommand("SELECT DISTINCTROW   [Ordenes de fabricación].ArtOrd, [Ordenes de fabricación].NumOrd, [Ordenes de fabricación].PieOrd, [Pedidos de clientes].NumPed " +   // Clientes.NomCli, Clientes.Divisa, Divisas.Cambio"  +//
                                         " FROM   " +
                                         " ([Pedidos de clientes] INNER JOIN [Ordenes de fabricación] ON [Ordenes de fabricación].PinOrd = [Pedidos de clientes].NumPed) " +
                                        " " +
                                         " WHERE (((([Pedidos de clientes].NumPed) = " + TextBox1.Text + ")))ORDER BY [Ordenes de fabricación].NumOrd DESC", con); //GROUP BY [Pedidos de clientes].CliPed, [Ordenes de fabricación].NumOrd ";


            //OleDbDataReader reader;
            //reader = oleDbCmd.ExecuteReader();

            OleDbDataAdapter Da = new OleDbDataAdapter(oleDbCmd);
            Da.SelectCommand = oleDbCmd;
            Da.Fill(dt);

            //Remove Column "ArtOrd" and "NumPed" 
            copyDataTable = dt.Copy();
            copyDataTable.Columns.Remove("ArtOrd");
            copyDataTable.Columns.Remove("NumPed");
            //Da.Fill(copyDataTable);

            //GridView2.DataSource = dt;
            //GridView2.DataBind();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                OleDbCommand oleDbCmd2 = con.CreateCommand();
                oleDbCmd2 = new OleDbCommand("SELECT TOP 2 [Ordenes de fabricación].NumOrd, [Ordenes de fabricación].ArtOrd FROM [Ordenes de fabricación] WHERE ArtOrd = '" + dt.Rows[i][0].ToString() + "'ORDER BY [Ordenes de fabricación].NumOrd DESC ", con);

                OleDbDataAdapter Da2 = new OleDbDataAdapter(oleDbCmd2);
                Da2.SelectCommand = oleDbCmd2;
                Da2.Fill(OldUID);
            }
            //Read From Excel Sheet......
            
            //string strNewPath = @"D:\CSK\Carbide\Stock Statement - ATS.xlsx";

           //string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
            if (OldUID.Rows.Count > 1)
            {
                for (int j = 1; j < OldUID.Rows.Count; j++)
                {
                    if (Convert.ToInt32(OldUID.Rows[j][0]) > 14000)
                    {
                        //string strNewPath = @"D:\CSK\Carbide\Stock Statement - ATS.xlsx";
                        string strNewPath = @"W:\Commercial Section\SHILPI\Stock Statement - ATS.xlsx";
                        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";

                        string query = "SELECT * FROM [T#C# Issue Details$A:G] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        //string query = "SELECT TOP 1 [F1],[F2],[Required T#C# Size],[F4],[F5],[F6],[F7] FROM [T#C# Issue Details$] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        con = new OleDbConnection(connString);
                        //if (con.State == ConnectionState.Closed) con.Open();
                        OleDbCommand cmd = new OleDbCommand(query, con);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(cdata);
                    }
                    else
                    {
                        //string strNewPath = @"D:\CSK\Carbide\Stock Statement - ATS (old).xlsx";
                        string strNewPath = @"W:\Commercial Section\SHILPI\Stock Statement - ATS (old).xlsx";
                        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";

                        string query = "SELECT * FROM [T#C# Issue Details$A:G] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        //string query = "SELECT TOP 1 [F1],[F2],[Required T#C# Size],[F4],[F5],[F6],[F7] FROM [T#C# Issue Details$] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        con = new OleDbConnection(connString);
                        //if (con.State == ConnectionState.Closed) con.Open();
                        OleDbCommand cmd = new OleDbCommand(query, con);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(cdata);
                    }

                }
            }
            else
            {
                for (int j = 0; j < OldUID.Rows.Count; j++)
                {
                    if (Convert.ToInt32(OldUID.Rows[j][0]) > 14000)
                    {
                        //string strNewPath = @"D:\CSK\Carbide\Stock Statement - ATS.xlsx";
                        string strNewPath = @"W:\Commercial Section\SHILPI\Stock Statement - ATS.xlsx";
                        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";

                        string query = "SELECT * FROM [T#C# Issue Details$A:G] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        //string query = "SELECT TOP 1 [F1],[F2],[Required T#C# Size],[F4],[F5],[F6],[F7] FROM [T#C# Issue Details$] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        con = new OleDbConnection(connString);
                        //if (con.State == ConnectionState.Closed) con.Open();
                        OleDbCommand cmd = new OleDbCommand(query, con);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(cdata);
                    }
                    else
                    {
                        //string strNewPath = @"D:\CSK\Carbide\Stock Statement - ATS (old).xlsx";
                        string strNewPath = @"W:\Commercial Section\SHILPI\Stock Statement - ATS (old).xlsx";
                        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";

                        string query = "SELECT * FROM [T#C# Issue Details$A:G] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        //string query = "SELECT TOP 1 [F1],[F2],[Required T#C# Size],[F4],[F5],[F6],[F7] FROM [T#C# Issue Details$] WHERE F2 = " + OldUID.Rows[j][0].ToString() + "";
                        con = new OleDbConnection(connString);
                        //if (con.State == ConnectionState.Closed) con.Open();
                        OleDbCommand cmd = new OleDbCommand(query, con);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(cdata);
                    }

                }
            }
            
            //DataTable[] dataTables = { copyDataTable, cdata };
            //Merge(dataTables);

            cdata.Columns.Remove("F1");
            cdata.Columns.Add("CodArt");

            foreach (DataRow dr in cdata.Rows)
            {
                for (int i = 0; i < OldUID.Rows.Count; i++)
                {
                    if (dr["F2"].ToString().Equals(OldUID.Rows[i][0].ToString()))
                    {
                        dr["CodArt"] = OldUID.Rows[i][1].ToString();
                    }
                }
            }

            //GridView3.DataSource = cdata;
            //GridView3.DataBind();


            // Merge two dataTables

            //DataTable[] dataTables = { copyDataTable, cdata };
            //Merge(dataTables);

            dt.Columns.Add("F2");
            dt.Columns.Add("Required T#C# Size");
            dt.Columns.Add("F4");
            dt.Columns.Add("F5");
            dt.Columns.Add("F6");
            dt.Columns.Add("F7");
            //dt.Columns.Add("CodArt");

            foreach (DataRow dr2 in dt.Rows)
            {
                for (int i = 0; i < cdata.Rows.Count; i++)
                {
                    if (dr2["ArtOrd"].ToString().Equals(cdata.Rows[i][6].ToString()))
                    {
                        //dr2["CodArt"] = cdata.Rows[i][1].ToString();
                        dr2["F2"] = cdata.Rows[i][0].ToString();
                        dr2["Required T#C# Size"] = cdata.Rows[i][1];
                        dr2["F4"] = cdata.Rows[i][2];
                        dr2["F5"] = cdata.Rows[i][3];
                        dr2["F6"] = cdata.Rows[i][4];
                        dr2["F7"] = cdata.Rows[i][5];
                    }
                }
            }
            FillBlankCell();
            //Sorting DataTable
            DataView dv = dt.DefaultView;
            dv.Sort = "NumOrd ASC";
            DataTable sorteddt = dv.ToTable();

            GridView2.DataSource = sorteddt;
            GridView2.DataBind();
            //CustDetails();

            // Merging DataTables...............

            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ArtOrd"] };
            //cdata.PrimaryKey = new DataColumn[] { cdata.Columns["CodArt"] };



            //dataTable3 = dt.Copy();
            //dataTable3.Merge(cdata, false, MissingSchemaAction.Add);
            //dataTable3.AcceptChanges();

            //GridView2.DataSource = dataTable3;
            //GridView2.DataBind();

            ************************************Carbide Details*****************************************************/
        }

        void FillBlankCell()
        {
            for (int l = 0; l < dt.Rows.Count; l++)
            {
                for (int m = 0; m < dt.Columns.Count; m++)
                {
                    if (string.IsNullOrEmpty(dt.Rows[l][m].ToString()))
                    {
                        // Write your Custom Code
                        dt.Rows[l][m] = "N/A";
                        dt.Rows[l][m] = "N/A";
                    }
                }
            }
        }

        void CustDetails()
        {
           /* OleDbCommand oleDbCmd5 = con.CreateCommand();
           // oleDbCmd5 = new OleDbCommand("SELECT [Clientes].CodCli, [Clientes].NomCli, [Clientes].DirCli, [Clientes].PobCli, [Clientes].PrvCli, [Clientes].TelCli, [Clientes].FacCli, [Pedidos de clientes].NumPed, [Pedidos de clientes].FecPed, [Pedidos de clientes].CliPed, [Pedidos de clientes].PedPed, [Ordenes de fabricación].NumOrd, [Ordenes de fabricación].ArtOrd, [Ordenes de fabricación].PlaOrd, [Ordenes de fabricación].PieOrd, [Ordenes de fabricación].PreOrd, [Ordenes de fabricación].DtoOrd, [Ordenes de fabricación].EntOrd  FROM (([Ordenes de fabricación] INNER JOIN [Pedidos de clientes] ON [Ordenes de fabricación].PinOrd = [Pedidos de clientes].NumPed) INNER JOIN [Clientes] ON [Pedidos de clientes].CliPed = [Clientes].CodCli)  WHERE [Ordenes de fabricación].PinOrd = " + TextBox1.Text + "", con);
            oleDbCmd5 = new OleDbCommand("SELECT [Ordenes de fabricación].NumOrd, [Ordenes de fabricación].EntOrd, [Ordenes de fabricación].PieOrd, [Ordenes de fabricación].ArtOrd, [Ordenes de fabricación].DtoOrd, [Ordenes de fabricación].PreOrd, [Ordenes de fabricación].PlaOrd, [Pedidos de clientes].FecPed, [Pedidos de clientes].PedPed, [Artículos de clientes].NomArt FROM (([Ordenes de fabricación] INNER JOIN [Pedidos de clientes] ON [Ordenes de fabricación].PinOrd = [Pedidos de clientes].NumPed) INNER JOIN [Clientes] ON [Pedidos de clientes].CliPed = [Clientes].CodCli)  WHERE [Pedidos de clientes].NumPed = " + TextBox1.Text + "", con);
            OleDbDataAdapter Da5 = new OleDbDataAdapter(oleDbCmd5);
            Da5.SelectCommand = oleDbCmd5;
            Da5.Fill(custdata);
            GridView3.DataSource = custdata;
            GridView3.DataBind();*/

            OleDbCommand oleDbCmd = con.CreateCommand();
            //con.Open();
            oleDbCmd = new OleDbCommand("SELECT DISTINCTROW   [Ordenes de fabricación].NumOrd, [Ordenes de fabricación].ArtOrd, [Artículos de clientes].NomArt, [Ordenes de fabricación].PlaOrd, [Ordenes de fabricación].PieOrd, [Ordenes de fabricación].PreOrd, [Ordenes de fabricación].DtoOrd, [Ordenes de fabricación].EntOrd, [Pedidos de clientes].NumPed, [Pedidos de clientes].FecPed, [Pedidos de clientes].CliPed, [Pedidos de clientes].PedPed, [Clientes].NomCli, [Clientes].DirCli, [Clientes].PobCli, [Clientes].PrvCli, [Clientes].TelCli, [Clientes].FaxCli, ([Ordenes de fabricación].PieOrd*[Ordenes de fabricación].PreOrd*(1-[Ordenes de fabricación].DtoOrd/100)) as Price, (([Ordenes de fabricación].DtoOrd - [Pedidos de clientes].FecPed)/7), [Ordenes de fabricación].Datos, [Pedidos de clientes].WorlesPo  " +   /* Clientes.NomCli, Clientes.Divisa, Divisas.Cambio"  +*/
                                          " FROM   " +
                                          " ((([Pedidos de clientes] INNER JOIN [Ordenes de fabricación] ON [Ordenes de fabricación].PinOrd = [Pedidos de clientes].NumPed) INNER JOIN  [Artículos de clientes] ON [Ordenes de fabricación].ArtOrd = [Artículos de clientes].CodArt) INNER JOIN [Clientes] ON [Pedidos de clientes].CliPed = [Clientes].CodCli)" +
                                         " " +
                                          " WHERE (((([Pedidos de clientes].NumPed) = " + TextBox1.Text + ")))ORDER BY [Ordenes de fabricación].NumOrd ASC", con); //GROUP BY [Pedidos de clientes].CliPed, [Ordenes de fabricación].NumOrd ";


            //OleDbDataReader reader;
            //reader = oleDbCmd.ExecuteReader();

            OleDbDataAdapter Da = new OleDbDataAdapter(oleDbCmd);
            Da.SelectCommand = oleDbCmd;
            Da.Fill(custdata);
            Label16.Text = "Total No of UID : " + custdata.Rows.Count;
            if (custdata.Rows.Count > 0)
            {
                GridView3.DataSource = custdata;
                GridView3.DataBind();

                TextBox2.Text = custdata.Rows[0]["NumPed"].ToString();
                TextBox3.Text = ((DateTime)custdata.Rows[0]["FecPed"]).ToShortDateString();
                TextBox4.Text = custdata.Rows[0]["CliPed"].ToString();
                TextBox5.Text = custdata.Rows[0]["PedPed"].ToString();
                TextBox7.Text = custdata.Rows[0]["WorlesPo"].ToString();
                TextBox6.Text = custdata.Rows[0]["NomCli"].ToString();
                Label8.Text = TextBox2.Text;
            }

            else
            {
                string script = "alert('Invalid Order No.!!!')";
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(Button1, this.GetType(), "Test", script, true);
            }
        }

        /*void btnExportpdf()
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=TestPage.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            this.Page.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }*/
        // <footer>Copyright &copy; Anu Worles Solutions Pvt Ltd.</footer>
        // Merging DataTables
        public DataTable Merge(DataTable[] dataTables)
        {
            List<int> oList = new List<int>();
            //DataTable mergedDataTable = new DataTable();
            foreach (DataTable dt in dataTables)
            {
                oList.Add(dt.Rows.Count);
                foreach (DataColumn dc in dt.Columns)
                {
                    //Merging dataTables with ""
                    mergedDataTable.Columns.Add(dt.TableName + "" + dc.ColumnName, dc.DataType);
                }
                //mergedDataTable.Columns.Add(dt.TableName + "-" + "Space");
            }
            int temp = 0;
            for (int m = 0; m < oList.Count; m++)
            {
                for (int n = 0; n < oList.Count - 1; n++)
                {
                    if (oList[n] > oList[n + 1])
                    {
                        temp = oList[n + 1];
                        oList[n + 1] = oList[n];
                        oList[n] = temp;
                    }
                }
            }
            int maxRow = oList[oList.Count - 1];
            for (int o = 0; o < maxRow; o++)
            {
                DataRow newRow = mergedDataTable.NewRow();
                int mergedDataTableColumn = 0;
                foreach (DataTable dt in dataTables)
                {
                    if (dt.Rows.Count > o)
                    {
                        for (int k = 0; k < dt.Columns.Count; k++)
                        {
                            newRow[mergedDataTableColumn] = dt.Rows[o][k];
                            mergedDataTableColumn++;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < dt.Columns.Count; k++)
                        {
                            newRow[mergedDataTableColumn] = DBNull.Value;
                            mergedDataTableColumn++;
                        }
                    }
                    //newRow[mergedDataTableColumn] = DBNull.Value;
                    //mergedDataTableColumn++;
                }
                mergedDataTable.Rows.Add(newRow);
                //FillBlankCell();
                //GridView1.DataSource = mergedDataTable;
                //GridView1.DataBind();
            }
            return mergedDataTable;
        }
        Decimal subtotal=0;
        Decimal qtysubtotal = 0;


        protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //GridView3.Columns[10].Visible = false;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string val3 = e.Row.Cells[12].Text;
                string val4 = e.Row.Cells[10].Text;
                //string val5 = e.Row.Cells[18].Text;
                Label weeks = (Label)e.Row.Cells[11].FindControl("Label2");
                TimeSpan difference = Convert.ToDateTime(val4) - Convert.ToDateTime(val3);
                Double days = Math.Round((Double)difference.TotalDays / 7);
                weeks.Text += days;//.ToString();
                //total += multiply;

                string val5 = e.Row.Cells[5].Text;
                string val6 = e.Row.Cells[6].Text;
                string val7 = e.Row.Cells[7].Text;
                Label Price = (Label)e.Row.Cells[8].FindControl("Label1");

                Decimal multiply = Math.Round(Convert.ToDecimal(val5) * Convert.ToDecimal(val6) * Convert.ToDecimal(1 - Convert.ToDecimal(val7) / 100), 2);
                Price.Text += multiply.ToString();
                subtotal += multiply;

                string val9 = e.Row.Cells[6].Text;
                Label qtyprice = (Label)e.Row.Cells[11].FindControl("Label3");
                Decimal qtytotal = Math.Round(Convert.ToDecimal(val5)*Convert.ToDecimal(val9));
                qtyprice.Text += qtytotal.ToString();
                qtysubtotal += qtytotal;
            }

            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                Label Totalpoint = (Label)e.Row.FindControl("total");
                Totalpoint.Text = subtotal.ToString();
                //e.Row.Cells[9].Text = total.ToString(); 
                //Label3.Text = Totalpoint.Text;
                //Label lblSub = (Label)e.Row.Cells[12].FindControl("AWSTotalpoint");
                Label lblSub = (Label)e.Row.FindControl("AWSTotalpoint");
                //lblSub.Text = AWS2total.ToString();

                Label Totalpoint2 = (Label)e.Row.FindControl("total2");
                //Totalpoint2.Text = qtysubtotal.ToString();
                //Label10.Text = qtysubtotal.ToString();
                Label Totalpoint3 = (Label)e.Row.FindControl("Label15");
                Totalpoint3.Text = qtysubtotal.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Label10.Visible = true;
            Button1.Visible = false;
            TextBox1.Visible = false;
            Button2.Visible = false;
            TextBox1.Text = null;
            ScriptManager.RegisterClientScriptBlock(this.Page, typeof(string), "print", "window.print();", true);
            //Button1.Visible = true;
            //TextBox1.Visible = true;
            //Button2.Visible = true;
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[0].Text == e.Row.Cells[2].Text) //Here is the condition!
                {  
                    //Change the cell color.
                    //e.Row.Cells[5].ForeColor = System.Drawing.Color.Yellow;
                    e.Row.Cells[2].Text = "N/A";
                    e.Row.Cells[3].Text = "N/A";
                    e.Row.Cells[4].Text = "N/A";
                    e.Row.Cells[5].Text = "N/A";
                    e.Row.Cells[6].Text = "N/A";
                    e.Row.Cells[7].Text = "N/A";

                    //Change the back color.
                    //e.Row.Cells[5].BackColor = Color.Red;
                    //Label1.Visible = true;
                    //Label1.Text = "Pending On AWS2";

                }
            }
        }

    }

}

        /*void ReadExcel()
        {
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        string query = null;
        string connString = "";
        //string strFileName = DateTime.Now.ToString("ddMMyyyy_HHmmss");
        //string strFileType = System.IO.Path.GetExtension(txtFilePath.FileName).ToString().ToLower();
 
       //Check file type
       //if (strFileType == ".xls" || strFileType == ".xlsx")
      //{
        // txtFilePath.SaveAs(Server.MapPath("~/UploadedExcel/" + strFileName + strFileType));
     // }
       // else
      // {
        //  lblMessage.Text = "Only excel files allowed";
        //  lblMessage.ForeColor = System.Drawing.Color.Red;
         /// lblMessage.Visible = true;
//return;
//}
 
//string strNewPath = Server.MapPath("~/UploadedExcel/" + strFileName);
        string strNewPath = @"D:\CSK\Carbide\Stock Statement - ATS.xlsx";
 
//Connection String to Excel Workbook
//if (strFileType.Trim() == ".xls")
//{
//connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
//}
//else if (strFileType.Trim() == ".xlsx")
//{
connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
//}

//query = "SELECT * FROM [T#C# Issue Details$A:G]";
//query = "SELECT TOP 1 * FROM [T#C# Issue Details$A:G] WHERE F1 BETWEEN "+TextBox1.Text+" AND "+TextBox2.Text+"";
query = "SELECT TOP 1 * FROM [T#C# Issue Details$A:G] WHERE F1 BETWEEN " + TextBox1.Text + " AND " + TextBox2.Text + "";
//query = "SELECT [Country],[Capital] FROM [Sheet1$] WHERE [Currency]=’Rupee’"
//query = "SELECT [Country],[Capital] FROM [Sheet1$]"
 
//Create the connection object
conn = new OleDbConnection(connString);
//Open connection
if (conn.State == ConnectionState.Closed) conn.Open();
//Create the command object
cmd = new OleDbCommand(query, conn);
da = new OleDbDataAdapter(cmd);
ds = new DataSet();
da.Fill(ds);
 
GridView1.DataSource = ds.Tables[0];
GridView1.DataBind();
 
//lblMessage.Text = "Data retrieved successfully! Total Records:" + ds.Tables[0].Rows.Count;
//lblMessage.ForeColor = System.Drawing.Color.Green;
//lblMessage.Visible = true;
 
  da.Dispose();
  conn.Close();
  conn.Dispose();
  }
  //  else
  //{
  //  lblMessage.Text = "Please select an excel file first";
  //  lblMessage.ForeColor = System.Drawing.Color.Red;
  //  lblMessage.Visible = true;
  // }*/
    