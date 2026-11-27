using Npgsql;

Console.Write("Passwort für herm: ");
string passwort = Console.ReadLine() ?? "";

string verbindung = $"Host=localhost;Port=5432;Database=herm;Username=herm;Password={passwort}";

using var conn = new NpgsqlConnection(verbindung);
conn.Open();

using var cmd = new NpgsqlCommand("SELECT id, vorname, nachname FROM unterricht.personen ORDER BY id", conn);
using var reader = cmd.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine($"{reader.GetInt32(0)}  {reader.GetString(1)}  {reader.GetString(2)}");
}