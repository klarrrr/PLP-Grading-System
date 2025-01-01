Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    ' MySQL Connection String
    Dim connectionString As String = "server=localhost; user=root; password=; database=grading_sys_db;"

    ' Dictionaries to Store Data
    Dim categoryScores As New Dictionary(Of String, List(Of Double))()
    Dim categoryTotalScores As New Dictionary(Of String, List(Of Double))()
    Dim categoryPercentages As New Dictionary(Of String, Double)()

    ' To Display Final Results
    Dim midterm1stSemGrade As Double
    Dim final1stSemGrade As Double
    Dim midterm2ndSemGrade As Double
    Dim final2ndSemGrade As Double
    Dim overallFinalGrade As Double

    ' Button to Trigger the Process
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear previous data
        categoryScores.Clear()
        categoryTotalScores.Clear()
        categoryPercentages.Clear()

        ' Fetch Data and Compute Scores
        FetchDataFromDatabase()
        ComputeGrades()
    End Sub

    ' Method to Fetch Data from MySQL Database
    Private Sub FetchDataFromDatabase()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT sc.category_id, c.category_name, sc.sub_category_name, s.score, sc.total_score, c.percent 
                                       FROM sub_categories sc
                                       JOIN scores s ON sc.sub_category_id = s.sub_category_id
                                       JOIN categories c ON sc.category_id = c.category_id"

                Dim cmd As New MySqlCommand(query, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim categoryName As String = reader("category_name").ToString()
                    Dim rawScore As Double = Convert.ToDouble(reader("score"))
                    Dim totalScore As Double = Convert.ToDouble(reader("total_score"))
                    Dim categoryPercent As Double = Convert.ToDouble(reader("percent"))

                    ' Initialize Dictionaries if Not Exists
                    If Not categoryScores.ContainsKey(categoryName) Then
                        categoryScores(categoryName) = New List(Of Double)
                        categoryTotalScores(categoryName) = New List(Of Double)
                        categoryPercentages(categoryName) = categoryPercent
                    End If

                    ' Add Scores to the Dictionaries
                    categoryScores(categoryName).Add(rawScore)
                    categoryTotalScores(categoryName).Add(totalScore)
                End While

            Catch ex As Exception
                MessageBox.Show("Error fetching data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Method to Compute Grades
    Private Sub ComputeGrades()
        Dim categoryResults As New Dictionary(Of String, Double)()
        Dim midtermGrade As Double = 0

        ' Step 1: Calculate Scores Per Category
        For Each category In categoryScores.Keys
            Dim totalRawScore As Double = categoryScores(category).Sum()
            Dim totalPossibleScore As Double = categoryTotalScores(category).Sum()

            ' Apply the Formula: raw score / total score * 50 + 50
            Dim categoryScore As Double = ((totalRawScore / totalPossibleScore) * 50) + 50

            ' Multiply by Percent: Score * (percent / 100)
            Dim weightedScore As Double = categoryScore * (categoryPercentages(category) / 100)

            ' Store the Results
            categoryResults(category) = Math.Round(weightedScore, 2)

            ' Summation for Midterm
            midtermGrade += weightedScore
        Next

        ' Display Category Results
        DisplayCategoryResults(categoryResults)

        ' Step 2: Finalize Midterm Grade
        midtermGrade = Math.Round(midtermGrade, 2)
        TextBox1.Text = "Midterm Grade: " & midtermGrade.ToString()

        ' Example: For finals, repeat the process with "finals" data
        ' To simplify, let's assume midtermGrade is 99.375 and finals is 86.50 for now.
        Dim finalsGrade As Double = 86.5 ' Example Final Grade

        ' Step 3: Calculate Overall Semester Grade
        Dim semesterGrade As Double = (midtermGrade + finalsGrade) / 2
        semesterGrade = Math.Round(semesterGrade, 2)

        ' Display Semester Grade
        TextBox2.Text = "Semester Grade: " & semesterGrade.ToString()

        ' Step 4: Overall Grade for Both Semesters (Example)
        Dim secondSemGrade As Double = 91.5 ' Example Second Semester Grade
        overallFinalGrade = (semesterGrade + secondSemGrade) / 2
        overallFinalGrade = Math.Round(overallFinalGrade, 2)

        ' Display Overall Final Grade
        TextBox3.Text = "Final Overall Grade: " & overallFinalGrade.ToString()
    End Sub

    ' Method to Display Results in a MessageBox or Labels
    Private Sub DisplayCategoryResults(results As Dictionary(Of String, Double))
        Dim output As String = "Category Results:" & Environment.NewLine
        For Each category In results.Keys
            output &= category & ": " & results(category).ToString("0.00") & Environment.NewLine
        Next
        MessageBox.Show(output, "Category Scores")
    End Sub
End Class