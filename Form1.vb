Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Label10.Text = CStr(1 + 1)
        ' Label10.Text = CStr(CInt(Label10.Text) + 1)
        Label7.Text = CStr(0)
        Label8.Text = CStr(0)
        ' btnunchecked()
    End Sub
    Dim player As Integer = 0
    Dim word As String
    Dim random As New Random
    Dim i As String
    Dim msgwin As String = "you win "
    Dim plname As String = ""
    Dim comptescore As Integer = 0
    Dim status As Boolean

    Public Sub MsgWinName(plwinname As String)
        MsgBox("you win :" + plwinname)
    End Sub
    Public Sub playerwin(pl As Integer)

        If pl = 1 Then
            plname = "player 1"
            comptescore += 1
            'Label7.Text = CStr(comptescore)
            Label7.Text = CStr(CInt(Label7.Text) + 1)
        ElseIf pl = 2 Then
            plname = "Player 2"
            comptescore += 1
            'Label8.Text = CStr(comptescore)
            Label8.Text = CStr(CInt(Label8.Text) + 1)
        End If

    End Sub
    Public Sub btnunchecked()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub
    Public Sub checkwin()
        '1 2 3
        '4 5 6
        '7 8 9
        ' if  status two player don't win 
        ' if player win 
        ' If status = False Then
        If Button1.Text = word And Button2.Text = word And Button3.Text = word Then ' 1 2 3
            ' MsgWinName(plname)

            status = True
            '  comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        ElseIf Button4.Text = word And Button5.Text = word And Button6.Text = word Then ' 4 5 6
            '  MsgWinName(plname)
            status = True
            ' comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        ElseIf Button7.Text = word And Button8.Text = word And Button9.Text = word Then '7 8 9
            ' MsgWinName(plname)
            status = True
            '   comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        ElseIf Button1.Text = word And Button4.Text = word And Button7.Text = word Then '1 4 7
            '  MsgWinName(plname)
            status = True
            comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        ElseIf Button2.Text = word And Button5.Text = word And Button8.Text = word Then '2 5 8
            ' MsgWinName(plname)
            status = True
            '   comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        ElseIf Button3.Text = word And Button6.Text = word And Button9.Text = word Then '3 6 9
            ' MsgWinName(plname)
            status = True
            ' comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        ElseIf Button1.Text = word And Button5.Text = word And Button9.Text = word Then '1 5 9
            '  MsgWinName(plname)
            status = True
            'comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        ElseIf Button3.Text = word And Button5.Text = word And Button7.Text = word Then '3 5  7
            '  MsgWinName(plname)
            status = True
            'comptescore += 1
            Score.Text = CStr(comptescore)
            btnunchecked()
        Else
            status = False
            ' Else
            ' status = False
            'Else
            'MsgBox("Draw")
            'comptescore += 1
            'Score.Text = CStr(comptescore)
        End If
        '    While (status = True)
        '    End While       '  Else
        '    ' status = False
        '    ' End If
        '    'MsgBox("Draw")
        '    'comptescore += 1
        '    'Score.Text = CStr(comptescore)
        '    'status = False
        If status = True Then
            playerwin(player)
            MsgWinName(plname)
        ElseIf status = False Then
            MsgBox("draw")
        Else

        End If
    End Sub
    Public Sub Resetgame()
        RadioButton1.Enabled = True
        RadioButton1.Checked = False
        RadioButton3.Enabled = True
        status = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox2.Enabled = True
        CheckBox1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        comptescore = 0
    End Sub
    Public Sub testchecked()
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Il faut cocher le  case")
        End If
    End Sub

    Public Sub jeux()
        If CheckBox1.Checked Then
            'MsgBox("player 1")
            player = 1
            lblplayer.Text = "Player 1"
            CheckBox2.Checked = True
            CheckBox2.Enabled = True
            CheckBox1.Checked = False
            CheckBox2.Checked = True
        ElseIf CheckBox2.Checked Then
            'MsgBox("Player 2")
            lblplayer.Text = "player 2"
            player = 2
            CheckBox2.Checked = True
            CheckBox2.Enabled = True
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox1.Checked = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        jeux()
        If player = 1 Then
            Button1.Text = word
            Button1.Enabled = False

        ElseIf player = 2 Then
            Button1.Text = word
            Button1.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        'If playerStatut = 0 Then
        'Button1.Text = word 'X
        'Button1.Enabled = False
        ' Else
        'Button1.Text = word 'O
        'Button1.Enabled = False
        '  End If
        ' CheckBox1.Checked = False
        ' CheckBox2.Checked = True
        ' CheckBox2.Enabled = False
        '  If player = 1 Then
        ' CheckBox1.Enabled
        '  End If
        checkwin()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        jeux()
        If player = 1 Then
            Button2.Text = word
            Button2.Enabled = False
        ElseIf player = 2 Then
            Button2.Text = word
            Button2.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        jeux()
        If player = 1 Then
            Button3.Text = word
            Button3.Enabled = False

        ElseIf player = 2 Then
            Button3.Text = word
            Button3.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        jeux()
        If player = 1 Then
            Button4.Text = word
            Button4.Enabled = False
        ElseIf player = 2 Then
            Button4.Text = word
            Button4.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        jeux()
        If player = 1 Then
            Button5.Text = word
            Button5.Enabled = False
        ElseIf player = 2 Then
            Button5.Text = word
            Button5.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        jeux()
        If player = 1 Then
            Button6.Text = word
            Button6.Enabled = False
        ElseIf player = 2 Then
            Button6.Text = word
            Button6.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        jeux()
        If player = 1 Then
            Button7.Text = word
            Button7.Enabled = False
        ElseIf player = 2 Then
            Button7.Text = word
            Button7.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        jeux()
        If player = 1 Then
            Button8.Text = word
            Button8.Enabled = False
        ElseIf player = 2 Then
            Button8.Text = word
            Button8.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        jeux()
        If player = 1 Then
            Button9.Text = word
            Button9.Enabled = False
        ElseIf player = 2 Then
            Button9.Text = word
            Button9.Enabled = False

        Else
            MsgBox("Erreur")
        End If
        checkwin()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            If player = 1 Then
                word = "X"
            Else
                word = "O"
            End If

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            If player = 2 Then
                word = "O"
            Else
                ' player = 1
                word = "X"
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton3.Enabled = False
            RadioButton1.Enabled = False
            CheckBox1.Checked = True
            CheckBox1.Enabled = False
            CheckBox2.Checked = True
            CheckBox2.Enabled = False
            player = 1
            player = 2
            'If player = 1 Then
            '    CheckBox1.Enabled = True
            '    CheckBox1.Checked = True
            'Else
            '    CheckBox2.Enabled = False
            '    CheckBox2.Checked = False
            'End If
            'If player = 2 Then
            '    CheckBox2.Enabled = True
            '    CheckBox2.Checked = True
            'Else
            '    CheckBox1.Enabled = False
            '    CheckBox1.Enabled = False
            'End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Resetgame()
    End Sub

End Class
