<p align="center">
  <img src="https://media.giphy.com/media/demgpwJ6rs2DS/giphy.gif" alt="the one and only Swedish Chef likes Pierre's Patisserie">
  </p>

# Pierre's Patisserie

### A Week VIII Epicodus Project, 7 May 2021

_By Jonathan Stull_

## **Description**

Pierre's Patisserie is an app that presents a menu of tasty pastries and queries the user for an order request for the number of bread and/or pastries the user would like. Once queried, the app returns a total cost of the order based on the order request and Pierre's _exceptional_ prices and even more exceptionaler patisserie prowess.

## **Setup/Installation Requirements**

* Software requirements (internet browser, code editor, etc.)
  1. Internet browser
  2. A code editor like VSCode or Atom to view or edit the codebase

* Download/clone instructions
  1. Download this repository onto your computer by clicking the 'code' button
  2. Open the project folder.

* Open via Bash/GitBash:
  1. Clone this repository onto your computer: git clone [https://github.com/jonathanstull/pierres-patisserie.git](https://github.com/jonathanstull/pierres-patisserie.git)
  2. Navigate into the `~/PierresPatisserie.Solution` directory and open in VSCode or preferred text editor code .
  3. This project uses C#/.NET. To compile and run the code, use the command `dotnet run`

## **Known Bugs**

* None

## **Specs**

* The application should return to the console a menu of Pierre's bread and the pastry of the day with the day's prices
* The application should query the user for the number of bread loaves they want; it should then query the user for the number of pastries they want
* Based on the number of loaves and pastries, the application should calculate and return a total cost to the user based on Pierre's current prices
  * Bread loaves are $5 each with a special buy two, get one free offer
  * Pastries are $2 each or $5 for three pastries

## **Technologies Used**

* HTML/CSS
* JavaScript
* jQuery
* Markdown
* VS Code
* Google Chrome/Mozilla Firefox
* C#/.NET
* Test-driven development

## Tests

Each model in this application was comprehensively tested during development according to test-driven development best practices. For an overview of functionality tested, please review the tests in the test file by navigating to `~/PierresPatisserie.Tests/ModelTests/PierresPatisserie.Tests.cs` and opening it in your preferred code editor.

This project utilizes one test file to test both Bread and Pastry classes, which are currently found in the `~/PierresPatisserie/ModelTests/` directory. Test classes are separated by comments indicating the functionality being tested.

## Whiteboarding

This project was planned with a recorded whiteboarding session available for download or listen. Refer to the audio file in the main project directory at `~/whiteboard.m4a`.

Contact me for the video file if you want to see the full spectrum of human emotion.

## **MIT License**

Copyright (c) 2021 Jonathan Stull

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## **Contact Information**

If you are interested in this work, please reach out to Jonathan at <jonathan.d.stull@gmail.com>.