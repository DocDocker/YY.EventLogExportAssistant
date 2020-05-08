﻿using System.ComponentModel.DataAnnotations;

namespace YY.EventLogExportAssistant.PostgreSQL.Models
{
    public class TransactionStatuses : CommonLogObject
    {
        public long Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
