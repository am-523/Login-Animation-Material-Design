Public Class Form1

    Public Sub InitializeMyForm()
        BackColor = Color.LightBlue
        ' Make the background color of form display transparently.
        TransparencyKey = BackColor
    End Sub 'InitializeMyForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeMyForm()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        pn_register.Visible = True
        pn_login.Visible = False
        Guna2Transition1.ShowSync(pn_register)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        pn_login.Visible = True
        Guna2Transition1.ShowSync(pn_login)
    End Sub
End Class
