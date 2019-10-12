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

        private DateTime _startDateTime;
        public DateTime StartDateTime
        {
            get
            {
                //Make sure to convert UTC date time to client machine's timezone's datetime/configured timezone's datetime
                return _startDateTime;
            }

            set
            {
                //Convert client machine's timezone's local datetime/configured timezone's datetime to UTC datetime
                _startDateTime = value;
            }
        }

        private DateTime _endDateTime;
        public DateTime EndDateTime
        {
            get
            {
                //Make sure to convert UTC date time to client machine's timezone's datetime/configured timezone's datetime
                return _endDateTime;
            }

            set
            {
                //Convert client machine's timezone's local datetime/configured timezone's datetime to UTC datetime
                _endDateTime = value;
            }
        }

        public TimeSpan TaskDuration { get; set; }

    }
}
