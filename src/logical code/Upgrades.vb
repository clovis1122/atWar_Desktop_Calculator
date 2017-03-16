Public Class Upgrades
    Public stack As Stack

    Private Sub Upgrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'General

        Gdefense.Checked = stack.GDefense
        GmilitiaHP.Checked = stack.GMilitiaHP
        GInfantryA.Checked = stack.GInfantryA
        GTankA.Checked = stack.GTankA
        GbomberA.Checked = stack.GBomberA
        GLucky.Checked = stack.GLucky

        'Common

        StrongAA.Checked = stack.StrongAA
        SaferTrans.Checked = stack.SaferTrans
        LuckyTank.Checked = stack.LuckyTank
        LuckyMil.Checked = stack.LuckyMil
        LuckyMar.Checked = stack.LuckyMar
        LuckyInf.Checked = stack.LuckyInf
    End Sub

    Private Sub Gdefense_CheckedChanged(sender As Object, e As EventArgs) Handles Gdefense.CheckedChanged
        stack.GDefense = Gdefense.Checked
    End Sub

    Private Sub GmilitiaHP_CheckedChanged(sender As Object, e As EventArgs) Handles GmilitiaHP.CheckedChanged
        stack.GMilitiaHP = GmilitiaHP.Checked
        stack.addModifiers()
    End Sub

    Private Sub GInfantryA_CheckedChanged(sender As Object, e As EventArgs) Handles GInfantryA.CheckedChanged
        stack.GInfantryA = GInfantryA.Checked
        stack.addModifiers()
    End Sub

    Private Sub GTankA_CheckedChanged(sender As Object, e As EventArgs) Handles GTankA.CheckedChanged
        stack.GTankA = GTankA.Checked
        stack.addModifiers()

    End Sub

    Private Sub GbomberA_CheckedChanged(sender As Object, e As EventArgs) Handles GbomberA.CheckedChanged
        stack.GBomberA = GbomberA.Checked
        stack.addModifiers()
    End Sub

    Private Sub GLucky_CheckedChanged(sender As Object, e As EventArgs) Handles GLucky.CheckedChanged
        stack.GLucky = GLucky.Checked
        stack.addModifiers()
    End Sub

    Private Sub StrongAA_CheckedChanged(sender As Object, e As EventArgs) Handles StrongAA.CheckedChanged
        stack.StrongAA = StrongAA.Checked
        stack.addModifiers()
    End Sub

    Private Sub SaferTrans_CheckedChanged(sender As Object, e As EventArgs) Handles SaferTrans.CheckedChanged
        stack.SaferTrans = SaferTrans.Checked
        stack.addModifiers()

    End Sub

    Private Sub LuckyTank_CheckedChanged(sender As Object, e As EventArgs) Handles LuckyTank.CheckedChanged
        stack.LuckyTank = LuckyTank.Checked
        stack.addModifiers()
    End Sub

    Private Sub LuckyMil_CheckedChanged(sender As Object, e As EventArgs) Handles LuckyMil.CheckedChanged
        stack.LuckyMil = LuckyMil.Checked
        stack.addModifiers()
    End Sub

    Private Sub LuckyMar_CheckedChanged(sender As Object, e As EventArgs) Handles LuckyMar.CheckedChanged
        stack.LuckyMar = LuckyMar.Checked
        stack.addModifiers()
    End Sub

    Private Sub LuckyInf_CheckedChanged(sender As Object, e As EventArgs) Handles LuckyInf.CheckedChanged
        stack.LuckyInf = LuckyInf.Checked
        stack.addModifiers()
    End Sub

End Class