using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class classbll
    {
        TestClz Obj1 = new TestClz();
        public DataSet getData()
        {
            return Obj1.getData();
        }
    }
}
