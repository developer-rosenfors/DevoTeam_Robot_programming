<<<<<<< HEAD
# DevoTeam Robot Programming

A C# solution for simulating a robot moving on a 2D grid, with robust movement logic and error handling. The robot can turn left/right, move forward, and reports its position and direction. The project includes unit tests for all core behaviors.

## Features

- Move a robot on a grid with commands: `F` (forward), `L` (turn left), `R` (turn right)
- Prevents moving out of grid bounds (throws exception)
- Handles invalid commands with clear error messages
- Unit tests for movement, turning, error handling, and edge cases

## Requirements

- .NET Framework 4.7.2 or .NET 8 (depending on project)
- Visual Studio 2019 or later recommended

## Getting Started

1. **Clone the repository**  

2. **Open the solution in Visual Studio**  
Open the `.sln` file.

3. **Build the solution**  
Use __Build Solution__ (`Ctrl+Shift+B`).

4. **Run the tests**  
- Open the __Test Explorer__ (`Test > Test Explorer`)
- Click __Run All__

## Usage Example
=======
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





>>>>>>> 976d6b0fdecd3737911229dfe8d31ca3c896623e

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

<<<<<<< HEAD
## Error Handling

- Throws `ArgumentException` for invalid commands or directions.
- Throws `InvalidOperationException` if the robot moves out of bounds.
- Throws `ArgumentNullException` if command string is null.

## Project Structure

- `DevoTeamRobot` - Main robot logic
- `DevoTeamRobot.Tests` - Unit tests for all behaviors

## Contributing

Pull requests are welcome. For major changes, please open an issue first.

## License

This project is licensed under the MIT License.

=======
>>>>>>> 976d6b0fdecd3737911229dfe8d31ca3c896623e






