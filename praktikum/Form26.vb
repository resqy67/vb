Public Class Form26
    Private Sub MhsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MhsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MhsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database11DataSet)

    End Sub

    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database11DataSet.mhs' table. You can move, or remove it, as needed.
        Me.MhsTableAdapter.Fill(Me.Database11DataSet.mhs)

    End Sub

    Private Sub MhsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MhsDataGridView.CellContentClick

    End Sub
End Class