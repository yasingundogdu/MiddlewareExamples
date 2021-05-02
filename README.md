# MiddlewareExamples
Token Refresher for ASP.NET Core Middleware Examples


There is no token when the first request. Takes a token from the service and writes to the session.
![1](https://user-images.githubusercontent.com/6221685/116809710-0f712380-ab48-11eb-8b0f-199bdda8ffa1.PNG)


In other requests don't take a token from the service because the session is full.
![2](https://user-images.githubusercontent.com/6221685/116809831-e56c3100-ab48-11eb-9323-6eab06303163.PNG)


