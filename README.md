# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

During this assessment, you may use most other resource besides your fellow students.  Feel free to google, look back at your notes, lessons, labs, etc... **you may not use Chat GPT or any other AI tool**

## Set Up

Fork this repository! (Don't clone it yet!!)

## Questions (12 Points Possible)
Edit this `README.md` file - answer the 6 questions before moving on to the exercise.  Make sure to save your changes to the README before moving on to the exercises!

To Edit the README:
* click the pencil icon in the upper right corner.
* make changes in the text editor.
* save your changes by clicking 'Commit Changes'
    * on the confirmation screen, click 'Commit Changes'
 
</br>
</br>

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  <---- This is not a valid option, as it has no way of linking this instance to 'Chair', it is just floating around by itself with an invalid reference. // ANSWER
    D. `Chair bench = new(24, true);`  
    
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:

  ANSWER: "OOP stands for object-oriented programming, it organizes code into objects, which are different representations of classes. Objects represent actual items and have attributes, and methods to actually do something with those attributes. They make it much easier to manage your code, as every part of it is contained within these packages for you to modify or use later. They can contain these fixed parts to them, which allow you to reuse them easily and indefinitely. They also have a lot more structure to them, making everything look better and more legible."

4. What is Automated Testing?

ANSWER: Automated testing is testing code before it is put into production, as in before putting it into the already working and functional structure of a written program. You can make sure it works and passes these functionality tests, before implementing it and potentially breaking other code that is in use.

5. What are some benefits of creating tests for our projects?

ANSWER: The benefits would be: being able to see if the code is functional, before putting it into the program that we intend to. If you can check for its functionality, you can make sure it's ready to go, before making sure the program is ready to accept it. If bad code was implemented into a program that was in use, like at a company, it could potentially break and crash the entire application for all its users, and downtime is bad for business. Even if the code is good, there may be steps that need to be taken to make it mesh with the existing code, and therefore its in your best interests to check it, make sure its good, and then sort everything else out.

6. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?

ANSWER: You need to add a project reference, so that the testing file knows what it is supposed to be testing.

7. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working. You do not need to write the whole test, just what you would **name** the test methods. Ex: `IsCreatedWithTwoArguments()`
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Summary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```

ANSWER: 

The test for ensuring that it is a vehicle that has wheels, color, and mileage may be named: "Vehicle.HasCorrectProperties()"

The test for ensuring that the string works properly is: "Summary_ReturnsInfoAboutVehicle()"

The test for making sure miles are added to the count for the vehicle would be: "Drive_AddsMilesToVehicle()"

The test for changing the color of the vehicle is: "Paint_ChangesColorOfVehicle()"

## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When the assessment is due, your instructors will show you how to commit the code you worked on in Visual Studio and push it up to GitHub :) 

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
