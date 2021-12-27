Module mdFunction
    Public Sub ShowForm(frm As Form)
        'Me.CenterToScreen()
        frm.MdiParent = FormMain
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.FormBorderStyle = FormBorderStyle.None
        frm.BringToFront()
        frm.Show()
    End Sub
End Module
