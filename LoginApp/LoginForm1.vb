Public Class LoginForm1

    ' TODO: �w�肳�ꂽ���[�U�[������уp�X���[�h���g�p���āA�J�X�^���F�؂����s����R�[�h��}�����܂�
    ' (https://go.microsoft.com/fwlink/?LinkId=35339 ���Q��)�B
    ' �J�X�^�� �v�����V�p���́A�ȉ��̂悤�Ɍ��݂̃X���b�h�̃v�����V�p���ɃA�^�b�`�ł��܂�:
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' ���̏ꍇ CustomPrincipal �́A�F�؂����s����̂Ɏg���� IPrincipal �����ł��B
    ' ����ɂ�� My.User �́A���[�U�[������ѕ\�����Ȃǂ� CustomPrincipal �I�u�W�F�N�g�ɗv�񂳂ꂽ ID ����
    ' �Ԃ��܂��B
    Private user1() As String = {"", ""}
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = user1(0) AndAlso
                PasswordTextBox.Text = user1(1) Then
            Form1.Show()
            Me.Close()
        Else
            MessageBox.Show("�F�؂ł��܂���B")
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
