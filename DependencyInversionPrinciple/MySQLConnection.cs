using DependencyInversionPrinciple;


//  Dependency Inversion Principle states:
//  Entities must depend on abstractions, not concretions. It states that the high-level module 
//  must not depend on the low-level module, but they should depend on abstractions.

//  The principle allows for decoupling. 

//  In this example the MySQLConnection is the low-level module while the PasswordReminder is the high level,
//  but according to the definition of D in SOLID, which states to depend on abstraction, not on concretions.
//  This snippet violates this principle as the PasswordReminder is being forced to depend on the MySQLConnection class.

//  Later, if you were to change the database engine, you would also have to edit the PasswordReminder class,
//  and this would violate the open-close principle.

//  The PasswordReminder class should not care what database the application uses. To address these issues,
//  you can code to an interface since high-level and low-level modules should depend on abstraction

public class MySQLConnection : IDbConnection
{
    //public string Connect()
    //{
    //    // handle the database connection
    //    return "Database connection";
    //}

    public string Connect()
    {
        return "Database connection";
    }
}

public class PasswordReminder
{
    private MySQLConnection _dbConnection;

    public PasswordReminder(MySQLConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
}
