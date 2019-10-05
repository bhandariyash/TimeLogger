using System;
using System.Collections.Generic;
using System.Text;

namespace TL.BL
{
    class ActualTask
    {
        public int ActualTaskId { get; private set; }
        public int ActualTaskCategoryId { get; private set; }
        public int ActualTaskTaskId { get; private set; }
        public int ActualTaskUserId { get; private set; }
        public string Location { get; set; }
        public string[] ActualTaskParticipants { get; set; }
        public int MyProperty { get; set; }
    }
}
