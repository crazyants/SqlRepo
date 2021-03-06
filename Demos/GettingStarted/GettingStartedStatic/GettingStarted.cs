﻿using System;
using SqlRepo.SqlServer.Static;

namespace GettingStartedStatic
{
    public class GettingStarted
    {
        public void DoIt()
        {
            var repository = RepoFactory.Create<ToDo>();
            var results = repository.Query()
                                    .Select(e => e.Id, e => e.Task, e => e.CreatedDate)
                                    .Where(e => e.IsCompleted == false)
                                    .Go();
            // ...
        }
    }
}