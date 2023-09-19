namespace UsingQueues.SingleAdvisor
{
    public class InterviewCenter
    {
        private int _count = 0;

        public Queue<WalkInInterview>? Interviews { get; set; }

        public InterviewCenter()
        {
            Interviews = new Queue<WalkInInterview>();
        }

        public void Interview(string stuID)
        {
            WalkInInterview interview = new WalkInInterview()
            {
                InterviewTime = DateTime.Now,
                StudentID = stuID,
                InterviewID = ++_count
            };

            Interviews?.Enqueue(interview);
        }

        public WalkInInterview AttendToStudent(string advisor)
        {
            if (Interviews?.Count > 0)
            {
                WalkInInterview interview = Interviews.Dequeue();
                interview.Advisor = advisor;
                interview.StartTime = DateTime.Now;
                return interview;
            }
            return null;
        }

        public void endIntervierw(WalkInInterview inter)
        {
            inter.EndTime = DateTime.Now;
        }
    }
}
