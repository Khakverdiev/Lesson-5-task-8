Student stud = new Student();

stud.FirstName = "Vladimir";
stud.LastName = "Vladimirovic";
stud.Patronymic = "Ivanov";
stud.Group = 20;
stud.Age = 17;
stud.GradeProgramming = 11;
stud.GradePr(stud);
stud.GradeProgramming = 10;
stud.GradePr(stud);
stud.GradeProgramming = 12;
stud.GradePr(stud);
stud.GradeProgramming = 9;
stud.GradePr(stud);

stud.GradeAdministrative = 12;
stud.GradeAd(stud);
stud.GradeAdministrative = 11;
stud.GradeAd(stud);
stud.GradeAdministrative = 8;
stud.GradeAd(stud);
stud.GradeAdministrative = 9;
stud.GradeAd(stud);

stud.GradeDesign = 12;
stud.GradeDe(stud);
stud.GradeDesign = 10;
stud.GradeDe(stud);
stud.GradeDesign = 8;
stud.GradeDe(stud);
stud.GradeDesign = 10;
stud.GradeDe(stud);
Student.info(stud);

class Student
{
    public string FirstName { get; set; } = "Empty";
    public string LastName { get; set; } = "Empty";
    public string Patronymic { get; set; } = "Empty";
    private int group;
    private int age;
    private int gradeProgramming;
    private int gradeAdministrative;
    private int gradeDesign;

    public int Group 
    {
        get { return group; }
        set
        {
            if (value > 0 && value < 21)
            {
                group = value;
            }
        }
    }

    public int Age
    {
        get { return age; } 
        set 
        {
            if (value > 0 && value < 110)
            {
                age = value;
            }
        }
    }

    public int GradeProgramming
    {
        get { return gradeProgramming; }
        set 
        {
            if (value > 0 && value < 13)
            {
                gradeProgramming = value;
            }
        }
    }

    public int GradeAdministrative
    {
        get { return gradeAdministrative; }
        set
        {
            if (value > 0 && value < 13)
            {
                gradeAdministrative = value;
            }
        }
    }

    public int GradeDesign
    {
        get { return gradeDesign; }
        set
        {
            if (value > 0 && value < 13)
            {
                gradeDesign = value;
            }
        }
    }

    public int[][] grades = new int[3][] { new int[0], new int[0], new int[0] };

    public void GradePr(Student student)
    {
        int[] gr = new int[grades[0].Length + 1];
        for(int i = 0; i < gr.Length - 1; ++i)
        {
            gr[i] = grades[0][i];
        }
        gr[gr.Length - 1] = student.GradeProgramming;
        grades[0] = new int[gr.Length];
        for (int i = 0; i < gr.Length; ++i) 
        {
            grades[0][i] = gr[i];
        }
    }

    public void GradeAd(Student student)
    {
        int[] gr = new int[grades[1].Length + 1];
        for (int i = 0; i < gr.Length - 1; ++i)
        {
            gr[i] = grades[1][i];
        }
        gr[gr.Length - 1] = student.GradeAdministrative;
        grades[1] = new int[gr.Length];
        for (int i = 0; i < gr.Length; ++i)
        {
            grades[1][i] = gr[i];
        }
    }

    public void GradeDe(Student student)
    {
        int[] gr = new int[grades[2].Length + 1];
        for (int i = 0; i < gr.Length - 1; ++i)
        {
            gr[i] = grades[2][i];
        }
        gr[gr.Length - 1] = student.GradeDesign;
        grades[2] = new int[gr.Length];
        for (int i = 0; i < gr.Length; ++i)
        {
            grades[2][i] = gr[i];
        }
    }

    public static void info(Student stud)
    {
        Console.WriteLine($"Name - {stud.FirstName}");
        Console.WriteLine($"Surname - {stud.LastName}");
        Console.WriteLine($"Patronymic - {stud.Patronymic}");
        Console.WriteLine($"Group - {stud.group}");
        Console.WriteLine($"Age - {stud.age}");

        double scorePr = 0.0;
        double scoreAd = 0.0;
        double scoreDe = 0.0;
        Console.WriteLine("Programming: ");
        for (int i = 0; i < stud.grades[0].Length; i++)
        {
            scorePr += stud.grades[0][i];
            Console.Write($"{stud.grades[0][i]} ");
        }
        Console.WriteLine();
        Console.WriteLine($"Score - {scorePr / stud.grades[0].Length}");

        Console.WriteLine("Administrative: ");
        for(int i = 0; i < stud.grades[1].Length; ++i)
        {
            scoreAd += stud.grades[1][i];
            Console.Write($"{stud.grades[1][i]} ");
        }
        Console.WriteLine();
        Console.WriteLine($"Score - {scoreAd / stud.grades[1].Length}");

        Console.WriteLine("Design: ");
        for(int i = 0; i < stud.grades[2].Length; ++i)
        {
            scoreDe += stud.grades[2][i];
            Console.Write($"{stud.grades[2][i] } ");
        }
        Console.WriteLine();
        Console.WriteLine($"Score - {scoreDe / stud.grades[2].Length}");
    }
}