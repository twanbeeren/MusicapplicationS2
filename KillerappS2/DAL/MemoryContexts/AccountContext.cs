using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class AccountContext : IAccountContext
    {
        public List<string> Taalgebruiklijst()
        {
            List<string> groftaalgebruik = new List<string>();
            groftaalgebruik.Add("fuck");
            groftaalgebruik.Add("kut");
            groftaalgebruik.Add("godverdomme");
            groftaalgebruik.Add("homeopatische genotsflikker");

            return groftaalgebruik;
        }
    }
}
