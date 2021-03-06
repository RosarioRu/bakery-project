# _Pierre's Bakery_

#### By _**Rosario Ruvalcaba**_

#### _This program builds a simple console application that displays price and specials for 'Pierre's Bakery.' It utilizes auto-implemented properties and methods to calculate the order total based on user input for number of loaves and croissants desired._

## Technologies Used

* _C#_
* _.NET_
* _MSTest (Microsoft.NET.Test.Sdk)_
* _Markdown_

## Description

_This project was created as an independent project for Epicodus in order to demonstrate understanding of test-driven-development in C#. The program takes user input and creates instances of the classes 'Bread' and 'Pastry.' Methods for calculating the cost of bread and pastry are then called on these instances._

_The console application prints the total cost of the order to the user._

_MSTest was used to unit test the Models. The price for bread/pastries varies due to 'specials' so branching was used to calculate price for each class independently (Bread/Pastry)._

## Setup/Installation Requirements

* _Clone repository from Github and save a copy on own computer._

* _If saving repository remotely, make an initial commit pushing ONLY your .gitignore file so bin/ and obj/ directories are not pushed._

* _Ensure you have C# and .NET installed by running the command [dotnet --version] in your terminal. If the response is not a version number, install .NET from Microsoft website._

* _Navigate to the Bakery directory in the project and run the command [dotnet build]._

* _While still in the Bakery subdirectory, run the command [dotnet run] to run the console application._

## Known Bugs

* _If user gives non-numeric answer, such as a string, for number of pastries and they do so twice, the application will fail. Only the first time the user enters the wrong answer type does the program allow for user to re-enter answer._

## License

MIT License

Copyright (c) _July_2022_ _Rosario Ruvalcaba Harwood_