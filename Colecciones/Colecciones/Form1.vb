Public Class Form1
    Dim librosDeProgramacion As New List(Of String)({"Visual Basic", "VIsual C#", "Visual C++", "Visual F#", "Java", "PHP"})

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        librosDeProgramacion.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Long = InputBox("Indique el índice a eliminar de un máximo de " & librosDeProgramacion.Count - 1, 0)
        If i > librosDeProgramacion.Count - 1 Then Exit Sub
        librosDeProgramacion.Remove(i)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sNuevo As String = InputBox("Ingrese el nuevo libro a agregar en la coleccion:")
        If sNuevo.Trim() <> "" Then librosDeProgramacion.Add(sNuevo)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Long = librosdeProgramacion.Count
        MsgBox("Cantidad de items en la coleccion:" & i)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        For Each item In librosDeProgramacion
            ListBox1.Items.Add(item)
        Next

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        librosDeProgramacion.Sort()
        Button5_Click(sender, e)

    End Sub
End Class
