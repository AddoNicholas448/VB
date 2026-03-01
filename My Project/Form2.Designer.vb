<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        labelTitle = New Label()
        labelFirstName = New Label()
        labelSurname = New Label()
        labelGender = New Label()
        labelDOB = New Label()
        labelAge = New Label()
        lebelOccupation = New Label()
        labelTelephone = New Label()
        labelEmail = New Label()
        labelReligion = New Label()
        labelRegion = New Label()
        cmbTitle = New ComboBox()
        cmbGender = New ComboBox()
        cmbOccupation = New ComboBox()
        cmbMaritalStatus = New ComboBox()
        cmbReligion = New ComboBox()
        cmbRegion = New ComboBox()
        txtFirstName = New TextBox()
        txtSurname = New TextBox()
        txtAge = New TextBox()
        txtTelephone = New TextBox()
        txtEmail = New TextBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        btnPrintPreview = New Button()
        Button3 = New Button()
        btnPrint = New Button()
        btnLoadPhoto = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewLinkColumn()
        Column8 = New DataGridViewLinkColumn()
        Column9 = New DataGridViewLinkColumn()
        Column10 = New DataGridViewLinkColumn()
        Column11 = New DataGridViewLinkColumn()
        Column12 = New DataGridViewLinkColumn()
        cmbDOB = New DateTimePicker()
        labelMaritalStatus = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        btnSubmit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelTitle
        ' 
        labelTitle.AutoSize = True
        labelTitle.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitle.Location = New Point(51, 24)
        labelTitle.Name = "labelTitle"
        labelTitle.Size = New Size(55, 23)
        labelTitle.TabIndex = 0
        labelTitle.Text = "Title:"
        ' 
        ' labelFirstName
        ' 
        labelFirstName.AutoSize = True
        labelFirstName.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelFirstName.Location = New Point(22, 61)
        labelFirstName.Name = "labelFirstName"
        labelFirstName.Size = New Size(104, 23)
        labelFirstName.TabIndex = 0
        labelFirstName.Text = "Firstname:"
        ' 
        ' labelSurname
        ' 
        labelSurname.AutoSize = True
        labelSurname.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSurname.Location = New Point(30, 107)
        labelSurname.Name = "labelSurname"
        labelSurname.Size = New Size(95, 23)
        labelSurname.TabIndex = 0
        labelSurname.Text = "Surname:"
        ' 
        ' labelGender
        ' 
        labelGender.AutoSize = True
        labelGender.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelGender.Location = New Point(37, 156)
        labelGender.Name = "labelGender"
        labelGender.Size = New Size(80, 23)
        labelGender.TabIndex = 0
        labelGender.Text = "Gender:"
        ' 
        ' labelDOB
        ' 
        labelDOB.AutoSize = True
        labelDOB.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelDOB.Location = New Point(12, 205)
        labelDOB.Name = "labelDOB"
        labelDOB.Size = New Size(127, 23)
        labelDOB.TabIndex = 0
        labelDOB.Text = "Date of Birth:"
        ' 
        ' labelAge
        ' 
        labelAge.AutoSize = True
        labelAge.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelAge.Location = New Point(62, 263)
        labelAge.Name = "labelAge"
        labelAge.Size = New Size(49, 23)
        labelAge.TabIndex = 0
        labelAge.Text = "Age:"
        ' 
        ' lebelOccupation
        ' 
        lebelOccupation.AutoSize = True
        lebelOccupation.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lebelOccupation.Location = New Point(25, 313)
        lebelOccupation.Name = "lebelOccupation"
        lebelOccupation.Size = New Size(117, 23)
        lebelOccupation.TabIndex = 0
        lebelOccupation.Text = "Occupation:"
        ' 
        ' labelTelephone
        ' 
        labelTelephone.AutoSize = True
        labelTelephone.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTelephone.Location = New Point(369, 17)
        labelTelephone.Name = "labelTelephone"
        labelTelephone.Size = New Size(108, 23)
        labelTelephone.TabIndex = 0
        labelTelephone.Text = "Telephone:"
        ' 
        ' labelEmail
        ' 
        labelEmail.AutoSize = True
        labelEmail.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelEmail.Location = New Point(400, 65)
        labelEmail.Name = "labelEmail"
        labelEmail.Size = New Size(64, 23)
        labelEmail.TabIndex = 0
        labelEmail.Text = "Email:"
        ' 
        ' labelReligion
        ' 
        labelReligion.AutoSize = True
        labelReligion.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelReligion.Location = New Point(382, 160)
        labelReligion.Name = "labelReligion"
        labelReligion.Size = New Size(86, 23)
        labelReligion.TabIndex = 0
        labelReligion.Text = "Religion:"
        ' 
        ' labelRegion
        ' 
        labelRegion.AutoSize = True
        labelRegion.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelRegion.Location = New Point(390, 209)
        labelRegion.Name = "labelRegion"
        labelRegion.Size = New Size(76, 23)
        labelRegion.TabIndex = 0
        labelRegion.Text = "Region:"
        ' 
        ' cmbTitle
        ' 
        cmbTitle.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTitle.FormattingEnabled = True
        cmbTitle.Items.AddRange(New Object() {"MR.", "MISS"})
        cmbTitle.Location = New Point(131, 24)
        cmbTitle.Name = "cmbTitle"
        cmbTitle.Size = New Size(95, 23)
        cmbTitle.TabIndex = 1
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        cmbGender.Location = New Point(116, 156)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(168, 23)
        cmbGender.TabIndex = 1
        ' 
        ' cmbOccupation
        ' 
        cmbOccupation.FormattingEnabled = True
        cmbOccupation.Items.AddRange(New Object() {"Teacher", "Doctor", "Engineer", "Nurse", "Police Officer", "Lawyer", "Accountant", "Farmer", "Electrician", "Journalist", "Other"})
        cmbOccupation.Location = New Point(116, 309)
        cmbOccupation.Name = "cmbOccupation"
        cmbOccupation.Size = New Size(168, 23)
        cmbOccupation.TabIndex = 1
        ' 
        ' cmbMaritalStatus
        ' 
        cmbMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMaritalStatus.FormattingEnabled = True
        cmbMaritalStatus.Items.AddRange(New Object() {"Single", "Married", "Complicated"})
        cmbMaritalStatus.Location = New Point(458, 107)
        cmbMaritalStatus.Name = "cmbMaritalStatus"
        cmbMaritalStatus.Size = New Size(159, 23)
        cmbMaritalStatus.TabIndex = 1
        ' 
        ' cmbReligion
        ' 
        cmbReligion.FormattingEnabled = True
        cmbReligion.Items.AddRange(New Object() {"Christian ", "Muslim", "Other"})
        cmbReligion.Location = New Point(458, 156)
        cmbReligion.Name = "cmbReligion"
        cmbReligion.Size = New Size(159, 23)
        cmbReligion.TabIndex = 1
        ' 
        ' cmbRegion
        ' 
        cmbRegion.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRegion.FormattingEnabled = True
        cmbRegion.Items.AddRange(New Object() {"Greater Accra Region", "Ashanti Region", "Western Region", "Western North Region", "Central Region", "Eastern Region", "Volta Region", "Oti Region", "Northern Region", "Savannah Region", "North East Region", "Upper East Region", "Upper West Region", "Bono Region", "Bono East Region", "Ahafo Region"})
        cmbRegion.Location = New Point(458, 205)
        cmbRegion.Name = "cmbRegion"
        cmbRegion.Size = New Size(159, 23)
        cmbRegion.TabIndex = 1
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(131, 61)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(168, 23)
        txtFirstName.TabIndex = 2
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(131, 107)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(168, 23)
        txtSurname.TabIndex = 2
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(116, 259)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(168, 23)
        txtAge.TabIndex = 2
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(458, 13)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(159, 23)
        txtTelephone.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(458, 61)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(159, 23)
        txtEmail.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Cornsilk
        PictureBox1.Image = My.Resources.Resources.IMG_20260220_WA00691
        PictureBox1.Location = New Point(667, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(153, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(369, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 29)
        Button1.TabIndex = 5
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnPrintPreview
        ' 
        btnPrintPreview.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnPrintPreview.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrintPreview.Location = New Point(685, 276)
        btnPrintPreview.Name = "btnPrintPreview"
        btnPrintPreview.Size = New Size(116, 29)
        btnPrintPreview.TabIndex = 5
        btnPrintPreview.Text = "Print Preview"
        btnPrintPreview.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(463, 313)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 29)
        Button3.TabIndex = 5
        Button3.Text = "Close"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.Location = New Point(553, 313)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 29)
        btnPrint.TabIndex = 5
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' btnLoadPhoto
        ' 
        btnLoadPhoto.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoadPhoto.Location = New Point(676, 230)
        btnLoadPhoto.Name = "btnLoadPhoto"
        btnLoadPhoto.Size = New Size(135, 30)
        btnLoadPhoto.TabIndex = 5
        btnLoadPhoto.Text = "Load Photo"
        btnLoadPhoto.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AccessibleRole = AccessibleRole.TitleBar
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        DataGridView1.Cursor = Cursors.SizeAll
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Format = "f"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = Color.White
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.GridColor = SystemColors.ScrollBar
        DataGridView1.Location = New Point(-9, 410)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Size = New Size(871, 96)
        DataGridView1.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "TITLE"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "FIRSTNAME"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "SURNAME"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "GENDER"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "DOB"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "AGE"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "OCCUPATION"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "TELEPHONE"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "EMAIL"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "MARITAL STATUS"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "RELIGION"
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "REGION"
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        ' 
        ' cmbDOB
        ' 
        cmbDOB.Location = New Point(116, 205)
        cmbDOB.Name = "cmbDOB"
        cmbDOB.Size = New Size(231, 23)
        cmbDOB.TabIndex = 7
        ' 
        ' labelMaritalStatus
        ' 
        labelMaritalStatus.AutoSize = True
        labelMaritalStatus.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelMaritalStatus.Location = New Point(341, 111)
        labelMaritalStatus.Name = "labelMaritalStatus"
        labelMaritalStatus.Size = New Size(139, 23)
        labelMaritalStatus.TabIndex = 0
        labelMaritalStatus.Text = "Marital Status:"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnSubmit.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(685, 349)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(150, 36)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(874, 518)
        Controls.Add(btnSubmit)
        Controls.Add(cmbDOB)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(btnPrint)
        Controls.Add(btnLoadPhoto)
        Controls.Add(btnPrintPreview)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(txtEmail)
        Controls.Add(txtTelephone)
        Controls.Add(txtAge)
        Controls.Add(txtSurname)
        Controls.Add(txtFirstName)
        Controls.Add(cmbRegion)
        Controls.Add(cmbReligion)
        Controls.Add(cmbMaritalStatus)
        Controls.Add(cmbOccupation)
        Controls.Add(cmbGender)
        Controls.Add(cmbTitle)
        Controls.Add(labelRegion)
        Controls.Add(labelMaritalStatus)
        Controls.Add(labelReligion)
        Controls.Add(labelEmail)
        Controls.Add(labelTelephone)
        Controls.Add(lebelOccupation)
        Controls.Add(labelAge)
        Controls.Add(labelDOB)
        Controls.Add(labelGender)
        Controls.Add(labelSurname)
        Controls.Add(labelFirstName)
        Controls.Add(labelTitle)
        Name = "Form2"
        Text = "Student Information"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelTitle As Label
    Friend WithEvents labelFirstName As Label
    Friend WithEvents labelSurname As Label
    Friend WithEvents labelGender As Label
    Friend WithEvents labelDOB As Label
    Friend WithEvents labelAge As Label
    Friend WithEvents lebelOccupation As Label
    Friend WithEvents labelTelephone As Label
    Friend WithEvents labelEmail As Label
    Friend WithEvents labelReligion As Label
    Friend WithEvents labelRegion As Label
    Friend WithEvents cmbTitle As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbOccupation As ComboBox
    Friend WithEvents cmbMaritalStatus As ComboBox
    Friend WithEvents cmbReligion As ComboBox
    Friend WithEvents cmbRegion As ComboBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnLoadPhoto As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbDOB As DateTimePicker
    Friend WithEvents labelMaritalStatus As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewLinkColumn
    Friend WithEvents Column8 As DataGridViewLinkColumn
    Friend WithEvents Column9 As DataGridViewLinkColumn
    Friend WithEvents Column10 As DataGridViewLinkColumn
    Friend WithEvents Column11 As DataGridViewLinkColumn
    Friend WithEvents Column12 As DataGridViewLinkColumn
End Class
