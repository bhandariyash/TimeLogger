using System;
using System.Collections.Generic;
using System.Text;

namespace TL.BL
{
    public class Task
    {
        public string TaskName { get; set; }
        public int TaskId { get; private set; }
        public int AddedByUserId { get; private set; }
        public int CategoryId { get; private set; }

        public Task(string taskName, int taskId, int addedbyUserId, int categoryId)
        {
            TaskName = taskName;
            TaskId = taskId;
            AddedByUserId = addedbyUserId;
            CategoryId = categoryId;
        }

        public Task()
        {

        }
    }
}
