1. Open file appsettings.Development.json

2. Change following lines
    "From": "your_email",
    "Password": "your_password",
    "Host": "your_host",
    "Username": "your_username"

3. Do following command in Package Manager Console 
    Update-Database
Please check before you do the command you have MSSQL

4. Run the application


--------------------------------------------------------------------------------------------------

After running the application you will see Swagger web page with this URL
https://localhost:7153/swagger/index.html
