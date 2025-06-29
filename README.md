# Register_Student-Console_WPF
Using both the console and .NET's WPF visual interface, I was able to create a class register program.

•	Briefly summarize the requirements and goals of the application you developed. What user needs was this application designed to address?
  o	The goal of this application was to use an interface to select several courses and register each course separately. This was achieved through a WPF application and a console application.
  o	When developing the console application, the main goal was iteration and proof of concept. The reasoning behind iteration and proof of concept was that it is only the developing side of the application to make sure that the code works before applying it to a user interface.
  o	When developing the WPF application, the main goal was visual and functionality. The reason for this was the proof of concept was already developed and created. Using WPF was only to make the user have an easier time navigating the application.
•	What did you do particularly well in developing this application?
  o	I made sure to cover edge cases in the programs failing and when they failed, due to user error, I made sure to catch it and make the program continue moving.
•	Compare and contrast the Console and WPF application designs. What screens and features were necessary to support user needs and produce a user-centered UI for the app? How did your UI designs keep users in mind? Why were your designs successful?
  o	I kept users in mind by using dropdowns for pre-selected classes that the user could not enter incorrectly. For the console program, I made sure that when the user entered in the wrong format, I made sure to tell them why they entered the wrong input.
•	How did you approach the process of debugging and coding your application? What techniques or strategies did you use? How could you use those techniques or strategies in the future?
  o	I debugged the program by entering in what I thought could fail the program, took the error code and produced an exception to it such as too many classes, not the right data type, and so on. Using this strategy, I can confidently catch most issues, however, edge cases will need to be dealt with by having others test the code and make sure that they are not able to break anything while using it.
•	Where did you have to be innovative to overcome a challenge in the full application development process?
  o	I had to make sure each error message would fail and output in the same spot, so I made sure when the error message was outputted, the error was put in the same spot just above the class selection box. This text would appear when the user would enter something wrong and would properly tell the user why it was incorrect.
