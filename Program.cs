
using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {
        string conexion = "Data Source=videojuegos.db";

        using (var connection = new SqliteConnection(conexion))
        {
            connection.Open();

            Console.WriteLine("================================");
            Console.WriteLine("   REGISTRO DE VIDEOJUEGOS");
            Console.WriteLine("================================");

            string crearTabla = @"
                CREATE TABLE IF NOT EXISTS Videojuegos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL UNIQUE,
                    Genero TEXT NOT NULL,
                    Plataforma TEXT NOT NULL
                );";

            using (var command = new SqliteCommand(crearTabla, connection))
            {
                command.ExecuteNonQuery();
            }

            Console.WriteLine("\nTabla creada correctamente.");

            string insertar = @"
                INSERT OR IGNORE INTO Videojuegos
                (Nombre, Genero, Plataforma)
                VALUES ($nombre, $genero, $plataforma);";

            using (var command = new SqliteCommand(insertar, connection))
            {
                command.Parameters.AddWithValue("$nombre", "Minecraft");
                command.Parameters.AddWithValue("$genero", "Supervivencia");
                command.Parameters.AddWithValue("$plataforma", "PC");
                command.ExecuteNonQuery();

                command.Parameters["$nombre"].Value = "FIFA 25";
                command.Parameters["$genero"].Value = "Deportes";
                command.Parameters["$plataforma"].Value = "PlayStation";
                command.ExecuteNonQuery();

                command.Parameters["$nombre"].Value = "Mario Kart";
                command.Parameters["$genero"].Value = "Carreras";
                command.Parameters["$plataforma"].Value = "Nintendo Switch";
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Registros insertados correctamente.");

            string consulta = "SELECT * FROM Videojuegos;";

            using (var command = new SqliteCommand(consulta, connection))
            using (var reader = command.ExecuteReader())
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("      VIDEOJUEGOS REGISTRADOS");
                Console.WriteLine("================================");

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader.GetInt32(0)}");
                    Console.WriteLine($"Nombre: {reader.GetString(1)}");
                    Console.WriteLine($"Género: {reader.GetString(2)}");
                    Console.WriteLine($"Plataforma: {reader.GetString(3)}");
                    Console.WriteLine("--------------------------------");
                }
            }
        }

        Console.WriteLine("\nProceso finalizado correctamente.");
        Console.WriteLine("La información quedó guardada en SQLite.");
    }
}
