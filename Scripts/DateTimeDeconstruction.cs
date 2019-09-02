using System;

public static class DateTimeDeconstruction
{
	public static void Deconstruct
	(
		this DateTime self,
		out  int      year,
		out  int      month,
		out  int      day
	)
	{
		year  = self.Year;
		month = self.Month;
		day   = self.Day;
	}

	public static void Deconstruct
	(
		this DateTime self,
		out  int      year,
		out  int      month,
		out  int      day,
		out  int      hour,
		out  int      minute,
		out  int      second
	)
	{
		year   = self.Year;
		month  = self.Month;
		day    = self.Day;
		hour   = self.Hour;
		minute = self.Minute;
		second = self.Second;
	}
}