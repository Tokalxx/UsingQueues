namespace UsingQueues.SingleAdvisor
{
    public class Tester
    {
        static void Main(string[] args)
        {
            InterviewCenter interCen = new InterviewCenter();
            Random ran = new Random();
            interCen.Interview("st123");
            interCen.Interview("st456");
            interCen.Interview("st789");
            interCen.Interview("st012");


            while (interCen.Interviews.Count > 0)
            {

                WalkInInterview walkInInterview = interCen.AttendToStudent("David Something");
                printTime($"Interview # {walkInInterview.InterviewID} for Student ({walkInInterview.StudentID})" +
                    $"is attended by {walkInInterview.Advisor}");
                //Code sleeps for 10 sec
                Thread.Sleep(ran.Next(1000, 5000));
                interCen.endIntervierw(walkInInterview);

                printTime($"Interview # {walkInInterview.InterviewID} with Student ({walkInInterview.StudentID})" +
                    $"is attended by {walkInInterview.Advisor} at {walkInInterview.EndTime.ToString("HH:mm:ss")}");

            }

            Console.Read();

        }

        static void printTime(string str)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")} - {str}]");
        }
        //static void printInter(WalkInInterview inter)
        //{
        //    Console.WriteLine($"{inter.StudentID}, {inter.Advisor}, {inter.StartTime},");
        //}
    }
}
