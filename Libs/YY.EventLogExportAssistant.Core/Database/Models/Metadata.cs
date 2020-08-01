﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace YY.EventLogExportAssistant.Database.Models
{
    public class Metadata : ReferenceObject
    {
        #region Public Properties

        public Guid Uuid { get; set; }

        #endregion
        
        #region Public Methods

        public static IReadOnlyList<Metadata> PrepearedItemsToSave(InformationSystemsBase system, ReferencesData data)
        {
            return data.Metadata.Select(e =>
                new Metadata()
                {
                    InformationSystemId = system.Id,
                    Name = e.Name,
                    Uuid = e.Uuid
                }).ToList().AsReadOnly();
        }
        public override bool ReferenceExistInDB(EventLogContext context, InformationSystemsBase system)
        {
            Metadata foundItem = context.Metadata
                .FirstOrDefault(e => e.InformationSystemId == InformationSystemId && e.Name == Name);

            if (foundItem == null)
                return false;
            else
                return true;
        }
        public override void AddReferenceToSaveInDB(EventLogContext context, InformationSystemsBase system)
        {
            context.Metadata.Add(this);
        }

        #endregion
    }
}
