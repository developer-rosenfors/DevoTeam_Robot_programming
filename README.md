Project Title
# DevoTeam_Robot_programming C# Solution

## Overview
This project implements a **robot controller** that navigates in a **grid-based room** following commands:
- **L** (Turn Left)
- **R** (Turn Right)
- **F** (Move Forward)

## Setup Instructions
### Prerequisites:
- **Visual Studio** (.NET 6 or later)
- **xUnit** for unit testing









Getting Started
Download and build at your local system.
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

Prerequisites
Visual Studio 2022

Give examples
Installing
A step by step series of examples that tell you how to get a development env running

Say what the step will be

Give the example
And repeat

until finished
End with an example of getting some data out of the system or using it for a little demo

Running the tests
Explain how to run the automated tests for this system

Break down into end to end tests
Explain what these tests test and why

Give an example
And coding style tests
Explain what these tests test and why
//
It’s a simple robot that can walk around in a room where the floor is represented as a number of fields in a
wire mesh. Input is first two numbers, which tells the robot how big the room is:
5 7
Which means that the room is 5 fields wide and is 7 fields deep.
The size of the room follows two digits and one letter indicating the starting
position of the robot and its orientation in space. For example:
1
3 3 N
Which means that the robot is in field (3, 3) and faces north. Subsequently, the
robot receives a number of navigation commands in the form of characters. The
following commands shall be implemented:
• L Turn left
• R Turn right
• F Walk forward
Example:
LFFRFRFRFF
If the robot walks outside of the room bounds an appropriate the program should
exit with an error code.
After the last command is received, the robot must report which field it is in
and what direction it is facing.
Example:
5 5
1 2 N
RFRFFRFRF
Report: 1 3 N
5 5
0 0 E
RFLFFLRF
Report: 3 1 E


Give an example
Deployment
Add additional notes about how to deploy this on a live system

Built With
Dropwizard - The web framework used
Maven - Dependency Management
ROME - Used to generate RSS Feeds
Contributing
Please read CONTRIBUTING.md for details on our code of conduct, and the process for submitting pull requests to us.

Versioning
We use SemVer for versioning. For the versions available, see the tags on this repository.

Authors
Billie Thompson - Initial work - PurpleBooth
See also the list of contributors who participated in this project.

License
This project is licensed under the MIT License - see the LICENSE.md file for details

Acknowledgments
Hat tip to anyone whose code was used
Inspiration
etc


### How to Run:
1. Clone the repository:
git clone <repository-url> cd RobotController

2. Open **Visual Studio** and load the solution.
3. Run `RobotController.sln` to execute the robot controller.
4. Enter:
- **Room Size** → `"5 5"`
- **Start Position** → `"1 2 N"`
- **Commands** → `"RFRFFRFRF"`
5. View the final **robot position**.

### Running Unit Tests
1. Open the test project in **Visual Studio**.
2. Run:
dotnet test

3. Ensure **all tests pass**.

## Git Repository Structure
- `/src` - Main application code
- `/tests` - Unit tests
- `README.md` - Instructions & setup guide

## Possible Enhancements
🔹 **Logging Mechanism** for debugging  
🔹 **Graphical Interface** for visualization  
🔹 **More Test Cases** for edge scenarios  

---

### **5. Git Setup Instructions**
```sh
# Initialize Git in your project directory
git init

# Add files to the repository
git add .

# Commit the initial implementation
git commit -m "Initial commit - Robot Controller"

# Create a GitHub repository and add the remote
git remote add origin <repository-url>

# Push the code to GitHub
git push -u origin main
