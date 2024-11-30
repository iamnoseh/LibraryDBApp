
using Servise;
using Npgsql;

 string connectionString = @"Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=12345;";
 string mainconnectionString = @"Server=localhost;Port=5432;Database=librarydb;User Id=postgres;Password=12345;";

const string CreateDatabaseCommand = @"Create database LibraryDB;";
const string CreateTableCommand = @"Create table Books(id serial primary key,
                                                        title varchar(100) not null,
                                                         author varchar(100) not null,
                                                         genre varchar(100) not null,
                                                         published_year timestamp
                                                        );";
const string AddBooksCommand = @"Insert into Books (title, author,genre,published_year)
                                                    values ('Maktabi kuhna','Sadriddin Ayni','Roman','12-10-1987'),
                                                    ('Matemetika','Author','Math','10-10-2009'),
                                                    ('Man va pul','Saidmurod davlatov','Bizness','23-8-2014'),
                                                    ('Voina i mir','lew Tolstoy','Roman','7-8-1988');
                                                    ";
const string UpdateCommand = @" Update Books set Title = 'New Mathematik' where author = 'Author';";

const string DeleteCommand = @"Delete from Books where title = 'Maktabi kuhna';";

const string SelectCommand = @"Select * from Books;";

using (NpgsqlConnection connection = new NpgsqlConnection(mainconnectionString))
{
    connection.Open();
    NpgsqlCommand command = connection.CreateCommand();
    // command.CommandText = CreateTableCommand;
    // command.CommandText = AddBooksCommand;
    // command.CommandText = UpdateCommand;
    command.CommandText = DeleteCommand;
    int res = command.ExecuteNonQuery();

    Console.WriteLine(res);

}

