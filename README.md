# RapidPay

Clone or download repo and open project in Visual Studio or VSCode.
- Build Solution
- Setup the database. I decided to use EF with SQLite to make the app self contained and portable, you'll need to run migrations.
    - In Visual Studio, you can use the Package Manager Console to apply migrations to the database:
                <br>
                <code>PM&gt; Update-Database</code>                
    - Alternatively, you can apply migrations from a command prompt at your project directory:
                <br>
                <code>&gt; dotnet ef database update</code>


Run the application and use Swagger or a REST client like Postman to explore and test the API.
Endpoints:
- <code>Card/GetBalance</code> Get the balance for a given card number.
- <code>Card/Create</code> Create a new card with the given cardNumber and balance.
- <code>Card/Pay</code> Make a payment with the given card number and amount.


Credentials, add Basic authorization to request headers:
- UserName: ApiUser
- Password: 123456
