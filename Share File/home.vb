Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Net

Public Class home
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Dim ftpFilePath As String = Nothing
    Dim maychu As String = "ftp://31.170.160.100"
    Dim taikhoan As String = "a2708645"
    Dim matkhau As String = ""
    Enum ProgressBarColor
        Green = &H1
        Red = &H2
        Yellow = &H3

    End Enum
    Private Shared Sub ChangeProgBarColor(ByVal ProgressBar_Name As Windows.Forms.ProgressBar, ByVal ProgressBar_Color As ProgressBarColor)
        SendMessage(ProgressBar_Name.Handle, &H410, ProgressBar_Color, 0)
    End Sub


    Private Sub home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Application.DoEvents()

        Me.AllowDrop = True
        ChangeProgBarColor(pBar, ProgressBarColor.Yellow)
        Control.CheckForIllegalCrossThreadCalls = False
        Try


            ' khoi dong cung win
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        Catch

        End Try
    End Sub

    Private Sub home_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop

        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            MainForm.txtFilePath.Text = path
            Label5.Text = path
            If InStr(MainForm.txtFilePath.Text, ".zip") > 0 Then
                ' MsgBox("Tồn tại")
                Timer1.Enabled = True
                ' IsURLValid("http://share.luutru360.com/file/" + MainForm.txtFilePath.Text + ".zip")


            ElseIf InStr(MainForm.txtFilePath.Text, ".rar") > 0 Then
                Timer1.Enabled = True
            Else
                Me.Size = New Size(560, 139)
                Label4.Text = "Kéo thả tập tin vào đây !"
                Timer1.Enabled = False
                MsgBox("Định dạng tập tin này không được hỗ trợ !")
            End If
        Next
    End Sub

    Private Sub home_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Dim IsMouseDown = False
    Dim startPoint
    Private Sub TitleBar_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleBar.MouseUp
        Try
            IsMouseDown = False
        Catch
        End Try
    End Sub
    Private Sub TitleBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleBar.MouseDown
        Try
            startPoint = e.Location
            IsMouseDown = True
        Catch
        End Try
    End Sub
    Private Sub TitleBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitleBar.MouseMove
        Try
            If IsMouseDown Then
                Dim p1 = New Point(e.X, e.Y)
                Dim p2 = PointToScreen(p1)
                Dim p3 = New Point(p2.X - startPoint.X, p2.Y - startPoint.Y)
                Location = p3
            End If
        Catch
        End Try
    End Sub

 
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Size = New Size(560, 139) Then
            Me.Size = New Size(560, 140)
        ElseIf Me.Size = New Size(560, 140) Then
            Me.Size = New Size(560, 141)
        ElseIf Me.Size = New Size(560, 141) Then
            Me.Size = New Size(560, 142)
        ElseIf Me.Size = New Size(560, 142) Then
            Me.Size = New Size(560, 143)
        ElseIf Me.Size = New Size(560, 143) Then
            Me.Size = New Size(560, 144)
        ElseIf Me.Size = New Size(560, 144) Then
            Me.Size = New Size(560, 145)
        ElseIf Me.Size = New Size(560, 145) Then
            Me.Size = New Size(560, 146)
        ElseIf Me.Size = New Size(560, 146) Then
            Me.Size = New Size(560, 147)
        ElseIf Me.Size = New Size(560, 147) Then
            Me.Size = New Size(560, 148)
        ElseIf Me.Size = New Size(560, 148) Then
            Me.Size = New Size(560, 149)
        ElseIf Me.Size = New Size(560, 149) Then
            Me.Size = New Size(560, 150)
        ElseIf Me.Size = New Size(560, 150) Then
            Me.Size = New Size(560, 151)
        ElseIf Me.Size = New Size(560, 151) Then
            Me.Size = New Size(560, 152)
        ElseIf Me.Size = New Size(560, 152) Then
            Me.Size = New Size(560, 153)
        ElseIf Me.Size = New Size(560, 153) Then
            Me.Size = New Size(560, 154)
        ElseIf Me.Size = New Size(560, 154) Then
            Me.Size = New Size(560, 155)
        ElseIf Me.Size = New Size(560, 155) Then
            Me.Size = New Size(560, 156)
        ElseIf Me.Size = New Size(560, 156) Then
            Me.Size = New Size(560, 157)
        ElseIf Me.Size = New Size(560, 157) Then
            Me.Size = New Size(560, 158)
        ElseIf Me.Size = New Size(560, 158) Then
            Me.Size = New Size(560, 159)
        ElseIf Me.Size = New Size(560, 159) Then
            Me.Size = New Size(560, 160)
        ElseIf Me.Size = New Size(560, 160) Then
            Me.Size = New Size(560, 161)
        ElseIf Me.Size = New Size(560, 161) Then
            Me.Size = New Size(560, 162)
        ElseIf Me.Size = New Size(560, 162) Then
            Me.Size = New Size(560, 163)
        ElseIf Me.Size = New Size(560, 163) Then
            Me.Size = New Size(560, 164)
        ElseIf Me.Size = New Size(560, 164) Then
            Me.Size = New Size(560, 165)
        ElseIf Me.Size = New Size(560, 165) Then
            Me.Size = New Size(560, 166)
        ElseIf Me.Size = New Size(560, 166) Then
            Me.Size = New Size(560, 167)
        ElseIf Me.Size = New Size(560, 167) Then
            Me.Size = New Size(560, 168)
        ElseIf Me.Size = New Size(560, 168) Then
            Me.Size = New Size(560, 169)
        ElseIf Me.Size = New Size(560, 169) Then
            Me.Size = New Size(560, 170)
        ElseIf Me.Size = New Size(560, 170) Then
            Me.Size = New Size(560, 171)
        ElseIf Me.Size = New Size(560, 171) Then
            Me.Size = New Size(560, 172)
        ElseIf Me.Size = New Size(560, 172) Then
            Me.Size = New Size(560, 173)
        ElseIf Me.Size = New Size(560, 173) Then
            Me.Size = New Size(560, 174)
        ElseIf Me.Size = New Size(560, 174) Then
            Me.Size = New Size(560, 175)
        ElseIf Me.Size = New Size(560, 175) Then
            Me.Size = New Size(560, 176)
        ElseIf Me.Size = New Size(560, 176) Then
            Me.Size = New Size(560, 177)
        ElseIf Me.Size = New Size(560, 177) Then
            Me.Size = New Size(560, 178)
        ElseIf Me.Size = New Size(560, 178) Then
            Me.Size = New Size(560, 179)
        ElseIf Me.Size = New Size(560, 179) Then
            Me.Size = New Size(560, 180)
        ElseIf Me.Size = New Size(560, 180) Then
            Me.Size = New Size(560, 181)
        ElseIf Me.Size = New Size(560, 181) Then
            Me.Size = New Size(560, 182)
        ElseIf Me.Size = New Size(560, 182) Then
            Me.Size = New Size(560, 183)
        ElseIf Me.Size = New Size(560, 183) Then
            Me.Size = New Size(560, 184)
        ElseIf Me.Size = New Size(560, 184) Then
            Me.Size = New Size(560, 185)
        ElseIf Me.Size = New Size(560, 185) Then
            Me.Size = New Size(560, 186)
        ElseIf Me.Size = New Size(560, 186) Then
            Me.Size = New Size(560, 187)
        ElseIf Me.Size = New Size(560, 187) Then
            Me.Size = New Size(560, 188)
        ElseIf Me.Size = New Size(560, 188) Then
            Me.Size = New Size(560, 189)
        ElseIf Me.Size = New Size(560, 189) Then
            Me.Size = New Size(560, 190)
        ElseIf Me.Size = New Size(560, 190) Then
            Me.Size = New Size(560, 191)
        ElseIf Me.Size = New Size(560, 191) Then
            Me.Size = New Size(560, 192)
        ElseIf Me.Size = New Size(560, 192) Then
            Me.Size = New Size(560, 193)
        ElseIf Me.Size = New Size(560, 193) Then
            Me.Size = New Size(560, 194)
        ElseIf Me.Size = New Size(560, 194) Then
            Me.Size = New Size(560, 195)
        ElseIf Me.Size = New Size(560, 195) Then
            Me.Size = New Size(560, 196)
        ElseIf Me.Size = New Size(560, 196) Then

            ' Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://share.luutru360.com/gettk.php")
            'Dim response As System.Net.HttpWebResponse = request.GetResponse()

            'Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

            'Dim sourcecode As String = sr.ReadToEnd()
            'MainForm.TextBox1.Text = sourcecode
            'MainForm.TextBox1.Text = Replace(MainForm.TextBox1.Text, " ", "")

            Label4.Text = "Đang tải lên ..."
            ftpFilePath = maychu & "/public_html/share/file/" & IO.Path.GetFileName(MainForm.txtFilePath.Text)
            MainForm.linktt.Text = "http://share.luutru360.com/taive.php?file" & "=" & IO.Path.GetFileName(MainForm.txtFilePath.Text)
            link2.lk.Text = "http://share.luutru360.com/taive.php?file" & "=" & IO.Path.GetFileName(MainForm.txtFilePath.Text)
            bWorker.RunWorkerAsync()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            Me.WindowState = FormWindowState.Minimized
            If Me.WindowState = FormWindowState.Minimized Then
                If Me IsNot Nothing Then
                    If Me.Tag Is "StorePage" Then
                        Me.WindowState = FormWindowState.Minimized
                    End If
                End If
            End If
        Catch
        End Try
        Try
            If Me.WindowState = FormWindowState.Maximized Then
                If Me IsNot Nothing Then
                    If Me.Tag Is "StorePage" Then
                        Me.WindowState = FormWindowState.Maximized
                    End If
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub bWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bWorker.DoWork
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create(New Uri(ftpFilePath)), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.UploadFile
        request.Credentials = New NetworkCredential(taikhoan, matkhau)
        request.UseBinary = True
        request.UsePassive = False
        Dim fileStream() As Byte = System.IO.File.ReadAllBytes(Label5.Text)
        Dim requestStream As System.IO.Stream = request.GetRequestStream()
        For offset As Integer = 0 To fileStream.Length Step 1024
            bWorker.ReportProgress(CType(offset * pBar.Maximum / fileStream.Length, Integer))
            Dim chSize As Integer = fileStream.Length - offset
            If chSize > 1024 Then chSize = 1024
            requestStream.Write(fileStream, offset, chSize)
        Next
        If Label4.Text = "Đang tải lên ...100 %" Then
        End If
        requestStream.Close()
        requestStream.Dispose()
    End Sub

    Private Sub bWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bWorker.ProgressChanged
        pBar.Value = e.ProgressPercentage
        Label4.Text = "Đang tải lên ..." & e.ProgressPercentage & " %"
    End Sub

    Private Sub bWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bWorker.RunWorkerCompleted
        MsgBox("Tập tin đã được chia sẻ lên máy chủ !", vbInformation, "Share Files")
        Label4.Text = "Kéo thả tập tin vào đây !"
        link2.Show()
        pBar.Value = 0
        Me.Size = New Size(560, 139)
    End Sub

  
    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        Dim webAddress As String = "http://share.luutru360.com"
        Process.Start(webAddress)
    End Sub

    Private Sub ChiaSẻFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiaSẻFilesToolStripMenuItem.Click
        Try
            If fileopen.ShowDialog = Windows.Forms.DialogResult.OK Then
                Label5.Text = fileopen.FileName
                MainForm.txtFilePath.Text = fileopen.FileName
                ftpFilePath = maychu & "/public_html/share/file/" & "(" & MainForm.TextBox1.Text & ")" & IO.Path.GetFileName(MainForm.txtFilePath.Text)
                MainForm.linktt.Text = "http://share.luutru360.com/taive.php?file" & "=" & IO.Path.GetFileName(MainForm.txtFilePath.Text)
                Me.Show()
                Timer1.Enabled = True
            End If
        Catch

        End Try
    End Sub

    Private Sub tmenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tmenu.Opening
     

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        End
    End Sub

    Private Sub ion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ion.MouseDoubleClick
        Me.Show()
    End Sub


End Class
