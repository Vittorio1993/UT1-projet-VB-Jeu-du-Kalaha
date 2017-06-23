Public Class Jeu_du_kalaha_Form_button
    Private a(13) As Integer
    Private i As Integer
    Private valeur As Integer
    Private Sub afficher_button()
        'Cette procédure permet d’afficher les boutons en chaîne de caractère.
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

    Private Sub verification_button()
        'Cette procédure permet de désactiver le bouton quand celui-ci est égal à 0.
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
        If a(7) = 0 Then
            btn7.Enabled = False
        End If
        If a(8) = 0 Then
            btn8.Enabled = False
        End If
        If a(9) = 0 Then
            btn9.Enabled = False
        End If
        If a(10) = 0 Then
            btn10.Enabled = False
        End If
        If a(11) = 0 Then
            btn11.Enabled = False
        End If
        If a(12) = 0 Then
            btn12.Enabled = False
        End If
    End Sub

    Private Sub activer()
        'Une fois que la partie est finie alors on active tous les boutons.
        btn7.Enabled = True : btn8.Enabled = True : btn9.Enabled = True : btn10.Enabled = True : btn11.Enabled = True : btn12.Enabled = True : btn13.Enabled = True
        btn0.Enabled = True : btn1.Enabled = True : btn2.Enabled = True : btn3.Enabled = True : btn4.Enabled = True : btn5.Enabled = True : btn6.Enabled = True
    End Sub

    Private Sub initialise()
        '« Au début de la partie, on initialise le jeu.
        Dim repondre As Integer
        activer()
        btn13.Enabled = False : btn6.Enabled = False
        InitialiseJeu(a)
        afficher_button()
        repondre = MsgBox("Bonjour, est ce que le joueur 1 joue en premier?", 4, "Bienvenue au jeu du Kalaha.") ' choisir qui est le premier joueur
        If repondre = 6 Then
            btn7.Enabled = False : btn8.Enabled = False : btn9.Enabled = False : btn10.Enabled = False : btn11.Enabled = False : btn12.Enabled = False
        Else
            btn0.Enabled = False : btn1.Enabled = False : btn2.Enabled = False : btn3.Enabled = False : btn4.Enabled = False : btn5.Enabled = False
        End If
    End Sub

    Public Sub lejoueur1()
        'Cette procédure permet de savoir si le joueur 1 rejoue, gagne ou perd la partie. 
        Dim repondre As Integer
        lbljoueur1.BackColor = Color.Transparent
        If PeutJouer(1, i, valeur, a) Then
            lbljoueur1.BackColor = Color.Aquamarine
            btn7.Enabled = False : btn8.Enabled = False : btn9.Enabled = False : btn10.Enabled = False : btn11.Enabled = False : btn12.Enabled = False
            btn0.Enabled = True : btn1.Enabled = True : btn2.Enabled = True : btn3.Enabled = True : btn4.Enabled = True : btn5.Enabled = True
        Else
            btn0.Enabled = False : btn1.Enabled = False : btn2.Enabled = False : btn3.Enabled = False : btn4.Enabled = False : btn5.Enabled = False
            btn7.Enabled = True : btn8.Enabled = True : btn9.Enabled = True : btn10.Enabled = True : btn11.Enabled = True : btn12.Enabled = True
        End If
        verification_button()
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
                initialise()
            Else
                End
            End If
        End If
    End Sub

    Public Sub lejoueur2()
        'Cette procédure permet de savoir si le joueur 2 rejoue, gagne ou perd la partie.
        Dim repondre As Integer
        lbljoueur2.BackColor = Color.Transparent
        If PeutJouer(2, i, valeur, a) Then
            lbljoueur2.BackColor = Color.Aquamarine
            btn0.Enabled = False : btn1.Enabled = False : btn2.Enabled = False : btn3.Enabled = False : btn4.Enabled = False : btn5.Enabled = False
            btn7.Enabled = True : btn8.Enabled = True : btn9.Enabled = True : btn10.Enabled = True : btn11.Enabled = True : btn12.Enabled = True
        Else
            btn7.Enabled = False : btn8.Enabled = False : btn9.Enabled = False : btn10.Enabled = False : btn11.Enabled = False : btn12.Enabled = False
            btn0.Enabled = True : btn1.Enabled = True : btn2.Enabled = True : btn3.Enabled = True : btn4.Enabled = True : btn5.Enabled = True
        End If
        verification_button()
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
                initialise()
            Else
                End
            End If
        End If
    End Sub

    Private Sub Jeu_du_kalaha_Form_button_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cette procédure représente la forme de l’interface.
        initialise()
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 0
        valeur = a(0)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 1
        valeur = a(1)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 2
        valeur = a(2)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 3
        valeur = a(3)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 4
        valeur = a(4)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 5
        valeur = a(5)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur1()
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 7
        valeur = a(7)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur2()
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 8
        valeur = a(8)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur2()
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 9
        valeur = a(9)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur2()
    End Sub

    Private Sub btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 10
        valeur = a(10)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur2()
    End Sub

    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 11
        valeur = a(11)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur2()
    End Sub

    Private Sub btn12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        'Cette procédure permet de savoir ce qu’on fait après avoir cliqué sur le bouton.
        i = 12
        valeur = a(12)
        Jouer(i, a, valeur)
        afficher_button()
        lejoueur2()
    End Sub
End Class
