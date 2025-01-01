Public Class ListViewItemComparer
    Implements IComparer

    Private ReadOnly _column As Integer
    Private ReadOnly _sortOrder As SortOrder

    Public Sub New(column As Integer, sortOrder As SortOrder)
        _column = column
        _sortOrder = sortOrder
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
        Dim itemY As ListViewItem = DirectCast(y, ListViewItem)

        Dim valueX As String = If(itemX.SubItems.Count > _column, itemX.SubItems(_column).Text, String.Empty)
        Dim valueY As String = If(itemY.SubItems.Count > _column, itemY.SubItems(_column).Text, String.Empty)

        Dim comparisonResult As Integer = String.Compare(valueX, valueY)

        If _sortOrder = SortOrder.Descending Then
            comparisonResult *= -1
        End If

        Return comparisonResult
    End Function

    Public Shared Sub SortListViewColumn(listView As ListView, columnIndex As Integer, sortOrder As SortOrder)
        listView.ListViewItemSorter = New ListViewItemComparer(columnIndex, sortOrder)
        listView.Sort()
    End Sub
End Class