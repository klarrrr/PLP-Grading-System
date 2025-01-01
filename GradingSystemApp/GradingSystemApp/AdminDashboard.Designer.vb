<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    'Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        StudentRegistrationCard = New MaterialSkin.Controls.MaterialCard()
        BtnAttachFile = New MaterialSkin.Controls.MaterialButton()
        StuClearBtn = New MaterialSkin.Controls.MaterialButton()
        StuDeleteBtn = New MaterialSkin.Controls.MaterialButton()
        StuUpdateBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        RegStudentEmailAddress = New MaterialSkin.Controls.MaterialTextBox()
        RegStudentRegBtn = New MaterialSkin.Controls.MaterialButton()
        RegStudentSection = New MaterialSkin.Controls.MaterialComboBox()
        RegStudentMiddleName = New MaterialSkin.Controls.MaterialTextBox()
        RegStudentLastName = New MaterialSkin.Controls.MaterialTextBox()
        RegStudentFirstName = New MaterialSkin.Controls.MaterialTextBox()
        RegStudentId = New MaterialSkin.Controls.MaterialTextBox()
        StudentListCard = New MaterialSkin.Controls.MaterialCard()
        StudentDataGridView = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader15 = New ColumnHeader()
        ColumnHeader16 = New ColumnHeader()
        SearchStudentTxtBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        ProfessorDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader25 = New ColumnHeader()
        ColumnHeader43 = New ColumnHeader()
        ColumnHeader44 = New ColumnHeader()
        ColumnHeader45 = New ColumnHeader()
        ColumnHeader46 = New ColumnHeader()
        ColumnHeader47 = New ColumnHeader()
        ColumnHeader48 = New ColumnHeader()
        ProfSearchBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        ProfClearBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        ProfDeleteBtn = New MaterialSkin.Controls.MaterialButton()
        ProfUpdateBtn = New MaterialSkin.Controls.MaterialButton()
        ProfConfirmPass = New MaterialSkin.Controls.MaterialTextBox()
        ProfPassword = New MaterialSkin.Controls.MaterialTextBox()
        ProfUsername = New MaterialSkin.Controls.MaterialTextBox()
        ProfEmail = New MaterialSkin.Controls.MaterialTextBox()
        ProfRegisterBtn = New MaterialSkin.Controls.MaterialButton()
        ProfMiddleName = New MaterialSkin.Controls.MaterialTextBox()
        ProfLastName = New MaterialSkin.Controls.MaterialTextBox()
        ProfFirstName = New MaterialSkin.Controls.MaterialTextBox()
        MaterialDrawer1 = New MaterialSkin.Controls.MaterialDrawer()
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Professor = New TabPage()
        TopPanel = New MaterialSkin.Controls.MaterialCard()
        AdminProfAdminLbl = New MaterialSkin.Controls.MaterialLabel()
        DateLabelProf = New MaterialSkin.Controls.MaterialLabel()
        TimeLabelProf = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox1 = New PictureBox()
        Student = New TabPage()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        StuAdminLbl = New MaterialSkin.Controls.MaterialLabel()
        StuDateLbl = New MaterialSkin.Controls.MaterialLabel()
        StuTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox2 = New PictureBox()
        CoursesAd = New TabPage()
        MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        AddSearchCourseBox = New MaterialSkin.Controls.MaterialTextBox()
        AddCourseDataGrid = New MaterialSkin.Controls.MaterialListView()
        CourCourseID = New ColumnHeader()
        CourCourseName = New ColumnHeader()
        MaterialCard20 = New MaterialSkin.Controls.MaterialCard()
        AddClearBtn = New MaterialSkin.Controls.MaterialButton()
        AddDeleteCourseBtn = New MaterialSkin.Controls.MaterialButton()
        AddUpdateCourseBtn = New MaterialSkin.Controls.MaterialButton()
        AddAddCourseBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel47 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel48 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel53 = New MaterialSkin.Controls.MaterialLabel()
        AddCourseNameBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialCard21 = New MaterialSkin.Controls.MaterialCard()
        CourProfLbl = New MaterialSkin.Controls.MaterialLabel()
        CourDateLbl = New MaterialSkin.Controls.MaterialLabel()
        CourTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel57 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox7 = New PictureBox()
        BulkEnrollment = New TabPage()
        MaterialCard13 = New MaterialSkin.Controls.MaterialCard()
        BulkCoursesDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader41 = New ColumnHeader()
        ColumnHeader42 = New ColumnHeader()
        MaterialCard12 = New MaterialSkin.Controls.MaterialCard()
        ClearBulkCoursesBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel60 = New MaterialSkin.Controls.MaterialLabel()
        BulkCourseIdBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel34 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel31 = New MaterialSkin.Controls.MaterialLabel()
        BulkEnrollBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel32 = New MaterialSkin.Controls.MaterialLabel()
        BulkCourseBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialCard11 = New MaterialSkin.Controls.MaterialCard()
        BulkProfLbl = New MaterialSkin.Controls.MaterialLabel()
        BulkDateLbl = New MaterialSkin.Controls.MaterialLabel()
        BulkTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel23 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox5 = New PictureBox()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        BulkSectionToUnenroll = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel62 = New MaterialSkin.Controls.MaterialLabel()
        BulkEnrolledStudentDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        ColumnHeader56 = New ColumnHeader()
        ColumnHeader57 = New ColumnHeader()
        BulkUnenrollBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel26 = New MaterialSkin.Controls.MaterialLabel()
        SelectSectionToEnroll = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel33 = New MaterialSkin.Controls.MaterialLabel()
        EnrolleSectionGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        SearchBulk = New MaterialSkin.Controls.MaterialTextBox()
        IndividualEnrollment = New TabPage()
        MaterialCard14 = New MaterialSkin.Controls.MaterialCard()
        IndSelectedCourseNameBox = New MaterialSkin.Controls.MaterialTextBox()
        IndSelectCourseDatGrid = New MaterialSkin.Controls.MaterialListView()
        IndCourCourseID = New ColumnHeader()
        IndCourCourseName = New ColumnHeader()
        MaterialCard15 = New MaterialSkin.Controls.MaterialCard()
        IndClearBtn = New MaterialSkin.Controls.MaterialButton()
        IndEnrollButton = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel25 = New MaterialSkin.Controls.MaterialLabel()
        IndSelectedCourseIdBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel27 = New MaterialSkin.Controls.MaterialLabel()
        IndStudentIdBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel35 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel36 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard16 = New MaterialSkin.Controls.MaterialCard()
        IndProfLbl = New MaterialSkin.Controls.MaterialLabel()
        IndDatelbl = New MaterialSkin.Controls.MaterialLabel()
        IndTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel40 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox6 = New PictureBox()
        MaterialCard17 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel59 = New MaterialSkin.Controls.MaterialLabel()
        IndSelectedEnrollIdBox = New MaterialSkin.Controls.MaterialTextBox()
        IndSortStudentByBox = New MaterialSkin.Controls.MaterialComboBox()
        IndSortEnrolledByBox = New MaterialSkin.Controls.MaterialComboBox()
        MaterialLabel41 = New MaterialSkin.Controls.MaterialLabel()
        IndEnrolledStudentsDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader49 = New ColumnHeader()
        ColumnHeader29 = New ColumnHeader()
        ColumnHeader30 = New ColumnHeader()
        ColumnHeader31 = New ColumnHeader()
        ColumnHeader32 = New ColumnHeader()
        ColumnHeader50 = New ColumnHeader()
        ColumnHeader53 = New ColumnHeader()
        IndUnenrollBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel43 = New MaterialSkin.Controls.MaterialLabel()
        IndSelectStudentDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader35 = New ColumnHeader()
        ColumnHeader36 = New ColumnHeader()
        ColumnHeader37 = New ColumnHeader()
        ColumnHeader38 = New ColumnHeader()
        ColumnHeader39 = New ColumnHeader()
        ColumnHeader40 = New ColumnHeader()
        MaterialLabel44 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel45 = New MaterialSkin.Controls.MaterialLabel()
        IndSearchStudentBox = New MaterialSkin.Controls.MaterialTextBox()
        CurrentCoursesHandled = New TabPage()
        MaterialCard9 = New MaterialSkin.Controls.MaterialCard()
        IniSearchForProfOrCourseBox = New MaterialSkin.Controls.MaterialTextBox()
        IniDataGrid = New MaterialSkin.Controls.MaterialListView()
        IniProfessorID = New ColumnHeader()
        IniFirstName = New ColumnHeader()
        IniLastName = New ColumnHeader()
        IniCourseIDColumnHeader = New ColumnHeader()
        ColumnHeader22 = New ColumnHeader()
        ColumnHeader24 = New ColumnHeader()
        ColumnHeader23 = New ColumnHeader()
        IniTeachesID = New ColumnHeader()
        MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        IniProfLbl = New MaterialSkin.Controls.MaterialLabel()
        IniDateLbl = New MaterialSkin.Controls.MaterialLabel()
        IniTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel15 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox3 = New PictureBox()
        MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        IniProfLastNameBox = New MaterialSkin.Controls.MaterialTextBox()
        IniDeleteBtn = New MaterialSkin.Controls.MaterialButton()
        IniUpdateBtn = New MaterialSkin.Controls.MaterialButton()
        IniClearBtn = New MaterialSkin.Controls.MaterialButton()
        IniSectionBox = New MaterialSkin.Controls.MaterialComboBox()
        IniCourseIdBox = New MaterialSkin.Controls.MaterialTextBox()
        IniCourse = New MaterialSkin.Controls.MaterialTextBox()
        IniAssignBtn = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel46 = New MaterialSkin.Controls.MaterialLabel()
        IniSelectProfessorDataGrid = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader17 = New ColumnHeader()
        ColumnHeader21 = New ColumnHeader()
        ColumnHeader33 = New ColumnHeader()
        IniProfID = New MaterialSkin.Controls.MaterialTextBox()
        IniProfFirstNameBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel42 = New MaterialSkin.Controls.MaterialLabel()
        IniChooseCourseDataGrid = New MaterialSkin.Controls.MaterialListView()
        IniCourseID = New ColumnHeader()
        IniCourseName = New ColumnHeader()
        IniTerm = New ColumnHeader()
        IniSem = New ColumnHeader()
        MaterialLabel16 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel17 = New MaterialSkin.Controls.MaterialLabel()
        Settings = New TabPage()
        MaterialCard18 = New MaterialSkin.Controls.MaterialCard()
        DarkModeSwitch = New MaterialSkin.Controls.MaterialSwitch()
        MaterialLabel49 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel50 = New MaterialSkin.Controls.MaterialLabel()
        SelfUpdateButton = New MaterialSkin.Controls.MaterialButton()
        AdminSelfPassword = New MaterialSkin.Controls.MaterialTextBox()
        AdminSelfUsernameBox = New MaterialSkin.Controls.MaterialTextBox()
        MaterialCard19 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel51 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel52 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard10 = New MaterialSkin.Controls.MaterialCard()
        SettingAdminLbl = New MaterialSkin.Controls.MaterialLabel()
        SettingsDateLabel = New MaterialSkin.Controls.MaterialLabel()
        SettingsTimeLbl = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel20 = New MaterialSkin.Controls.MaterialLabel()
        PictureBox4 = New PictureBox()
        SignOut = New TabPage()
        MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        SignOutCancel = New MaterialSkin.Controls.MaterialButton()
        SignOutYes = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        ImageList1 = New ImageList(components)
        Timer1 = New Timer(components)
        StudentRegistrationCard.SuspendLayout()
        StudentListCard.SuspendLayout()
        MaterialCard7.SuspendLayout()
        MaterialCard6.SuspendLayout()
        MaterialTabControl1.SuspendLayout()
        Professor.SuspendLayout()
        TopPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Student.SuspendLayout()
        MaterialCard2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CoursesAd.SuspendLayout()
        MaterialCard3.SuspendLayout()
        MaterialCard20.SuspendLayout()
        MaterialCard21.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        BulkEnrollment.SuspendLayout()
        MaterialCard13.SuspendLayout()
        MaterialCard12.SuspendLayout()
        MaterialCard11.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        MaterialCard1.SuspendLayout()
        IndividualEnrollment.SuspendLayout()
        MaterialCard14.SuspendLayout()
        MaterialCard15.SuspendLayout()
        MaterialCard16.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        MaterialCard17.SuspendLayout()
        CurrentCoursesHandled.SuspendLayout()
        MaterialCard9.SuspendLayout()
        MaterialCard8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MaterialCard5.SuspendLayout()
        Settings.SuspendLayout()
        MaterialCard18.SuspendLayout()
        MaterialCard19.SuspendLayout()
        MaterialCard10.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SignOut.SuspendLayout()
        MaterialCard4.SuspendLayout()
        SuspendLayout()
        ' 
        ' StudentRegistrationCard
        ' 
        StudentRegistrationCard.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        StudentRegistrationCard.Controls.Add(BtnAttachFile)
        StudentRegistrationCard.Controls.Add(StuClearBtn)
        StudentRegistrationCard.Controls.Add(StuDeleteBtn)
        StudentRegistrationCard.Controls.Add(StuUpdateBtn)
        StudentRegistrationCard.Controls.Add(MaterialLabel3)
        StudentRegistrationCard.Controls.Add(MaterialLabel4)
        StudentRegistrationCard.Controls.Add(RegStudentEmailAddress)
        StudentRegistrationCard.Controls.Add(RegStudentRegBtn)
        StudentRegistrationCard.Controls.Add(RegStudentSection)
        StudentRegistrationCard.Controls.Add(RegStudentMiddleName)
        StudentRegistrationCard.Controls.Add(RegStudentLastName)
        StudentRegistrationCard.Controls.Add(RegStudentFirstName)
        StudentRegistrationCard.Controls.Add(RegStudentId)
        StudentRegistrationCard.Depth = 0
        StudentRegistrationCard.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        StudentRegistrationCard.Location = New Point(14, 155)
        StudentRegistrationCard.Margin = New Padding(14)
        StudentRegistrationCard.MouseState = MaterialSkin.MouseState.HOVER
        StudentRegistrationCard.Name = "StudentRegistrationCard"
        StudentRegistrationCard.Padding = New Padding(30)
        StudentRegistrationCard.Size = New Size(526, 836)
        StudentRegistrationCard.TabIndex = 6
        ' 
        ' BtnAttachFile
        ' 
        BtnAttachFile.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnAttachFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BtnAttachFile.Depth = 0
        BtnAttachFile.HighEmphasis = True
        BtnAttachFile.Icon = Nothing
        BtnAttachFile.Location = New Point(334, 716)
        BtnAttachFile.Margin = New Padding(4, 6, 4, 6)
        BtnAttachFile.MouseState = MaterialSkin.MouseState.HOVER
        BtnAttachFile.Name = "BtnAttachFile"
        BtnAttachFile.NoAccentTextColor = Color.Empty
        BtnAttachFile.Size = New Size(159, 36)
        BtnAttachFile.TabIndex = 48
        BtnAttachFile.Text = "Attach Excel File"
        BtnAttachFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BtnAttachFile.UseAccentColor = False
        BtnAttachFile.UseVisualStyleBackColor = True
        ' 
        ' StuClearBtn
        ' 
        StuClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        StuClearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        StuClearBtn.Depth = 0
        StuClearBtn.HighEmphasis = True
        StuClearBtn.Icon = Nothing
        StuClearBtn.Location = New Point(426, 36)
        StuClearBtn.Margin = New Padding(4, 6, 4, 6)
        StuClearBtn.MouseState = MaterialSkin.MouseState.HOVER
        StuClearBtn.Name = "StuClearBtn"
        StuClearBtn.NoAccentTextColor = Color.Empty
        StuClearBtn.Size = New Size(66, 36)
        StuClearBtn.TabIndex = 47
        StuClearBtn.Text = "clear"
        StuClearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        StuClearBtn.UseAccentColor = True
        StuClearBtn.UseVisualStyleBackColor = True
        ' 
        ' StuDeleteBtn
        ' 
        StuDeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        StuDeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        StuDeleteBtn.Depth = 0
        StuDeleteBtn.HighEmphasis = True
        StuDeleteBtn.Icon = Nothing
        StuDeleteBtn.Location = New Point(33, 764)
        StuDeleteBtn.Margin = New Padding(4, 6, 4, 6)
        StuDeleteBtn.MouseState = MaterialSkin.MouseState.HOVER
        StuDeleteBtn.Name = "StuDeleteBtn"
        StuDeleteBtn.NoAccentTextColor = Color.Empty
        StuDeleteBtn.Size = New Size(73, 36)
        StuDeleteBtn.TabIndex = 31
        StuDeleteBtn.Text = "Delete"
        StuDeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        StuDeleteBtn.UseAccentColor = False
        StuDeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' StuUpdateBtn
        ' 
        StuUpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        StuUpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        StuUpdateBtn.Depth = 0
        StuUpdateBtn.HighEmphasis = True
        StuUpdateBtn.Icon = Nothing
        StuUpdateBtn.Location = New Point(317, 764)
        StuUpdateBtn.Margin = New Padding(4, 6, 4, 6)
        StuUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER
        StuUpdateBtn.Name = "StuUpdateBtn"
        StuUpdateBtn.NoAccentTextColor = Color.Empty
        StuUpdateBtn.Size = New Size(77, 36)
        StuUpdateBtn.TabIndex = 30
        StuUpdateBtn.Text = "update"
        StuUpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        StuUpdateBtn.UseAccentColor = False
        StuUpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        MaterialLabel3.Location = New Point(33, 71)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(123, 19)
        MaterialLabel3.TabIndex = 29
        MaterialLabel3.Text = "Register students"
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel4.Location = New Point(33, 30)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(300, 41)
        MaterialLabel4.TabIndex = 28
        MaterialLabel4.Text = "Student registration"
        ' 
        ' RegStudentEmailAddress
        ' 
        RegStudentEmailAddress.AnimateReadOnly = False
        RegStudentEmailAddress.BorderStyle = BorderStyle.None
        RegStudentEmailAddress.Depth = 0
        RegStudentEmailAddress.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        RegStudentEmailAddress.Hint = "Enter email address"
        RegStudentEmailAddress.LeadingIcon = My.Resources.Resources.email
        RegStudentEmailAddress.Location = New Point(33, 506)
        RegStudentEmailAddress.MaxLength = 50
        RegStudentEmailAddress.MouseState = MaterialSkin.MouseState.OUT
        RegStudentEmailAddress.Multiline = False
        RegStudentEmailAddress.Name = "RegStudentEmailAddress"
        RegStudentEmailAddress.Size = New Size(460, 50)
        RegStudentEmailAddress.TabIndex = 20
        RegStudentEmailAddress.Text = ""
        RegStudentEmailAddress.TrailingIcon = Nothing
        RegStudentEmailAddress.UseAccent = False
        ' 
        ' RegStudentRegBtn
        ' 
        RegStudentRegBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        RegStudentRegBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        RegStudentRegBtn.Depth = 0
        RegStudentRegBtn.HighEmphasis = True
        RegStudentRegBtn.Icon = Nothing
        RegStudentRegBtn.Location = New Point(404, 764)
        RegStudentRegBtn.Margin = New Padding(4, 6, 4, 6)
        RegStudentRegBtn.MouseState = MaterialSkin.MouseState.HOVER
        RegStudentRegBtn.Name = "RegStudentRegBtn"
        RegStudentRegBtn.NoAccentTextColor = Color.Empty
        RegStudentRegBtn.Size = New Size(89, 36)
        RegStudentRegBtn.TabIndex = 19
        RegStudentRegBtn.Text = "Register"
        RegStudentRegBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        RegStudentRegBtn.UseAccentColor = False
        RegStudentRegBtn.UseVisualStyleBackColor = True
        ' 
        ' RegStudentSection
        ' 
        RegStudentSection.AutoResize = False
        RegStudentSection.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        RegStudentSection.Depth = 0
        RegStudentSection.DrawMode = DrawMode.OwnerDrawVariable
        RegStudentSection.DropDownHeight = 174
        RegStudentSection.DropDownStyle = ComboBoxStyle.DropDownList
        RegStudentSection.DropDownWidth = 121
        RegStudentSection.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        RegStudentSection.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        RegStudentSection.FormattingEnabled = True
        RegStudentSection.Hint = "Select section"
        RegStudentSection.IntegralHeight = False
        RegStudentSection.ItemHeight = 43
        RegStudentSection.Items.AddRange(New Object() {"BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        RegStudentSection.Location = New Point(33, 428)
        RegStudentSection.MaxDropDownItems = 4
        RegStudentSection.MouseState = MaterialSkin.MouseState.OUT
        RegStudentSection.Name = "RegStudentSection"
        RegStudentSection.Size = New Size(460, 49)
        RegStudentSection.StartIndex = 0
        RegStudentSection.TabIndex = 16
        RegStudentSection.UseAccent = False
        ' 
        ' RegStudentMiddleName
        ' 
        RegStudentMiddleName.AnimateReadOnly = False
        RegStudentMiddleName.BorderStyle = BorderStyle.None
        RegStudentMiddleName.Depth = 0
        RegStudentMiddleName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        RegStudentMiddleName.Hint = "Enter middle name"
        RegStudentMiddleName.LeadingIcon = Nothing
        RegStudentMiddleName.Location = New Point(33, 350)
        RegStudentMiddleName.MaxLength = 50
        RegStudentMiddleName.MouseState = MaterialSkin.MouseState.OUT
        RegStudentMiddleName.Multiline = False
        RegStudentMiddleName.Name = "RegStudentMiddleName"
        RegStudentMiddleName.Size = New Size(460, 50)
        RegStudentMiddleName.TabIndex = 13
        RegStudentMiddleName.Text = ""
        RegStudentMiddleName.TrailingIcon = Nothing
        RegStudentMiddleName.UseAccent = False
        ' 
        ' RegStudentLastName
        ' 
        RegStudentLastName.AnimateReadOnly = False
        RegStudentLastName.BorderStyle = BorderStyle.None
        RegStudentLastName.Depth = 0
        RegStudentLastName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        RegStudentLastName.Hint = "Enter last name"
        RegStudentLastName.LeadingIcon = Nothing
        RegStudentLastName.Location = New Point(33, 272)
        RegStudentLastName.MaxLength = 50
        RegStudentLastName.MouseState = MaterialSkin.MouseState.OUT
        RegStudentLastName.Multiline = False
        RegStudentLastName.Name = "RegStudentLastName"
        RegStudentLastName.Size = New Size(460, 50)
        RegStudentLastName.TabIndex = 12
        RegStudentLastName.Text = ""
        RegStudentLastName.TrailingIcon = Nothing
        RegStudentLastName.UseAccent = False
        ' 
        ' RegStudentFirstName
        ' 
        RegStudentFirstName.AnimateReadOnly = False
        RegStudentFirstName.BorderStyle = BorderStyle.None
        RegStudentFirstName.Depth = 0
        RegStudentFirstName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        RegStudentFirstName.Hint = "Enter first name"
        RegStudentFirstName.LeadingIcon = Nothing
        RegStudentFirstName.Location = New Point(33, 194)
        RegStudentFirstName.MaxLength = 50
        RegStudentFirstName.MouseState = MaterialSkin.MouseState.OUT
        RegStudentFirstName.Multiline = False
        RegStudentFirstName.Name = "RegStudentFirstName"
        RegStudentFirstName.Size = New Size(460, 50)
        RegStudentFirstName.TabIndex = 11
        RegStudentFirstName.Text = ""
        RegStudentFirstName.TrailingIcon = Nothing
        RegStudentFirstName.UseAccent = False
        ' 
        ' RegStudentId
        ' 
        RegStudentId.AnimateReadOnly = False
        RegStudentId.BorderStyle = BorderStyle.None
        RegStudentId.Depth = 0
        RegStudentId.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        RegStudentId.Hint = "Enter student id"
        RegStudentId.LeadingIcon = My.Resources.Resources.hash
        RegStudentId.Location = New Point(33, 116)
        RegStudentId.MaxLength = 50
        RegStudentId.MouseState = MaterialSkin.MouseState.OUT
        RegStudentId.Multiline = False
        RegStudentId.Name = "RegStudentId"
        RegStudentId.Size = New Size(460, 50)
        RegStudentId.TabIndex = 10
        RegStudentId.Text = ""
        RegStudentId.TrailingIcon = Nothing
        RegStudentId.UseAccent = False
        ' 
        ' StudentListCard
        ' 
        StudentListCard.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        StudentListCard.Controls.Add(StudentDataGridView)
        StudentListCard.Controls.Add(SearchStudentTxtBox)
        StudentListCard.Depth = 0
        StudentListCard.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        StudentListCard.Location = New Point(571, 155)
        StudentListCard.Margin = New Padding(14)
        StudentListCard.MouseState = MaterialSkin.MouseState.HOVER
        StudentListCard.Name = "StudentListCard"
        StudentListCard.Padding = New Padding(30)
        StudentListCard.Size = New Size(1271, 836)
        StudentListCard.TabIndex = 7
        ' 
        ' StudentDataGridView
        ' 
        StudentDataGridView.AutoSizeTable = False
        StudentDataGridView.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        StudentDataGridView.BorderStyle = BorderStyle.None
        StudentDataGridView.Columns.AddRange(New ColumnHeader() {ColumnHeader9, ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader15, ColumnHeader16})
        StudentDataGridView.Depth = 0
        StudentDataGridView.Dock = DockStyle.Bottom
        StudentDataGridView.FullRowSelect = True
        StudentDataGridView.Location = New Point(30, 116)
        StudentDataGridView.MinimumSize = New Size(200, 100)
        StudentDataGridView.MouseLocation = New Point(-1, -1)
        StudentDataGridView.MouseState = MaterialSkin.MouseState.OUT
        StudentDataGridView.Name = "StudentDataGridView"
        StudentDataGridView.OwnerDraw = True
        StudentDataGridView.Size = New Size(1211, 690)
        StudentDataGridView.TabIndex = 36
        StudentDataGridView.UseCompatibleStateImageBehavior = False
        StudentDataGridView.View = View.Details
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Stud ID"
        ColumnHeader9.Width = 160
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "First Name"
        ColumnHeader10.Width = 200
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "Last Name"
        ColumnHeader11.Width = 200
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "Middle Name"
        ColumnHeader12.Width = 200
        ' 
        ' ColumnHeader15
        ' 
        ColumnHeader15.Text = "Section"
        ColumnHeader15.Width = 150
        ' 
        ' ColumnHeader16
        ' 
        ColumnHeader16.Text = "Email"
        ColumnHeader16.Width = 300
        ' 
        ' SearchStudentTxtBox
        ' 
        SearchStudentTxtBox.AnimateReadOnly = False
        SearchStudentTxtBox.BorderStyle = BorderStyle.None
        SearchStudentTxtBox.Depth = 0
        SearchStudentTxtBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        SearchStudentTxtBox.Hint = "Search for student name"
        SearchStudentTxtBox.LeadingIcon = My.Resources.Resources.magnifier
        SearchStudentTxtBox.Location = New Point(33, 33)
        SearchStudentTxtBox.MaxLength = 50
        SearchStudentTxtBox.MouseState = MaterialSkin.MouseState.OUT
        SearchStudentTxtBox.Multiline = False
        SearchStudentTxtBox.Name = "SearchStudentTxtBox"
        SearchStudentTxtBox.Size = New Size(1205, 50)
        SearchStudentTxtBox.TabIndex = 11
        SearchStudentTxtBox.Text = ""
        SearchStudentTxtBox.TrailingIcon = Nothing
        SearchStudentTxtBox.UseAccent = False
        ' 
        ' MaterialCard7
        ' 
        MaterialCard7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard7.Controls.Add(ProfessorDataGrid)
        MaterialCard7.Controls.Add(ProfSearchBox)
        MaterialCard7.Depth = 0
        MaterialCard7.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard7.Location = New Point(571, 155)
        MaterialCard7.Margin = New Padding(14)
        MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard7.Name = "MaterialCard7"
        MaterialCard7.Padding = New Padding(30)
        MaterialCard7.Size = New Size(1271, 833)
        MaterialCard7.TabIndex = 7
        ' 
        ' ProfessorDataGrid
        ' 
        ProfessorDataGrid.AutoSizeTable = False
        ProfessorDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ProfessorDataGrid.BorderStyle = BorderStyle.None
        ProfessorDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader25, ColumnHeader43, ColumnHeader44, ColumnHeader45, ColumnHeader46, ColumnHeader47, ColumnHeader48})
        ProfessorDataGrid.Depth = 0
        ProfessorDataGrid.Dock = DockStyle.Bottom
        ProfessorDataGrid.FullRowSelect = True
        ProfessorDataGrid.Location = New Point(30, 113)
        ProfessorDataGrid.MinimumSize = New Size(200, 100)
        ProfessorDataGrid.MouseLocation = New Point(-1, -1)
        ProfessorDataGrid.MouseState = MaterialSkin.MouseState.OUT
        ProfessorDataGrid.Name = "ProfessorDataGrid"
        ProfessorDataGrid.OwnerDraw = True
        ProfessorDataGrid.Size = New Size(1211, 690)
        ProfessorDataGrid.TabIndex = 37
        ProfessorDataGrid.UseCompatibleStateImageBehavior = False
        ProfessorDataGrid.View = View.Details
        ' 
        ' ColumnHeader25
        ' 
        ColumnHeader25.Text = "Prof ID"
        ColumnHeader25.Width = 160
        ' 
        ' ColumnHeader43
        ' 
        ColumnHeader43.Text = "First Name"
        ColumnHeader43.Width = 200
        ' 
        ' ColumnHeader44
        ' 
        ColumnHeader44.Text = "Last Name"
        ColumnHeader44.Width = 200
        ' 
        ' ColumnHeader45
        ' 
        ColumnHeader45.Text = "Middle Name"
        ColumnHeader45.Width = 200
        ' 
        ' ColumnHeader46
        ' 
        ColumnHeader46.Text = "Email"
        ColumnHeader46.Width = 150
        ' 
        ' ColumnHeader47
        ' 
        ColumnHeader47.Text = "Username"
        ColumnHeader47.Width = 300
        ' 
        ' ColumnHeader48
        ' 
        ColumnHeader48.Text = "Password"
        ' 
        ' ProfSearchBox
        ' 
        ProfSearchBox.AnimateReadOnly = False
        ProfSearchBox.BorderStyle = BorderStyle.None
        ProfSearchBox.Depth = 0
        ProfSearchBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfSearchBox.Hint = "Search for professor"
        ProfSearchBox.LeadingIcon = My.Resources.Resources.magnifier
        ProfSearchBox.Location = New Point(30, 33)
        ProfSearchBox.MaxLength = 50
        ProfSearchBox.MouseState = MaterialSkin.MouseState.OUT
        ProfSearchBox.Multiline = False
        ProfSearchBox.Name = "ProfSearchBox"
        ProfSearchBox.Size = New Size(1208, 50)
        ProfSearchBox.TabIndex = 11
        ProfSearchBox.Text = ""
        ProfSearchBox.TrailingIcon = Nothing
        ProfSearchBox.UseAccent = False
        ' 
        ' MaterialCard6
        ' 
        MaterialCard6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard6.Controls.Add(ProfClearBtn)
        MaterialCard6.Controls.Add(MaterialLabel2)
        MaterialCard6.Controls.Add(MaterialLabel1)
        MaterialCard6.Controls.Add(ProfDeleteBtn)
        MaterialCard6.Controls.Add(ProfUpdateBtn)
        MaterialCard6.Controls.Add(ProfConfirmPass)
        MaterialCard6.Controls.Add(ProfPassword)
        MaterialCard6.Controls.Add(ProfUsername)
        MaterialCard6.Controls.Add(ProfEmail)
        MaterialCard6.Controls.Add(ProfRegisterBtn)
        MaterialCard6.Controls.Add(ProfMiddleName)
        MaterialCard6.Controls.Add(ProfLastName)
        MaterialCard6.Controls.Add(ProfFirstName)
        MaterialCard6.Depth = 0
        MaterialCard6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard6.Location = New Point(14, 155)
        MaterialCard6.Margin = New Padding(14)
        MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard6.Name = "MaterialCard6"
        MaterialCard6.Padding = New Padding(30)
        MaterialCard6.Size = New Size(526, 833)
        MaterialCard6.TabIndex = 6
        ' 
        ' ProfClearBtn
        ' 
        ProfClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ProfClearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ProfClearBtn.Depth = 0
        ProfClearBtn.HighEmphasis = True
        ProfClearBtn.Icon = Nothing
        ProfClearBtn.Location = New Point(426, 36)
        ProfClearBtn.Margin = New Padding(4, 6, 4, 6)
        ProfClearBtn.MouseState = MaterialSkin.MouseState.HOVER
        ProfClearBtn.Name = "ProfClearBtn"
        ProfClearBtn.NoAccentTextColor = Color.Empty
        ProfClearBtn.Size = New Size(66, 36)
        ProfClearBtn.TabIndex = 46
        ProfClearBtn.Text = "clear"
        ProfClearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ProfClearBtn.UseAccentColor = True
        ProfClearBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        MaterialLabel2.Location = New Point(33, 71)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(129, 19)
        MaterialLabel2.TabIndex = 27
        MaterialLabel2.Text = "Register professor"
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
        MaterialLabel1.Size = New Size(332, 41)
        MaterialLabel1.TabIndex = 26
        MaterialLabel1.Text = "Professor registration"
        ' 
        ' ProfDeleteBtn
        ' 
        ProfDeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ProfDeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ProfDeleteBtn.Depth = 0
        ProfDeleteBtn.HighEmphasis = True
        ProfDeleteBtn.Icon = Nothing
        ProfDeleteBtn.Location = New Point(33, 760)
        ProfDeleteBtn.Margin = New Padding(4, 6, 4, 6)
        ProfDeleteBtn.MouseState = MaterialSkin.MouseState.HOVER
        ProfDeleteBtn.Name = "ProfDeleteBtn"
        ProfDeleteBtn.NoAccentTextColor = Color.Empty
        ProfDeleteBtn.Size = New Size(73, 36)
        ProfDeleteBtn.TabIndex = 25
        ProfDeleteBtn.Text = "Delete"
        ProfDeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ProfDeleteBtn.UseAccentColor = False
        ProfDeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' ProfUpdateBtn
        ' 
        ProfUpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ProfUpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ProfUpdateBtn.Depth = 0
        ProfUpdateBtn.HighEmphasis = True
        ProfUpdateBtn.Icon = Nothing
        ProfUpdateBtn.Location = New Point(317, 760)
        ProfUpdateBtn.Margin = New Padding(4, 6, 4, 6)
        ProfUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER
        ProfUpdateBtn.Name = "ProfUpdateBtn"
        ProfUpdateBtn.NoAccentTextColor = Color.Empty
        ProfUpdateBtn.Size = New Size(77, 36)
        ProfUpdateBtn.TabIndex = 24
        ProfUpdateBtn.Text = "update"
        ProfUpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ProfUpdateBtn.UseAccentColor = False
        ProfUpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' ProfConfirmPass
        ' 
        ProfConfirmPass.AnimateReadOnly = False
        ProfConfirmPass.BorderStyle = BorderStyle.None
        ProfConfirmPass.Depth = 0
        ProfConfirmPass.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfConfirmPass.Hint = "Enter confirm password"
        ProfConfirmPass.LeadingIcon = Nothing
        ProfConfirmPass.Location = New Point(33, 628)
        ProfConfirmPass.MaxLength = 50
        ProfConfirmPass.MouseState = MaterialSkin.MouseState.OUT
        ProfConfirmPass.Multiline = False
        ProfConfirmPass.Name = "ProfConfirmPass"
        ProfConfirmPass.Password = True
        ProfConfirmPass.Size = New Size(460, 50)
        ProfConfirmPass.TabIndex = 23
        ProfConfirmPass.Text = ""
        ProfConfirmPass.TrailingIcon = Nothing
        ProfConfirmPass.UseAccent = False
        ' 
        ' ProfPassword
        ' 
        ProfPassword.AnimateReadOnly = False
        ProfPassword.BorderStyle = BorderStyle.None
        ProfPassword.Depth = 0
        ProfPassword.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfPassword.Hint = "Enter password"
        ProfPassword.LeadingIcon = My.Resources.Resources.padlock
        ProfPassword.Location = New Point(33, 548)
        ProfPassword.MaxLength = 50
        ProfPassword.MouseState = MaterialSkin.MouseState.OUT
        ProfPassword.Multiline = False
        ProfPassword.Name = "ProfPassword"
        ProfPassword.Password = True
        ProfPassword.Size = New Size(460, 50)
        ProfPassword.TabIndex = 22
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
        ProfUsername.Hint = "Enter username"
        ProfUsername.LeadingIcon = My.Resources.Resources.user
        ProfUsername.Location = New Point(33, 468)
        ProfUsername.MaxLength = 50
        ProfUsername.MouseState = MaterialSkin.MouseState.OUT
        ProfUsername.Multiline = False
        ProfUsername.Name = "ProfUsername"
        ProfUsername.Size = New Size(460, 50)
        ProfUsername.TabIndex = 21
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
        ProfEmail.Hint = "Enter email address"
        ProfEmail.LeadingIcon = My.Resources.Resources.email
        ProfEmail.Location = New Point(33, 388)
        ProfEmail.MaxLength = 50
        ProfEmail.MouseState = MaterialSkin.MouseState.OUT
        ProfEmail.Multiline = False
        ProfEmail.Name = "ProfEmail"
        ProfEmail.Size = New Size(460, 50)
        ProfEmail.TabIndex = 20
        ProfEmail.Text = ""
        ProfEmail.TrailingIcon = Nothing
        ProfEmail.UseAccent = False
        ' 
        ' ProfRegisterBtn
        ' 
        ProfRegisterBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ProfRegisterBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ProfRegisterBtn.Depth = 0
        ProfRegisterBtn.HighEmphasis = True
        ProfRegisterBtn.Icon = Nothing
        ProfRegisterBtn.Location = New Point(403, 761)
        ProfRegisterBtn.Margin = New Padding(4, 6, 4, 6)
        ProfRegisterBtn.MouseState = MaterialSkin.MouseState.HOVER
        ProfRegisterBtn.Name = "ProfRegisterBtn"
        ProfRegisterBtn.NoAccentTextColor = Color.Empty
        ProfRegisterBtn.Size = New Size(89, 36)
        ProfRegisterBtn.TabIndex = 19
        ProfRegisterBtn.Text = "Register"
        ProfRegisterBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ProfRegisterBtn.UseAccentColor = False
        ProfRegisterBtn.UseVisualStyleBackColor = True
        ' 
        ' ProfMiddleName
        ' 
        ProfMiddleName.AnimateReadOnly = False
        ProfMiddleName.BorderStyle = BorderStyle.None
        ProfMiddleName.Depth = 0
        ProfMiddleName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        ProfMiddleName.Hint = "Enter middle name"
        ProfMiddleName.LeadingIcon = Nothing
        ProfMiddleName.Location = New Point(33, 308)
        ProfMiddleName.MaxLength = 50
        ProfMiddleName.MouseState = MaterialSkin.MouseState.OUT
        ProfMiddleName.Multiline = False
        ProfMiddleName.Name = "ProfMiddleName"
        ProfMiddleName.Size = New Size(460, 50)
        ProfMiddleName.TabIndex = 13
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
        ProfLastName.Hint = "Enter last name"
        ProfLastName.LeadingIcon = Nothing
        ProfLastName.Location = New Point(33, 228)
        ProfLastName.MaxLength = 50
        ProfLastName.MouseState = MaterialSkin.MouseState.OUT
        ProfLastName.Multiline = False
        ProfLastName.Name = "ProfLastName"
        ProfLastName.Size = New Size(460, 50)
        ProfLastName.TabIndex = 12
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
        ProfFirstName.Hint = "Enter first name"
        ProfFirstName.LeadingIcon = Nothing
        ProfFirstName.Location = New Point(33, 148)
        ProfFirstName.MaxLength = 50
        ProfFirstName.MouseState = MaterialSkin.MouseState.OUT
        ProfFirstName.Multiline = False
        ProfFirstName.Name = "ProfFirstName"
        ProfFirstName.Size = New Size(460, 50)
        ProfFirstName.TabIndex = 11
        ProfFirstName.Text = ""
        ProfFirstName.TrailingIcon = Nothing
        ProfFirstName.UseAccent = False
        ' 
        ' MaterialDrawer1
        ' 
        MaterialDrawer1.AutoHide = False
        MaterialDrawer1.AutoShow = False
        MaterialDrawer1.BackgroundWithAccent = False
        MaterialDrawer1.BaseTabControl = Nothing
        MaterialDrawer1.Depth = 0
        MaterialDrawer1.HighlightWithAccent = True
        MaterialDrawer1.IndicatorWidth = 0
        MaterialDrawer1.IsOpen = False
        MaterialDrawer1.Location = New Point(-312, 154)
        MaterialDrawer1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialDrawer1.Name = "MaterialDrawer1"
        MaterialDrawer1.ShowIconsWhenHidden = False
        MaterialDrawer1.Size = New Size(312, 150)
        MaterialDrawer1.TabIndex = 12
        MaterialDrawer1.Text = "MaterialDrawer1"
        MaterialDrawer1.UseColors = False
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.Alignment = TabAlignment.Left
        MaterialTabControl1.Controls.Add(Professor)
        MaterialTabControl1.Controls.Add(Student)
        MaterialTabControl1.Controls.Add(CoursesAd)
        MaterialTabControl1.Controls.Add(BulkEnrollment)
        MaterialTabControl1.Controls.Add(IndividualEnrollment)
        MaterialTabControl1.Controls.Add(CurrentCoursesHandled)
        MaterialTabControl1.Controls.Add(Settings)
        MaterialTabControl1.Controls.Add(SignOut)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.Dock = DockStyle.Fill
        MaterialTabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MaterialTabControl1.ImageList = ImageList1
        MaterialTabControl1.ItemSize = New Size(102, 20)
        MaterialTabControl1.Location = New Point(3, 64)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(1917, 1013)
        MaterialTabControl1.TabIndex = 13
        ' 
        ' Professor
        ' 
        Professor.Controls.Add(TopPanel)
        Professor.Controls.Add(MaterialCard6)
        Professor.Controls.Add(MaterialCard7)
        Professor.ImageKey = "teacher (1) (1).png"
        Professor.Location = New Point(44, 4)
        Professor.Name = "Professor"
        Professor.Padding = New Padding(3)
        Professor.Size = New Size(1869, 1005)
        Professor.TabIndex = 0
        Professor.Text = "Professor"
        Professor.UseVisualStyleBackColor = True
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        TopPanel.Controls.Add(AdminProfAdminLbl)
        TopPanel.Controls.Add(DateLabelProf)
        TopPanel.Controls.Add(TimeLabelProf)
        TopPanel.Controls.Add(MaterialLabel7)
        TopPanel.Controls.Add(PictureBox1)
        TopPanel.Depth = 0
        TopPanel.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        TopPanel.Location = New Point(14, 14)
        TopPanel.Margin = New Padding(14)
        TopPanel.MouseState = MaterialSkin.MouseState.HOVER
        TopPanel.Name = "TopPanel"
        TopPanel.Padding = New Padding(30)
        TopPanel.Size = New Size(1828, 110)
        TopPanel.TabIndex = 8
        ' 
        ' AdminProfAdminLbl
        ' 
        AdminProfAdminLbl.AutoSize = True
        AdminProfAdminLbl.Depth = 0
        AdminProfAdminLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        AdminProfAdminLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        AdminProfAdminLbl.Location = New Point(1531, 24)
        AdminProfAdminLbl.MouseState = MaterialSkin.MouseState.HOVER
        AdminProfAdminLbl.Name = "AdminProfAdminLbl"
        AdminProfAdminLbl.Size = New Size(264, 24)
        AdminProfAdminLbl.TabIndex = 7
        AdminProfAdminLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' DateLabelProf
        ' 
        DateLabelProf.AutoSize = True
        DateLabelProf.Depth = 0
        DateLabelProf.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        DateLabelProf.Location = New Point(1667, 48)
        DateLabelProf.MouseState = MaterialSkin.MouseState.HOVER
        DateLabelProf.Name = "DateLabelProf"
        DateLabelProf.Size = New Size(128, 19)
        DateLabelProf.TabIndex = 6
        DateLabelProf.Text = "December 5, 2024"
        ' 
        ' TimeLabelProf
        ' 
        TimeLabelProf.AutoSize = True
        TimeLabelProf.Depth = 0
        TimeLabelProf.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        TimeLabelProf.Location = New Point(1754, 67)
        TimeLabelProf.MouseState = MaterialSkin.MouseState.HOVER
        TimeLabelProf.Name = "TimeLabelProf"
        TimeLabelProf.Size = New Size(41, 19)
        TimeLabelProf.TabIndex = 5
        TimeLabelProf.Text = "11:04"
        ' 
        ' MaterialLabel7
        ' 
        MaterialLabel7.AutoSize = True
        MaterialLabel7.Depth = 0
        MaterialLabel7.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel7.Location = New Point(485, 26)
        MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel7.Name = "MaterialLabel7"
        MaterialLabel7.Size = New Size(855, 58)
        MaterialLabel7.TabIndex = 1
        MaterialLabel7.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
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
        ' Student
        ' 
        Student.Controls.Add(MaterialCard2)
        Student.Controls.Add(StudentListCard)
        Student.Controls.Add(StudentRegistrationCard)
        Student.ImageKey = "reading-book (1).png"
        Student.Location = New Point(44, 4)
        Student.Name = "Student"
        Student.Padding = New Padding(3)
        Student.Size = New Size(1869, 1005)
        Student.TabIndex = 1
        Student.Text = "Student"
        Student.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(StuAdminLbl)
        MaterialCard2.Controls.Add(StuDateLbl)
        MaterialCard2.Controls.Add(StuTimeLbl)
        MaterialCard2.Controls.Add(MaterialLabel10)
        MaterialCard2.Controls.Add(PictureBox2)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(14, 14)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(30)
        MaterialCard2.Size = New Size(1825, 110)
        MaterialCard2.TabIndex = 9
        ' 
        ' StuAdminLbl
        ' 
        StuAdminLbl.AutoSize = True
        StuAdminLbl.Depth = 0
        StuAdminLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        StuAdminLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        StuAdminLbl.Location = New Point(1528, 24)
        StuAdminLbl.MouseState = MaterialSkin.MouseState.HOVER
        StuAdminLbl.Name = "StuAdminLbl"
        StuAdminLbl.Size = New Size(264, 24)
        StuAdminLbl.TabIndex = 7
        StuAdminLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' StuDateLbl
        ' 
        StuDateLbl.AutoSize = True
        StuDateLbl.Depth = 0
        StuDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        StuDateLbl.Location = New Point(1664, 48)
        StuDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        StuDateLbl.Name = "StuDateLbl"
        StuDateLbl.Size = New Size(128, 19)
        StuDateLbl.TabIndex = 6
        StuDateLbl.Text = "December 5, 2024"
        ' 
        ' StuTimeLbl
        ' 
        StuTimeLbl.AutoSize = True
        StuTimeLbl.Depth = 0
        StuTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        StuTimeLbl.Location = New Point(1751, 67)
        StuTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        StuTimeLbl.Name = "StuTimeLbl"
        StuTimeLbl.Size = New Size(41, 19)
        StuTimeLbl.TabIndex = 5
        StuTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel10
        ' 
        MaterialLabel10.AutoSize = True
        MaterialLabel10.Depth = 0
        MaterialLabel10.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel10.Location = New Point(485, 26)
        MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel10.Name = "MaterialLabel10"
        MaterialLabel10.Size = New Size(855, 58)
        MaterialLabel10.TabIndex = 1
        MaterialLabel10.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.PLP_logo1
        PictureBox2.Location = New Point(33, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' CoursesAd
        ' 
        CoursesAd.Controls.Add(MaterialCard3)
        CoursesAd.Controls.Add(MaterialCard20)
        CoursesAd.Controls.Add(MaterialCard21)
        CoursesAd.ImageKey = "online-course (1).png"
        CoursesAd.Location = New Point(44, 4)
        CoursesAd.Name = "CoursesAd"
        CoursesAd.Size = New Size(1869, 1005)
        CoursesAd.TabIndex = 7
        CoursesAd.Text = "Courses"
        CoursesAd.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(AddSearchCourseBox)
        MaterialCard3.Controls.Add(AddCourseDataGrid)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(660, 152)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(30)
        MaterialCard3.Size = New Size(1179, 839)
        MaterialCard3.TabIndex = 16
        ' 
        ' AddSearchCourseBox
        ' 
        AddSearchCourseBox.AnimateReadOnly = False
        AddSearchCourseBox.BorderStyle = BorderStyle.None
        AddSearchCourseBox.Depth = 0
        AddSearchCourseBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        AddSearchCourseBox.Hint = "Search for course"
        AddSearchCourseBox.LeadingIcon = My.Resources.Resources.magnifier
        AddSearchCourseBox.Location = New Point(30, 33)
        AddSearchCourseBox.MaxLength = 50
        AddSearchCourseBox.MouseState = MaterialSkin.MouseState.OUT
        AddSearchCourseBox.Multiline = False
        AddSearchCourseBox.Name = "AddSearchCourseBox"
        AddSearchCourseBox.Size = New Size(1119, 50)
        AddSearchCourseBox.TabIndex = 37
        AddSearchCourseBox.Text = ""
        AddSearchCourseBox.TrailingIcon = Nothing
        AddSearchCourseBox.UseAccent = False
        ' 
        ' AddCourseDataGrid
        ' 
        AddCourseDataGrid.AutoSizeTable = False
        AddCourseDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        AddCourseDataGrid.BorderStyle = BorderStyle.None
        AddCourseDataGrid.Columns.AddRange(New ColumnHeader() {CourCourseID, CourCourseName})
        AddCourseDataGrid.Depth = 0
        AddCourseDataGrid.Dock = DockStyle.Bottom
        AddCourseDataGrid.FullRowSelect = True
        AddCourseDataGrid.Location = New Point(30, 100)
        AddCourseDataGrid.MinimumSize = New Size(200, 100)
        AddCourseDataGrid.MouseLocation = New Point(-1, -1)
        AddCourseDataGrid.MouseState = MaterialSkin.MouseState.OUT
        AddCourseDataGrid.Name = "AddCourseDataGrid"
        AddCourseDataGrid.OwnerDraw = True
        AddCourseDataGrid.Size = New Size(1119, 709)
        AddCourseDataGrid.TabIndex = 36
        AddCourseDataGrid.UseCompatibleStateImageBehavior = False
        AddCourseDataGrid.View = View.Details
        ' 
        ' CourCourseID
        ' 
        CourCourseID.Text = "Course ID"
        CourCourseID.Width = 600
        ' 
        ' CourCourseName
        ' 
        CourCourseName.Text = "Course Name"
        CourCourseName.Width = 600
        ' 
        ' MaterialCard20
        ' 
        MaterialCard20.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard20.Controls.Add(AddClearBtn)
        MaterialCard20.Controls.Add(AddDeleteCourseBtn)
        MaterialCard20.Controls.Add(AddUpdateCourseBtn)
        MaterialCard20.Controls.Add(AddAddCourseBtn)
        MaterialCard20.Controls.Add(MaterialLabel47)
        MaterialCard20.Controls.Add(MaterialLabel48)
        MaterialCard20.Controls.Add(MaterialLabel53)
        MaterialCard20.Controls.Add(AddCourseNameBox)
        MaterialCard20.Depth = 0
        MaterialCard20.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard20.Location = New Point(14, 152)
        MaterialCard20.Margin = New Padding(14)
        MaterialCard20.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard20.Name = "MaterialCard20"
        MaterialCard20.Padding = New Padding(30)
        MaterialCard20.Size = New Size(618, 839)
        MaterialCard20.TabIndex = 15
        ' 
        ' AddClearBtn
        ' 
        AddClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        AddClearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        AddClearBtn.Depth = 0
        AddClearBtn.HighEmphasis = True
        AddClearBtn.Icon = Nothing
        AddClearBtn.Location = New Point(518, 36)
        AddClearBtn.Margin = New Padding(4, 6, 4, 6)
        AddClearBtn.MouseState = MaterialSkin.MouseState.HOVER
        AddClearBtn.Name = "AddClearBtn"
        AddClearBtn.NoAccentTextColor = Color.Empty
        AddClearBtn.Size = New Size(66, 36)
        AddClearBtn.TabIndex = 45
        AddClearBtn.Text = "clear"
        AddClearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        AddClearBtn.UseAccentColor = True
        AddClearBtn.UseVisualStyleBackColor = True
        ' 
        ' AddDeleteCourseBtn
        ' 
        AddDeleteCourseBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        AddDeleteCourseBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        AddDeleteCourseBtn.Depth = 0
        AddDeleteCourseBtn.HighEmphasis = True
        AddDeleteCourseBtn.Icon = Nothing
        AddDeleteCourseBtn.Location = New Point(35, 767)
        AddDeleteCourseBtn.Margin = New Padding(4, 6, 4, 6)
        AddDeleteCourseBtn.MouseState = MaterialSkin.MouseState.HOVER
        AddDeleteCourseBtn.Name = "AddDeleteCourseBtn"
        AddDeleteCourseBtn.NoAccentTextColor = Color.Empty
        AddDeleteCourseBtn.Size = New Size(73, 36)
        AddDeleteCourseBtn.TabIndex = 42
        AddDeleteCourseBtn.Text = "DELETE"
        AddDeleteCourseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        AddDeleteCourseBtn.UseAccentColor = False
        AddDeleteCourseBtn.UseVisualStyleBackColor = True
        ' 
        ' AddUpdateCourseBtn
        ' 
        AddUpdateCourseBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        AddUpdateCourseBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        AddUpdateCourseBtn.Depth = 0
        AddUpdateCourseBtn.HighEmphasis = True
        AddUpdateCourseBtn.Icon = Nothing
        AddUpdateCourseBtn.Location = New Point(436, 767)
        AddUpdateCourseBtn.Margin = New Padding(4, 6, 4, 6)
        AddUpdateCourseBtn.MouseState = MaterialSkin.MouseState.HOVER
        AddUpdateCourseBtn.Name = "AddUpdateCourseBtn"
        AddUpdateCourseBtn.NoAccentTextColor = Color.Empty
        AddUpdateCourseBtn.Size = New Size(77, 36)
        AddUpdateCourseBtn.TabIndex = 40
        AddUpdateCourseBtn.Text = "UPDATE"
        AddUpdateCourseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        AddUpdateCourseBtn.UseAccentColor = False
        AddUpdateCourseBtn.UseVisualStyleBackColor = True
        ' 
        ' AddAddCourseBtn
        ' 
        AddAddCourseBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        AddAddCourseBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        AddAddCourseBtn.Depth = 0
        AddAddCourseBtn.HighEmphasis = True
        AddAddCourseBtn.Icon = Nothing
        AddAddCourseBtn.Location = New Point(521, 767)
        AddAddCourseBtn.Margin = New Padding(4, 6, 4, 6)
        AddAddCourseBtn.MouseState = MaterialSkin.MouseState.HOVER
        AddAddCourseBtn.Name = "AddAddCourseBtn"
        AddAddCourseBtn.NoAccentTextColor = Color.Empty
        AddAddCourseBtn.Size = New Size(64, 36)
        AddAddCourseBtn.TabIndex = 39
        AddAddCourseBtn.Text = "Add"
        AddAddCourseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        AddAddCourseBtn.UseAccentColor = False
        AddAddCourseBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel47
        ' 
        MaterialLabel47.AutoSize = True
        MaterialLabel47.Depth = 0
        MaterialLabel47.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel47.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel47.Location = New Point(34, 249)
        MaterialLabel47.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel47.Name = "MaterialLabel47"
        MaterialLabel47.Size = New Size(73, 14)
        MaterialLabel47.TabIndex = 38
        MaterialLabel47.Text = "Course name"
        ' 
        ' MaterialLabel48
        ' 
        MaterialLabel48.AutoSize = True
        MaterialLabel48.Depth = 0
        MaterialLabel48.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel48.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel48.Location = New Point(33, 71)
        MaterialLabel48.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel48.Name = "MaterialLabel48"
        MaterialLabel48.Size = New Size(100, 17)
        MaterialLabel48.TabIndex = 32
        MaterialLabel48.Text = "Add and modify"
        ' 
        ' MaterialLabel53
        ' 
        MaterialLabel53.AutoSize = True
        MaterialLabel53.Depth = 0
        MaterialLabel53.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel53.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel53.Location = New Point(33, 30)
        MaterialLabel53.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel53.Name = "MaterialLabel53"
        MaterialLabel53.Size = New Size(127, 41)
        MaterialLabel53.TabIndex = 31
        MaterialLabel53.Text = "Courses"
        ' 
        ' AddCourseNameBox
        ' 
        AddCourseNameBox.AnimateReadOnly = False
        AddCourseNameBox.BorderStyle = BorderStyle.None
        AddCourseNameBox.Depth = 0
        AddCourseNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        AddCourseNameBox.Hint = "Course name"
        AddCourseNameBox.LeadingIcon = Nothing
        AddCourseNameBox.Location = New Point(33, 183)
        AddCourseNameBox.MaxLength = 50
        AddCourseNameBox.MouseState = MaterialSkin.MouseState.OUT
        AddCourseNameBox.Multiline = False
        AddCourseNameBox.Name = "AddCourseNameBox"
        AddCourseNameBox.Size = New Size(551, 50)
        AddCourseNameBox.TabIndex = 21
        AddCourseNameBox.Text = ""
        AddCourseNameBox.TrailingIcon = Nothing
        AddCourseNameBox.UseAccent = False
        ' 
        ' MaterialCard21
        ' 
        MaterialCard21.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard21.Controls.Add(CourProfLbl)
        MaterialCard21.Controls.Add(CourDateLbl)
        MaterialCard21.Controls.Add(CourTimeLbl)
        MaterialCard21.Controls.Add(MaterialLabel57)
        MaterialCard21.Controls.Add(PictureBox7)
        MaterialCard21.Depth = 0
        MaterialCard21.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard21.Location = New Point(14, 14)
        MaterialCard21.Margin = New Padding(14)
        MaterialCard21.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard21.Name = "MaterialCard21"
        MaterialCard21.Padding = New Padding(30)
        MaterialCard21.Size = New Size(1825, 110)
        MaterialCard21.TabIndex = 14
        ' 
        ' CourProfLbl
        ' 
        CourProfLbl.AutoSize = True
        CourProfLbl.Depth = 0
        CourProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        CourProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        CourProfLbl.Location = New Point(1528, 24)
        CourProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        CourProfLbl.Name = "CourProfLbl"
        CourProfLbl.Size = New Size(264, 24)
        CourProfLbl.TabIndex = 4
        CourProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' CourDateLbl
        ' 
        CourDateLbl.AutoSize = True
        CourDateLbl.Depth = 0
        CourDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        CourDateLbl.Location = New Point(1664, 48)
        CourDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        CourDateLbl.Name = "CourDateLbl"
        CourDateLbl.Size = New Size(128, 19)
        CourDateLbl.TabIndex = 3
        CourDateLbl.Text = "December 5, 2024"
        ' 
        ' CourTimeLbl
        ' 
        CourTimeLbl.AutoSize = True
        CourTimeLbl.Depth = 0
        CourTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        CourTimeLbl.Location = New Point(1751, 67)
        CourTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        CourTimeLbl.Name = "CourTimeLbl"
        CourTimeLbl.Size = New Size(41, 19)
        CourTimeLbl.TabIndex = 2
        CourTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel57
        ' 
        MaterialLabel57.AutoSize = True
        MaterialLabel57.Depth = 0
        MaterialLabel57.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel57.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel57.Location = New Point(485, 26)
        MaterialLabel57.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel57.Name = "MaterialLabel57"
        MaterialLabel57.Size = New Size(855, 58)
        MaterialLabel57.TabIndex = 1
        MaterialLabel57.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.PLP_logo1
        PictureBox7.Location = New Point(33, 30)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(50, 50)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' BulkEnrollment
        ' 
        BulkEnrollment.Controls.Add(MaterialCard13)
        BulkEnrollment.Controls.Add(MaterialCard12)
        BulkEnrollment.Controls.Add(MaterialCard11)
        BulkEnrollment.Controls.Add(MaterialCard1)
        BulkEnrollment.ImageKey = "crowd-of-users (1).png"
        BulkEnrollment.Location = New Point(44, 4)
        BulkEnrollment.Name = "BulkEnrollment"
        BulkEnrollment.Padding = New Padding(0, 0, 60, 0)
        BulkEnrollment.Size = New Size(1869, 1005)
        BulkEnrollment.TabIndex = 2
        BulkEnrollment.Text = "Bulk Enroll"
        BulkEnrollment.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard13
        ' 
        MaterialCard13.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard13.Controls.Add(BulkCoursesDataGrid)
        MaterialCard13.Depth = 0
        MaterialCard13.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard13.Location = New Point(1366, 505)
        MaterialCard13.Margin = New Padding(14)
        MaterialCard13.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard13.Name = "MaterialCard13"
        MaterialCard13.Padding = New Padding(30)
        MaterialCard13.Size = New Size(473, 489)
        MaterialCard13.TabIndex = 13
        ' 
        ' BulkCoursesDataGrid
        ' 
        BulkCoursesDataGrid.AutoSizeTable = False
        BulkCoursesDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        BulkCoursesDataGrid.BorderStyle = BorderStyle.None
        BulkCoursesDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader41, ColumnHeader42})
        BulkCoursesDataGrid.Depth = 0
        BulkCoursesDataGrid.Dock = DockStyle.Fill
        BulkCoursesDataGrid.FullRowSelect = True
        BulkCoursesDataGrid.Location = New Point(30, 30)
        BulkCoursesDataGrid.MinimumSize = New Size(200, 100)
        BulkCoursesDataGrid.MouseLocation = New Point(-1, -1)
        BulkCoursesDataGrid.MouseState = MaterialSkin.MouseState.OUT
        BulkCoursesDataGrid.Name = "BulkCoursesDataGrid"
        BulkCoursesDataGrid.OwnerDraw = True
        BulkCoursesDataGrid.Size = New Size(413, 429)
        BulkCoursesDataGrid.TabIndex = 37
        BulkCoursesDataGrid.UseCompatibleStateImageBehavior = False
        BulkCoursesDataGrid.View = View.Details
        ' 
        ' ColumnHeader41
        ' 
        ColumnHeader41.Text = "ID"
        ColumnHeader41.Width = 150
        ' 
        ' ColumnHeader42
        ' 
        ColumnHeader42.Text = "Course Name"
        ColumnHeader42.Width = 200
        ' 
        ' MaterialCard12
        ' 
        MaterialCard12.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard12.Controls.Add(ClearBulkCoursesBtn)
        MaterialCard12.Controls.Add(MaterialLabel60)
        MaterialCard12.Controls.Add(BulkCourseIdBox)
        MaterialCard12.Controls.Add(MaterialLabel34)
        MaterialCard12.Controls.Add(MaterialLabel31)
        MaterialCard12.Controls.Add(BulkEnrollBtn)
        MaterialCard12.Controls.Add(MaterialLabel32)
        MaterialCard12.Controls.Add(BulkCourseBox)
        MaterialCard12.Depth = 0
        MaterialCard12.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard12.Location = New Point(1366, 155)
        MaterialCard12.Margin = New Padding(14)
        MaterialCard12.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard12.Name = "MaterialCard12"
        MaterialCard12.Padding = New Padding(30)
        MaterialCard12.Size = New Size(473, 322)
        MaterialCard12.TabIndex = 12
        ' 
        ' ClearBulkCoursesBtn
        ' 
        ClearBulkCoursesBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClearBulkCoursesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        ClearBulkCoursesBtn.Depth = 0
        ClearBulkCoursesBtn.HighEmphasis = True
        ClearBulkCoursesBtn.Icon = Nothing
        ClearBulkCoursesBtn.Location = New Point(373, 35)
        ClearBulkCoursesBtn.Margin = New Padding(4, 6, 4, 6)
        ClearBulkCoursesBtn.MouseState = MaterialSkin.MouseState.HOVER
        ClearBulkCoursesBtn.Name = "ClearBulkCoursesBtn"
        ClearBulkCoursesBtn.NoAccentTextColor = Color.Empty
        ClearBulkCoursesBtn.Size = New Size(66, 36)
        ClearBulkCoursesBtn.TabIndex = 56
        ClearBulkCoursesBtn.Text = "clear"
        ClearBulkCoursesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        ClearBulkCoursesBtn.UseAccentColor = True
        ClearBulkCoursesBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel60
        ' 
        MaterialLabel60.AutoSize = True
        MaterialLabel60.Depth = 0
        MaterialLabel60.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel60.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel60.Location = New Point(33, 156)
        MaterialLabel60.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel60.Name = "MaterialLabel60"
        MaterialLabel60.Size = New Size(98, 14)
        MaterialLabel60.TabIndex = 53
        MaterialLabel60.Text = "Selected course id"
        ' 
        ' BulkCourseIdBox
        ' 
        BulkCourseIdBox.AnimateReadOnly = False
        BulkCourseIdBox.BorderStyle = BorderStyle.None
        BulkCourseIdBox.Depth = 0
        BulkCourseIdBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        BulkCourseIdBox.Hint = "Course id"
        BulkCourseIdBox.LeadingIcon = Nothing
        BulkCourseIdBox.Location = New Point(30, 173)
        BulkCourseIdBox.MaxLength = 50
        BulkCourseIdBox.MouseState = MaterialSkin.MouseState.OUT
        BulkCourseIdBox.Multiline = False
        BulkCourseIdBox.Name = "BulkCourseIdBox"
        BulkCourseIdBox.Size = New Size(409, 50)
        BulkCourseIdBox.TabIndex = 52
        BulkCourseIdBox.Text = ""
        BulkCourseIdBox.TrailingIcon = Nothing
        BulkCourseIdBox.UseAccent = False
        ' 
        ' MaterialLabel34
        ' 
        MaterialLabel34.AutoSize = True
        MaterialLabel34.Depth = 0
        MaterialLabel34.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel34.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel34.Location = New Point(30, 228)
        MaterialLabel34.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel34.Name = "MaterialLabel34"
        MaterialLabel34.Size = New Size(253, 14)
        MaterialLabel34.TabIndex = 38
        MaterialLabel34.Text = "Select course from table below before enrolling"
        ' 
        ' MaterialLabel31
        ' 
        MaterialLabel31.AutoSize = True
        MaterialLabel31.Depth = 0
        MaterialLabel31.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel31.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel31.Location = New Point(32, 73)
        MaterialLabel31.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel31.Name = "MaterialLabel31"
        MaterialLabel31.Size = New Size(100, 17)
        MaterialLabel31.TabIndex = 32
        MaterialLabel31.Text = "Add and modify"
        ' 
        ' BulkEnrollBtn
        ' 
        BulkEnrollBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BulkEnrollBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BulkEnrollBtn.Depth = 0
        BulkEnrollBtn.HighEmphasis = True
        BulkEnrollBtn.Icon = Nothing
        BulkEnrollBtn.Location = New Point(367, 250)
        BulkEnrollBtn.Margin = New Padding(4, 6, 4, 6)
        BulkEnrollBtn.MouseState = MaterialSkin.MouseState.HOVER
        BulkEnrollBtn.Name = "BulkEnrollBtn"
        BulkEnrollBtn.NoAccentTextColor = Color.Empty
        BulkEnrollBtn.Size = New Size(76, 36)
        BulkEnrollBtn.TabIndex = 36
        BulkEnrollBtn.Text = "Enroll"
        BulkEnrollBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BulkEnrollBtn.UseAccentColor = False
        BulkEnrollBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel32
        ' 
        MaterialLabel32.AutoSize = True
        MaterialLabel32.Depth = 0
        MaterialLabel32.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel32.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel32.Location = New Point(32, 30)
        MaterialLabel32.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel32.Name = "MaterialLabel32"
        MaterialLabel32.Size = New Size(127, 41)
        MaterialLabel32.TabIndex = 31
        MaterialLabel32.Text = "Courses"
        ' 
        ' BulkCourseBox
        ' 
        BulkCourseBox.AnimateReadOnly = False
        BulkCourseBox.BorderStyle = BorderStyle.None
        BulkCourseBox.Depth = 0
        BulkCourseBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        BulkCourseBox.Hint = "Course name"
        BulkCourseBox.LeadingIcon = Nothing
        BulkCourseBox.Location = New Point(33, 103)
        BulkCourseBox.MaxLength = 50
        BulkCourseBox.MouseState = MaterialSkin.MouseState.OUT
        BulkCourseBox.Multiline = False
        BulkCourseBox.Name = "BulkCourseBox"
        BulkCourseBox.Size = New Size(407, 50)
        BulkCourseBox.TabIndex = 21
        BulkCourseBox.Text = ""
        BulkCourseBox.TrailingIcon = Nothing
        BulkCourseBox.UseAccent = False
        ' 
        ' MaterialCard11
        ' 
        MaterialCard11.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard11.Controls.Add(BulkProfLbl)
        MaterialCard11.Controls.Add(BulkDateLbl)
        MaterialCard11.Controls.Add(BulkTimeLbl)
        MaterialCard11.Controls.Add(MaterialLabel23)
        MaterialCard11.Controls.Add(PictureBox5)
        MaterialCard11.Depth = 0
        MaterialCard11.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard11.Location = New Point(14, 14)
        MaterialCard11.Margin = New Padding(14)
        MaterialCard11.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard11.Name = "MaterialCard11"
        MaterialCard11.Padding = New Padding(30)
        MaterialCard11.Size = New Size(1825, 110)
        MaterialCard11.TabIndex = 11
        ' 
        ' BulkProfLbl
        ' 
        BulkProfLbl.AutoSize = True
        BulkProfLbl.Depth = 0
        BulkProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        BulkProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        BulkProfLbl.Location = New Point(1528, 24)
        BulkProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        BulkProfLbl.Name = "BulkProfLbl"
        BulkProfLbl.Size = New Size(264, 24)
        BulkProfLbl.TabIndex = 4
        BulkProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' BulkDateLbl
        ' 
        BulkDateLbl.AutoSize = True
        BulkDateLbl.Depth = 0
        BulkDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        BulkDateLbl.Location = New Point(1664, 48)
        BulkDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        BulkDateLbl.Name = "BulkDateLbl"
        BulkDateLbl.Size = New Size(128, 19)
        BulkDateLbl.TabIndex = 3
        BulkDateLbl.Text = "December 5, 2024"
        ' 
        ' BulkTimeLbl
        ' 
        BulkTimeLbl.AutoSize = True
        BulkTimeLbl.Depth = 0
        BulkTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        BulkTimeLbl.Location = New Point(1751, 67)
        BulkTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        BulkTimeLbl.Name = "BulkTimeLbl"
        BulkTimeLbl.Size = New Size(41, 19)
        BulkTimeLbl.TabIndex = 2
        BulkTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel23
        ' 
        MaterialLabel23.AutoSize = True
        MaterialLabel23.Depth = 0
        MaterialLabel23.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel23.Location = New Point(485, 26)
        MaterialLabel23.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel23.Name = "MaterialLabel23"
        MaterialLabel23.Size = New Size(855, 58)
        MaterialLabel23.TabIndex = 1
        MaterialLabel23.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
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
        ' MaterialCard1
        ' 
        MaterialCard1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(BulkSectionToUnenroll)
        MaterialCard1.Controls.Add(MaterialLabel62)
        MaterialCard1.Controls.Add(BulkEnrolledStudentDataGrid)
        MaterialCard1.Controls.Add(BulkUnenrollBtn)
        MaterialCard1.Controls.Add(MaterialLabel26)
        MaterialCard1.Controls.Add(SelectSectionToEnroll)
        MaterialCard1.Controls.Add(MaterialLabel33)
        MaterialCard1.Controls.Add(EnrolleSectionGrid)
        MaterialCard1.Controls.Add(MaterialLabel5)
        MaterialCard1.Controls.Add(MaterialLabel6)
        MaterialCard1.Controls.Add(SearchBulk)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 155)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(30)
        MaterialCard1.Size = New Size(1324, 839)
        MaterialCard1.TabIndex = 10
        ' 
        ' BulkSectionToUnenroll
        ' 
        BulkSectionToUnenroll.AutoResize = False
        BulkSectionToUnenroll.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        BulkSectionToUnenroll.Depth = 0
        BulkSectionToUnenroll.DrawMode = DrawMode.OwnerDrawVariable
        BulkSectionToUnenroll.DropDownHeight = 174
        BulkSectionToUnenroll.DropDownStyle = ComboBoxStyle.DropDownList
        BulkSectionToUnenroll.DropDownWidth = 121
        BulkSectionToUnenroll.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        BulkSectionToUnenroll.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        BulkSectionToUnenroll.FormattingEnabled = True
        BulkSectionToUnenroll.Hint = "Filter"
        BulkSectionToUnenroll.IntegralHeight = False
        BulkSectionToUnenroll.ItemHeight = 43
        BulkSectionToUnenroll.Items.AddRange(New Object() {"", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        BulkSectionToUnenroll.Location = New Point(1170, 530)
        BulkSectionToUnenroll.MaxDropDownItems = 4
        BulkSectionToUnenroll.MouseState = MaterialSkin.MouseState.OUT
        BulkSectionToUnenroll.Name = "BulkSectionToUnenroll"
        BulkSectionToUnenroll.Size = New Size(120, 49)
        BulkSectionToUnenroll.StartIndex = 0
        BulkSectionToUnenroll.TabIndex = 56
        BulkSectionToUnenroll.UseAccent = False
        ' 
        ' MaterialLabel62
        ' 
        MaterialLabel62.AutoSize = True
        MaterialLabel62.Depth = 0
        MaterialLabel62.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel62.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel62.Location = New Point(1170, 583)
        MaterialLabel62.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel62.Name = "MaterialLabel62"
        MaterialLabel62.Size = New Size(136, 14)
        MaterialLabel62.TabIndex = 55
        MaterialLabel62.Text = "Select section to unenroll"
        ' 
        ' BulkEnrolledStudentDataGrid
        ' 
        BulkEnrolledStudentDataGrid.AutoSizeTable = False
        BulkEnrolledStudentDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        BulkEnrolledStudentDataGrid.BorderStyle = BorderStyle.None
        BulkEnrolledStudentDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader5, ColumnHeader6, ColumnHeader13, ColumnHeader14, ColumnHeader56, ColumnHeader57})
        BulkEnrolledStudentDataGrid.Depth = 0
        BulkEnrolledStudentDataGrid.FullRowSelect = True
        BulkEnrolledStudentDataGrid.Location = New Point(33, 530)
        BulkEnrolledStudentDataGrid.Margin = New Padding(14)
        BulkEnrolledStudentDataGrid.MinimumSize = New Size(200, 100)
        BulkEnrolledStudentDataGrid.MouseLocation = New Point(-1, -1)
        BulkEnrolledStudentDataGrid.MouseState = MaterialSkin.MouseState.OUT
        BulkEnrolledStudentDataGrid.Name = "BulkEnrolledStudentDataGrid"
        BulkEnrolledStudentDataGrid.OwnerDraw = True
        BulkEnrolledStudentDataGrid.Size = New Size(1120, 265)
        BulkEnrolledStudentDataGrid.TabIndex = 53
        BulkEnrolledStudentDataGrid.UseCompatibleStateImageBehavior = False
        BulkEnrolledStudentDataGrid.View = View.Details
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Enroll ID"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Stud ID"
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "First Name"
        ColumnHeader13.Width = 200
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.Text = "Last Name"
        ColumnHeader14.Width = 200
        ' 
        ' ColumnHeader56
        ' 
        ColumnHeader56.Text = "Course"
        ColumnHeader56.Width = 220
        ' 
        ' ColumnHeader57
        ' 
        ColumnHeader57.Text = "Date Enrolled"
        ColumnHeader57.Width = 200
        ' 
        ' BulkUnenrollBtn
        ' 
        BulkUnenrollBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BulkUnenrollBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        BulkUnenrollBtn.Depth = 0
        BulkUnenrollBtn.HighEmphasis = True
        BulkUnenrollBtn.Icon = Nothing
        BulkUnenrollBtn.Location = New Point(1194, 767)
        BulkUnenrollBtn.Margin = New Padding(4, 6, 4, 6)
        BulkUnenrollBtn.MouseState = MaterialSkin.MouseState.HOVER
        BulkUnenrollBtn.Name = "BulkUnenrollBtn"
        BulkUnenrollBtn.NoAccentTextColor = Color.Empty
        BulkUnenrollBtn.Size = New Size(96, 36)
        BulkUnenrollBtn.TabIndex = 54
        BulkUnenrollBtn.Text = "Unenroll"
        BulkUnenrollBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        BulkUnenrollBtn.UseAccentColor = False
        BulkUnenrollBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel26
        ' 
        MaterialLabel26.AutoSize = True
        MaterialLabel26.Depth = 0
        MaterialLabel26.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel26.Location = New Point(33, 795)
        MaterialLabel26.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel26.Name = "MaterialLabel26"
        MaterialLabel26.Size = New Size(150, 14)
        MaterialLabel26.TabIndex = 42
        MaterialLabel26.Text = "Individual enrolled students"
        ' 
        ' SelectSectionToEnroll
        ' 
        SelectSectionToEnroll.AutoResize = False
        SelectSectionToEnroll.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SelectSectionToEnroll.Depth = 0
        SelectSectionToEnroll.DrawMode = DrawMode.OwnerDrawVariable
        SelectSectionToEnroll.DropDownHeight = 174
        SelectSectionToEnroll.DropDownStyle = ComboBoxStyle.DropDownList
        SelectSectionToEnroll.DropDownWidth = 121
        SelectSectionToEnroll.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        SelectSectionToEnroll.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        SelectSectionToEnroll.FormattingEnabled = True
        SelectSectionToEnroll.Hint = "Filter by section"
        SelectSectionToEnroll.IntegralHeight = False
        SelectSectionToEnroll.ItemHeight = 43
        SelectSectionToEnroll.Items.AddRange(New Object() {"", "BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        SelectSectionToEnroll.Location = New Point(943, 120)
        SelectSectionToEnroll.MaxDropDownItems = 4
        SelectSectionToEnroll.MouseState = MaterialSkin.MouseState.OUT
        SelectSectionToEnroll.Name = "SelectSectionToEnroll"
        SelectSectionToEnroll.Size = New Size(348, 49)
        SelectSectionToEnroll.StartIndex = 0
        SelectSectionToEnroll.TabIndex = 38
        SelectSectionToEnroll.UseAccent = False
        ' 
        ' MaterialLabel33
        ' 
        MaterialLabel33.AutoSize = True
        MaterialLabel33.Depth = 0
        MaterialLabel33.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel33.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel33.Location = New Point(33, 505)
        MaterialLabel33.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel33.Name = "MaterialLabel33"
        MaterialLabel33.Size = New Size(338, 14)
        MaterialLabel33.TabIndex = 37
        MaterialLabel33.Text = "The following students will be enrolled to your specified course"
        ' 
        ' EnrolleSectionGrid
        ' 
        EnrolleSectionGrid.AutoSizeTable = False
        EnrolleSectionGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        EnrolleSectionGrid.BorderStyle = BorderStyle.None
        EnrolleSectionGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader7, ColumnHeader8})
        EnrolleSectionGrid.Depth = 0
        EnrolleSectionGrid.FullRowSelect = True
        EnrolleSectionGrid.Location = New Point(33, 175)
        EnrolleSectionGrid.MinimumSize = New Size(200, 100)
        EnrolleSectionGrid.MouseLocation = New Point(-1, -1)
        EnrolleSectionGrid.MouseState = MaterialSkin.MouseState.OUT
        EnrolleSectionGrid.Name = "EnrolleSectionGrid"
        EnrolleSectionGrid.OwnerDraw = True
        EnrolleSectionGrid.Size = New Size(1258, 327)
        EnrolleSectionGrid.TabIndex = 35
        EnrolleSectionGrid.UseCompatibleStateImageBehavior = False
        EnrolleSectionGrid.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Stud ID"
        ColumnHeader1.Width = 160
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "First Name"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Last Name"
        ColumnHeader3.Width = 200
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Middle Name"
        ColumnHeader4.Width = 200
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Section"
        ColumnHeader7.Width = 160
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Email"
        ColumnHeader8.Width = 320
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        MaterialLabel5.Location = New Point(33, 71)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(165, 19)
        MaterialLabel5.TabIndex = 33
        MaterialLabel5.Text = "Assign student courses"
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
        MaterialLabel6.Size = New Size(236, 41)
        MaterialLabel6.TabIndex = 32
        MaterialLabel6.Text = "Bulk enrollment"
        ' 
        ' SearchBulk
        ' 
        SearchBulk.AnimateReadOnly = False
        SearchBulk.BorderStyle = BorderStyle.None
        SearchBulk.Depth = 0
        SearchBulk.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        SearchBulk.Hint = "Search"
        SearchBulk.LeadingIcon = Nothing
        SearchBulk.Location = New Point(33, 119)
        SearchBulk.MaxLength = 50
        SearchBulk.MouseState = MaterialSkin.MouseState.OUT
        SearchBulk.Multiline = False
        SearchBulk.Name = "SearchBulk"
        SearchBulk.Size = New Size(904, 50)
        SearchBulk.TabIndex = 25
        SearchBulk.Text = ""
        SearchBulk.TrailingIcon = Nothing
        SearchBulk.UseAccent = False
        ' 
        ' IndividualEnrollment
        ' 
        IndividualEnrollment.Controls.Add(MaterialCard14)
        IndividualEnrollment.Controls.Add(MaterialCard15)
        IndividualEnrollment.Controls.Add(MaterialCard16)
        IndividualEnrollment.Controls.Add(MaterialCard17)
        IndividualEnrollment.ImageKey = "user (1) (1).png"
        IndividualEnrollment.Location = New Point(44, 4)
        IndividualEnrollment.Name = "IndividualEnrollment"
        IndividualEnrollment.Size = New Size(1869, 1005)
        IndividualEnrollment.TabIndex = 6
        IndividualEnrollment.Text = "Individual Enroll"
        IndividualEnrollment.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard14
        ' 
        MaterialCard14.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard14.Controls.Add(IndSelectedCourseNameBox)
        MaterialCard14.Controls.Add(IndSelectCourseDatGrid)
        MaterialCard14.Depth = 0
        MaterialCard14.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard14.Location = New Point(1366, 503)
        MaterialCard14.Margin = New Padding(14)
        MaterialCard14.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard14.Name = "MaterialCard14"
        MaterialCard14.Padding = New Padding(30)
        MaterialCard14.Size = New Size(473, 488)
        MaterialCard14.TabIndex = 17
        ' 
        ' IndSelectedCourseNameBox
        ' 
        IndSelectedCourseNameBox.AnimateReadOnly = False
        IndSelectedCourseNameBox.BorderStyle = BorderStyle.None
        IndSelectedCourseNameBox.Depth = 0
        IndSelectedCourseNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IndSelectedCourseNameBox.Hint = "Selected course name"
        IndSelectedCourseNameBox.LeadingIcon = Nothing
        IndSelectedCourseNameBox.Location = New Point(30, 33)
        IndSelectedCourseNameBox.MaxLength = 50
        IndSelectedCourseNameBox.MouseState = MaterialSkin.MouseState.OUT
        IndSelectedCourseNameBox.Multiline = False
        IndSelectedCourseNameBox.Name = "IndSelectedCourseNameBox"
        IndSelectedCourseNameBox.Size = New Size(409, 50)
        IndSelectedCourseNameBox.TabIndex = 51
        IndSelectedCourseNameBox.Text = ""
        IndSelectedCourseNameBox.TrailingIcon = Nothing
        IndSelectedCourseNameBox.UseAccent = False
        ' 
        ' IndSelectCourseDatGrid
        ' 
        IndSelectCourseDatGrid.AutoSizeTable = False
        IndSelectCourseDatGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IndSelectCourseDatGrid.BorderStyle = BorderStyle.None
        IndSelectCourseDatGrid.Columns.AddRange(New ColumnHeader() {IndCourCourseID, IndCourCourseName})
        IndSelectCourseDatGrid.Depth = 0
        IndSelectCourseDatGrid.Dock = DockStyle.Bottom
        IndSelectCourseDatGrid.FullRowSelect = True
        IndSelectCourseDatGrid.Location = New Point(30, 110)
        IndSelectCourseDatGrid.MinimumSize = New Size(200, 100)
        IndSelectCourseDatGrid.MouseLocation = New Point(-1, -1)
        IndSelectCourseDatGrid.MouseState = MaterialSkin.MouseState.OUT
        IndSelectCourseDatGrid.Name = "IndSelectCourseDatGrid"
        IndSelectCourseDatGrid.OwnerDraw = True
        IndSelectCourseDatGrid.Size = New Size(413, 348)
        IndSelectCourseDatGrid.TabIndex = 37
        IndSelectCourseDatGrid.UseCompatibleStateImageBehavior = False
        IndSelectCourseDatGrid.View = View.Details
        ' 
        ' IndCourCourseID
        ' 
        IndCourCourseID.Text = "ID"
        IndCourCourseID.Width = 200
        ' 
        ' IndCourCourseName
        ' 
        IndCourCourseName.Text = "Course Name"
        IndCourCourseName.Width = 200
        ' 
        ' MaterialCard15
        ' 
        MaterialCard15.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard15.Controls.Add(IndClearBtn)
        MaterialCard15.Controls.Add(IndEnrollButton)
        MaterialCard15.Controls.Add(MaterialLabel25)
        MaterialCard15.Controls.Add(IndSelectedCourseIdBox)
        MaterialCard15.Controls.Add(MaterialLabel27)
        MaterialCard15.Controls.Add(IndStudentIdBox)
        MaterialCard15.Controls.Add(MaterialLabel35)
        MaterialCard15.Controls.Add(MaterialLabel36)
        MaterialCard15.Depth = 0
        MaterialCard15.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard15.Location = New Point(1366, 152)
        MaterialCard15.Margin = New Padding(14)
        MaterialCard15.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard15.Name = "MaterialCard15"
        MaterialCard15.Padding = New Padding(30)
        MaterialCard15.Size = New Size(473, 323)
        MaterialCard15.TabIndex = 16
        ' 
        ' IndClearBtn
        ' 
        IndClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        IndClearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        IndClearBtn.Depth = 0
        IndClearBtn.HighEmphasis = True
        IndClearBtn.Icon = Nothing
        IndClearBtn.Location = New Point(373, 36)
        IndClearBtn.Margin = New Padding(4, 6, 4, 6)
        IndClearBtn.MouseState = MaterialSkin.MouseState.HOVER
        IndClearBtn.Name = "IndClearBtn"
        IndClearBtn.NoAccentTextColor = Color.Empty
        IndClearBtn.Size = New Size(66, 36)
        IndClearBtn.TabIndex = 52
        IndClearBtn.Text = "clear"
        IndClearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        IndClearBtn.UseAccentColor = True
        IndClearBtn.UseVisualStyleBackColor = True
        ' 
        ' IndEnrollButton
        ' 
        IndEnrollButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        IndEnrollButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        IndEnrollButton.Depth = 0
        IndEnrollButton.HighEmphasis = True
        IndEnrollButton.Icon = Nothing
        IndEnrollButton.Location = New Point(367, 251)
        IndEnrollButton.Margin = New Padding(4, 6, 4, 6)
        IndEnrollButton.MouseState = MaterialSkin.MouseState.HOVER
        IndEnrollButton.Name = "IndEnrollButton"
        IndEnrollButton.NoAccentTextColor = Color.Empty
        IndEnrollButton.Size = New Size(76, 36)
        IndEnrollButton.TabIndex = 51
        IndEnrollButton.Text = "Enroll"
        IndEnrollButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        IndEnrollButton.UseAccentColor = False
        IndEnrollButton.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel25
        ' 
        MaterialLabel25.AutoSize = True
        MaterialLabel25.Depth = 0
        MaterialLabel25.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel25.Location = New Point(30, 227)
        MaterialLabel25.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel25.Name = "MaterialLabel25"
        MaterialLabel25.Size = New Size(166, 14)
        MaterialLabel25.TabIndex = 49
        MaterialLabel25.Text = "Select course from table below"
        ' 
        ' IndSelectedCourseIdBox
        ' 
        IndSelectedCourseIdBox.AnimateReadOnly = False
        IndSelectedCourseIdBox.BorderStyle = BorderStyle.None
        IndSelectedCourseIdBox.Depth = 0
        IndSelectedCourseIdBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IndSelectedCourseIdBox.Hint = "Course id"
        IndSelectedCourseIdBox.LeadingIcon = Nothing
        IndSelectedCourseIdBox.Location = New Point(30, 175)
        IndSelectedCourseIdBox.MaxLength = 50
        IndSelectedCourseIdBox.MouseState = MaterialSkin.MouseState.OUT
        IndSelectedCourseIdBox.Multiline = False
        IndSelectedCourseIdBox.Name = "IndSelectedCourseIdBox"
        IndSelectedCourseIdBox.Size = New Size(409, 50)
        IndSelectedCourseIdBox.TabIndex = 50
        IndSelectedCourseIdBox.Text = ""
        IndSelectedCourseIdBox.TrailingIcon = Nothing
        IndSelectedCourseIdBox.UseAccent = False
        ' 
        ' MaterialLabel27
        ' 
        MaterialLabel27.AutoSize = True
        MaterialLabel27.Depth = 0
        MaterialLabel27.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel27.Location = New Point(30, 155)
        MaterialLabel27.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel27.Name = "MaterialLabel27"
        MaterialLabel27.Size = New Size(242, 14)
        MaterialLabel27.TabIndex = 38
        MaterialLabel27.Text = "Select or type student id to individually enroll"
        ' 
        ' IndStudentIdBox
        ' 
        IndStudentIdBox.AnimateReadOnly = False
        IndStudentIdBox.BorderStyle = BorderStyle.None
        IndStudentIdBox.Depth = 0
        IndStudentIdBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IndStudentIdBox.Hint = "Enter student id"
        IndStudentIdBox.LeadingIcon = Nothing
        IndStudentIdBox.Location = New Point(30, 103)
        IndStudentIdBox.MaxLength = 50
        IndStudentIdBox.MouseState = MaterialSkin.MouseState.OUT
        IndStudentIdBox.Multiline = False
        IndStudentIdBox.Name = "IndStudentIdBox"
        IndStudentIdBox.Size = New Size(409, 50)
        IndStudentIdBox.TabIndex = 44
        IndStudentIdBox.Text = ""
        IndStudentIdBox.TrailingIcon = Nothing
        IndStudentIdBox.UseAccent = False
        ' 
        ' MaterialLabel35
        ' 
        MaterialLabel35.AutoSize = True
        MaterialLabel35.Depth = 0
        MaterialLabel35.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel35.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel35.Location = New Point(33, 73)
        MaterialLabel35.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel35.Name = "MaterialLabel35"
        MaterialLabel35.Size = New Size(100, 17)
        MaterialLabel35.TabIndex = 32
        MaterialLabel35.Text = "Add and modify"
        ' 
        ' MaterialLabel36
        ' 
        MaterialLabel36.AutoSize = True
        MaterialLabel36.Depth = 0
        MaterialLabel36.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel36.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel36.Location = New Point(30, 30)
        MaterialLabel36.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel36.Name = "MaterialLabel36"
        MaterialLabel36.Size = New Size(136, 41)
        MaterialLabel36.TabIndex = 31
        MaterialLabel36.Text = "Students"
        ' 
        ' MaterialCard16
        ' 
        MaterialCard16.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard16.Controls.Add(IndProfLbl)
        MaterialCard16.Controls.Add(IndDatelbl)
        MaterialCard16.Controls.Add(IndTimeLbl)
        MaterialCard16.Controls.Add(MaterialLabel40)
        MaterialCard16.Controls.Add(PictureBox6)
        MaterialCard16.Depth = 0
        MaterialCard16.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard16.Location = New Point(14, 14)
        MaterialCard16.Margin = New Padding(14)
        MaterialCard16.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard16.Name = "MaterialCard16"
        MaterialCard16.Padding = New Padding(30)
        MaterialCard16.Size = New Size(1825, 110)
        MaterialCard16.TabIndex = 15
        ' 
        ' IndProfLbl
        ' 
        IndProfLbl.AutoSize = True
        IndProfLbl.Depth = 0
        IndProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        IndProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        IndProfLbl.Location = New Point(1528, 24)
        IndProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        IndProfLbl.Name = "IndProfLbl"
        IndProfLbl.Size = New Size(264, 24)
        IndProfLbl.TabIndex = 4
        IndProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' IndDatelbl
        ' 
        IndDatelbl.AutoSize = True
        IndDatelbl.Depth = 0
        IndDatelbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        IndDatelbl.Location = New Point(1664, 48)
        IndDatelbl.MouseState = MaterialSkin.MouseState.HOVER
        IndDatelbl.Name = "IndDatelbl"
        IndDatelbl.Size = New Size(128, 19)
        IndDatelbl.TabIndex = 3
        IndDatelbl.Text = "December 5, 2024"
        ' 
        ' IndTimeLbl
        ' 
        IndTimeLbl.AutoSize = True
        IndTimeLbl.Depth = 0
        IndTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        IndTimeLbl.Location = New Point(1751, 67)
        IndTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        IndTimeLbl.Name = "IndTimeLbl"
        IndTimeLbl.Size = New Size(41, 19)
        IndTimeLbl.TabIndex = 2
        IndTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel40
        ' 
        MaterialLabel40.AutoSize = True
        MaterialLabel40.Depth = 0
        MaterialLabel40.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel40.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel40.Location = New Point(485, 26)
        MaterialLabel40.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel40.Name = "MaterialLabel40"
        MaterialLabel40.Size = New Size(855, 58)
        MaterialLabel40.TabIndex = 1
        MaterialLabel40.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
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
        ' MaterialCard17
        ' 
        MaterialCard17.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        MaterialCard17.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard17.Controls.Add(MaterialLabel59)
        MaterialCard17.Controls.Add(IndSelectedEnrollIdBox)
        MaterialCard17.Controls.Add(IndSortStudentByBox)
        MaterialCard17.Controls.Add(IndSortEnrolledByBox)
        MaterialCard17.Controls.Add(MaterialLabel41)
        MaterialCard17.Controls.Add(IndEnrolledStudentsDataGrid)
        MaterialCard17.Controls.Add(IndUnenrollBtn)
        MaterialCard17.Controls.Add(MaterialLabel43)
        MaterialCard17.Controls.Add(IndSelectStudentDataGrid)
        MaterialCard17.Controls.Add(MaterialLabel44)
        MaterialCard17.Controls.Add(MaterialLabel45)
        MaterialCard17.Controls.Add(IndSearchStudentBox)
        MaterialCard17.Depth = 0
        MaterialCard17.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard17.Location = New Point(14, 152)
        MaterialCard17.Margin = New Padding(14)
        MaterialCard17.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard17.Name = "MaterialCard17"
        MaterialCard17.Padding = New Padding(30)
        MaterialCard17.Size = New Size(1324, 839)
        MaterialCard17.TabIndex = 14
        ' 
        ' MaterialLabel59
        ' 
        MaterialLabel59.AutoSize = True
        MaterialLabel59.Depth = 0
        MaterialLabel59.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel59.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel59.Location = New Point(1170, 583)
        MaterialLabel59.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel59.Name = "MaterialLabel59"
        MaterialLabel59.Size = New Size(94, 14)
        MaterialLabel59.TabIndex = 51
        MaterialLabel59.Text = "Selected Enroll ID"
        ' 
        ' IndSelectedEnrollIdBox
        ' 
        IndSelectedEnrollIdBox.AnimateReadOnly = False
        IndSelectedEnrollIdBox.BorderStyle = BorderStyle.None
        IndSelectedEnrollIdBox.Depth = 0
        IndSelectedEnrollIdBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IndSelectedEnrollIdBox.Hint = "Enroll Id"
        IndSelectedEnrollIdBox.LeadingIcon = Nothing
        IndSelectedEnrollIdBox.Location = New Point(1170, 530)
        IndSelectedEnrollIdBox.MaxLength = 50
        IndSelectedEnrollIdBox.MouseState = MaterialSkin.MouseState.OUT
        IndSelectedEnrollIdBox.Multiline = False
        IndSelectedEnrollIdBox.Name = "IndSelectedEnrollIdBox"
        IndSelectedEnrollIdBox.Size = New Size(121, 50)
        IndSelectedEnrollIdBox.TabIndex = 52
        IndSelectedEnrollIdBox.Text = ""
        IndSelectedEnrollIdBox.TrailingIcon = Nothing
        IndSelectedEnrollIdBox.UseAccent = False
        ' 
        ' IndSortStudentByBox
        ' 
        IndSortStudentByBox.AutoResize = False
        IndSortStudentByBox.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IndSortStudentByBox.Depth = 0
        IndSortStudentByBox.DrawMode = DrawMode.OwnerDrawVariable
        IndSortStudentByBox.DropDownHeight = 174
        IndSortStudentByBox.DropDownStyle = ComboBoxStyle.DropDownList
        IndSortStudentByBox.DropDownWidth = 121
        IndSortStudentByBox.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        IndSortStudentByBox.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        IndSortStudentByBox.FormattingEnabled = True
        IndSortStudentByBox.Hint = "Sort students by"
        IndSortStudentByBox.IntegralHeight = False
        IndSortStudentByBox.ItemHeight = 43
        IndSortStudentByBox.Items.AddRange(New Object() {"Student ID", "First Name", "Last Name", "Middle Name", "Section", "Email"})
        IndSortStudentByBox.Location = New Point(667, 120)
        IndSortStudentByBox.MaxDropDownItems = 4
        IndSortStudentByBox.MouseState = MaterialSkin.MouseState.OUT
        IndSortStudentByBox.Name = "IndSortStudentByBox"
        IndSortStudentByBox.Size = New Size(327, 49)
        IndSortStudentByBox.StartIndex = 0
        IndSortStudentByBox.TabIndex = 49
        IndSortStudentByBox.UseAccent = False
        ' 
        ' IndSortEnrolledByBox
        ' 
        IndSortEnrolledByBox.AutoResize = False
        IndSortEnrolledByBox.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IndSortEnrolledByBox.Depth = 0
        IndSortEnrolledByBox.DrawMode = DrawMode.OwnerDrawVariable
        IndSortEnrolledByBox.DropDownHeight = 174
        IndSortEnrolledByBox.DropDownStyle = ComboBoxStyle.DropDownList
        IndSortEnrolledByBox.DropDownWidth = 121
        IndSortEnrolledByBox.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        IndSortEnrolledByBox.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        IndSortEnrolledByBox.FormattingEnabled = True
        IndSortEnrolledByBox.Hint = "Sort enrolled by"
        IndSortEnrolledByBox.IntegralHeight = False
        IndSortEnrolledByBox.ItemHeight = 43
        IndSortEnrolledByBox.Items.AddRange(New Object() {"Enrollment ID", "Student ID", "First Name", "Last Name", "Course", "Date Enrolled"})
        IndSortEnrolledByBox.Location = New Point(1000, 120)
        IndSortEnrolledByBox.MaxDropDownItems = 4
        IndSortEnrolledByBox.MouseState = MaterialSkin.MouseState.OUT
        IndSortEnrolledByBox.Name = "IndSortEnrolledByBox"
        IndSortEnrolledByBox.Size = New Size(290, 49)
        IndSortEnrolledByBox.StartIndex = 0
        IndSortEnrolledByBox.TabIndex = 48
        IndSortEnrolledByBox.UseAccent = False
        ' 
        ' MaterialLabel41
        ' 
        MaterialLabel41.AutoSize = True
        MaterialLabel41.Depth = 0
        MaterialLabel41.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel41.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel41.Location = New Point(33, 795)
        MaterialLabel41.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel41.Name = "MaterialLabel41"
        MaterialLabel41.Size = New Size(150, 14)
        MaterialLabel41.TabIndex = 42
        MaterialLabel41.Text = "Individual enrolled students"
        ' 
        ' IndEnrolledStudentsDataGrid
        ' 
        IndEnrolledStudentsDataGrid.AutoSizeTable = False
        IndEnrolledStudentsDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IndEnrolledStudentsDataGrid.BorderStyle = BorderStyle.None
        IndEnrolledStudentsDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader49, ColumnHeader29, ColumnHeader30, ColumnHeader31, ColumnHeader32, ColumnHeader50, ColumnHeader53})
        IndEnrolledStudentsDataGrid.Depth = 0
        IndEnrolledStudentsDataGrid.FullRowSelect = True
        IndEnrolledStudentsDataGrid.Location = New Point(33, 530)
        IndEnrolledStudentsDataGrid.Margin = New Padding(14)
        IndEnrolledStudentsDataGrid.MinimumSize = New Size(200, 100)
        IndEnrolledStudentsDataGrid.MouseLocation = New Point(-1, -1)
        IndEnrolledStudentsDataGrid.MouseState = MaterialSkin.MouseState.OUT
        IndEnrolledStudentsDataGrid.Name = "IndEnrolledStudentsDataGrid"
        IndEnrolledStudentsDataGrid.OwnerDraw = True
        IndEnrolledStudentsDataGrid.Size = New Size(1120, 265)
        IndEnrolledStudentsDataGrid.TabIndex = 41
        IndEnrolledStudentsDataGrid.UseCompatibleStateImageBehavior = False
        IndEnrolledStudentsDataGrid.View = View.Details
        ' 
        ' ColumnHeader49
        ' 
        ColumnHeader49.Text = "Enroll ID"
        ColumnHeader49.Width = 100
        ' 
        ' ColumnHeader29
        ' 
        ColumnHeader29.Text = "Stud ID"
        ColumnHeader29.Width = 150
        ' 
        ' ColumnHeader30
        ' 
        ColumnHeader30.Text = "First Name"
        ColumnHeader30.Width = 200
        ' 
        ' ColumnHeader31
        ' 
        ColumnHeader31.Text = "Last Name"
        ColumnHeader31.Width = 200
        ' 
        ' ColumnHeader32
        ' 
        ColumnHeader32.Text = "Course"
        ColumnHeader32.Width = 200
        ' 
        ' ColumnHeader50
        ' 
        ColumnHeader50.Text = "Date Enrolled"
        ColumnHeader50.Width = 150
        ' 
        ' ColumnHeader53
        ' 
        ColumnHeader53.Text = "Semester"
        ColumnHeader53.Width = 150
        ' 
        ' IndUnenrollBtn
        ' 
        IndUnenrollBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        IndUnenrollBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        IndUnenrollBtn.Depth = 0
        IndUnenrollBtn.HighEmphasis = True
        IndUnenrollBtn.Icon = Nothing
        IndUnenrollBtn.Location = New Point(1194, 767)
        IndUnenrollBtn.Margin = New Padding(4, 6, 4, 6)
        IndUnenrollBtn.MouseState = MaterialSkin.MouseState.HOVER
        IndUnenrollBtn.Name = "IndUnenrollBtn"
        IndUnenrollBtn.NoAccentTextColor = Color.Empty
        IndUnenrollBtn.Size = New Size(96, 36)
        IndUnenrollBtn.TabIndex = 48
        IndUnenrollBtn.Text = "Unenroll"
        IndUnenrollBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        IndUnenrollBtn.UseAccentColor = False
        IndUnenrollBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel43
        ' 
        MaterialLabel43.AutoSize = True
        MaterialLabel43.Depth = 0
        MaterialLabel43.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel43.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel43.Location = New Point(33, 505)
        MaterialLabel43.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel43.Name = "MaterialLabel43"
        MaterialLabel43.Size = New Size(471, 14)
        MaterialLabel43.TabIndex = 37
        MaterialLabel43.Text = "Select one from the following students to individually enroll or manually type student id"
        ' 
        ' IndSelectStudentDataGrid
        ' 
        IndSelectStudentDataGrid.AutoSizeTable = False
        IndSelectStudentDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IndSelectStudentDataGrid.BorderStyle = BorderStyle.None
        IndSelectStudentDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader35, ColumnHeader36, ColumnHeader37, ColumnHeader38, ColumnHeader39, ColumnHeader40})
        IndSelectStudentDataGrid.Depth = 0
        IndSelectStudentDataGrid.FullRowSelect = True
        IndSelectStudentDataGrid.Location = New Point(33, 175)
        IndSelectStudentDataGrid.MinimumSize = New Size(200, 100)
        IndSelectStudentDataGrid.MouseLocation = New Point(-1, -1)
        IndSelectStudentDataGrid.MouseState = MaterialSkin.MouseState.OUT
        IndSelectStudentDataGrid.Name = "IndSelectStudentDataGrid"
        IndSelectStudentDataGrid.OwnerDraw = True
        IndSelectStudentDataGrid.Size = New Size(1258, 327)
        IndSelectStudentDataGrid.TabIndex = 35
        IndSelectStudentDataGrid.UseCompatibleStateImageBehavior = False
        IndSelectStudentDataGrid.View = View.Details
        ' 
        ' ColumnHeader35
        ' 
        ColumnHeader35.Text = "Stud ID"
        ColumnHeader35.Width = 160
        ' 
        ' ColumnHeader36
        ' 
        ColumnHeader36.Text = "First Name"
        ColumnHeader36.Width = 200
        ' 
        ' ColumnHeader37
        ' 
        ColumnHeader37.Text = "Last Name"
        ColumnHeader37.Width = 200
        ' 
        ' ColumnHeader38
        ' 
        ColumnHeader38.Text = "Middle Name"
        ColumnHeader38.Width = 200
        ' 
        ' ColumnHeader39
        ' 
        ColumnHeader39.Text = "Section"
        ColumnHeader39.Width = 150
        ' 
        ' ColumnHeader40
        ' 
        ColumnHeader40.Text = "Email"
        ColumnHeader40.Width = 350
        ' 
        ' MaterialLabel44
        ' 
        MaterialLabel44.AutoSize = True
        MaterialLabel44.Depth = 0
        MaterialLabel44.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel44.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        MaterialLabel44.Location = New Point(33, 71)
        MaterialLabel44.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel44.Name = "MaterialLabel44"
        MaterialLabel44.Size = New Size(250, 19)
        MaterialLabel44.TabIndex = 33
        MaterialLabel44.Text = "Assign student courses individually"
        ' 
        ' MaterialLabel45
        ' 
        MaterialLabel45.AutoSize = True
        MaterialLabel45.Depth = 0
        MaterialLabel45.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel45.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel45.Location = New Point(33, 30)
        MaterialLabel45.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel45.Name = "MaterialLabel45"
        MaterialLabel45.Size = New Size(315, 41)
        MaterialLabel45.TabIndex = 32
        MaterialLabel45.Text = "Individual enrollment"
        ' 
        ' IndSearchStudentBox
        ' 
        IndSearchStudentBox.AnimateReadOnly = False
        IndSearchStudentBox.BorderStyle = BorderStyle.None
        IndSearchStudentBox.Depth = 0
        IndSearchStudentBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IndSearchStudentBox.Hint = "Search"
        IndSearchStudentBox.LeadingIcon = Nothing
        IndSearchStudentBox.Location = New Point(33, 119)
        IndSearchStudentBox.MaxLength = 50
        IndSearchStudentBox.MouseState = MaterialSkin.MouseState.OUT
        IndSearchStudentBox.Multiline = False
        IndSearchStudentBox.Name = "IndSearchStudentBox"
        IndSearchStudentBox.Size = New Size(628, 50)
        IndSearchStudentBox.TabIndex = 25
        IndSearchStudentBox.Text = ""
        IndSearchStudentBox.TrailingIcon = Nothing
        IndSearchStudentBox.UseAccent = False
        ' 
        ' CurrentCoursesHandled
        ' 
        CurrentCoursesHandled.Controls.Add(MaterialCard9)
        CurrentCoursesHandled.Controls.Add(MaterialCard8)
        CurrentCoursesHandled.Controls.Add(MaterialCard5)
        CurrentCoursesHandled.ImageKey = "book (1).png"
        CurrentCoursesHandled.Location = New Point(44, 4)
        CurrentCoursesHandled.Name = "CurrentCoursesHandled"
        CurrentCoursesHandled.Size = New Size(1869, 1005)
        CurrentCoursesHandled.TabIndex = 5
        CurrentCoursesHandled.Text = "Initialization"
        CurrentCoursesHandled.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard9
        ' 
        MaterialCard9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard9.Controls.Add(IniSearchForProfOrCourseBox)
        MaterialCard9.Controls.Add(IniDataGrid)
        MaterialCard9.Depth = 0
        MaterialCard9.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard9.Location = New Point(769, 155)
        MaterialCard9.Margin = New Padding(14)
        MaterialCard9.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard9.Name = "MaterialCard9"
        MaterialCard9.Padding = New Padding(30)
        MaterialCard9.Size = New Size(1070, 836)
        MaterialCard9.TabIndex = 11
        ' 
        ' IniSearchForProfOrCourseBox
        ' 
        IniSearchForProfOrCourseBox.AnimateReadOnly = False
        IniSearchForProfOrCourseBox.BorderStyle = BorderStyle.None
        IniSearchForProfOrCourseBox.Depth = 0
        IniSearchForProfOrCourseBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniSearchForProfOrCourseBox.Hint = "Search for professor or course"
        IniSearchForProfOrCourseBox.LeadingIcon = My.Resources.Resources.magnifier
        IniSearchForProfOrCourseBox.Location = New Point(33, 33)
        IniSearchForProfOrCourseBox.MaxLength = 50
        IniSearchForProfOrCourseBox.MouseState = MaterialSkin.MouseState.OUT
        IniSearchForProfOrCourseBox.Multiline = False
        IniSearchForProfOrCourseBox.Name = "IniSearchForProfOrCourseBox"
        IniSearchForProfOrCourseBox.Size = New Size(1004, 50)
        IniSearchForProfOrCourseBox.TabIndex = 38
        IniSearchForProfOrCourseBox.Text = ""
        IniSearchForProfOrCourseBox.TrailingIcon = Nothing
        IniSearchForProfOrCourseBox.UseAccent = False
        ' 
        ' IniDataGrid
        ' 
        IniDataGrid.AllowColumnReorder = True
        IniDataGrid.AutoSizeTable = False
        IniDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IniDataGrid.BorderStyle = BorderStyle.None
        IniDataGrid.Columns.AddRange(New ColumnHeader() {IniProfessorID, IniFirstName, IniLastName, IniCourseIDColumnHeader, ColumnHeader22, ColumnHeader24, ColumnHeader23, IniTeachesID})
        IniDataGrid.Depth = 0
        IniDataGrid.Dock = DockStyle.Bottom
        IniDataGrid.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        IniDataGrid.FullRowSelect = True
        IniDataGrid.Location = New Point(30, 100)
        IniDataGrid.Margin = New Padding(14)
        IniDataGrid.MinimumSize = New Size(200, 100)
        IniDataGrid.MouseLocation = New Point(-1, -1)
        IniDataGrid.MouseState = MaterialSkin.MouseState.OUT
        IniDataGrid.Name = "IniDataGrid"
        IniDataGrid.OwnerDraw = True
        IniDataGrid.Size = New Size(1010, 706)
        IniDataGrid.TabIndex = 33
        IniDataGrid.UseCompatibleStateImageBehavior = False
        IniDataGrid.View = View.Details
        ' 
        ' IniProfessorID
        ' 
        IniProfessorID.Text = "Prof ID"
        IniProfessorID.Width = 90
        ' 
        ' IniFirstName
        ' 
        IniFirstName.Text = "First Name"
        IniFirstName.Width = 150
        ' 
        ' IniLastName
        ' 
        IniLastName.Text = "Last Name"
        IniLastName.Width = 150
        ' 
        ' IniCourseIDColumnHeader
        ' 
        IniCourseIDColumnHeader.Text = "Course ID"
        IniCourseIDColumnHeader.Width = 100
        ' 
        ' ColumnHeader22
        ' 
        ColumnHeader22.Text = "Course Name"
        ColumnHeader22.Width = 200
        ' 
        ' ColumnHeader24
        ' 
        ColumnHeader24.Text = "Section"
        ColumnHeader24.Width = 100
        ' 
        ' ColumnHeader23
        ' 
        ColumnHeader23.Text = "Start Date"
        ColumnHeader23.Width = 150
        ' 
        ' IniTeachesID
        ' 
        IniTeachesID.Text = "T.ID"
        IniTeachesID.Width = 80
        ' 
        ' MaterialCard8
        ' 
        MaterialCard8.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard8.Controls.Add(IniProfLbl)
        MaterialCard8.Controls.Add(IniDateLbl)
        MaterialCard8.Controls.Add(IniTimeLbl)
        MaterialCard8.Controls.Add(MaterialLabel15)
        MaterialCard8.Controls.Add(PictureBox3)
        MaterialCard8.Depth = 0
        MaterialCard8.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard8.Location = New Point(14, 14)
        MaterialCard8.Margin = New Padding(14)
        MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard8.Name = "MaterialCard8"
        MaterialCard8.Padding = New Padding(30)
        MaterialCard8.Size = New Size(1825, 110)
        MaterialCard8.TabIndex = 10
        ' 
        ' IniProfLbl
        ' 
        IniProfLbl.AutoSize = True
        IniProfLbl.Depth = 0
        IniProfLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        IniProfLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        IniProfLbl.Location = New Point(1528, 24)
        IniProfLbl.MouseState = MaterialSkin.MouseState.HOVER
        IniProfLbl.Name = "IniProfLbl"
        IniProfLbl.Size = New Size(264, 24)
        IniProfLbl.TabIndex = 7
        IniProfLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' IniDateLbl
        ' 
        IniDateLbl.AutoSize = True
        IniDateLbl.Depth = 0
        IniDateLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniDateLbl.Location = New Point(1664, 48)
        IniDateLbl.MouseState = MaterialSkin.MouseState.HOVER
        IniDateLbl.Name = "IniDateLbl"
        IniDateLbl.Size = New Size(128, 19)
        IniDateLbl.TabIndex = 6
        IniDateLbl.Text = "December 5, 2024"
        ' 
        ' IniTimeLbl
        ' 
        IniTimeLbl.AutoSize = True
        IniTimeLbl.Depth = 0
        IniTimeLbl.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniTimeLbl.Location = New Point(1751, 67)
        IniTimeLbl.MouseState = MaterialSkin.MouseState.HOVER
        IniTimeLbl.Name = "IniTimeLbl"
        IniTimeLbl.Size = New Size(41, 19)
        IniTimeLbl.TabIndex = 5
        IniTimeLbl.Text = "11:04"
        ' 
        ' MaterialLabel15
        ' 
        MaterialLabel15.AutoSize = True
        MaterialLabel15.Depth = 0
        MaterialLabel15.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel15.Location = New Point(485, 26)
        MaterialLabel15.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel15.Name = "MaterialLabel15"
        MaterialLabel15.Size = New Size(855, 58)
        MaterialLabel15.TabIndex = 1
        MaterialLabel15.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
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
        ' MaterialCard5
        ' 
        MaterialCard5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard5.Controls.Add(IniProfLastNameBox)
        MaterialCard5.Controls.Add(IniDeleteBtn)
        MaterialCard5.Controls.Add(IniUpdateBtn)
        MaterialCard5.Controls.Add(IniClearBtn)
        MaterialCard5.Controls.Add(IniSectionBox)
        MaterialCard5.Controls.Add(IniCourseIdBox)
        MaterialCard5.Controls.Add(IniCourse)
        MaterialCard5.Controls.Add(IniAssignBtn)
        MaterialCard5.Controls.Add(MaterialLabel46)
        MaterialCard5.Controls.Add(IniSelectProfessorDataGrid)
        MaterialCard5.Controls.Add(IniProfID)
        MaterialCard5.Controls.Add(IniProfFirstNameBox)
        MaterialCard5.Controls.Add(MaterialLabel42)
        MaterialCard5.Controls.Add(IniChooseCourseDataGrid)
        MaterialCard5.Controls.Add(MaterialLabel16)
        MaterialCard5.Controls.Add(MaterialLabel17)
        MaterialCard5.Depth = 0
        MaterialCard5.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard5.Location = New Point(14, 155)
        MaterialCard5.Margin = New Padding(14)
        MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard5.Name = "MaterialCard5"
        MaterialCard5.Padding = New Padding(30)
        MaterialCard5.Size = New Size(727, 836)
        MaterialCard5.TabIndex = 0
        ' 
        ' IniProfLastNameBox
        ' 
        IniProfLastNameBox.AnimateReadOnly = False
        IniProfLastNameBox.BorderStyle = BorderStyle.None
        IniProfLastNameBox.Depth = 0
        IniProfLastNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniProfLastNameBox.Hint = "Professor last name"
        IniProfLastNameBox.LeadingIcon = Nothing
        IniProfLastNameBox.Location = New Point(392, 115)
        IniProfLastNameBox.MaxLength = 50
        IniProfLastNameBox.MouseState = MaterialSkin.MouseState.OUT
        IniProfLastNameBox.Multiline = False
        IniProfLastNameBox.Name = "IniProfLastNameBox"
        IniProfLastNameBox.Size = New Size(301, 50)
        IniProfLastNameBox.TabIndex = 50
        IniProfLastNameBox.Text = ""
        IniProfLastNameBox.TrailingIcon = Nothing
        IniProfLastNameBox.UseAccent = False
        ' 
        ' IniDeleteBtn
        ' 
        IniDeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        IniDeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        IniDeleteBtn.Depth = 0
        IniDeleteBtn.HighEmphasis = True
        IniDeleteBtn.Icon = Nothing
        IniDeleteBtn.Location = New Point(454, 35)
        IniDeleteBtn.Margin = New Padding(4, 6, 4, 6)
        IniDeleteBtn.MouseState = MaterialSkin.MouseState.HOVER
        IniDeleteBtn.Name = "IniDeleteBtn"
        IniDeleteBtn.NoAccentTextColor = Color.Empty
        IniDeleteBtn.Size = New Size(73, 36)
        IniDeleteBtn.TabIndex = 49
        IniDeleteBtn.Text = "DELETE"
        IniDeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        IniDeleteBtn.UseAccentColor = False
        IniDeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' IniUpdateBtn
        ' 
        IniUpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        IniUpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        IniUpdateBtn.Depth = 0
        IniUpdateBtn.HighEmphasis = True
        IniUpdateBtn.Icon = Nothing
        IniUpdateBtn.Location = New Point(535, 35)
        IniUpdateBtn.Margin = New Padding(4, 6, 4, 6)
        IniUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER
        IniUpdateBtn.Name = "IniUpdateBtn"
        IniUpdateBtn.NoAccentTextColor = Color.Empty
        IniUpdateBtn.Size = New Size(77, 36)
        IniUpdateBtn.TabIndex = 48
        IniUpdateBtn.Text = "UPDATE"
        IniUpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        IniUpdateBtn.UseAccentColor = False
        IniUpdateBtn.UseVisualStyleBackColor = True
        ' 
        ' IniClearBtn
        ' 
        IniClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        IniClearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        IniClearBtn.Depth = 0
        IniClearBtn.HighEmphasis = True
        IniClearBtn.Icon = Nothing
        IniClearBtn.Location = New Point(380, 35)
        IniClearBtn.Margin = New Padding(4, 6, 4, 6)
        IniClearBtn.MouseState = MaterialSkin.MouseState.HOVER
        IniClearBtn.Name = "IniClearBtn"
        IniClearBtn.NoAccentTextColor = Color.Empty
        IniClearBtn.Size = New Size(66, 36)
        IniClearBtn.TabIndex = 47
        IniClearBtn.Text = "clear"
        IniClearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        IniClearBtn.UseAccentColor = True
        IniClearBtn.UseVisualStyleBackColor = True
        ' 
        ' IniSectionBox
        ' 
        IniSectionBox.AutoResize = False
        IniSectionBox.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IniSectionBox.Depth = 0
        IniSectionBox.DrawMode = DrawMode.OwnerDrawVariable
        IniSectionBox.DropDownHeight = 174
        IniSectionBox.DropDownStyle = ComboBoxStyle.DropDownList
        IniSectionBox.DropDownWidth = 121
        IniSectionBox.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        IniSectionBox.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        IniSectionBox.FormattingEnabled = True
        IniSectionBox.Hint = "Select section"
        IniSectionBox.IntegralHeight = False
        IniSectionBox.ItemHeight = 43
        IniSectionBox.Items.AddRange(New Object() {"BSIT1A", "BSIT1B", "BSIT1C", "BSIT1D", "BSIT1E", "BSIT1F", "BSIT1G", "BSIT1H", "BSIT1I", "BSIT2A", "BSIT2B", "BSIT2C", "BSIT2D", "BSIT2E", "BSIT2F", "BSIT2G", "BSIT2H", "BSIT2I", "BSIT3A", "BSIT3B", "BSIT3C", "BSIT3D", "BSIT3E", "BSIT3F", "BSIT3G", "BSIT3H", "BSIT3I", "BSIT4A", "BSIT4B", "BSIT4C", "BSIT4D", "BSIT4E", "BSIT4F", "BSIT4G", "BSIT4H", "BSIT4I"})
        IniSectionBox.Location = New Point(392, 171)
        IniSectionBox.MaxDropDownItems = 4
        IniSectionBox.MouseState = MaterialSkin.MouseState.OUT
        IniSectionBox.Name = "IniSectionBox"
        IniSectionBox.Size = New Size(301, 49)
        IniSectionBox.StartIndex = 0
        IniSectionBox.TabIndex = 46
        IniSectionBox.UseAccent = False
        ' 
        ' IniCourseIdBox
        ' 
        IniCourseIdBox.AnimateReadOnly = False
        IniCourseIdBox.BorderStyle = BorderStyle.None
        IniCourseIdBox.Depth = 0
        IniCourseIdBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniCourseIdBox.Hint = "Course ID"
        IniCourseIdBox.LeadingIcon = Nothing
        IniCourseIdBox.Location = New Point(33, 226)
        IniCourseIdBox.MaxLength = 50
        IniCourseIdBox.MouseState = MaterialSkin.MouseState.OUT
        IniCourseIdBox.Multiline = False
        IniCourseIdBox.Name = "IniCourseIdBox"
        IniCourseIdBox.Size = New Size(161, 50)
        IniCourseIdBox.TabIndex = 45
        IniCourseIdBox.Text = ""
        IniCourseIdBox.TrailingIcon = Nothing
        IniCourseIdBox.UseAccent = False
        ' 
        ' IniCourse
        ' 
        IniCourse.AnimateReadOnly = False
        IniCourse.BorderStyle = BorderStyle.None
        IniCourse.Depth = 0
        IniCourse.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniCourse.Hint = "Course"
        IniCourse.LeadingIcon = Nothing
        IniCourse.Location = New Point(200, 226)
        IniCourse.MaxLength = 50
        IniCourse.MouseState = MaterialSkin.MouseState.OUT
        IniCourse.Multiline = False
        IniCourse.Name = "IniCourse"
        IniCourse.Size = New Size(493, 50)
        IniCourse.TabIndex = 44
        IniCourse.Text = ""
        IniCourse.TrailingIcon = Nothing
        IniCourse.UseAccent = False
        ' 
        ' IniAssignBtn
        ' 
        IniAssignBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        IniAssignBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        IniAssignBtn.Depth = 0
        IniAssignBtn.HighEmphasis = True
        IniAssignBtn.Icon = Nothing
        IniAssignBtn.Location = New Point(620, 36)
        IniAssignBtn.Margin = New Padding(4, 6, 4, 6)
        IniAssignBtn.MouseState = MaterialSkin.MouseState.HOVER
        IniAssignBtn.Name = "IniAssignBtn"
        IniAssignBtn.NoAccentTextColor = Color.Empty
        IniAssignBtn.Size = New Size(73, 36)
        IniAssignBtn.TabIndex = 43
        IniAssignBtn.Text = "ASsign"
        IniAssignBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        IniAssignBtn.UseAccentColor = False
        IniAssignBtn.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel46
        ' 
        MaterialLabel46.AutoSize = True
        MaterialLabel46.Depth = 0
        MaterialLabel46.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel46.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel46.Location = New Point(33, 526)
        MaterialLabel46.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel46.Name = "MaterialLabel46"
        MaterialLabel46.Size = New Size(283, 14)
        MaterialLabel46.TabIndex = 42
        MaterialLabel46.Text = "Select from the following professor or manually type"
        ' 
        ' IniSelectProfessorDataGrid
        ' 
        IniSelectProfessorDataGrid.AllowColumnReorder = True
        IniSelectProfessorDataGrid.AutoSizeTable = False
        IniSelectProfessorDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IniSelectProfessorDataGrid.BorderStyle = BorderStyle.None
        IniSelectProfessorDataGrid.Columns.AddRange(New ColumnHeader() {ColumnHeader17, ColumnHeader21, ColumnHeader33})
        IniSelectProfessorDataGrid.Depth = 0
        IniSelectProfessorDataGrid.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        IniSelectProfessorDataGrid.FullRowSelect = True
        IniSelectProfessorDataGrid.Location = New Point(33, 282)
        IniSelectProfessorDataGrid.MinimumSize = New Size(200, 100)
        IniSelectProfessorDataGrid.MouseLocation = New Point(-1, -1)
        IniSelectProfessorDataGrid.MouseState = MaterialSkin.MouseState.OUT
        IniSelectProfessorDataGrid.Name = "IniSelectProfessorDataGrid"
        IniSelectProfessorDataGrid.OwnerDraw = True
        IniSelectProfessorDataGrid.Size = New Size(661, 241)
        IniSelectProfessorDataGrid.TabIndex = 41
        IniSelectProfessorDataGrid.UseCompatibleStateImageBehavior = False
        IniSelectProfessorDataGrid.View = View.Details
        ' 
        ' ColumnHeader17
        ' 
        ColumnHeader17.Text = "ID"
        ColumnHeader17.Width = 200
        ' 
        ' ColumnHeader21
        ' 
        ColumnHeader21.Text = "First Name"
        ColumnHeader21.Width = 200
        ' 
        ' ColumnHeader33
        ' 
        ColumnHeader33.Text = "Last Name"
        ColumnHeader33.Width = 300
        ' 
        ' IniProfID
        ' 
        IniProfID.AnimateReadOnly = False
        IniProfID.BorderStyle = BorderStyle.None
        IniProfID.Depth = 0
        IniProfID.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniProfID.Hint = "Professor ID"
        IniProfID.LeadingIcon = Nothing
        IniProfID.Location = New Point(33, 170)
        IniProfID.MaxLength = 50
        IniProfID.MouseState = MaterialSkin.MouseState.OUT
        IniProfID.Multiline = False
        IniProfID.Name = "IniProfID"
        IniProfID.Size = New Size(353, 50)
        IniProfID.TabIndex = 40
        IniProfID.Text = ""
        IniProfID.TrailingIcon = Nothing
        IniProfID.UseAccent = False
        ' 
        ' IniProfFirstNameBox
        ' 
        IniProfFirstNameBox.AnimateReadOnly = False
        IniProfFirstNameBox.BorderStyle = BorderStyle.None
        IniProfFirstNameBox.Depth = 0
        IniProfFirstNameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        IniProfFirstNameBox.Hint = "Professor first name"
        IniProfFirstNameBox.LeadingIcon = Nothing
        IniProfFirstNameBox.Location = New Point(33, 114)
        IniProfFirstNameBox.MaxLength = 50
        IniProfFirstNameBox.MouseState = MaterialSkin.MouseState.OUT
        IniProfFirstNameBox.Multiline = False
        IniProfFirstNameBox.Name = "IniProfFirstNameBox"
        IniProfFirstNameBox.Size = New Size(353, 50)
        IniProfFirstNameBox.TabIndex = 39
        IniProfFirstNameBox.Text = ""
        IniProfFirstNameBox.TrailingIcon = Nothing
        IniProfFirstNameBox.UseAccent = False
        ' 
        ' MaterialLabel42
        ' 
        MaterialLabel42.AutoSize = True
        MaterialLabel42.Depth = 0
        MaterialLabel42.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel42.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel42.Location = New Point(33, 792)
        MaterialLabel42.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel42.Name = "MaterialLabel42"
        MaterialLabel42.Size = New Size(176, 14)
        MaterialLabel42.TabIndex = 38
        MaterialLabel42.Text = "Select course to enroll teacher to"
        ' 
        ' IniChooseCourseDataGrid
        ' 
        IniChooseCourseDataGrid.AllowColumnReorder = True
        IniChooseCourseDataGrid.AutoSizeTable = False
        IniChooseCourseDataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        IniChooseCourseDataGrid.BorderStyle = BorderStyle.None
        IniChooseCourseDataGrid.Columns.AddRange(New ColumnHeader() {IniCourseID, IniCourseName, IniTerm, IniSem})
        IniChooseCourseDataGrid.Depth = 0
        IniChooseCourseDataGrid.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        IniChooseCourseDataGrid.FullRowSelect = True
        IniChooseCourseDataGrid.Location = New Point(33, 543)
        IniChooseCourseDataGrid.MinimumSize = New Size(200, 100)
        IniChooseCourseDataGrid.MouseLocation = New Point(-1, -1)
        IniChooseCourseDataGrid.MouseState = MaterialSkin.MouseState.OUT
        IniChooseCourseDataGrid.Name = "IniChooseCourseDataGrid"
        IniChooseCourseDataGrid.OwnerDraw = True
        IniChooseCourseDataGrid.Size = New Size(660, 246)
        IniChooseCourseDataGrid.TabIndex = 37
        IniChooseCourseDataGrid.UseCompatibleStateImageBehavior = False
        IniChooseCourseDataGrid.View = View.Details
        ' 
        ' IniCourseID
        ' 
        IniCourseID.Text = "Course ID"
        IniCourseID.Width = 200
        ' 
        ' IniCourseName
        ' 
        IniCourseName.Text = "Course Name"
        IniCourseName.Width = 150
        ' 
        ' IniTerm
        ' 
        IniTerm.Text = "Term"
        IniTerm.Width = 150
        ' 
        ' IniSem
        ' 
        IniSem.Text = "Semester"
        IniSem.Width = 150
        ' 
        ' MaterialLabel16
        ' 
        MaterialLabel16.AutoSize = True
        MaterialLabel16.Depth = 0
        MaterialLabel16.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        MaterialLabel16.Location = New Point(33, 71)
        MaterialLabel16.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel16.Name = "MaterialLabel16"
        MaterialLabel16.Size = New Size(205, 19)
        MaterialLabel16.TabIndex = 35
        MaterialLabel16.Text = "Assign courses to professors"
        ' 
        ' MaterialLabel17
        ' 
        MaterialLabel17.AutoSize = True
        MaterialLabel17.Depth = 0
        MaterialLabel17.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel17.Location = New Point(33, 30)
        MaterialLabel17.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel17.Name = "MaterialLabel17"
        MaterialLabel17.Size = New Size(296, 41)
        MaterialLabel17.TabIndex = 34
        MaterialLabel17.Text = "Course assignment"
        ' 
        ' Settings
        ' 
        Settings.Controls.Add(MaterialCard18)
        Settings.Controls.Add(MaterialCard19)
        Settings.Controls.Add(MaterialCard10)
        Settings.ImageKey = "setting (1).png"
        Settings.Location = New Point(44, 4)
        Settings.Name = "Settings"
        Settings.Size = New Size(1869, 1005)
        Settings.TabIndex = 3
        Settings.Text = "Settings"
        Settings.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard18
        ' 
        MaterialCard18.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard18.Controls.Add(DarkModeSwitch)
        MaterialCard18.Controls.Add(MaterialLabel49)
        MaterialCard18.Controls.Add(MaterialLabel50)
        MaterialCard18.Controls.Add(SelfUpdateButton)
        MaterialCard18.Controls.Add(AdminSelfPassword)
        MaterialCard18.Controls.Add(AdminSelfUsernameBox)
        MaterialCard18.Depth = 0
        MaterialCard18.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard18.Location = New Point(16, 313)
        MaterialCard18.Margin = New Padding(14)
        MaterialCard18.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard18.Name = "MaterialCard18"
        MaterialCard18.Padding = New Padding(90, 30, 90, 30)
        MaterialCard18.Size = New Size(1825, 678)
        MaterialCard18.TabIndex = 15
        ' 
        ' DarkModeSwitch
        ' 
        DarkModeSwitch.AutoSize = True
        DarkModeSwitch.Depth = 0
        DarkModeSwitch.Location = New Point(683, 180)
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
        ' MaterialLabel49
        ' 
        MaterialLabel49.AutoSize = True
        MaterialLabel49.Depth = 0
        MaterialLabel49.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel49.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel49.Location = New Point(683, 110)
        MaterialLabel49.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel49.Name = "MaterialLabel49"
        MaterialLabel49.Size = New Size(55, 14)
        MaterialLabel49.TabIndex = 33
        MaterialLabel49.Text = "Password"
        ' 
        ' MaterialLabel50
        ' 
        MaterialLabel50.AutoSize = True
        MaterialLabel50.Depth = 0
        MaterialLabel50.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel50.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        MaterialLabel50.Location = New Point(682, 30)
        MaterialLabel50.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel50.Name = "MaterialLabel50"
        MaterialLabel50.Size = New Size(56, 14)
        MaterialLabel50.TabIndex = 32
        MaterialLabel50.Text = "Username"
        ' 
        ' SelfUpdateButton
        ' 
        SelfUpdateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SelfUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        SelfUpdateButton.Depth = 0
        SelfUpdateButton.HighEmphasis = True
        SelfUpdateButton.Icon = Nothing
        SelfUpdateButton.Location = New Point(1065, 606)
        SelfUpdateButton.Margin = New Padding(4, 6, 4, 6)
        SelfUpdateButton.MouseState = MaterialSkin.MouseState.HOVER
        SelfUpdateButton.Name = "SelfUpdateButton"
        SelfUpdateButton.NoAccentTextColor = Color.Empty
        SelfUpdateButton.Size = New Size(77, 36)
        SelfUpdateButton.TabIndex = 31
        SelfUpdateButton.Text = "update"
        SelfUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        SelfUpdateButton.UseAccentColor = False
        SelfUpdateButton.UseVisualStyleBackColor = True
        ' 
        ' AdminSelfPassword
        ' 
        AdminSelfPassword.AnimateReadOnly = False
        AdminSelfPassword.BorderStyle = BorderStyle.None
        AdminSelfPassword.Depth = 0
        AdminSelfPassword.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        AdminSelfPassword.Hint = "Admin password"
        AdminSelfPassword.LeadingIcon = Nothing
        AdminSelfPassword.Location = New Point(682, 127)
        AdminSelfPassword.MaxLength = 50
        AdminSelfPassword.MouseState = MaterialSkin.MouseState.OUT
        AdminSelfPassword.Multiline = False
        AdminSelfPassword.Name = "AdminSelfPassword"
        AdminSelfPassword.Password = True
        AdminSelfPassword.Size = New Size(460, 50)
        AdminSelfPassword.TabIndex = 25
        AdminSelfPassword.Text = ""
        AdminSelfPassword.TrailingIcon = Nothing
        AdminSelfPassword.UseAccent = False
        ' 
        ' AdminSelfUsernameBox
        ' 
        AdminSelfUsernameBox.AnimateReadOnly = False
        AdminSelfUsernameBox.BorderStyle = BorderStyle.None
        AdminSelfUsernameBox.Depth = 0
        AdminSelfUsernameBox.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        AdminSelfUsernameBox.Hint = "Admin username"
        AdminSelfUsernameBox.LeadingIcon = Nothing
        AdminSelfUsernameBox.Location = New Point(682, 47)
        AdminSelfUsernameBox.MaxLength = 50
        AdminSelfUsernameBox.MouseState = MaterialSkin.MouseState.OUT
        AdminSelfUsernameBox.Multiline = False
        AdminSelfUsernameBox.Name = "AdminSelfUsernameBox"
        AdminSelfUsernameBox.Size = New Size(460, 50)
        AdminSelfUsernameBox.TabIndex = 24
        AdminSelfUsernameBox.Text = ""
        AdminSelfUsernameBox.TrailingIcon = Nothing
        AdminSelfUsernameBox.UseAccent = False
        ' 
        ' MaterialCard19
        ' 
        MaterialCard19.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard19.Controls.Add(MaterialLabel51)
        MaterialCard19.Controls.Add(MaterialLabel52)
        MaterialCard19.Depth = 0
        MaterialCard19.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard19.Location = New Point(14, 152)
        MaterialCard19.Margin = New Padding(14)
        MaterialCard19.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard19.Name = "MaterialCard19"
        MaterialCard19.Padding = New Padding(30)
        MaterialCard19.Size = New Size(1825, 133)
        MaterialCard19.TabIndex = 14
        ' 
        ' MaterialLabel51
        ' 
        MaterialLabel51.AutoSize = True
        MaterialLabel51.Depth = 0
        MaterialLabel51.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel51.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        MaterialLabel51.Location = New Point(33, 78)
        MaterialLabel51.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel51.Name = "MaterialLabel51"
        MaterialLabel51.Size = New Size(99, 17)
        MaterialLabel51.TabIndex = 32
        MaterialLabel51.Text = "Modify account"
        ' 
        ' MaterialLabel52
        ' 
        MaterialLabel52.AutoSize = True
        MaterialLabel52.Depth = 0
        MaterialLabel52.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel52.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel52.Location = New Point(33, 37)
        MaterialLabel52.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel52.Name = "MaterialLabel52"
        MaterialLabel52.Size = New Size(125, 41)
        MaterialLabel52.TabIndex = 31
        MaterialLabel52.Text = "Settings"
        ' 
        ' MaterialCard10
        ' 
        MaterialCard10.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard10.Controls.Add(SettingAdminLbl)
        MaterialCard10.Controls.Add(SettingsDateLabel)
        MaterialCard10.Controls.Add(SettingsTimeLbl)
        MaterialCard10.Controls.Add(MaterialLabel20)
        MaterialCard10.Controls.Add(PictureBox4)
        MaterialCard10.Depth = 0
        MaterialCard10.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard10.Location = New Point(14, 14)
        MaterialCard10.Margin = New Padding(14)
        MaterialCard10.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard10.Name = "MaterialCard10"
        MaterialCard10.Padding = New Padding(30)
        MaterialCard10.Size = New Size(1825, 110)
        MaterialCard10.TabIndex = 10
        ' 
        ' SettingAdminLbl
        ' 
        SettingAdminLbl.AutoSize = True
        SettingAdminLbl.Depth = 0
        SettingAdminLbl.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        SettingAdminLbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        SettingAdminLbl.Location = New Point(1528, 24)
        SettingAdminLbl.MouseState = MaterialSkin.MouseState.HOVER
        SettingAdminLbl.Name = "SettingAdminLbl"
        SettingAdminLbl.Size = New Size(264, 24)
        SettingAdminLbl.TabIndex = 7
        SettingAdminLbl.Text = "Prof. Klarenz Cobie Manrique"
        ' 
        ' SettingsDateLabel
        ' 
        SettingsDateLabel.AutoSize = True
        SettingsDateLabel.Depth = 0
        SettingsDateLabel.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        SettingsDateLabel.Location = New Point(1664, 48)
        SettingsDateLabel.MouseState = MaterialSkin.MouseState.HOVER
        SettingsDateLabel.Name = "SettingsDateLabel"
        SettingsDateLabel.Size = New Size(128, 19)
        SettingsDateLabel.TabIndex = 6
        SettingsDateLabel.Text = "December 5, 2024"
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
        ' MaterialLabel20
        ' 
        MaterialLabel20.AutoSize = True
        MaterialLabel20.Depth = 0
        MaterialLabel20.Font = New Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        MaterialLabel20.Location = New Point(485, 26)
        MaterialLabel20.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel20.Name = "MaterialLabel20"
        MaterialLabel20.Size = New Size(855, 58)
        MaterialLabel20.TabIndex = 1
        MaterialLabel20.Text = "PAMANTASAN NG LUNGSOD NG PASIG"
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
        SignOut.Controls.Add(MaterialCard4)
        SignOut.ImageKey = "logout (1).png"
        SignOut.Location = New Point(44, 4)
        SignOut.Name = "SignOut"
        SignOut.Size = New Size(1869, 1005)
        SignOut.TabIndex = 4
        SignOut.Text = "Sign Out"
        SignOut.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(SignOutCancel)
        MaterialCard4.Controls.Add(SignOutYes)
        MaterialCard4.Controls.Add(MaterialLabel12)
        MaterialCard4.Controls.Add(MaterialLabel11)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(567, 310)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(30)
        MaterialCard4.Size = New Size(725, 260)
        MaterialCard4.TabIndex = 0
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
        ' MaterialLabel12
        ' 
        MaterialLabel12.AutoSize = True
        MaterialLabel12.Depth = 0
        MaterialLabel12.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel12.Location = New Point(262, 71)
        MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel12.Name = "MaterialLabel12"
        MaterialLabel12.Size = New Size(201, 19)
        MaterialLabel12.TabIndex = 1
        MaterialLabel12.Text = "Are you sure on signing out?"
        ' 
        ' MaterialLabel11
        ' 
        MaterialLabel11.AutoSize = True
        MaterialLabel11.Depth = 0
        MaterialLabel11.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel11.Location = New Point(275, 30)
        MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel11.Name = "MaterialLabel11"
        MaterialLabel11.Size = New Size(174, 41)
        MaterialLabel11.TabIndex = 0
        MaterialLabel11.Text = "Signing Out"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "teacher (1) (1).png")
        ImageList1.Images.SetKeyName(1, "reading-book (1).png")
        ImageList1.Images.SetKeyName(2, "exam (1).png")
        ImageList1.Images.SetKeyName(3, "teacher (1) (1).png")
        ImageList1.Images.SetKeyName(4, "setting (1).png")
        ImageList1.Images.SetKeyName(5, "logout (1).png")
        ImageList1.Images.SetKeyName(6, "book (1).png")
        ImageList1.Images.SetKeyName(7, "user (1) (1).png")
        ImageList1.Images.SetKeyName(8, "crowd-of-users (1).png")
        ImageList1.Images.SetKeyName(9, "online-course (1).png")
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(248))
        ClientSize = New Size(1920, 1080)
        Controls.Add(MaterialTabControl1)
        Controls.Add(MaterialDrawer1)
        DrawerAutoShow = True
        DrawerShowIconsWhenHidden = True
        DrawerTabControl = MaterialTabControl1
        DrawerUseColors = True
        Name = "AdminDashboard"
        Padding = New Padding(3, 64, 0, 3)
        Sizable = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        WindowState = FormWindowState.Maximized
        StudentRegistrationCard.ResumeLayout(False)
        StudentRegistrationCard.PerformLayout()
        StudentListCard.ResumeLayout(False)
        MaterialCard7.ResumeLayout(False)
        MaterialCard6.ResumeLayout(False)
        MaterialCard6.PerformLayout()
        MaterialTabControl1.ResumeLayout(False)
        Professor.ResumeLayout(False)
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Student.ResumeLayout(False)
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CoursesAd.ResumeLayout(False)
        MaterialCard3.ResumeLayout(False)
        MaterialCard20.ResumeLayout(False)
        MaterialCard20.PerformLayout()
        MaterialCard21.ResumeLayout(False)
        MaterialCard21.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        BulkEnrollment.ResumeLayout(False)
        MaterialCard13.ResumeLayout(False)
        MaterialCard12.ResumeLayout(False)
        MaterialCard12.PerformLayout()
        MaterialCard11.ResumeLayout(False)
        MaterialCard11.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        MaterialCard1.ResumeLayout(False)
        MaterialCard1.PerformLayout()
        IndividualEnrollment.ResumeLayout(False)
        MaterialCard14.ResumeLayout(False)
        MaterialCard15.ResumeLayout(False)
        MaterialCard15.PerformLayout()
        MaterialCard16.ResumeLayout(False)
        MaterialCard16.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        MaterialCard17.ResumeLayout(False)
        MaterialCard17.PerformLayout()
        CurrentCoursesHandled.ResumeLayout(False)
        MaterialCard9.ResumeLayout(False)
        MaterialCard8.ResumeLayout(False)
        MaterialCard8.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MaterialCard5.ResumeLayout(False)
        MaterialCard5.PerformLayout()
        Settings.ResumeLayout(False)
        MaterialCard18.ResumeLayout(False)
        MaterialCard18.PerformLayout()
        MaterialCard19.ResumeLayout(False)
        MaterialCard19.PerformLayout()
        MaterialCard10.ResumeLayout(False)
        MaterialCard10.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        SignOut.ResumeLayout(False)
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents StudentRegistrationCard As MaterialSkin.Controls.MaterialCard
    Friend WithEvents RegStudentId As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents RegStudentMiddleName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents RegStudentLastName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents RegStudentFirstName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents RegStudentRegBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents RegStudentSection As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents StudentListCard As MaterialSkin.Controls.MaterialCard
    Friend WithEvents SearchStudentTxtBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents RegStudentEmailAddress As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents ProfEmail As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfRegisterBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ProfMiddleName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfLastName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfFirstName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents ProfSearchBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfUsername As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfConfirmPass As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfUpdateBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ProfDeleteBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialDrawer1 As MaterialSkin.Controls.MaterialDrawer
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents Student As TabPage
    Friend WithEvents Professor As TabPage
    Friend WithEvents BulkEnrollment As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents SearchBulk As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Settings As TabPage
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents EnrolleSectionGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents TopPanel As MaterialSkin.Controls.MaterialCard
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents StudentDataGridView As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents SignOut As TabPage
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SignOutCancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents SignOutYes As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CurrentCoursesHandled As TabPage
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel15 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard9 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents IniDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents IniProfessorID As ColumnHeader
    Friend WithEvents IniFirstName As ColumnHeader
    Friend WithEvents IniLastName As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents MaterialLabel16 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel17 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard11 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents BulkProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BulkDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BulkTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel23 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MaterialCard10 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel20 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents AdminProfAdminLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DateLabelProf As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TimeLabelProf As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents StuAdminLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents StuDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents StuTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SettingAdminLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SettingsDateLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SettingsTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IniProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IniDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IniTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard13 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents BulkEnrollBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel33 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SelectSectionToEnroll As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel26 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IndividualEnrollment As TabPage
    Friend WithEvents MaterialCard14 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard15 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel27 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel35 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel36 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton4 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IndAdd As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard16 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents IndProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IndDatelbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IndTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel40 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents MaterialCard17 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel41 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IndEnrolledStudentsDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ColumnHeader31 As ColumnHeader
    Friend WithEvents ColumnHeader32 As ColumnHeader
    Friend WithEvents MaterialLabel43 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton6 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IndSelectStudentDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader35 As ColumnHeader
    Friend WithEvents ColumnHeader36 As ColumnHeader
    Friend WithEvents ColumnHeader37 As ColumnHeader
    Friend WithEvents ColumnHeader38 As ColumnHeader
    Friend WithEvents ColumnHeader39 As ColumnHeader
    Friend WithEvents ColumnHeader40 As ColumnHeader
    Friend WithEvents MaterialLabel44 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel45 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IndSearchStudentBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialComboBox1 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents IndStudentIdBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard18 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DarkModeSwitch As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents MaterialLabel49 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel50 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SelfUpdateButton As MaterialSkin.Controls.MaterialButton
    Friend WithEvents AdminSelfPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents AdminSelfUsernameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard19 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel51 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel52 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel42 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IniChooseCourseDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents IniCourseID As ColumnHeader
    Friend WithEvents IniCourseName As ColumnHeader
    Friend WithEvents IndUnenrollBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IndSelectCourseDatGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents IndCourCourseID As ColumnHeader
    Friend WithEvents IndCourCourseName As ColumnHeader
    Friend WithEvents IniCourse As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents IniAssignBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel46 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IniSelectProfessorDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader33 As ColumnHeader
    Friend WithEvents IniProfID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents IniProfFirstNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents IniCourseIdBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents CoursesAd As TabPage
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents AddCourseDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents CourCourseID As ColumnHeader
    Friend WithEvents CourCourseName As ColumnHeader
    Friend WithEvents MaterialCard20 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents AddDeleteCourseBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents AddUpdateCourseBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents AddAddCourseBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel47 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel48 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel53 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AddCourseNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard21 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CourProfLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CourDateLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CourTimeLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel57 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents AddSearchCourseBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard12 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel34 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel31 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel32 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BulkCourseBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents AddClearBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BulkCoursesDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader41 As ColumnHeader
    Friend WithEvents ColumnHeader42 As ColumnHeader
    Friend WithEvents IniSectionBox As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents IniClearBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IniSearchForProfOrCourseBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents IniDeleteBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IniUpdateBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IniTeachesID As ColumnHeader
    Friend WithEvents IniCourseIDColumnHeader As ColumnHeader
    Friend WithEvents IniProfLastNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ProfessorDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader43 As ColumnHeader
    Friend WithEvents ColumnHeader44 As ColumnHeader
    Friend WithEvents ColumnHeader45 As ColumnHeader
    Friend WithEvents ColumnHeader46 As ColumnHeader
    Friend WithEvents ColumnHeader47 As ColumnHeader
    Friend WithEvents ColumnHeader48 As ColumnHeader
    Friend WithEvents ProfClearBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents StuClearBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents StuDeleteBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents StuUpdateBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IndSortStudentByBox As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents IndSortEnrolledByBox As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents IndSelectedCourseNameBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel25 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IndSelectedCourseIdBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents IndEnrollButton As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IndClearBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ColumnHeader49 As ColumnHeader
    Friend WithEvents ColumnHeader50 As ColumnHeader
    Friend WithEvents MaterialLabel59 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IndSelectedEnrollIdBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel60 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BulkCourseIdBox As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ColumnHeader53 As ColumnHeader
    Friend WithEvents MaterialLabel62 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BulkEnrolledStudentDataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader56 As ColumnHeader
    Friend WithEvents ColumnHeader57 As ColumnHeader
    Friend WithEvents BulkUnenrollBtn As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BulkSectionToUnenroll As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BtnAttachFile As MaterialSkin.Controls.MaterialButton
    Friend WithEvents IniTerm As ColumnHeader
    Friend WithEvents IniSem As ColumnHeader
    Friend WithEvents ClearBulkCoursesBtn As MaterialSkin.Controls.MaterialButton
End Class
