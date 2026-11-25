using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoUseLibrary
{
    public class ExceptionEntity
    {
        public int Id { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
