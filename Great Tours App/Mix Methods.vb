Imports Newtonsoft.Json
Imports System.ComponentModel
Imports System.Reflection

Module Mix_Methods

    Friend Sub ExportTo(ByVal iGrid As DevExpress.XtraGrid.GridControl, strFormText As String)
        Try
            Dim r As New Random
            Dim f As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\GreatToursCrmMini"
            If IO.Directory.Exists(f) = False Then IO.Directory.CreateDirectory(f)
            f &= "\" & strFormText
            If IO.Directory.Exists(f) = False Then IO.Directory.CreateDirectory(f)

            f &= "\REP" & r.Next(0, Integer.MaxValue) & ".xlsx"
            iGrid.ExportToXlsx(f)

            Process.Start("EXPLORER.EXE", Chr(34) & f & Chr(34))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.Title)
        End Try
    End Sub

    Friend Function ToJson(O As Object) As String
        Dim json As String = JsonConvert.SerializeObject(O, Formatting.Indented)
        Return json
    End Function

    <System.Runtime.CompilerServices.Extension>
    Friend Function ToDataTable(Of T)(data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim dt As New DataTable()
        For i As Integer = 0 To properties.Count - 1
            Dim [property] As PropertyDescriptor = properties(i)
            dt.Columns.Add([property].Name, [property].PropertyType)
        Next
        Dim values As Object() = New Object(properties.Count - 1) {}
        For Each item As T In data
            For i As Integer = 0 To values.Length - 1
                values(i) = properties(i).GetValue(item)
            Next
            dt.Rows.Add(values)
        Next
        Return dt
    End Function

End Module