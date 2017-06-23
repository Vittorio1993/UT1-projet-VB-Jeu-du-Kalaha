Public Class Jeu_du_kalaha_Form_label
    Private a(13) As Integer
    Private i As Integer
    Private valeur As Integer
    Private Sub afficher_label()
        ' Cette procédure permet d’afficher les labels en chaîne de caractère.
        lbl0.Text = CStr(a(0))
        lbl1.Text = CStr(a(1))
        lbl2.Text = CStr(a(2))
        lbl3.Text = CStr(a(3))
        lbl4.Text = CStr(a(4))
        lbl5.Text = CStr(a(5))
        lbl6.Text = CStr(a(6))
        lbl7.Text = CStr(a(7))
        lbl8.Text = CStr(a(8))
        lbl9.Text = CStr(a(9))
        lbl10.Text = CStr(a(10))
        lbl11.Text = CStr(a(11))
        lbl12.Text = CStr(a(12))
        lbl13.Text = CStr(a(13))
    End Sub

    Private Sub verification_label()
        'Cette procédure permet de désactiver les labels quand ceux-ci valent 0.
        If a(0) = 0 Then
            lbl0.Enabled = False
        End If
        If a(1) = 0 Then
            lbl1.Enabled = False
        End If
        If a(2) = 0 Then
            lbl2.Enabled = False
        End If
        If a(3) = 0 Then
            lbl3.Enabled = False
        End If
        If a(4) = 0 Then
            lbl4.Enabled = False
        End If
        If a(5) = 0 Then
            lbl5.Enabled = False
        End If
        If a(7) = 0 Then
            lbl7.Enabled = False
        End If
        If a(8) = 0 Then
            lbl8.Enabled = False
        End If
        If a(9) = 0 Then
            lbl9.Enabled = False
        End If
        If a(10) = 0 Then
            lbl10.Enabled = False
        End If
        If a(11) = 0 Then
            lbl11.Enabled = False
        End If
        If a(12) = 0 Then
            lbl12.Enabled = False
        End If
    End Sub

    Private Sub activer()
        'Une fois que la partie est finie alors on active tous les labels.
        lbl7.Enabled = True : lbl8.Enabled = True : lbl9.Enabled = True : lbl10.Enabled = True : lbl11.Enabled = True : lbl12.Enabled = True
        lbl0.Enabled = True : lbl1.Enabled = True : lbl2.Enabled = True : lbl3.Enabled = True : lbl4.Enabled = True : lbl5.Enabled = True
    End Sub

    Private Sub initialise()
        'Au début de la partie, on initialise le jeu.
        Dim repondre As Integer
        activer()
        lbl13.Enabled = False : lbl6.Enabled = False
        InitialiseJeu(a)
        afficher_label()
        repondre = MsgBox("Bonjour, est ce que le joueur 1 joue en premier?", 4, "Bienvenue au jeu du Kalaha.") ' choisir qui est le premier joueur
        If repondre = 6 Then
            lbl7.Enabled = False : lbl8.Enabled = False : lbl9.Enabled = False : lbl10.Enabled = False : lbl11.Enabled = False : lbl12.Enabled = False
        Else
            lbl0.Enabled = False : lbl1.Enabled = False : lbl2.Enabled = False : lbl3.Enabled = False : lbl4.Enabled = False : lbl5.Enabled = False
        End If
    End Sub

    Public Sub lejoueur1()
        'Cette procédure permet de savoir si le joueur 1 rejoue, gagne ou perd la partie.
        Dim repondre As Integer
        lbljoueur1.BackColor = Color.Transparent
        If PeutJouer(1, i, valeur, a) Then
            lbljoueur1.BackColor = Color.Aquamarine
            lbl7.Enabled = False : lbl8.Enabled = False : lbl9.Enabled = False : lbl10.Enabled = False : lbl11.Enabled = False : lbl12.Enabled = False
            lbl0.Enabled = True : lbl1.Enabled = True : lbl2.Enabled = True : lbl3.Enabled = True : lbl4.Enabled = True : lbl5.Enabled = True
        Else
            lbl0.Enabled = False : lbl1.Enabled = False : lbl2.Enabled = False : lbl3.Enabled = False : lbl4.Enabled = False : lbl5.Enabled = False
            lbl7.Enabled = True : lbl8.Enabled = True : lbl9.Enabled = True : lbl10.Enabled = True : lbl11.Enabled = True : lbl12.Enabled = True
        End If
        verification_label()
        If JeuTermine(a) Then
            If a(6) < a(13) Then
                MsgBox("Le joueur 2 gagne le jeu")
            ElseIf a(6) > a(13) Then
                MsgBox("Le joueur 1 gagne le jeu.")
            Else
                MsgBox("Match nul!")
            End If
            repondre = MsgBox("Veux tu rejouer?", 4, "information")
            If repondre = 6 Then
                activer()
                choisir_entre_les_trois_interfaces.Show()
                Me.Hide()
            Else
                End
            End If
        End If
    End Sub

    Public Sub lejoueur2()
        'Cette procédure permet de savoir si le joueur 2 rejoue, gagne ou perd la partie.
        Dim repondre As Integer
        lbljoueur1.BackColor = Color.Transparent
        If PeutJouer(2, i, valeur, a) Then
            lbljoueur1.BackColor = Color.Aquamarine
            lbl0.Enabled = False : lbl1.Enabled = False : lbl2.Enabled = False : lbl3.Enabled = False : lbl4.Enabled = False : lbl5.Enabled = False
            lbl7.Enabled = True : lbl8.Enabled = True : lbl9.Enabled = True : lbl10.Enabled = True : lbl11.Enabled = True : lbl12.Enabled = True
        Else
            lbl7.Enabled = False : lbl8.Enabled = False : lbl9.Enabled = False : lbl10.Enabled = False : lbl11.Enabled = False : lbl12.Enabled = False
            lbl0.Enabled = True : lbl1.Enabled = True : lbl2.Enabled = True : lbl3.Enabled = True : lbl4.Enabled = True : lbl5.Enabled = True
        End If
        verification_label()
        If JeuTermine(a) Then
            If a(6) < a(13) Then
                MsgBox("Le joueur 2 gagne le jeu.")
            ElseIf a(6) > a(13) Then
                MsgBox("Le joueur 1 gagne le jeu.")
            Else
                MsgBox("Match nul!")
            End If
            repondre = MsgBox("Veux tu rejouer?", 4, "information")
            If repondre = 6 Then
                activer()
                choisir_entre_les_trois_interfaces.Show()
                Me.Hide()
            Else
                End
            End If
        End If
    End Sub

    Private Sub Jeu_du_kalaha_Form_label_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Cette procédure représente la forme de l’interface.
        Dim repondre As Integer
        InitialiseJeu(a)
        afficher_label()
        repondre = MsgBox("Bonjour, est ce que le joueur 1 joue en premier ?", 4, "Bienvenue à Kalaha") ' choisir qui est le premier joueur
        If repondre = 6 Then
            lbl7.Enabled = False : lbl8.Enabled = False : lbl9.Enabled = False : lbl10.Enabled = False : lbl11.Enabled = False : lbl12.Enabled = False
        Else
            lbl0.Enabled = False : lbl1.Enabled = False : lbl2.Enabled = False : lbl3.Enabled = False : lbl4.Enabled = False : lbl5.Enabled = False
        End If
    End Sub

    Private Sub lbl0_Click(sender As Object, e As EventArgs) Handles lbl0.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 0
        valeur = a(0)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur1()
    End Sub

    Private Sub lbl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl1.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 1
        valeur = a(1)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur1()
    End Sub

    Private Sub lbl2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl2.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 2
        valeur = a(2)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur1()
    End Sub

    Private Sub lbl3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl3.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 3
        valeur = a(3)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur1()
    End Sub

    Private Sub lbl4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl4.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 4
        valeur = a(4)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur1()
    End Sub

    Private Sub lbl5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl5.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 5
        valeur = a(5)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur1()
    End Sub

    Private Sub lbl7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl7.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 7
        valeur = a(7)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur2()
    End Sub

    Private Sub lbl8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl8.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 8
        valeur = a(8)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur2()
    End Sub

    Private Sub lbl9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl9.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 9
        valeur = a(9)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur2()
    End Sub

    Private Sub lbl10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl10.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 10
        valeur = a(10)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur2()
    End Sub

    Private Sub lbl11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl11.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 11
        valeur = a(11)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur2()
    End Sub

    Private Sub lbl12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl12.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le label.
        i = 12
        valeur = a(12)
        Jouer(i, a, valeur)
        afficher_label()
        lejoueur2()
    End Sub
End Class