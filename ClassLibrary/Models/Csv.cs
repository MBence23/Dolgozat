using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Csv
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }

        public Csv()
        {

            Column1 = "";
            Column2 = "";
        }

        public Csv(string csvRow)
        {
            string[] columns = csvRow.Split(',');


            if (columns.Length >= 2)
            {

                Column1 = columns[0];
                Column2 = columns[1];

            }

        public override string ToString()
        {
            return $"Column1: {Column1}, Column2: {Column2}";
        }



    }
}
    



 
