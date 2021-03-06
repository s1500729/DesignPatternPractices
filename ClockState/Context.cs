﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClockState
{
	public interface Context
	{
		void SetClock(int hour);
		void ChangeState(State state);
		void CallSecurityCenter(string msg);
		void RecordLog(string msg);
	}
}
