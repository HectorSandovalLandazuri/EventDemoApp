CollegeClassModel history = new CollegeClassModel("History",3);
CollegeClassModel spanish = new CollegeClassModel("Spanish", 2);

history.EnrollmentFull += CollegeClass_EnrollellmentFull;


history.SignUpStudent("Héctor").PrintToConsole();
history.SignUpStudent("Claudia").PrintToConsole();
history.SignUpStudent("Ricky").PrintToConsole();
history.SignUpStudent("Manuel").PrintToConsole();
history.SignUpStudent("Nicolás").PrintToConsole();
Console.WriteLine();


spanish.EnrollmentFull += CollegeClass_EnrollellmentFull;


spanish.SignUpStudent("Héctor").PrintToConsole();
spanish.SignUpStudent("Claudia").PrintToConsole();
spanish.SignUpStudent("Ricky").PrintToConsole();

void CollegeClass_EnrollellmentFull(object sender, string e)
{
    //CollegeClassModel model = (CollegeClassModel)sender;
    Console.WriteLine();
    Console.WriteLine(e);
//    Console.WriteLine($"{model.CourseTitle} is now full.");
    Console.WriteLine();
}
