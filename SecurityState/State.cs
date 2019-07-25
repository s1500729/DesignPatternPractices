﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityState
{
	public interface State
	{
		void DoClock(Context context, int hour);
		void DoUse(Context context);
		void DoAlarm(Context context);
		void DoPhone(Context context);
	}
}
