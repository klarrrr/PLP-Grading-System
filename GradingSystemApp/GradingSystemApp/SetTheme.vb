Imports System.Data.SqlTypes
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient
Module SetTheme
    Public Sub SetFormThemeDark(Form As MaterialForm)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Form)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Green200, Primary.Green300, Primary.Green100, Accent.Yellow700, TextShade.BLACK)
    End Sub

    Public Sub SetFormThemeLight(Form As MaterialForm)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Form)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Amber700, TextShade.WHITE)
    End Sub

    Public Sub EvaluateIfDark(Form As MaterialForm, Switch As MaterialSwitch)
        If Switch.CheckState = CheckState.Checked Then
            SetFormThemeDark(Form)
        Else
            SetFormThemeLight(Form)
        End If
        Form.Refresh()
    End Sub

    Public Sub DarkModeBtnFlipped(Form As MaterialForm, ByRef DarkModeSwitch As MaterialSwitch, SqlString As String, LoggedInUserName As String, table As String, unique_key As String)
        EvaluateIfDark(Form, DarkModeSwitch)
        Dim str As String = "UPDATE " & table & " SET dark_mode = @darkMode WHERE " & unique_key & " = @username"
        Dim darkModeValue As Integer = If(DarkModeSwitch.CheckState = CheckState.Checked, 1, 0)

        Using con As New MySqlConnection(SqlString)
            con.Open()
            Using cmd As New MySqlCommand(str, con)
                cmd.Parameters.AddWithValue("@darkMode", darkModeValue)
                cmd.Parameters.AddWithValue("@username", LoggedInUserName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DarkModeDB(table As String, unique_key As String, actual_unique_key As String, ByRef DarkModeSwitch As MaterialSwitch, SqlString As String)
        Using con As New MySqlConnection(SqlString)
            con.Open()
            Dim str As String = "SELECT dark_mode FROM " & table & " WHERE " & unique_key & " = @actual_unique_key"
            Dim cmd As New MySqlCommand(str, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@actual_unique_key", actual_unique_key)
            Dim darkModeValue = Convert.ToInt32(cmd.ExecuteScalar())
            If darkModeValue = 1 Then
                DarkModeSwitch.Checked = True
            Else
                DarkModeSwitch.Checked = False
            End If
        End Using
    End Sub
End Module
