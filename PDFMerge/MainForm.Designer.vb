﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.pbar = New System.Windows.Forms.ProgressBar
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.FileList = New System.Windows.Forms.CheckedListBox
        Me.lblProgress = New System.Windows.Forms.Label
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.cmdConvert = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        Me.cmdUp = New System.Windows.Forms.Button
        Me.CmdDown = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'pbar
        '
        Me.pbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbar.Location = New System.Drawing.Point(500, 402)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(249, 23)
        Me.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbar.TabIndex = 15
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(11, 22)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Check/Uncheck All"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FileList
        '
        Me.FileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileList.BackColor = System.Drawing.Color.White
        Me.FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileList.FormattingEnabled = True
        Me.FileList.Location = New System.Drawing.Point(12, 55)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(737, 332)
        Me.FileList.TabIndex = 10
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.Location = New System.Drawing.Point(12, 401)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(220, 23)
        Me.lblProgress.TabIndex = 16
        '
        'cmdLoad
        '
        Me.cmdLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLoad.Location = New System.Drawing.Point(443, 22)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(88, 23)
        Me.cmdLoad.TabIndex = 12
        Me.cmdLoad.Text = "Load PDF"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdConvert
        '
        Me.cmdConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConvert.Location = New System.Drawing.Point(536, 22)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(86, 23)
        Me.cmdConvert.TabIndex = 11
        Me.cmdConvert.Text = "Merge PDF"
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(15, 412)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 17
        '
        'cmdUp
        '
        Me.cmdUp.Location = New System.Drawing.Point(151, 22)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(81, 23)
        Me.cmdUp.TabIndex = 18
        Me.cmdUp.Text = "Move Up"
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'CmdDown
        '
        Me.CmdDown.Location = New System.Drawing.Point(238, 22)
        Me.CmdDown.Name = "CmdDown"
        Me.CmdDown.Size = New System.Drawing.Size(83, 23)
        Me.CmdDown.TabIndex = 19
        Me.CmdDown.Text = "Move Down"
        Me.CmdDown.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(638, 32)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(111, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.thetechhub.com"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 434)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.FileList)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdConvert)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "PDF Merge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents FileList As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents cmdUp As System.Windows.Forms.Button
    Friend WithEvents CmdDown As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
