Imports Newtonsoft.Json

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

End Module