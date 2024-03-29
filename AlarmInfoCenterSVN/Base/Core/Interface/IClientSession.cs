﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace AlarmInfoCenter.Base
{
	public interface IClientSession
	{
		event Action SessionDestroyedEvent;
		bool SessionStarted { get; }
		bool SessionDestroyed { get; }
		IPAddress ClientAddress { get; }

		void StartSession();
		void DestroySession(bool throwDestroyedEvent);
		void PushNewState();
	}
}
