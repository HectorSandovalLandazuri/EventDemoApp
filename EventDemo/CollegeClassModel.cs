







public class CollegeClassModel
{
    public EventHandler<string> EnrollmentFull;
    private List<string> enrolledStudents = new List<string>();
    private List<string> waitingList = new List<string>();

    public string CourseTitle { get; private set; }
    public int MaximumStudents { get; private set; }

    public CollegeClassModel(string title,int maximumStudents)
    {
        CourseTitle=title;
        MaximumStudents=maximumStudents;
    }

    public string SignUpStudent(string studentName)
    {
        string output = "";
        if (enrolledStudents.Count< MaximumStudents)
        {
            enrolledStudents.Add(studentName);
            output = $"{studentName} was enrolled in {CourseTitle}";
            //check if we waxed out
            if (enrolledStudents.Count==MaximumStudents)
            {
                EnrollmentFull?.Invoke(this, $"{CourseTitle} is now full.");
            }
        }
        else
        {
            waitingList.Add(studentName);
            output = $"{studentName} was added to the wait list in {CourseTitle}";
        }
        return output;
    }
}