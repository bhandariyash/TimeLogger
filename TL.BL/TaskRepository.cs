using System;
using System.Collections.Generic;
using System.Text;

namespace TL.BL
{
    class TaskRepository
    {
        public Task RetrieveTaskById(int taskId)
        {
            Task task = new Task("", -1, -1, -1);
            //Check if task exists by the id

            return task;
        }

        public bool SaveTask(Task task)
        {
            bool success = false;

            if (RetrieveTaskById(task.TaskId).TaskId == -1)
            {
                //Call an Insert Stored Procedure
            }
            else
            {
                //Call an Update Stored Procedure
            }
            return success;
        }

        public bool DeleteTask(Task task)
        {
            bool success = false;
            if (RetrieveTaskById(task.TaskId).TaskId == -1)
            {
                return true;
            }
            else
            {
                //Call delete Stored Procedure
            }
            return success;
        }
    }
}
