using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace XamarinFormsLocalDb
{
	public class jobdb
	{
		readonly SQLiteAsyncConnection database;

		public jobdb(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<job>().Wait();
		}

		public Task<List<job>> GetjobAsync()
		{
			return database.Table<job>().ToListAsync();
		}
 

		public Task<job> GetjobAsync(int id)
		{
			return database.Table<job>().Where(i => i.jobId == id).FirstOrDefaultAsync();
		}

		public Task<int> SavejobAsync(job item)
		{
			if (item.jobId != 0)
			{
				return database.UpdateAsync(item);
			}
			else {
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeletejobAsync(job item)
		{
			return database.DeleteAsync(item);
		}
	}
}
