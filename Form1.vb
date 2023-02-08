

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1

    Public plus As Boolean = False
    Public minus As Boolean = False
    Public del As Boolean = False
    Public mult As Boolean = False
    Public first_smb As String
    Public second_smb As String
    Public first_smb_log As Boolean = False
    Public second_smb_log As Boolean = False
    Public sum As String
    Public Number As Char



    Private Sub Start() Handles Me.Activated

        RichTextBox2.Text = "Введите первое число в поле выше, затем выберите знак."
        RichTextBox1.Font = New Font(RichTextBox1.Text, 40)
        CheckBox1.CheckState = CheckState.Checked

    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, RichTextBox1.KeyPress
        Dim ShCu$ = vbBack & ChrW(1) & ChrW(22) & ChrW(24) & ChrW(26) & ChrW(3)
        e.KeyChar = If("0123456789.".Contains(e.KeyChar) OrElse ShCu.Contains(e.KeyChar), e.KeyChar, Nothing)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = "Лог пуст"
        RichTextBox2.Text = "Введите первое число в поле выше, а затем выберите действие (+, -, / или *)."
        RichTextBox1.Text = ""
        plus = False
        minus = False
        del = False
        mult = False
        first_smb_log = False
        second_smb_log = False
        sum = 0

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If first_smb_log = False Then

            first_smb = RichTextBox1.Text
            first_smb_log = True
            plus = True
            TextBox1.Text = "1_s_l = True; +++"
            RichTextBox2.Text = first_smb + " +..." + "Введите следующее число в поле выше и нажмите « = »."

        End If

        If first_smb = "" Then

            RichTextBox2.Text = ""
            RichTextBox2.Text = "Вы не ввели первое число! Нажмите «ОЧИСТИТЬ!» и начните заново!"

        End If

        RichTextBox1.Text = ""

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If first_smb_log = False Then

            first_smb = RichTextBox1.Text
            first_smb_log = True
            minus = True
            TextBox1.Text = "1_s_l = True; ---"
            RichTextBox2.Text = first_smb + " -..." + "Введите следующее число в поле выше и нажмите « = »."

        End If

        If first_smb = "" Then

            RichTextBox2.Text = ""
            RichTextBox2.Text = "Вы не ввели первое число! Нажмите «ОЧИСТИТЬ!» и начните заново!"

        End If

        RichTextBox1.Text = ""

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        If first_smb_log = False Then

            first_smb = RichTextBox1.Text
            first_smb_log = True
            mult = True
            TextBox1.Text = "1_s_l = True; ***"
            RichTextBox2.Text = first_smb + " *..." + "Введите следующее число в поле выше и нажмите « = »."

        End If

        If first_smb = "" Then

            RichTextBox2.Text = ""
            RichTextBox2.Text = "Вы не ввели первое число! Нажмите «ОЧИСТИТЬ!» и начните заново!"

        End If

        RichTextBox1.Text = ""

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        If first_smb_log = False Then

            first_smb = RichTextBox1.Text
            first_smb_log = True
            del = True
            TextBox1.Text = "1_s_l = True; ///"
            RichTextBox2.Text = first_smb + " /..." + "Введите следующее число в поле выше и нажмите « = »."

        End If

        If first_smb = "" Then

            RichTextBox2.Text = ""
            RichTextBox2.Text = "Вы не ввели первое число! Нажмите «ОЧИСТИТЬ!» и начните заново!"

        End If

        RichTextBox1.Text = ""

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If plus = True Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) + Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " + " + second_smb + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."


        End If

        If minus = True Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) - Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " - " + second_smb + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."

        End If

        If del = True Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) / Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " / " + second_smb + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."

        End If

        If mult = True Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) * Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " * " + second_smb + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."

        End If

        If plus = True And second_smb = "" Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) + Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " + " + "0" + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."


        End If

        If minus = True And second_smb = "" Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) - Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " - " + "0" + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."

        End If

        If del = True And second_smb = "" Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) / Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " / " + "0" + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."

        End If

        If mult = True And second_smb = "" Then

            second_smb = RichTextBox1.Text
            sum = Val(first_smb) * Val(second_smb)
            TextBox1.Text = "Успешно"
            RichTextBox2.Text = first_smb + " * " + "0" + " = " + sum + " - нажмите «ОЧИСТИТЬ!», для ввода нового выражения."

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click

        CheckBox2.CheckState = CheckState.Unchecked
        Button1.Text = "ОЧИСТИТЬ!"
        Label2.Text = "Язык"
        Label1.Text = "Лог:"

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.Click

        CheckBox1.CheckState = CheckState.Unchecked
        Button1.Text = "CLEAR!"
        Label2.Text = "Language"
        Label1.Text = "Log:"

    End Sub

End Class