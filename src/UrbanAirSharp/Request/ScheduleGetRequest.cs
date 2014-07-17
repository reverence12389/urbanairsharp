﻿// Copyright (c) 2014-2015 Jeff Gosling (jeffery.gosling@gmail.com)
using System;
using System.Net.Http;

namespace UrbanAirSharp.Request
{
	/// <summary>
	/// Used to form a SCHEDULE request
	/// 
	/// http://docs.urbanairship.com/reference/api/v3/schedule.html#schedule-a-notification
	/// </summary>
	public class ScheduleGetRequest : BaseRequest
	{
		public ScheduleGetRequest(Guid scheduleId)
		{
			RequestUrl = "api/schedules/" + scheduleId;
			RequestMethod = HttpMethod.Get;
		}

		public override object GetContent()
		{
			return null;
		}
	}
}