Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class TeacherDashboard
    Private LoggedInUsername As String
    Public Sub New(username As String)
        InitializeComponent()
        LoggedInUsername = username
    End Sub

    Dim MySqlString As String = "server=localhost; user=root; password=; database=grading_sys_db;"
    Dim cmd As New MySqlCommand
    Dim dtCategories As New DataTable
    Dim dtSelfSettings As New DataTable
    Dim dtCatCourse As New DataTable
    Dim dtSubCateg As New DataTable
    Dim dtScScore As New DataTable
    Dim dtFinalGrade As New DataTable
    Dim dtAttendance As New DataTable
    Private Sub LoadCategories()
        dtCategories.Clear()
        Using con As New MySqlConnection(MySqlString)
            con.Open()
            Using cmd As New MySqlCommand("
            SELECT c.* 
            FROM categories c
            INNER JOIN courses cr ON c.course_id = cr.course_id
            INNER JOIN teaches t ON cr.course_id = t.course_id
            INNER JOIN professors p ON t.professor_id = p.professor_id
            WHERE p.prof_username = @prof_username", con)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@prof_username", LoggedInUsername)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtCategories.Load(reader)
                End Using
            End Using
        End Using

        CategoriesDataGrid.Items.Clear()

        For Each row As DataRow In dtCategories.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtCategories.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            CategoriesDataGrid.Items.Add(listViewItem)
        Next
    End Sub
    Private Sub LoadSelfSettings()
        Using con As New MySqlConnection(MySqlString)
            con.Open()
            dtSelfSettings.Clear()
            Using cmd As New MySqlCommand("SELECT prof_first_name, prof_last_name, prof_middle_name, prof_email, prof_username, prof_password FROM professors WHERE prof_username = @prof_username", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@prof_username", LoggedInUsername)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ProfFirstName.Text = reader("prof_first_name").ToString()
                        ProfLastName.Text = reader("prof_last_name").ToString()
                        ProfMiddleName.Text = reader("prof_middle_name").ToString()
                        ProfEmail.Text = reader("prof_email").ToString()
                        ProfUsername.Text = reader("prof_username").ToString()
                        ProfPassword.Text = reader("prof_password").ToString()
                    Else
                        MessageBox.Show("No professor data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadOwnAssignedCourses()
        dtCatCourse.Clear()
        Using con As New MySqlConnection(MySqlString)
            con.Open()
            Using cmd As New MySqlCommand("
                                        SELECT 
                                            t.course_id, c.course_name
                                        FROM 
                                            teaches t
                                        JOIN 
                                            courses c ON t.course_id = c.course_id
                                        JOIN 
                                            professors p ON t.professor_id = p.professor_id
                                        WHERE 
                                            p.prof_username = @prof_username", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@prof_username", LoggedInUsername)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtCatCourse.Load(reader)
                End Using
            End Using
        End Using

        CatCourseDataGrid.Items.Clear()
        For Each row As DataRow In dtCatCourse.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtCatCourse.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            CatCourseDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub LoadSubCateDataGrid()
        dtSubCateg.Clear()
        Using con As New MySqlConnection(MySqlString)
            con.Open()

            Using cmd As New MySqlCommand("select sc.sub_category_id, sc.course_id, sc.category_id, sc.sub_category_name, sc.total_score, sc.term, sc.semester from sub_categories sc JOIN teaches t ON t.course_id = sc.course_id WHERE t.professor_id = (SELECT professor_id FROM professors WHERE prof_username = @prof_username);", con)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@prof_username", LoggedInUsername)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtSubCateg.Load(reader)
                End Using
            End Using
        End Using

        CatSubDataGird.Items.Clear()
        For Each row As DataRow In dtSubCateg.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtSubCateg.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            CatSubDataGird.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub PopulateSubCategoryComboBox()
        ' Clear the ComboBox before adding new items
        ScFilterBySubCat.Items.Clear()

        Using con As New MySqlConnection(MySqlString)
            con.Open()

            ' Query to get the sub-category names associated with the logged-in admin
            Dim query As String = "SELECT DISTINCT sc.sub_category_name
                               FROM sub_categories sc
                               JOIN categories cat ON sc.category_id = cat.category_id
                               JOIN courses c ON cat.course_id = c.course_id
                               JOIN teaches t ON c.course_id = t.course_id
                               JOIN professors p ON t.professor_id = p.professor_id
                               WHERE p.prof_username = @adminUsername"

            Using cmd As New MySqlCommand(query, con)
                ' Add parameter to filter by the logged-in admin's username
                cmd.Parameters.AddWithValue("@adminUsername", LoggedInUsername)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Loop through the results and add each sub-category to the ComboBox
                    While reader.Read()
                        ScFilterBySubCat.Items.Add(reader("sub_category_name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub PopulateFilterByCourse()
        ' Clear the ComboBox before adding new items
        AttendanceFilterByCourse.Items.Clear()

        Using con As New MySqlConnection(MySqlString)
            con.Open()

            ' Query to get the sub-category names associated with the logged-in admin
            Dim query As String = "SELECT DISTINCT c.course_name from courses c JOIN teaches t ON c.course_id = t.course_id JOIN professors p ON t.professor_id = p.professor_id WHERE p.prof_username = @adminUsername"

            Using cmd As New MySqlCommand(query, con)
                ' Add parameter to filter by the logged-in admin's username
                cmd.Parameters.AddWithValue("@adminUsername", LoggedInUsername)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Loop through the results and add each sub-category to the ComboBox
                    While reader.Read()
                        AttendanceFilterByCourse.Items.Add(reader("course_name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadFinalGrades()
        Dim query As String = "
SELECT 
    st.student_id,
    st.first_name,
    st.last_name,
    co.course_name,
    st.section,

    -- 1st Semester Midterm Grade
    ROUND(
        SUM(
            CASE 
                WHEN s.term = 'midterm' AND s.semester = '1st' THEN s.score
                ELSE 0
            END
        ) / SUM(
            CASE 
                WHEN s.term = 'midterm' AND s.semester = '1st' THEN sc.total_score
                ELSE 0
            END
        ) * 100, 2
    ) AS first_sem_midterm_percentage,

    -- 1st Semester Finals Grade
    ROUND(
        SUM(
            CASE 
                WHEN s.term = 'finals' AND s.semester = '1st' THEN s.score
                ELSE 0
            END
        ) / SUM(
            CASE 
                WHEN s.term = 'finals' AND s.semester = '1st' THEN sc.total_score
                ELSE 0
            END
        ) * 100, 2
    ) AS first_sem_finals_percentage,

    -- 1st Semester Overall Grade (Midterm + Finals) / 2
ROUND(
    (
        (
            SUM(
                CASE 
                    WHEN s.term = 'midterm' AND s.semester = '1st' THEN s.score
                    ELSE 0
                END
            ) / SUM(
                CASE 
                    WHEN s.term = 'midterm' AND s.semester = '1st' THEN sc.total_score
                    ELSE 0
                END
            ) * 100
        )
        +
        (
            SUM(
                CASE 
                    WHEN s.term = 'finals' AND s.semester = '1st' THEN s.score
                    ELSE 0
                END
            ) / SUM(
                CASE 
                    WHEN s.term = 'finals' AND s.semester = '1st' THEN sc.total_score
                    ELSE 0
                END
            ) * 100
        )
    ) / 2, 2
) AS first_sem_overall,

    -- 2nd Semester Midterm Grade
    ROUND(
        SUM(
            CASE 
                WHEN s.term = 'midterm' AND s.semester = '2nd' THEN s.score
                ELSE 0
            END
        ) / SUM(
            CASE 
                WHEN s.term = 'midterm' AND s.semester = '2nd' THEN sc.total_score
                ELSE 0
            END
        ) * 100, 2
    ) AS second_sem_midterm_percentage,

    -- 2nd Semester Finals Grade
    ROUND(
        SUM(
            CASE 
                WHEN s.term = 'finals' AND s.semester = '2nd' THEN s.score
                ELSE 0
            END
        ) / SUM(
            CASE 
                WHEN s.term = 'finals' AND s.semester = '2nd' THEN sc.total_score
                ELSE 0
            END
        ) * 100, 2
    ) AS second_sem_finals_percentage,

    -- 2nd Semester Overall Grade (Midterm + Finals) / 2
ROUND(
    (
        (
            SUM(
                CASE 
                    WHEN s.term = 'midterm' AND s.semester = '2nd' THEN s.score
                    ELSE 0
                END
            ) / SUM(
                CASE 
                    WHEN s.term = 'midterm' AND s.semester = '2nd' THEN sc.total_score
                    ELSE 0
                END
            ) * 100
        )
        +
        (
            SUM(
                CASE 
                    WHEN s.term = 'finals' AND s.semester = '2nd' THEN s.score
                    ELSE 0
                END
            ) / SUM(
                CASE 
                    WHEN s.term = 'finals' AND s.semester = '2nd' THEN sc.total_score
                    ELSE 0
                END
            ) * 100
        )
    ) / 2, 2
) AS second_sem_overall,


    -- Final Grade: Average of 1st and 2nd Semester Overall Grades
    ROUND(
        (
            (
                SUM(
                    CASE 
                        WHEN s.term IN ('midterm', 'finals') AND s.semester = '1st' THEN s.score
                        ELSE 0
                    END
                ) / SUM(
                    CASE 
                        WHEN s.term IN ('midterm', 'finals') AND s.semester = '1st' THEN sc.total_score
                        ELSE 0
                    END
                ) * 100
            )
            +
            (
                SUM(
                    CASE 
                        WHEN s.term IN ('midterm', 'finals') AND s.semester = '2nd' THEN s.score
                        ELSE 0
                    END
                ) / SUM(
                    CASE 
                        WHEN s.term IN ('midterm', 'finals') AND s.semester = '2nd' THEN sc.total_score
                        ELSE 0
                    END
                ) * 100
            )
        ) / 2, 2
    ) AS final_grade,
NULL AS invisible_column
FROM 
    students st
INNER JOIN enrollments e ON e.student_id = st.student_id
LEFT JOIN scores s ON s.student_id = st.student_id
LEFT JOIN sub_categories sc ON s.sub_category_id = sc.sub_category_id
LEFT JOIN categories c ON sc.category_id = c.category_id
JOIN courses co ON sc.course_id = c.course_id
WHERE 1=1

"
        Dim SelectedSection = If(FinalGradeFilterBySection.SelectedItem IsNot Nothing, FinalGradeFilterBySection.SelectedItem.ToString(), "")

        If Not String.IsNullOrEmpty(SelectedSection) Then
            query &= " AND st.section = @section"
        End If

        query &= " 
GROUP BY 
    st.student_id, st.first_name, st.last_name, st.section

ORDER BY 
    st.student_id;"

        Using con As New MySqlConnection(MySqlString)
            con.Open()
            dtFinalGrade.Clear()
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.Clear()

                If Not String.IsNullOrEmpty(SelectedSection) Then
                    cmd.Parameters.AddWithValue("@section", SelectedSection)
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtFinalGrade.Load(reader)
                End Using
            End Using
        End Using

        FinalGradeDataGrid.Items.Clear()

        For Each row As DataRow In dtFinalGrade.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtFinalGrade.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            FinalGradeDataGrid.Items.Add(listViewItem)
        Next

        For Each item As ListViewItem In FinalGradeDataGrid.Items
            ' Get the final grade from the 11th column (index 10, since it's 0-based)
            Dim finalGrade As Double
            If Double.TryParse(item.SubItems(11).Text, finalGrade) Then
                ' Determine the point grade based on the final grade
                Dim pointGrade As String = ""

                If finalGrade >= 97.5 Then
                    pointGrade = "1.00"
                ElseIf finalGrade >= 94.5 Then
                    pointGrade = "1.25"
                ElseIf finalGrade >= 91.5 Then
                    pointGrade = "1.50"
                ElseIf finalGrade >= 88.5 Then
                    pointGrade = "1.75"
                ElseIf finalGrade >= 85.5 Then
                    pointGrade = "2.00"
                ElseIf finalGrade >= 82.5 Then
                    pointGrade = "2.25"
                ElseIf finalGrade >= 79.5 Then
                    pointGrade = "2.50"
                ElseIf finalGrade >= 76.5 Then
                    pointGrade = "2.75"
                ElseIf finalGrade >= 74.5 Then
                    pointGrade = "3.00"
                Else
                    pointGrade = "5.00"
                End If
                item.SubItems(12).Text = pointGrade
            End If
        Next

    End Sub

    ' LAST LOAD

    Private Sub SignOut_Click(sender As Object, e As TabControlCancelEventArgs) Handles SignOut.Click
        If e.TabPage Is MaterialTabControl1.TabPages("SignOut") Then
            e.Cancel = True
            Dim ask = MsgBox("Are you sure on signing out?", MsgBoxStyle.YesNo, "Grading System")
            If ask = MsgBoxResult.Yes Then
                Form1.Show()
                Close()
            End If
        End If
    End Sub

    Private Sub SignOutCancel_Click(sender As Object, e As EventArgs) Handles SignOutCancel.Click
        MaterialTabControl1.SelectedTab = Categories
    End Sub
    Private Sub SignOutYes_Click(sender As Object, e As EventArgs) Handles SignOutYes.Click
        Form1.Show()
        Hide()
        MaterialTabControl1.SelectedTab = Categories
        SetFormThemeLight(Me)
    End Sub

    Private Sub TeacherDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
    Private Sub DarkModeSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles DarkModeSwitch.CheckedChanged
        DarkModeBtnFlipped(Me, DarkModeSwitch, MySqlString, LoggedInUsername, "professors", "prof_username")
    End Sub
    Private Sub TeacherDashboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SetProfName()
        DarkModeDB("professors", "prof_username", LoggedInUsername, DarkModeSwitch, MySqlString)
        MaterialTabControl1.SelectedTab = Categories
        LoadCategories()
        LoadSelfSettings()
        LoadOwnAssignedCourses()
        LoadSubCateDataGrid()
        AttendanceFilterByCourse.Items.Add("")
        AttendanceChooseCourse.Items.Add("")
        ScFilterBySection.Items.Add("")
        ScFilterBySubCat.Items.Add("")
        PopulateSubCategoryComboBox()
        PopulateFilterByCourse()
        PopulateSubCategories()
        ApplyFilters()
        LoadFinalGrades()
        LoadAttendance()
        FilterPreviousAbsentees()
        PopulateAttendanceSelectCourse()
        AddHandler AttendanceDataGrid.ItemActivate, AddressOf AttendanceDataGrid_ItemActivate
        AddHandler AbsentDataGrid.ItemActivate, AddressOf AbsentDataGrid_ItemActivate
    End Sub

    Private Sub ProfUpdateBtn_Click(sender As Object, e As EventArgs) Handles ProfUpdateBtn.Click
        If ProfFirstName.Text <> "" AndAlso ProfLastName.Text <> "" AndAlso ProfEmail.Text <> "" AndAlso
        ProfEmail.Text.EndsWith("@plpasig.edu.ph") AndAlso ProfUsername.Text <> "" AndAlso ProfPassword.TextLength >= 8 Then

            Dim reEnteredPassword As String = InputBox("Please re-enter your password to confirm changes:", "Password Confirmation")
            If String.IsNullOrEmpty(reEnteredPassword) Then
                MessageBox.Show("Account modification cancelled.", "Confirmation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim originalPassword As String = ProfPassword.Text
            If reEnteredPassword = originalPassword Then
                MessageBox.Show("Password confirmed. Proceeding with the update.", "Confirmation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Password does not match. Changes aborted.", "Confirmation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim result As DialogResult = MessageBox.Show("Are you sure with your current changes?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
            Using con As New MySqlConnection(MySqlString)
                con.Open()
                Using cmd As New MySqlCommand("UPDATE admins SET admin_username = @new_username, admin_password = @new_password WHERE admin_username = '" & LoggedInUsername & "'", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@new_username", ProfUsername.Text)
                    cmd.Parameters.AddWithValue("@new_password", ProfPassword.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoggedInUsername = ProfUsername.Text
            Form1.ProfessorUsername.Text = LoggedInUsername
            MessageBox.Show("Your information was successfully updated.")
        ElseIf ProfFirstName.Text = "" AndAlso ProfLastName.Text = "" AndAlso ProfEmail.Text = "" AndAlso
        ProfUsername.Text = "" Then
        ElseIf ProfFirstName.Text = "" Then
            MessageBox.Show("Error: cannot update if your first name is empty")
        ElseIf ProfLastName.Text = "" Then
            MessageBox.Show("Error: cannot update if your last name is empty")
        ElseIf ProfUsername.Text = "" Then
            MessageBox.Show("Error: cannot update if your username is empty")
        ElseIf ProfPassword.Text = "" Then
            MessageBox.Show("Error: cannot update if your password is empty")
        ElseIf ProfPassword.TextLength < 8 Then
            MessageBox.Show("Error: cannot update if password is less than 8 characters")
        ElseIf Not ProfEmail.Text.EndsWith("@plpasig.edu.ph") Then
            MessageBox.Show("Error: cannot update email is not a PLP email")
        Else
            MessageBox.Show("Error: double check your credentials.")
        End If
    End Sub

    Private Sub CatCourseDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles CatCourseDataGrid.ItemSelectionChanged
        Try
            If CatCourseDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = CatCourseDataGrid.SelectedItems(0)
                CatSelectedCourseBox.Text = selectedItem.SubItems(1).Text
                CatSelectedCourseIDBox.Text = selectedItem.SubItems(0).Text
                SubCatSelectedCourseIdBox.Text = selectedItem.SubItems(0).Text
            Else
                CatSelectedCourseBox.Clear()
                CatSelectedCourseIDBox.Clear()
                SubCatSelectedCourseIdBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub CatCoursesSearchForCoursesBox_TextChanged(sender As Object, e As EventArgs) Handles CatCoursesSearchForCoursesBox.TextChanged
        If CatCoursesSearchForCoursesBox.Text = "" Then
            LoadOwnAssignedCourses()
        Else
            Dim searchText = "%" & CatCoursesSearchForCoursesBox.Text & "%"
            Using con As New MySqlConnection(MySqlString)
                con.Open()
                dtCatCourse.Clear()

                Using cmd As New MySqlCommand("SELECT t.course_id, c.course_name 
                                       FROM teaches t
                                       JOIN courses c ON t.course_id = c.course_id
                                       JOIN professors p ON t.professor_id = p.professor_id
                                       WHERE p.prof_username = @prof_username AND
                                       CONCAT(c.course_name, t.course_id) like @search", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@search", searchText)
                    cmd.Parameters.AddWithValue("@prof_username", LoggedInUsername)
                    Using reader = cmd.ExecuteReader
                        dtCatCourse.Load(reader)
                    End Using
                End Using
            End Using

            CatCourseDataGrid.Items.Clear()

            For Each row As DataRow In dtCatCourse.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString)
                For i = 1 To dtCatCourse.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString)
                Next
                CatCourseDataGrid.Items.Add(listViewItem)
            Next
        End If
    End Sub

    Private Sub CatAddBtn_Click(sender As Object, e As EventArgs) Handles CatAddBtn.Click
        Try
            If CatSelectedCourseBox.Text <> "" AndAlso CatCategNameBox.Text <> "" AndAlso CatCatPercentBox.Text <> "" AndAlso CatSelectedCourseIDBox.Text <> "" Then
                ' Convert input percentage to integer
                Dim newCategoryPercent As Integer
                If Not Integer.TryParse(CatCatPercentBox.Text, newCategoryPercent) Then
                    MessageBox.Show("Error: Percentage must be a valid number.")
                    Return
                End If

                Dim totalPercentage = 0
                Using con As New MySqlConnection(MySqlString)
                    con.Open()
                    ' Query to calculate the total percentage for the selected course
                    Using cmd As New MySqlCommand("
                    SELECT SUM(Percent) 
                    FROM categories 
                    WHERE course_id = @course_id", con)
                        cmd.Parameters.AddWithValue("@course_id", CatCourseDataGrid.SelectedItems(0).SubItems(0).Text)

                        Dim result = cmd.ExecuteScalar
                        If Not IsDBNull(result) Then
                            totalPercentage = Convert.ToInt32(result)
                        End If
                    End Using

                    ' Validate if adding the new percentage will exceed 100%
                    If totalPercentage + newCategoryPercent > 100 Then
                        MessageBox.Show("Error: Adding this category will exceed 100% total for the course." & vbCrLf & "")
                        Return
                    End If
                End Using

                ' Insert the new category if validation passes
                Using con As New MySqlConnection(MySqlString)
                    con.Open()

                    Using cmd As New MySqlCommand("INSERT INTO categories (course_id, category_name, Percent) VALUES (@course_id, @category_name, @percent)", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@course_id", CatCourseDataGrid.SelectedItems(0).SubItems(0).Text)
                        cmd.Parameters.AddWithValue("@category_name", CatCategNameBox.Text)
                        cmd.Parameters.AddWithValue("@percent", newCategoryPercent)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                CatClrBtn.PerformClick()
                LoadCategories()
            ElseIf CatSelectedCourseBox.Text = "" AndAlso CatCategNameBox.Text = "" AndAlso CatCatPercentBox.Text = "" Then
                MessageBox.Show("Error: cannot add category with everything empty")
            ElseIf CatSelectedCourseBox.Text = "" Then
                MessageBox.Show("Error: cannot add category with no course selected")
            ElseIf CatCategNameBox.Text = "" Then
                MessageBox.Show("Error: cannot add category with empty category name")
            ElseIf CatCatPercentBox.Text = "" Then
                MessageBox.Show("Error: cannot add category with empty percentage")
            Else
                MessageBox.Show("Error: Double check your details")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CategoriesDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles CategoriesDataGrid.ItemSelectionChanged
        Try
            If CategoriesDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = CategoriesDataGrid.SelectedItems(0)
                CatSelectedCourseIDBox.Text = selectedItem.SubItems(1).Text
                CatCategNameBox.Text = selectedItem.SubItems(2).Text
                CatCatPercentBox.Text = selectedItem.SubItems(3).Text
                SubCatCategoryIdBox.Text = selectedItem.SubItems(0).Text
                Using con As New MySqlConnection(MySqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("SELECT category_name FROM categories WHERE category_id = @category_id", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@category_id", CategoriesDataGrid.SelectedItems(0).SubItems(0).Text)
                        Using reader = cmd.ExecuteReader()
                            If reader.Read() Then
                                CatSubCatSubNameBox.Text = reader.GetString(0)
                            Else
                                MessageBox.Show("No data found for the specified category ID.")
                            End If
                        End Using
                    End Using
                End Using
            Else
                CatCategNameBox.Clear()
                CatCatPercentBox.Clear()
                CatSubCatSubNameBox.Clear()
                SubCatCategoryIdBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub CatDeleteBtn_Click(sender As Object, e As EventArgs) Handles CatDeleteBtn.Click
        Try
            If CatSelectedCourseBox.Text <> "" AndAlso CatCategNameBox.Text <> "" AndAlso CatCatPercentBox.Text <> "" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure on deleting the: " & CategoriesDataGrid.SelectedItems(0).SubItems(2).Text, "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If
                Using con As New MySqlConnection(MySqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("DELETE FROM categories WHERE category_id = @category_id", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@category_id", CategoriesDataGrid.SelectedItems(0).SubItems(0).Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadCategories()
                CatClrBtn.PerformClick()
            ElseIf CatSelectedCourseBox.Text = "" AndAlso CatCategNameBox.Text = "" AndAlso CatCatPercentBox.Text = "" Then
                MessageBox.Show("Error: There are empty fields")
            ElseIf CatSelectedCourseBox.Text = "" Then
                MessageBox.Show("Error: Choose a course first")
            ElseIf CatCategNameBox.Text = "" Then
                MessageBox.Show("Error: Choose a category to delete first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CatUpdateBtn_Click(sender As Object, e As EventArgs) Handles CatUpdateBtn.Click
        Try
            If CategoriesDataGrid.SelectedItems.Count = 0 Then
                MessageBox.Show("Error: Select a category first")
                Return
            End If

            If CatCategNameBox.Text = "" OrElse CatCatPercentBox.Text = "" Then
                MessageBox.Show("Error: Category name and percentage cannot be empty")
                Return
            End If

            Dim percentValue As Integer
            If Not Integer.TryParse(CatCatPercentBox.Text, percentValue) Then
                MessageBox.Show("Error: Percentage must be a valid number")
                Return
            End If

            ' Get the sum of percentages for the selected course excluding the current category
            Dim totalPercent As Integer = 0
            Dim currentCategoryPercent As Integer = 0
            Using con As New MySqlConnection(MySqlString)
                con.Open()
                Using cmd As New MySqlCommand("SELECT category_id, percent FROM categories WHERE course_id = @course_id", con)
                    cmd.Parameters.AddWithValue("@course_id", CategoriesDataGrid.SelectedItems(0).SubItems(1).Text)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If reader("category_id").ToString() = CategoriesDataGrid.SelectedItems(0).SubItems(0).Text Then
                                currentCategoryPercent = Convert.ToInt32(reader("percent")) ' Store the current percentage of the category being updated
                            Else
                                totalPercent += Convert.ToInt32(reader("percent")) ' Add up the percentages of the other categories
                            End If
                        End While
                    End Using
                End Using
            End Using

            ' Check if the new total percentage will exceed 100%
            If totalPercent + percentValue > 100 Then
                MessageBox.Show("Error: Total percentage for categories cannot exceed 100%")
                Return
            End If

            ' If the total percentage is less than 100%, warn the user
            If totalPercent + percentValue < 100 Then
                Dim remainingPercent As Integer = 100 - (totalPercent + percentValue)
                MessageBox.Show("Warning: The total percentage will add up to " & (totalPercent + percentValue) & "%. Please adjust other categories to allocate the remaining " & remainingPercent & "%.")
            End If

            ' Update the category with the new percentage
            Using con As New MySqlConnection(MySqlString)
                con.Open()
                Using cmd As New MySqlCommand("UPDATE categories SET course_id = @course_id, category_name = @category_name, percent = @percent WHERE category_id = @category_id", con)
                    cmd.Parameters.AddWithValue("@course_id", CategoriesDataGrid.SelectedItems(0).SubItems(1).Text)
                    cmd.Parameters.AddWithValue("@category_name", CatCategNameBox.Text)
                    cmd.Parameters.AddWithValue("@percent", percentValue)
                    cmd.Parameters.AddWithValue("@category_id", CategoriesDataGrid.SelectedItems(0).SubItems(0).Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("The: " & CatCategNameBox.Text & " was successfully updated")

            CatClrBtn.PerformClick()
            LoadCategories()
            CatSubDataGird.Refresh()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub SubCatAddBtn_Click(sender As Object, e As EventArgs) Handles SubCatAddBtn.Click
        Try
            Dim percentValue As Integer
            If Not Integer.TryParse(CatSubTotScoreBox.Text, percentValue) Then
                MessageBox.Show("Error: Total Score must be a number")
                Return
            End If

            If CatSubCatSubNameBox.Text <> "" AndAlso CatSubCatNameBox.Text <> "" AndAlso CatSubTotScoreBox.Text <> "" AndAlso CatSelectSem.SelectedItem <> "" AndAlso CatSelectTerm.SelectedItem <> "" Then
                Dim newSubCategoryId As Integer
                Dim SelectedTerm = If(CatSelectTerm.SelectedItem IsNot Nothing, CatSelectTerm.SelectedItem.ToString(), "")
                Dim SelectedSem = If(CatSelectSem.SelectedItem IsNot Nothing, CatSelectSem.SelectedItem.ToString(), "")

                Using con As New MySqlConnection(MySqlString)
                    con.Open()

                    ' Check if the sub-category already exists
                    Dim checkSubCategoryQuery As String = "SELECT COUNT(*) FROM sub_categories WHERE course_id = @course_id AND category_id = @category_id AND sub_category_name = @sub_category_name AND term = @term And semester = @semester"

                    Using checkCmd As New MySqlCommand(checkSubCategoryQuery, con)
                        checkCmd.Parameters.AddWithValue("@course_id", SubCatSelectedCourseIdBox.Text)
                        checkCmd.Parameters.AddWithValue("@category_id", SubCatCategoryIdBox.Text)
                        checkCmd.Parameters.AddWithValue("@sub_category_name", CatSubCatNameBox.Text)
                        checkCmd.Parameters.AddWithValue("@term", SelectedTerm)
                        checkCmd.Parameters.AddWithValue("@semester", SelectedSem)

                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If count > 0 Then
                            MessageBox.Show("Error: The sub-category already exists.")
                            Return
                        End If
                    End Using

                    ' Insert the new sub_category
                    Using cmd As New MySqlCommand("INSERT INTO sub_categories (course_id, category_id, sub_category_name, total_score, term, semester) VALUES (@course_id, @category_id, @sub_category_name, @total_score, @term, @semester)", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@course_id", SubCatSelectedCourseIdBox.Text)
                        cmd.Parameters.AddWithValue("@category_id", SubCatCategoryIdBox.Text)
                        cmd.Parameters.AddWithValue("@sub_category_name", CatSubCatNameBox.Text)
                        cmd.Parameters.AddWithValue("@total_score", CatSubTotScoreBox.Text)
                        cmd.Parameters.AddWithValue("@term", SelectedTerm)
                        cmd.Parameters.AddWithValue("@semester", SelectedSem)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Retrieve the ID of the newly inserted sub_category
                    Using getIdCmd As New MySqlCommand("SELECT LAST_INSERT_ID();", con)
                        newSubCategoryId = Convert.ToInt32(getIdCmd.ExecuteScalar())
                    End Using

                    ' Fetch enrolled students for the given course_id
                    Using getStudentsCmd As New MySqlCommand("SELECT student_id FROM enrollments WHERE course_id = @course_id", con)
                        getStudentsCmd.Parameters.AddWithValue("@course_id", SubCatSelectedCourseIdBox.Text)

                        Using reader As MySqlDataReader = getStudentsCmd.ExecuteReader()
                            Dim studentIds As New List(Of String)
                            While reader.Read()
                                studentIds.Add(reader("student_id").ToString())
                            End While
                            reader.Close()

                            ' Insert scores only for the selected term and semester
                            For Each studentId As String In studentIds
                                ' Check if the score template already exists for the selected term and semester
                                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM scores WHERE student_id = @student_id AND sub_category_id = @sub_category_id AND term = @term AND semester = @semester", con)
                                    checkCmd.Parameters.Clear()
                                    checkCmd.Parameters.AddWithValue("@student_id", studentId)
                                    checkCmd.Parameters.AddWithValue("@sub_category_id", newSubCategoryId)
                                    checkCmd.Parameters.AddWithValue("@term", SelectedTerm)
                                    checkCmd.Parameters.AddWithValue("@semester", SelectedSem)

                                    Dim exists As Boolean = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0

                                    ' Insert only if no existing record is found
                                    If Not exists Then
                                        Using insertScoreCmd As New MySqlCommand("INSERT INTO scores (student_id, sub_category_id, score, term, semester) VALUES (@student_id, @sub_category_id, @score, @term, @semester)", con)
                                            insertScoreCmd.Parameters.Clear()
                                            insertScoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                            insertScoreCmd.Parameters.AddWithValue("@sub_category_id", newSubCategoryId)
                                            insertScoreCmd.Parameters.AddWithValue("@score", 0)  ' Default score is 0
                                            insertScoreCmd.Parameters.AddWithValue("@term", SelectedTerm)
                                            insertScoreCmd.Parameters.AddWithValue("@semester", SelectedSem)
                                            insertScoreCmd.ExecuteNonQuery()
                                        End Using
                                    End If
                                End Using
                            Next
                        End Using
                    End Using
                End Using

                SubCatClrBtn.PerformClick()
                LoadSubCateDataGrid()
                LoadFinalGrades()
                ApplyFilters()
                LoadAttendance()
                PopulateFilterByCourse()
                PopulateSubCategoryComboBox()
                PopulateSubCategories()

                MessageBox.Show("Sub-category and score templates added successfully.")
            Else
                ' Error handling for missing fields
                If CatSubCatSubNameBox.Text = "" Then MessageBox.Show("Error: Sub Category name is empty")
                If CatSubCatNameBox.Text = "" Then MessageBox.Show("Error: Category name is empty")
                If CatSubTotScoreBox.Text = "" Then MessageBox.Show("Error: Total Score is empty")
                If CatSelectTerm.Text = "" Then MessageBox.Show("Error: Term is empty")
                If CatSelectSem.Text = "" Then MessageBox.Show("Error: Semester is empty")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ScScoreDataGrid_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ScScoreDataGrid.ItemSelectionChanged
        Try
            If ScScoreDataGrid.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = ScScoreDataGrid.SelectedItems(0)
                ScStudentNameBox.Text = selectedItem.SubItems(2).Text & " " & selectedItem.SubItems(3).Text
                ScCourseNameBox.Text = selectedItem.SubItems(4).Text
                ScCatNameBox.Text = selectedItem.SubItems(5).Text
                ScSubCatNameBox.Text = selectedItem.SubItems(6).Text
                ScRawScoreBox.Text = selectedItem.SubItems(7).Text
                ScTotalScoreBox.Text = selectedItem.SubItems(8).Text
            Else
                ScStudentNameBox.Clear()
                ScCourseNameBox.Clear()
                ScCatNameBox.Clear()
                ScSubCatNameBox.Clear()
                ScRawScoreBox.Clear()
                ScTotalScoreBox.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    'select t.teaches_id, t.professor_id, t.professor_id, p.prof_first_name, p.prof_last_name, t.course_id, c.course_name, t.start_date FROM teaches t JOIN professors p ON t.professor_id = p.professor_id JOIN courses c ON t.course_id = c.course_id;

    Private Sub DisableKeypress(sender As Object, e As KeyPressEventArgs) Handles ScStudentNameBox.KeyPress, ScCourseNameBox.KeyPress, ScCatNameBox.KeyPress, ScSubCatNameBox.KeyPress, ScTotalScoreBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub ScEnterBtn_Click(sender As Object, e As EventArgs) Handles ScEnterBtn.Click
        Try
            If ScStudentNameBox.Text = "" Or ScCatNameBox.Text = "" Or ScCourseNameBox.Text = "" Or ScSubCatNameBox.Text = "" Or ScTotalScoreBox.Text = "" Then
                MessageBox.Show("Error: please select a student from the table on the right")
                Return
            End If

            If ScRawScoreBox.Text = "" Then
                MessageBox.Show("Error: raw score cannot be empty, input atleast 0")
                ScRawScoreBox.Text = 0
                Return
            End If

            If ScTotalScore.Text = "" Then
                MessageBox.Show("Error: total score cannot be empty, input atleast " & CInt(ScRawScoreBox.Text) + 1)
                ScTotalScore.Text = CInt(ScRawScoreBox.Text) + 1
                Return
            End If

            If CInt(ScRawScoreBox.Text) > CInt(ScTotalScoreBox.Text) Then
                MessageBox.Show("Error: raw score cannot be greater than total score")
                Return
            End If

            If CInt(ScRawScoreBox.Text) < 0 Then
                MessageBox.Show("Error: raw score cannot be less than 0")
                ScRawScoreBox.Text = 0
                Return
            End If

            Dim percentValue As Integer
            If Not Integer.TryParse(ScRawScoreBox.Text, percentValue) Then
                MessageBox.Show("Error: Percentage must be a valid number")
                Return
            End If

            Using con As New MySqlConnection(MySqlString)
                con.Open()

                Using cmd As New MySqlCommand("UPDATE scores SET score = @score WHERE score_id = @score_id", con)
                    cmd.Parameters.AddWithValue("@score_id", ScScoreDataGrid.SelectedItems(0).SubItems(0).Text)
                    cmd.Parameters.AddWithValue("score", ScRawScoreBox.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show(ScStudentNameBox.Text & "'s score was successfully entered.")

            ScClearBtn.PerformClick()
            ApplyFilters()
            LoadFinalGrades()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ScClearBtn_Click(sender As Object, e As EventArgs) Handles ScClearBtn.Click
        ScStudentNameBox.Clear()
        ScCourseNameBox.Clear()
        ScCatNameBox.Clear()
        ScSubCatNameBox.Clear()
        ScRawScoreBox.Clear()
        ScTotalScoreBox.Clear()
    End Sub

    Private Sub LoadAttendance()
        dtAttendance.Clear()

        Dim SelectedSection As String = If(AttendanceFilterBySection.SelectedItem IsNot Nothing, AttendanceFilterBySection.SelectedItem.ToString(), "")

        Dim BaseQuery As String = "SELECT student_id, first_name, last_name, section FROM students WHERE 1=1"

        If Not String.IsNullOrEmpty(SelectedSection) Then
            BaseQuery &= " AND section = '" & AttendanceFilterBySection.SelectedItem & "'"
        End If

        Using con As New MySqlConnection(MySqlString)
            con.Open()
            Using cmd As New MySqlCommand(BaseQuery, con)
                Using reader = cmd.ExecuteReader
                    dtAttendance.Load(reader)
                End Using
            End Using
        End Using

        AttendanceDataGrid.Items.Clear()

        For Each row As DataRow In dtAttendance.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString)
            For i = 1 To dtAttendance.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString)
            Next
            listViewItem.SubItems.Add(Date.Today.Date)
            AttendanceDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub AttendanceFilterBySection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendanceFilterBySection.SelectedIndexChanged
        LoadAttendance()
    End Sub

    Private Sub AttendanceDataGrid_ItemActivate(sender As Object, e As EventArgs) Handles AttendanceDataGrid.ItemActivate
        AttendanceFilterBySection.Enabled = False
        ' Check if an item is selected
        If AttendanceDataGrid.SelectedItems.Count > 0 Then
            ' Get the selected ListViewItem from AttendanceDataGrid
            Dim selectedItem As ListViewItem = AttendanceDataGrid.SelectedItems(0)

            ' Create a new ListViewItem for AbsentDataGrid
            Dim newItem As New ListViewItem(selectedItem.Text) ' Assuming the first column is the student name or ID

            ' Add subitems (additional columns) to the new item
            For i As Integer = 1 To selectedItem.SubItems.Count - 1
                newItem.SubItems.Add(selectedItem.SubItems(i).Text)
            Next

            ' Add today's date to the fifth (or last) column of the new item
            ' newItem.SubItems.Add(DateTime.Today.ToString("MM/dd/yyyy"))

            ' Add the new item to the AbsentDataGrid
            AbsentDataGrid.Items.Add(newItem)

            ' Sort the AbsentDataGrid
            AbsentDataGrid.Sorting = SortOrder.Ascending
            AbsentDataGrid.Sort()

            ' Remove the selected item from AttendanceDataGrid
            AttendanceDataGrid.Items.Remove(selectedItem)
        End If
    End Sub

    Private Sub AbsentDataGrid_ItemActivate(sender As Object, e As EventArgs) Handles AbsentDataGrid.ItemActivate
        ' Check if an item is selected
        If AbsentDataGrid.SelectedItems.Count > 0 Then
            ' Get the selected ListViewItem from AbsentDataGrid
            Dim selectedItem As ListViewItem = AbsentDataGrid.SelectedItems(0)

            ' Create a new ListViewItem for AttendanceDataGrid
            Dim newItem As New ListViewItem(selectedItem.Text) ' Assuming the first column is the student name or ID

            ' Add subitems (additional columns) to the new item
            For i As Integer = 1 To selectedItem.SubItems.Count - 1
                newItem.SubItems.Add(selectedItem.SubItems(i).Text)
            Next

            ' Add today's date to the fifth (or last) column of the new item
            'newItem.SubItems.Add(DateTime.Today.ToString("MM/dd/yyyy"))

            ' Add the new item to the AttendanceDataGrid
            AttendanceDataGrid.Items.Add(newItem)

            ' Sort the AttendanceDataGrid by the first column (student_id or whatever column you want to sort by)
            AttendanceDataGrid.Sorting = SortOrder.Ascending  ' Or .Descending if you want descending order
            AttendanceDataGrid.Sort()

            ' Remove the selected item from AbsentDataGrid
            AbsentDataGrid.Items.Remove(selectedItem)
        End If
    End Sub

    Private Sub AttendanceReturnBtn_Click(sender As Object, e As EventArgs) Handles AttendanceReturnBtn.Click
        Dim result As DialogResult = MessageBox.Show("Return all of the absentees to present attedance?", "Return Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If
        AttendanceFilterBySection.Enabled = True
        If AbsentDataGrid.Items.Count > 0 Then
            For Each item As ListViewItem In AbsentDataGrid.Items
                Dim newItem As New ListViewItem(item.Text)

                For i As Integer = 1 To item.SubItems.Count - 1
                    newItem.SubItems.Add(item.SubItems(i).Text)
                Next

                AttendanceDataGrid.Items.Add(newItem)
            Next

            AbsentDataGrid.Items.Clear()

            AttendanceDataGrid.Sorting = SortOrder.Ascending
            AttendanceDataGrid.Sort()
        End If
    End Sub

    Private Sub PopulateAttendanceSelectCourse()
        Using con As New MySqlConnection(MySqlString)
            con.Open()
            Using cmd As New MySqlCommand("SELECT t.course_id, c.course_name 
                                           FROM teaches t
                                           JOIN courses c
                                           ON t.course_id = c.course_id 
                                           WHERE t.professor_id = 
                                           (SELECT professor_id FROM professors WHERE prof_username = '" & LoggedInUsername & "') ", con)
                Using reader As MySqlDataReader = cmd.ExecuteReader
                    While reader.Read()
                        AttendanceChooseCourse.Items.Add(reader("course_id") & "-" & reader("course_name"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub PopulateSubCategories()
        ' Clear existing items in the ComboBox
        AttenSelectSubCat.Items.Clear()

        ' SQL query to select sub-categories containing "attendance" in the name
        Dim query As String = "SELECT sub_category_id, sub_category_name FROM sub_categories WHERE sub_category_name LIKE '%attendance%'"

        Using con As New MySqlConnection(MySqlString)
            con.Open()

            Using cmd As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Get sub-category id and name
                        Dim subCategoryId As Integer = reader.GetInt32("sub_category_id")
                        Dim subCategoryName As String = reader.GetString("sub_category_name")

                        ' Add formatted string to ComboBox (sub_category_id - sub_category_name)
                        AttenSelectSubCat.Items.Add(subCategoryId.ToString() & " - " & subCategoryName)
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub SaveAttedanceBtn_Click(sender As Object, e As EventArgs) Handles SaveAttedanceBtn.Click
        Dim result = MessageBox.Show("Are you sure on saving absent students?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        If AbsentDataGrid.Items.Count > 0 Then
            If AttendanceChooseCourse.SelectedIndex = -1 Then
                MessageBox.Show("Select a course first")
                Return
            End If

            If AttenSelectSubCat.SelectedIndex = -1 Then
                MessageBox.Show("Select a sub-category first")
                Return
            End If

            Dim selectedSubCategory As String = AttenSelectSubCat.SelectedItem.ToString()

            ' Get the sub_category_id by splitting the selected item at the dash ("-") and taking the first part
            Dim subCategoryId As Integer
            Dim subCategoryParts As String() = selectedSubCategory.Split("-"c)
            ' Try parsing the first part as an integer (sub_category_id)
            If Integer.TryParse(subCategoryParts(0).Trim(), subCategoryId) Then
            Else
                MessageBox.Show("Invalid sub-category selected.")
            End If

            Dim selectedCourseID As String = AttendanceChooseCourse.SelectedItem.ToString().Split("-"c)(0).Trim()

            Dim courseId As Integer
            Dim courseParts As String() = selectedCourseID.Split("-"c)
            ' Try parsing the first part as an integer (sub_category_id)
            If Integer.TryParse(courseParts(0).Trim(), courseId) Then
            Else
                MessageBox.Show("Invalid course selected.")
            End If

            Dim absentDate As Date = Date.Today.Date

            Using con As New MySqlConnection(MySqlString)
                con.Open()

                Using transaction = con.BeginTransaction
                    ' Increment total score for the selected sub-category
                    Dim updateTotalScoreCmd As New MySqlCommand("UPDATE sub_categories SET total_score = total_score + 1 WHERE sub_category_id = @sub_category_id AND course_id = @course_id", con, transaction)
                    updateTotalScoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                    updateTotalScoreCmd.Parameters.AddWithValue("@course_id", courseId)
                    updateTotalScoreCmd.ExecuteNonQuery()

                    For Each item As ListViewItem In AbsentDataGrid.Items
                        If AttendanceChooseCourse.SelectedIndex <> -1 Then
                            Dim studentId As Integer
                            If Not Integer.TryParse(item.SubItems(0).Text, studentId) Then
                                MessageBox.Show("Invalid student ID: " & item.SubItems(0).Text)
                                Return
                            End If

                            ' Insert absent record for students who are absent
                            Dim absentInsertCmd As New MySqlCommand("INSERT INTO attendance (student_id, course_id, date_absent) VALUES (@student_id, @course_id, @date_absent)", con, transaction)
                            absentInsertCmd.Parameters.AddWithValue("@student_id", studentId)
                            absentInsertCmd.Parameters.AddWithValue("@course_id", courseId)
                            absentInsertCmd.Parameters.AddWithValue("@date_absent", absentDate)
                            absentInsertCmd.ExecuteNonQuery()
                        Else
                            MessageBox.Show("Error: No student found in the Attendance Grid.")
                            Return
                        End If
                    Next

                    For Each item As ListViewItem In AttendanceDataGrid.Items
                        If AttendanceChooseCourse.SelectedIndex <> -1 Then
                            Dim studentId As Integer
                            If Not Integer.TryParse(item.SubItems(0).Text, studentId) Then
                                MessageBox.Show("Invalid student ID: " & item.SubItems(0).Text)
                                Return
                            End If

                            ' Increment score for every student in the scores table for the selected sub-category
                            Dim updateStudentScoreCmd As New MySqlCommand("UPDATE scores SET score = score + 1 WHERE student_id = @student_id AND sub_category_id = @sub_category_id", con, transaction)
                            updateStudentScoreCmd.Parameters.AddWithValue("@student_id", studentId)
                            updateStudentScoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                            updateStudentScoreCmd.ExecuteNonQuery()
                        End If
                    Next

                    transaction.Commit()
                End Using

                MessageBox.Show("Attendance has been saved successfully.")
                AttendanceFilterBySection.Enabled = True
                AbsentDataGrid.Items.Clear()
                FilterPreviousAbsentees()
                LoadAttendance()
                AttendanceDataGrid.Refresh()
                LoadFinalGrades()
                ApplyFilters()
                LoadSubCateDataGrid()
            End Using
        End If
    End Sub


    ' Function to check if the student is absent
    Private Function IsStudentAbsent(studentId As Integer) As Boolean
        For Each item As ListViewItem In AbsentDataGrid.Items
            If Integer.TryParse(item.SubItems(0).Text, studentId) Then
                Return True
            End If
        Next
        Return False
    End Function


    Dim dtPreviousAttendance As New DataTable

    Private Sub FilterPreviousAbsentees()
        Dim SelectedSection As String = If(AttendanceFilterBySectionPreviousAbsentees.SelectedItem IsNot Nothing, AttendanceFilterBySectionPreviousAbsentees.SelectedItem.ToString(), "")
        Dim selectedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        Dim BaseQuery As String = "
        SELECT a.attendance_id, a.student_id, s.first_name, s.last_name, s.section, a.course_id, a.date_absent FROM attendance a JOIN students s ON a.student_id = s.student_id WHERE 1=1"

        If Not String.IsNullOrEmpty(SelectedSection) Then
            BaseQuery &= " AND s.section = @section"
        End If

        If Not String.IsNullOrEmpty(selectedDate) Then
            BaseQuery &= " AND date_absent = @date_absent"
        End If

        dtPreviousAttendance.Clear()

        Using con As New MySqlConnection(MySqlString)
            con.Open()
            Using cmd As New MySqlCommand(BaseQuery, con)
                cmd.Parameters.Clear()

                If Not String.IsNullOrEmpty(SelectedSection) Then
                    cmd.Parameters.AddWithValue("@section", SelectedSection)
                End If

                If Not String.IsNullOrEmpty(selectedDate) Then
                    cmd.Parameters.AddWithValue("@date_absent", selectedDate)
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtPreviousAttendance.Load(reader)
                End Using

            End Using
        End Using

        PreviousAbsenteesDataGrid.Items.Clear()

        For Each row As DataRow In dtPreviousAttendance.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtPreviousAttendance.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            PreviousAbsenteesDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        FilterPreviousAbsentees()
    End Sub

    Private Sub CatSubDataGird_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles CatSubDataGird.ItemSelectionChanged
        Try
            If CatSubDataGird.SelectedItems.Count > 0 Then
                Dim selectedItem As ListViewItem = CatSubDataGird.SelectedItems(0)

                ' Get the course_id from the selected item (index 1)
                Dim courseId As Integer = Convert.ToInt32(selectedItem.SubItems(1).Text)

                ' Query the database to get the course name based on course_id
                Using con As New MySqlConnection(MySqlString)
                    con.Open()
                    Dim query As String = "SELECT course_name FROM courses WHERE course_id = @course_id"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@course_id", courseId)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Assign the course name to CatSubCatSubNameBox
                                CatSubCatSubNameBox.Text = reader("course_name").ToString()
                            End If
                        End Using
                    End Using
                End Using

                ' Assign the other values from the selected row to the textboxes
                SubCatSelectedCourseIdBox.Text = selectedItem.SubItems(1).Text ' Course ID
                CatSubCatNameBox.Text = selectedItem.SubItems(3).Text ' Subcategory Name
                CatSubTotScoreBox.Text = selectedItem.SubItems(4).Text ' Total Score
                CatSelectTerm.SelectedItem = selectedItem.SubItems(5).Text
                CatSelectTerm.Text = selectedItem.SubItems(5).Text
                CatSelectTerm.Refresh()
                CatSelectSem.SelectedItem = selectedItem.SubItems(6).Text
                CatSelectSem.Text = selectedItem.SubItems(6).Text
                CatSelectSem.Refresh()
                SubCatCategoryIdBox.Text = selectedItem.SubItems(2).Text
            Else
                ' If no item is selected, clear the textboxes
                SubCatSelectedCourseIdBox.Clear()
                CatSubCatNameBox.Clear()
                CatSubTotScoreBox.Clear()
                CatSubCatSubNameBox.Clear()
                SubCatCategoryIdBox.Clear()
                CatSelectSem.SelectedIndex = -1
                CatSelectSem.Text = ""
                CatSelectSem.Refresh()
                CatSelectTerm.SelectedIndex = -1
                CatSelectTerm.Text = ""
                CatSelectTerm.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub SubCatDelBtn_Click(sender As Object, e As EventArgs) Handles SubCatDelBtn.Click
        Try
            If SubCatSelectedCourseIdBox.Text <> "" AndAlso CatSubCatSubNameBox.Text <> "" AndAlso CatSubCatNameBox.Text <> "" AndAlso CatSubTotScoreBox.Text <> "" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure on deleting the: " & CatSubDataGird.SelectedItems(0).SubItems(1).Text, "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If

                Using con As New MySqlConnection(MySqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("DELETE FROM sub_categories WHERE sub_category_id = @sub_category_id", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@sub_category_id", CatSubDataGird.SelectedItems(0).SubItems(0).Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadSubCateDataGrid()
                SubCatClrBtn.PerformClick()
            ElseIf SubCatSelectedCourseIdBox.Text = "" Or CatSubCatSubNameBox.Text = "" Or CatSubCatNameBox.Text = "" Or CatSubTotScoreBox.Text = "" Then
                MessageBox.Show("Error: Select a sub category to delete first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AttendanceFilterByCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendanceFilterByCourse.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub ScFilterBySubCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScFilterBySubCat.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub ScFilterBySection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScFilterBySection.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub ApplyFilters()
        Dim selectedCourse As String = If(AttendanceFilterByCourse.SelectedItem IsNot Nothing, AttendanceFilterByCourse.SelectedItem.ToString(), "")
        Dim selectedSubCat As String = If(ScFilterBySubCat.SelectedItem IsNot Nothing, ScFilterBySubCat.SelectedItem.ToString(), "")
        Dim selectedSection As String = If(ScFilterBySection.SelectedItem IsNot Nothing, ScFilterBySection.SelectedItem.ToString(), "")
        Dim SearchBox As String = If(ScoringSearchStudentsBox.Text <> "", ScoringSearchStudentsBox.Text, "")
        SearchBox = "%" & SearchBox & "%"
        Dim selectedTerm As String = If(ScFilterByTerm.SelectedItem IsNot Nothing, ScFilterByTerm.SelectedItem.ToString(), "")
        Dim selectedSem As String = If(ScFilterBySem.SelectedItem IsNot Nothing, ScFilterBySem.SelectedItem.ToString(), "")


        ' Initialize the query
        Dim baseQuery As String = "
        SELECT 
            scr.score_id,
            s.student_id,
            s.first_name,
            s.last_name,
            c.course_name,
            cat.category_name,
            sc.sub_category_name,
            scr.score,
            sc.total_score,
            (scr.score / sc.total_score) * 50 + 50 AS grade,
            scr.term,
            scr.semester
        FROM 
            students s
        JOIN 
            scores scr ON s.student_id = scr.student_id
        JOIN 
            sub_categories sc ON scr.sub_category_id = sc.sub_category_id
        JOIN 
            categories cat ON sc.category_id = cat.category_id
        JOIN 
            courses c ON cat.course_id = c.course_id
        JOIN
            teaches t ON t.course_id = c.course_id
        WHERE t.professor_id =
            (SELECT professor_id FROM professors where prof_username = '" & LoggedInUsername & "')
        "

        ' Add filters dynamically
        If Not String.IsNullOrEmpty(selectedCourse) Then
            baseQuery &= " AND c.course_name = @course_name"
        End If

        If Not String.IsNullOrEmpty(selectedSubCat) Then
            baseQuery &= " AND sc.sub_category_name = @sub_category_name"
        End If

        If Not String.IsNullOrEmpty(selectedSection) Then
            baseQuery &= " AND s.section = @section"
        End If

        If Not String.IsNullOrEmpty(SearchBox) Then
            baseQuery &= " AND CONCAT(s.student_id, s.first_name, s.last_name) like @search"
        End If

        If Not String.IsNullOrEmpty(selectedTerm) Then
            baseQuery &= " AND scr.term = @term"
        End If

        If Not String.IsNullOrEmpty(selectedSem) Then
            baseQuery &= " AND scr.semester = @sem"
        End If

        baseQuery &= " ORDER BY s.student_id, cat.category_name, sc.sub_category_name"

        ' Clear previous data
        dtScScore.Clear()

        ' Execute the query
        Using con As New MySqlConnection(MySqlString)
            con.Open()
            Using cmd As New MySqlCommand(baseQuery, con)
                ' Add parameters dynamically
                If Not String.IsNullOrEmpty(selectedCourse) Then
                    cmd.Parameters.AddWithValue("@course_name", selectedCourse)
                End If

                If Not String.IsNullOrEmpty(selectedSubCat) Then
                    cmd.Parameters.AddWithValue("@sub_category_name", selectedSubCat)
                End If

                If Not String.IsNullOrEmpty(selectedSection) Then
                    cmd.Parameters.AddWithValue("@section", selectedSection)
                End If

                If Not String.IsNullOrEmpty(SearchBox) Then
                    cmd.Parameters.AddWithValue("@search", SearchBox)
                End If

                If Not String.IsNullOrEmpty(selectedTerm) Then
                    cmd.Parameters.AddWithValue("@term", selectedTerm)
                End If

                If Not String.IsNullOrEmpty(selectedSem) Then
                    cmd.Parameters.AddWithValue("@sem", selectedSem)
                End If

                ' Load data
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dtScScore.Load(reader)
                End Using
            End Using
        End Using

        ' Populate the ListView
        ScScoreDataGrid.Items.Clear()
        For Each row As DataRow In dtScScore.Rows
            Dim listViewItem As New ListViewItem(row(0).ToString())
            For i As Integer = 1 To dtScScore.Columns.Count - 1
                listViewItem.SubItems.Add(row(i).ToString())
            Next
            ScScoreDataGrid.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub SetProfName()
        CatProfLbl.Text = LoggedInUsername
        CatProfLbl.Left = CatProfLbl.Parent.Width - CatProfLbl.Width - 30
        AttendanceProfLbl.Text = LoggedInUsername
        AttendanceProfLbl.Left = AttendanceProfLbl.Parent.Width - AttendanceProfLbl.Width - 30
        ScoringProfLbl.Text = LoggedInUsername
        ScoringProfLbl.Left = ScoringProfLbl.Parent.Width - ScoringProfLbl.Width - 30
        FinalGradeProfLbl.Text = LoggedInUsername
        FinalGradeProfLbl.Left = FinalGradeProfLbl.Parent.Width - FinalGradeProfLbl.Width - 30
        SettingsProfLbl.Text = LoggedInUsername
        SettingsProfLbl.Left = SettingsProfLbl.Parent.Width - SettingsProfLbl.Width - 30
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CatTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        CatDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        CatTimeLbl.Left = CatTimeLbl.Parent.Width - CatTimeLbl.Width - 30
        CatDateLbl.Left = CatDateLbl.Parent.Width - CatDateLbl.Width - 30

        AttendanceTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        AttendanceDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        AttendanceTimeLbl.Left = AttendanceTimeLbl.Parent.Width - AttendanceTimeLbl.Width - 30
        AttendanceDateLbl.Left = AttendanceDateLbl.Parent.Width - AttendanceDateLbl.Width - 30

        ScoringTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        ScoringDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        ScoringTimeLbl.Left = ScoringTimeLbl.Parent.Width - ScoringTimeLbl.Width - 30
        ScoringDateLbl.Left = ScoringDateLbl.Parent.Width - ScoringDateLbl.Width - 30

        FinalGradeTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        FinalGradeDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        FinalGradeTimeLbl.Left = FinalGradeTimeLbl.Parent.Width - FinalGradeTimeLbl.Width - 30
        FinalGradeDateLbl.Left = FinalGradeDateLbl.Parent.Width - FinalGradeDateLbl.Width - 30

        SettingsTimeLbl.Text = Date.Now.ToString("hh:mm:ss tt").ToUpper
        SettingsDateLbl.Text = Date.Now.ToString("MMMM dd, yyyy")
        SettingsTimeLbl.Left = SettingsTimeLbl.Parent.Width - SettingsTimeLbl.Width - 30
        SettingsDateLbl.Left = SettingsDateLbl.Parent.Width - SettingsDateLbl.Width - 30
    End Sub

    Private Sub AttendanceFilterBySectionPreviousAbsentees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendanceFilterBySectionPreviousAbsentees.SelectedIndexChanged
        FilterPreviousAbsentees()
    End Sub

    Private Sub DelAbsentBtn_Click(sender As Object, e As EventArgs) Handles DelAbsentBtn.Click
        Try
            If PreviousAbsenteesDataGrid.SelectedItems.Count >= 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure on deleting: " & PreviousAbsenteesDataGrid.SelectedItems(0).SubItems(2).Text & " " & PreviousAbsenteesDataGrid.SelectedItems(0).SubItems(3).Text & " from saved absents?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If

                Using con As New MySqlConnection(MySqlString)
                    con.Open()
                    Using cmd As New MySqlCommand("DELETE FROM attendance WHERE attendance_id = @attendance_id", con)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@attendance_id", PreviousAbsenteesDataGrid.SelectedItems(0).SubItems(0).Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                FilterPreviousAbsentees()
                LoadFinalGrades()
            Else
                MessageBox.Show("Error: You are not selecting anything")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ScoringSearchStudentsBox_TextChanged(sender As Object, e As EventArgs) Handles ScoringSearchStudentsBox.TextChanged
        If ScoringSearchStudentsBox.Text = "" Then
            ApplyFilters()
        Else
            ApplyFilters()
        End If
    End Sub

    Private Sub CatSubSearchSubBox_TextChanged(sender As Object, e As EventArgs) Handles CatSubSearchSubBox.TextChanged
        If CatSubSearchSubBox.Text = "" Then
            LoadSubCateDataGrid()
        Else
            Dim searchText = "%" & CatSubSearchSubBox.Text & "%"
            Using con As New MySqlConnection(MySqlString)
                con.Open()
                dtSubCateg.Clear()

                Using cmd As New MySqlCommand("select sc.sub_category_id, sc.course_id, sc.category_id, sc.sub_category_name, sc.total_score, sc.term, sc.semester from sub_categories sc JOIN teaches t ON t.course_id = sc.course_id WHERE t.professor_id = (SELECT professor_id FROM professors WHERE prof_username = @prof_username) AND CONCAT(sub_category_id, sub_category_name) like @search;", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@search", searchText)
                    cmd.Parameters.AddWithValue("@prof_username", LoggedInUsername)
                    Using reader = cmd.ExecuteReader
                        dtSubCateg.Load(reader)
                    End Using
                End Using
            End Using

            CatSubDataGird.Items.Clear()

            For Each row As DataRow In dtSubCateg.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString)
                For i = 1 To dtSubCateg.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString)
                Next
                CatSubDataGird.Items.Add(listViewItem)
            Next
        End If
    End Sub

    Private Sub CatSearchCatNameBox_TextChanged(sender As Object, e As EventArgs) Handles CatSearchCatNameBox.TextChanged
        If CatSearchCatNameBox.Text = "" Then
            LoadCategories()
        Else
            Dim searchText = "%" & CatSearchCatNameBox.Text & "%"
            Using con As New MySqlConnection(MySqlString)
                con.Open()
                dtCategories.Clear()

                Using cmd As New MySqlCommand("
                            SELECT c.* 
                            FROM categories c
                            INNER JOIN courses cr ON c.course_id = cr.course_id
                            INNER JOIN teaches t ON cr.course_id = t.course_id
                            INNER JOIN professors p ON t.professor_id = p.professor_id
                            WHERE p.prof_username = @prof_username
                            AND CONCAT(category_id, category_name) like @search
                ", con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@search", searchText)
                    cmd.Parameters.AddWithValue("@prof_username", LoggedInUsername)
                    Using reader = cmd.ExecuteReader
                        dtCategories.Load(reader)
                    End Using
                End Using
            End Using

            CategoriesDataGrid.Items.Clear()

            For Each row As DataRow In dtCategories.Rows
                Dim listViewItem As New ListViewItem(row(0).ToString)
                For i = 1 To dtCategories.Columns.Count - 1
                    listViewItem.SubItems.Add(row(i).ToString)
                Next
                CategoriesDataGrid.Items.Add(listViewItem)
            Next
        End If
    End Sub

    Private Sub ScRawScoreBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ScRawScoreBox.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            ScEnterBtn.PerformClick()
            ScScoreDataGrid.Focus()
            e.Handled = True ' para wala sound
        End If
    End Sub

    Private Sub ScScoreDataGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ScScoreDataGrid.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            ScRawScoreBox.Focus()
            e.Handled = True ' para wala sound
        End If
    End Sub

    Private Sub CatClrBtn_Click(sender As Object, e As EventArgs) Handles CatClrBtn.Click
        CatSearchCatNameBox.Clear()
        CatSelectedCourseIDBox.Clear()
        CatSelectedCourseBox.Clear()
        CatCategNameBox.Clear()
        CatCatPercentBox.Clear()
    End Sub

    Private Sub SubCatClrBtn_Click(sender As Object, e As EventArgs) Handles SubCatClrBtn.Click
        CatSubSearchSubBox.Clear()
        SubCatSelectedCourseIdBox.Clear()
        CatSubCatSubNameBox.Clear()
        CatSubCatNameBox.Clear()
        CatSubTotScoreBox.Clear()
        CatSelectTerm.SelectedIndex = -1
        CatSelectTerm.Text = ""
        CatSelectTerm.Refresh()
        CatSelectSem.SelectedIndex = -1
        CatSelectSem.Text = ""
        CatSelectSem.Refresh()
    End Sub

    Private Sub ClearEverythingBtn_Click(sender As Object, e As EventArgs) Handles ClearEverythingBtn.Click
        CatClrBtn.PerformClick()
        SubCatClrBtn.PerformClick()
        CatCoursesSearchForCoursesBox.Clear()
        CatCoursesSortByBox.SelectedIndex = -1
        CatCoursesSortByBox.Text = ""
        CatCoursesSortByBox.Refresh()
    End Sub

    Private Sub ScFilterByTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScFilterByTerm.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub ScFilterBySem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScFilterBySem.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub SubCatUpdateBtn_Click(sender As Object, e As EventArgs) Handles SubCatUpdateBtn.Click
        ' Check if a category is selected in the CategoriesDataGrid
        If CatSubDataGird.SelectedItems.Count = 0 Then
            MessageBox.Show("Error: Select a sub category first.")
            Return
        End If

        ' Check if any of the required textboxes are empty
        If String.IsNullOrEmpty(SubCatSelectedCourseIdBox.Text) OrElse
       String.IsNullOrEmpty(CatSubCatSubNameBox.Text) OrElse
       String.IsNullOrEmpty(CatSubCatNameBox.Text) OrElse
       String.IsNullOrEmpty(CatSubTotScoreBox.Text) Then
            MessageBox.Show("Error: Please fill in all the fields before updating.")
            Return
        End If

        Try
            ' Assuming Category ID and other data are retrieved from the selected row
            Dim categoryId As Integer = Convert.ToInt32(CatSubDataGird.SelectedItems(0).SubItems(2).Text) ' Get the category_id from the selected row
            Dim subCategoryId As Integer = Convert.ToInt32(CatSubDataGird.SelectedItems(0).SubItems(0).Text) ' Get the sub_category_id from the selected row
            Dim selectedTerm As String = If(CatSelectTerm.SelectedItem IsNot Nothing, CatSelectTerm.SelectedItem.ToString(), "")
            Dim selectedSem As String = If(CatSelectSem.SelectedItem IsNot Nothing, CatSelectSem.SelectedItem.ToString(), "")

            ' Your SQL logic to update the sub-category based on the provided data
            Using con As New MySqlConnection(MySqlString)
                con.Open()

                ' Update the sub_categories table with the new values
                Using cmd As New MySqlCommand("UPDATE sub_categories SET category_id = @category_id, sub_category_name = @sub_category_name, total_score = @total_score, term = @term, semester = @semester WHERE sub_category_id = @sub_category_id", con)
                    ' Add parameters to the SQL command
                    cmd.Parameters.AddWithValue("@category_id", categoryId) ' Use the category_id from the selected category
                    cmd.Parameters.AddWithValue("@sub_category_name", CatSubCatNameBox.Text) ' Subcategory name
                    cmd.Parameters.AddWithValue("@total_score", Convert.ToInt32(CatSubTotScoreBox.Text)) ' Total score
                    cmd.Parameters.AddWithValue("@term", selectedTerm) ' Selected term
                    cmd.Parameters.AddWithValue("@semester", selectedSem) ' Selected semester
                    cmd.Parameters.AddWithValue("@sub_category_id", subCategoryId) ' Subcategory ID (from selected row)

                    ' Execute the query
                    cmd.ExecuteNonQuery()
                End Using

                ' Now, update the scores table to reflect the changes in term and semester for the students enrolled in this sub-category
                Using getStudentsCmd As New MySqlCommand("SELECT student_id FROM enrollments WHERE course_id = @course_id", con)
                    getStudentsCmd.Parameters.AddWithValue("@course_id", SubCatSelectedCourseIdBox.Text)

                    Using reader As MySqlDataReader = getStudentsCmd.ExecuteReader()
                        Dim studentIds As New List(Of String)
                        While reader.Read()
                            studentIds.Add(reader("student_id").ToString())
                        End While
                        reader.Close()

                        ' Update scores for the selected term and semester
                        For Each studentId As String In studentIds
                            ' Check if a score entry exists for the selected student, sub_category, term, and semester
                            Using checkScoreCmd As New MySqlCommand("SELECT COUNT(*) FROM scores WHERE student_id = @student_id AND sub_category_id = @sub_category_id AND term = @term AND semester = @semester", con)
                                checkScoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                checkScoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                checkScoreCmd.Parameters.AddWithValue("@term", selectedTerm)
                                checkScoreCmd.Parameters.AddWithValue("@semester", selectedSem)

                                Dim exists As Boolean = Convert.ToInt32(checkScoreCmd.ExecuteScalar()) > 0

                                ' If no existing record, update the score entry for the student
                                If exists Then
                                    Using updateScoreCmd As New MySqlCommand("UPDATE scores SET term = @term, semester = @semester WHERE student_id = @student_id AND sub_category_id = @sub_category_id", con)
                                        updateScoreCmd.Parameters.AddWithValue("@term", selectedTerm)
                                        updateScoreCmd.Parameters.AddWithValue("@semester", selectedSem)
                                        updateScoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                        updateScoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                        updateScoreCmd.ExecuteNonQuery()
                                    End Using
                                Else
                                    ' If no score entry, insert a new one
                                    Using insertScoreCmd As New MySqlCommand("INSERT INTO scores (student_id, sub_category_id, score, term, semester) VALUES (@student_id, @sub_category_id, @score, @term, @semester)", con)
                                        insertScoreCmd.Parameters.AddWithValue("@student_id", studentId)
                                        insertScoreCmd.Parameters.AddWithValue("@sub_category_id", subCategoryId)
                                        insertScoreCmd.Parameters.AddWithValue("@score", 0) ' Default score
                                        insertScoreCmd.Parameters.AddWithValue("@term", selectedTerm)
                                        insertScoreCmd.Parameters.AddWithValue("@semester", selectedSem)
                                        insertScoreCmd.ExecuteNonQuery()
                                    End Using
                                End If
                            End Using
                        Next
                    End Using
                End Using
            End Using

            ' If the update is successful
            MessageBox.Show("Sub-category and scores updated successfully.")

            ' Optionally, refresh the relevant data grids or clear the form
            LoadCategories()
            LoadSubCateDataGrid()
            CatSubDataGird.Refresh()
            ApplyFilters()
            LoadFinalGrades()
            PopulateSubCategoryComboBox()
            PopulateSubCategories()

        Catch ex As Exception
            ' Handle any exceptions that occur
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub FinalGradeFilterBySection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FinalGradeFilterBySection.SelectedIndexChanged
        LoadFinalGrades()
    End Sub

    Private Sub SaveAsBtn_Click(sender As Object, e As EventArgs) Handles SaveAsBtn.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("Enter filename to create PDF!", vbExclamation)
        Else
            ' Create PdfPTable with number of columns in ListView
            Dim pdfTable As New PdfPTable(FinalGradeDataGrid.Columns.Count)
            pdfTable.DefaultCell.Padding = 3
            pdfTable.WidthPercentage = 85
            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
            pdfTable.DefaultCell.BorderWidth = 0

            ' Add header text with custom format
            Dim nameParagraph As New Paragraph("" & LoggedInUsername & " / " & FinalGradeDateLbl.Text & " / " & FinalGradeTimeLbl.Text & "", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12))
            nameParagraph.Alignment = iTextSharp.text.Element.ALIGN_LEFT

            ' Load logos as images
            Dim imagePath1 As String = "plp_logo\plplogo.jpg"
            Dim img1 As Image = Image.GetInstance(imagePath1)
            img1.ScaleAbsoluteWidth(20.0F)

            Dim imagePath2 As String = "plp_logo\ccslogo.png"
            Dim img2 As Image = Image.GetInstance(imagePath2)
            img2.ScaleAbsoluteWidth(20.0F)

            ' Create PdfPTable for images
            Dim imageTable As New PdfPTable(7)
            imageTable.TotalWidth = 900.0F
            imageTable.LockedWidth = True
            imageTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
            imageTable.DefaultCell.Border = 0
            imageTable.DefaultCell.PaddingTop = 50
            imageTable.DefaultCell.FixedHeight = 150.0F

            ' Add logos and other info
            imageTable.AddCell(img1)
            imageTable.AddCell(New PdfPCell() With {.Border = 0})
            imageTable.AddCell(New PdfPCell(New Phrase("Pamantasan ng Lungsod ng Pasig", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD))) With {.Colspan = 3, .HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, .PaddingTop = 70, .Border = 0})
            imageTable.AddCell(New PdfPCell() With {.Border = 0})
            imageTable.AddCell(img2)

            ' Set font size for table content
            Const FontSize As Integer = 14

            ' Set heading based on filters
            Dim heading As Paragraph
            If FinalGradeFilterBySection.SelectedIndex <> -1 Then
                heading = New Paragraph("Grade Reports" & vbCrLf & "Students of " & FinalGradeFilterBySection.SelectedItem.ToString, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD))
            Else
                heading = New Paragraph("Grade Reports" & vbCrLf & "Enrolled Students to You", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD))
            End If
            heading.Alignment = iTextSharp.text.Element.ALIGN_CENTER
            heading.SpacingBefore = 40
            pdfTable.SpacingBefore = 20

            ' Adding ListView header row
            For Each column As ColumnHeader In FinalGradeDataGrid.Columns
                pdfTable.AddCell(New PdfPCell(New Phrase(column.Text, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, FontSize))) With {.BackgroundColor = New iTextSharp.text.BaseColor(76, 175, 80)})
            Next

            ' Adding ListView data rows
            For Each item As ListViewItem In FinalGradeDataGrid.Items
                For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                    pdfTable.AddCell(New Phrase(subItem.Text, New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, FontSize)))
                Next
            Next

            ' Adding table title
            Dim tableTitle As New Paragraph("Report Cards of Students", New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD)) With {
                .SpacingBefore = 40,
                .SpacingAfter = 20,
                .Alignment = iTextSharp.text.Element.ALIGN_CENTER
            }

            ' Create PDF document and writer
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))

            ' Apply page number handler
            writer.PageEvent = New PageNumberEventHandler()

            pdfDoc.Open()
            pdfDoc.Add(nameParagraph)
            pdfDoc.Add(imageTable)
            pdfDoc.Add(heading)
            pdfDoc.Add(tableTitle)
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()

            MessageBox.Show("Successfully Saved!", "Online Registration System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShellExecute(IntPtr.Zero, "open", SaveFileDialog1.FileName + ".pdf", Nothing, Nothing, 1)
        End If
    End Sub
    Public Class PageNumberEventHandler
        Inherits PdfPageEventHelper

        Public Overrides Sub OnEndPage(ByVal writer As PdfWriter, ByVal document As Document)
            Dim pageNumber As String = "Page " & writer.PageNumber
            Dim font As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL)

            ' Position the page number at the bottom-center of the page
            Dim yPosition As Single = document.BottomMargin
            Dim xPosition As Single = (document.PageSize.Width - writer.GetVerticalPosition(True)) / 2

            ' Write the page number
            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, New Phrase(pageNumber, font), xPosition, yPosition, 0)
        End Sub
    End Class


    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (
ByVal hwnd As IntPtr,
ByVal lpOperation As String,
ByVal lpFile As String,
ByVal lpParameters As String,
ByVal lpDirectory As String,
ByVal nShowCmd As Integer
) As IntPtr
End Class