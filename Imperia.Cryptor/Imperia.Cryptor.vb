Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
  Friend WithEvents sChave As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents sValor As System.Windows.Forms.TextBox
  Friend WithEvents sResultado As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents btDecrypt As System.Windows.Forms.Button
  Friend WithEvents btEncrypt As System.Windows.Forms.Button
  Friend WithEvents grpCrypt As System.Windows.Forms.GroupBox
  Friend WithEvents grpBits As System.Windows.Forms.GroupBox
  Friend WithEvents rad256 As System.Windows.Forms.RadioButton
  Friend WithEvents rad128 As System.Windows.Forms.RadioButton
  Friend WithEvents rad192 As System.Windows.Forms.RadioButton
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.sChave = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.sValor = New System.Windows.Forms.TextBox()
    Me.btEncrypt = New System.Windows.Forms.Button()
    Me.btDecrypt = New System.Windows.Forms.Button()
    Me.sResultado = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.grpCrypt = New System.Windows.Forms.GroupBox()
    Me.grpBits = New System.Windows.Forms.GroupBox()
    Me.rad256 = New System.Windows.Forms.RadioButton()
    Me.rad192 = New System.Windows.Forms.RadioButton()
    Me.rad128 = New System.Windows.Forms.RadioButton()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpCrypt.SuspendLayout()
    Me.grpBits.SuspendLayout()
    Me.SuspendLayout()
    '
    'sChave
    '
    Me.sChave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.sChave.Location = New System.Drawing.Point(142, 116)
    Me.sChave.Name = "sChave"
    Me.sChave.Size = New System.Drawing.Size(623, 20)
    Me.sChave.TabIndex = 0
    Me.sChave.UseSystemPasswordChar = True
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(102, 116)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 16)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Key"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(94, 148)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 23)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Value"
    '
    'sValor
    '
    Me.sValor.Location = New System.Drawing.Point(142, 148)
    Me.sValor.Multiline = True
    Me.sValor.Name = "sValor"
    Me.sValor.Size = New System.Drawing.Size(628, 227)
    Me.sValor.TabIndex = 3
    '
    'btEncrypt
    '
    Me.btEncrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.btEncrypt.Location = New System.Drawing.Point(142, 381)
    Me.btEncrypt.Name = "btEncrypt"
    Me.btEncrypt.Size = New System.Drawing.Size(75, 23)
    Me.btEncrypt.TabIndex = 4
    Me.btEncrypt.Text = "Encrypt"
    Me.btEncrypt.UseVisualStyleBackColor = False
    '
    'btDecrypt
    '
    Me.btDecrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.btDecrypt.Location = New System.Drawing.Point(248, 381)
    Me.btDecrypt.Name = "btDecrypt"
    Me.btDecrypt.Size = New System.Drawing.Size(75, 23)
    Me.btDecrypt.TabIndex = 5
    Me.btDecrypt.Text = "Decrypt"
    Me.btDecrypt.UseVisualStyleBackColor = False
    '
    'sResultado
    '
    Me.sResultado.BackColor = System.Drawing.SystemColors.Info
    Me.sResultado.Location = New System.Drawing.Point(137, 420)
    Me.sResultado.Multiline = True
    Me.sResultado.Name = "sResultado"
    Me.sResultado.Size = New System.Drawing.Size(628, 241)
    Me.sResultado.TabIndex = 6
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(89, 420)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 23)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Result"
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(175, 81)
    Me.PictureBox1.TabIndex = 8
    Me.PictureBox1.TabStop = False
    '
    'grpCrypt
    '
    Me.grpCrypt.Controls.Add(Me.sResultado)
    Me.grpCrypt.Controls.Add(Me.grpBits)
    Me.grpCrypt.Controls.Add(Me.Label2)
    Me.grpCrypt.Controls.Add(Me.PictureBox1)
    Me.grpCrypt.Controls.Add(Me.sChave)
    Me.grpCrypt.Controls.Add(Me.sValor)
    Me.grpCrypt.Controls.Add(Me.Label3)
    Me.grpCrypt.Controls.Add(Me.btEncrypt)
    Me.grpCrypt.Controls.Add(Me.Label1)
    Me.grpCrypt.Controls.Add(Me.btDecrypt)
    Me.grpCrypt.Location = New System.Drawing.Point(4, 0)
    Me.grpCrypt.Name = "grpCrypt"
    Me.grpCrypt.Size = New System.Drawing.Size(809, 732)
    Me.grpCrypt.TabIndex = 9
    Me.grpCrypt.TabStop = False
    '
    'grpBits
    '
    Me.grpBits.BackColor = System.Drawing.SystemColors.Control
    Me.grpBits.Controls.Add(Me.rad256)
    Me.grpBits.Controls.Add(Me.rad192)
    Me.grpBits.Controls.Add(Me.rad128)
    Me.grpBits.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.grpBits.Location = New System.Drawing.Point(14, 108)
    Me.grpBits.Name = "grpBits"
    Me.grpBits.Size = New System.Drawing.Size(64, 128)
    Me.grpBits.TabIndex = 0
    Me.grpBits.TabStop = False
    Me.grpBits.Text = "Bits"
    '
    'rad256
    '
    Me.rad256.Location = New System.Drawing.Point(8, 88)
    Me.rad256.Name = "rad256"
    Me.rad256.Size = New System.Drawing.Size(48, 24)
    Me.rad256.TabIndex = 2
    Me.rad256.Text = "256"
    '
    'rad192
    '
    Me.rad192.Location = New System.Drawing.Point(8, 57)
    Me.rad192.Name = "rad192"
    Me.rad192.Size = New System.Drawing.Size(48, 24)
    Me.rad192.TabIndex = 1
    Me.rad192.Text = "192"
    '
    'rad128
    '
    Me.rad128.Checked = True
    Me.rad128.Location = New System.Drawing.Point(8, 24)
    Me.rad128.Name = "rad128"
    Me.rad128.Size = New System.Drawing.Size(48, 24)
    Me.rad128.TabIndex = 0
    Me.rad128.TabStop = True
    Me.rad128.Text = "128"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(822, 686)
    Me.Controls.Add(Me.grpCrypt)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "Imperia Cryptor 2.0 (Rijndael)"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpCrypt.ResumeLayout(False)
    Me.grpCrypt.PerformLayout()
    Me.grpBits.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub btEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEncrypt.Click

    Try

      If rad192.Checked = True Then

        Dim IED As New Imperia.Encryption.Rijndael192Bits
        sResultado.Text = IED.Encrypt(Me.sChave.Text, Me.sValor.Text)

      ElseIf rad256.Checked = True Then

        Dim IED As New Imperia.Encryption.Rijndael256Bits
        sResultado.Text = IED.Encrypt(Me.sChave.Text, Me.sValor.Text)

      Else '128

        Dim IED As New Imperia.Encryption.Rijndael128Bits
        sResultado.Text = IED.Encrypt(Me.sChave.Text, Me.sValor.Text)

      End If

    Catch ex As Exception

      MsgBox("Não foi possível realizar a operação.", MsgBoxStyle.Information)

    End Try

  End Sub

  Private Sub btDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDecrypt.Click

    Try

      If rad192.Checked = True Then

        Dim IED As New Imperia.Encryption.Rijndael192Bits
        sResultado.Text = IED.Decrypt(Me.sChave.Text, Me.sValor.Text)

      ElseIf rad256.Checked = True Then

        Dim IED As New Imperia.Encryption.Rijndael256Bits
        sResultado.Text = IED.Decrypt(Me.sChave.Text, Me.sValor.Text)

      Else '128

        Dim IED As New Imperia.Encryption.Rijndael128Bits
        sResultado.Text = IED.Decrypt(Me.sChave.Text, Me.sValor.Text)

      End If

    Catch ex As Exception

      MsgBox("Não foi possível realizar a operação.", MsgBoxStyle.Information)

    End Try

  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub
End Class
