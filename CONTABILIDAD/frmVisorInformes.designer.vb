﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorInformes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Visor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Visor
        '
        Me.Visor.ActiveViewIndex = -1
        Me.Visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visor.Cursor = System.Windows.Forms.Cursors.Default
        Me.Visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Visor.Location = New System.Drawing.Point(0, 0)
        Me.Visor.Name = "Visor"
        'Me.Visor.SelectionFormula = ""
        Me.Visor.Size = New System.Drawing.Size(1136, 391)
        Me.Visor.TabIndex = 0
        'Me.Visor.ViewTimeSelectionFormula = ""
        '
        'frmVisorInformes
        '
        Me.ClientSize = New System.Drawing.Size(1136, 391)
        Me.Controls.Add(Me.Visor)
        Me.Name = "frmVisorInformes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Visor As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
