Imports System.Net.Mail
Imports System.IO
Imports System.Configuration
Imports System
Imports System.Threading

Public Class Ananas
    Dim p As New Process
    Dim Log_Line As String
    Dim MyDate As String
    Dim Date_String As String
    Dim Login As String
    Dim Poste As String

    Private Sub Process_check()
        'Insertion du chemin d'accès de l'appli dans une variable "path"
        Dim path As String = My.Settings.appsname

        'si ma méthode, renseignée par "path", est active, alors on ne fait rien
        If IsProcessRunning(path) = True Then

            'sinon démarrer le processus
        Else
            Process.Start(path)
            'Appel de la méthode "Envoi_Mail()"
            Call Envoi_Mail()
            'Appel de la méthode "LogDemarrerAppli()"
            Call LogDemarrerAppli()
            'Appel de la méthode "Create_EditLogTxt()"
            Call Create_EditLogTxt()
        End If


    End Sub

    Public Sub DateNow()
        'la variable MyDate prend la valeur de la date et l'heure d'aujourd'hui
        MyDate = Now()
        'la variable MyDate qui est en format date sera mise dans le format de Date_String-> String
        Date_String = Format(MyDate)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Lorsque le timer est activé, appeler la méthode Process_check()
        Call Process_check()



    End Sub

    Public Function IsProcessRunning(ByVal name As String) As Boolean
        'la variable name prend la valeur de la variable locale My.Settings.appsname qui contient le nom de l'application à lancer
        name = My.Settings.appsname

        'démarrer la relève des processus en cours et rechercher les processus qui commencent par le nom de l'application à lancer et retourner "true" lorsqu'il y en a un
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Envoi_Mail()
        'si la variable My.Settings.onOff retourne la valeur False, donc si l'envoi de mail est du Off
        If (My.Settings.OnOff = False) Then
            'on fait rien

        Else

            'sinon on donne la valeur du corps du mail à la variable message
            Dim message As String = "Ce message vous a été généré automatiquement car Ananas a détecté que le processus de " & My.Settings.appsname & " n'était plus actif et a dû être relancé." & Chr(13) & Chr(13) & "Envoyé via Ananas sur le compte " & Login & " qui se trouve sur le poste " & Poste & "." & Chr(13) & Chr(13) & "Commentaire de l'utilisateur: " & Chr(13) & My.Settings.msgSuppMail

            'mail du destinataire, mail du receveur, objet et le body, renseigné dans la variable "message", du mail envoyé par SMTP
            Dim email As New MailMessage(My.Settings.expediteur, My.Settings.destinataire, "Message d'information - Ananas a lancé " & My.Settings.appsname, message)
            'insrtion des paramétrages pour envoyer ce mail via le serveur mail SMTP de la ville de lausanne, du n° port renseigné par l'utilisateur
            Dim smtpMail As New System.Net.Mail.SmtpClient(My.Settings.serveurSMTP, My.Settings.noPortSMTP)

            'envoi du mail/ en cas d'erreur faire apparaitre une msgbox 
            Try
                smtpMail.Send(email)
            Catch ex As Exception
                MsgBox("erreur lors de l'envoi du mail")
                MsgBox(ex.ToString)
            End Try

        End If



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

        'création d'un dossier ananas dans le C:\ si celui n'existe pas
        If (Not System.IO.Directory.Exists("C:\Ananas")) Then
            System.IO.Directory.CreateDirectory("C:\Ananas")
        End If

        'la variable locale login est renseignée par le nom de l'utilisateur actuel principale
        Login = Thread.CurrentPrincipal.Identity.Name

        'la variable locale Poste est renseignée par le nom de l'ordinateur 
        Poste = My.Computer.Name

        'le text du label2 est renseignée par la variable locale lien qui renferme le lien de l'application à lancer
        Label2.Text = My.Settings.lien

        'l'interval du timer1 est renseignée dans la variable locale My.Settings.interval
        Timer1.Interval = My.Settings.interval

        'Appel de la méthode Appchoisi
        Call AppChoisi()

        'Appel de la méthode LogDemarrerAnanas
        Call LogDemarrerAnanas()
        'Appel de la méthode Create_EditLogTxt
        Call Create_EditLogTxt()


        If (My.Settings.AutoPlay = True) Then

            Call Process_check()

        End If

    End Sub

    Private Sub Ananas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Appel de la méthode LogFermerAnanas
        Call LogFermerAnanas()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'si Timer1 est activé
        If (Timer1.Enabled = True) Then
            'alors afficher un msg à l'utilisateur sous forme d'informations
            MsgBox("L'application est en cours d'exécution, veuillez l'arrêter pour accéder aux paramètres!", vbInformation, "Information")
        Else
            'sinon afficher la forme 2
            Form2.Show()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'activer le timer
        Timer1.Enabled = True

        'la valeur du Label1 sera Statut: Start
        Label1.Text = "Statut: Start"

        'le titre de la fenêtre sera Ananas is running
        Me.Text = "Ananas is running"

        'désactiver le bouton1 et activer le bouton2
        Button1.Visible = False
        Button2.Visible = True


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'désactiver le timer
        Timer1.Enabled = False

        'la valeur du Label1 sera Statut: Start
        Label1.Text = "Statut: Stop"

        'le titre de la fenêtre sera Ananas is running
        Me.Text = "Ananas is stopped"

        'activer le bouton1 et désactiver le bouton2
        Button1.Visible = True
        Button2.Visible = False

        'appel de la méthode LogArreterAppli()
        Call LogArreterAppli()
        'appel de la méthode Create_EditingLogTxt()
        Call Create_EditLogTxt()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'msg affiché à l'utilisateur lors de l'appui sur le bouton Quitter, sous forme Attention et qui contient les boutons ok et annuler
        Select Case MsgBox("Êtes-vous sûrs de vouloir quitter Ananas?", vbOKCancel, "Attention!")

            Case vbOK

                'procédure si click sur Ok
                Me.Close()

            Case vbCancel
                'procédure si click sur Annuler
        End Select

    End Sub

    Private Sub LogFermerAnanas()


        'Appel la fonction DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a été stoppé le " + Date_String

        'appel de la méthode Create_EditLogTxt()
        Call Create_EditLogTxt()

    End Sub

    Private Sub LogDemarrerAnanas()

        'Appel la fonction DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a été démarré le " + Date_String

    End Sub

    Private Sub LogDemarrerAppli()

        'Appelle la fonction DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a lancé " & My.Settings.appsname & " le " + Date_String

    End Sub
    Public Sub LogArreterAppli()

        'Appelle la fonctino DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "Ananas a arrêté " & My.Settings.appsname & " le " + Date_String

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'ouvre la Form3
        Form3.Show()
    End Sub

    Public Sub LogNewAppli()

        'Appelle la fonction DateNow()
        Call DateNow()

        'dans la variable qui insère des données dans un fichier .txt insertion du string suivi de la date et l'heure
        Log_Line = "L'application " & My.Settings.appsname & " a été séléctionnée pour être contrôlée par Ananas, le " + Date_String

        'appel de la méthode Create_EditingLogTxt()
        Call Create_EditLogTxt()

    End Sub

    Public Sub AppChoisi()

        'si My.Settings.lien a la valeur entre "" ou s'il est vide alors
        If My.Settings.lien = "Veuillez sélectionner un programme dans les paramètres" Or My.Settings.lien = "" Then

            'Mettre le btn1 visible et désactivé
            Button1.Visible = True
            Button1.Enabled = False
            'Mettre le btn2 invisible
            Button2.Visible = False
            'le texte du label1 sera vide
            Label1.Text = ""

            'sinon
        Else

            'Mettre le btn1 visible et activé
            Button1.Visible = True
            Button1.Enabled = True
            'Mettre le btn2 invisible
            Button2.Visible = False
            'le texte du label1 sera "Lancer l'application"
            Label1.Text = "Lancer l'application"
            'appel de la méthode LogNewAppli()
            Call LogNewAppli()

        End If


    End Sub


End Class

