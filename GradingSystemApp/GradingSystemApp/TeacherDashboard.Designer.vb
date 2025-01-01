<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherDashboard
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherDashboard))
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Categories = New TabPage()
        CatTopPanel = New MaterialSkin.Controls.MaterialCard()
        CatProfLbl = New MaterialSkin.Controls.MaterialLabel()
        CatDateLbl = New MaterialSkin.Controls.MaterialLabel()
        CatTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel16 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox3 = New PictureBox()
        MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        CatSelectedCourseIDBox = New MaterialSkin.Controls.MaterialTextBox()
        CatClrBtn = New MaterialSkin.Controls.MaterialButton()
        CatSelectedCourseBox = New MaterialSkin.Controls.MaterialTextBox()
        CatCatPercentBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel17 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        CatDeleteBtn = New MaterialSkin.Controls.MaterialButton()
        CatSearchCatNameBox = New MaterialSkin.Controls.MaterialTextBox()
        CatUpdateBtn = New MaterialSkin.Controls.MaterialButton()
        CatCategNameBox = New MaterialSkin.Controls.MaterialTextBox()
        CatAddBtn = New MaterialSkin.Controls.MaterialButton()
        CategoriesDataGrid = New MaterialSkin.Controls.MaterialListView()
        CategID = New ColumnHeader()
        CourseID = New ColumnHeader()
        CategoryName = New ColumnHeader()
        Percent = New ColumnHeader()
        MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        SubCatCategoryIdBox = New MaterialSkin.Controls.MaterialTextBox()
        CatSelectSem = New MaterialSkin.Controls.MaterialComboBox()
        CatSelectTerm = New MaterialSkin.Controls.MaterialComboBox()
        SubCatSelectedCourseIdBox = New MaterialSkin.Controls.MaterialTextBox()
        SubCatClrBtn = New MaterialSkin.Controls.MaterialButton()
        CatSubCatSubNameBox = New MaterialSkin.Controls.MaterialTextBox()
        CatSubDataGird = New MaterialSkin.Controls.MaterialListView()
        SubCategID = New ColumnHeader()
        SubCatCourseID = New ColumnHeader()
        CategID2 = New ColumnHeader()
        SubCategName = New ColumnHeader()
        TotalScore = New ColumnHeader()
        ColumnHeader28 = New ColumnHeader()
        ColumnHeader29 = New ColumnHeader()
        MaterialLabel18 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        SubCatDelBtn = New MaterialSkin.Controls.MaterialButton()
        CatSubTotScoreBox = New MaterialSkin.Controls.MaterialTextBox()
        CatSubSearchSubBox = New MaterialSkin.Controls.MaterialTextBox()
        SubCatUpdateBtn = New MaterialSkin.Controls.MaterialButton()
        CatSubCatNameBox = New MaterialSkin.Controls.MaterialTextBox()
        SubCatAddBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        CatCoursesSortByBox = New MaterialSkin.Controls.MaterialComboBox()
        ClearEverythingBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel36 = New MaterialSkin.Controls.MaterialLabel()
        CatCourseDataGrid = New MaterialSkin.Controls.MaterialListView()
        CourseID2 = New ColumnHeader()
        CourseName2 = New ColumnHeader()
        CatCoursesSearchForCoursesBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Attendance = New TabPage()
        MaterialCard14 = New MaterialSkin.Controls.MaterialCard()
        DelAbsentBtn = New MaterialSkin.Controls.MaterialButton()
        DateTimePicker1 = New DateTimePicker()
        MaterialLabel61 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel62 = New MaterialSkin.Controls.MaterialLabel()
        PreviousAbsenteesDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader20 = New ColumnHeader()
        ColumnHeader15 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        ColumnHeader16 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader19 = New ColumnHeader()
        AttendanceFilterBySectionPreviousAbsentees = New MaterialSkin.Controls.MaterialComboBox()
        MaterialCard13 = New MaterialSkin.Controls.MaterialCard()
        AttenSelectSubCat = New MaterialSkin.Controls.MaterialComboBox()
        AttendanceReturnBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel59 = New MaterialSkin.Controls.MaterialLabel()
        SaveAttedanceBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel60 = New MaterialSkin.Controls.MaterialLabel()
        AbsentDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        MaterialCard16 = New MaterialSkin.Controls.MaterialCard()
        AttendanceChooseCourse = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel58 = New MaterialSkin.Controls.MaterialLabel()
        AttendanceFilterBySection = New MaterialSkin.Controls.MaterialComboBox()
        AttendanceDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        MaterialLabel45 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel57 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard15 = New MaterialSkin.Controls.MaterialCard()
        AttendanceProfLbl = New MaterialSkin.Controls.MaterialLabel()
        AttendanceDateLbl = New MaterialSkin.Controls.MaterialLabel()
        AttendanceTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel52 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox5 = New PictureBox()
        Scoring = New TabPage()
        MaterialCard12 = New MaterialSkin.Controls.MaterialCard()
        ScFilterBySem = New MaterialSkin.Controls.MaterialComboBox()
        ScFilterByTerm = New MaterialSkin.Controls.MaterialComboBox()
        ScClearBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel41 = New MaterialSkin.Controls.MaterialLabel()
        ScStudentNameBox = New MaterialSkin.Controls.MaterialTextBox()
        ScEnterBtn = New MaterialSkin.Controls.MaterialButton()
        ScRawScoreBox = New MaterialSkin.Controls.MaterialTextBox()
        ScSubCatNameBox = New MaterialSkin.Controls.MaterialTextBox()
        ScCatNameBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel40 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel37 = New MaterialSkin.Controls.MaterialLabel()
        ScCourseNameBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel48 = New MaterialSkin.Controls.MaterialLabel()
        ScTotalScoreBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel47 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel46 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel38 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel39 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel43 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        AttendanceFilterByCourse = New MaterialSkin.Controls.MaterialComboBox()
        ScFilterBySection = New MaterialSkin.Controls.MaterialComboBox()
        ScScoreDataGrid = New MaterialSkin.Controls.MaterialListView()
        ScScoreId = New ColumnHeader()
        ScStudentId = New ColumnHeader()
        ScFirstName = New ColumnHeader()
        ScLastName = New ColumnHeader()
        ScCourseName = New ColumnHeader()
        ScCategoryName = New ColumnHeader()
        ScSubCategoryName = New ColumnHeader()
        ScRawScore = New ColumnHeader()
        ScTotalScore = New ColumnHeader()
        ScGrade = New ColumnHeader()
        scTerm = New ColumnHeader()
        ScSemestr = New ColumnHeader()
        ScFilterBySubCat = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel32 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel33 = New MaterialSkin.Controls.MaterialLabel()
        ScoringSearchStudentsBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        ScoringProfLbl = New MaterialSkin.Controls.MaterialLabel()
        ScoringDateLbl = New MaterialSkin.Controls.MaterialLabel()
        ScoringTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox1 = New PictureBox()
        Grading = New TabPage()
        MaterialCard18 = New MaterialSkin.Controls.MaterialCard()
        SaveAsBtn = New MaterialSkin.Controls.MaterialButton()
        FinalGradeFilterBySection = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel42 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel44 = New MaterialSkin.Controls.MaterialLabel()
        FinalGradeDataGrid = New MaterialSkin.Controls.MaterialListView()
        GStudentId = New ColumnHeader()
        GFirstName = New ColumnHeader()
        GLastName = New ColumnHeader()
        GCourseName = New ColumnHeader()
        ColumnHeader27 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader17 = New ColumnHeader()
        ColumnHeader18 = New ColumnHeader()
        ColumnHeader22 = New ColumnHeader()
        ColumnHeader23 = New ColumnHeader()
        ColumnHeader24 = New ColumnHeader()
        ColumnHeader25 = New ColumnHeader()
        PointGrader = New ColumnHeader()
        MaterialCard17 = New MaterialSkin.Controls.MaterialCard()
        FinalGradeProfLbl = New MaterialSkin.Controls.MaterialLabel()
        FinalGradeDateLbl = New MaterialSkin.Controls.MaterialLabel()
        FinalGradeTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel56 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox6 = New PictureBox()
        Settings = New TabPage()
        MaterialCard10 = New MaterialSkin.Controls.MaterialCard()
        DarkModeSwitch = New MaterialSkin.Controls.MaterialSwitch()
        MaterialLabel31 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel30 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel29 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel27 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel26 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel25 = New MaterialSkin.Controls.MaterialLabel()
        ProfUpdateBtn = New MaterialSkin.Controls.MaterialButton()
        ProfPassword = New MaterialSkin.Controls.MaterialTextBox()
        ProfUsername = New MaterialSkin.Controls.MaterialTextBox()
        ProfEmail = New MaterialSkin.Controls.MaterialTextBox()
        ProfMiddleName = New MaterialSkin.Controls.MaterialTextBox()
        ProfLastName = New MaterialSkin.Controls.MaterialTextBox()
        ProfFirstName = New MaterialSkin.Controls.MaterialTextBox()
        MaterialCard9 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel23 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel24 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        SettingsProfLbl = New MaterialSkin.Controls.MaterialLabel()
        SettingsDateLbl = New MaterialSkin.Controls.MaterialLabel()
        SettingsTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel22 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox4 = New PictureBox()
        SignOut = New TabPage()
        MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        SignOutCancel = New MaterialSkin.Controls.MaterialButton()
        SignOutYes = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel14 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel15 = New MaterialSkin.Controls.MaterialLabel()
        ImageList1 = New ImageList(components)
        MaterialCheckbox1 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialCheckbox2 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialCheckbox3 = New MaterialSkin.Controls.MaterialCheckbox()
        Timer1 = New Timer(components)
        SaveFileDialog1 = New SaveFileDialog()
        MaterialTabControl1.SuspendLayout()
        Categories.SuspendLayout()
        CatTopPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MaterialCard4.SuspendLayout()
        MaterialCard5.SuspendLayout()
        MaterialCard2.SuspendLayout()
        Attendance.SuspendLayout()
        MaterialCard14.SuspendLayout()
        MaterialCard13.SuspendLayout()
        MaterialCard16.SuspendLayout()
        MaterialCard15.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Scoring.SuspendLayout()
        MaterialCard12.SuspendLayout()
        MaterialCard3.SuspendLayout()
        MaterialCard6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Grading.SuspendLayout()
        MaterialCard18.SuspendLayout()
        MaterialCard17.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Settings.SuspendLayout()
        MaterialCard10.SuspendLayout()
        MaterialCard9.SuspendLayout()
        MaterialCard8.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SignOut.SuspendLayout()
        MaterialCard7.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.Alignment = TabAlignment.Left
        MaterialTabControl1.Controls.Add(Categories)
        MaterialTabControl1.Controls.Add(Attendance)
        MaterialTabControl1.Controls.Add(Scoring)
        MaterialTabControl1.Controls.Add(Grading)
        MaterialTabControl1.Controls.Add(Settings)
        MaterialTabControl1.Controls.Add(SignOut)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.Dock = DockStyle.Fill
        MaterialTabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MaterialTabControl1.ImageList = ImageList1
        MaterialTabControl1.ItemSize = New Size(50, 25)
        MaterialTabControl1.Location = New Point(3, 64)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(1914, 1013)
        MaterialTabControl1.TabIndex = 14
        ' 
        ' Categories
        ' 
        Categories.Controls.Add(CatTopPanel)
        Categories.Controls.Add(MaterialCard4)
        Categories.Controls.Add(MaterialCard5)
        Categories.Controls.Add(MaterialCard2)
        Categories.ImageKey = "categorization (1).png"
        Categories.Location = New Point(29, 4)
        Categories.Name = "Categories"
        Categories.Padding = New Padding(0, 0, 60, 0)
        Categories.Size = New Size(1881, 1005)
        Categories.TabIndex = 2
        Categories.Text = "Categories"
        Categories.UseVisualStyleBackColor = True
        ' 
        ' CatTopPanel
        ' 
        CatTopPanel.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CatTopPanel.Controls.Add(CatProfLbl)
        CatTopPanel.Controls.Add(CatDateLbl)
        CatTopPanel.Controls.Add(CatTimeLbl)
        CatTopPanel.Controls.Add(MaterialLabel16)
        CatTopPanel.Controls.Add(PictureBox3)
        CatTopPanel.Depth = 0
        CatTopPanel.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        CatTopPanel.Location = New Point(14, 14)
        CatTopPanel.Margin = New Padding(14)
        CatTopPanel.MouseState = MaterialSkin.MouseState.HOVER
        CatTopPanel.Name = "CatTopPanel"
        CatTopPanel.Padding = New Padding(30)
        CatTopPanel.Size = New Size(1828, 110)
        CatTopPanel.TabIndex = 11
        ' 
        ' CatProfLbl
        ' 
        CatProfLbl.AutoSize = True
        CatProfLbl.Depth = 0
        CatProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        CatProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        CatProfLbl.Location = New Point(1531, 24)
        CatProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        CatProfLbl.Name = "CatProfLbl"
        CatProfLbl.Size = New Size(264, 24)
        CatProfLbl.TabIndex = 7
        CatProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' CatDateLbl
        ' 
        CatDateLbl.AutoSize = True
        CatDateLbl.Depth = 0
        CatDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatDateLbl.Location = New Point(1667, 48)
        CatDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        CatDateLbl.Name = "CatDateLbl"
        CatDateLbl.Size = New Size(128, 19)
        CatDateLbl.TabIndex = 6
        CatDateLbl.Text = "December 5, 2024"
        ' 
        ' CatTimeLbl
        ' 
        CatTimeLbl.AutoSize = True
        CatTimeLbl.Depth = 0
        CatTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatTimeLbl.Location = New Point(1754, 67)
        CatTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        CatTimeLbl.Name = "CatTimeLbl"
        CatTimeLbl.Size = New Size(41, 19)
        CatTimeLbl.TabIndex = 5
        CatTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel16
        ' 
        MaterialLabel16.AutoSize = True
        MaterialLabel16.Depth = 0
        MaterialLabel16.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel16.Location = New Point(487, 26)
        MaterialLabel16.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel16.Name = "MaterialLabel16"
        MaterialLabel16.Size = New Size(855, 58)
        MaterialLabel16.TabIndex = 1
        MaterialLabel16.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.PLP_logo1
        PictureBox3.Location = New Point(33, 30)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(CatSelectedCourseIDBox)
        MaterialCard4.Controls.Add(CatClrBtn)
        MaterialCard4.Controls.Add(CatSelectedCourseBox)
        MaterialCard4.Controls.Add(CatCatPercentBox)
        MaterialCard4.Controls.Add(MaterialLabel17)
        MaterialCard4.Controls.Add(MaterialLabel4)
        MaterialCard4.Controls.Add(MaterialLabel3)
        MaterialCard4.Controls.Add(CatDeleteBtn)
        MaterialCard4.Controls.Add(CatSearchCatNameBox)
        MaterialCard4.Controls.Add(CatUpdateBtn)
        MaterialCard4.Controls.Add(CatCategNameBox)
        MaterialCard4.Controls.Add(CatAddBtn)
        MaterialCard4.Controls.Add(CategoriesDataGrid)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(14, 148)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(30)
        MaterialCard4.Size = New Size(455, 847)
        MaterialCard4.TabIndex = 8
        ' 
        ' CatSelectedCourseIDBox
        ' 
        CatSelectedCourseIDBox.AnimateReadOnly = False
        CatSelectedCourseIDBox.BorderStyle = BorderStyle.None
        CatSelectedCourseIDBox.Depth = 0
        CatSelectedCourseIDBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatSelectedCourseIDBox.Hint = "Course ID"
        CatSelectedCourseIDBox.LeadingIcon = Nothing
        CatSelectedCourseIDBox.Location = New Point(34, 172)
        CatSelectedCourseIDBox.MaxLength = 50
        CatSelectedCourseIDBox.MouseState = MaterialSkin.MouseState.OUT
        CatSelectedCourseIDBox.Multiline = False
        CatSelectedCourseIDBox.Name = "CatSelectedCourseIDBox"
        CatSelectedCourseIDBox.Size = New Size(119, 50)
        CatSelectedCourseIDBox.TabIndex = 42
        CatSelectedCourseIDBox.Text = ""
        CatSelectedCourseIDBox.TrailingIcon = Nothing
        CatSelectedCourseIDBox.UseAccent = False
        ' 
        ' CatClrBtn
        ' 
        CatClrBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CatClrBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        CatClrBtn.Depth = 0
        CatClrBtn.HighEmphasis = True
        CatClrBtn.Icon = Nothing
        CatClrBtn.Location = New Point(355, 36)
        CatClrBtn.Margin = New Padding(4, 6, 4, 6)
        CatClrBtn.MouseState = MaterialSkin.MouseState.HOVER
        CatClrBtn.Name = "CatClrBtn"
        CatClrBtn.NoAccentTextColor = Color.Empty
        CatClrBtn.Size = New Size(66, 36)
        CatClrBtn.TabIndex = 41
        CatClrBtn.Text = "Clear"
        CatClrBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        CatClrBtn.UseAccentColor = True
        CatClrBtn.UseVisualStyleBackColor = True
        ' 
        ' CatSelectedCourseBox
        ' 
        CatSelectedCourseBox.AnimateReadOnly = False
        CatSelectedCourseBox.BorderStyle = BorderStyle.None
        CatSelectedCourseBox.Depth = 0
        CatSelectedCourseBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatSelectedCourseBox.Hint = "Selected Course Name"
        CatSelectedCourseBox.LeadingIcon = Nothing
        CatSelectedCourseBox.Location = New Point(159, 173)
        CatSelectedCourseBox.MaxLength = 50
        CatSelectedCourseBox.MouseState = MaterialSkin.MouseState.OUT
        CatSelectedCourseBox.Multiline = False
        CatSelectedCourseBox.Name = "CatSelectedCourseBox"
        CatSelectedCourseBox.Size = New Size(263, 50)
        CatSelectedCourseBox.TabIndex = 34
        CatSelectedCourseBox.Text = ""
        CatSelectedCourseBox.TrailingIcon = Nothing
        CatSelectedCourseBox.UseAccent = False
        ' 
        ' CatCatPercentBox
        ' 
        CatCatPercentBox.AnimateReadOnly = False
        CatCatPercentBox.BorderStyle = BorderStyle.None
        CatCatPercentBox.Depth = 0
        CatCatPercentBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatCatPercentBox.Hint = "Enter percentage"
        CatCatPercentBox.LeadingIcon = Nothing
        CatCatPercentBox.Location = New Point(35, 283)
        CatCatPercentBox.MaxLength = 50
        CatCatPercentBox.MouseState = MaterialSkin.MouseState.OUT
        CatCatPercentBox.Multiline = False
        CatCatPercentBox.Name = "CatCatPercentBox"
        CatCatPercentBox.Size = New Size(387, 50)
        CatCatPercentBox.TabIndex = 33
        CatCatPercentBox.Text = ""
        CatCatPercentBox.TrailingIcon = Nothing
        CatCatPercentBox.UseAccent = False
        ' 
        ' MaterialLabel17
        ' 
        MaterialLabel17.AutoSize = True
        MaterialLabel17.Depth = 0
        MaterialLabel17.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel17.Location = New Point(33, 738)
        MaterialLabel17.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel17.Name = "MaterialLabel17"
        MaterialLabel17.Size = New Size(59, 14)
        MaterialLabel17.TabIndex = 32
        MaterialLabel17.Text = "Categories"
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel4.Location = New Point(33, 71)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(100, 17)
        MaterialLabel4.TabIndex = 30
        MaterialLabel4.Text = "Add and modify"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel3.Location = New Point(33, 30)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(165, 41)
        MaterialLabel3.TabIndex = 29
        MaterialLabel3.Text = "Categories"
        ' 
        ' CatDeleteBtn
        ' 
        CatDeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CatDeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        CatDeleteBtn.Depth = 0
        CatDeleteBtn.HighEmphasis = True
        CatDeleteBtn.Icon = Nothing
        CatDeleteBtn.Location = New Point(34, 775)
        CatDeleteBtn.Margin = New Padding(4, 6, 4, 6)
        CatDeleteBtn.MouseState = MaterialSkin.MouseState.HOVER
        CatDeleteBtn.Name = "CatDeleteBtn"
        CatDeleteBtn.NoAccentTextColor = Color.Empty
        CatDeleteBtn.Size = New Size(73, 36)
        CatDeleteBtn.TabIndex = 28
        CatDeleteBtn.Text = "Delete"
        CatDeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        CatDeleteBtn.UseAccentColor = False
        CatDeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' CatSearchCatNameBox
        ' 
        CatSearchCatNameBox.AnimateReadOnly = False
        CatSearchCatNameBox.BorderStyle = BorderStyle.None
        CatSearchCatNameBox.Depth = 0
        CatSearchCatNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatSearchCatNameBox.Hint = "Search category name"
        CatSearchCatNameBox.LeadingIcon = My.Resources.Resources.magnifier
        CatSearchCatNameBox.Location = New Point(34, 118)
        CatSearchCatNameBox.MaxLength = 50
        CatSearchCatNameBox.MouseState = MaterialSkin.MouseState.OUT
        CatSearchCatNameBox.Multiline = False
        CatSearchCatNameBox.Name = "CatSearchCatNameBox"
        CatSearchCatNameBox.Size = New Size(388, 50)
        CatSearchCatNameBox.TabIndex = 27
        CatSearchCatNameBox.Text = ""
        CatSearchCatNameBox.TrailingIcon = Nothing
        CatSearchCatNameBox.UseAccent = False
        ' 
        ' CatUpdateBtn
        ' 
        CatUpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CatUpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        CatUpdateBtn.Depth = 0
        CatUpdateBtn.HighEmphasis = True
        CatUpdateBtn.Icon = Nothing
        CatUpdateBtn.Location = New Point(273, 775)
        CatUpdateBtn.Margin = New Padding(4, 6, 4, 6)
        CatUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER
        CatUpdateBtn.Name = "CatUpdateBtn"
        CatUpdateBtn.NoAccentTextColor = Color.Empty
        CatUpdateBtn.Size = New Size(77, 36)
        CatUpdateBtn.TabIndex = 25
        CatUpdateBtn.Text = "UPDATE"
        CatUpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        CatUpdateBtn.UseAccentColor = False
        CatUpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' CatCategNameBox
        ' 
        CatCategNameBox.AnimateReadOnly = False
        CatCategNameBox.BorderStyle = BorderStyle.None
        CatCategNameBox.Depth = 0
        CatCategNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatCategNameBox.Hint = "Category name"
        CatCategNameBox.LeadingIcon = Nothing
        CatCategNameBox.Location = New Point(35, 228)
        CatCategNameBox.MaxLength = 50
        CatCategNameBox.MouseState = MaterialSkin.MouseState.OUT
        CatCategNameBox.Multiline = False
        CatCategNameBox.Name = "CatCategNameBox"
        CatCategNameBox.Size = New Size(387, 50)
        CatCategNameBox.TabIndex = 24
        CatCategNameBox.Text = ""
        CatCategNameBox.TrailingIcon = Nothing
        CatCategNameBox.UseAccent = False
        ' 
        ' CatAddBtn
        ' 
        CatAddBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CatAddBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        CatAddBtn.Depth = 0
        CatAddBtn.HighEmphasis = True
        CatAddBtn.Icon = Nothing
        CatAddBtn.Location = New Point(358, 775)
        CatAddBtn.Margin = New Padding(4, 6, 4, 6)
        CatAddBtn.MouseState = MaterialSkin.MouseState.HOVER
        CatAddBtn.Name = "CatAddBtn"
        CatAddBtn.NoAccentTextColor = Color.Empty
        CatAddBtn.Size = New Size(64, 36)
        CatAddBtn.TabIndex = 23
        CatAddBtn.Text = "Add"
        CatAddBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        CatAddBtn.UseAccentColor = False
        CatAddBtn.UseVisualStyleBackColor = True
        ' 
        ' CategoriesDataGrid
        ' 
        CategoriesDataGrid.AllowColumnReorder = True
        CategoriesDataGrid.AutoSizeTable = False
        CategoriesDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CategoriesDataGrid.BorderStyle = BorderStyle.None
        CategoriesDataGrid.Columns.AddRange(New ColumnHeader() {CategID, CourseID, CategoryName, Percent})
        CategoriesDataGrid.Depth = 0
        CategoriesDataGrid.FullRowSelect = True
        CategoriesDataGrid.Location = New Point(33, 341)
        CategoriesDataGrid.MinimumSize = New Size(200, 100)
        CategoriesDataGrid.MouseLocation = New Point(-1, -1)
        CategoriesDataGrid.MouseState = MaterialSkin.MouseState.OUT
        CategoriesDataGrid.Name = "CategoriesDataGrid"
        CategoriesDataGrid.OwnerDraw = True
        CategoriesDataGrid.Size = New Size(389, 394)
        CategoriesDataGrid.TabIndex = 31
        CategoriesDataGrid.UseCompatibleStateImageBehavior = False
        CategoriesDataGrid.View = View.Details
        ' 
        ' CategID
        ' 
        CategID.Text = "ID"
        CategID.Width = 50
        ' 
        ' CourseID
        ' 
        CourseID.Text = "Course ID"
        CourseID.Width = 100
        ' 
        ' CategoryName
        ' 
        CategoryName.Text = "Category Name"
        CategoryName.Width = 150
        ' 
        ' Percent
        ' 
        Percent.Text = "Percent"
        Percent.Width = 150
        ' 
        ' MaterialCard5
        ' 
        MaterialCard5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard5.Controls.Add(SubCatCategoryIdBox)
        MaterialCard5.Controls.Add(CatSelectSem)
        MaterialCard5.Controls.Add(CatSelectTerm)
        MaterialCard5.Controls.Add(SubCatSelectedCourseIdBox)
        MaterialCard5.Controls.Add(SubCatClrBtn)
        MaterialCard5.Controls.Add(CatSubCatSubNameBox)
        MaterialCard5.Controls.Add(CatSubDataGird)
        MaterialCard5.Controls.Add(MaterialLabel18)
        MaterialCard5.Controls.Add(MaterialLabel5)
        MaterialCard5.Controls.Add(MaterialLabel6)
        MaterialCard5.Controls.Add(SubCatDelBtn)
        MaterialCard5.Controls.Add(CatSubTotScoreBox)
        MaterialCard5.Controls.Add(CatSubSearchSubBox)
        MaterialCard5.Controls.Add(SubCatUpdateBtn)
        MaterialCard5.Controls.Add(CatSubCatNameBox)
        MaterialCard5.Controls.Add(SubCatAddBtn)
        MaterialCard5.Depth = 0
        MaterialCard5.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard5.Location = New Point(497, 148)
        MaterialCard5.Margin = New Padding(14)
        MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard5.Name = "MaterialCard5"
        MaterialCard5.Padding = New Padding(30)
        MaterialCard5.Size = New Size(693, 847)
        MaterialCard5.TabIndex = 9
        ' 
        ' SubCatCategoryIdBox
        ' 
        SubCatCategoryIdBox.AnimateReadOnly = False
        SubCatCategoryIdBox.BorderStyle = BorderStyle.None
        SubCatCategoryIdBox.Depth = 0
        SubCatCategoryIdBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        SubCatCategoryIdBox.Hint = "Category ID"
        SubCatCategoryIdBox.LeadingIcon = Nothing
        SubCatCategoryIdBox.Location = New Point(33, 227)
        SubCatCategoryIdBox.MaxLength = 50
        SubCatCategoryIdBox.MouseState = MaterialSkin.MouseState.OUT
        SubCatCategoryIdBox.Multiline = False
        SubCatCategoryIdBox.Name = "SubCatCategoryIdBox"
        SubCatCategoryIdBox.Size = New Size(198, 50)
        SubCatCategoryIdBox.TabIndex = 46
        SubCatCategoryIdBox.Text = ""
        SubCatCategoryIdBox.TrailingIcon = Nothing
        SubCatCategoryIdBox.UseAccent = False
        ' 
        ' CatSelectSem
        ' 
        CatSelectSem.AutoResize = False
        CatSelectSem.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CatSelectSem.Depth = 0
        CatSelectSem.DrawMode = DrawMode.OwnerDrawVariable
        CatSelectSem.DropDownHeight = 174
        CatSelectSem.DropDownStyle = ComboBoxStyle.DropDownList
        CatSelectSem.DropDownWidth = 121
        CatSelectSem.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        CatSelectSem.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        CatSelectSem.FormattingEnabled = True
        CatSelectSem.Hint = "Select Sem"
        CatSelectSem.IntegralHeight = False
        CatSelectSem.ItemHeight = 43
        CatSelectSem.Items.AddRange(New Object() {"", "1st", "2nd"})
        CatSelectSem.Location = New Point(484, 283)
        CatSelectSem.MaxDropDownItems = 4
        CatSelectSem.MouseState = MaterialSkin.MouseState.OUT
        CatSelectSem.Name = "CatSelectSem"
        CatSelectSem.Size = New Size(176, 49)
        CatSelectSem.StartIndex = 0
        CatSelectSem.TabIndex = 45
        ' 
        ' CatSelectTerm
        ' 
        CatSelectTerm.AutoResize = False
        CatSelectTerm.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CatSelectTerm.Depth = 0
        CatSelectTerm.DrawMode = DrawMode.OwnerDrawVariable
        CatSelectTerm.DropDownHeight = 174
        CatSelectTerm.DropDownStyle = ComboBoxStyle.DropDownList
        CatSelectTerm.DropDownWidth = 121
        CatSelectTerm.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        CatSelectTerm.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        CatSelectTerm.FormattingEnabled = True
        CatSelectTerm.Hint = "Select Term"
        CatSelectTerm.IntegralHeight = False
        CatSelectTerm.ItemHeight = 43
        CatSelectTerm.Items.AddRange(New Object() {"", "midterm", "finals"})
        CatSelectTerm.Location = New Point(274, 283)
        CatSelectTerm.MaxDropDownItems = 4
        CatSelectTerm.MouseState = MaterialSkin.MouseState.OUT
        CatSelectTerm.Name = "CatSelectTerm"
        CatSelectTerm.Size = New Size(204, 49)
        CatSelectTerm.StartIndex = 0
        CatSelectTerm.TabIndex = 44
        ' 
        ' SubCatSelectedCourseIdBox
        ' 
        SubCatSelectedCourseIdBox.AnimateReadOnly = False
        SubCatSelectedCourseIdBox.BorderStyle = BorderStyle.None
        SubCatSelectedCourseIdBox.Depth = 0
        SubCatSelectedCourseIdBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        SubCatSelectedCourseIdBox.Hint = "Course ID"
        SubCatSelectedCourseIdBox.LeadingIcon = Nothing
        SubCatSelectedCourseIdBox.Location = New Point(33, 172)
        SubCatSelectedCourseIdBox.MaxLength = 50
        SubCatSelectedCourseIdBox.MouseState = MaterialSkin.MouseState.OUT
        SubCatSelectedCourseIdBox.Multiline = False
        SubCatSelectedCourseIdBox.Name = "SubCatSelectedCourseIdBox"
        SubCatSelectedCourseIdBox.Size = New Size(198, 50)
        SubCatSelectedCourseIdBox.TabIndex = 43
        SubCatSelectedCourseIdBox.Text = ""
        SubCatSelectedCourseIdBox.TrailingIcon = Nothing
        SubCatSelectedCourseIdBox.UseAccent = False
        ' 
        ' SubCatClrBtn
        ' 
        SubCatClrBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SubCatClrBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SubCatClrBtn.Depth = 0
        SubCatClrBtn.HighEmphasis = True
        SubCatClrBtn.Icon = Nothing
        SubCatClrBtn.Location = New Point(593, 36)
        SubCatClrBtn.Margin = New Padding(4, 6, 4, 6)
        SubCatClrBtn.MouseState = MaterialSkin.MouseState.HOVER
        SubCatClrBtn.Name = "SubCatClrBtn"
        SubCatClrBtn.NoAccentTextColor = Color.Empty
        SubCatClrBtn.Size = New Size(66, 36)
        SubCatClrBtn.TabIndex = 42
        SubCatClrBtn.Text = "Clear"
        SubCatClrBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SubCatClrBtn.UseAccentColor = True
        SubCatClrBtn.UseVisualStyleBackColor = True
        ' 
        ' CatSubCatSubNameBox
        ' 
        CatSubCatSubNameBox.AnimateReadOnly = False
        CatSubCatSubNameBox.BorderStyle = BorderStyle.None
        CatSubCatSubNameBox.Depth = 0
        CatSubCatSubNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatSubCatSubNameBox.Hint = "Selected Category Name"
        CatSubCatSubNameBox.LeadingIcon = Nothing
        CatSubCatSubNameBox.Location = New Point(237, 173)
        CatSubCatSubNameBox.MaxLength = 50
        CatSubCatSubNameBox.MouseState = MaterialSkin.MouseState.OUT
        CatSubCatSubNameBox.Multiline = False
        CatSubCatSubNameBox.Name = "CatSubCatSubNameBox"
        CatSubCatSubNameBox.Size = New Size(423, 50)
        CatSubCatSubNameBox.TabIndex = 38
        CatSubCatSubNameBox.Text = ""
        CatSubCatSubNameBox.TrailingIcon = Nothing
        CatSubCatSubNameBox.UseAccent = False
        ' 
        ' CatSubDataGird
        ' 
        CatSubDataGird.AllowColumnReorder = True
        CatSubDataGird.AutoSizeTable = False
        CatSubDataGird.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CatSubDataGird.BorderStyle = BorderStyle.None
        CatSubDataGird.Columns.AddRange(New ColumnHeader() {SubCategID, SubCatCourseID, CategID2, SubCategName, TotalScore, ColumnHeader28, ColumnHeader29})
        CatSubDataGird.Depth = 0
        CatSubDataGird.FullRowSelect = True
        CatSubDataGird.Location = New Point(32, 341)
        CatSubDataGird.MinimumSize = New Size(200, 100)
        CatSubDataGird.MouseLocation = New Point(-1, -1)
        CatSubDataGird.MouseState = MaterialSkin.MouseState.OUT
        CatSubDataGird.Name = "CatSubDataGird"
        CatSubDataGird.OwnerDraw = True
        CatSubDataGird.Size = New Size(628, 394)
        CatSubDataGird.TabIndex = 37
        CatSubDataGird.UseCompatibleStateImageBehavior = False
        CatSubDataGird.View = View.Details
        ' 
        ' SubCategID
        ' 
        SubCategID.Text = "ID"
        SubCategID.Width = 50
        ' 
        ' SubCatCourseID
        ' 
        SubCatCourseID.Text = "Course ID"
        SubCatCourseID.Width = 90
        ' 
        ' CategID2
        ' 
        CategID2.Text = "Categ ID"
        CategID2.Width = 90
        ' 
        ' SubCategName
        ' 
        SubCategName.Text = "SubCateg Name"
        SubCategName.Width = 140
        ' 
        ' TotalScore
        ' 
        TotalScore.Text = "Total Score"
        TotalScore.Width = 105
        ' 
        ' ColumnHeader28
        ' 
        ColumnHeader28.Text = "Term"
        ColumnHeader28.Width = 70
        ' 
        ' ColumnHeader29
        ' 
        ColumnHeader29.Text = "Sem"
        ' 
        ' MaterialLabel18
        ' 
        MaterialLabel18.AutoSize = True
        MaterialLabel18.Depth = 0
        MaterialLabel18.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel18.Location = New Point(33, 738)
        MaterialLabel18.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel18.Name = "MaterialLabel18"
        MaterialLabel18.Size = New Size(83, 14)
        MaterialLabel18.TabIndex = 36
        MaterialLabel18.Text = "Sub Categories"
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel5.Location = New Point(33, 71)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(100, 17)
        MaterialLabel5.TabIndex = 35
        MaterialLabel5.Text = "Add and modify"
        ' 
        ' MaterialLabel6
        ' 
        MaterialLabel6.AutoSize = True
        MaterialLabel6.Depth = 0
        MaterialLabel6.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel6.Location = New Point(33, 30)
        MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel6.Name = "MaterialLabel6"
        MaterialLabel6.Size = New Size(227, 41)
        MaterialLabel6.TabIndex = 34
        MaterialLabel6.Text = "Sub categories"
        ' 
        ' SubCatDelBtn
        ' 
        SubCatDelBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SubCatDelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SubCatDelBtn.Depth = 0
        SubCatDelBtn.HighEmphasis = True
        SubCatDelBtn.Icon = Nothing
        SubCatDelBtn.Location = New Point(33, 775)
        SubCatDelBtn.Margin = New Padding(4, 6, 4, 6)
        SubCatDelBtn.MouseState = MaterialSkin.MouseState.HOVER
        SubCatDelBtn.Name = "SubCatDelBtn"
        SubCatDelBtn.NoAccentTextColor = Color.Empty
        SubCatDelBtn.Size = New Size(73, 36)
        SubCatDelBtn.TabIndex = 33
        SubCatDelBtn.Text = "Delete"
        SubCatDelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SubCatDelBtn.UseAccentColor = False
        SubCatDelBtn.UseVisualStyleBackColor = True
        ' 
        ' CatSubTotScoreBox
        ' 
        CatSubTotScoreBox.AnimateReadOnly = False
        CatSubTotScoreBox.BorderStyle = BorderStyle.None
        CatSubTotScoreBox.Depth = 0
        CatSubTotScoreBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatSubTotScoreBox.Hint = "Total score"
        CatSubTotScoreBox.LeadingIcon = Nothing
        CatSubTotScoreBox.Location = New Point(32, 283)
        CatSubTotScoreBox.MaxLength = 50
        CatSubTotScoreBox.MouseState = MaterialSkin.MouseState.OUT
        CatSubTotScoreBox.Multiline = False
        CatSubTotScoreBox.Name = "CatSubTotScoreBox"
        CatSubTotScoreBox.Size = New Size(236, 50)
        CatSubTotScoreBox.TabIndex = 32
        CatSubTotScoreBox.Text = ""
        CatSubTotScoreBox.TrailingIcon = Nothing
        CatSubTotScoreBox.UseAccent = False
        ' 
        ' CatSubSearchSubBox
        ' 
        CatSubSearchSubBox.AnimateReadOnly = False
        CatSubSearchSubBox.BorderStyle = BorderStyle.None
        CatSubSearchSubBox.Depth = 0
        CatSubSearchSubBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatSubSearchSubBox.Hint = "Search sub category name"
        CatSubSearchSubBox.LeadingIcon = My.Resources.Resources.magnifier
        CatSubSearchSubBox.Location = New Point(33, 118)
        CatSubSearchSubBox.MaxLength = 50
        CatSubSearchSubBox.MouseState = MaterialSkin.MouseState.OUT
        CatSubSearchSubBox.Multiline = False
        CatSubSearchSubBox.Name = "CatSubSearchSubBox"
        CatSubSearchSubBox.Size = New Size(627, 50)
        CatSubSearchSubBox.TabIndex = 31
        CatSubSearchSubBox.Text = ""
        CatSubSearchSubBox.TrailingIcon = Nothing
        CatSubSearchSubBox.UseAccent = False
        ' 
        ' SubCatUpdateBtn
        ' 
        SubCatUpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SubCatUpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SubCatUpdateBtn.Depth = 0
        SubCatUpdateBtn.HighEmphasis = True
        SubCatUpdateBtn.Icon = Nothing
        SubCatUpdateBtn.Location = New Point(508, 775)
        SubCatUpdateBtn.Margin = New Padding(4, 6, 4, 6)
        SubCatUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER
        SubCatUpdateBtn.Name = "SubCatUpdateBtn"
        SubCatUpdateBtn.NoAccentTextColor = Color.Empty
        SubCatUpdateBtn.Size = New Size(77, 36)
        SubCatUpdateBtn.TabIndex = 29
        SubCatUpdateBtn.Text = "UPDATE"
        SubCatUpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SubCatUpdateBtn.UseAccentColor = False
        SubCatUpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' CatSubCatNameBox
        ' 
        CatSubCatNameBox.AnimateReadOnly = False
        CatSubCatNameBox.BorderStyle = BorderStyle.None
        CatSubCatNameBox.Depth = 0
        CatSubCatNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatSubCatNameBox.Hint = "Sub category name"
        CatSubCatNameBox.LeadingIcon = Nothing
        CatSubCatNameBox.Location = New Point(237, 228)
        CatSubCatNameBox.MaxLength = 50
        CatSubCatNameBox.MouseState = MaterialSkin.MouseState.OUT
        CatSubCatNameBox.Multiline = False
        CatSubCatNameBox.Name = "CatSubCatNameBox"
        CatSubCatNameBox.Size = New Size(424, 50)
        CatSubCatNameBox.TabIndex = 28
        CatSubCatNameBox.Text = ""
        CatSubCatNameBox.TrailingIcon = Nothing
        CatSubCatNameBox.UseAccent = False
        ' 
        ' SubCatAddBtn
        ' 
        SubCatAddBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SubCatAddBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SubCatAddBtn.Depth = 0
        SubCatAddBtn.HighEmphasis = True
        SubCatAddBtn.Icon = Nothing
        SubCatAddBtn.Location = New Point(593, 775)
        SubCatAddBtn.Margin = New Padding(4, 6, 4, 6)
        SubCatAddBtn.MouseState = MaterialSkin.MouseState.HOVER
        SubCatAddBtn.Name = "SubCatAddBtn"
        SubCatAddBtn.NoAccentTextColor = Color.Empty
        SubCatAddBtn.Size = New Size(64, 36)
        SubCatAddBtn.TabIndex = 27
        SubCatAddBtn.Text = "Add"
        SubCatAddBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SubCatAddBtn.UseAccentColor = False
        SubCatAddBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(CatCoursesSortByBox)
        MaterialCard2.Controls.Add(ClearEverythingBtn)
        MaterialCard2.Controls.Add(MaterialLabel36)
        MaterialCard2.Controls.Add(CatCourseDataGrid)
        MaterialCard2.Controls.Add(CatCoursesSearchForCoursesBox)
        MaterialCard2.Controls.Add(MaterialLabel2)
        MaterialCard2.Controls.Add(MaterialLabel1)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(1218, 148)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(30)
        MaterialCard2.Size = New Size(624, 847)
        MaterialCard2.TabIndex = 10
        ' 
        ' CatCoursesSortByBox
        ' 
        CatCoursesSortByBox.AutoResize = False
        CatCoursesSortByBox.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CatCoursesSortByBox.Depth = 0
        CatCoursesSortByBox.DrawMode = DrawMode.OwnerDrawVariable
        CatCoursesSortByBox.DropDownHeight = 174
        CatCoursesSortByBox.DropDownStyle = ComboBoxStyle.DropDownList
        CatCoursesSortByBox.DropDownWidth = 121
        CatCoursesSortByBox.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        CatCoursesSortByBox.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        CatCoursesSortByBox.FormattingEnabled = True
        CatCoursesSortByBox.Hint = "Sort courses by"
        CatCoursesSortByBox.IntegralHeight = False
        CatCoursesSortByBox.ItemHeight = 43
        CatCoursesSortByBox.Items.AddRange(New Object() {"Course ID", "Course Name"})
        CatCoursesSortByBox.Location = New Point(434, 118)
        CatCoursesSortByBox.MaxDropDownItems = 4
        CatCoursesSortByBox.MouseState = MaterialSkin.MouseState.OUT
        CatCoursesSortByBox.Name = "CatCoursesSortByBox"
        CatCoursesSortByBox.Size = New Size(157, 49)
        CatCoursesSortByBox.StartIndex = 0
        CatCoursesSortByBox.TabIndex = 41
        ' 
        ' ClearEverythingBtn
        ' 
        ClearEverythingBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClearEverythingBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ClearEverythingBtn.Depth = 0
        ClearEverythingBtn.HighEmphasis = True
        ClearEverythingBtn.Icon = Nothing
        ClearEverythingBtn.Location = New Point(431, 775)
        ClearEverythingBtn.Margin = New Padding(4, 6, 4, 6)
        ClearEverythingBtn.MouseState = MaterialSkin.MouseState.HOVER
        ClearEverythingBtn.Name = "ClearEverythingBtn"
        ClearEverythingBtn.NoAccentTextColor = Color.Empty
        ClearEverythingBtn.Size = New Size(159, 36)
        ClearEverythingBtn.TabIndex = 40
        ClearEverythingBtn.Text = "Clear Everything"
        ClearEverythingBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ClearEverythingBtn.UseAccentColor = True
        ClearEverythingBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel36
        ' 
        MaterialLabel36.AutoSize = True
        MaterialLabel36.Depth = 0
        MaterialLabel36.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel36.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel36.Location = New Point(33, 738)
        MaterialLabel36.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel36.Name = "MaterialLabel36"
        MaterialLabel36.Size = New Size(45, 14)
        MaterialLabel36.TabIndex = 39
        MaterialLabel36.Text = "Courses"
        ' 
        ' CatCourseDataGrid
        ' 
        CatCourseDataGrid.AllowColumnReorder = True
        CatCourseDataGrid.AutoSizeTable = False
        CatCourseDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        CatCourseDataGrid.BorderStyle = BorderStyle.None
        CatCourseDataGrid.Columns.AddRange(New ColumnHeader() {CourseID2, CourseName2})
        CatCourseDataGrid.Depth = 0
        CatCourseDataGrid.FullRowSelect = True
        CatCourseDataGrid.Location = New Point(33, 174)
        CatCourseDataGrid.MinimumSize = New Size(200, 100)
        CatCourseDataGrid.MouseLocation = New Point(-1, -1)
        CatCourseDataGrid.MouseState = MaterialSkin.MouseState.OUT
        CatCourseDataGrid.Name = "CatCourseDataGrid"
        CatCourseDataGrid.OwnerDraw = True
        CatCourseDataGrid.Size = New Size(558, 561)
        CatCourseDataGrid.TabIndex = 38
        CatCourseDataGrid.UseCompatibleStateImageBehavior = False
        CatCourseDataGrid.View = View.Details
        ' 
        ' CourseID2
        ' 
        CourseID2.Text = "Course ID"
        CourseID2.Width = 270
        ' 
        ' CourseName2
        ' 
        CourseName2.Text = "Course Name"
        CourseName2.Width = 270
        ' 
        ' CatCoursesSearchForCoursesBox
        ' 
        CatCoursesSearchForCoursesBox.AnimateReadOnly = False
        CatCoursesSearchForCoursesBox.BorderStyle = BorderStyle.None
        CatCoursesSearchForCoursesBox.Depth = 0
        CatCoursesSearchForCoursesBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        CatCoursesSearchForCoursesBox.Hint = "Search for your courses"
        CatCoursesSearchForCoursesBox.LeadingIcon = My.Resources.Resources.magnifier
        CatCoursesSearchForCoursesBox.Location = New Point(33, 118)
        CatCoursesSearchForCoursesBox.MaxLength = 50
        CatCoursesSearchForCoursesBox.MouseState = MaterialSkin.MouseState.OUT
        CatCoursesSearchForCoursesBox.Multiline = False
        CatCoursesSearchForCoursesBox.Name = "CatCoursesSearchForCoursesBox"
        CatCoursesSearchForCoursesBox.Size = New Size(395, 50)
        CatCoursesSearchForCoursesBox.TabIndex = 32
        CatCoursesSearchForCoursesBox.Text = ""
        CatCoursesSearchForCoursesBox.TrailingIcon = Nothing
        CatCoursesSearchForCoursesBox.UseAccent = False
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel2.Location = New Point(33, 73)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(145, 17)
        MaterialLabel2.TabIndex = 1
        MaterialLabel2.Text = "Your assigned courses"
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel1.Location = New Point(33, 30)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(127, 41)
        MaterialLabel1.TabIndex = 0
        MaterialLabel1.Text = "Courses"
        ' 
        ' Attendance
        ' 
        Attendance.Controls.Add(MaterialCard14)
        Attendance.Controls.Add(MaterialCard13)
        Attendance.Controls.Add(MaterialCard16)
        Attendance.Controls.Add(MaterialCard15)
        Attendance.ImageKey = "user (1) (1).png"
        Attendance.Location = New Point(29, 4)
        Attendance.Name = "Attendance"
        Attendance.Size = New Size(1881, 1005)
        Attendance.TabIndex = 5
        Attendance.Text = "Attendance"
        Attendance.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard14
        ' 
        MaterialCard14.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard14.Controls.Add(DelAbsentBtn)
        MaterialCard14.Controls.Add(DateTimePicker1)
        MaterialCard14.Controls.Add(MaterialLabel61)
        MaterialCard14.Controls.Add(MaterialLabel62)
        MaterialCard14.Controls.Add(PreviousAbsenteesDataGrid)
        MaterialCard14.Controls.Add(AttendanceFilterBySectionPreviousAbsentees)
        MaterialCard14.Depth = 0
        MaterialCard14.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard14.Location = New Point(794, 552)
        MaterialCard14.Margin = New Padding(14)
        MaterialCard14.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard14.Name = "MaterialCard14"
        MaterialCard14.Padding = New Padding(30)
        MaterialCard14.Size = New Size(1045, 439)
        MaterialCard14.TabIndex = 14
        ' 
        ' DelAbsentBtn
        ' 
        DelAbsentBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        DelAbsentBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        DelAbsentBtn.Depth = 0
        DelAbsentBtn.HighEmphasis = True
        DelAbsentBtn.Icon = Nothing
        DelAbsentBtn.Location = New Point(931, 36)
        DelAbsentBtn.Margin = New Padding(4, 6, 4, 6)
        DelAbsentBtn.MouseState = MaterialSkin.MouseState.HOVER
        DelAbsentBtn.Name = "DelAbsentBtn"
        DelAbsentBtn.NoAccentTextColor = Color.Empty
        DelAbsentBtn.Size = New Size(80, 36)
        DelAbsentBtn.TabIndex = 62
        DelAbsentBtn.Text = "Remove"
        DelAbsentBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        DelAbsentBtn.UseAccentColor = False
        DelAbsentBtn.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Roboto", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(394, 45)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 34)
        DateTimePicker1.TabIndex = 49
        ' 
        ' MaterialLabel61
        ' 
        MaterialLabel61.AutoSize = True
        MaterialLabel61.Depth = 0
        MaterialLabel61.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel61.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel61.Location = New Point(33, 71)
        MaterialLabel61.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel61.Name = "MaterialLabel61"
        MaterialLabel61.Size = New Size(69, 17)
        MaterialLabel61.TabIndex = 48
        MaterialLabel61.Text = "Absentees"
        ' 
        ' MaterialLabel62
        ' 
        MaterialLabel62.AutoSize = True
        MaterialLabel62.Depth = 0
        MaterialLabel62.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel62.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel62.Location = New Point(33, 30)
        MaterialLabel62.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel62.Name = "MaterialLabel62"
        MaterialLabel62.Size = New Size(298, 41)
        MaterialLabel62.TabIndex = 47
        MaterialLabel62.Text = "Previous absentees"
        ' 
        ' PreviousAbsenteesDataGrid
        ' 
        PreviousAbsenteesDataGrid.AutoSizeTable = False
        PreviousAbsenteesDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        PreviousAbsenteesDataGrid.BorderStyle = BorderStyle.None
        PreviousAbsenteesDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader20, ColumnHeader15, ColumnHeader13, ColumnHeader14, ColumnHeader16, ColumnHeader5, ColumnHeader19})
        PreviousAbsenteesDataGrid.Depth = 0
        PreviousAbsenteesDataGrid.Dock = DockStyle.Bottom
        PreviousAbsenteesDataGrid.FullRowSelect = True
        PreviousAbsenteesDataGrid.Location = New Point(30, 99)
        PreviousAbsenteesDataGrid.Margin = New Padding(14)
        PreviousAbsenteesDataGrid.MinimumSize = New Size(200, 100)
        PreviousAbsenteesDataGrid.MouseLocation = New Point(-1, -1)
        PreviousAbsenteesDataGrid.MouseState = MaterialSkin.MouseState.OUT
        PreviousAbsenteesDataGrid.Name = "PreviousAbsenteesDataGrid"
        PreviousAbsenteesDataGrid.OwnerDraw = True
        PreviousAbsenteesDataGrid.Size = New Size(985, 310)
        PreviousAbsenteesDataGrid.TabIndex = 46
        PreviousAbsenteesDataGrid.UseCompatibleStateImageBehavior = False
        PreviousAbsenteesDataGrid.View = View.Details
        ' 
        ' ColumnHeader20
        ' 
        ColumnHeader20.Text = "Absent ID"
        ColumnHeader20.Width = 110
        ' 
        ' ColumnHeader15
        ' 
        ColumnHeader15.Text = "Stud ID"
        ColumnHeader15.Width = 150
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "First Name"
        ColumnHeader13.Width = 150
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.Text = "Last Name"
        ColumnHeader14.Width = 150
        ' 
        ' ColumnHeader16
        ' 
        ColumnHeader16.Text = "Section"
        ColumnHeader16.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Course ID"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader19
        ' 
        ColumnHeader19.Text = "Date Absent"
        ColumnHeader19.Width = 250
        ' 
        ' AttendanceFilterBySectionPreviousAbsentees
        ' 
        AttendanceFilterBySectionPreviousAbsentees.AutoResize = False
        AttendanceFilterBySectionPreviousAbsentees.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AttendanceFilterBySectionPreviousAbsentees.Depth = 0
        AttendanceFilterBySectionPreviousAbsentees.DrawMode = DrawMode.OwnerDrawVariable
        AttendanceFilterBySectionPreviousAbsentees.DropDownHeight = 174
        AttendanceFilterBySectionPreviousAbsentees.DropDownStyle = ComboBoxStyle.DropDownList
        AttendanceFilterBySectionPreviousAbsentees.DropDownWidth = 121
        AttendanceFilterBySectionPreviousAbsentees.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        AttendanceFilterBySectionPreviousAbsentees.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        AttendanceFilterBySectionPreviousAbsentees.FormattingEnabled = True
        AttendanceFilterBySectionPreviousAbsentees.Hint = "Filter by Section"
        AttendanceFilterBySectionPreviousAbsentees.IntegralHeight = False
        AttendanceFilterBySectionPreviousAbsentees.ItemHeight = 43
        AttendanceFilterBySectionPreviousAbsentees.Items.AddRange(New Object() {"", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        AttendanceFilterBySectionPreviousAbsentees.Location = New Point(650, 30)
        AttendanceFilterBySectionPreviousAbsentees.MaxDropDownItems = 4
        AttendanceFilterBySectionPreviousAbsentees.MouseState = MaterialSkin.MouseState.OUT
        AttendanceFilterBySectionPreviousAbsentees.Name = "AttendanceFilterBySectionPreviousAbsentees"
        AttendanceFilterBySectionPreviousAbsentees.Size = New Size(274, 49)
        AttendanceFilterBySectionPreviousAbsentees.StartIndex = 0
        AttendanceFilterBySectionPreviousAbsentees.TabIndex = 45
        AttendanceFilterBySectionPreviousAbsentees.UseAccent = False
        ' 
        ' MaterialCard13
        ' 
        MaterialCard13.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard13.Controls.Add(AttenSelectSubCat)
        MaterialCard13.Controls.Add(AttendanceReturnBtn)
        MaterialCard13.Controls.Add(MaterialLabel59)
        MaterialCard13.Controls.Add(SaveAttedanceBtn)
        MaterialCard13.Controls.Add(MaterialLabel60)
        MaterialCard13.Controls.Add(AbsentDataGrid)
        MaterialCard13.Depth = 0
        MaterialCard13.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard13.Location = New Point(794, 152)
        MaterialCard13.Margin = New Padding(14)
        MaterialCard13.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard13.Name = "MaterialCard13"
        MaterialCard13.Padding = New Padding(30)
        MaterialCard13.Size = New Size(1045, 372)
        MaterialCard13.TabIndex = 13
        ' 
        ' AttenSelectSubCat
        ' 
        AttenSelectSubCat.AutoResize = False
        AttenSelectSubCat.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AttenSelectSubCat.Depth = 0
        AttenSelectSubCat.DrawMode = DrawMode.OwnerDrawVariable
        AttenSelectSubCat.DropDownHeight = 174
        AttenSelectSubCat.DropDownStyle = ComboBoxStyle.DropDownList
        AttenSelectSubCat.DropDownWidth = 121
        AttenSelectSubCat.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        AttenSelectSubCat.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        AttenSelectSubCat.FormattingEnabled = True
        AttenSelectSubCat.Hint = "Select Attendance in Sub Category"
        AttenSelectSubCat.IntegralHeight = False
        AttenSelectSubCat.ItemHeight = 43
        AttenSelectSubCat.Location = New Point(473, 23)
        AttenSelectSubCat.MaxDropDownItems = 4
        AttenSelectSubCat.MouseState = MaterialSkin.MouseState.OUT
        AttenSelectSubCat.Name = "AttenSelectSubCat"
        AttenSelectSubCat.Size = New Size(382, 49)
        AttenSelectSubCat.StartIndex = 0
        AttenSelectSubCat.TabIndex = 63
        ' 
        ' AttendanceReturnBtn
        ' 
        AttendanceReturnBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        AttendanceReturnBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        AttendanceReturnBtn.Depth = 0
        AttendanceReturnBtn.HighEmphasis = True
        AttendanceReturnBtn.Icon = Nothing
        AttendanceReturnBtn.Location = New Point(862, 35)
        AttendanceReturnBtn.Margin = New Padding(4, 6, 4, 6)
        AttendanceReturnBtn.MouseState = MaterialSkin.MouseState.HOVER
        AttendanceReturnBtn.Name = "AttendanceReturnBtn"
        AttendanceReturnBtn.NoAccentTextColor = Color.Empty
        AttendanceReturnBtn.Size = New Size(77, 36)
        AttendanceReturnBtn.TabIndex = 62
        AttendanceReturnBtn.Text = "Return"
        AttendanceReturnBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        AttendanceReturnBtn.UseAccentColor = True
        AttendanceReturnBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel59
        ' 
        MaterialLabel59.AutoSize = True
        MaterialLabel59.Depth = 0
        MaterialLabel59.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel59.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel59.Location = New Point(33, 71)
        MaterialLabel59.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel59.Name = "MaterialLabel59"
        MaterialLabel59.Size = New Size(69, 17)
        MaterialLabel59.TabIndex = 46
        MaterialLabel59.Text = "Absentees"
        ' 
        ' SaveAttedanceBtn
        ' 
        SaveAttedanceBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SaveAttedanceBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SaveAttedanceBtn.Depth = 0
        SaveAttedanceBtn.HighEmphasis = True
        SaveAttedanceBtn.Icon = Nothing
        SaveAttedanceBtn.Location = New Point(947, 36)
        SaveAttedanceBtn.Margin = New Padding(4, 6, 4, 6)
        SaveAttedanceBtn.MouseState = MaterialSkin.MouseState.HOVER
        SaveAttedanceBtn.Name = "SaveAttedanceBtn"
        SaveAttedanceBtn.NoAccentTextColor = Color.Empty
        SaveAttedanceBtn.Size = New Size(64, 36)
        SaveAttedanceBtn.TabIndex = 61
        SaveAttedanceBtn.Text = "Save"
        SaveAttedanceBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SaveAttedanceBtn.UseAccentColor = False
        SaveAttedanceBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel60
        ' 
        MaterialLabel60.AutoSize = True
        MaterialLabel60.Depth = 0
        MaterialLabel60.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel60.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel60.Location = New Point(33, 30)
        MaterialLabel60.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel60.Name = "MaterialLabel60"
        MaterialLabel60.Size = New Size(200, 41)
        MaterialLabel60.TabIndex = 45
        MaterialLabel60.Text = "Absent today"
        ' 
        ' AbsentDataGrid
        ' 
        AbsentDataGrid.AutoSizeTable = False
        AbsentDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AbsentDataGrid.BorderStyle = BorderStyle.None
        AbsentDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader10, ColumnHeader11})
        AbsentDataGrid.Depth = 0
        AbsentDataGrid.Dock = DockStyle.Bottom
        AbsentDataGrid.FullRowSelect = True
        AbsentDataGrid.Location = New Point(30, 102)
        AbsentDataGrid.Margin = New Padding(14)
        AbsentDataGrid.MinimumSize = New Size(200, 100)
        AbsentDataGrid.MouseLocation = New Point(-1, -1)
        AbsentDataGrid.MouseState = MaterialSkin.MouseState.OUT
        AbsentDataGrid.Name = "AbsentDataGrid"
        AbsentDataGrid.OwnerDraw = True
        AbsentDataGrid.Size = New Size(985, 240)
        AbsentDataGrid.TabIndex = 44
        AbsentDataGrid.UseCompatibleStateImageBehavior = False
        AbsentDataGrid.View = View.Details
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Stud ID"
        ColumnHeader7.Width = 150
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "First Name"
        ColumnHeader8.Width = 200
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Last Name"
        ColumnHeader9.Width = 200
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Section"
        ColumnHeader10.Width = 150
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "Date Absent"
        ColumnHeader11.Width = 300
        ' 
        ' MaterialCard16
        ' 
        MaterialCard16.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard16.Controls.Add(AttendanceChooseCourse)
        MaterialCard16.Controls.Add(MaterialLabel58)
        MaterialCard16.Controls.Add(AttendanceFilterBySection)
        MaterialCard16.Controls.Add(AttendanceDataGrid)
        MaterialCard16.Controls.Add(MaterialLabel45)
        MaterialCard16.Controls.Add(MaterialLabel57)
        MaterialCard16.Depth = 0
        MaterialCard16.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard16.Location = New Point(14, 152)
        MaterialCard16.Margin = New Padding(14)
        MaterialCard16.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard16.Name = "MaterialCard16"
        MaterialCard16.Padding = New Padding(30)
        MaterialCard16.Size = New Size(752, 839)
        MaterialCard16.TabIndex = 12
        ' 
        ' AttendanceChooseCourse
        ' 
        AttendanceChooseCourse.AutoResize = False
        AttendanceChooseCourse.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AttendanceChooseCourse.Depth = 0
        AttendanceChooseCourse.DrawMode = DrawMode.OwnerDrawVariable
        AttendanceChooseCourse.DropDownHeight = 174
        AttendanceChooseCourse.DropDownStyle = ComboBoxStyle.DropDownList
        AttendanceChooseCourse.DropDownWidth = 121
        AttendanceChooseCourse.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        AttendanceChooseCourse.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        AttendanceChooseCourse.FormattingEnabled = True
        AttendanceChooseCourse.Hint = "Select Course "
        AttendanceChooseCourse.IntegralHeight = False
        AttendanceChooseCourse.ItemHeight = 43
        AttendanceChooseCourse.Location = New Point(448, 33)
        AttendanceChooseCourse.MaxDropDownItems = 4
        AttendanceChooseCourse.MouseState = MaterialSkin.MouseState.OUT
        AttendanceChooseCourse.Name = "AttendanceChooseCourse"
        AttendanceChooseCourse.Size = New Size(274, 49)
        AttendanceChooseCourse.StartIndex = 0
        AttendanceChooseCourse.TabIndex = 62
        ' 
        ' MaterialLabel58
        ' 
        MaterialLabel58.AutoSize = True
        MaterialLabel58.Depth = 0
        MaterialLabel58.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel58.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel58.Location = New Point(33, 137)
        MaterialLabel58.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel58.Name = "MaterialLabel58"
        MaterialLabel58.Size = New Size(243, 14)
        MaterialLabel58.TabIndex = 60
        MaterialLabel58.Text = "Double click or enter key the absent student" & vbCrLf
        ' 
        ' AttendanceFilterBySection
        ' 
        AttendanceFilterBySection.AutoResize = False
        AttendanceFilterBySection.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AttendanceFilterBySection.Depth = 0
        AttendanceFilterBySection.DrawMode = DrawMode.OwnerDrawVariable
        AttendanceFilterBySection.DropDownHeight = 174
        AttendanceFilterBySection.DropDownStyle = ComboBoxStyle.DropDownList
        AttendanceFilterBySection.DropDownWidth = 121
        AttendanceFilterBySection.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        AttendanceFilterBySection.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        AttendanceFilterBySection.FormattingEnabled = True
        AttendanceFilterBySection.Hint = "Filter by Section"
        AttendanceFilterBySection.IntegralHeight = False
        AttendanceFilterBySection.ItemHeight = 43
        AttendanceFilterBySection.Items.AddRange(New Object() {"", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        AttendanceFilterBySection.Location = New Point(448, 89)
        AttendanceFilterBySection.MaxDropDownItems = 4
        AttendanceFilterBySection.MouseState = MaterialSkin.MouseState.OUT
        AttendanceFilterBySection.Name = "AttendanceFilterBySection"
        AttendanceFilterBySection.Size = New Size(274, 49)
        AttendanceFilterBySection.StartIndex = 0
        AttendanceFilterBySection.TabIndex = 44
        AttendanceFilterBySection.UseAccent = False
        ' 
        ' AttendanceDataGrid
        ' 
        AttendanceDataGrid.AutoSizeTable = False
        AttendanceDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AttendanceDataGrid.BorderStyle = BorderStyle.None
        AttendanceDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader12})
        AttendanceDataGrid.Depth = 0
        AttendanceDataGrid.Dock = DockStyle.Bottom
        AttendanceDataGrid.FullRowSelect = True
        AttendanceDataGrid.Location = New Point(30, 165)
        AttendanceDataGrid.Margin = New Padding(14)
        AttendanceDataGrid.MinimumSize = New Size(200, 100)
        AttendanceDataGrid.MouseLocation = New Point(-1, -1)
        AttendanceDataGrid.MouseState = MaterialSkin.MouseState.OUT
        AttendanceDataGrid.Name = "AttendanceDataGrid"
        AttendanceDataGrid.OwnerDraw = True
        AttendanceDataGrid.Size = New Size(692, 644)
        AttendanceDataGrid.TabIndex = 43
        AttendanceDataGrid.UseCompatibleStateImageBehavior = False
        AttendanceDataGrid.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Stud ID"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "First Name"
        ColumnHeader2.Width = 190
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Last Name"
        ColumnHeader3.Width = 190
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Section"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "Date Today"
        ColumnHeader12.Width = 200
        ' 
        ' MaterialLabel45
        ' 
        MaterialLabel45.AutoSize = True
        MaterialLabel45.Depth = 0
        MaterialLabel45.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel45.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel45.Location = New Point(33, 71)
        MaterialLabel45.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel45.Name = "MaterialLabel45"
        MaterialLabel45.Size = New Size(115, 17)
        MaterialLabel45.TabIndex = 36
        MaterialLabel45.Text = "Present or Absent"
        ' 
        ' MaterialLabel57
        ' 
        MaterialLabel57.AutoSize = True
        MaterialLabel57.Depth = 0
        MaterialLabel57.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel57.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel57.Location = New Point(33, 30)
        MaterialLabel57.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel57.Name = "MaterialLabel57"
        MaterialLabel57.Size = New Size(175, 41)
        MaterialLabel57.TabIndex = 35
        MaterialLabel57.Text = "Attendance"
        ' 
        ' MaterialCard15
        ' 
        MaterialCard15.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard15.Controls.Add(AttendanceProfLbl)
        MaterialCard15.Controls.Add(AttendanceDateLbl)
        MaterialCard15.Controls.Add(AttendanceTimeLbl)
        MaterialCard15.Controls.Add(MaterialLabel52)
        MaterialCard15.Controls.Add(PictureBox5)
        MaterialCard15.Depth = 0
        MaterialCard15.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard15.Location = New Point(14, 14)
        MaterialCard15.Margin = New Padding(14)
        MaterialCard15.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard15.Name = "MaterialCard15"
        MaterialCard15.Padding = New Padding(30)
        MaterialCard15.Size = New Size(1825, 110)
        MaterialCard15.TabIndex = 11
        ' 
        ' AttendanceProfLbl
        ' 
        AttendanceProfLbl.AutoSize = True
        AttendanceProfLbl.Depth = 0
        AttendanceProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        AttendanceProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        AttendanceProfLbl.Location = New Point(1528, 24)
        AttendanceProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        AttendanceProfLbl.Name = "AttendanceProfLbl"
        AttendanceProfLbl.Size = New Size(264, 24)
        AttendanceProfLbl.TabIndex = 7
        AttendanceProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' AttendanceDateLbl
        ' 
        AttendanceDateLbl.AutoSize = True
        AttendanceDateLbl.Depth = 0
        AttendanceDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        AttendanceDateLbl.Location = New Point(1664, 48)
        AttendanceDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        AttendanceDateLbl.Name = "AttendanceDateLbl"
        AttendanceDateLbl.Size = New Size(128, 19)
        AttendanceDateLbl.TabIndex = 6
        AttendanceDateLbl.Text = "December 5, 2024"
        ' 
        ' AttendanceTimeLbl
        ' 
        AttendanceTimeLbl.AutoSize = True
        AttendanceTimeLbl.Depth = 0
        AttendanceTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        AttendanceTimeLbl.Location = New Point(1751, 67)
        AttendanceTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        AttendanceTimeLbl.Name = "AttendanceTimeLbl"
        AttendanceTimeLbl.Size = New Size(41, 19)
        AttendanceTimeLbl.TabIndex = 5
        AttendanceTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel52
        ' 
        MaterialLabel52.AutoSize = True
        MaterialLabel52.Depth = 0
        MaterialLabel52.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel52.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel52.Location = New Point(485, 26)
        MaterialLabel52.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel52.Name = "MaterialLabel52"
        MaterialLabel52.Size = New Size(855, 58)
        MaterialLabel52.TabIndex = 1
        MaterialLabel52.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.PLP_logo1
        PictureBox5.Location = New Point(33, 30)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(50, 50)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' Scoring
        ' 
        Scoring.Controls.Add(MaterialCard12)
        Scoring.Controls.Add(MaterialCard3)
        Scoring.Controls.Add(MaterialCard6)
        Scoring.ImageKey = "exam (2) (1).png"
        Scoring.Location = New Point(29, 4)
        Scoring.Name = "Scoring"
        Scoring.Padding = New Padding(3)
        Scoring.Size = New Size(1881, 1005)
        Scoring.TabIndex = 0
        Scoring.Text = "Scoring"
        Scoring.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard12
        ' 
        MaterialCard12.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard12.Controls.Add(ScFilterBySem)
        MaterialCard12.Controls.Add(ScFilterByTerm)
        MaterialCard12.Controls.Add(ScClearBtn)
        MaterialCard12.Controls.Add(MaterialLabel41)
        MaterialCard12.Controls.Add(ScStudentNameBox)
        MaterialCard12.Controls.Add(ScEnterBtn)
        MaterialCard12.Controls.Add(ScRawScoreBox)
        MaterialCard12.Controls.Add(ScSubCatNameBox)
        MaterialCard12.Controls.Add(ScCatNameBox)
        MaterialCard12.Controls.Add(MaterialLabel40)
        MaterialCard12.Controls.Add(MaterialLabel37)
        MaterialCard12.Controls.Add(ScCourseNameBox)
        MaterialCard12.Controls.Add(MaterialLabel48)
        MaterialCard12.Controls.Add(ScTotalScoreBox)
        MaterialCard12.Controls.Add(MaterialLabel47)
        MaterialCard12.Controls.Add(MaterialLabel46)
        MaterialCard12.Controls.Add(MaterialLabel38)
        MaterialCard12.Controls.Add(MaterialLabel39)
        MaterialCard12.Controls.Add(MaterialLabel43)
        MaterialCard12.Depth = 0
        MaterialCard12.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard12.Location = New Point(17, 155)
        MaterialCard12.Margin = New Padding(14)
        MaterialCard12.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard12.Name = "MaterialCard12"
        MaterialCard12.Padding = New Padding(30)
        MaterialCard12.Size = New Size(348, 821)
        MaterialCard12.TabIndex = 16
        ' 
        ' ScFilterBySem
        ' 
        ScFilterBySem.AutoResize = False
        ScFilterBySem.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ScFilterBySem.Depth = 0
        ScFilterBySem.DrawMode = DrawMode.OwnerDrawVariable
        ScFilterBySem.DropDownHeight = 174
        ScFilterBySem.DropDownStyle = ComboBoxStyle.DropDownList
        ScFilterBySem.DropDownWidth = 121
        ScFilterBySem.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        ScFilterBySem.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        ScFilterBySem.FormattingEnabled = True
        ScFilterBySem.Hint = "Filter by semester"
        ScFilterBySem.IntegralHeight = False
        ScFilterBySem.ItemHeight = 43
        ScFilterBySem.Items.AddRange(New Object() {"", "1st", "2nd"})
        ScFilterBySem.Location = New Point(27, 178)
        ScFilterBySem.MaxDropDownItems = 4
        ScFilterBySem.MouseState = MaterialSkin.MouseState.OUT
        ScFilterBySem.Name = "ScFilterBySem"
        ScFilterBySem.Size = New Size(291, 49)
        ScFilterBySem.StartIndex = 0
        ScFilterBySem.TabIndex = 62
        ScFilterBySem.UseAccent = False
        ' 
        ' ScFilterByTerm
        ' 
        ScFilterByTerm.AutoResize = False
        ScFilterByTerm.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ScFilterByTerm.Depth = 0
        ScFilterByTerm.DrawMode = DrawMode.OwnerDrawVariable
        ScFilterByTerm.DropDownHeight = 174
        ScFilterByTerm.DropDownStyle = ComboBoxStyle.DropDownList
        ScFilterByTerm.DropDownWidth = 121
        ScFilterByTerm.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        ScFilterByTerm.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        ScFilterByTerm.FormattingEnabled = True
        ScFilterByTerm.Hint = "Filter by term"
        ScFilterByTerm.IntegralHeight = False
        ScFilterByTerm.ItemHeight = 43
        ScFilterByTerm.Items.AddRange(New Object() {"", "midterm", "finals"})
        ScFilterByTerm.Location = New Point(30, 123)
        ScFilterByTerm.MaxDropDownItems = 4
        ScFilterByTerm.MouseState = MaterialSkin.MouseState.OUT
        ScFilterByTerm.Name = "ScFilterByTerm"
        ScFilterByTerm.Size = New Size(291, 49)
        ScFilterByTerm.StartIndex = 0
        ScFilterByTerm.TabIndex = 61
        ScFilterByTerm.UseAccent = False
        ' 
        ' ScClearBtn
        ' 
        ScClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ScClearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ScClearBtn.Depth = 0
        ScClearBtn.HighEmphasis = True
        ScClearBtn.Icon = Nothing
        ScClearBtn.Location = New Point(252, 35)
        ScClearBtn.Margin = New Padding(4, 6, 4, 6)
        ScClearBtn.MouseState = MaterialSkin.MouseState.HOVER
        ScClearBtn.Name = "ScClearBtn"
        ScClearBtn.NoAccentTextColor = Color.Empty
        ScClearBtn.Size = New Size(66, 36)
        ScClearBtn.TabIndex = 60
        ScClearBtn.Text = "Clear"
        ScClearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ScClearBtn.UseAccentColor = True
        ScClearBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel41
        ' 
        MaterialLabel41.AutoSize = True
        MaterialLabel41.Depth = 0
        MaterialLabel41.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel41.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel41.Location = New Point(33, 323)
        MaterialLabel41.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel41.Name = "MaterialLabel41"
        MaterialLabel41.Size = New Size(166, 14)
        MaterialLabel41.TabIndex = 59
        MaterialLabel41.Text = "You are modifying the score of"
        ' 
        ' ScStudentNameBox
        ' 
        ScStudentNameBox.AnimateReadOnly = False
        ScStudentNameBox.BorderStyle = BorderStyle.None
        ScStudentNameBox.Depth = 0
        ScStudentNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScStudentNameBox.Hint = "Student Name"
        ScStudentNameBox.LeadingIcon = Nothing
        ScStudentNameBox.Location = New Point(33, 260)
        ScStudentNameBox.MaxLength = 50
        ScStudentNameBox.MouseState = MaterialSkin.MouseState.OUT
        ScStudentNameBox.Multiline = False
        ScStudentNameBox.Name = "ScStudentNameBox"
        ScStudentNameBox.Size = New Size(288, 50)
        ScStudentNameBox.TabIndex = 58
        ScStudentNameBox.Text = ""
        ScStudentNameBox.TrailingIcon = Nothing
        ScStudentNameBox.UseAccent = False
        ' 
        ' ScEnterBtn
        ' 
        ScEnterBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ScEnterBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ScEnterBtn.Depth = 0
        ScEnterBtn.HighEmphasis = True
        ScEnterBtn.Icon = Nothing
        ScEnterBtn.Location = New Point(251, 749)
        ScEnterBtn.Margin = New Padding(4, 6, 4, 6)
        ScEnterBtn.MouseState = MaterialSkin.MouseState.HOVER
        ScEnterBtn.Name = "ScEnterBtn"
        ScEnterBtn.NoAccentTextColor = Color.Empty
        ScEnterBtn.Size = New Size(67, 36)
        ScEnterBtn.TabIndex = 57
        ScEnterBtn.Text = "Enter"
        ScEnterBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ScEnterBtn.UseAccentColor = False
        ScEnterBtn.UseVisualStyleBackColor = True
        ' 
        ' ScRawScoreBox
        ' 
        ScRawScoreBox.AnimateReadOnly = False
        ScRawScoreBox.BorderStyle = BorderStyle.None
        ScRawScoreBox.Depth = 0
        ScRawScoreBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScRawScoreBox.Hint = "Raw score"
        ScRawScoreBox.LeadingIcon = Nothing
        ScRawScoreBox.Location = New Point(30, 620)
        ScRawScoreBox.MaxLength = 50
        ScRawScoreBox.MouseState = MaterialSkin.MouseState.OUT
        ScRawScoreBox.Multiline = False
        ScRawScoreBox.Name = "ScRawScoreBox"
        ScRawScoreBox.Size = New Size(139, 50)
        ScRawScoreBox.TabIndex = 56
        ScRawScoreBox.Text = ""
        ScRawScoreBox.TrailingIcon = Nothing
        ScRawScoreBox.UseAccent = False
        ' 
        ' ScSubCatNameBox
        ' 
        ScSubCatNameBox.AnimateReadOnly = False
        ScSubCatNameBox.BorderStyle = BorderStyle.None
        ScSubCatNameBox.Depth = 0
        ScSubCatNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScSubCatNameBox.Hint = "Sub category name"
        ScSubCatNameBox.LeadingIcon = Nothing
        ScSubCatNameBox.Location = New Point(27, 530)
        ScSubCatNameBox.MaxLength = 50
        ScSubCatNameBox.MouseState = MaterialSkin.MouseState.OUT
        ScSubCatNameBox.Multiline = False
        ScSubCatNameBox.Name = "ScSubCatNameBox"
        ScSubCatNameBox.Size = New Size(288, 50)
        ScSubCatNameBox.TabIndex = 55
        ScSubCatNameBox.Text = ""
        ScSubCatNameBox.TrailingIcon = Nothing
        ScSubCatNameBox.UseAccent = False
        ' 
        ' ScCatNameBox
        ' 
        ScCatNameBox.AnimateReadOnly = False
        ScCatNameBox.BorderStyle = BorderStyle.None
        ScCatNameBox.Depth = 0
        ScCatNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScCatNameBox.Hint = "Category name"
        ScCatNameBox.LeadingIcon = Nothing
        ScCatNameBox.Location = New Point(27, 440)
        ScCatNameBox.MaxLength = 50
        ScCatNameBox.MouseState = MaterialSkin.MouseState.OUT
        ScCatNameBox.Multiline = False
        ScCatNameBox.Name = "ScCatNameBox"
        ScCatNameBox.Size = New Size(288, 50)
        ScCatNameBox.TabIndex = 54
        ScCatNameBox.Text = ""
        ScCatNameBox.TrailingIcon = Nothing
        ScCatNameBox.UseAccent = False
        ' 
        ' MaterialLabel40
        ' 
        MaterialLabel40.AutoSize = True
        MaterialLabel40.Depth = 0
        MaterialLabel40.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel40.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel40.Location = New Point(33, 777)
        MaterialLabel40.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel40.Name = "MaterialLabel40"
        MaterialLabel40.Size = New Size(203, 14)
        MaterialLabel40.TabIndex = 53
        MaterialLabel40.Text = "Select or click students from the table"
        ' 
        ' MaterialLabel37
        ' 
        MaterialLabel37.AutoSize = True
        MaterialLabel37.Depth = 0
        MaterialLabel37.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel37.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel37.Location = New Point(30, 413)
        MaterialLabel37.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel37.Name = "MaterialLabel37"
        MaterialLabel37.Size = New Size(132, 14)
        MaterialLabel37.TabIndex = 52
        MaterialLabel37.Text = "Selected Category name"
        ' 
        ' ScCourseNameBox
        ' 
        ScCourseNameBox.AnimateReadOnly = False
        ScCourseNameBox.BorderStyle = BorderStyle.None
        ScCourseNameBox.Depth = 0
        ScCourseNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScCourseNameBox.Hint = "Course name"
        ScCourseNameBox.LeadingIcon = Nothing
        ScCourseNameBox.Location = New Point(30, 350)
        ScCourseNameBox.MaxLength = 50
        ScCourseNameBox.MouseState = MaterialSkin.MouseState.OUT
        ScCourseNameBox.Multiline = False
        ScCourseNameBox.Name = "ScCourseNameBox"
        ScCourseNameBox.Size = New Size(285, 50)
        ScCourseNameBox.TabIndex = 51
        ScCourseNameBox.Text = ""
        ScCourseNameBox.TrailingIcon = Nothing
        ScCourseNameBox.UseAccent = False
        ' 
        ' MaterialLabel48
        ' 
        MaterialLabel48.AutoSize = True
        MaterialLabel48.Depth = 0
        MaterialLabel48.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel48.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel48.Location = New Point(175, 683)
        MaterialLabel48.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel48.Name = "MaterialLabel48"
        MaterialLabel48.Size = New Size(61, 14)
        MaterialLabel48.TabIndex = 49
        MaterialLabel48.Text = "Total score"
        ' 
        ' ScTotalScoreBox
        ' 
        ScTotalScoreBox.AnimateReadOnly = False
        ScTotalScoreBox.BorderStyle = BorderStyle.None
        ScTotalScoreBox.Depth = 0
        ScTotalScoreBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScTotalScoreBox.Hint = "Total score"
        ScTotalScoreBox.LeadingIcon = Nothing
        ScTotalScoreBox.Location = New Point(175, 620)
        ScTotalScoreBox.MaxLength = 50
        ScTotalScoreBox.MouseState = MaterialSkin.MouseState.OUT
        ScTotalScoreBox.Multiline = False
        ScTotalScoreBox.Name = "ScTotalScoreBox"
        ScTotalScoreBox.Size = New Size(140, 50)
        ScTotalScoreBox.TabIndex = 48
        ScTotalScoreBox.Text = ""
        ScTotalScoreBox.TrailingIcon = Nothing
        ScTotalScoreBox.UseAccent = False
        ' 
        ' MaterialLabel47
        ' 
        MaterialLabel47.AutoSize = True
        MaterialLabel47.Depth = 0
        MaterialLabel47.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel47.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel47.Location = New Point(30, 593)
        MaterialLabel47.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel47.Name = "MaterialLabel47"
        MaterialLabel47.Size = New Size(154, 14)
        MaterialLabel47.TabIndex = 46
        MaterialLabel47.Text = "Selected Sub category name"
        ' 
        ' MaterialLabel46
        ' 
        MaterialLabel46.AutoSize = True
        MaterialLabel46.Depth = 0
        MaterialLabel46.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel46.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel46.Location = New Point(30, 503)
        MaterialLabel46.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel46.Name = "MaterialLabel46"
        MaterialLabel46.Size = New Size(132, 14)
        MaterialLabel46.TabIndex = 45
        MaterialLabel46.Text = "Selected Category name"
        ' 
        ' MaterialLabel38
        ' 
        MaterialLabel38.AutoSize = True
        MaterialLabel38.Depth = 0
        MaterialLabel38.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel38.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel38.Location = New Point(30, 683)
        MaterialLabel38.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel38.Name = "MaterialLabel38"
        MaterialLabel38.Size = New Size(61, 14)
        MaterialLabel38.TabIndex = 42
        MaterialLabel38.Text = "Enter score"
        ' 
        ' MaterialLabel39
        ' 
        MaterialLabel39.AutoSize = True
        MaterialLabel39.Depth = 0
        MaterialLabel39.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel39.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel39.Location = New Point(33, 71)
        MaterialLabel39.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel39.Name = "MaterialLabel39"
        MaterialLabel39.Size = New Size(90, 17)
        MaterialLabel39.TabIndex = 1
        MaterialLabel39.Text = "Modify scores"
        ' 
        ' MaterialLabel43
        ' 
        MaterialLabel43.AutoSize = True
        MaterialLabel43.Depth = 0
        MaterialLabel43.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel43.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel43.Location = New Point(33, 30)
        MaterialLabel43.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel43.Name = "MaterialLabel43"
        MaterialLabel43.Size = New Size(173, 41)
        MaterialLabel43.TabIndex = 0
        MaterialLabel43.Text = "Enter score"
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(AttendanceFilterByCourse)
        MaterialCard3.Controls.Add(ScFilterBySection)
        MaterialCard3.Controls.Add(ScScoreDataGrid)
        MaterialCard3.Controls.Add(ScFilterBySubCat)
        MaterialCard3.Controls.Add(MaterialLabel32)
        MaterialCard3.Controls.Add(MaterialLabel33)
        MaterialCard3.Controls.Add(ScoringSearchStudentsBox)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(393, 155)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(30)
        MaterialCard3.Size = New Size(1446, 821)
        MaterialCard3.TabIndex = 12
        ' 
        ' AttendanceFilterByCourse
        ' 
        AttendanceFilterByCourse.AutoResize = False
        AttendanceFilterByCourse.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AttendanceFilterByCourse.Depth = 0
        AttendanceFilterByCourse.DrawMode = DrawMode.OwnerDrawVariable
        AttendanceFilterByCourse.DropDownHeight = 174
        AttendanceFilterByCourse.DropDownStyle = ComboBoxStyle.DropDownList
        AttendanceFilterByCourse.DropDownWidth = 121
        AttendanceFilterByCourse.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        AttendanceFilterByCourse.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        AttendanceFilterByCourse.FormattingEnabled = True
        AttendanceFilterByCourse.Hint = "Filter by course"
        AttendanceFilterByCourse.IntegralHeight = False
        AttendanceFilterByCourse.ItemHeight = 43
        AttendanceFilterByCourse.Location = New Point(617, 36)
        AttendanceFilterByCourse.MaxDropDownItems = 4
        AttendanceFilterByCourse.MouseState = MaterialSkin.MouseState.OUT
        AttendanceFilterByCourse.Name = "AttendanceFilterByCourse"
        AttendanceFilterByCourse.Size = New Size(255, 49)
        AttendanceFilterByCourse.StartIndex = 0
        AttendanceFilterByCourse.TabIndex = 44
        AttendanceFilterByCourse.UseAccent = False
        ' 
        ' ScFilterBySection
        ' 
        ScFilterBySection.AutoResize = False
        ScFilterBySection.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ScFilterBySection.Depth = 0
        ScFilterBySection.DrawMode = DrawMode.OwnerDrawVariable
        ScFilterBySection.DropDownHeight = 174
        ScFilterBySection.DropDownStyle = ComboBoxStyle.DropDownList
        ScFilterBySection.DropDownWidth = 121
        ScFilterBySection.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        ScFilterBySection.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        ScFilterBySection.FormattingEnabled = True
        ScFilterBySection.Hint = "Filter by Section"
        ScFilterBySection.IntegralHeight = False
        ScFilterBySection.ItemHeight = 43
        ScFilterBySection.Items.AddRange(New Object() {"", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        ScFilterBySection.Location = New Point(1139, 36)
        ScFilterBySection.MaxDropDownItems = 4
        ScFilterBySection.MouseState = MaterialSkin.MouseState.OUT
        ScFilterBySection.Name = "ScFilterBySection"
        ScFilterBySection.Size = New Size(274, 49)
        ScFilterBySection.StartIndex = 0
        ScFilterBySection.TabIndex = 43
        ScFilterBySection.UseAccent = False
        ' 
        ' ScScoreDataGrid
        ' 
        ScScoreDataGrid.AutoSizeTable = False
        ScScoreDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ScScoreDataGrid.BorderStyle = BorderStyle.None
        ScScoreDataGrid.Columns.AddRange(New ColumnHeader() {ScScoreId, ScStudentId, ScFirstName, ScLastName, ScCourseName, ScCategoryName, ScSubCategoryName, ScRawScore, ScTotalScore, ScGrade, scTerm, ScSemestr})
        ScScoreDataGrid.Depth = 0
        ScScoreDataGrid.Dock = DockStyle.Bottom
        ScScoreDataGrid.FullRowSelect = True
        ScScoreDataGrid.Location = New Point(30, 102)
        ScScoreDataGrid.Margin = New Padding(14)
        ScScoreDataGrid.MinimumSize = New Size(200, 100)
        ScScoreDataGrid.MouseLocation = New Point(-1, -1)
        ScScoreDataGrid.MouseState = MaterialSkin.MouseState.OUT
        ScScoreDataGrid.Name = "ScScoreDataGrid"
        ScScoreDataGrid.OwnerDraw = True
        ScScoreDataGrid.Size = New Size(1386, 689)
        ScScoreDataGrid.TabIndex = 42
        ScScoreDataGrid.UseCompatibleStateImageBehavior = False
        ScScoreDataGrid.View = View.Details
        ' 
        ' ScScoreId
        ' 
        ScScoreId.Text = "Score ID"
        ScScoreId.Width = 85
        ' 
        ' ScStudentId
        ' 
        ScStudentId.Text = "Student ID"
        ScStudentId.Width = 100
        ' 
        ' ScFirstName
        ' 
        ScFirstName.Text = "First Name"
        ScFirstName.Width = 120
        ' 
        ' ScLastName
        ' 
        ScLastName.Text = "Last Name"
        ScLastName.Width = 120
        ' 
        ' ScCourseName
        ' 
        ScCourseName.Text = "Course Name"
        ScCourseName.Width = 200
        ' 
        ' ScCategoryName
        ' 
        ScCategoryName.Text = "Category Name"
        ScCategoryName.Width = 150
        ' 
        ' ScSubCategoryName
        ' 
        ScSubCategoryName.Text = "Sub Category Name"
        ScSubCategoryName.Width = 150
        ' 
        ' ScRawScore
        ' 
        ScRawScore.Text = "Raw Score"
        ScRawScore.Width = 100
        ' 
        ' ScTotalScore
        ' 
        ScTotalScore.Text = "Total"
        ScTotalScore.Width = 100
        ' 
        ' ScGrade
        ' 
        ScGrade.Text = "Grade"
        ScGrade.Width = 90
        ' 
        ' scTerm
        ' 
        scTerm.Text = "Term"
        scTerm.Width = 80
        ' 
        ' ScSemestr
        ' 
        ScSemestr.Text = "Sem"
        ScSemestr.Width = 80
        ' 
        ' ScFilterBySubCat
        ' 
        ScFilterBySubCat.AutoResize = False
        ScFilterBySubCat.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ScFilterBySubCat.Depth = 0
        ScFilterBySubCat.DrawMode = DrawMode.OwnerDrawVariable
        ScFilterBySubCat.DropDownHeight = 174
        ScFilterBySubCat.DropDownStyle = ComboBoxStyle.DropDownList
        ScFilterBySubCat.DropDownWidth = 121
        ScFilterBySubCat.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        ScFilterBySubCat.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        ScFilterBySubCat.FormattingEnabled = True
        ScFilterBySubCat.Hint = "Filter by Sub Category"
        ScFilterBySubCat.IntegralHeight = False
        ScFilterBySubCat.ItemHeight = 43
        ScFilterBySubCat.Location = New Point(878, 36)
        ScFilterBySubCat.MaxDropDownItems = 4
        ScFilterBySubCat.MouseState = MaterialSkin.MouseState.OUT
        ScFilterBySubCat.Name = "ScFilterBySubCat"
        ScFilterBySubCat.Size = New Size(255, 49)
        ScFilterBySubCat.StartIndex = 0
        ScFilterBySubCat.TabIndex = 39
        ScFilterBySubCat.UseAccent = False
        ' 
        ' MaterialLabel32
        ' 
        MaterialLabel32.AutoSize = True
        MaterialLabel32.Depth = 0
        MaterialLabel32.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel32.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel32.Location = New Point(33, 71)
        MaterialLabel32.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel32.Name = "MaterialLabel32"
        MaterialLabel32.Size = New Size(130, 17)
        MaterialLabel32.TabIndex = 34
        MaterialLabel32.Text = "Grade your students"
        ' 
        ' MaterialLabel33
        ' 
        MaterialLabel33.AutoSize = True
        MaterialLabel33.Depth = 0
        MaterialLabel33.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel33.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel33.Location = New Point(33, 30)
        MaterialLabel33.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel33.Name = "MaterialLabel33"
        MaterialLabel33.Size = New Size(136, 41)
        MaterialLabel33.TabIndex = 33
        MaterialLabel33.Text = "Students"
        ' 
        ' ScoringSearchStudentsBox
        ' 
        ScoringSearchStudentsBox.AnimateReadOnly = False
        ScoringSearchStudentsBox.BorderStyle = BorderStyle.None
        ScoringSearchStudentsBox.Depth = 0
        ScoringSearchStudentsBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoringSearchStudentsBox.Hint = "Search students"
        ScoringSearchStudentsBox.LeadingIcon = My.Resources.Resources.magnifier
        ScoringSearchStudentsBox.Location = New Point(187, 35)
        ScoringSearchStudentsBox.MaxLength = 50
        ScoringSearchStudentsBox.MouseState = MaterialSkin.MouseState.OUT
        ScoringSearchStudentsBox.Multiline = False
        ScoringSearchStudentsBox.Name = "ScoringSearchStudentsBox"
        ScoringSearchStudentsBox.Size = New Size(424, 50)
        ScoringSearchStudentsBox.TabIndex = 11
        ScoringSearchStudentsBox.Text = ""
        ScoringSearchStudentsBox.TrailingIcon = Nothing
        ScoringSearchStudentsBox.UseAccent = False
        ' 
        ' MaterialCard6
        ' 
        MaterialCard6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard6.Controls.Add(ScoringProfLbl)
        MaterialCard6.Controls.Add(ScoringDateLbl)
        MaterialCard6.Controls.Add(ScoringTimeLbl)
        MaterialCard6.Controls.Add(MaterialLabel13)
        MaterialCard6.Controls.Add(PictureBox1)
        MaterialCard6.Depth = 0
        MaterialCard6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard6.Location = New Point(14, 17)
        MaterialCard6.Margin = New Padding(14)
        MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard6.Name = "MaterialCard6"
        MaterialCard6.Padding = New Padding(30)
        MaterialCard6.Size = New Size(1825, 110)
        MaterialCard6.TabIndex = 10
        ' 
        ' ScoringProfLbl
        ' 
        ScoringProfLbl.AutoSize = True
        ScoringProfLbl.Depth = 0
        ScoringProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        ScoringProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        ScoringProfLbl.Location = New Point(1528, 24)
        ScoringProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        ScoringProfLbl.Name = "ScoringProfLbl"
        ScoringProfLbl.Size = New Size(264, 24)
        ScoringProfLbl.TabIndex = 7
        ScoringProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' ScoringDateLbl
        ' 
        ScoringDateLbl.AutoSize = True
        ScoringDateLbl.Depth = 0
        ScoringDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoringDateLbl.Location = New Point(1664, 48)
        ScoringDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        ScoringDateLbl.Name = "ScoringDateLbl"
        ScoringDateLbl.Size = New Size(128, 19)
        ScoringDateLbl.TabIndex = 6
        ScoringDateLbl.Text = "December 5, 2024"
        ' 
        ' ScoringTimeLbl
        ' 
        ScoringTimeLbl.AutoSize = True
        ScoringTimeLbl.Depth = 0
        ScoringTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        ScoringTimeLbl.Location = New Point(1751, 67)
        ScoringTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        ScoringTimeLbl.Name = "ScoringTimeLbl"
        ScoringTimeLbl.Size = New Size(41, 19)
        ScoringTimeLbl.TabIndex = 5
        ScoringTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel13
        ' 
        MaterialLabel13.AutoSize = True
        MaterialLabel13.Depth = 0
        MaterialLabel13.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel13.Location = New Point(485, 26)
        MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel13.Name = "MaterialLabel13"
        MaterialLabel13.Size = New Size(855, 58)
        MaterialLabel13.TabIndex = 1
        MaterialLabel13.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.PLP_logo1
        PictureBox1.Location = New Point(33, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Grading
        ' 
        Grading.Controls.Add(MaterialCard18)
        Grading.Controls.Add(MaterialCard17)
        Grading.ImageKey = "completed-form (1).png"
        Grading.Location = New Point(29, 4)
        Grading.Name = "Grading"
        Grading.Size = New Size(1881, 1005)
        Grading.TabIndex = 7
        Grading.Text = "Final Grade"
        Grading.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard18
        ' 
        MaterialCard18.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard18.Controls.Add(SaveAsBtn)
        MaterialCard18.Controls.Add(FinalGradeFilterBySection)
        MaterialCard18.Controls.Add(MaterialLabel42)
        MaterialCard18.Controls.Add(MaterialLabel44)
        MaterialCard18.Controls.Add(FinalGradeDataGrid)
        MaterialCard18.Depth = 0
        MaterialCard18.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard18.Location = New Point(14, 152)
        MaterialCard18.Margin = New Padding(14)
        MaterialCard18.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard18.Name = "MaterialCard18"
        MaterialCard18.Padding = New Padding(30)
        MaterialCard18.Size = New Size(1828, 843)
        MaterialCard18.TabIndex = 13
        ' 
        ' SaveAsBtn
        ' 
        SaveAsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SaveAsBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SaveAsBtn.Depth = 0
        SaveAsBtn.HighEmphasis = True
        SaveAsBtn.Icon = Nothing
        SaveAsBtn.Location = New Point(1683, 36)
        SaveAsBtn.Margin = New Padding(4, 6, 4, 6)
        SaveAsBtn.MouseState = MaterialSkin.MouseState.HOVER
        SaveAsBtn.Name = "SaveAsBtn"
        SaveAsBtn.NoAccentTextColor = Color.Empty
        SaveAsBtn.Size = New Size(111, 36)
        SaveAsBtn.TabIndex = 58
        SaveAsBtn.Text = "Save as PDF"
        SaveAsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SaveAsBtn.UseAccentColor = False
        SaveAsBtn.UseVisualStyleBackColor = True
        ' 
        ' FinalGradeFilterBySection
        ' 
        FinalGradeFilterBySection.AutoResize = False
        FinalGradeFilterBySection.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        FinalGradeFilterBySection.Depth = 0
        FinalGradeFilterBySection.DrawMode = DrawMode.OwnerDrawVariable
        FinalGradeFilterBySection.DropDownHeight = 174
        FinalGradeFilterBySection.DropDownStyle = ComboBoxStyle.DropDownList
        FinalGradeFilterBySection.DropDownWidth = 121
        FinalGradeFilterBySection.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        FinalGradeFilterBySection.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        FinalGradeFilterBySection.FormattingEnabled = True
        FinalGradeFilterBySection.Hint = "Filter by Section"
        FinalGradeFilterBySection.IntegralHeight = False
        FinalGradeFilterBySection.ItemHeight = 43
        FinalGradeFilterBySection.Items.AddRange(New Object() {"", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        FinalGradeFilterBySection.Location = New Point(1402, 33)
        FinalGradeFilterBySection.MaxDropDownItems = 4
        FinalGradeFilterBySection.MouseState = MaterialSkin.MouseState.OUT
        FinalGradeFilterBySection.Name = "FinalGradeFilterBySection"
        FinalGradeFilterBySection.Size = New Size(274, 49)
        FinalGradeFilterBySection.StartIndex = 0
        FinalGradeFilterBySection.TabIndex = 44
        FinalGradeFilterBySection.UseAccent = False
        ' 
        ' MaterialLabel42
        ' 
        MaterialLabel42.AutoSize = True
        MaterialLabel42.Depth = 0
        MaterialLabel42.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel42.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel42.Location = New Point(33, 71)
        MaterialLabel42.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel42.Name = "MaterialLabel42"
        MaterialLabel42.Size = New Size(126, 17)
        MaterialLabel42.TabIndex = 3
        MaterialLabel42.Text = "Summary of Grades"
        ' 
        ' MaterialLabel44
        ' 
        MaterialLabel44.AutoSize = True
        MaterialLabel44.Depth = 0
        MaterialLabel44.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel44.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel44.Location = New Point(33, 30)
        MaterialLabel44.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel44.Name = "MaterialLabel44"
        MaterialLabel44.Size = New Size(191, 41)
        MaterialLabel44.TabIndex = 2
        MaterialLabel44.Text = "Grade report"
        ' 
        ' FinalGradeDataGrid
        ' 
        FinalGradeDataGrid.AutoSizeTable = False
        FinalGradeDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        FinalGradeDataGrid.BorderStyle = BorderStyle.None
        FinalGradeDataGrid.Columns.AddRange(New ColumnHeader() {GStudentId, GFirstName, GLastName, GCourseName, ColumnHeader27, ColumnHeader6, ColumnHeader17, ColumnHeader18, ColumnHeader22, ColumnHeader23, ColumnHeader24, ColumnHeader25, PointGrader})
        FinalGradeDataGrid.Depth = 0
        FinalGradeDataGrid.Dock = DockStyle.Bottom
        FinalGradeDataGrid.FullRowSelect = True
        FinalGradeDataGrid.Location = New Point(30, 135)
        FinalGradeDataGrid.MinimumSize = New Size(200, 100)
        FinalGradeDataGrid.MouseLocation = New Point(-1, -1)
        FinalGradeDataGrid.MouseState = MaterialSkin.MouseState.OUT
        FinalGradeDataGrid.Name = "FinalGradeDataGrid"
        FinalGradeDataGrid.OwnerDraw = True
        FinalGradeDataGrid.Size = New Size(1768, 678)
        FinalGradeDataGrid.TabIndex = 0
        FinalGradeDataGrid.UseCompatibleStateImageBehavior = False
        FinalGradeDataGrid.View = View.Details
        ' 
        ' GStudentId
        ' 
        GStudentId.Text = "Student Id"
        GStudentId.Width = 100
        ' 
        ' GFirstName
        ' 
        GFirstName.Text = "First Name"
        GFirstName.Width = 130
        ' 
        ' GLastName
        ' 
        GLastName.Text = "Last Name"
        GLastName.Width = 130
        ' 
        ' GCourseName
        ' 
        GCourseName.Text = "Course Name"
        GCourseName.Width = 190
        ' 
        ' ColumnHeader27
        ' 
        ColumnHeader27.Text = "Section"
        ColumnHeader27.Width = 90
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Sem1 Midterm"
        ColumnHeader6.Width = 120
        ' 
        ' ColumnHeader17
        ' 
        ColumnHeader17.Text = "Sem1 Final"
        ColumnHeader17.Width = 120
        ' 
        ' ColumnHeader18
        ' 
        ColumnHeader18.Text = "Sem1 Overall"
        ColumnHeader18.Width = 190
        ' 
        ' ColumnHeader22
        ' 
        ColumnHeader22.Text = "Sem2 Midterm"
        ColumnHeader22.Width = 120
        ' 
        ' ColumnHeader23
        ' 
        ColumnHeader23.Text = "Sem2 Finals"
        ColumnHeader23.Width = 120
        ' 
        ' ColumnHeader24
        ' 
        ColumnHeader24.Text = "Sem2 Overall"
        ColumnHeader24.Width = 190
        ' 
        ' ColumnHeader25
        ' 
        ColumnHeader25.Text = "Final Grade"
        ColumnHeader25.Width = 120
        ' 
        ' PointGrader
        ' 
        PointGrader.Text = "Point Grade"
        PointGrader.Width = 160
        ' 
        ' MaterialCard17
        ' 
        MaterialCard17.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard17.Controls.Add(FinalGradeProfLbl)
        MaterialCard17.Controls.Add(FinalGradeDateLbl)
        MaterialCard17.Controls.Add(FinalGradeTimeLbl)
        MaterialCard17.Controls.Add(MaterialLabel56)
        MaterialCard17.Controls.Add(PictureBox6)
        MaterialCard17.Depth = 0
        MaterialCard17.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard17.Location = New Point(14, 14)
        MaterialCard17.Margin = New Padding(14)
        MaterialCard17.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard17.Name = "MaterialCard17"
        MaterialCard17.Padding = New Padding(30)
        MaterialCard17.Size = New Size(1828, 110)
        MaterialCard17.TabIndex = 12
        ' 
        ' FinalGradeProfLbl
        ' 
        FinalGradeProfLbl.AutoSize = True
        FinalGradeProfLbl.Depth = 0
        FinalGradeProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        FinalGradeProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        FinalGradeProfLbl.Location = New Point(1531, 24)
        FinalGradeProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        FinalGradeProfLbl.Name = "FinalGradeProfLbl"
        FinalGradeProfLbl.Size = New Size(264, 24)
        FinalGradeProfLbl.TabIndex = 7
        FinalGradeProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' FinalGradeDateLbl
        ' 
        FinalGradeDateLbl.AutoSize = True
        FinalGradeDateLbl.Depth = 0
        FinalGradeDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        FinalGradeDateLbl.Location = New Point(1667, 48)
        FinalGradeDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        FinalGradeDateLbl.Name = "FinalGradeDateLbl"
        FinalGradeDateLbl.Size = New Size(128, 19)
        FinalGradeDateLbl.TabIndex = 6
        FinalGradeDateLbl.Text = "December 5, 2024"
        ' 
        ' FinalGradeTimeLbl
        ' 
        FinalGradeTimeLbl.AutoSize = True
        FinalGradeTimeLbl.Depth = 0
        FinalGradeTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        FinalGradeTimeLbl.Location = New Point(1754, 67)
        FinalGradeTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        FinalGradeTimeLbl.Name = "FinalGradeTimeLbl"
        FinalGradeTimeLbl.Size = New Size(41, 19)
        FinalGradeTimeLbl.TabIndex = 5
        FinalGradeTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel56
        ' 
        MaterialLabel56.AutoSize = True
        MaterialLabel56.Depth = 0
        MaterialLabel56.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel56.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel56.Location = New Point(487, 26)
        MaterialLabel56.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel56.Name = "MaterialLabel56"
        MaterialLabel56.Size = New Size(855, 58)
        MaterialLabel56.TabIndex = 1
        MaterialLabel56.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.PLP_logo1
        PictureBox6.Location = New Point(33, 30)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(50, 50)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 0
        PictureBox6.TabStop = False
        ' 
        ' Settings
        ' 
        Settings.Controls.Add(MaterialCard10)
        Settings.Controls.Add(MaterialCard9)
        Settings.Controls.Add(MaterialCard8)
        Settings.ImageKey = "setting (1).png"
        Settings.Location = New Point(29, 4)
        Settings.Name = "Settings"
        Settings.Size = New Size(1881, 1005)
        Settings.TabIndex = 3
        Settings.Text = "Settings"
        Settings.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard10
        ' 
        MaterialCard10.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard10.Controls.Add(DarkModeSwitch)
        MaterialCard10.Controls.Add(MaterialLabel31)
        MaterialCard10.Controls.Add(MaterialLabel30)
        MaterialCard10.Controls.Add(MaterialLabel29)
        MaterialCard10.Controls.Add(MaterialLabel27)
        MaterialCard10.Controls.Add(MaterialLabel26)
        MaterialCard10.Controls.Add(MaterialLabel25)
        MaterialCard10.Controls.Add(ProfUpdateBtn)
        MaterialCard10.Controls.Add(ProfPassword)
        MaterialCard10.Controls.Add(ProfUsername)
        MaterialCard10.Controls.Add(ProfEmail)
        MaterialCard10.Controls.Add(ProfMiddleName)
        MaterialCard10.Controls.Add(ProfLastName)
        MaterialCard10.Controls.Add(ProfFirstName)
        MaterialCard10.Depth = 0
        MaterialCard10.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard10.Location = New Point(16, 313)
        MaterialCard10.Margin = New Padding(14)
        MaterialCard10.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard10.Name = "MaterialCard10"
        MaterialCard10.Padding = New Padding(90, 30, 90, 30)
        MaterialCard10.Size = New Size(1825, 678)
        MaterialCard10.TabIndex = 13
        ' 
        ' DarkModeSwitch
        ' 
        DarkModeSwitch.AutoSize = True
        DarkModeSwitch.Depth = 0
        DarkModeSwitch.Location = New Point(682, 515)
        DarkModeSwitch.Margin = New Padding(0)
        DarkModeSwitch.MouseLocation = New Point(-1, -1)
        DarkModeSwitch.MouseState = MaterialSkin.MouseState.HOVER
        DarkModeSwitch.Name = "DarkModeSwitch"
        DarkModeSwitch.Ripple = True
        DarkModeSwitch.Size = New Size(135, 37)
        DarkModeSwitch.TabIndex = 38
        DarkModeSwitch.Text = "Dark Mode"
        DarkModeSwitch.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel31
        ' 
        MaterialLabel31.AutoSize = True
        MaterialLabel31.Depth = 0
        MaterialLabel31.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel31.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel31.Location = New Point(682, 430)
        MaterialLabel31.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel31.Name = "MaterialLabel31"
        MaterialLabel31.Size = New Size(55, 14)
        MaterialLabel31.TabIndex = 37
        MaterialLabel31.Text = "Password"
        ' 
        ' MaterialLabel30
        ' 
        MaterialLabel30.AutoSize = True
        MaterialLabel30.Depth = 0
        MaterialLabel30.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel30.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel30.Location = New Point(682, 350)
        MaterialLabel30.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel30.Name = "MaterialLabel30"
        MaterialLabel30.Size = New Size(56, 14)
        MaterialLabel30.TabIndex = 36
        MaterialLabel30.Text = "Username"
        ' 
        ' MaterialLabel29
        ' 
        MaterialLabel29.AutoSize = True
        MaterialLabel29.Depth = 0
        MaterialLabel29.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel29.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel29.Location = New Point(682, 270)
        MaterialLabel29.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel29.Name = "MaterialLabel29"
        MaterialLabel29.Size = New Size(79, 14)
        MaterialLabel29.TabIndex = 35
        MaterialLabel29.Text = "Email Address"
        ' 
        ' MaterialLabel27
        ' 
        MaterialLabel27.AutoSize = True
        MaterialLabel27.Depth = 0
        MaterialLabel27.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel27.Location = New Point(682, 190)
        MaterialLabel27.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel27.Name = "MaterialLabel27"
        MaterialLabel27.Size = New Size(73, 14)
        MaterialLabel27.TabIndex = 34
        MaterialLabel27.Text = "Middle Name"
        ' 
        ' MaterialLabel26
        ' 
        MaterialLabel26.AutoSize = True
        MaterialLabel26.Depth = 0
        MaterialLabel26.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel26.Location = New Point(682, 110)
        MaterialLabel26.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel26.Name = "MaterialLabel26"
        MaterialLabel26.Size = New Size(60, 14)
        MaterialLabel26.TabIndex = 33
        MaterialLabel26.Text = "Last Name"
        ' 
        ' MaterialLabel25
        ' 
        MaterialLabel25.AutoSize = True
        MaterialLabel25.Depth = 0
        MaterialLabel25.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel25.Location = New Point(682, 30)
        MaterialLabel25.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel25.Name = "MaterialLabel25"
        MaterialLabel25.Size = New Size(61, 14)
        MaterialLabel25.TabIndex = 32
        MaterialLabel25.Text = "First Name"
        ' 
        ' ProfUpdateBtn
        ' 
        ProfUpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ProfUpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ProfUpdateBtn.Depth = 0
        ProfUpdateBtn.HighEmphasis = True
        ProfUpdateBtn.Icon = Nothing
        ProfUpdateBtn.Location = New Point(1065, 606)
        ProfUpdateBtn.Margin = New Padding(4, 6, 4, 6)
        ProfUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER
        ProfUpdateBtn.Name = "ProfUpdateBtn"
        ProfUpdateBtn.NoAccentTextColor = Color.Empty
        ProfUpdateBtn.Size = New Size(77, 36)
        ProfUpdateBtn.TabIndex = 31
        ProfUpdateBtn.Text = "update"
        ProfUpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ProfUpdateBtn.UseAccentColor = False
        ProfUpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' ProfPassword
        ' 
        ProfPassword.AnimateReadOnly = False
        ProfPassword.BorderStyle = BorderStyle.None
        ProfPassword.Depth = 0
        ProfPassword.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfPassword.Hint = "Professor Password"
        ProfPassword.LeadingIcon = My.Resources.Resources.padlock
        ProfPassword.Location = New Point(682, 447)
        ProfPassword.MaxLength = 50
        ProfPassword.MouseState = MaterialSkin.MouseState.OUT
        ProfPassword.Multiline = False
        ProfPassword.Name = "ProfPassword"
        ProfPassword.Password = True
        ProfPassword.Size = New Size(460, 50)
        ProfPassword.TabIndex = 29
        ProfPassword.Text = ""
        ProfPassword.TrailingIcon = Nothing
        ProfPassword.UseAccent = False
        ' 
        ' ProfUsername
        ' 
        ProfUsername.AnimateReadOnly = False
        ProfUsername.BorderStyle = BorderStyle.None
        ProfUsername.Depth = 0
        ProfUsername.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfUsername.Hint = "Professor Username"
        ProfUsername.LeadingIcon = My.Resources.Resources.user
        ProfUsername.Location = New Point(682, 367)
        ProfUsername.MaxLength = 50
        ProfUsername.MouseState = MaterialSkin.MouseState.OUT
        ProfUsername.Multiline = False
        ProfUsername.Name = "ProfUsername"
        ProfUsername.Size = New Size(460, 50)
        ProfUsername.TabIndex = 28
        ProfUsername.Text = ""
        ProfUsername.TrailingIcon = Nothing
        ProfUsername.UseAccent = False
        ' 
        ' ProfEmail
        ' 
        ProfEmail.AnimateReadOnly = False
        ProfEmail.BorderStyle = BorderStyle.None
        ProfEmail.Depth = 0
        ProfEmail.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfEmail.Hint = "Professor Email"
        ProfEmail.LeadingIcon = My.Resources.Resources.email
        ProfEmail.Location = New Point(682, 287)
        ProfEmail.MaxLength = 50
        ProfEmail.MouseState = MaterialSkin.MouseState.OUT
        ProfEmail.Multiline = False
        ProfEmail.Name = "ProfEmail"
        ProfEmail.Size = New Size(460, 50)
        ProfEmail.TabIndex = 27
        ProfEmail.Text = ""
        ProfEmail.TrailingIcon = Nothing
        ProfEmail.UseAccent = False
        ' 
        ' ProfMiddleName
        ' 
        ProfMiddleName.AnimateReadOnly = False
        ProfMiddleName.BorderStyle = BorderStyle.None
        ProfMiddleName.Depth = 0
        ProfMiddleName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfMiddleName.Hint = "Professor Middle Name"
        ProfMiddleName.LeadingIcon = Nothing
        ProfMiddleName.Location = New Point(682, 207)
        ProfMiddleName.MaxLength = 50
        ProfMiddleName.MouseState = MaterialSkin.MouseState.OUT
        ProfMiddleName.Multiline = False
        ProfMiddleName.Name = "ProfMiddleName"
        ProfMiddleName.Size = New Size(460, 50)
        ProfMiddleName.TabIndex = 26
        ProfMiddleName.Text = ""
        ProfMiddleName.TrailingIcon = Nothing
        ProfMiddleName.UseAccent = False
        ' 
        ' ProfLastName
        ' 
        ProfLastName.AnimateReadOnly = False
        ProfLastName.BorderStyle = BorderStyle.None
        ProfLastName.Depth = 0
        ProfLastName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfLastName.Hint = "Professor Last Name"
        ProfLastName.LeadingIcon = Nothing
        ProfLastName.Location = New Point(682, 127)
        ProfLastName.MaxLength = 50
        ProfLastName.MouseState = MaterialSkin.MouseState.OUT
        ProfLastName.Multiline = False
        ProfLastName.Name = "ProfLastName"
        ProfLastName.Size = New Size(460, 50)
        ProfLastName.TabIndex = 25
        ProfLastName.Text = ""
        ProfLastName.TrailingIcon = Nothing
        ProfLastName.UseAccent = False
        ' 
        ' ProfFirstName
        ' 
        ProfFirstName.AnimateReadOnly = False
        ProfFirstName.BorderStyle = BorderStyle.None
        ProfFirstName.Depth = 0
        ProfFirstName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfFirstName.Hint = "Professor First Name"
        ProfFirstName.LeadingIcon = Nothing
        ProfFirstName.Location = New Point(682, 47)
        ProfFirstName.MaxLength = 50
        ProfFirstName.MouseState = MaterialSkin.MouseState.OUT
        ProfFirstName.Multiline = False
        ProfFirstName.Name = "ProfFirstName"
        ProfFirstName.Size = New Size(460, 50)
        ProfFirstName.TabIndex = 24
        ProfFirstName.Text = ""
        ProfFirstName.TrailingIcon = Nothing
        ProfFirstName.UseAccent = False
        ' 
        ' MaterialCard9
        ' 
        MaterialCard9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard9.Controls.Add(MaterialLabel23)
        MaterialCard9.Controls.Add(MaterialLabel24)
        MaterialCard9.Depth = 0
        MaterialCard9.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard9.Location = New Point(14, 152)
        MaterialCard9.Margin = New Padding(14)
        MaterialCard9.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard9.Name = "MaterialCard9"
        MaterialCard9.Padding = New Padding(30)
        MaterialCard9.Size = New Size(1825, 133)
        MaterialCard9.TabIndex = 12
        ' 
        ' MaterialLabel23
        ' 
        MaterialLabel23.AutoSize = True
        MaterialLabel23.Depth = 0
        MaterialLabel23.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel23.Location = New Point(33, 78)
        MaterialLabel23.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel23.Name = "MaterialLabel23"
        MaterialLabel23.Size = New Size(99, 17)
        MaterialLabel23.TabIndex = 32
        MaterialLabel23.Text = "Modify account"
        ' 
        ' MaterialLabel24
        ' 
        MaterialLabel24.AutoSize = True
        MaterialLabel24.Depth = 0
        MaterialLabel24.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel24.Location = New Point(33, 37)
        MaterialLabel24.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel24.Name = "MaterialLabel24"
        MaterialLabel24.Size = New Size(125, 41)
        MaterialLabel24.TabIndex = 31
        MaterialLabel24.Text = "Settings"
        ' 
        ' MaterialCard8
        ' 
        MaterialCard8.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard8.Controls.Add(SettingsProfLbl)
        MaterialCard8.Controls.Add(SettingsDateLbl)
        MaterialCard8.Controls.Add(SettingsTimeLbl)
        MaterialCard8.Controls.Add(MaterialLabel22)
        MaterialCard8.Controls.Add(PictureBox4)
        MaterialCard8.Depth = 0
        MaterialCard8.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard8.Location = New Point(14, 14)
        MaterialCard8.Margin = New Padding(14)
        MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard8.Name = "MaterialCard8"
        MaterialCard8.Padding = New Padding(30)
        MaterialCard8.Size = New Size(1825, 110)
        MaterialCard8.TabIndex = 11
        ' 
        ' SettingsProfLbl
        ' 
        SettingsProfLbl.AutoSize = True
        SettingsProfLbl.Depth = 0
        SettingsProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        SettingsProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        SettingsProfLbl.Location = New Point(1528, 24)
        SettingsProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        SettingsProfLbl.Name = "SettingsProfLbl"
        SettingsProfLbl.Size = New Size(264, 24)
        SettingsProfLbl.TabIndex = 7
        SettingsProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' SettingsDateLbl
        ' 
        SettingsDateLbl.AutoSize = True
        SettingsDateLbl.Depth = 0
        SettingsDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        SettingsDateLbl.Location = New Point(1664, 48)
        SettingsDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        SettingsDateLbl.Name = "SettingsDateLbl"
        SettingsDateLbl.Size = New Size(128, 19)
        SettingsDateLbl.TabIndex = 6
        SettingsDateLbl.Text = "December 5, 2024"
        ' 
        ' SettingsTimeLbl
        ' 
        SettingsTimeLbl.AutoSize = True
        SettingsTimeLbl.Depth = 0
        SettingsTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        SettingsTimeLbl.Location = New Point(1751, 67)
        SettingsTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        SettingsTimeLbl.Name = "SettingsTimeLbl"
        SettingsTimeLbl.Size = New Size(41, 19)
        SettingsTimeLbl.TabIndex = 5
        SettingsTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel22
        ' 
        MaterialLabel22.AutoSize = True
        MaterialLabel22.Depth = 0
        MaterialLabel22.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel22.Location = New Point(485, 26)
        MaterialLabel22.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel22.Name = "MaterialLabel22"
        MaterialLabel22.Size = New Size(855, 58)
        MaterialLabel22.TabIndex = 1
        MaterialLabel22.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.PLP_logo1
        PictureBox4.Location = New Point(33, 30)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' SignOut
        ' 
        SignOut.Controls.Add(MaterialCard7)
        SignOut.ImageKey = "logout (1).png"
        SignOut.Location = New Point(29, 4)
        SignOut.Name = "SignOut"
        SignOut.Size = New Size(1881, 1005)
        SignOut.TabIndex = 4
        SignOut.Text = "SignOut"
        SignOut.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard7
        ' 
        MaterialCard7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard7.Controls.Add(SignOutCancel)
        MaterialCard7.Controls.Add(SignOutYes)
        MaterialCard7.Controls.Add(MaterialLabel14)
        MaterialCard7.Controls.Add(MaterialLabel15)
        MaterialCard7.Depth = 0
        MaterialCard7.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard7.Location = New Point(566, 372)
        MaterialCard7.Margin = New Padding(14)
        MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard7.Name = "MaterialCard7"
        MaterialCard7.Padding = New Padding(30)
        MaterialCard7.Size = New Size(725, 260)
        MaterialCard7.TabIndex = 1
        ' 
        ' SignOutCancel
        ' 
        SignOutCancel.AutoSize = False
        SignOutCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SignOutCancel.BackColor = Color.Red
        SignOutCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SignOutCancel.Depth = 0
        SignOutCancel.HighEmphasis = True
        SignOutCancel.Icon = Nothing
        SignOutCancel.Location = New Point(34, 165)
        SignOutCancel.Margin = New Padding(4, 6, 4, 6)
        SignOutCancel.MouseState = MaterialSkin.MouseState.HOVER
        SignOutCancel.Name = "SignOutCancel"
        SignOutCancel.NoAccentTextColor = Color.Empty
        SignOutCancel.Size = New Size(161, 59)
        SignOutCancel.TabIndex = 19
        SignOutCancel.Text = "Cancel"
        SignOutCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SignOutCancel.UseAccentColor = True
        SignOutCancel.UseVisualStyleBackColor = False
        ' 
        ' SignOutYes
        ' 
        SignOutYes.AutoSize = False
        SignOutYes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SignOutYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SignOutYes.Depth = 0
        SignOutYes.HighEmphasis = True
        SignOutYes.Icon = Nothing
        SignOutYes.Location = New Point(530, 165)
        SignOutYes.Margin = New Padding(4, 6, 4, 6)
        SignOutYes.MouseState = MaterialSkin.MouseState.HOVER
        SignOutYes.Name = "SignOutYes"
        SignOutYes.NoAccentTextColor = Color.Empty
        SignOutYes.Size = New Size(161, 59)
        SignOutYes.TabIndex = 18
        SignOutYes.Text = "Yes"
        SignOutYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SignOutYes.UseAccentColor = False
        SignOutYes.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel14
        ' 
        MaterialLabel14.AutoSize = True
        MaterialLabel14.Depth = 0
        MaterialLabel14.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel14.Location = New Point(278, 87)
        MaterialLabel14.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel14.Name = "MaterialLabel14"
        MaterialLabel14.Size = New Size(201, 19)
        MaterialLabel14.TabIndex = 1
        MaterialLabel14.Text = "Are you sure on signing out?"
        ' 
        ' MaterialLabel15
        ' 
        MaterialLabel15.AutoSize = True
        MaterialLabel15.Depth = 0
        MaterialLabel15.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel15.Location = New Point(291, 46)
        MaterialLabel15.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel15.Name = "MaterialLabel15"
        MaterialLabel15.Size = New Size(174, 41)
        MaterialLabel15.TabIndex = 0
        MaterialLabel15.Text = "Signing Out"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "setting (1).png")
        ImageList1.Images.SetKeyName(1, "reading-book (1).png")
        ImageList1.Images.SetKeyName(2, "exam (1).png")
        ImageList1.Images.SetKeyName(3, "teacher (1) (1).png")
        ImageList1.Images.SetKeyName(4, "exam (2) (1).png")
        ImageList1.Images.SetKeyName(5, "categorization (1).png")
        ImageList1.Images.SetKeyName(6, "logout (1).png")
        ImageList1.Images.SetKeyName(7, "user (1) (1).png")
        ImageList1.Images.SetKeyName(8, "crowd-of-users (1).png")
        ImageList1.Images.SetKeyName(9, "printing (1).png")
        ImageList1.Images.SetKeyName(10, "completed-form (1).png")
        ' 
        ' MaterialCheckbox1
        ' 
        MaterialCheckbox1.AutoSize = True
        MaterialCheckbox1.Depth = 0
        MaterialCheckbox1.Location = New Point(0, 0)
        MaterialCheckbox1.Margin = New Padding(0)
        MaterialCheckbox1.MouseLocation = New Point(-1, -1)
        MaterialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCheckbox1.Name = "MaterialCheckbox1"
        MaterialCheckbox1.ReadOnly = False
        MaterialCheckbox1.Ripple = True
        MaterialCheckbox1.Size = New Size(10, 10)
        MaterialCheckbox1.TabIndex = 0
        MaterialCheckbox1.Text = "MaterialCheckbox1"
        MaterialCheckbox1.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox2
        ' 
        MaterialCheckbox2.AutoSize = True
        MaterialCheckbox2.Depth = 0
        MaterialCheckbox2.Location = New Point(0, 0)
        MaterialCheckbox2.Margin = New Padding(0)
        MaterialCheckbox2.MouseLocation = New Point(-1, -1)
        MaterialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCheckbox2.Name = "MaterialCheckbox2"
        MaterialCheckbox2.ReadOnly = False
        MaterialCheckbox2.Ripple = True
        MaterialCheckbox2.Size = New Size(10, 10)
        MaterialCheckbox2.TabIndex = 0
        MaterialCheckbox2.Text = "MaterialCheckbox2"
        MaterialCheckbox2.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox3
        ' 
        MaterialCheckbox3.AutoSize = True
        MaterialCheckbox3.Depth = 0
        MaterialCheckbox3.Location = New Point(0, 0)
        MaterialCheckbox3.Margin = New Padding(0)
        MaterialCheckbox3.MouseLocation = New Point(-1, -1)
        MaterialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCheckbox3.Name = "MaterialCheckbox3"
        MaterialCheckbox3.ReadOnly = False
        MaterialCheckbox3.Ripple = True
        MaterialCheckbox3.Size = New Size(10, 10)
        MaterialCheckbox3.TabIndex = 0
        MaterialCheckbox3.Text = "MaterialCheckbox3"
        MaterialCheckbox3.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' TeacherDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1080)
        Controls.Add(MaterialTabControl1)
        DrawerAutoShow = True
        DrawerShowIconsWhenHidden = True
        DrawerTabControl = MaterialTabControl1
        DrawerUseColors = True
        Name = "TeacherDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TeacherDashboard"
        WindowState = FormWindowState.Maximized
        MaterialTabControl1.ResumeLayout(False)
        Categories.ResumeLayout(False)
        CatTopPanel.ResumeLayout(False)
        CatTopPanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        MaterialCard5.ResumeLayout(False)
        MaterialCard5.PerformLayout()
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        Attendance.ResumeLayout(False)
        MaterialCard14.ResumeLayout(False)
        MaterialCard14.PerformLayout()
        MaterialCard13.ResumeLayout(False)
        MaterialCard13.PerformLayout()
        MaterialCard16.ResumeLayout(False)
        MaterialCard16.PerformLayout()
        MaterialCard15.ResumeLayout(False)
        MaterialCard15.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Scoring.ResumeLayout(False)
        MaterialCard12.ResumeLayout(False)
        MaterialCard12.PerformLayout()
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
        MaterialCard6.ResumeLayout(False)
        MaterialCard6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Grading.ResumeLayout(False)
        MaterialCard18.ResumeLayout(False)
        MaterialCard18.PerformLayout()
        MaterialCard17.ResumeLayout(False)
        MaterialCard17.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Settings.ResumeLayout(False)
        MaterialCard10.ResumeLayout(False)
        MaterialCard10.PerformLayout()
        MaterialCard9.ResumeLayout(False)
        MaterialCard9.PerformLayout()
        MaterialCard8.ResumeLayout(False)
        MaterialCard8.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        SignOut.ResumeLayout(False)
        MaterialCard7.ResumeLayout(False)
        MaterialCard7.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents Categories As TabPage
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CatDeleteBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CatSearchCatNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents CatUpdateBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CatCategNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents CatAddBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents SubCatDelBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CatSubTotScoreBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents CatSubSearchSubBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents SubCatUpdateBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CatSubCatNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents SubCatAddBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Scoring As TabPage
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CategoriesDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Settings As TabPage
    Friend WithEvents SignOut As TabPage
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents ScoringProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ScoringDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ScoringTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents SignOutCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents SignOutYes As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel14 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel15 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CatTopPanel As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CatProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CatDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CatTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel16 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MaterialLabel17 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel18 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents SettingsProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SettingsDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SettingsTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel22 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MaterialCard9 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel23 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel24 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard10 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents ProfPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfUsername As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfEmail As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfMiddleName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfLastName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfFirstName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel31 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel30 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel29 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel27 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel26 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel25 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ProfUpdateBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DarkModeSwitch As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents CategID As ColumnHeader
    Friend WithEvents CourseID As ColumnHeader
    Friend WithEvents CategoryName As ColumnHeader
    Friend WithEvents CatSubDataGird As MaterialSkin.Controls.MaterialListView
    Friend WithEvents SubCategID As ColumnHeader
    Friend WithEvents SubCategName As ColumnHeader
    Friend WithEvents CategID2 As ColumnHeader
    Friend WithEvents TotalScore As ColumnHeader
    Friend WithEvents CatCoursesSearchForCoursesBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ClearEverythingBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel36 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CatCourseDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents CourseID2 As ColumnHeader
    Friend WithEvents CourseName2 As ColumnHeader
    Friend WithEvents CatCatPercentBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Percent As ColumnHeader
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialComboBox3 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ScScoreDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ScFilterBySubCat As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel32 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel33 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ScoringSearchStudentsBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard12 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialTextBox10 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel47 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel46 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox7 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox8 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel38 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel39 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel43 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel48 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ScTotalScoreBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Attendance As TabPage
    Friend WithEvents MaterialCard15 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents AttendanceProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AttendanceDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AttendanceTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel52 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MaterialCard16 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCheckbox1 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox2 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox3 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents CatSelectedCourseBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents CatSubCatSubNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents CatClrBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents SubCatClrBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CatCoursesSortByBox As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents CatSelectedCourseIDBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents SubCatSelectedCourseIdBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Grading As TabPage
    Friend WithEvents MaterialCard17 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents FinalGradeProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents FinalGradeDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents FinalGradeTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel56 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents MaterialCard18 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents FinalGradeDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents GStudentId As ColumnHeader
    Friend WithEvents GFirstName As ColumnHeader
    Friend WithEvents GLastName As ColumnHeader
    Friend WithEvents GCourseName As ColumnHeader
    Friend WithEvents ScStudentId As ColumnHeader
    Friend WithEvents ScFirstName As ColumnHeader
    Friend WithEvents ScLastName As ColumnHeader
    Friend WithEvents ScCourseName As ColumnHeader
    Friend WithEvents ScCategoryName As ColumnHeader
    Friend WithEvents ScSubCategoryName As ColumnHeader
    Friend WithEvents ScRawScore As ColumnHeader
    Friend WithEvents ScTotalScore As ColumnHeader
    Friend WithEvents ScGrade As ColumnHeader
    Friend WithEvents ScFilterBySection As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel40 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel37 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ScCourseNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ScEnterBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ScRawScoreBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ScSubCatNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ScCatNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel41 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ScStudentNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ScScoreId As ColumnHeader
    Friend WithEvents ScClearBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel42 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel44 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AttendanceDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents MaterialLabel45 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel57 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AttendanceFilterBySection As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialCard13 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel59 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel60 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AbsentDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents MaterialLabel58 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents AttendanceReturnBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents SaveAttedanceBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents MaterialCard14 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents AttendanceFilterBySectionPreviousAbsentees As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel61 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel62 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PreviousAbsenteesDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents DelAbsentBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents AttendanceFilterByCourse As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents AttendanceChooseCourse As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents SubCatCourseID As ColumnHeader
    Friend WithEvents scTerm As ColumnHeader
    Friend WithEvents ScSemestr As ColumnHeader
    Friend WithEvents ScFilterByTerm As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ScFilterBySem As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents PointGrader As ColumnHeader
    Friend WithEvents SaveAsBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents FinalGradeFilterBySection As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents CatSelectSem As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents CatSelectTerm As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents SubCatCategoryIdBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents AttenSelectSem As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents AttenSelectSubCat As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
