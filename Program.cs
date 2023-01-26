
// Average Exam Score Calculator Program

const int TOTAL = 5;
double averageFormula = 0;
double scoreOne = 0;
double scoreTwo = 0;
double scoreThree= 0;
double scoreFour = 0;
double scoreFive = 0;

Console.WriteLine("Exam Average Calculator (Assuming the total is out of 100)");    // Produces title of program
Console.WriteLine();

Console.Write("Enter 1st exam score: ");
string scoreInputOne = Console.ReadLine();
scoreOne = double.Parse(scoreInputOne);
                                                 
Console.Write("Enter 2nd exam score: ");                  
string scoreInputTwo = Console.ReadLine();                 
scoreTwo = double.Parse(scoreInputTwo);                      
                                                               
Console.Write("Enter 3rd exam score: ");                          
string scoreInputThree = Console.ReadLine();                // Collects data from user      
scoreThree = double.Parse(scoreInputThree);                        
                                                                
Console.Write("Enter 4th exam score: ");                     
string scoreInputFour = Console.ReadLine();               
scoreFour = double.Parse(scoreInputFour);              
                                                    
Console.Write("Enter 5th exam score: ");         
string scoreInputFive = Console.ReadLine();   
scoreFive = double.Parse(scoreInputFive);  

Console.WriteLine();
Console.WriteLine("Exam Score: " + scoreOne);
Console.WriteLine("Exam Score: " + scoreTwo);
Console.WriteLine("Exam Score: " + scoreThree);             // Displays user entries
Console.WriteLine("Exam Score: " + scoreFour);
Console.WriteLine("Exam Score: " + scoreFive);

averageFormula = (scoreOne + scoreTwo + scoreThree + scoreFour + scoreFive) / TOTAL;

Console.WriteLine();
Console.WriteLine("The average of the exam scores is: {0:F2}", averageFormula); // Displays the users output using the formula

