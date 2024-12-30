<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    @{ Code dim myMessage = "Hello World!"; }
    <p>The value of myMessage is : @myMessage</p>

    @{Code
        dim greeting = "Welcome to our site";
        dim weekDay = DateTime.Now.DayOfWeek;
        dim greetingMessage = greeting + "Today is " + weekDay;
    }
    <p>The greeting is: @greetingMessage</p>
</body>
</html>