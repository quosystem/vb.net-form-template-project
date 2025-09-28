<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class G001
    Inherits Common.CustomBaseForm

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbInstruct = New System.Windows.Forms.GroupBox()
        Me.flpInstruct = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnG002 = New System.Windows.Forms.Button()
        Me.gbInstruct.SuspendLayout()
        Me.flpInstruct.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbInstruct
        '
        Me.gbInstruct.AccessibleDescription = "CTRL02"
        Me.gbInstruct.AccessibleName = "出荷指示"
        Me.gbInstruct.Controls.Add(Me.flpInstruct)
        Me.gbInstruct.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbInstruct.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.gbInstruct.Location = New System.Drawing.Point(15, 40)
        Me.gbInstruct.Name = "gbInstruct"
        Me.gbInstruct.Padding = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.gbInstruct.Size = New System.Drawing.Size(470, 70)
        Me.gbInstruct.TabIndex = 1
        Me.gbInstruct.TabStop = False
        Me.gbInstruct.Text = "機能名"
        '
        'flpInstruct
        '
        Me.flpInstruct.AccessibleDescription = "CTRL03"
        Me.flpInstruct.AutoSize = True
        Me.flpInstruct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpInstruct.Controls.Add(Me.btnG002)
        Me.flpInstruct.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpInstruct.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpInstruct.Location = New System.Drawing.Point(3, 25)
        Me.flpInstruct.Margin = New System.Windows.Forms.Padding(0)
        Me.flpInstruct.Name = "flpInstruct"
        Me.flpInstruct.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.flpInstruct.Size = New System.Drawing.Size(464, 40)
        Me.flpInstruct.TabIndex = 0
        Me.flpInstruct.WrapContents = False
        '
        'btnG002
        '
        Me.btnG002.AccessibleDescription = "CTRL03A"
        Me.btnG002.AccessibleName = "出荷指示"
        Me.btnG002.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG002.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnG002.Location = New System.Drawing.Point(7, 0)
        Me.btnG002.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnG002.Name = "btnG002"
        Me.btnG002.Size = New System.Drawing.Size(450, 30)
        Me.btnG002.TabIndex = 11
        Me.btnG002.Text = "画面名"
        Me.btnG002.UseVisualStyleBackColor = True
        '
        'G001
        '
        Me.AccessibleDescription = "G001"
        Me.AccessibleName = "メニュー"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CheckAuthority = False
        Me.ClientSize = New System.Drawing.Size(500, 170)
        Me.Controls.Add(Me.gbInstruct)
        Me.FormName = "メニュー"
        Me.FormShowTime = New Date(2025, 6, 19, 16, 8, 4, 770)
        Me.FormType = Common.CustomBaseForm.FormKind.MenuForm
        Me.Name = "G001"
        Me.ShowMsgLogButton = False
        Me.Text = "G001"
        Me.Controls.SetChildIndex(Me.gbInstruct, 0)
        Me.gbInstruct.ResumeLayout(False)
        Me.gbInstruct.PerformLayout()
        Me.flpInstruct.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbInstruct As GroupBox
    Friend WithEvents flpInstruct As FlowLayoutPanel
    Friend WithEvents btnG002 As Button
End Class
