Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient
Public Class AdminDashboard
    Private LoggedInUsername As String
    Public Sub New(username As String)
        InitializeComponent()
        LoggedInUsername = username
    End Sub

    Private Sub AdminDashboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetProfName()
        DarkModeDB("admins", "admin_username", LoggedInUsername, DarkModeSwitch, SqlString)
        LoadStudent()
        LoadProfessor()
        LoadIniProfessors()
        IniClearBtn.PerformClick()
        IniLoadChooseProf()
        IniLoadChooseCourse()
        LoadAddCourse()
        BulkLoadCourses()
        LoadToBeEnrolledBulk()
        LoadBulkEnrolledStudents()
        LoadIndSelectStudent()
        LoadIndEnrolledStudents()
        LoadIndSelectCourse()
        LoadSelfSettings()
        CheckIfAttendanceInSubCategories()
    End Sub

    Dim SqlString As String = "server=localhost; user=root; password=; database=grading_sys_db;"

    Dim dtStudent As New DataTable
    Dim dtCoursesCategoriesSubCategories As New DataTable
    Dim dtSubCategories As New DataTable
    Dim dtProfessor As New DataTable
    Dim dtEnrollSections As New DataTable
    Dim dtIniProf As New DataTable
    Dim dtIniChooseProf As New DataTable
    Dim dtIniChooseCourse As New DataTable
    Dim dtBulkCourses As New DataTable
    Dim dtAddCourse As New DataTable
    Dim dtIndSelectStudent As New DataTable
    Dim dtIndEnrolledStudents As New DataTable
    Dim dtIndSelectCourse As New DataTable
    Dim dtSelfSettings As New DataTable
    Dim dtBulkEnrolledStudents As New DataTable

    Private Sub RegStudentRegBtn_Click(sender As Object, e As EventArgs) Handles RegStudentRegBtn.Click
        Try
            If RegStudentId.Text <> "" AndAlso RegStudentFirstName.Text <> "" AndAlso RegStudentLastName.Text <> "" AndAlso RegStudentEmailAddress.Text <> "" AndAlso RegStudentEmailAddress.Text.EndsWith("@plpasig.edu.ph") AndAlso RegStudentSection.SelectedItem <> Nothing Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()

                    Using cmd As New MySqlCommand("INSERT INTO students VALUES (@StudentId, @FirstName, @LastName, @MiddleName, @Section, @Email)", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@StudentId", RegStudentId.Text)
                        cmd.Parameters.AddWithValue("@FirstName", RegStudentFirstName.Text)
                        cmd.Parameters.AddWithValue("@LastName", RegStudentLastName.Text)
                        cmd.Parameters.AddWithValue("@MiddleName", RegStudentMiddleName.Text)
                        cmd.Parameters.AddWithValue("@Section", RegStudentSection.SelectedItem)
                        cmd.Parameters.AddWithValue("@Email", RegStudentEmailAddress.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                StuClearBtn.PerformClick()
                RegStudentSection.Refresh()
                LoadStudent()
            ElseIf RegStudentId.Text = "" AndAlso RegStudentFirstName.Text = "" AndAlso RegStudentLastName.Text = "" AndAlso RegStudentEmailAddress.Text = "" AndAlso RegStudentSection.SelectedItem = Nothing Then
                MessageBox.Show("Error: All of the fields are empty empty fields")
            ElseIf RegStudentSection.SelectedItem = Nothing Then
                MessageBox.Show("Error: Student ID box is empty")
            ElseIf RegStudentFirstName.Text = "" Then
                MessageBox.Show("Error: Student First Name box is empty")
            ElseIf RegStudentLastName.Text = "" Then
                MessageBox.Show("Error: Student Last Name box is empty")
            ElseIf RegStudentEmailAddress.Text = "" Then
                MessageBox.Show("Error: Student Email Address box is empty")
            ElseIf Not RegStudentEmailAddress.Text.EndsWith("@plpasig.edu.ph") Then
                MessageBox.Show("Error: Student Email must be a PLP email")
            Else
                MessageBox.Show("Error: Double check your details")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadStudent()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtStudent.Clear()
            Using cmd As New MySqlCommand("select * from students", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtStudent.Load(reader)
                End Using
            End Using
            StudentDataGridView.Items.Clear()
            For Each row As DataRow In dtStudent.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString())
                For i As Integer = 1 To dtStudent.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString())
                Next
                StudentDataGridView.Items.Add(listViewItem)
            Next
        End Using
    End Sub
    Private Sub LoadProfessor()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtProfessor.Clear()
            Using cmd As New MySqlCommand("SELECT professor_id, prof_first_name, prof_last_name, prof_middle_name, prof_email, prof_username, prof_password FROM professors ORDER BY prof_first_name", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtProfessor.Load(reader)
                End Using
            End Using
        End Using

        ProfessorDataGrid.Items.Clear()

        For Each row As DataRow In dtProfessor.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtProfessor.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            ProfessorDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub LoadIniProfessors()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtIniProf.Clear()

            Dim IniSearch As String = If(IniSearchForProfOrCourseBox.Text, "")
            IniSearch = "%" & IniSearch & "%"
            Dim BaseQuery As String = "SELECT t.professor_id, p.prof_first_name, p.prof_last_name, c.course_id, c.course_name, t.section, t.start_date, t.teaches_id FROM teaches t JOIN professors p ON t.professor_id = p.professor_id JOIN courses c ON t.course_id = c.course_id WHERE 1=1"

            If Not String.IsNullOrEmpty(IniSearch) Then
                BaseQuery &= " AND CONCAT(t.professor_id, p.prof_first_name, p.prof_last_name) like @search"
            End If
            Using cmd As New MySqlCommand(BaseQuery, con)
                cmd.Parameters.Clear()
                If Not String.IsNullOrEmpty(IniSearch) Then
                    cmd.Parameters.AddWithValue("@search", IniSearch)
                End If
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtIniProf.Load(reader)
                End Using
            End Using
        End Using

        IniDataGrid.Items.Clear()

        For Each row As DataRow In dtIniProf.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtIniProf.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            IniDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub IniLoadChooseProf()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtIniChooseProf.Clear()
            Using cmd As New MySqlCommand("select p.professor_id, p.prof_first_name, p.prof_last_name from professors p order by p.prof_first_name", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtIniChooseProf.Load(reader)
                End Using
            End Using
        End Using

        IniSelectProfessorDataGrid.Items.Clear()

        For Each row As DataRow In dtIniChooseProf.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtIniChooseProf.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            IniSelectProfessorDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub IniLoadChooseCourse()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtIniChooseCourse.Clear()
            Using cmd As New MySqlCommand("select * from courses", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtIniChooseCourse.Load(reader)
                End Using
            End Using
        End Using

        IniChooseCourseDataGrid.Items.Clear()

        For Each row As DataRow In dtIniChooseCourse.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtIniChooseCourse.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            IniChooseCourseDataGrid.Items.Add(listViewItem)
        Next
    End Sub
    Private Sub BulkLoadCourses()
        Using con As New MySqlConnection(SqlString) '
            con.Open()
            dtBulkCourses.Clear() '
            Using cmd As New MySqlCommand("select * from courses", con) '
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtBulkCourses.Load(reader)
                End Using
            End Using
        End Using

        BulkCoursesDataGrid.Items.Clear()

        For Each row As DataRow In dtBulkCourses.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtBulkCourses.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            BulkCoursesDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub LoadAddCourse()
        Using con As New MySqlConnection(SqlString) '
            con.Open()
            dtAddCourse.Clear() '
            Using cmd As New MySqlCommand("select * from courses", con) '
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtAddCourse.Load(reader)
                End Using
            End Using
        End Using

        AddCourseDataGrid.Items.Clear()

        For Each row As DataRow In dtAddCourse.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtAddCourse.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            AddCourseDataGrid.Items.Add(listViewItem)
        Next
    End Sub
    Private Sub LoadIndSelectStudent()
        Using con As New MySqlConnection(SqlString) '
            con.Open()
            dtIndSelectStudent.Clear() '
            Using cmd As New MySqlCommand("select * from students", con) '
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtIndSelectStudent.Load(reader)
                End Using
            End Using
        End Using

        IndSelectStudentDataGrid.Items.Clear()

        For Each row As DataRow In dtIndSelectStudent.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtIndSelectStudent.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            IndSelectStudentDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub LoadIndEnrolledStudents()
        Using con As New MySqlConnection(SqlString) '
            con.Open()
            dtIndEnrolledStudents.Clear() '
            Using cmd As New MySqlCommand("SELECT e.enrollment_id, e.student_id, s.first_name, s.last_name, c.course_name, e.enrollment_date FROM enrollments e JOIN students s ON e.student_id = s.student_id JOIN courses c ON e.course_id = c.course_id", con) '
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtIndEnrolledStudents.Load(reader)
                End Using
            End Using
        End Using

        IndEnrolledStudentsDataGrid.Items.Clear()

        For Each row As DataRow In dtIndEnrolledStudents.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtIndEnrolledStudents.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            IndEnrolledStudentsDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub LoadToBeEnrolledBulk()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtEnrollSections.Clear()
            Dim SelectedFilterSection As String = If(SelectSectionToEnroll.SelectedItem IsNot Nothing, SelectSectionToEnroll.SelectedItem.ToString(), "")
            Dim SearchBulkBox As String = If(SearchBulk.Text, "")
            SearchBulkBox = "%" & SearchBulkBox & "%"
            Dim BaseQuery As String = "SELECT student_id, first_name, last_name, middle_name, section, student_email from students WHERE 1=1"

            If Not String.IsNullOrEmpty(SelectedFilterSection) Then
                BaseQuery &= " AND section = '" & SelectedFilterSection & "'"
            End If

            If Not String.IsNullOrEmpty(SearchBulkBox) Then
                BaseQuery &= " AND CONCAT(student_id, first_name, last_name, middle_name) like @search"
            End If

            Using cmd As New MySqlCommand(BaseQuery, con) '
                cmd.Parameters.Clear()
                If Not String.IsNullOrEmpty(SearchBulkBox) Then
                    cmd.Parameters.AddWithValue("@search", SearchBulkBox)
                End If
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtEnrollSections.Load(reader)
                End Using
            End Using
        End Using

        EnrolleSectionGrid.Items.Clear()

        For Each row As DataRow In dtEnrollSections.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtEnrollSections.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            EnrolleSectionGrid.Items.Add(listViewItem)
        Next
    End Sub
    Private Sub LoadBulkEnrolledStudents()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtBulkEnrolledStudents.Clear()
            Dim SelectedFilterSection As String = If(BulkSectionToUnenroll.SelectedItem IsNot Nothing, BulkSectionToUnenroll.SelectedItem.ToString(), "")
            Dim BaseQuery As String = "
SELECT 
    e.enrollment_id, 
    e.student_id, 
    s.first_name, 
    s.last_name, 
    c.course_name, 
    e.enrollment_date 
FROM 
    enrollments e 
JOIN 
    students s 
ON 
    e.student_id = s.student_id 
JOIN 
    courses c 
ON 
    e.course_id = c.course_id 
WHERE 
    1=1"
            If Not String.IsNullOrEmpty(SelectedFilterSection) Then
                BaseQuery &= " AND s.section = @section"
            End If

            Using cmd As New MySqlCommand(BaseQuery, con)
                cmd.Parameters.Clear()

                If Not String.IsNullOrEmpty(SelectedFilterSection) Then
                    cmd.Parameters.AddWithValue("@section", SelectedFilterSection)
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtBulkEnrolledStudents.Load(reader)
                End Using
            End Using
        End Using

        BulkEnrolledStudentDataGrid.Items.Clear()

        For Each row As DataRow In dtBulkEnrolledStudents.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtBulkEnrolledStudents.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            BulkEnrolledStudentDataGrid.Items.Add(listViewItem)
        Next
    End Sub
    Private Sub LoadIndSelectCourse()
        Using con As New MySqlConnection(SqlString) '
            con.Open()
            dtIndSelectCourse.Clear() '
            Using cmd As New MySqlCommand("select * from courses", con) '
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtIndSelectCourse.Load(reader)
                End Using
            End Using
        End Using

        IndSelectCourseDatGrid.Items.Clear()

        For Each row As DataRow In dtIndSelectCourse.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtIndSelectCourse.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            IndSelectCourseDatGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub LoadSelfSettings()
        Using con As New MySqlConnection(SqlString)
            con.Open()
            dtSelfSettings.Clear()
            Using cmd As New MySqlCommand("SELECT admin_username, admin_password FROM admins", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Assign the values directly to the text boxes
                        AdminSelfUsernameBox.Text = reader("admin_username").ToString()
                        AdminSelfPassword.Text = reader("admin_password").ToString()
                    Else
                        MessageBox.Show("No admin data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End Using
    End Sub


    Private Sub SearchStudentTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SearchStudentTxtBox.TextChanged
        If SearchStudentTxtBox.Text = "" Then
            LoadStudent()
        Else
            Dim searchText = "%" & SearchStudentTxtBox.Text & "%"
            Using con As New MySqlConnection(SqlString)
                con.Open()
                dtStudent.Clear()
                Using cmd As New MySqlCommand("select * from students WHERE CONCAT(first_name, last_name, middle_name, student_id) like @search", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@search", searchText)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dtStudent.Load(reader)
                    End Using
                End Using
            End Using

            StudentDataGridView.Items.Clear()

            For Each row As DataRow In dtStudent.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString())
                For i As Integer = 1 To dtStudent.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString())
                Next
                StudentDataGridView.Items.Add(listViewItem)
            Next
        End If
    End Sub

    Private Sub ProfSearchBox_TextChanged(sender As Object, e As EventArgs) Handles ProfSearchBox.TextChanged
        If ProfSearchBox.Text = "" Then
            LoadProfessor()
        Else
            Dim searchText = "%" & ProfSearchBox.Text & "%"
            Using con As New MySqlConnection(SqlString)
                con.Open()
                dtProfessor.Clear()
                Using cmd As New MySqlCommand("SELECT professor_id, prof_first_name, prof_last_name, prof_middle_name, prof_email, prof_username, prof_password FROM professors WHERE CONCAT(prof_first_name, prof_last_name, prof_middle_name) like @search", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@search", searchText)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dtProfessor.Load(reader)
                    End Using
                End Using
            End Using

            ProfessorDataGrid.Items.Clear()

            For Each row As DataRow In dtProfessor.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString())
                For i As Integer = 1 To dtProfessor.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString())
                Next
                ProfessorDataGrid.Items.Add(listViewItem)
            Next
        End If
    End Sub

    Private Sub ProfRegisterBtn_Click(sender As Object, e As EventArgs) Handles ProfRegisterBtn.Click
        Try
            If ProfEmail.Text.EndsWith("@plpasig.edu.ph") AndAlso ProfPassword.Text = ProfConfirmPass.Text AndAlso ProfPassword.TextLength >= 8 Then
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
                ProfClearBtn.PerformClick()
                LoadProfessor()
            ElseIf ProfPassword.Text <> ProfConfirmPass.Text Then
                MessageBox.Show("Password does not match")
            ElseIf ProfPassword.TextLength < 8 Then
                MessageBox.Show("Password must be atleast 8 characters long")
            ElseIf Not ProfEmail.Text.EndsWith("@plpasig.edu.ph") Then
                MessageBox.Show("Only PLP email allowed")
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Username is already taken")

            End If
        End Try
    End Sub

    Private Sub ProfessorDataGrid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProfessorDataGrid.SelectedIndexChanged
        Try
            If ProfessorDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem = ProfessorDataGrid.SelectedItems(0)

                ProfFirstName.Text = selectedItem.SubItems(1).Text
                ProfLastName.Text = selectedItem.SubItems(2).Text
                ProfMiddleName.Text = selectedItem.SubItems(3).Text
                ProfEmail.Text = selectedItem.SubItems(4).Text
                ProfUsername.Text = selectedItem.SubItems(5).Text
                ProfPassword.Text = selectedItem.SubItems(6).Text
                ProfConfirmPass.Text = selectedItem.SubItems(6).Text
            Else
                ProfFirstName.Text = ""
                ProfLastName.Text = ""
                ProfMiddleName.Text = ""
                ProfEmail.Text = ""
                ProfUsername.Text = ""
                ProfPassword.Text = ""
                ProfConfirmPass.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub StudentDataGridView_ItemSelectionChanged(sender As Object, e As EventArgs) Handles StudentDataGridView.ItemSelectionChanged
        Try
            If StudentDataGridView.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = StudentDataGridView.SelectedItems(0)

                RegStudentId.Text = selectedItem.SubItems(0).Text
                RegStudentFirstName.Text = selectedItem.SubItems(1).Text
                RegStudentLastName.Text = selectedItem.SubItems(2).Text
                RegStudentMiddleName.Text = selectedItem.SubItems(3).Text
                RegStudentSection.SelectedItem = selectedItem.SubItems(4).Text
                RegStudentSection.Text = selectedItem.SubItems(4).Text
                RegStudentEmailAddress.Text = selectedItem.SubItems(5).Text

                RegStudentSection.Refresh()
            Else
                RegStudentId.Clear()
                RegStudentFirstName.Clear()
                RegStudentLastName.Clear()
                RegStudentMiddleName.Clear()
                RegStudentSection.SelectedItem = Nothing
                RegStudentEmailAddress.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub SetProfName()
        AdminProfAdminLbl.Text = LoggedInUsername
        AdminProfAdminLbl.Left = AdminProfAdminLbl.Parent.Width - AdminProfAdminLbl.Width - 30

        StuAdminLbl.Text = LoggedInUsername
        StuAdminLbl.Left = StuAdminLbl.Parent.Width - StuAdminLbl.Width - 30

        CourProfLbl.Text = LoggedInUsername
        CourProfLbl.Left = CourProfLbl.Parent.Width - CourProfLbl.Width - 30

        BulkProfLbl.Text = LoggedInUsername
        BulkProfLbl.Left = BulkProfLbl.Parent.Width - BulkProfLbl.Width - 30

        IndProfLbl.Text = LoggedInUsername
        IndProfLbl.Left = IndProfLbl.Parent.Width - IndProfLbl.Width - 30

        IniProfLbl.Text = LoggedInUsername
        IniProfLbl.Left = IniProfLbl.Parent.Width - IniProfLbl.Width - 30

        SettingAdminLbl.Text = LoggedInUsername
        SettingAdminLbl.Left = SettingAdminLbl.Parent.Width - SettingAdminLbl.Width - 30
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabelProf.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        DateLabelProf.Text = Date.Now.ToString("MMMM dd, yyyy")
        TimeLabelProf.Left = TimeLabelProf.Parent.Width - TimeLabelProf.Width - 30
        DateLabelProf.Left = DateLabelProf.Parent.Width - DateLabelProf.Width - 30

        StuTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        StuDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        StuTimeLbl.Left = StuTimeLbl.Parent.Width - StuTimeLbl.Width - 30
        StuDateLbl.Left = StuDateLbl.Parent.Width - StuDateLbl.Width - 30

        CourTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        CourDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        CourTimeLbl.Left = CourTimeLbl.Parent.Width - CourTimeLbl.Width - 30
        CourDateLbl.Left = CourDateLbl.Parent.Width - CourDateLbl.Width - 30

        BulkTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        BulkDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        BulkTimeLbl.Left = BulkTimeLbl.Parent.Width - BulkTimeLbl.Width - 30
        BulkDateLbl.Left = BulkDateLbl.Parent.Width - BulkDateLbl.Width - 30

        IndTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        IndDatelbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        IndTimeLbl.Left = IndTimeLbl.Parent.Width - IndTimeLbl.Width - 30
        IndDatelbl.Left = IndDatelbl.Parent.Width - IndDatelbl.Width - 30

        IniTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        IniDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        IniTimeLbl.Left = IniTimeLbl.Parent.Width - IniTimeLbl.Width - 30
        IniDateLbl.Left = IniDateLbl.Parent.Width - IniDateLbl.Width - 30

        SettingsTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        SettingsDateLabel.Text = Date.Now.ToString("MMMM dd, yyyy")
        SettingsTimeLbl.Left = SettingsTimeLbl.Parent.Width - SettingsTimeLbl.Width - 30
        SettingsDateLabel.Left = SettingsDateLabel.Parent.Width - SettingsDateLabel.Width - 30
    End Sub

    Private Sub SignOutCancel_Click(sender As Object, e As EventArgs) Handles SignOutCancel.Click
        MaterialTabControl1.SelectedTab = Professor
    End Sub
    Private Sub SignOutYes_Click(sender As Object, e As EventArgs) Handles SignOutYes.Click
        Form1.Show()
        Hide()
        MaterialTabControl1.SelectedTab = Professor
        SetFormThemeLight(Me)
    End Sub

    Private Sub DarkModeSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles DarkModeSwitch.CheckedChanged
        DarkModeBtnFlipped(Me, DarkModeSwitch, SqlString, LoggedInUsername, "admins", "admin_username")
    End Sub

    Private Sub IniSelectProfessorDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles IniSelectProfessorDataGrid.ItemSelectionChanged
        Try
            If IniSelectProfessorDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = IniSelectProfessorDataGrid.SelectedItems(0)
                IniProfFirstNameBox.Text = selectedItem.SubItems(1).Text
                IniProfLastNameBox.Text = selectedItem.SubItems(2).Text
                IniProfID.Text = selectedItem.SubItems(0).Text
            Else
                IniProfFirstNameBox.Clear()
                IniProfID.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub IniChooseCourseDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles IniChooseCourseDataGrid.ItemSelectionChanged
        Try
            If IniChooseCourseDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = IniChooseCourseDataGrid.SelectedItems(0)
                IniCourse.Text = selectedItem.SubItems(1).Text
                IniCourseIdBox.Text = selectedItem.SubItems(0).Text
            Else
                IniCourse.Clear()
                IniCourseIdBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub IniAssignBtn_Click(sender As Object, e As EventArgs) Handles IniAssignBtn.Click
        Try
            If IniCourse.Text <> "" AndAlso IniCourseIdBox.Text <> "" AndAlso IniProfFirstNameBox.Text <> "" AndAlso IniProfLastNameBox.Text <> "" AndAlso IniProfID.Text <> "" AndAlso IniSectionBox.SelectedItem IsNot Nothing Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()

                    ' Check if the professor is already assigned to the course
                    Dim isAssigned As Boolean = False
                    Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM teaches WHERE professor_id = @professor_id AND course_id = @course_id", con)
                        checkCmd.Parameters.AddWithValue("@professor_id", IniProfID.Text)
                        checkCmd.Parameters.AddWithValue("@course_id", IniCourseIdBox.Text)
                        isAssigned = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
                    End Using

                    If isAssigned Then
                        MessageBox.Show("Error: The professor is already assigned to this course.", "Assignment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    ' If not already assigned, insert the record
                    Using cmd As New MySqlCommand("INSERT INTO teaches (professor_id, course_id, section, start_date) VALUES (@professor_id, @course_id, @section, @start_date)", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@professor_id", IniProfID.Text)
                        cmd.Parameters.AddWithValue("@course_id", IniCourseIdBox.Text)
                        cmd.Parameters.AddWithValue("@section", IniSectionBox.Text)
                        cmd.Parameters.AddWithValue("@start_date", Date.Today.Date)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Clear input fields and reload the data
                IniClearBtn.PerformClick()
                LoadIniProfessors()
            ElseIf IniCourse.Text = "" AndAlso IniCourseIdBox.Text = "" AndAlso IniProfFirstNameBox.Text = "" AndAlso IniProfLastNameBox.Text = "" AndAlso IniProfID.Text = "" Then
                MessageBox.Show("Error: There are empty fields")
            ElseIf IniCourse.Text = "" Or IniCourseIdBox.Text = "" Then
                MessageBox.Show("Error: Choose a course first")
            ElseIf IniProfFirstNameBox.Text = "" Or IniProfID.Text = "" Then
                MessageBox.Show("Error: Choose a professor first")
            ElseIf IniSectionBox.SelectedItem Is Nothing Then
                MessageBox.Show("Error: Choose a section first")
            Else
                MessageBox.Show("Error: Double check your info")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub IniUpdateBtn_Click(sender As Object, e As EventArgs) Handles IniUpdateBtn.Click
        Try
            If IniCourse.Text <> "" AndAlso IniCourseIdBox.Text <> "" AndAlso IniProfFirstNameBox.Text <> "" AndAlso IniProfLastNameBox.Text <> "" AndAlso IniProfID.Text <> "" AndAlso IniSectionBox.SelectedItem <> Nothing Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("UPDATE teaches SET professor_id = @professor_id, course_id = @course_id, section = @section, start_date = @start_date WHERE teaches_id = @teaches_id ", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@professor_id", IniProfID.Text)
                        cmd.Parameters.AddWithValue("@course_id", IniCourseIdBox.Text)
                        cmd.Parameters.AddWithValue("@section", IniSectionBox.Text)
                        cmd.Parameters.AddWithValue("@start_date", Date.Today.Date)
                        cmd.Parameters.AddWithValue("@teaches_id", IniDataGrid.SelectedItems(0).SubItems(7).Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadIniProfessors()
                IniClearBtn.PerformClick()
            ElseIf IniCourse.Text = "" AndAlso IniCourseIdBox.Text = "" AndAlso IniProfFirstNameBox.Text = "" AndAlso IniProfLastNameBox.Text = "" AndAlso IniProfID.Text = "" Then
                MessageBox.Show("Error: There are empty fields")
            ElseIf IniCourse.Text = "" Or IniCourseIdBox.Text = "" Then
                MessageBox.Show("Error: Choose a course first")
            ElseIf IniProfFirstNameBox.Text = "" Or IniProfID.Text = "" Or IniProfLastNameBox.Text = "" Then
                MessageBox.Show("Error: Choose a professor first")
            ElseIf IniSectionBox.SelectedItem = Nothing Then
                MessageBox.Show("Error: Choose a section first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub IniDeleteBtn_Click(sender As Object, e As EventArgs) Handles IniDeleteBtn.Click
        Try
            If IniCourse.Text <> "" AndAlso IniCourseIdBox.Text <> "" AndAlso IniProfFirstNameBox.Text <> "" AndAlso IniProfLastNameBox.Text <> "" AndAlso IniProfID.Text <> "" AndAlso IniSectionBox.SelectedItem <> Nothing Then
                Dim result As DialogResult = MessageBox.Show("Are you sure on deleting teaches id number: " & IniDataGrid.SelectedItems(0).SubItems(7).Text, "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If
                Using con As New MySqlConnection(SqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("DELETE FROM teaches WHERE teaches_id = @teaches_id ", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@teaches_id", IniDataGrid.SelectedItems(0).SubItems(7).Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadIniProfessors()
                IniClearBtn.PerformClick()
            ElseIf IniCourse.Text = "" AndAlso IniCourseIdBox.Text = "" AndAlso IniProfFirstNameBox.Text = "" AndAlso IniProfLastNameBox.Text = "" AndAlso IniProfID.Text = "" Then
                MessageBox.Show("Error: There are empty fields")
            ElseIf IniCourse.Text = "" Or IniCourseIdBox.Text = "" Then
                MessageBox.Show("Error: Choose a course first")
            ElseIf IniProfFirstNameBox.Text = "" Or IniProfID.Text = "" Or IniProfLastNameBox.Text = "" Then
                MessageBox.Show("Error: Choose a professor first")
            ElseIf IniSectionBox.SelectedItem = Nothing Then
                MessageBox.Show("Error: Choose a section first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub IniClearBtn_Click(sender As Object, e As EventArgs) Handles IniClearBtn.Click
        IniProfFirstNameBox.Clear()
        IniProfLastNameBox.Clear()
        IniProfID.Clear()
        IniSectionBox.SelectedItem = Nothing
        IniSectionBox.SelectedIndex = -1
        IniSectionBox.Refresh()
        IniCourseIdBox.Clear()
        IniCourse.Clear()
    End Sub
    Private Sub DisableKeyPress(sender As Object, e As KeyPressEventArgs) Handles IniProfFirstNameBox.KeyPress, IniProfID.KeyPress, IniCourse.KeyPress, IniCourseIdBox.KeyPress, BulkCourseBox.KeyPress, IndSelectedCourseNameBox.KeyPress, IndSelectedEnrollIdBox.KeyPress, IndSelectedEnrollIdBox.KeyPress, BulkCourseIdBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub AddCourseDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles AddCourseDataGrid.ItemSelectionChanged
        Try
            If AddCourseDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = AddCourseDataGrid.SelectedItems(0)
                AddCourseNameBox.Text = selectedItem.SubItems(1).Text
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub AddAddCourseBtn_Click(sender As Object, e As EventArgs) Handles AddAddCourseBtn.Click
        Try
            If AddCourseNameBox.Text <> "" Then
                ' Step 1: Insert the course data into the "courses" table
                Using con As New MySqlConnection(SqlString)
                    con.Open()

                    ' Insert the course into the courses table
                    Dim courseQuery As String = "INSERT INTO courses (course_name) VALUES (@course_name)"
                    Using cmd As New MySqlCommand(courseQuery, con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@course_name", AddCourseNameBox.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Step 2: Get the last inserted course_id
                    Dim lastCourseIdQuery As String = "SELECT LAST_INSERT_ID()"
                    Using cmd As New MySqlCommand(lastCourseIdQuery, con)
                        Dim courseId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        ' Step 3: Insert the default categories and sub-categories
                        Dim categories As New List(Of (String, Decimal)) From {
                        ("Quiz", 25),
                        ("Lab", 25),
                        ("Exam", 40),
                        ("Attendance", 10)
                    }

                        For Each category In categories
                            ' Insert category into the "categories" table
                            Dim categoryQuery As String = "INSERT INTO categories (course_id, category_name, percent) VALUES (@course_id, @category_name, @percent)"
                            Using cmdCategory As New MySqlCommand(categoryQuery, con)
                                cmdCategory.Parameters.Clear()
                                cmdCategory.Parameters.AddWithValue("@course_id", courseId)
                                cmdCategory.Parameters.AddWithValue("@category_name", category.Item1)
                                cmdCategory.Parameters.AddWithValue("@percent", category.Item2)
                                cmdCategory.ExecuteNonQuery()
                            End Using

                            ' Step 4: Get the last inserted category_id
                            Dim lastCategoryIdQuery As String = "SELECT LAST_INSERT_ID()"
                            Dim categoryId As Integer
                            Using cmdCategoryId As New MySqlCommand(lastCategoryIdQuery, con)
                                categoryId = Convert.ToInt32(cmdCategoryId.ExecuteScalar())
                            End Using

                            ' Step 5: Insert sub-category (e.g., "quiz 1", "lab 1", etc.)
                            Dim subCategoryQuery As String = "INSERT INTO sub_categories (course_id, category_id, sub_category_name, total_score) 
                                                          VALUES (@course_id, @category_id, @sub_category_name, @total_score)"
                            Using cmdSubCategory As New MySqlCommand(subCategoryQuery, con)
                                cmdSubCategory.Parameters.Clear()
                                cmdSubCategory.Parameters.AddWithValue("@course_id", courseId)
                                cmdSubCategory.Parameters.AddWithValue("@category_id", categoryId)
                                cmdSubCategory.Parameters.AddWithValue("@sub_category_name", category.Item1.ToLower() & " 1") ' For example, "quiz 1"
                                cmdSubCategory.Parameters.AddWithValue("@total_score", 0) ' Default total score is 0
                                cmdSubCategory.ExecuteNonQuery()
                            End Using
                        Next
                    End Using
                End Using

                ' Step 6: Refresh the UI (clear fields and reload data)
                AddClearBtn.PerformClick()
                LoadAddCourse()
                BulkLoadCourses()
                IniLoadChooseCourse()

                MessageBox.Show("Course added successfully along with default categories and sub-categories.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf AddCourseNameBox.Text = "" Then
                MessageBox.Show("Error: Fill in the boxes to add")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub AddUpdateCourseBtn_Click(sender As Object, e As EventArgs) Handles AddUpdateCourseBtn.Click
        Try
            If AddCourseNameBox.Text <> "" AndAlso AddCourseDataGrid.SelectedItems.Count > 0 Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()

                    Using cmd As New MySqlCommand("UPDATE courses SET course_name = @course_name, term = @term WHERE course_id = @course_id", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@course_name", AddCourseNameBox.Text)
                        cmd.Parameters.AddWithValue("@course_id", AddCourseDataGrid.SelectedItems(0).SubItems(0))
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                AddClearBtn.PerformClick()
                LoadAddCourse()
                BulkLoadCourses()
                IniLoadChooseCourse()
            ElseIf AddCourseNameBox.Text = "" Then
                MessageBox.Show("Error: choose a course from table first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddDeleteCourseBtn_Click(sender As Object, e As EventArgs) Handles AddDeleteCourseBtn.Click
        Try
            If AddCourseNameBox.Text <> "" AndAlso AddCourseDataGrid.SelectedItems.Count > 0 Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()

                    Using cmd As New MySqlCommand("DELETE FROM courses WHERE course_id = @course_id", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@course_name", AddCourseNameBox.Text)
                        cmd.Parameters.AddWithValue("@course_id", AddCourseDataGrid.SelectedItems(0).SubItems(0))
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                AddClearBtn.PerformClick()
                LoadAddCourse()
                BulkLoadCourses()
                IniLoadChooseCourse()
            ElseIf AddCourseNameBox.Text = "" Then
                MessageBox.Show("Error: choose a course from table first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AddClearBtn_Click(sender As Object, e As EventArgs) Handles AddClearBtn.Click
        AddCourseNameBox.Clear()
    End Sub

    Private Sub AddSearchCourseBox_TextChanged(sender As Object, e As EventArgs) Handles AddSearchCourseBox.TextChanged
        If AddSearchCourseBox.Text = "" Then
            LoadAddCourse()
        Else
            Dim searchText = "%" & AddSearchCourseBox.Text & "%"
            Using con As New MySqlConnection(SqlString)
                con.Open()
                dtAddCourse.Clear()

                Using cmd As New MySqlCommand("select * from courses WHERE CONCAT(course_id, course_name) like @search", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@search", searchText)
                    Using reader = cmd.ExecuteReader
                        dtAddCourse.Load(reader)
                    End Using
                End Using
            End Using

            AddCourseDataGrid.Items.Clear()

            For Each row As DataRow In dtAddCourse.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString)
                For i = 1 To dtAddCourse.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString)
                Next
                AddCourseDataGrid.Items.Add(listViewItem)
            Next
        End If
    End Sub

    Private Sub SelectSectionToEnroll_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles SelectSectionToEnroll.SelectedIndexChanged
        LoadToBeEnrolledBulk()
    End Sub

    Private Sub BulkCoursesDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles BulkCoursesDataGrid.ItemSelectionChanged
        Try
            If BulkCoursesDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = BulkCoursesDataGrid.SelectedItems(0)
                BulkCourseIdBox.Text = selectedItem.SubItems(0).Text
                BulkCourseBox.Text = selectedItem.SubItems(1).Text
            Else
                BulkCourseIdBox.Clear()
                BulkCourseBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub IniDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles IniDataGrid.ItemSelectionChanged
        Try
            If IniDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = IniDataGrid.SelectedItems(0)
                IniProfID.Text = selectedItem.SubItems(0).Text
                IniProfFirstNameBox.Text = selectedItem.SubItems(1).Text
                IniProfLastNameBox.Text = selectedItem.SubItems(2).Text
                IniCourse.Text = selectedItem.SubItems(4).Text
                IniCourseIdBox.Text = selectedItem.SubItems(3).Text
                IniSectionBox.SelectedItem = selectedItem.SubItems(5).Text
                IniSectionBox.Text = selectedItem.SubItems(5).Text
                IniSectionBox.Refresh()
            Else
                IniClearBtn.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
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

    Private Sub StuClearBtn_Click(sender As Object, e As EventArgs) Handles StuClearBtn.Click
        RegStudentId.Clear()
        RegStudentFirstName.Clear()
        RegStudentLastName.Clear()
        RegStudentMiddleName.Clear()
        RegStudentSection.SelectedItem = Nothing
        RegStudentSection.Text = ""
        RegStudentEmailAddress.Clear()
    End Sub

    Private Sub StuDeleteBtn_Click(sender As Object, e As EventArgs) Handles StuDeleteBtn.Click
        Try
            If RegStudentId.Text <> "" AndAlso RegStudentFirstName.Text <> "" AndAlso RegStudentLastName.Text <> "" AndAlso RegStudentEmailAddress.Text <> "" AndAlso RegStudentSection.SelectedItem <> Nothing Then
                Dim result As DialogResult = MessageBox.Show("Are you sure on deleting student: " & StudentDataGridView.SelectedItems(0).SubItems(1).Text & " " & StudentDataGridView.SelectedItems(0).SubItems(2).Text, "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If
                Using con As New MySqlConnection(SqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("DELETE FROM students WHERE student_id = @student_id ", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@student_id", StudentDataGridView.SelectedItems(0).SubItems(0).Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadStudent()
                StuClearBtn.PerformClick()
                RegStudentSection.Refresh()
            ElseIf RegStudentId.Text = "" AndAlso RegStudentFirstName.Text = "" AndAlso RegStudentLastName.Text = "" AndAlso RegStudentEmailAddress.Text = "" AndAlso RegStudentSection.SelectedItem = Nothing Then
                MessageBox.Show("Error: All of the fields are empty empty fields")
            ElseIf RegStudentSection.SelectedItem = Nothing Then
                MessageBox.Show("Error: Student ID box is empty")
            ElseIf RegStudentFirstName.Text = "" Then
                MessageBox.Show("Error: Student First Name box is empty")
            ElseIf RegStudentLastName.Text = "" Then
                MessageBox.Show("Error: Student Last Name box is empty")
            ElseIf RegStudentEmailAddress.Text = "" Then
                MessageBox.Show("Error: Student Email Address box is empty")
            Else
                MessageBox.Show("Error: Double check your details")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StuUpdateBtn_Click(sender As Object, e As EventArgs) Handles StuUpdateBtn.Click
        Try
            If RegStudentId.Text <> "" AndAlso RegStudentFirstName.Text <> "" AndAlso RegStudentLastName.Text <> "" AndAlso RegStudentEmailAddress.Text <> "" AndAlso RegStudentSection.SelectedItem <> Nothing Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("UPDATE students SET student_id = @student_id, first_name = @first_name, last_name = @last_name, middle_name = @middle_name, section = @section, student_email = @student_email WHERE student_id = @student_id ", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@student_id", RegStudentId.Text)
                        cmd.Parameters.AddWithValue("@first_name", RegStudentFirstName.Text)
                        cmd.Parameters.AddWithValue("@last_name", RegStudentLastName.Text)
                        cmd.Parameters.AddWithValue("@middle_name", RegStudentMiddleName.Text)
                        cmd.Parameters.AddWithValue("@section", RegStudentSection.SelectedItem)
                        cmd.Parameters.AddWithValue("@student_email", RegStudentEmailAddress.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadStudent()
                StuClearBtn.PerformClick()
                RegStudentSection.Refresh()
            ElseIf RegStudentId.Text = "" AndAlso RegStudentFirstName.Text = "" AndAlso RegStudentLastName.Text = "" AndAlso RegStudentEmailAddress.Text = "" AndAlso RegStudentSection.SelectedItem = Nothing Then
                MessageBox.Show("Error: All of the fields are empty empty fields")
            ElseIf RegStudentSection.SelectedItem = Nothing Then
                MessageBox.Show("Error: Student ID box is empty")
            ElseIf RegStudentFirstName.Text = "" Then
                MessageBox.Show("Error: Student First Name box is empty")
            ElseIf RegStudentLastName.Text = "" Then
                MessageBox.Show("Error: Student Last Name box is empty")
            ElseIf RegStudentEmailAddress.Text = "" Then
                MessageBox.Show("Error: Student Email Address box is empty")
            Else
                MessageBox.Show("Error: Double check your details")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub IndSelectStudentDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles IndSelectStudentDataGrid.ItemSelectionChanged
        Try
            If IndSelectStudentDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = IndSelectStudentDataGrid.SelectedItems(0)
                IndStudentIdBox.Text = selectedItem.SubItems(0).Text
            Else
                IndStudentIdBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub IndClearBtn_Click(sender As Object, e As EventArgs) Handles IndClearBtn.Click
        IndStudentIdBox.Clear()
        IndSelectedCourseIdBox.Clear()
        IndSelectedCourseNameBox.Clear()
    End Sub

    Private Sub IndSelectCourseDatGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles IndSelectCourseDatGrid.ItemSelectionChanged
        Try
            If IndSelectCourseDatGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = IndSelectCourseDatGrid.SelectedItems(0)
                IndSelectedCourseIdBox.Text = selectedItem.SubItems(0).Text
                IndSelectedCourseNameBox.Text = selectedItem.SubItems(1).Text
            Else
                IndSelectedCourseIdBox.Clear()
                IndSelectedCourseNameBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub IndEnrollButton_Click(sender As Object, e As EventArgs) Handles IndEnrollButton.Click
        Try
            If IndStudentIdBox.Text <> "" AndAlso IndSelectedCourseIdBox.Text <> "" AndAlso IndSelectedCourseNameBox.Text <> "" Then
                Using con As New MySqlConnection(SqlString)
                    con.Open()

                    ' Check if the student is already enrolled in the course
                    Dim isEnrolled As Boolean = False
                    Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM enrollments WHERE student_id = @student_id AND course_id = @course_id", con)
                        checkCmd.Parameters.AddWithValue("@student_id", IndStudentIdBox.Text)
                        checkCmd.Parameters.AddWithValue("@course_id", IndSelectedCourseIdBox.Text)
                        isEnrolled = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
                    End Using

                    If isEnrolled Then
                        MessageBox.Show("Error: The student is already enrolled in the selected course.")
                        Return
                    End If

                    ' Enroll the student
                    Using enrollCmd As New MySqlCommand("INSERT INTO enrollments (student_id, course_id, enrollment_date) VALUES (@student_id, @course_id, @enrollment_date)", con)
                        enrollCmd.Parameters.Clear()
                        enrollCmd.Parameters.AddWithValue("@student_id", IndStudentIdBox.Text)
                        enrollCmd.Parameters.AddWithValue("@course_id", IndSelectedCourseIdBox.Text)
                        enrollCmd.Parameters.AddWithValue("@enrollment_date", Date.Today.Date)
                        enrollCmd.ExecuteNonQuery()
                    End Using

                    ' Fetch sub-categories related to the selected course
                    Using subCatCmd As New MySqlCommand("SELECT sub_category_id FROM sub_categories WHERE course_id = @course_id", con)
                        subCatCmd.Parameters.AddWithValue("@course_id", IndSelectedCourseIdBox.Text)

                        Using reader As MySqlDataReader = subCatCmd.ExecuteReader()
                            Dim subCategoryIds As New List(Of Integer)

                            While reader.Read()
                                subCategoryIds.Add(Convert.ToInt32(reader("sub_category_id")))
                            End While
                            reader.Close()

                            ' Insert scores for each sub-category related to the selected course
                            For Each subCategoryId As Integer In subCategoryIds
                                ' Check if the score template already exists for this student and sub-category
                                Using checkScoreCmd As New MySqlCommand("SELECT COUNT(*) FROM scores WHERE student_id = @student_id AND sub_category_id = @sub_category_id", con)
                                    checkScoreCmd.Parameters.AddWithValue("@student_id", IndStudentIdBox.Text)
                                    checkScoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)

                                    Dim exists As Boolean = Convert.ToInt32(checkScoreCmd.ExecuteScalar()) > 0

                                    ' Insert only if the template does not exist
                                    If Not exists Then
                                        Using insertScoreCmd As New MySqlCommand("INSERT INTO scores (student_id, sub_category_id, score) VALUES (@student_id, @sub_category_id, @score)", con)
                                            insertScoreCmd.Parameters.AddWithValue("@student_id", IndStudentIdBox.Text)
                                            insertScoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                            insertScoreCmd.Parameters.AddWithValue("@score", 0) ' Default score
                                            insertScoreCmd.ExecuteNonQuery()
                                        End Using
                                    End If
                                End Using
                            Next
                        End Using
                    End Using
                End Using

                ' Clear the form and reload the enrolled students
                IndClearBtn.PerformClick()
                LoadIndEnrolledStudents()
                MessageBox.Show("Student enrolled and score templates added successfully.")
            ElseIf IndStudentIdBox.Text = "" AndAlso IndSelectedCourseIdBox.Text = "" AndAlso IndSelectedCourseNameBox.Text = "" Then
                MessageBox.Show("Error: Nothing is selected")
            ElseIf IndStudentIdBox.Text = "" Then
                MessageBox.Show("Error: Select student first")
            ElseIf IndSelectedCourseIdBox.Text = "" Or IndSelectedCourseNameBox.Text = "" Then
                MessageBox.Show("Error: Select course first")
            Else
                MessageBox.Show("Error: Double check your details")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub IndUnenrollBtn_Click(sender As Object, e As EventArgs) Handles IndUnenrollBtn.Click
        Try
            If IndSelectedEnrollIdBox.Text <> "" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure on deleting student enrollment: " & IndEnrolledStudentsDataGrid.SelectedItems(0).SubItems(2).Text & " " & IndEnrolledStudentsDataGrid.SelectedItems(0).SubItems(3).Text & " to " & IndEnrolledStudentsDataGrid.SelectedItems(0).SubItems(4).Text, "Unenroll Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If
                Using con As New MySqlConnection(SqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("DELETE FROM enrollments WHERE enrollment_id = @enrollment_id ", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@enrollment_id", IndEnrolledStudentsDataGrid.SelectedItems(0).SubItems(0).Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadIndEnrolledStudents()
                IndSelectedEnrollIdBox.Clear()
            ElseIf IndSelectedEnrollIdBox.Text = "" Then
                MessageBox.Show("Error: Select an enrolled student before unenrolling")
            Else
                MessageBox.Show("Error: Double check your details")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub IndEnrolledStudentsDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles IndEnrolledStudentsDataGrid.ItemSelectionChanged
        Try
            If IndEnrolledStudentsDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = IndEnrolledStudentsDataGrid.SelectedItems(0)
                IndSelectedEnrollIdBox.Text = selectedItem.SubItems(0).Text
            Else
                IndSelectedEnrollIdBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub IndSearchStudentBox_TextChanged(sender As Object, e As EventArgs) Handles IndSearchStudentBox.TextChanged
        If IndSearchStudentBox.Text = "" Then
            LoadIndSelectStudent()
        Else
            Dim searchText = "%" & IndSearchStudentBox.Text & "%"
            Using con As New MySqlConnection(SqlString)
                con.Open()
                dtIndSelectStudent.Clear()

                Using cmd As New MySqlCommand("select * from students WHERE CONCAT(student_id, first_name, last_name, middle_name) like @search", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@search", searchText)
                    Using reader = cmd.ExecuteReader
                        dtIndSelectStudent.Load(reader)
                    End Using
                End Using
            End Using

            IndSelectStudentDataGrid.Items.Clear()

            For Each row As DataRow In dtIndSelectStudent.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString)
                For i = 1 To dtIndSelectStudent.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString)
                Next
                IndSelectStudentDataGrid.Items.Add(listViewItem)
            Next
        End If
    End Sub

    Private Sub IndSortStudentByBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IndSortStudentByBox.SelectedIndexChanged
        If IndSortStudentByBox.SelectedItem = "Student ID" Then
            ListViewItemComparer.SortListViewColumn(IndSelectStudentDataGrid, 0, SortOrder.Ascending)
        ElseIf IndSortStudentByBox.SelectedItem = "First Name" Then
            ListViewItemComparer.SortListViewColumn(IndSelectStudentDataGrid, 1, SortOrder.Ascending)
        ElseIf IndSortStudentByBox.SelectedItem = "Last Name" Then
            ListViewItemComparer.SortListViewColumn(IndSelectStudentDataGrid, 2, SortOrder.Ascending)
        ElseIf IndSortStudentByBox.SelectedItem = "Middle Name" Then
            ListViewItemComparer.SortListViewColumn(IndSelectStudentDataGrid, 3, SortOrder.Ascending)
        ElseIf IndSortStudentByBox.SelectedItem = "Section" Then
            ListViewItemComparer.SortListViewColumn(IndSelectStudentDataGrid, 4, SortOrder.Ascending)
        ElseIf IndSortStudentByBox.SelectedItem = "Email" Then
            ListViewItemComparer.SortListViewColumn(IndSelectStudentDataGrid, 5, SortOrder.Ascending)
        End If
    End Sub
    Private Sub IndSortEnrolledByBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IndSortEnrolledByBox.SelectedIndexChanged
        If IndSortEnrolledByBox.SelectedItem = "Enrollment ID" Then
            ListViewItemComparer.SortListViewColumn(IndEnrolledStudentsDataGrid, 0, SortOrder.Ascending)
        ElseIf IndSortEnrolledByBox.SelectedItem = "First Name" Then
            ListViewItemComparer.SortListViewColumn(IndEnrolledStudentsDataGrid, 1, SortOrder.Ascending)
        ElseIf IndSortEnrolledByBox.SelectedItem = "Last Name" Then
            ListViewItemComparer.SortListViewColumn(IndEnrolledStudentsDataGrid, 2, SortOrder.Ascending)
        ElseIf IndSortEnrolledByBox.SelectedItem = "Course" Then
            ListViewItemComparer.SortListViewColumn(IndEnrolledStudentsDataGrid, 3, SortOrder.Ascending)
        ElseIf IndSortEnrolledByBox.SelectedItem = "Date Enrolled" Then
            ListViewItemComparer.SortListViewColumn(IndEnrolledStudentsDataGrid, 4, SortOrder.Ascending)
        End If
    End Sub

    Private Sub BulkEnrollBtn_Click(sender As Object, e As EventArgs) Handles BulkEnrollBtn.Click
        If BulkCourseIdBox.Text = "" Or BulkCourseBox.Text = "" Then
            MessageBox.Show("Error: Select a course to enroll first")
            Return
        End If

        If EnrolleSectionGrid.Items.Count <> 0 Then
            Dim studentList As New Text.StringBuilder()
            Dim notEnrolledList As New Text.StringBuilder() ' To track students who couldn't be enrolled
            Dim successfullyEnrolledCount As Integer = 0 ' Counter for successful enrollments

            ' Prepare list of students for confirmation message
            For Each item As ListViewItem In EnrolleSectionGrid.Items
                Dim firstName As String = item.SubItems(1).Text
                Dim lastName As String = item.SubItems(2).Text
                studentList.AppendLine($"{firstName} {lastName}")
            Next

            Dim confirmationMessage As String = $"Are you sure you want to enroll students in section {SelectSectionToEnroll.Text}:{Environment.NewLine}{Environment.NewLine}{studentList}"

            Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Enrollment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If

            Using con As New MySqlConnection(SqlString)
                con.Open()

                For Each item As ListViewItem In EnrolleSectionGrid.Items
                    Dim studentId As String = item.SubItems(0).Text
                    Dim courseId As String = BulkCourseIdBox.Text

                    Dim isEnrolled As Boolean = False
                    Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM enrollments WHERE student_id = @student_id AND course_id = @course_id", con)
                        checkCmd.Parameters.AddWithValue("@student_id", studentId)
                        checkCmd.Parameters.AddWithValue("@course_id", courseId)
                        isEnrolled = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
                    End Using

                    If Not isEnrolled Then

                        Using insertCmd As New MySqlCommand("INSERT INTO enrollments (student_id, course_id, enrollment_date) VALUES (@student_id, @course_id, @enrollment_date)", con)
                            insertCmd.Parameters.AddWithValue("@student_id", studentId)
                            insertCmd.Parameters.AddWithValue("@course_id", courseId)
                            insertCmd.Parameters.AddWithValue("@enrollment_date", Date.Today.Date)
                            insertCmd.ExecuteNonQuery()
                            successfullyEnrolledCount += 1
                        End Using

                        Using subCategoryCmd As New MySqlCommand("SELECT sub_category_id FROM sub_categories WHERE course_id = @course_id", con)
                            subCategoryCmd.Parameters.AddWithValue("@course_id", courseId)
                            Using reader As MySqlDataReader = subCategoryCmd.ExecuteReader()
                                Dim subCategoryIds As New List(Of Integer)
                                While reader.Read()
                                    subCategoryIds.Add(Convert.ToInt32(reader("sub_category_id")))
                                End While

                                reader.Close()
                                For Each subCategoryId As Integer In subCategoryIds
                                    Using scoreCmd As New MySqlCommand("INSERT INTO scores (student_id, sub_category_id, score, term, semester) VALUES (@student_id, @sub_category_id, @score, @term, @semester)", con)
                                        scoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                        scoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                        scoreCmd.Parameters.AddWithValue("@score", 0)
                                        scoreCmd.Parameters.AddWithValue("@term", "midterm")
                                        scoreCmd.Parameters.AddWithValue("@semester", "1st")
                                        scoreCmd.ExecuteNonQuery()
                                    End Using
                                    Using scoreCmd As New MySqlCommand("INSERT INTO scores (student_id, sub_category_id, score, term, semester) VALUES (@student_id, @sub_category_id, @score, @term, @semester)", con)
                                        scoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                        scoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                        scoreCmd.Parameters.AddWithValue("@score", 0)
                                        scoreCmd.Parameters.AddWithValue("@term", "finals")
                                        scoreCmd.Parameters.AddWithValue("@semester", "1st")
                                        scoreCmd.ExecuteNonQuery()
                                    End Using
                                    Using scoreCmd As New MySqlCommand("INSERT INTO scores (student_id, sub_category_id, score, term, semester) VALUES (@student_id, @sub_category_id, @score, @term, @semester)", con)
                                        scoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                        scoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                        scoreCmd.Parameters.AddWithValue("@score", 0)
                                        scoreCmd.Parameters.AddWithValue("@term", "midterm")
                                        scoreCmd.Parameters.AddWithValue("@semester", "2nd")
                                        scoreCmd.ExecuteNonQuery()
                                    End Using
                                    Using scoreCmd As New MySqlCommand("INSERT INTO scores (student_id, sub_category_id, score, term, semester) VALUES (@student_id, @sub_category_id, @score, @term, @semester)", con)
                                        scoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                        scoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                        scoreCmd.Parameters.AddWithValue("@score", 0)
                                        scoreCmd.Parameters.AddWithValue("@term", "finals")
                                        scoreCmd.Parameters.AddWithValue("@semester", "2nd")
                                        scoreCmd.ExecuteNonQuery()
                                    End Using
                                Next
                            End Using
                        End Using
                    Else
                        Dim firstName As String = item.SubItems(1).Text
                        Dim lastName As String = item.SubItems(2).Text
                        notEnrolledList.AppendLine($"{firstName} {lastName}")
                    End If
                Next
            End Using

            Dim message As String = $"{successfullyEnrolledCount} students were successfully enrolled in {SelectSectionToEnroll.SelectedItem}."
            If notEnrolledList.Length > 0 Then
                message &= $"{Environment.NewLine}{Environment.NewLine}The following students were not enrolled because they are already enrolled in the course:{Environment.NewLine}{notEnrolledList}"
            End If
            MessageBox.Show(message)

            LoadIndEnrolledStudents()
            LoadToBeEnrolledBulk()
            LoadBulkEnrolledStudents()
            ClearBulkCoursesBtn.PerformClick()

        ElseIf EnrolleSectionGrid.Items.Count = 0 Then
            MessageBox.Show("Error: No students found in the section to enroll.")
        ElseIf BulkCourseIdBox.Text = "" OrElse BulkCourseBox.Text = "" Then
            MessageBox.Show("Error: Select a course first.")
        Else
            MessageBox.Show("Error: Double check your details.")
        End If
    End Sub

    Private Sub IniSearchForProfOrCourseBox_TextChanged(sender As Object, e As EventArgs) Handles IniSearchForProfOrCourseBox.TextChanged
        LoadIniProfessors()
    End Sub

    Private Sub SelfUpdateButton_Click(sender As Object, e As EventArgs) Handles SelfUpdateButton.Click
        If AdminSelfUsernameBox.Text <> "" AndAlso AdminSelfPassword.Text <> "" AndAlso AdminSelfPassword.TextLength >= 8 Then
            Dim reEnteredPassword As String = InputBox("Please re-enter your password to confirm changes:", "Password Confirmation")
            If String.IsNullOrEmpty(reEnteredPassword) Then
                MessageBox.Show("Account modification cancelled.", "Confirmation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim originalPassword As String = AdminSelfPassword.Text
            If reEnteredPassword = originalPassword Then
                MessageBox.Show("Password confirmed. Proceeding with the update.", "Confirmation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Password does not match. Changes aborted.", "Confirmation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim result As DialogResult = MessageBox.Show("Are you sure with your current changes?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
            Using con As New MySqlConnection(SqlString)
                con.Open()
                Using cmd As New MySqlCommand("UPDATE admins SET admin_username = @new_username, admin_password = @new_password WHERE admin_username = '" & LoggedInUsername & "'", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@new_username", AdminSelfUsernameBox.Text)
                    cmd.Parameters.AddWithValue("@new_password", AdminSelfPassword.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoggedInUsername = AdminSelfUsernameBox.Text
            Form1.AdminUsernameTxtBox.Text = LoggedInUsername
            MessageBox.Show("Your information was successfully updated.")
        ElseIf AdminSelfUsernameBox.Text = "" AndAlso AdminSelfPassword.Text = "" Then
            MessageBox.Show("Error: cannot update if everything is empty")
        ElseIf AdminSelfUsernameBox.Text = "" Then
            MessageBox.Show("Error: cannot update if your username is empty")
        ElseIf AdminSelfPassword.Text = "" Then
            MessageBox.Show("Error: cannot update if your password is empty")
        ElseIf AdminSelfPassword.TextLength <8 Then
            MessageBox.Show("Error: cannot update if password is less than 8 characters")
        Else
            MessageBox.Show("Error: double check your credentials.")
        End If
    End Sub

    Private Sub BulkUnenrollBtn_Click(sender As Object, e As EventArgs) Handles BulkUnenrollBtn.Click
        Dim section As String = BulkSectionToUnenroll.SelectedItem.ToString()

        If MessageBox.Show($"Are you sure you want to unenroll all students in section {section}?",
                           "Confirm Unenrollment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Using connection As New MySqlConnection(SqlString)
                Try
                    connection.Open()
                    Dim query As String = "DELETE e FROM enrollments e 
                                           JOIN students s ON e.student_id = s.student_id 
                                           WHERE s.section = @section"

                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@section", section)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        MessageBox.Show($"{rowsAffected} student(s) have been unenrolled from section {section}.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                    LoadBulkEnrolledStudents()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub BulkSectionToUnenroll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BulkSectionToUnenroll.SelectedIndexChanged
        LoadBulkEnrolledStudents()
    End Sub

    Private Sub RegStudentId_TextChanged(sender As Object, e As EventArgs) Handles RegStudentId.TextChanged
        If RegStudentId.TextLength > 7 Then
            RegStudentId.Text = RegStudentId.Text.Substring(0, 7)
            RegStudentId.SelectionStart = RegStudentId.TextLength
        End If
    End Sub
    Private Sub RegStudentId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RegStudentId.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SearchBulk_TextChanged(sender As Object, e As EventArgs) Handles SearchBulk.TextChanged
        LoadToBeEnrolledBulk()
    End Sub

    Private Sub ClearBulkCoursesBtn_Click(sender As Object, e As EventArgs) Handles ClearBulkCoursesBtn.Click
        BulkCourseBox.Clear()
        BulkCourseIdBox.Clear()
        If BulkCoursesDataGrid.SelectedItems.Count > 0 Then
            BulkCoursesDataGrid.SelectedItems.Clear()
        End If
    End Sub

    Private Sub CheckIfAttendanceInSubCategories()
        Dim attendanceExists As Boolean = False

        Try
            Using con As New MySqlConnection(SqlString)
                con.Open()

                ' SQL query to check if 'attendance' exists in the sub_category_name column
                Dim query As String = "SELECT COUNT(*) FROM sub_categories WHERE LOWER(sub_category_name) LIKE '%attendance%'"

                Using cmd As New MySqlCommand(query, con)
                    ' ExecuteScalar returns the count
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Check if count > 0 (word 'attendance' exists)
                    If count > 0 Then
                        attendanceExists = True
                    End If
                End Using
            End Using

            ' Display result based on the check
            If attendanceExists Then ' exists

            Else ' not exists

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class