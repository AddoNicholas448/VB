<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Orange
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 24)
        Label1.TabIndex = 0
        Label1.Text = "Length"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 22)
        Label2.TabIndex = 0
        Label2.Text = "Breath"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Blue
        Label3.Location = New Point(12, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 22)
        Label3.TabIndex = 0
        Label3.Text = "Area"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(84, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(95, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(84, 57)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(95, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(84, 113)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(95, 23)
        TextBox3.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Orange
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(195, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 23)
        Button1.TabIndex = 2
        Button1.Text = "Compute"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Salmon
        Button2.Location = New Point(195, 60)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 23)
        Button2.TabIndex = 2
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Blue
        Button3.Location = New Point(195, 113)
        Button3.Name = "Button3"
        Button3.Size = New Size(126, 23)
        Button3.TabIndex = 2
        Button3.Text = "CLOSE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Crimson
        ClientSize = New Size(437, 290)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
