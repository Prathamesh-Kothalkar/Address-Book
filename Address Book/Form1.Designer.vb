<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Button6 = New Button()
        TextBox5 = New TextBox()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 266)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mobile"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 315)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 3
        Label4.Text = "City"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(128, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(198, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(128, 216)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(198, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(128, 266)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(198, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(128, 312)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(198, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 362)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 20)
        Label5.TabIndex = 8
        Label5.Text = "Country"' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.SeaShell
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        ListView1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ListView1.Location = New Point(621, 107)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(715, 421)
        ListView1.TabIndex = 9
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Last Name"' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Mobile"' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "City"' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Country"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(128, 359)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(198, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSalmon
        Button1.Location = New Point(44, 472)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 56)
        Button1.TabIndex = 11
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientInactiveCaption
        Button2.Location = New Point(196, 472)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 56)
        Button2.TabIndex = 12
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Location = New Point(334, 472)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 56)
        Button3.TabIndex = 13
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.Location = New Point(674, 568)
        Button4.Name = "Button4"
        Button4.Size = New Size(110, 56)
        Button4.TabIndex = 14
        Button4.Text = "Remove"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.OrangeRed
        Button5.Location = New Point(969, 568)
        Button5.Name = "Button5"
        Button5.Size = New Size(110, 56)
        Button5.TabIndex = 15
        Button5.Text = "Save"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientActiveCaption
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(62, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(281, 41)
        Label6.TabIndex = 16
        Label6.Text = "ADDRESS BOOK"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Monotype Corsiva", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(12, 686)
        Label7.Name = "Label7"
        Label7.Size = New Size(365, 27)
        Label7.TabIndex = 17
        Label7.Text = "Devleoped by :- Prathamesh Kothalkar"' 
        ' Button6
        ' 
        Button6.BackColor = Color.Khaki
        Button6.Location = New Point(1226, 38)
        Button6.Name = "Button6"
        Button6.Size = New Size(110, 56)
        Button6.TabIndex = 18
        Button6.Text = "Show all Record"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(658, 53)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(223, 27)
        TextBox5.TabIndex = 19
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.Info
        Button7.Location = New Point(901, 53)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 29)
        Button7.TabIndex = 20
        Button7.Text = "Search"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(1120, 568)
        Button8.Name = "Button8"
        Button8.Size = New Size(110, 56)
        Button8.TabIndex = 21
        Button8.Text = "Clear List Box"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Coral
        Button9.Location = New Point(821, 568)
        Button9.Name = "Button9"
        Button9.Size = New Size(110, 56)
        Button9.TabIndex = 22
        Button9.Text = "Update"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(1379, 725)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(TextBox5)
        Controls.Add(Button6)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(ListView1)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "Form1"
        Text = "AddressBook"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
