
Module ModKoneksiKeVB
        '-- MySQL Connection
        Public connDB As New MySql.Data.MySqlClient.MySqlConnection

        Public Sub conecDB()
            Try

                'This is the server IP/Server name.  If server is intalled on your local machine, your IP should be 127.0.0.1 or you may use localhost
                Dim strServer As String = "127.0.0.1"
                Dim strDbase As String = "db_latihannet" 'Database name
                Dim strUser As String = "root" 'Database user
            Dim strPassword As String = "" 'Database Password
                Dim strPort As String = "3306" 'Database Port

                'MySQL Connection String
            If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "server=" & strServer.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPassword.Trim & ";port=" & strPort

                If connDB.State <> ConnectionState.Open Then connDB.Open() Else connDB.Close()
                MsgBox("Connected")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Module