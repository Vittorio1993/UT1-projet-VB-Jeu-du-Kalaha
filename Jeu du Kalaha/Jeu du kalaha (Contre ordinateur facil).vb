Public Class Jeu_du_kalaha_Contre_ordinateur_dificile
    Private a(13) As Integer
    Private i As Integer
    Private valeur As Integer
    Private Sub afficher_button()
        btn0.Text = CStr(a(0))
        btn1.Text = CStr(a(1))
        btn2.Text = CStr(a(2))
        btn3.Text = CStr(a(3))
        btn4.Text = CStr(a(4))
        btn5.Text = CStr(a(5))
        btn6.Text = CStr(a(6))
        btn7.Text = CStr(a(7))
        btn8.Text = CStr(a(8))
        btn9.Text = CStr(a(9))
        btn10.Text = CStr(a(10))
        btn11.Text = CStr(a(11))
        btn12.Text = CStr(a(12))
        btn13.Text = CStr(a(13))
    End Sub

    Private Sub verification_boutton()
        If a(0) = 0 Then
            btn0.Enabled = False
        End If
        If a(1) = 0 Then
            btn1.Enabled = False
        End If
        If a(2) = 0 Then
            btn2.Enabled = False
        End If
        If a(3) = 0 Then
            btn3.Enabled = False
        End If
        If a(4) = 0 Then
            btn4.Enabled = False
        End If
        If a(5) = 0 Then
            btn5.Enabled = False
        End If
    End Sub


    Public Sub lejoueur1()
        lbljoueur1.BackColor = Color.Transparent
        If a(5) + a(0) + a(1) + a(2) + a(3) + a(4) + a(7) + a(8) + a(9) + a(10) + a(11) + a(12) = 0 Then
            afficher_button()
            If a(6) < a(13) Then
                MsgBox("Dommage ! Le jeu est fini et l'ordinateur gagne le jeu.")
                End
            ElseIf a(6) > a(13) Then
                MsgBox("Filicitation ! Le jeu est fini et tu gagne le jeu.")
                End
            Else
                MsgBox("Le jeu est fini, toi et l'ordinateur sont équilibre")
                End
            End If
        End If
        If PeutJouer(1, i, valeur, a) Then
            lbljoueur1.BackColor = Color.Aquamarine
            btn0.Enabled = True : btn1.Enabled = True : btn2.Enabled = True : btn3.Enabled = True : btn4.Enabled = True : btn5.Enabled = True
        Else
            ordinateur()
        End If
        verification_boutton()

    End Sub

    Public Sub ordinateur()
        If a(5) + a(0) + a(1) + a(2) + a(3) + a(4) + a(7) + a(8) + a(9) + a(10) + a(11) + a(12) = 0 Then
            afficher_button()
            If a(6) < a(13) Then
                MsgBox("Dommage ! Le jeu est fini et l'ordinateur gagne le jeu.")
            ElseIf a(6) > a(13) Then
                MsgBox("Filicitation ! Le jeu est fini et tu gagne le jeu.")
            Else
                MsgBox("Le jeu est fini, toi et l'ordinateur sont équilibre.")
            End If
        End If
        i = Int(Rnd() * 6) + 7
        valeur = a(i)
        Do While valeur = 0
            i = Int(Rnd() * 6) + 7
            valeur = a(i)
        Loop
        Jouer(i, a, valeur)
        afficher_button()
        If PeutJouer(2, i, valeur, a) Then
            btn0.Enabled = False : btn1.Enabled = False : btn2.Enabled = False : btn3.Enabled = False : btn4.Enabled = False : btn5.Enabled = False
            ordinateur()
        Else
            btn0.Enabled = True : btn1.Enabled = True : btn2.Enabled = True : btn3.Enabled = True : btn4.Enabled = True : btn5.Enabled = True
        End If
        verification_boutton()


    End Sub

    Private Sub Je_du_Kalaha3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn13.Enabled = False : btn6.Enabled = False
        InitialiseJeu(a)
        afficher_button()
        btn7.Enabled = False : btn8.Enabled = False : btn9.Enabled = False : btn10.Enabled = False : btn11.Enabled = False : btn12.Enabled = False
    End Sub


    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        i = 0
        valeur = a(0)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        i = 1
        valeur = a(1)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        i = 2
        valeur = a(2)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        i = 3
        valeur = a(3)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        i = 4
        valeur = a(4)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        i = 5
        valeur = a(5)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub
End Class