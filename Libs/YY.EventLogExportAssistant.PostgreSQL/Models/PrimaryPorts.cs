﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YY.EventLogExportAssistant.PostgreSQL.Models
{
    public class PrimaryPorts : LogObject
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