<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNilai1 = New System.Windows.Forms.TextBox()
        Me.CmbOperator = New System.Windows.Forms.ComboBox()
        Me.TxtNilai2 = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Opertor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIlai 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'TxtNilai1
        '
        Me.TxtNilai1.Location = New System.Drawing.Point(103, 25)
        Me.TxtNilai1.Name = "TxtNilai1"
        Me.TxtNilai1.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilai1.TabIndex = 4
        '
        'CmbOperator
        '
        Me.CmbOperator.FormattingEnabled = True
        Me.CmbOperator.Location = New System.Drawing.Point(103, 55)
        Me.CmbOperator.Name = "CmbOperator"
        Me.CmbOperator.Size = New System.Drawing.Size(121, 21)
        Me.CmbOperator.TabIndex = 5
        '
        'TxtNilai2
        '
        Me.TxtNilai2.Location = New System.Drawing.Point(103, 85)
        Me.TxtNilai2.Name = "TxtNilai2"
        Me.TxtNilai2.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilai2.TabIndex = 6
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(103, 115)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(100, 20)
        Me.TxtHasil.TabIndex = 7
        '
        'BtnProcess
        '
        Me.BtnProcess.Location = New System.Drawing.Point(86, 171)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(75, 23)
        Me.BtnProcess.TabIndex = 8
        Me.BtnProcess.Text = "Process"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 228)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtNilai2)
        Me.Controls.Add(Me.CmbOperator)
        Me.Controls.Add(Me.TxtNilai1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tyoe Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNilai1 As System.Windows.Forms.TextBox
    Friend WithEvents CmbOperator As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNilai2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasil As System.Windows.Forms.TextBox
    Friend WithEvents BtnProcess As System.Windows.Forms.Button

End Class
