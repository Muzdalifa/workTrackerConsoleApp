using System;
using System.Collections.Generic;
using System.Text;

namespace workTrackerConsoleApp.Models
{
    interface IInfo
    {
        const string INFOSTART = "-------info-------"; //you cant have field inside interface but you can have constant
        public int Id { get; set; }
        string Info();

    }
}
