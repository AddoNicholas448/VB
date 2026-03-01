<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(39, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 27)
        Label1.TabIndex = 1
        Label1.Text = "NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(48, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 23)
        Label3.TabIndex = 1
        Label3.Text = "EMAIL"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button4.Font = New Font("Arial Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(493, 291)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 29)
        Button4.TabIndex = 0
        Button4.Text = "Creat "
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.WhiteSmoke
        PictureBox1.Image = My.Resources.Resources.IMG_20260220_WA00691
        PictureBox1.Location = New Point(415, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(135, 146)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 23)
        Label4.TabIndex = 1
        Label4.Text = "CONFIRM PASSWORD"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 161)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 23)
        Label5.TabIndex = 1
        Label5.Text = "NEW PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(206, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(206, 33)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(177, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(206, 161)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(177, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(206, 233)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(177, 23)
        TextBox4.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(431, 181)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 23)
        Button1.TabIndex = 0
        Button1.Text = "LOAD PHOTO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(608, 347)
        Controls.Add(TextBox2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Name = "Form3"
        Text = "Sign up"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
End Class
