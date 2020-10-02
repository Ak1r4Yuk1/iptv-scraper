Imports System.IO
Imports System.Net
Imports System.Web

Public Class Form1
    Dim desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myDt As DateTime = DateTime.Now

        myDt.ToString("ddMMyy")

        Dim filename = "https://www.iptvsource.com/lists/it_" & myDt.ToString("ddMMyy") & "_iptvsource_com3.m3u"
        Dim filename1 = "https://www.iptvsource.com/lists/it_" & myDt.ToString("ddMMyy") & "_iptvsource_com4.m3u"
        Dim filename2 = "https://www.iptvsource.com/lists/it_" & myDt.ToString("ddMMyy") & "_iptvsource_com5.m3u"

        MsgBox("Check Your iptv Folder in Desktop for File italy.m3u")
        Try

            My.Computer.Network.DownloadFile(filename, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-italy.m3u")
            My.Computer.Network.DownloadFile(filename1, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-italy2.m3u")
            My.Computer.Network.DownloadFile(filename2, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-italy3.m3u")

        Catch
            MsgBox("If some lists are missing try again next time..")
        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myDt As DateTime = DateTime.Now

        myDt.ToString("ddMMyy")
        Dim filename = "https://www.iptvsource.com/lists/uk_" & myDt.ToString("ddMMyy") & "_iptvsource_com3.m3u"
        Dim filename1 = "https://www.iptvsource.com/lists/uk_" & myDt.ToString("ddMMyy") & "_iptvsource_com4.m3u"
        Dim filename2 = "https://www.iptvsource.com/lists/uk_" & myDt.ToString("ddMMyy") & "_iptvsource_com5.m3u"

        MsgBox("Check Your iptv Folder in Desktop for File uk.m3u")

        Try
            My.Computer.Network.DownloadFile(filename, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-uk.m3u")
            My.Computer.Network.DownloadFile(filename1, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-uk2.m3u")
            My.Computer.Network.DownloadFile(filename2, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-uk3.m3u")

        Catch
            MsgBox("If some lists are missing try again next time..")

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myDt As DateTime = DateTime.Now

        myDt.ToString("ddMMyy")
        Dim filename = "https://www.iptvsource.com/lists/de_" & myDt.ToString("ddMMyy") & "_iptvsource_com3.m3u"
        Dim filename1 = "https://www.iptvsource.com/lists/de_" & myDt.ToString("ddMMyy") & "_iptvsource_com4.m3u"
        Dim filename2 = "https://www.iptvsource.com/lists/de_" & myDt.ToString("ddMMyy") & "_iptvsource_com5.m3u"

        MsgBox("Check Your iptv Folder in Desktop for File germany.m3u")
        Try
            My.Computer.Network.DownloadFile(filename, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-germany.m3u")
            My.Computer.Network.DownloadFile(filename1, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-germany2.m3u")
            My.Computer.Network.DownloadFile(filename2, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-germany3.m3u")
        Catch
            MsgBox("If some lists are missing try again next time..")
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myDt As DateTime = DateTime.Now

        myDt.ToString("ddMMyy")
        Dim filename = "https://www.iptvsource.com/lists/es_" & myDt.ToString("ddMMyy") & "_iptvsource_com3.m3u"
        Dim filename1 = "https://www.iptvsource.com/lists/es_" & myDt.ToString("ddMMyy") & "_iptvsource_com4.m3u"
        Dim filename2 = "https://www.iptvsource.com/lists/es_" & myDt.ToString("ddMMyy") & "_iptvsource_com5.m3u"

        MsgBox("Check Your iptv Folder in Desktop for File spain.m3u")
        Try
            My.Computer.Network.DownloadFile(filename, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-spain.m3u")
            My.Computer.Network.DownloadFile(filename1, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-spain2.m3u")
            My.Computer.Network.DownloadFile(filename2, desktop + "\iptv\" & myDt.ToString("dd-MM-yy") & "-spain3.m3u")
        Catch
            MsgBox("If some lists are missing try again next time..")
        End Try


    End Sub
End Class
