﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace YY.EventLogExportAssistant.Database.Models
{
    public class Computers : ReferenceObject
    {
        #region Public Methods

        public static IReadOnlyList<Computers> PrepearedItemsToSave(InformationSystemsBase system, ReferencesData data)
        {
            return data.Computers.Select(e =>
                new Computers()
                {
                    InformationSystemId = system.Id,
                    Name = e.Name
                }).ToList().AsReadOnly();
        }
        public override bool ReferenceExistInDB(EventLogContext context, InformationSystemsBase system)
        {
            Computers foundItem = context.Computers
                .FirstOrDefault(e => e.InformationSystemId == InformationSystemId && e.Name == Name);

            if (foundItem == null)
                return false;
            else
                return true;
        }
        public override void AddReferenceToSaveInDB(EventLogContext context, InformationSystemsBase system)
        {
            context.Computers.Add(this);
        }

        #endregion
    }
}
