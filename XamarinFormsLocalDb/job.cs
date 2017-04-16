using System;
using SQLite;

namespace XamarinFormsLocalDb
{
	public class job
	{
		[PrimaryKey, AutoIncrement]
		public int jobId { get; set; }
		public string CompanyName { get; set; }
		public string Position { get; set; }
		public string AboutJob { get; set; }
		public string PayRate { get; set; }
		public string CompanySites { get; set; }
		public bool Workauthorization { get; set; }
		public string ContactInfo { get; set; }
		public string appliedDate { get; set; }
		public string interviewDate { get; set; }
		public bool IsCustomTeamNamesSwitchToggled { get; set; }
		public bool Reject { get; set; }
	}
}
