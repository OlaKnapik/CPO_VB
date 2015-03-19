Imports System.Windows.Forms

Public Class Dialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim kontr = TrackBar1.Value

        Dim pomocniczyObraz As Bitmap = Form1.obraz.Clone
        Dim r, g, b As Integer
        Dim pr As Integer

        Form1.ProgressBar1.Value = 0
        Form1.ProgressBar1.Maximum = Form1.obraz.Height

        Dim lut(255) As Integer
        pr = TrackBar1.Value

        For i As Integer = 0 To 255
            lut(i) = (255 * (i - pr)) / (255 - (2 * pr))

            If lut(i) < 0 Then
                lut(i) = 0
            End If
            If lut(i) > 225 Then
                lut(i) = 225
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
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
