# Temperature Converter

A Visual Basic .NET Windows Forms application that converts temperatures between Celsius and Fahrenheit.

## Features

- **Main Menu**: Choose between two conversion types
- **Celsius to Fahrenheit**: Convert Celsius temperatures to Fahrenheit
- **Fahrenheit to Celsius**: Convert Fahrenheit temperatures to Celsius
- **Input Validation**: Handles both valid and invalid numeric inputs gracefully
- **Supports Multiple Formats**: Accepts numbers with both period (.) and comma (,) as decimal separator, depending on system locale

## Project Structure

```
Assignment 2 demo/
├── Form1.vb                      # Main form with conversion choice buttons
├── FormCtoF.vb                   # Celsius to Fahrenheit converter form
├── FormFtoC.vb                   # Fahrenheit to Celsius converter form
├── Assignment 2 demo.vbproj      # Project configuration
└── My Project/                   # Application settings
```

## Getting Started

### Prerequisites

- .NET Framework 4.7.2 or higher
- Visual Studio Community 2019 or later (or any compatible IDE)

### Running the Application

1. Clone the repository:
   ```bash
   git clone https://github.com/illusive-1/Assignment-VB.git
   cd Assignment-VB
   ```

2. Open the solution file:
   ```bash
   start "Assignment 2 demo.slnx"
   ```

3. Build and run:
   - Press **F5** or click **Start** in Visual Studio
   - The main form will open with two conversion options

### Usage

1. **Select Conversion Type**:
   - Click "Celsius -> Fahrenheit" or "Fahrenheit -> Celsius"

2. **Enter Temperature**:
   - Type the temperature value in the input field
   - Use period (.) or comma (,) as decimal separator

3. **Convert**:
   - Click the "Convert" button
   - Result displays immediately

4. **Close**:
   - Click "Close" to return to the main menu

## Conversion Formulas

- **Celsius to Fahrenheit**: F = (C × 9/5) + 32
- **Fahrenheit to Celsius**: C = (F - 32) × 5/9

## Examples

- 0°C = 32°F
- 100°C = 212°F
- -40°C = -40°F

## License

This project is licensed under the MIT License — see the LICENSE file for details.

## Author

illus

## Assignment

Assignment 2 Demo - Temperature Converter Application
