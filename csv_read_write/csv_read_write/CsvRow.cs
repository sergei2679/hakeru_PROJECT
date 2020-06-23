using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv_read_write
{

    public class CsvRow : List<string>
    {
        public CsvRow(string col1, string col2, string col3)
        {
            Col1 = col1;
            Col2 = col2;
            Col3 = col3;
        }

        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }

        public string LineText { get; set; }
    }
}
