﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Models;

namespace Timesheets.Data.Interfaces
{
    public interface ISheetRepo: IRepoBase<Sheet>
    {
        Task<IEnumerable<Sheet>> GetItemsForInvoice(Guid cocontractId, DateTime dateStart, DateTime dateEnd);
    }
}