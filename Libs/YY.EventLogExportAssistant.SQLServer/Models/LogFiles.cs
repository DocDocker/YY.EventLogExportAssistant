﻿using System;

namespace YY.EventLogExportAssistant.SQLServer.Models
{
    public class LogFiles : CommonLogObject
    {        
        public string FileName { set; get; }
        public DateTime CreateDate { set; get; }
        public long Id { set; get; }
        public DateTime ModificationDate { set; get; }
        public long LastEventNumber { set; get; }
        public string LastCurrentFileReferences { set; get; }
        public string LastCurrentFileData { set; get; }
        public long LastStreamPosition { set; get; }

    }
}
