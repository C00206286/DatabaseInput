using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;       //microsoft Excel 14 object in references-> COM tab

namespace DatabaseInput
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Hello");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\brendan\Desktop\data2");
            //Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlWorksheet.UsedRange;
        

            //int rowCount = xlRange.Rows.Count;
            //int colCount = xlRange.Columns.Count;
        

            //Console.WriteLine(rowCount);
            //Console.WriteLine(colCount);

            //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=niteldb;password=Crab123");
            //con.Open();
            
            /*
            
            for (int i = 1; i <= rowCount; i++)

            {
                int y = 8;
                int j = 10;
                //for (int j = 14; j <= 14; j++)
                //for (int j = 1; j <= 1; j++)
                {
                    //new line
                    //if (j == 1)

                    //Console.Write("\r\n");

                    //write the value to the console



                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                       
                            Console.WriteLine(xlRange.Cells[i, j].Value2.ToString());
                            string owner = "";
                            //MySqlCommand cmd = new MySqlCommand("select * from company where id = 22", con);
                            MySqlCommand cmd2 = new MySqlCommand("select * from company", con);
                            MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            adp2.Fill(dt2);
                            foreach (DataRow row in dt2.Rows)
                            {
                                if(row["name"].ToString() == xlRange.Cells[i, y].Value2.ToString())
                                {
             
                                    owner = row[0].ToString();
                                }
                            }

                        MySqlCommand cmd3 = new MySqlCommand("select * from numbers where number = " + xlRange.Cells[i, j].Value2.ToString(), con);
                        MySqlDataAdapter adp3 = new MySqlDataAdapter(cmd3);
                        DataTable dt3 = new DataTable();
                        adp3.Fill(dt3);

                        if (dt3.Rows.Count == 0)
                        {
                            //MySqlCommand cmd = new MySqlCommand("select * from company where id = 22", con);
                            MySqlCommand cmd = new MySqlCommand("insert into numbers (number, owner) values (" + xlRange.Cells[i, j].Value2.ToString() + ", " + owner + ")", con);
                            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                  
                            adp.Fill(dt);

                            cmd.Dispose();

                        }

                      
                        cmd2.Dispose();
                        cmd3.Dispose();

                        
                    }
                    //Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                }
            }

    */
    




           // MySqlCommand cmd = new MySqlCommand("select * from company where id = 22", con);
           // MySqlCommand cmd = new MySqlCommand("update company set name = 'Mansell' where id = 22", con);
            //MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
           // DataTable dt = new DataTable();
           // DataSet ds = new DataSet();

            //adp.Fill(dt);

           // foreach (DataRow row in dt.Rows)
             //   Console.WriteLine("{0} {1}", row[0], row["name"]);

            // adp.Fill(ds);

            // Console.WriteLine(ds.Tables.Count);
            //Console.WriteLine(ds.Tables[0].TableName);
            //foreach (DataRow row in ds.Tables["company"].Rows)
            //  Console.WriteLine("{0} {1}", row[0], row[1]);



            //con.Close();
            //cmd.Dispose();
            //cleanup
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(xlRange);
            //Marshal.ReleaseComObject(xlWorksheet);

            //close and release
           // xlWorkbook.Close();
           // Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
           // xlApp.Quit();
          //  Marshal.ReleaseComObject(xlApp);

            Application.Run(new Form1());
            

        }
        
    }
}
