# SQL Injection Prevention in ADO.NET

SQL Injection refers to the malicious code that can cause permanent loss to the database and even result in the loss of the database. Injection refers to the insertion of SQL queries through input data from the client into the application. Attackers can use SQL injection to add, modify, or delete records in the database. SQL injection can also be thought of as a web-based attack to take over the database.

For example, if a web application takes input from the user and stores it into the database or conversely, we can say that the function of the web application is to retrieve data from the database and display it in the web application. To perform these functions the web application generates a SQL query that executes on the database and finally, the database sends the relevant results to the application. In the case of a SQL injection, we manipulate the SQL queries using the malicious code resulting in the output that was actually not desired by the application and even leading to the loss of the information.

SQL Injection Prevention refers to the techniques and methods using which we can prevent the SQL injection attack. We can avoid the injection of malicious code by using the following methods:-

<b>Parameterized statements</b> - Parameterized statements means using parameters to pass values. It makes sure the inputs are passed to the SQL statements in a safer manner. If we consider the above application, an important point to note is that the SQL injection occurs because of the way we coded the application. Instead of directly passing values from the textboxes to the code, if we would have added parameters the situation would be different.
<br>
<b>Stored Procedures</b> – Using stored procedures in applications comes as a preventive measure against SQL injection. As stored procedures include the involvement of parameters it acts as a savior. The stored procedures could be provided with any number of input parameters and output parameters. Output parameters are used in case the values are to be returned.
