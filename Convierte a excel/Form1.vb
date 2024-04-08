Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Graph
Imports Microsoft.Office.Interop.InfoPath
Imports Scripting
Imports System.IO
Imports Microsoft.Office.Interop
Imports File = Scripting.File

Public Class Form1
    Private Sub btn_convierte_Click(sender As Object, e As EventArgs) Handles btn_convierte.Click

        Dim ruta_pdf As String
        Dim ruta_excel As String
        ruta_pdf = txt_pdf.Text
        ruta_excel = txt_excel.Text

        Dim fso As New FileSystemObject
        Dim folder As Folder
        Dim archivo As File

        folder = fso.GetFolder(ruta_pdf)

        Dim wa As Object
        Dim doc As Object
        Dim wr As Object

        wa = CreateObject("word.application")

        wa.Visible = False

        Dim xlApp2 As Excel.Application
        Dim nwb As Workbook
        Dim nsh As Worksheet
        xlApp2 = CreateObject("Excel.Application")

        For Each archivo In folder.Files
            doc = wa.documents.Open(archivo.Path, False, Format:="PDF Files")
            wr = doc.Paragraphs(1).Range
            wr.WholeStory

            nwb = xlApp2.Workbooks.Add
            nsh = nwb.Sheets(1)
            wr.Copy

            nsh.Paste()
            nwb.SaveAs(ruta_excel & "\" & Replace(archivo.Name, ".pdf", ".xlsx"))

            doc.Close(False)
            nwb.Close(False)
        Next

        wa.Quit

        MsgBox("Documentos convertidos con exito, puede revisarlos en: " + ruta_excel)

        lbl_abre.Visible = True
        lbl_destino.Text = ruta_excel
        lbl_destino.Visible = True

    End Sub

    Private Sub txt_pdf_Click(sender As Object, e As EventArgs) Handles txt_pdf.Click, lbl_pdf.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txt_pdf.Text = FolderBrowserDialog1.SelectedPath
            lbl_pdf.Visible = False
        End If
    End Sub

    Private Sub txt_excel_Click(sender As Object, e As EventArgs) Handles txt_excel.Click, lbl_excel.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txt_excel.Text = FolderBrowserDialog1.SelectedPath
            lbl_excel.Visible = False
        End If
    End Sub

    Private Sub lbl_destino_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_destino.LinkClicked
        Process.Start("explorer.exe", lbl_destino.Text)
    End Sub
End Class
