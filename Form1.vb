Imports System.Net.Mail
Imports System.IO

Public Class Ananas
    Dim p As New Process
    Dim Log_Line As String
    Dim MyDate As String
    Dim Date_String As String

    Private Sub Process_check()
        'Insertion du chemin d'accès de l'appli dans une variable "path"
        Dim path As String = "C:\Windows\System32\calc.exe"

        'si ma méthode, renseignée par "path", est active, alors on ne fait rien
        If IsProcessRunning(path) = True Then

            'sinon démarrer le processus
        Else
            Process.Start(path)
            'Appel de la méthode "Envoi_Mail()"
            Call Envoi_Mail()
            Call LogDemarrerAppli()
            Call Create_EditLogTxt()
        End If


    End Sub

    Private Sub DateNow()
        MyDate = Now()
        Date_String = Format(MyDate)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Lorsque le timer est activé, appeler la méthode Process_check()
        Call Process_check()



    End Sub

    Public Function IsProcessRunning(ByVal name As String) As Boolean
        name = "calc"

        'démarrer la relève des processus en cours et rechercher les processus qui commencent par "calc" et retourner "true" lorsqu'il y en a un
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Envoi_Mail()
        Dim message As String = "Ce message vous a été envoyé automatiquement car Ananas a détecté que le processus de calc.exe n'était plus actif et a dû être relancé." & Chr(13) & Chr(13) & "Envoyé via Ananas sur Visual Studio créé par Romy Cordonier/Pascal Dentan en octobre 2017."

        'mail du destinataire, mail du receveur, objet et le body, renseigné dans la variable "message", du mail envoyé par SMTP
        Dim email As New MailMessage("oss@lausanne.ch", "romy.cordonier@lausanne.ch", "Message d'information - Ananas a relancé Calc.exe", message)
        'insrtion des paramétrages pour envoyer ce mail via le serveur mail SMTP de la vilel de lausanne, du port n° 25
        Dim smtpMail As New System.Net.Mail.SmtpClient("smtp.lausanne.ch", 25)

        'envoi du mail/ en cas d'erreur faire apparaitre une msgbox 
        Try
            smtpMail.Send(email)
        Catch ex As Exception
            MsgBox("erreur lors de l'envoi du mail")
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Create_EditLogTxt()

        'Création d'un flux d'écriture
        Dim sw As New StreamWriter("logAnanas.txt", True)
        'écriture        
        sw.WriteLine(Log_Line)
        'fin du processus sw
        sw.Close()

    End Sub

    Private Sub Ananas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Lancer le programme Ananas"

        Call LogDemarrerAnanas()
        Call Create_EditLogTxt()

        Button2.Visible = False



    End Sub

    Private Sub Ananas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Call LogFermerAnanas()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'activer le timer
        Timer1.Enabled = True

        Label1.Text = "Statut: Start"

        Me.Text = "Ananas is running"

        'désactiver le bouton1 et activer le bouton2
        Button1.Visible = False
        Button2.Visible = True

        Call LogDemarrerAppli()
        'appel de la méthode Create_EditingLogTxt()
        Call Create_EditLogTxt()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'désactiver le timer
        Timer1.Enabled = False

        Label1.Text = "Statut: Stop"

        Me.Text = "Ananas is stopped"

        'activer le bouton1 et désactiver le bouton2
        Button1.Visible = True
        Button2.Visible = False

        Call LogArreterAppli()
        'appel de la méthode Create_EditingLogTxt()
        Call Create_EditLogTxt()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Select Case MsgBox("Êtes-vous sûrs de vouloir quitter Ananas?", vbOKCancel, "Attention!")

            Case vbOK

                'procédure si click sur Ok
                Me.Close()

            Case vbCancel
                'procédure si click sur Annuler
        End Select

    End Sub

    Private Sub LogFermerAnanas()


        'Appel la fonctino DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a été stoppé le " + Date_String

        'appel de la méthode Create_EditingLogTxt()
        Call Create_EditLogTxt()

    End Sub

    Private Sub LogDemarrerAnanas()

        'Appel la fonctino DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a été démarré le " + Date_String

    End Sub

    Private Sub LogDemarrerAppli()

        'Appel la fonctino DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a lancé calc.exe le " + Date_String

    End Sub
    Public Sub LogArreterAppli()

        'Appel la fonctino DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a arrêté calc.exe le " + Date_String
        ' MsgBox(Form2.apps)

    End Sub
End Class

