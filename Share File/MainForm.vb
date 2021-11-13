Imports System.Net
Public Class MainForm
    Dim ftpFilePath As String = Nothing
    Dim maychu As String = "ftp://31.170.160.100"
    Dim taikhoan As String = "a2708645"
    Dim matkhau As String = "Nhan123456"



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            If fileopen.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtFilePath.Text = fileopen.FileName
                ftpFilePath = maychu & "/public_html/share/file/" & IO.Path.GetFileName(txtFilePath.Text)
                linktt.Text = "http://share.luutru360.com" & "/" & IO.Path.GetFileName(txtFilePath.Text)
                btnUpload.Enabled = True
                linktt.Enabled = True
                txtFilePath.Enabled = True
                btnUpload.Enabled = True
                TextBox1.Enabled = True
            End If
        Catch

        End Try

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ftpFilePath = maychu & "/public_html/share/" & IO.Path.GetFileName(txtFilePath.Text)
        linktt.Text = "http://share.luutru360.com" & "/" & IO.Path.GetFileName(txtFilePath.Text)
        btnUpload.Enabled = False
        bWorker.RunWorkerAsync()
    End Sub

    Private Sub bWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bWorker.DoWork
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(New Uri(ftpFilePath)), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.UploadFile
        request.Credentials = New NetworkCredential(taikhoan, matkhau)
        request.UseBinary = True
        request.UsePassive = False
        Dim fileStream() As Byte = System.IO.File.ReadAllBytes(txtFilePath.Text)
        Dim requestStream As System.IO.Stream = request.GetRequestStream()
        For offset As Integer = 0 To fileStream.Length Step 1024
            bWorker.ReportProgress(CType(offset * pBar.Maximum / fileStream.Length, Integer))
            Dim chSize As Integer = fileStream.Length - offset
            If chSize > 1024 Then chSize = 1024
            requestStream.Write(fileStream, offset, chSize)
        Next
        If lblPercent.Text = "100 %" Then
            linktt.Enabled = True
            txtFilePath.Enabled = True
            btnUpload.Enabled = True
            TextBox1.Enabled = True
        End If
        requestStream.Close()
        requestStream.Dispose()
    End Sub

    Private Sub bWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bWorker.ProgressChanged
        pBar.Value = e.ProgressPercentage
        lblPercent.Text = e.ProgressPercentage & " %"
    End Sub

    Private Sub bWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bWorker.RunWorkerCompleted
        MsgBox("Tập tin đã được chia sẻ lên máy chủ !")
        pBar.Value = 0
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class