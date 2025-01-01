Imports System.Data.SqlTypes
Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim SqlString As String = "server=localhost; user=root; password=; database=grading_sys_db;"
    Dim con As New MySqlConnection(SqlString)
    Dim cmd As New MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormThemeLight(Me)
        If My.Settings.ProfRememberMe = True Then
            ProfessorUsername.Text = My.Settings.ProfUsername
            ProfessorPassword.Text = My.Settings.ProfPassword
            RemMeChkBox.Checked = True
        End If
        If My.Settings.AdminRememberMe = True Then
            AdminUsernameTxtBox.Text = My.Settings.AdminUsername
            AdminPasswordTxtBox.Text = My.Settings.AdminPassword
            RemMeAdminBox.Checked = True
        End If
    End Sub

    Private Sub SelectAdmin(sender As Object, e As EventArgs) Handles SelectAdminCard.Click, SelectAdminPictureBox.Click, AdminEnterBtn.Click, AdminSub1.Click, AdminSub2.Click, AdminLbl.Click
        AdminSignInCard.Show()
        AdminUsernameTxtBox.Focus()
        SelectUserCard.Hide()
    End Sub
    Private Sub SelectTeacher(sender As Object, e As EventArgs) Handles SelectTeacherCard.Click, SelectTeacherPictureBox.Click, ProfEnterBtn.Click, TeacherSub1.Click, TeacherSub2.Click, TeacherLbl.Click
        TeacherSignInCard.Show()
        ProfessorUsername.Focus()
        SelectUserCard.Hide()
    End Sub
    Private Sub GoBackToSelectUser(sender As Object, e As EventArgs) Handles ProfessorGoBack.Click, AdminGoBack.Click
        SelectUserCard.Show()
        TeacherSignInCard.Hide()
        AdminSignInCard.Hide()
        If RemMeAdminBox.Checked = False Then
            AdminPasswordTxtBox.Clear()
        End If
        If RemMeChkBox.Checked = False Then
            ProfessorPassword.Clear()
        End If
    End Sub

    Private Sub AdminLoginBtn_Click(sender As Object, e As EventArgs) Handles AdminLoginBtn.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM admins WHERE admin_username = @username AND admin_password = @pass"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", AdminUsernameTxtBox.Text)
            cmd.Parameters.AddWithValue("@pass", AdminPasswordTxtBox.Text)
            Dim userExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If userExists > 0 Then

                If RemMeAdminBox.Checked = True Then
                    My.Settings.AdminRememberMe = True
                    My.Settings.AdminUsername = AdminUsernameTxtBox.Text
                    My.Settings.AdminPassword = AdminPasswordTxtBox.Text
                    My.Settings.Save()
                Else
                    My.Settings.AdminRememberMe = False
                    My.Settings.AdminUsername = ""
                    My.Settings.AdminPassword = ""
                    My.Settings.Save()
                End If

                Dim AdminForm As New AdminDashboard(AdminUsernameTxtBox.Text)
                AdminForm.Show()
                Hide()
                AdminPasswordTxtBox.Clear()
            Else
                MessageBox.Show("Invalid Account Input Credentials")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TeacherLogin_Click(sender As Object, e As EventArgs) Handles TeacherLogin.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM professors WHERE prof_username = @username AND prof_password = @pass"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", ProfessorUsername.Text)
            cmd.Parameters.AddWithValue("@pass", ProfessorPassword.Text)
            Dim userExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If userExists > 0 Then

                If RemMeChkBox.Checked = True Then
                    My.Settings.ProfRememberMe = True
                    My.Settings.ProfUsername = ProfessorUsername.Text
                    My.Settings.ProfPassword = ProfessorPassword.Text
                    My.Settings.Save()
                Else
                    My.Settings.ProfRememberMe = False
                    My.Settings.ProfUsername = ""
                    My.Settings.ProfPassword = ""
                    My.Settings.Save()
                End If

                Dim TeacherForm As New TeacherDashboard(ProfessorUsername.Text)
                TeacherForm.Show()
                Hide()
                ProfessorPassword.Clear()
            Else
                MessageBox.Show("Invalid Account Input Credentials")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub LoginEvent(sender As Object, e As KeyEventArgs) Handles ProfessorUsername.KeyDown, ProfessorPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            AdminLoginBtn.PerformClick()
        End If
    End Sub

    Private Sub AdminPasswordTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AdminPasswordTxtBox.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            AdminLoginBtn.PerformClick()
        End If
    End Sub

    Private Sub AdminUsernameTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AdminUsernameTxtBox.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            AdminLoginBtn.PerformClick()
        End If
    End Sub

    Private Sub ProfessorUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProfessorUsername.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TeacherLogin.PerformClick()
        End If
    End Sub

    Private Sub ProfessorPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProfessorPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TeacherLogin.PerformClick()
        End If
    End Sub

    Private Sub CreateAccountProfBtn_Click(sender As Object, e As EventArgs) Handles CreateAccountProfBtn.Click
        RegisterProfessorCard.Show()
        TeacherSignInCard.Hide()
        ProfessorPassword.Clear()
    End Sub

    Private Sub GoBackToProfSignIn_Click(sender As Object, e As EventArgs) Handles GoBackToProfSignIn.Click
        GoBackToProfSignInSub()
    End Sub

    Private Sub ProfClearBtn_Click(sender As Object, e As EventArgs) Handles ProfClearBtn.Click
        ProfFirstName.Clear()
        ProfLastName.Clear()
        ProfMiddleName.Clear()
        ProfEmail.Clear()
        ProfUsername.Clear()
        ProfPassword.Clear()
        ProfConfirmPass.Clear()
    End Sub

    Private Sub ProfRegisterBtn_Click(sender As Object, e As EventArgs) Handles ProfRegisterBtn.Click
        Try
            If ProfEmail.Text.EndsWith("@plpasig.edu.ph") AndAlso ProfPassword.Text = ProfConfirmPass.Text AndAlso ProfPassword.TextLength >= 8 AndAlso ProfFirstName.Text <> "" AndAlso ProfLastName.Text <> "" AndAlso ProfUsername.Text <> "" Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()

                    Using cmd As New MySqlCommand("INSERT INTO professors (prof_first_name, prof_last_name, prof_middle_name, prof_email, prof_username, prof_password) VALUES (@FirstName, @LastName, @MiddleName, @Email, @Username, @Password)", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@FirstName", ProfFirstName.Text)
                        cmd.Parameters.AddWithValue("@LastName", ProfLastName.Text)
                        cmd.Parameters.AddWithValue("@MiddleName", ProfMiddleName.Text)
                        cmd.Parameters.AddWithValue("@Email", ProfEmail.Text)
                        cmd.Parameters.AddWithValue("@Username", ProfUsername.Text)
                        cmd.Parameters.AddWithValue("@Password", ProfPassword.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Registration Successful!")
                ProfClearBtn.PerformClick()
                GoBackToProfSignInSub()
            ElseIf ProfFirstName.Text = "" Then
                MessageBox.Show("Please provide your first name")
            ElseIf ProfLastName.Text = "" Then
                MessageBox.Show("Please provide your last name")
            ElseIf ProfUsername.Text = "" Then
                MessageBox.Show("Please provide a username")
            ElseIf ProfEmail.Text = "" Then
                MessageBox.Show("Please provide your PLP email")
            ElseIf Not ProfEmail.Text.EndsWith("@plpasig.edu.ph") Then
                MessageBox.Show("Only PLP email allowed")
            ElseIf ProfPassword.Text <> ProfConfirmPass.Text Then
                MessageBox.Show("Password does not match")
            ElseIf ProfPassword.TextLength < 8 Then
                MessageBox.Show("Password must be atleast 8 characters long")
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Username is already taken")
            End If
        End Try
    End Sub

    Private Sub GoBackToProfSignInSub()
        TeacherSignInCard.Show()
        RegisterProfessorCard.Hide()
        ProfessorPassword.Clear()
    End Sub
End Class