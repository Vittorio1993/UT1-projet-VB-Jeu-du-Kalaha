Module Module1
    Public Function PeutJouer(ByVal n As Integer, ByVal i As Integer, ByVal valeur As Integer, ByVal a() As Integer) As Boolean
        Dim pouvoir As Boolean
        If n = 1 Then
            If a(7) + a(8) + a(9) + a(10) + a(11) + a(12) = 0 Then
                pouvoir = True
            Else
                If i = 0 Then
                    If valeur Mod 14 = 6 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 1 Then
                    If valeur Mod 14 = 5 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 2 Then
                    If valeur Mod 14 = 4 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 3 Then
                    If valeur Mod 14 = 3 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 4 Then
                    If valeur Mod 14 = 2 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 5 Then
                    If a(0) + a(1) + a(2) + a(3) + a(4) + a(5) = 0 Then
                        pouvoir = False
                    Else
                        If valeur Mod 14 = 1 Then
                            pouvoir = True
                        Else
                            pouvoir = False
                        End If
                    End If
                End If
            End If
        End If
        If n = 2 Then
            If a(0) + a(1) + a(2) + a(3) + a(4) + a(5) = 0 Then
                pouvoir = True
            Else
                If i = 7 Then
                    If valeur Mod 14 = 6 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 8 Then
                    If valeur Mod 14 = 5 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 9 Then
                    If valeur Mod 14 = 4 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 10 Then
                    If valeur Mod 14 = 3 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 11 Then
                    If valeur Mod 14 = 2 Then
                        pouvoir = True
                    Else
                        pouvoir = False
                    End If
                End If
                If i = 12 Then
                    If a(7) + a(8) + a(9) + a(10) + a(11) + a(12) = 0 Then
                        pouvoir = False
                    Else
                        If valeur Mod 14 = 1 Then
                            pouvoir = True
                        Else
                            pouvoir = False
                        End If
                    End If
                End If
            End If
        End If
        Return pouvoir
    End Function

    Public Function JeuTermine(ByVal a() As Integer) As Boolean
        Dim terminer As Boolean
        If a(0) = 0 And a(1) = 0 And a(2) = 0 And a(3) = 0 And a(4) = 0 And a(5) = 0 And a(7) = 0 And a(8) = 0 And a(9) = 0 And a(10) = 0 And a(11) = 0 And a(12) = 0 Then
            terminer = True
        End If
        Return terminer
    End Function

    Public Sub InitialiseJeu(ByRef a() As Integer) '''''''''''修改啦啦啦啦啦
        a(6) = 0 : a(13) = 0 '''''''''''修改啦啦啦啦啦
        Dim i As Integer
        For i = 0 To 5
            a(i) = 3
        Next
        For i = 7 To 12
            a(i) = 3
        Next

    End Sub

    Public Sub Jouer(ByVal i As Integer, ByRef a() As Integer, ByVal valeur As Integer)
        Dim n As Integer
        n = i + 1
        a(i) = 0
        Do While valeur <> 0
            a(n) = a(n) + 1
            n = n + 1
            valeur = valeur - 1
            If n = 14 Then
                n = 0
            End If
        Loop
    End Sub
End Module


