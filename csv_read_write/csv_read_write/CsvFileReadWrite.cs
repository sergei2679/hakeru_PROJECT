using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows;

namespace csv_read_write
{
    public class CsvFileReadWrite //: StreamReader
    {
        const string connString = @"Data Source=LAPTOP-T5P076II\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static string filePath;

        public CsvFileReadWrite(string path)
        {
            filePath = path;
        }     

        public void Read()
        {
            // Open the file to read from.
            string[] readText = File.ReadAllLines(filePath);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }

        //private DataTable BuildDataTable()
        //{
        //    DataTable table = new DataTable();
        //    try
        //    {
        //        using (TextFieldParser csvReader = new TextFieldParser(filePath))
        //        {
        //            csvReader.HasFieldsEnclosedInQuotes = true;
        //            csvReader.SetDelimiters(new string[] { "," });

        //            string[] colFields = csvReader.ReadFields();

        //            foreach (string column in colFields)
        //            {
        //                DataColumn column1 = new DataColumn(column);
        //                DataColumn column2 = new DataColumn(column);
        //                DataColumn column3 = new DataColumn(column);

        //                column1.AllowDBNull = true;
        //                column2.AllowDBNull = true;
        //                column3.AllowDBNull = true;

        //                table.Columns.Add(column1);
        //                table.Columns.Add(column2);
        //                table.Columns.Add(column3);
        //            }
        //            while (!csvReader.EndOfData)
        //            {
        //                string[] fieldData = csvReader.ReadFields();
        //                //Making empty value as null
        //                for (int i = 0; i < fieldData.Length; i++)
        //                {
        //                    if (fieldData[i] == "")
        //                    {
        //                        fieldData[i] = null;
        //                    }
        //                }
        //                table.Rows.Add(fieldData);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    return table;
        //}

        public void Write()  // string timeStamp
        {
            try
            {
                //specify file name of log file (csv).
                string newFileName = filePath;

                //check to see if file exists, if not create an empty file with the specified file name.
                if (!File.Exists(newFileName))
                {
                    FileStream fs = new FileStream(newFileName, FileMode.CreateNew);
                    fs.Close();

                    //define header of new file, and write header to file.
                    string csvHeader = "ID,Country,Date";

                    using (FileStream fsWHT = new FileStream(newFileName, FileMode.Append, FileAccess.Write))
                    using (StreamWriter swT = new StreamWriter(fsWHT))
                    {
                        swT.WriteLine(csvHeader.ToString());
                    }
                }

                //set up connection to database.
                SqlConnection sqlConn;

                //string cDEString = "Data Source=localhost\\NAMEDPIPE;Initial Catalog=db;User Id=user;Password=pwd";
                string strCommand = "select OrderID,ShipCountry,ShippedDate from Orders";

                try
                {
                    sqlConn = new SqlConnection(connString);
                }
                catch (Exception ex)
                {
                    //error handling here.
                    MessageBox.Show(ex.Message);
                    return;
                }

                try
                {
                    sqlConn.Open();
                }
                catch (Exception ex)
                {
                    //error handling here.
                    MessageBox.Show(ex.Message);
                    return;
                }

                SqlDataReader reader = null;
                SqlCommand sqlCommand = new SqlCommand(strCommand, sqlConn);

                try
                {
                    reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {

                        //grab relevant tag data and set the csv line for the current row.
                        string csvDetails = reader["OrderID"] + "," + reader["ShipCountry"] + "," + reader["ShippedDate"];

                        using (FileStream fsWDT = new FileStream(newFileName, FileMode.Append, FileAccess.Write))
                        using (StreamWriter swDT = new StreamWriter(fsWDT))
                        {
                            //write csv line to file.
                            swDT.WriteLine(csvDetails.ToString());
                        }
                    }
                }

                catch (Exception ex)
                {
                    //error handling here.
                    sqlConn.Close();
                    return;
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                //error handling here.
                MessageBox.Show(ex.Message);
            }
        }

        //public string[] GetArray()
        //{
        //    return array;
        //}

        //public void PrintScreen()
        //{
        //    //string[] arr = new string[];
        //    var s = UniqueList(array);
        //    foreach (var r in s)
        //        Console.WriteLine(r);
        //}     

    }

}
