<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TB_interval = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_CommentaireMail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TB_dest = New System.Windows.Forms.TextBox()
        Me.TB_serveurSMTP = New System.Windows.Forms.TextBox()
        Me.TB_noPort = New System.Windows.Forms.TextBox()
        Me.TB_exp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PB_AutoPlayOFF = New System.Windows.Forms.PictureBox()
        Me.PB_AutoPlayON = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_AutoPlayOFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_AutoPlayON, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(10, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Rechercher..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(367, 20)
        Me.TextBox1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Fichier Logs"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(426, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TB_interval
        '
        Me.TB_interval.Location = New System.Drawing.Point(131, 59)
        Me.TB_interval.Name = "TB_interval"
        Me.TB_interval.Size = New System.Drawing.Size(150, 20)
        Me.TB_interval.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Interval en ms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Par ex. 15000 = 15 secondes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Adresse du serveur SMTP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Adresse mail de l'expéditeur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Adresse mail du destinataire"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Numéro de port"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TB_interval)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 103)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Application à surveiller"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.TB_CommentaireMail)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.TB_dest)
        Me.GroupBox2.Controls.Add(Me.TB_serveurSMTP)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TB_noPort)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TB_exp)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 227)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Envoi des mails d'alertes"
        '
        'TB_CommentaireMail
        '
        Me.TB_CommentaireMail.Location = New System.Drawing.Point(152, 158)
        Me.TB_CommentaireMail.Multiline = True
        Me.TB_CommentaireMail.Name = "TB_CommentaireMail"
        Me.TB_CommentaireMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB_CommentaireMail.Size = New System.Drawing.Size(351, 50)
        Me.TB_CommentaireMail.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Commentaire"
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(374, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 55)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Pour envoyer à plusieurs mails, séprarer les adresses mails par des virgules."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources._ON
        Me.PictureBox2.Location = New System.Drawing.Point(195, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 23)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Activer/Désactiver l'envoi de mail"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.OFF
        Me.PictureBox1.Location = New System.Drawing.Point(195, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 23)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TB_dest
        '
        Me.TB_dest.Location = New System.Drawing.Point(152, 126)
        Me.TB_dest.Name = "TB_dest"
        Me.TB_dest.Size = New System.Drawing.Size(198, 20)
        Me.TB_dest.TabIndex = 13
        '
        'TB_serveurSMTP
        '
        Me.TB_serveurSMTP.Location = New System.Drawing.Point(152, 65)
        Me.TB_serveurSMTP.Name = "TB_serveurSMTP"
        Me.TB_serveurSMTP.Size = New System.Drawing.Size(199, 20)
        Me.TB_serveurSMTP.TabIndex = 11
        '
        'TB_noPort
        '
        Me.TB_noPort.Location = New System.Drawing.Point(460, 65)
        Me.TB_noPort.Name = "TB_noPort"
        Me.TB_noPort.Size = New System.Drawing.Size(43, 20)
        Me.TB_noPort.TabIndex = 14
        '
        'TB_exp
        '
        Me.TB_exp.Location = New System.Drawing.Point(152, 95)
        Me.TB_exp.Name = "TB_exp"
        Me.TB_exp.Size = New System.Drawing.Size(199, 20)
        Me.TB_exp.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Activer Ananas au démarrage du PC"
        '
        'PB_AutoPlayOFF
        '
        Me.PB_AutoPlayOFF.Image = Global.WindowsApplication1.My.Resources.Resources.OFF
        Me.PB_AutoPlayOFF.Location = New System.Drawing.Point(244, 362)
        Me.PB_AutoPlayOFF.Name = "PB_AutoPlayOFF"
        Me.PB_AutoPlayOFF.Size = New System.Drawing.Size(63, 24)
        Me.PB_AutoPlayOFF.TabIndex = 13
        Me.PB_AutoPlayOFF.TabStop = False
        '
        'PB_AutoPlayON
        '
        Me.PB_AutoPlayON.Image = Global.WindowsApplication1.My.Resources.Resources._ON
        Me.PB_AutoPlayON.Location = New System.Drawing.Point(244, 362)
        Me.PB_AutoPlayON.Name = "PB_AutoPlayON"
        Me.PB_AutoPlayON.Size = New System.Drawing.Size(63, 24)
        Me.PB_AutoPlayON.TabIndex = 14
        Me.PB_AutoPlayON.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 491)
        Me.Controls.Add(Me.PB_AutoPlayON)
        Me.Controls.Add(Me.PB_AutoPlayOFF)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_AutoPlayOFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_AutoPlayON, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TB_interval As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TB_noPort As TextBox
    Friend WithEvents TB_dest As TextBox
    Friend WithEvents TB_exp As TextBox
    Friend WithEvents TB_serveurSMTP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_CommentaireMail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PB_AutoPlayOFF As PictureBox
    Friend WithEvents PB_AutoPlayON As PictureBox
End Class
