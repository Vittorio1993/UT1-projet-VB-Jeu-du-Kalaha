Public Class choisir_le_niveau_de_ordinateur

    Private Sub btnfacile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnfacile.Click
        'Choisir le niveau facile.
        Jeu_du_kalaha_Contre_ordinateur_facile.Show()
        Me.Hide()
    End Sub

    Private Sub btndifficile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btndifficile.Click
        'Choisir le niveau difficile.
        Jeu_du_kalaha_Contre_ordinateur_dificile.Show()
        Me.Hide()
    End Sub

End Class