using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class TestLogic
    {
        private bool TestMulti()
        {
            logic log = new logic();

            if (log.Multi(5, 5) == 25)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private bool TestAdd()
        {
            logic log = new logic();
            if (log.Add(5, 5) == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
