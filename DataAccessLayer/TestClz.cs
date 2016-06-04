using DataAccessLayer.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TestClz:DBObject
    {
        public DataSet getData()
        {
            return RunProcedure("saveTest");
        }
    }
}
