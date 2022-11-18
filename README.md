# Who wants to be a Millionaire

## Configuration
#### Set the appropriate ConnectionString in appsettings.json.
#### Create a migration and update the database.

## Database
#### Question - stores the text of the questions, the four answers, the correct answer, and the difficulty level of the question.
#### Level - stores the amount of the prize and whether it is guaranteed and the difficulty level of the question.

## Architecture
#### ASP.NET Core MVC application
#### The app uses Repository-Service pattern
#### The app uses Entity Framework Core
#### The main functionality of the application is contained in the "Game" controller in the "Index" method. This method is designed to display the question and, depending on whether the correct answer has been given, either displays the next questions or the game is over.
