using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TblAreaData
    {
        DataConnection conn = new DataConnection();
        public DataTable LoadArea()
        {
            return conn.LoadArea();
        }
    }
}
