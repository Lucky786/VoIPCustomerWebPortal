﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VoipProjectEntities.Application.Features.CallRecordingAgents.Queries.GetCalllRecordingAgentDetail
{
    public class CallRecordingAgentDetailVm
    {
        public Guid CallRecordingAgentID { get; set; }

        public double Cost { get; set; }

        public DateTime Duration { get; set; }

        public int CallStatus { get; set; }

        public int Country { get; set; }
    }
}
