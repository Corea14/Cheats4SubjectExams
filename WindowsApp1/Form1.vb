Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_MONITORPOWER As Integer = &HF170
    Private Const MONITOR_OFF As Integer = 2
    Private Const MONITOR_ON As Integer = -1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.P Then
            ' Encender la pantalla nuevamente
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_ON)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub AgregarFila_Click(sender As Object, e As EventArgs)
        ' Agregar una fila vacía al DataGridView
        Dim dataGridView As DataGridView = Me.Controls.OfType(Of DataGridView)().First()
        dataGridView.Rows.Add()
    End Sub

    Private Sub AgregarColumna_Click(sender As Object, e As EventArgs)
        ' Agregar una columna al DataGridView
        Dim dataGridView As DataGridView = Me.Controls.OfType(Of DataGridView)().First()
        dataGridView.Columns.Add("Columna" & dataGridView.Columns.Count + 1, "Columna " & dataGridView.Columns.Count + 1)
    End Sub



    Function juan(asd)
        asd = TextBox1.Text + TextBox2.Text
        Return asd
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(juan(0))
    End Sub
End Class
