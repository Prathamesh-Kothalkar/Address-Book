Imports System.Configuration
Imports System.Drawing.Text
Imports System.IO
Imports System.Linq.Expressions

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button9.Enabled = False
        ComboBox1.Items.Add("IND")
        ComboBox1.Items.Add("USA")
        ComboBox1.Items.Add("RUS")
        ComboBox1.Items.Add("JPN")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("All Fields are Required")
        Else
            If ListView1.Items.Count = 0 Then
                Dim item1 As ListViewItem
                item1 = ListView1.Items.Add(TextBox1.Text)
                item1.SubItems.Add(TextBox2.Text)
                item1.SubItems.Add(TextBox3.Text)
                item1.SubItems.Add(TextBox4.Text)
                item1.SubItems.Add(ComboBox1.SelectedItem)
                item1 = Nothing
            Else
                With ListView1
                    Dim additem As ListViewItem
                    additem = .FindItemWithText(TextBox1.Text, True, 0, True)
                    If Not additem Is Nothing Then
                        MsgBox("Person is already in Added")
                    Else
                        Dim item1 As ListViewItem
                        item1 = ListView1.Items.Add(TextBox1.Text)
                        item1.SubItems.Add(TextBox2.Text)
                        item1.SubItems.Add(TextBox3.Text)
                        item1.SubItems.Add(TextBox4.Text)
                        item1.SubItems.Add(ComboBox1.SelectedItem)
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iexit As DialogResult
        iexit = MsgBox("Confirm To Exit", MessageBoxButtons.YesNo)
        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim item1 As ListViewItem
            item1 = ListView1.SelectedItems(0)
            item1.Remove()
        Catch a As ArgumentOutOfRangeException
            MsgBox("Please Select name")
        End Try
        Button9.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ''''''
        Dim fileName As String = Application.StartupPath & "\listview.txt"
        Dim writer As StreamWriter

        If File.Exists(fileName) Then
            writer = New StreamWriter(fileName, True)
        Else
            writer = New StreamWriter(fileName)
        End If

        For Each item As ListViewItem In ListView1.Items
            Dim line As String = String.Join(",", item.SubItems.Cast(Of ListViewItem.ListViewSubItem).Select(Function(subItem) subItem.Text))
            writer.WriteLine(line)
        Next

        writer.Close()
        MsgBox("Added SucessFully", MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        ListView1.Items.Clear()
        Button9.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListView1.Items.Clear()
        ' Open the file
        Using reader As New StreamReader("C:\Users\Prath\source\repos\Address Book\bin\Debug\net6.0-windows\listview.txt")
            ' Read the file line by line
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                ' Split the line into separate fields
                Dim fields() As String = line.Split(","c)
                ' Create a new ListViewItem object and add it to the ListView control
                Dim item As New ListViewItem(fields(0)) ' First column
                item.SubItems.Add(fields(1)) ' Second column
                item.SubItems.Add(fields(2)) ' Third column
                item.SubItems.Add(fields(3))
                item.SubItems.Add(fields(4))
                ' Add the item to the ListView control
                ListView1.Items.Add(item)
            End While
        End Using
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Using reader As New StreamReader("C:\Users\Prath\source\repos\Address Book\bin\Debug\net6.0-windows\listview.txt")
            If TextBox5.Text = "" Then
                MsgBox("Enter Name First", MessageBoxIcon.Warning)

            Else
                'clear Listview first
                ListView1.Items.Clear()
                Dim flag As Boolean = False

                ' Read the file line by line
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim fields() As String = line.Split(","c)
                    ' Split the line into separate fields

                    ' Create a new ListViewItem object and add it to the ListView control
                    If fields(0) = (TextBox5.Text) Then
                        Dim item As New ListViewItem(fields(0)) ' First column
                        item.SubItems.Add(fields(1))
                        item.SubItems.Add(fields(2))
                        item.SubItems.Add(fields(3))
                        item.SubItems.Add(fields(4))
                        ' Add the item to the ListView control
                        ListView1.Items.Add(item)
                        flag = True
                    End If
                End While
                If flag = False Then
                    MsgBox("Person Not Found", MessageBoxIcon.Information)
                End If
            End If
        End Using
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim fileName As String = Application.StartupPath & "\temp.txt"
        Dim writer As StreamWriter
        writer = New StreamWriter(fileName)

        For Each item As ListViewItem In ListView1.Items
            Dim line As String = String.Join(",", item.SubItems.Cast(Of ListViewItem.ListViewSubItem).Select(Function(subItem) subItem.Text))
            writer.WriteLine(line)
        Next
        writer.Close()
        ''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''
        Dim sourceFile As String = "C:\Users\Prath\source\repos\Address Book\bin\Debug\net6.0-windows\temp.txt"
        Dim destinationFile As String = "C:\Users\Prath\source\repos\Address Book\bin\Debug\net6.0-windows\listview.txt"

        File.Copy(sourceFile, destinationFile, True)

        MsgBox("Updated..!")
    End Sub
End Class

'**************** Develop By :- Prathamesh Kothalkar ******************' 
