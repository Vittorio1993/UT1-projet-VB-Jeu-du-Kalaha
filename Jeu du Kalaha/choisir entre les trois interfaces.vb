Public Class choisir_entre_les_trois_interfaces

    Private Sub btnformeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnformeB.Click
        'choisir la version contre le joueur. La version sera sous forme de bouton.
        Jeu_du_kalaha_Form_button.Show()
        Me.Hide()
    End Sub

    Private Sub btnformeL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnformeL.Click
        'choisir la version contre le joueur. La version sera sous forme de label.
        Jeu_du_kalaha_Form_label.Show()
        Me.Hide()
    End Sub

    Private Sub btnO_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnO.Click
        'Choisir la version contre l'ordinateur.
        choisir_le_niveau_de_ordinateur.Show()
        Me.Hide()
    End Sub
End Class