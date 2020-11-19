Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbOperator.Items.Add("+")
        CmbOperator.Items.Add("-")
        CmbOperator.Items.Add("/")
        CmbOperator.Items.Add("x")
        CmbOperator.Items.Add("<>")
        CmbOperator.Items.Add("<")
        CmbOperator.Items.Add(">")
        CmbOperator.Items.Add(">=")
        CmbOperator.Items.Add("<=")
        CmbOperator.Items.Add("Like")
        CmbOperator.Items.Add("Not")
        CmbOperator.Items.Add("And")
        CmbOperator.Items.Add("Or")
        CmbOperator.Items.Add("Xor")
        CmbOperator.Items.Add("+ (Penggabungan)")
        CmbOperator.Items.Add("&")
    End Sub

    Private Sub BtnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcess.Click
        Select Case CmbOperator.Text
            Case "+"
                TxtHasil.Text = Val(TxtNilai1.Text) + (TxtNilai2.Text)
            Case "-"
                TxtHasil.Text = TxtNilai1.Text - TxtNilai2.Text
            Case "/"
                TxtHasil.Text = TxtNilai1.Text / TxtNilai2.Text
            Case "x"
                TxtHasil.Text = TxtNilai1.Text * TxtNilai2.Text
            Case "<>"
                TxtHasil.Text = TxtNilai1.Text <> TxtNilai2.Text
            Case "<"
                TxtHasil.Text = TxtNilai1.Text < TxtNilai2.Text
            Case ">"
                TxtHasil.Text = TxtNilai1.Text > TxtNilai2.Text
            Case "<="
                TxtHasil.Text = TxtNilai1.Text <= TxtNilai2.Text
            Case ">="
                TxtHasil.Text = TxtNilai1.Text >= TxtNilai2.Text
            Case "Like"
                TxtHasil.Text = TxtNilai1.Text Like TxtNilai2.Text
            Case "Not"
                TxtHasil.Text = Not TxtNilai1.Text = TxtNilai2.Text
            Case "And"
                TxtHasil.Text = TxtNilai1.Text = "Maxikom" And TxtNilai2.Text = "Maxikom"
            Case "Or"
                TxtHasil.Text = TxtNilai1.Text = "Maxikom" And TxtNilai2.Text = "Maxikom" Or TxtNilai2.Text = "Maxikom"
            Case "Xor"
                TxtHasil.Text = TxtNilai1.Text = "Maxikom" And TxtNilai2.Text = "Maxikom" Xor TxtNilai2.Text = "Maxikom"
            Case "+ (Penggabungan)"
                TxtHasil.Text = TxtNilai1.Text + TxtNilai2.Text
            Case "&"
                TxtHasil.Text = TxtNilai1.Text & TxtNilai2.Text
        End Select
    End Sub
End Class
