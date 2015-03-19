﻿Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim jas = TrackBar1.Value

        Dim pomocniczyObraz As Bitmap = Form1.obraz.Clone
        Dim r, g, b, j As Integer
        Form1.ProgressBar1.Value = 0
        Form1.ProgressBar1.Maximum = Form1.obraz.Height

        Dim lut(255) As Integer
        j = TrackBar1.Value

        For i As Integer = 0 To 255
            lut(i) = i + j

            If lut(i) > 225 Then
                lut(i) = 225
            End If
            If lut(i) < 0 Then
                lut(i) = 0
            End If
        Next

        For y As Integer = 0 To pomocniczyObraz.Height - 1
            For x As Integer = 0 To pomocniczyObraz.Width - 1
                r = pomocniczyObraz.GetPixel(x, y).R
                g = pomocniczyObraz.GetPixel(x, y).G
                b = pomocniczyObraz.GetPixel(x, y).B

                pomocniczyObraz.SetPixel(x, y, Color.FromArgb(lut(r), lut(g), lut(b)))
            Next
            Form1.ProgressBar1.Value = Form1.ProgressBar1.Value + 1
        Next
        Form1.PictureBox1.Image = pomocniczyObraz
        Form1.PictureBox1.Refresh()
        Me.Close()

        oblicz_hist()
        Form1.Refresh()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub oblicz_hist()
        'obliczenie histogramu
        Dim histR(255), histB(255), histG(255) As Integer

        Dim obraz As Bitmap = Form1.PictureBox1.Image
        Dim obraz1 As Bitmap = New Bitmap(obraz.Width, obraz.Height)
        Dim R, G, B As Integer

        For i As Integer = 0 To 255
            histR(i) = 0
            histG(i) = 0
            histB(i) = 0
        Next

        For x As Integer = 0 To Form1.PictureBox1.Image.Width - 1
            For y As Integer = 0 To Form1.PictureBox1.Image.Height - 1
                R = obraz.GetPixel(x, y).R
                G = obraz.GetPixel(x, y).G
                B = obraz.GetPixel(x, y).B
                histR(R) = histR(R) + 1
                histG(G) = histG(G) + 1
                histB(B) = histB(B) + 1
            Next
        Next

    End Sub

End Class
