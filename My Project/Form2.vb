Public Class Form2
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles labelReligion.Click, labelMaritalStatus.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbTitle.Text = " " Then
            MsgBox("Please select your Title", MsgBoxStyle.Information)

        ElseIf txtFirstName.Text = " " Then
            MsgBox("Please enter your FirstName", MsgBoxStyle.Information)

        ElseIf txtFirstName.Text = " " Then
            MsgBox("Please enter your Surename", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnLoadPhoto.Click
        OpenFileDialog1.Title = "Select a Photo"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Set up Save File Dialog
        SaveFileDialog1.Title = "Save Form as Image"
        SaveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Capture the form as bitmap
            Dim bmp As New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

            ' Determine file format from extension
            Select Case System.IO.Path.GetExtension(SaveFileDialog1.FileName).ToLower()
                Case ".png"
                    bmp.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
                Case ".jpg", ".jpeg"
                    bmp.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
                Case ".bmp"
                    bmp.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Bmp)
                Case Else
                    MessageBox.Show("Unsupported file format.")
            End Select

            MessageBox.Show("Form saved successfully!")
        End If
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click

        ' Link PrintDocument to PrintPreviewDialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Capture form as bitmap
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        ' Draw bitmap on print page
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Add columns to DataGridView if not already added
        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("Title", "Title")
            DataGridView1.Columns.Add("FirstName", "First Name")
            DataGridView1.Columns.Add("Surname", "Surname")
            DataGridView1.Columns.Add("Gender", "Gender")
            DataGridView1.Columns.Add("DOB", "Date of Birth")
            DataGridView1.Columns.Add("Age", "Age")
            DataGridView1.Columns.Add("Occupation", "Occupation")
            DataGridView1.Columns.Add("Telephone", "Telephone")
            DataGridView1.Columns.Add("Email", "Email")
            DataGridView1.Columns.Add("MaritalStatus", "Marital Status")
            DataGridView1.Columns.Add("Religion", "Religion")
            DataGridView1.Columns.Add("Region", "Region")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' --- Validation (make sure all required fields are filled) ---
        If labelTitle.Text = "" Or labelFirstName.Text = "" Or labelSurname.Text = "" Or
           labelGender.Text = "" Or labelDOB.Text = "" Or labelAge.Text = "" Or
           lebelOccupation.Text = "" Or labelTelephone.Text = "" Or labelEmail.Text = "" Or
           labelMaritalStatus.Text = "" Or labelReligion.Text = "" Or labelRegion.Text = "" Then

            MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' --- Optional: further validations ---
        ' e.g., email format, age as number, telephone as number, etc.

        ' --- Add data to DataGridView ---


        DataGridView1.Rows.Add(
                               cmbTitle.Text.Trim(),
                               txtFirstName.Text.Trim(),
                               txtSurname.Text.Trim(),
                               cmbGender.Text.Trim(),
                               cmbDOB.Text.Trim(),
                               txtAge.Text.Trim(),
                               cmbOccupation.Text.Trim(),
                               txtTelephone.Text.Trim(),
                               txtEmail.Text.Trim(),
                               cmbMaritalStatus.Text.Trim(),
                               cmbReligion.Text.Trim(),
                               cmbRegion.Text.Trim()
                               )


        'clrear textbox
        cmbTitle.SelectedIndex = -1
        txtFirstName.Clear()
        txtSurname.Clear()
        txtAge.Text.Trim()
        txtTelephone.Clear()
        txtEmail.Clear()
        cmbRegion.SelectedIndex = -1
        cmbReligion.SelectedIndex = -1
        cmbGender.SelectedIndex = -1
        cmbMaritalStatus.SelectedIndex = -1
        cmbOccupation.SelectedIndex = -1


        MessageBox.Show("Data submitted successfully!")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTitle.SelectedIndexChanged

    End Sub

    Private Sub cmbDOB_ValueChanged(sender As Object, e As EventArgs) Handles cmbDOB.ValueChanged
        Dim today As Date = Date.Today
        Dim birthDate As Date = cmbDOB.Value
        Dim age As Integer = today.Year - birthDate.Year

        ' Check if birthday has not occurred this year
        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub txtFirstName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyUp

    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox(e.ToString)
        End If
    End Sub

    Private Sub txtSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSurname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox(e.ToString)
        End If
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedIndexChanged

    End Sub

    Private Sub cmbGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbGender.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox(e.ToString)
        End If
    End Sub
End Class