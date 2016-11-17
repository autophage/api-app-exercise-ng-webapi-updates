# API-based application assessment with Angular 1.x and ASP.NET Web API 

This is an exercise to use a JavaScript (Angular 1.x in this case) front-end to use an API to get and update data. Following the steps below, you should clone the repo, do the exercise and push the code to a new repo as your final product.

1. Clone this repository.
1. Get the skeleton Angular application working.
    1. Be sure NPM and Bower are installed
        * Type `npm` at the command-line. If you don't have it, get it here: [NPM](https://www.npmjs.org/)
        * Type `bower` at the command-line. If you don't have it get it here: [Bower](http://bower.io/)
    1. Run `npm install`
    1. Run `npm start` to start the UI 
    1. Navigate to http://localhost:8000/

1. In the root of the source code directory, in a folder called `API`, scaffold an ASP.NET Web API project (i.e. with File > New > Project > ASP.NET Web API in Visual Studio).
1. Create an endpoint that returns the following hard-coded data:

    ```
    2 Person objects with these fields and anything for the values:
        FirstName
        LastName
        JobTitle
    ```
1. Create an endpoint that allows updating a Person object, then display a console message with the updated values (no query or database necessary).
1. Start the Web API application and verify you can hit it. 
1. In the Angular application, on the homepage, use an endpoint to display both people with all the fields in table format. Use Twitter Bootstrap to make it look presentable.
1. Allow selection of one of the people in the table, and show a form for editing of each of the fields. Allow submission of the edits to the 2nd endpoint. 
1. Verify the updates made it to the endpoint properly with the console message.  
1. Submit your final code to a new repo. Share it and walk through how it works from end-to-end.
