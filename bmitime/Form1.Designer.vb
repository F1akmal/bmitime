<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblBerat = New Label()
        Label2 = New Label()
        nudBerat = New NumericUpDown()
        nudTinggi = New NumericUpDown()
        lblArahan = New Label()
        BtnSubmit = New Button()
        CType(nudBerat, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTinggi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(281, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 47)
        Label1.TabIndex = 0
        Label1.Text = "BMI Kamu"
        ' 
        ' lblBerat
        ' 
        lblBerat.AutoSize = True
        lblBerat.Location = New Point(43, 112)
        lblBerat.Name = "lblBerat"
        lblBerat.Size = New Size(55, 15)
        lblBerat.TabIndex = 1
        lblBerat.Text = "Berat(kg)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 2
        Label2.Text = "Tinggi(meter)"
        ' 
        ' nudBerat
        ' 
        nudBerat.DecimalPlaces = 2
        nudBerat.Location = New Point(198, 114)
        nudBerat.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        nudBerat.Name = "nudBerat"
        nudBerat.Size = New Size(81, 23)
        nudBerat.TabIndex = 3
        ' 
        ' nudTinggi
        ' 
        nudTinggi.DecimalPlaces = 2
        nudTinggi.Location = New Point(198, 184)
        nudTinggi.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        nudTinggi.Name = "nudTinggi"
        nudTinggi.Size = New Size(81, 23)
        nudTinggi.TabIndex = 4
        ' 
        ' lblArahan
        ' 
        lblArahan.AutoSize = True
        lblArahan.Location = New Point(362, 157)
        lblArahan.Name = "lblArahan"
        lblArahan.Size = New Size(198, 15)
        lblArahan.TabIndex = 5
        lblArahan.Text = "Sila masukkan berat dan tinggi anda"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(362, 112)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(75, 23)
        BtnSubmit.TabIndex = 6
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnSubmit)
        Controls.Add(lblArahan)
        Controls.Add(nudTinggi)
        Controls.Add(nudBerat)
        Controls.Add(Label2)
        Controls.Add(lblBerat)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(nudBerat, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTinggi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBerat As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudBerat As NumericUpDown
    Friend WithEvents nudTinggi As NumericUpDown
    Friend WithEvents lblArahan As Label
    Friend WithEvents BtnSubmit As Button

End Class
