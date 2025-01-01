Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As New MySqlConnection("server=localhost; user=root; password=; database=grading_sys_db;")
    Dim cmd As New MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormThemeLight(Me)
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
        AdminPasswordTxtBox.Clear()
        ProfessorPassword.Clear()
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
End Class