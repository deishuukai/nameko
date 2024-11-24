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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(34, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(562, 86)
        Label1.TabIndex = 0
        Label1.Text = "STUDENT LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(142, 242)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 30)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(142, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 30)
        Label3.TabIndex = 2
        Label3.Text = "USERNAME"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(278, 242)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(278, 200)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(278, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 42)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(632, 450)
        Controls.Add(Button1)
        Controls.Add(txtUsername)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Button1 As Button

End Class
