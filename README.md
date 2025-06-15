# DevoTeam_Robot_programming
DevoTeam_Robot_programming - Robot Controller in C#

A C# solution for simulating a robot moving on a 2D grid, with robust movement logic and error handling. The robot can turn left/right, move forward, and reports its position and direction. The project includes unit tests for all core behaviors.

## Features

- Move a robot on a grid with commands: `F` (forward), `L` (turn left), `R` (turn right)
- Prevents moving out of grid bounds (throws exception)
- Handles invalid commands with clear error messages
- Unit tests for movement, turning, error handling, and edge cases

## Requirements

- .NET Framework 4.7.2 or .NET 8 (depending on project)
- Visual Studio 2019 or later recommended
- xUnit for unit testing

## Getting Started

1. **Clone the repository**  

2. **Open the solution in Visual Studio**  
Open the `.sln` file.

3. **Build the solution**  
Use __Build Solution__ (`Ctrl+Shift+B`).

4. **Run the tests**  
- Open the __Test Explorer__ (`Test > Test Explorer`)
- Click __Run All__

## Git Repository Structure
- `/DevoTeam_Robot_programming` - Main application code
- `/DevoTeam_Robot_Programming.Tests` - Unit tests
- `README.md` - Instructions & setup guide

## Possible Enhancements
🔹 **Logging Mechanism** for debugging  
🔹 **Graphical Interface** for visualization  
🔹 **More Test Cases** for edge scenarios  

## Usage Example

### Parameters

- **Grid Size:**  
  The grid is defined by its width and height (e.g., `5 5` for a 5x5 grid).

- **Starting Position:**  
  The robot's initial position and direction are specified as:  
  `<X> <Y> <Direction>`  
  Example: `1 2 N` (X=1, Y=2, facing North)  
  Directions:  
    - `N` = North  
    - `E` = East  
    - `S` = South  
    - `W` = West  

- **Commands:**  
  A string of characters, each representing an action:  
    - `L` = Turn left  
    - `R` = Turn right  
    - `F` = Move forward  

### Example






