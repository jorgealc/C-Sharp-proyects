Public Class Form1

    Public valor, codigo, sumar, i As Integer 'Podrán ser utilizadas en cualquier procedimiento de la clase 

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        codigo = 1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim item As New ListViewItem(codigo)
        item.SubItems.Add(ComboBox1.SelectedItem) 'Obtiene o establece el elemento seleccionado en el ComboBox
        item.SubItems.Add(valor)
        ListView1.Items.Add(item)
        codigo = +1
        sumar = 0
        For Me.i = 0 To ListView1.Items.Count - 1
            sumar = sumar + CDbl(ListView1.Items(i).SubItems(2).Text)


        Next
        TextBox1.Text = sumar

    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim item As New ListViewItem(codigo)
        item.SubItems.Add(ComboBox2.SelectedItem) 'Obtiene o establece el elemento seleccionado en el ComboBox
        item.SubItems.Add(valor)
        ListView1.Items.Add(item)
        codigo = +1
        sumar = 0
        For Me.i = 0 To ListView1.Items.Count - 1
            sumar = sumar + CDbl(ListView1.Items(i).SubItems(2).Text)


        Next
        TextBox1.Text = sumar
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                valor = 1500
            Case 1
                valor = 1300
            Case 2
                valor = 1800
            Case 3
                valor = 1500
            Case 4
                valor = 2000
            

        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
         Select ComboBox2.SelectedIndex
            Case 0
                valor = 4000
            Case 1
                valor = 2500
            Case 2
                valor = 1200
            Case 3
                valor = 3500
            Case 4
                valor = 3000
        End Select

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListView1.FocusedItem Is Nothing Then
            Exit Sub
        Else
            Dim respuesta = MsgBox("Desea eliminar el elemento(Si/No)", MsgBoxStyle.YesNo)
            If (respuesta = "6") Then
                ListView1.Items.RemoveAt(ListView1.FocusedItem.Index)
            Else
                MsgBox("Elemento no Eliminado", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
