# Birthdate Validator - C# Console Application


# Overview
This C# console application prompts the user to enter their birthdate in YYYY/MM/DD format.
It validates the input, calculates the user's age, and provides specific messages based on different conditions such as:

	* If the user is 100 years or older.
	* If the entered date is today.
	* If the entered date is in the future.
	* If today is the user's birthday.

# Features

	1. User Input Validation:
		Ensures the date is correctly formatted and valid.
	2. Age Calculation:
		Computes the user's age correctly by checking if the birthday has already occurred in the current year.
	3. Custom Messages:
		Celebratory message if the user is 100 years old or more.
		Special messages for same-day or future dates.
		"Happy Birthday" message if today is the user's birthday.

# Prerequisites
-> .NET SDK (Version 6.0 or later recommended). You can download and install the .NET SDK from the official .NET website.
-> C# compatible IDE (e.g., Visual Studio, Visual Studio Code) or CLI


# How to Run the Program

Using Visual Studio
	1. Open the project in Visual Studio.
	2. Press Ctrl + F5 to run the program.
	3. Follow the on-screen instructions to enter your birthdate.

Using Command Line
	1. Navigate to the project directory.
	2. Build the project using:
		dotnet build
	3. Run the application:
		dotnet run
	4. Follow the on-screen instructions to enter your birthdate.

# Troubleshooting
	* Invalid Date Format: Ensure the date is entered in YYYY/MM/DD format (e.g., 1990/05/20).
	* .NET SDK Not Recognized: Verify that the .NET SDK is installed and correctly configured in your system's PATH.


# Considerations:

	1. Code Quality
		The code follows best practices for handling user input, validation, and error messages.
		It is structured clearly, separating validation, processing, and output.
		The CalculateAge method is modular and reusable.
	2. Code Clarity
		Variable and method names are self-explanatory (CalculateAge, birthDate, today).
		Inline comments and XML documentation make it easy to understand the logic.
		Early return statements prevent unnecessary nesting, improving readability.
	3. Maintenance and Extensibility
		The program is structured so that additional features (e.g., localization, alternative date formats) can be easily integrated.
		Error handling ensures robustness, making future debugging easier.
		Using DateTime.TryParseExact makes it simple to extend support for different formats.
	4. Naming Conventions
		The code follows C# naming conventions (PascalCase for methods, camelCase for variables).
		The namespace (BirthdateValidator) and class (Program) follow logical naming standards.
	5. How Easily We Can Run the Program
		This is a console application, so it can be run using .NET CLI or directly from an IDE (e.g., Visual Studio, VS Code).
		No external dependencies are required, making execution straightforward.
	6. Errors
		Invalid input format: The program detects incorrect date formats and provides a clear error message.
		Empty input: If no input is provided, the program prompts the user with an appropriate message.
		Future date: The program correctly handles cases where the user enters a date that hasn't occurred yet.
		Same-day birthdate: It handles an edge case where the input matches today's date.
	7. Documentation
		The code includes XML documentation for methods and explanations for key logic blocks.
		This ensures that future developers can quickly understand and modify the code.


# Contribute
Contributions are welcome!

## Author
Alpesh Savani


BirthdayProgram