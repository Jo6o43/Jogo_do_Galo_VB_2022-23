Public Class Form1
    Public J_player As Byte = 0
    Public J_nc1, J_nc2, J_nc3, J_nc4, J_nc5, J_nc6, J_nc7, J_nc8, J_nc9, J_P1score, J_P2score As Byte
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        J_nc1 = 0
        J_nc2 = 0
        J_nc3 = 0
        J_nc4 = 0
        J_nc5 = 0
        J_nc6 = 0
        J_nc7 = 0
        J_nc8 = 0
        J_nc9 = 0
        J_P1score = 0
        J_P2score = 0
    End Sub
    Private Sub Sair_Click(sender As Object, e As EventArgs)
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("O Jogador 1 ganhou esta rodada, Boa Sorte na Próxima!!!", 0, "Resultado")
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If J_nc1 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B1.Text = "X"
                B1.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B1.Text = "O"
                B1.ForeColor = Color.Blue
            End If
            J_nc1 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If J_nc2 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B2.Text = "X"
                B2.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B2.Text = "O"
                B2.ForeColor = Color.Blue
            End If
            J_nc2 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If J_nc3 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B3.Text = "X"
                B3.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B3.Text = "O"
                B3.ForeColor = Color.Blue
            End If
            J_nc3 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If J_nc4 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B4.Text = "X"
                B4.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B4.Text = "O"
                B4.ForeColor = Color.Blue
            End If
            J_nc4 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If J_nc5 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B5.Text = "X"
                B5.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B5.Text = "O"
                B5.ForeColor = Color.Blue
            End If
            J_nc5 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        If J_nc6 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B6.Text = "X"
                B6.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B6.Text = "O"
                B6.ForeColor = Color.Blue
            End If
            J_nc6 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If J_nc7 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B7.Text = "X"
                B7.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B7.Text = "O"
                B7.ForeColor = Color.Blue
            End If
            J_nc7 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        If J_nc8 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B8.Text = "X"
                B8.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B8.Text = "O"
                B8.ForeColor = Color.Blue
            End If
            J_nc8 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        If J_nc9 = 0 Then
            J_player = J_player + 1
            If J_player = 1 Or J_player = 3 Or J_player = 5 Or J_player = 7 Or J_player = 9 Then
                B9.Text = "X"
                B9.ForeColor = Color.Red
            ElseIf J_player = 2 Or J_player = 4 Or J_player = 6 Or J_player = 8 Then
                B9.Text = "O"
                B9.ForeColor = Color.Blue
            End If
            J_nc9 = 1
        End If
        Module2.resultado()
    End Sub
    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        Module1.restart()
    End Sub
End Class