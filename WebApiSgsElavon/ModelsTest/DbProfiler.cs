using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class DbProfiler
    {
        public int RowNumber { get; set; }
        public int? EventClass { get; set; }
        public string TextData { get; set; }
        public int? Spid { get; set; }
        public DateTime? StartTime { get; set; }
        public byte[] BinaryData { get; set; }
    }
}
