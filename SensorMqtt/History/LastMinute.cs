﻿using Microsoft.Maker.RemoteWiring;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Waher.Persistence.Attributes;

namespace SensorMqtt.History
{
	[CollectionName("MinuteValues")]
	public class LastMinute : Base
	{
	}
}
