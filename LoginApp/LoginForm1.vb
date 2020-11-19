Public Class LoginForm1

    ' TODO: 指定されたユーザー名およびパスワードを使用して、カスタム認証を実行するコードを挿入します
    ' (https://go.microsoft.com/fwlink/?LinkId=35339 を参照)。
    ' カスタム プリンシパルは、以下のように現在のスレッドのプリンシパルにアタッチできます:
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' この場合 CustomPrincipal は、認証を実行するのに使われる IPrincipal 実装です。
    ' これにより My.User は、ユーザー名および表示名などの CustomPrincipal オブジェクトに要約された ID 情報を
    ' 返します。
    Private user1() As String = {"", ""}
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = user1(0) AndAlso
                PasswordTextBox.Text = user1(1) Then
            Form1.Show()
            Me.Close()
        Else
            MessageBox.Show("認証できません。")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ControlBox = False
    End Sub
End Class
