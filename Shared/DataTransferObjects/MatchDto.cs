﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedHel.DataTransferObjects
{
     public record MatchDto(int Id, int WinnerId, int LoserId, DateTime Timestamp);

}
