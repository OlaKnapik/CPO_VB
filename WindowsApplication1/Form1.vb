Public Class Form1
    Public obraz As Bitmap

    Private Sub OtwórzToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtwórzToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            obraz = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image = obraz
            oblicz_hist()
            Me.Refresh()
        End If
    End Sub

    Private Sub ZapiszToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZapiszToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName + ".tiff")
        End If
    End Sub

    Private Sub NegacjaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NegacjaToolStripMenuItem.Click

        Dim pomocniczyObraz As Bitmap = obraz.Clone
        Dim r, g, b As Integer
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = obraz.Height

        For y As Integer = 0 To pomocniczyObraz.Height - 1
            For x As Integer = 0 To pomocniczyObraz.Width - 1
                r = pomocniczyObraz.GetPixel(x, y).R
                g = pomocniczyObraz.GetPixel(x, y).G
                b = pomocniczyObraz.GetPixel(x, y).B
                r = 255 - r
                g = 255 - g
                b = 255 - b
                pomocniczyObraz.SetPixel(x, y, Color.FromArgb(r, g, b))

            Next
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next
        PictureBox1.Image = pomocniczyObraz
        PictureBox1.Refresh()
        oblicz_hist()
        Me.Refresh()

    End Sub

    Private Sub OdcienieSzarościToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdcienieSzarościToolStripMenuItem.Click

        Dim pomocniczyObraz2 As Bitmap = obraz.Clone
        Dim r, g, b, srednia As Integer
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = obraz.Height
        For y As Integer = 0 To pomocniczyObraz2.Height - 1
            For x As Integer = 0 To pomocniczyObraz2.Width - 1
                r = pomocniczyObraz2.GetPixel(x, y).R
                g = pomocniczyObraz2.GetPixel(x, y).G
                b = pomocniczyObraz2.GetPixel(x, y).B
                srednia = (r + g + b) / 3
                r = srednia
                g = srednia
                b = srednia
                pomocniczyObraz2.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next
        PictureBox1.Image = pomocniczyObraz2
        PictureBox1.Refresh()

        oblicz_hist()
        Me.Refresh()

    End Sub

    Private Sub OdbicieWPionieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdbicieWPionieToolStripMenuItem.Click

        Dim pomocniczyObraz3 As Bitmap = obraz.Clone

        pomocniczyObraz3.RotateFlip(RotateFlipType.Rotate180FlipX)
        PictureBox1.Image = pomocniczyObraz3
        PictureBox1.Refresh()

        oblicz_hist()
        Me.Refresh()

    End Sub

    Private Sub OdbicieWPoziomieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdbicieWPoziomieToolStripMenuItem.Click

        Dim pomocniczyObraz3 As Bitmap = obraz.Clone

        pomocniczyObraz3.RotateFlip(RotateFlipType.Rotate180FlipY)
        PictureBox1.Image = pomocniczyObraz3
        PictureBox1.Refresh()

        oblicz_hist()
        Me.Refresh()

    End Sub

    Private Sub ZmianaJasnosciToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ZmianaJasnosciToolStripMenuItem.Click
        Dim suwak = New Dialog1
        suwak.Show()

    End Sub

    Private Sub ZmianaKontrastuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZmianaKontrastuToolStripMenuItem.Click
        Dim suwak2 = New Dialog2
        suwak2.show()
    End Sub

    Private Sub WyrównanieHostogramuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WyrównanieHostogramuToolStripMenuItem.Click

        Dim obrazek As Bitmap = obraz.Clone
        Dim wartosc As Color
        Dim R, G, B As Integer
        Dim histR(255) As Integer
        Dim histG(255) As Integer
        Dim histB(255) As Integer
        Dim N As Integer

        Dim dystrR(255) As Integer
        Dim dystrG(255) As Integer
        Dim dystrB(255) As Integer

        Dim skalR(255) As Integer
        Dim skalG(255) As Integer
        Dim skalB(255) As Integer

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = obrazek.Height * 1.5

        N = obrazek.Width * obrazek.Height

        For x As Integer = 0 To obrazek.Width - 1
            For y As Integer = 0 To obrazek.Height - 1
                wartosc = obrazek.GetPixel(x, y)
                R = wartosc.R
                G = wartosc.G
                B = wartosc.B
                histR(R) = histR(R) + 1
                histG(G) = histG(G) + 1
                histB(B) = histB(B) + 1
            Next
        Next


        dystrR(0) = histR(0)
        dystrG(0) = histG(0)
        dystrB(0) = histB(0)

        For i As Integer = 0 To 254
            dystrR(i + 1) = histR(i) + dystrR(i)
            If dystrR(i + 1) > N Then
                dystrR(i + 1) = N
            End If
            dystrG(i + 1) = histG(i) + dystrG(i)
            If dystrG(i + 1) > N Then
                dystrG(i + 1) = N
            End If
            dystrB(i + 1) = histB(i) + dystrB(i)
            If dystrB(i + 1) > N Then
                dystrB(i + 1) = N
            End If
        Next


        For i As Integer = 0 To 255
            skalR(i) = dystrR(i) * 255 / (obrazek.Width * obrazek.Height)
            skalG(i) = dystrG(i) * 255 / (obrazek.Width * obrazek.Height)
            skalB(i) = dystrB(i) * 255 / (obrazek.Width * obrazek.Height)
        Next
        For x As Integer = 0 To obrazek.Width - 1
            For y As Integer = 0 To obrazek.Height - 1
                wartosc = obrazek.GetPixel(x, y)
                R = wartosc.R
                G = wartosc.G
                B = wartosc.B
                R = skalR(R)
                G = skalG(G)
                B = skalB(B)
                wartosc = Color.FromArgb(R, G, B)
                obrazek.SetPixel(x, y, wartosc)
            Next
            ProgressBar1.Value = ProgressBar1.Value + 1

        Next
        PictureBox1.Image = obrazek
        PictureBox1.Refresh()

        oblicz_hist()
        Me.Refresh()

    End Sub

    Private Sub FiltrUsredniajacyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltrUsredniajacyToolStripMenuItem.Click

        Dim obrazek As Bitmap = obraz.Clone
        Dim obrazek2 As Bitmap = obraz.Clone
        Dim wartosc As Color
        Dim tablicaR(obrazek.Width, obrazek.Height) As Long
        Dim tablicaG(obrazek.Width, obrazek.Height) As Long
        Dim tablicaB(obrazek.Width - 1, obrazek.Height - 1) As Long
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = obrazek.Height * 1.5

        For x As Integer = 0 To obrazek.Width - 1
            For y As Integer = 0 To obrazek.Height - 1

                If x > 0 And y > 0 And x < obrazek.Width - 2 And y < obrazek.Height - 2 Then

                    tablicaR(x, y) = (CLng(obrazek.GetPixel(x - 1, y + 1).R) + CLng(obrazek.GetPixel(x, y + 1).R) + CLng(obrazek.GetPixel(x + 1, y + 1).R) + CLng(obrazek.GetPixel(x - 1, y).R) + CLng(obrazek.GetPixel(x, y).R) + CLng(obrazek.GetPixel(x + 1, y).R) + CLng(obrazek.GetPixel(x - 1, y - 1).R) + CLng(obrazek.GetPixel(x, y - 1).R) + CLng(obrazek.GetPixel(x + 1, y - 1).R)) / 9
                    tablicaG(x, y) = (CLng(obrazek.GetPixel(x - 1, y + 1).G) + CLng(obrazek.GetPixel(x, y + 1).G) + CLng(obrazek.GetPixel(x + 1, y + 1).G) + CLng(obrazek.GetPixel(x - 1, y).G) + CLng(obrazek.GetPixel(x, y).G) + CLng(obrazek.GetPixel(x + 1, y).G) + CLng(obrazek.GetPixel(x - 1, y - 1).G) + CLng(obrazek.GetPixel(x, y - 1).G) + CLng(obrazek.GetPixel(x + 1, y - 1).G)) / 9
                    tablicaB(x, y) = (CLng(obrazek.GetPixel(x - 1, y + 1).B) + CLng(obrazek.GetPixel(x, y + 1).B) + CLng(obrazek.GetPixel(x + 1, y + 1).B) + CLng(obrazek.GetPixel(x - 1, y).B) + CLng(obrazek.GetPixel(x, y).B) + CLng(obrazek.GetPixel(x + 1, y).B) + CLng(obrazek.GetPixel(x - 1, y - 1).B) + CLng(obrazek.GetPixel(x, y - 1).B) + CLng(obrazek.GetPixel(x + 1, y - 1).B)) / 9

                Else
                    tablicaR(x, y) = 0
                    tablicaG(x, y) = 0
                    tablicaB(x, y) = 0
                End If

                wartosc = Color.FromArgb(tablicaR(x, y), tablicaG(x, y), tablicaB(x, y))
                obrazek2.SetPixel(x, y, wartosc)

            Next
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next
        PictureBox1.Image = obrazek2
        PictureBox1.Refresh()
        oblicz_hist()
        Me.Refresh()

    End Sub

    Dim histR(255), histB(255), histG(255) As Integer

    Sub oblicz_hist()

        Dim obraz As Bitmap = PictureBox1.Image
        Dim obraz1 As Bitmap = New Bitmap(obraz.Width, obraz.Height)
        Dim R, G, B As Integer

        For i As Integer = 0 To 255
            histR(i) = 0
            histG(i) = 0
            histB(i) = 0
        Next

        For x As Integer = 0 To PictureBox1.Image.Width - 1
            For y As Integer = 0 To PictureBox1.Image.Height - 1
                R = obraz.GetPixel(x, y).R
                G = obraz.GetPixel(x, y).G
                B = obraz.GetPixel(x, y).B
                histR(R) = histR(R) + 1
                histG(G) = histG(G) + 1
                histB(B) = histB(B) + 1
            Next
        Next

    End Sub

    Private Sub AutomatycznyKontrastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomatycznyKontrastToolStripMenuItem.Click

        Dim p1R, p1G, p1B, p2R, p2G, p2B As Integer
        Dim R, G, B, p As Integer
        Dim obraz As Bitmap = PictureBox1.Image
        Dim obraz1 As Bitmap = New Bitmap(obraz.Width, obraz.Height)

        oblicz_hist()

        p = 0
        For i As Integer = 0 To 255
            If histR(i) > p Then
                p1R = i
                Exit For
            End If
        Next
        For i As Integer = 0 To 255
            If histR(i) > p Then
                p2R = i
            End If
        Next

        For i As Integer = 0 To 255
            If histG(i) > p Then
                p1G = i
                Exit For
            End If
        Next


        For i As Integer = 0 To 255
            If histG(i) > p Then
                p2G = i
            End If
        Next

        For i As Integer = 0 To 255
            If histB(i) > p Then
                p1B = i
            End If
            Exit For
        Next

        For i As Integer = 0 To 255
            If histB(i) > p Then
                p2B = i
            End If

        Next

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = obraz.Width
        For x As Integer = 0 To PictureBox1.Image.Width - 1
            For y As Integer = 0 To PictureBox1.Image.Height - 1
                R = obraz.GetPixel(x, y).R
                G = obraz.GetPixel(x, y).G
                B = obraz.GetPixel(x, y).B

                R = ((R - p1R) * 255) / (p2R - p1R)
                G = ((G - p1G) * 255) / (p2G - p1G)
                B = ((B - p1B) * 255) / (p2B - p1B)
                If R < 0 Then R = 0
                If G < 0 Then G = 0
                If B < 0 Then B = 0

                If R > 255 Then R = 255
                If G > 255 Then G = 255
                If B > 255 Then B = 255

                obraz1.SetPixel(x, y, Color.FromArgb(R, G, B))
            Next
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next
        PictureBox1.Image = obraz1
        PictureBox1.Refresh()

        oblicz_hist()
        Me.Refresh()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If histR.Max <> 0 Then
            For x = 0 To 255
                Dim y1, y2 As Integer
                y1 = Panel1.Height - 1
                y2 = Panel1.Height - 1 - (histR(x) * Panel1.Height / histR.Max)
                e.Graphics.DrawLine(Pens.Red, x, y1, x, y2)
            Next
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        If histR.Max <> 0 Then
            For x = 0 To 255
                Dim y1, y2 As Integer
                y1 = Panel1.Height - 1
                y2 = Panel1.Height - 1 - (histG(x) * Panel1.Height / histG.Max)
                e.Graphics.DrawLine(Pens.Green, x, y1, x, y2)
            Next
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        If histR.Max <> 0 Then
            For x = 0 To 255
                Dim y1, y2 As Integer
                y1 = Panel1.Height - 1
                y2 = Panel1.Height - 1 - (histB(x) * Panel1.Height / histB.Max)
                e.Graphics.DrawLine(Pens.Blue, x, y1, x, y2)
            Next
        End If
    End Sub
End Class
