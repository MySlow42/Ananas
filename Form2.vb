Imports System.Configuration

Public Class Form2
    Dim Proc As New Process
    Public apps As String
    ' https://social.msdn.microsoft.com/Forums/en-US/333add2a-95e7-4fd8-8874-bf21b653cdac/create-shortcut-using-net?forum=Vsexpressvb
    Dim MyShortcut
    Dim CAnanasPath = "C:\Ananas"
    Dim wsh As Object = CreateObject("WScript.Shell")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Ouvre d'un explorateur de fichiers où le titre est Veuillez sélectionner un programme
        OpenFileDialog1.Title = "Veuillez sélectionner un programme"
        'le lien de l'appli sélectionnée sera renseignée dans la variable locale My.settings.lien
        OpenFileDialog1.FileName = My.Settings.lien
        'affiche l'exploreur
        OpenFileDialog1.ShowDialog()


        'la variable apps renfermera le lien de l'application
        apps = OpenFileDialog1.FileName
        'affiche le lien de l'appliaction dans le Textbox à côté du btn Recherche
        TextBox1.Text = apps
        'le label2 du form1 affichera le lien de l'application
        Ananas.Label2.Text = apps

        'Renseigne la variable locale My.Settings.appsname avec le nom de l'application sans l'extension
        My.Settings.appsname = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.SafeFileName)
        'la variable locale My.Settings.lien prend la valeur de la variale apps -> lien de l'application à lancer
        My.Settings.lien = apps
        'enregistre les paramètres de mes variables locales pour les stocker dans un fichier de configuration
        My.Settings.Save()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ouvre le fichier spécifiée
        Proc.StartInfo.FileName = "logAnanas.txt"
        'lance le processus
        Proc.Start()
        'libère la mémoire
        Proc.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '[OK]

        'la valeur renseignée par l'utilisateur dans le champs My.Settings.interval sera affiché dans le TextBox de l'interval
        My.Settings.interval = TB_interval.Text

        'va insérer la valeur de l'interval dans le timer1 qui se trouve dans le from1
        Ananas.Timer1.Interval = My.Settings.interval

        'la valeur renseignée par l'utilisateur dans le champs My.Settings.destinataire sera affiché dans le TextBox ddu destinataire
        My.Settings.destinataire = TB_dest.Text
        'la valeur renseignée par l'expédit dans le champs My.Settings.expéditeur sera affiché dans le TextBox du expéditeur
        My.Settings.expediteur = TB_exp.Text
        'la valeur renseignée par l'utilisateur dans le champs My.Settings.noPortSMTP sera affiché dans le TextBox du n° de port du serveur SMTP
        My.Settings.noPortSMTP = TB_noPort.Text
        'la valeur renseignée par l'utilisateur dans le champs My.Settings.serveurSMTP sera affiché dans le TextBox de l'adresse du serveur
        My.Settings.serveurSMTP = TB_serveurSMTP.Text
        'la valeur renseignée par l'utilisateur dans le champs My.Settings.CommentaireMail sera affiché dans le TextBox du commentaire
        My.Settings.msgSuppMail = TB_CommentaireMail.Text






        MyShortcut = wsh.CreateShortcut(CAnanasPath & My.Settings.appsname)
        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings("path to exe including the exe")

        MyShortcut.WorkingDirectory = wsh.ExpandEnvironmentStrings("path to exe without the exe")

        MyShortcut.WindowStyle = 4









        'enregistre les paramètres de mes variables locales pour les stocker dans un fichier de configuration
        My.Settings.Save()
        'Appel la méthode qui se trouve dans le form1 AppChoisi
        Call Ananas.AppChoisi()

        'Ferme la fenêtre
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'La valeur du TextBox1 affichera la lien de l'application
        TextBox1.Text = My.Settings.lien
        'la valeur affichée dans le TB d'interval sera celle enregistrée dans le fichier de config pour la variable My.Settings.Interval
        TB_interval.Text = My.Settings.interval

        'la valeur du TB du destinataire sera celle enregistrée dans le fichier de config pour la variable My.Settings.destinataire
        TB_dest.Text = My.Settings.destinataire
        'la valeur du TB du expéditeur sera celle enregistrée dans le fichier de config pour la variable My.Settings.expediteur
        TB_exp.Text = My.Settings.expediteur
        'la valeur du TB du no de port sera celle enregistrée dans le fichier de config pour la variable My.Settings.noPortSMTP
        TB_noPort.Text = My.Settings.noPortSMTP
        'la valeur du TB de l'adresse du serveur sera celle enregistrée dans le fichier de config pour la variable My.Settings.serveurSMTP
        TB_serveurSMTP.Text = My.Settings.serveurSMTP
        'la valeur du TB du commentaire mail sera celle enregistrée dans le fichier de config pour la variable My.Settings.msgSuppMail
        TB_CommentaireMail.Text = My.Settings.msgSuppMail




        'Appel de la méthode BtnOff
        Call BtnOff()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'la paramètre enregistré dans les configurations de My.Settings.OnOff sera True
        My.Settings.OnOff = True

        'Appel de la méthode BtnOff
        Call BtnOff()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


        'la paramètre enregistré dans les configurations de My.Settings.OnOff sera True
        My.Settings.OnOff = False

        'Appel de la méthode BtnOff
        Call BtnOff()

    End Sub

    Private Sub BtnOff()

        'si la valeur dans le fichier de config sous My.Settings.OnOff est False
        If (My.Settings.OnOff = False) Then
            'alors on set la PB1 en visible
            PictureBox1.Visible = True
            'la PB2 en invisible
            PictureBox2.Visible = False
            'la TB du destinataire sera désecativée
            TB_dest.Enabled = False
            'la TB de l'expéditeur sera désecativée
            TB_exp.Enabled = False
            'la TB du no de port sera désecativée
            TB_noPort.Enabled = False
            'la TB de l'adresse du serveur sera désecativée
            TB_serveurSMTP.Enabled = False
            'la TB du commentaire du mail sera désecativée
            TB_CommentaireMail.Enabled = False

            'sinon
        Else
            'la PB1 sera invisible
            PictureBox1.Visible = False
            'la PB2 sera visible
            PictureBox2.Visible = True
            'la TB du destinataire sera ativée
            TB_dest.Enabled = True
            'la TB de l'expéditeur sera ativée
            TB_exp.Enabled = True
            'la TB du no port sera ativée
            TB_noPort.Enabled = True
            'la TB du serveur SMTP sera activé
            TB_serveurSMTP.Enabled = True
            'la TB du commentaire du mail sera ativée
            TB_CommentaireMail.Enabled = True

        End If

    End Sub

    Private Sub PB_AutoPlayOFF_Click(sender As Object, e As EventArgs) Handles PB_AutoPlayOFF.Click

        My.Settings.AutoPlay = False

        Call BtnActiveAnanasStartup()

    End Sub

    Private Sub PB_AutoPlayON_Click(sender As Object, e As EventArgs) Handles PB_AutoPlayON.Click

        My.Settings.AutoPlay = True

        Call BtnActiveAnanasStartup()

    End Sub

    Private Sub BtnActiveAnanasStartup()

        If (My.Settings.AutoPlay = False) Then
            'alors on set la PB1 en visible
            PB_AutoPlayOFF.Visible = False
            'la PB2 en invisible
            PB_AutoPlayON.Visible = True

            'sinon
        Else
            'la PB1 sera invisible
            PB_AutoPlayOFF.Visible = True
            'la PB2 sera visible
            PB_AutoPlayON.Visible = False

        End If


    End Sub

End Class