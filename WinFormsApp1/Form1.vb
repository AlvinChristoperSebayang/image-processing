
Imports System.Drawing.Drawing2D
Public Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub BukaFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaFileToolStripMenuItem.Click
        Dim BukaFile As New OpenFileDialog

        Try
            BukaFile.Title = "Buka File Gambar"
            BukaFile.DefaultExt = "bmp"
            BukaFile.Filter = "File Citra|*.bmp;*.jpg;*.png"

            If BukaFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = New Bitmap(BukaFile.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Try
            Dispose()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest As New Bitmap(picSource.Width, picSource.Height)

        For i = 0 To picSource.Width - 1
            For j = 0 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                If i < picSource.Width / 6 Then
                    picDest.SetPixel(i, j, Color.FromArgb(r, 0, 0)) ' Merah
                ElseIf i < 2 * picSource.Width / 6 Then
                    picDest.SetPixel(i, j, Color.FromArgb(0, g, 0)) ' Hijau
                ElseIf i < 3 * picSource.Width / 6 Then
                    picDest.SetPixel(i, j, Color.FromArgb(0, 0, b)) ' Biru
                ElseIf i < 4 * picSource.Width / 6 Then
                    picDest.SetPixel(i, j, Color.FromArgb(r, g, 0)) ' Kuning
                ElseIf i < 5 * picSource.Width / 6 Then
                    picDest.SetPixel(i, j, Color.FromArgb(r, 0, b)) ' Ungu
                Else
                    picDest.SetPixel(i, j, Color.FromArgb(r, 0, b)) ' Ungu
                End If
            Next
        Next

        PictureBox2.Image = picDest
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest = picSource
        PictureBox2.Image = picDest

        For i = 1 To picSource.Width - 1
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                picDest.SetPixel(i, j, Color.FromArgb(0, g, 0))

            Next
        Next
    End Sub

    Private Sub NegativeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegativeToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest = picSource
        PictureBox2.Image = picDest

        For i = 1 To picSource.Width - 1
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                r = 255 - r
                g = 255 - g
                b = 255 - b
                picDest.SetPixel(i, j, Color.FromArgb(r, g, b))
            Next
        Next
    End Sub

    Private Sub ThresoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegativeToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest = picSource
        PictureBox2.Image = picDest

        Dim thresh As Integer
        thresh = 100

        Dim gray As Integer
        For i = 1 To picSource.Width - 1
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                gray = CInt((r + g + b) / 3)

                If gray >= thresh Then
                    r = 255
                    g = 255
                    b = 255
                Else
                    r = 0
                    g = 0
                    b = 0
                End If
                picDest.SetPixel(i, j, Color.FromArgb(r, g, b))

            Next
        Next
    End Sub


    Private Sub PenajamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenajamanToolStripMenuItem.Click

    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest = picSource
        PictureBox2.Image = picDest

        Dim gray As Integer
        For i = 1 To picSource.Width - 1
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                gray = CInt((r + g + b) / 3)

                picDest.SetPixel(i, j, Color.FromArgb(gray, gray, gray))

            Next
        Next

    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest = picSource
        PictureBox2.Image = picDest

        For i = 1 To picSource.Width - 1
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                picDest.SetPixel(i, j, Color.FromArgb(r, 0, 0))

            Next
        Next
    End Sub
End Class

