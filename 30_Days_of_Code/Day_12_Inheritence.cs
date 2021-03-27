// AWN
//https://www.hackerrank.com/challenges/30-inheritance/problem

class Student : Person{
    private int[] testScores;  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int identification, int[] scores):
        base(firstName, lastName, identification)
        {
            this.testScores = scores;
        }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        int avg = 0;
        int sum = 0;
        
        for (int i = 0; i < testScores.Count(); i++)
            sum += testScores[i];     
        
        avg = sum / testScores.Count();
        
        if (avg >= 90 && avg <= 100)
            return 'O';
        else if (avg >= 80 && avg < 90)
            return 'E';
        else if (avg >= 70 && avg < 80)
            return 'A';
        else if (avg >= 55 && avg < 70)
            return 'P';
        else if (avg >= 40 && avg < 55)
            return 'D';
        else
            return 'T';
    }
}

class Solution {
	static void Main() 
    {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}