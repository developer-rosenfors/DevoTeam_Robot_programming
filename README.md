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

## Getting Started
Download and build at your local system.
These instructions will get you a copy of the project up and running on your local machine for development and 
testing purposes. 

### How to Run:
1. Clone the repository:
git clone <repository-url> cd DevoTeam_Robot_programming

2. Open **Visual Studio** and load the solution.
3. Run `DevoTeam_Robot_programming.sln` to execute the robot controller.
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







