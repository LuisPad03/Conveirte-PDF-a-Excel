<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_excel = New System.Windows.Forms.TextBox()
        Me.txt_pdf = New System.Windows.Forms.TextBox()
        Me.btn_convierte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_pdf = New System.Windows.Forms.Label()
        Me.lbl_excel = New System.Windows.Forms.Label()
        Me.lbl_destino = New System.Windows.Forms.LinkLabel()
        Me.lbl_abre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_excel
        '
        Me.txt_excel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_excel.Location = New System.Drawing.Point(141, 138)
        Me.txt_excel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_excel.Name = "txt_excel"
        Me.txt_excel.Size = New System.Drawing.Size(750, 26)
        Me.txt_excel.TabIndex = 0
        '
        'txt_pdf
        '
        Me.txt_pdf.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_pdf.Location = New System.Drawing.Point(141, 98)
        Me.txt_pdf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_pdf.Name = "txt_pdf"
        Me.txt_pdf.Size = New System.Drawing.Size(750, 26)
        Me.txt_pdf.TabIndex = 0
        '
        'btn_convierte
        '
        Me.btn_convierte.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_convierte.Location = New System.Drawing.Point(659, 174)
        Me.btn_convierte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_convierte.Name = "btn_convierte"
        Me.btn_convierte.Size = New System.Drawing.Size(232, 36)
        Me.btn_convierte.TabIndex = 1
        Me.btn_convierte.Text = "Convertir"
        Me.btn_convierte.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carpeta de PDF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Guardar en:"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(7, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(896, 55)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Seleciona la carpeta donde se encuentren los archivos PDF que se desean convertir" &
    " a formato Excel, la carpeta debe contener unicamente archivos en formato PDF."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_pdf
        '
        Me.lbl_pdf.AutoSize = True
        Me.lbl_pdf.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_pdf.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_pdf.Location = New System.Drawing.Point(367, 101)
        Me.lbl_pdf.Name = "lbl_pdf"
        Me.lbl_pdf.Size = New System.Drawing.Size(237, 20)
        Me.lbl_pdf.TabIndex = 4
        Me.lbl_pdf.Text = "Da Click para selecionar carpeta"
        '
        'lbl_excel
        '
        Me.lbl_excel.AutoSize = True
        Me.lbl_excel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_excel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_excel.Location = New System.Drawing.Point(367, 140)
        Me.lbl_excel.Name = "lbl_excel"
        Me.lbl_excel.Size = New System.Drawing.Size(237, 20)
        Me.lbl_excel.TabIndex = 4
        Me.lbl_excel.Text = "Da Click para selecionar carpeta"
        '
        'lbl_destino
        '
        Me.lbl_destino.AutoSize = True
        Me.lbl_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destino.Location = New System.Drawing.Point(307, 182)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(122, 20)
        Me.lbl_destino.TabIndex = 5
        Me.lbl_destino.TabStop = True
        Me.lbl_destino.Text = "Carpeta destino"
        Me.lbl_destino.Visible = False
        '
        'lbl_abre
        '
        Me.lbl_abre.AutoSize = True
        Me.lbl_abre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_abre.Location = New System.Drawing.Point(144, 182)
        Me.lbl_abre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_abre.Name = "lbl_abre"
        Me.lbl_abre.Size = New System.Drawing.Size(165, 20)
        Me.lbl_abre.TabIndex = 2
        Me.lbl_abre.Text = "Abrir cartpeta destino:"
        Me.lbl_abre.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(915, 218)
        Me.Controls.Add(Me.lbl_destino)
        Me.Controls.Add(Me.lbl_excel)
        Me.Controls.Add(Me.lbl_pdf)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_abre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_convierte)
        Me.Controls.Add(Me.txt_pdf)
        Me.Controls.Add(Me.txt_excel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prueba convierte PDF a Excel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_excel As TextBox
    Friend WithEvents txt_pdf As TextBox
    Friend WithEvents btn_convierte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_pdf As Label
    Friend WithEvents lbl_excel As Label
    Friend WithEvents lbl_destino As LinkLabel
    Friend WithEvents lbl_abre As Label
End Class
