﻿namespace CongestionCharge.Core.Vehicles
{
    using System;
    using System.Collections.Generic;

    using CongestionCharge.Core.Charges;
    using CongestionCharge.Core.Interfaces;

    public class MotorBike : Vehicle
	{
		public override List<Charge> Charges
		{
			get
			{
				var daysChargeApplies = new List<DayOfWeek>
				{
					DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday
				};

				return new List<Charge>
				{
					new Charge(new TimeSpan(7, 0, 0), new TimeSpan(19, 0, 0), 1M, daysChargeApplies)
				};
			}
		}
	}
}
