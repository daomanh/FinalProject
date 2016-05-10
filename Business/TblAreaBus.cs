using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TblAreaBus
    {
        TblAreaData tblA = new TblAreaData();
        public DataTable LoadArea()
        {            
            return tblA.LoadArea();
        }
    }
}
