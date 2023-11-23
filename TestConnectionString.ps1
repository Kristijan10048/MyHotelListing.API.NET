$conn = New-Object System.Data.SqlClient.SqlConnection;
$conn.ConnectionString = "Server=192.168.1.25;User ID=dev1;Password=dev1;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;Integrated Security=false";
$conn.Open();
$conn.Close();