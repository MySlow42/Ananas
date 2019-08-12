Public Class Form2
    Dim Proc As New Process
    Dim apps As String

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()


        ' Pour insérer l'emplacement du fichier choisi dans le TextBox 
        apps = OpenFileDialog1.FileName

        TextBox1.Text = apps


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Proc.StartInfo.FileName = "logAnanas.txt"
        Proc.Start()
        Proc.Close()

    End Sub
End Class