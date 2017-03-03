using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GeoPrivacyVisualizerApplication
{
    public class Util
    {
        public static DataTable GetDataTableFromCsv(string CSVFilePathName, bool IsFirstRowHeader)
        {
            DataTable dt = new DataTable();

            using (var MyReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(CSVFilePathName))
            {
                MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                MyReader.Delimiters = new String[] { "," };

                string[] currentRow;

                //'Loop through all of the fields in the file.  
                //'If any lines are corrupt, report an error and continue parsing.  
                bool firstRow = true;
                while (!MyReader.EndOfData)
                {
                    try
                    {
                        currentRow = MyReader.ReadFields();

                        //Add the header columns
                        if (IsFirstRowHeader && firstRow)
                        {
                            foreach (string c in currentRow)
                            {
                                dt.Columns.Add(c, typeof(string));
                            }

                            firstRow = false;
                            continue;
                        }

                        //Create a new row
                        DataRow dr = dt.NewRow();
                        

                        //Loop thru the current line and fill the data out
                        for (int c = 0; c < currentRow.Count(); c++)
                        {
                            dr[c] = currentRow[c];
                        }
                        dt.Rows.Add(dr);
                    }
                    catch (Microsoft.VisualBasic.FileIO.MalformedLineException ex)
                    {
                        //Handle the exception here
                    }
                }
            }

            return dt;
        }
        
    }

}
