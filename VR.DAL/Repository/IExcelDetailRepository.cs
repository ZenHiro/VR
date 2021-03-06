﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VR.DAL.Model;
namespace VR.DAL.Repository
{
    public interface IExcelDetailRepository: IBaseRepository<ExcelDetail>
    {
        TruckStatus? GetStatus(int excelDetailId);

        bool UpdateStatus(int excelDetailId, int newStatus);
    }
}
