﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mainumbi.Lakeli
{
    public interface IJobManager
    {
        Task<Job> CreateAsync(Guid newId, Guid userId, string comment, string contactNumber, string adress);
        Task<List<Job>> GetJobsAsync(JobState? state = null, Guid? userID = null);
    }
}
