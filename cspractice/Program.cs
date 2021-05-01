using System;

// Base class
class Person {
    public string name;
    public int age;
    public string gender;

    // Constructor method
    public Person(string n, int a, string g) {
        name = n;
        age = a;
        gender = g;
    }

    public void showInfo() {
        try {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age + " yrs");
            Console.WriteLine("Gender: " + gender);

            // Exception handling:
            if (gender != "Male" || gender != "Female") {
                throw new Exception(); 
            }
        } 
        catch (Exception) {
            Console.WriteLine("Why r u gae?!");
        }
        Console.WriteLine();
    }
}

class Student : Person {
    private int std_id;
    public string institute;
    public double[] exam_results = new double[3];

    public Student(string n, int a, string g, int id, string ins) : base (n, a, g){
        std_id = id;
        institute = ins;
    }

    public void setResults() {
        string[] exams = {"JSC", "SSC", "HSC"}; 
        Console.WriteLine("Enter GPA for three exams: ");
        for (int i=0; i < 3; i++) {
            Console.Write(exams[i] + ": ");
            double gpa = Convert.ToDouble(Console.ReadLine());
            exam_results[i] = gpa;
        }
        Console.WriteLine();
    }

    public void showResult() {
        string[] exams = {"JSC", "SSC", "HSC"}; 
        Console.WriteLine("Result of " + name + "(" + std_id + ")");
        Console.WriteLine("Institute: " + institute);
        for (int i=0; i < 3; i++) {
            Console.Write(exams[i] + ": ");
            Console.WriteLine(exam_results[i]);
        }
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        Person p1 = new Person("Karim", 23, "Unclassified");
        p1.showInfo();

        Student s1 = new Student("MT Ekleel", 19, "Male", 10113, "EUSC");
        s1.setResults();
        s1.showInfo();
        s1.showResult();
    }
}
