﻿using Inspection_of_Measuring_Instruments.Shared.Models.InstrumentModels;

namespace Inspection_of_Measuring_Instruments.Shared.Models.InspectionModels;

public class ScaleInspectionModel : BaseInspectionModel
{
    public ICollection<ScaleModel>? Scale { get; set; }
}