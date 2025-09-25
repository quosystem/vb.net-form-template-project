Imports Common

Public Class G001

    Private Const MENU_FORM_MIN_HEIGHT As Integer = 60
    Private Const GROUP_BOX_MIN_HEIGHT As Integer = 30
    Private Const MENU_BUTTON_HEIGHT As Integer = 40

    Public Sub New(designId As String)
        InitializeComponent()

        Me.DesignID = designId
        AddHandler Me.Shown, AddressOf Me_Shown
        SetupMenuButton()
    End Sub
    Private Sub Me_Shown(sender As Object, e As EventArgs)
        ResizeMenuForm()
        Me.ActiveControl = Nothing
    End Sub


    Private Sub ResizeMenuForm()
        Dim menuHeight As Integer = 0
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl IsNot GroupBox Then
                Continue For
            End If
            Dim gb As GroupBox = DirectCast(ctrl, GroupBox)
            gb.Height = GetGroupBoxHeight(gb)
            menuHeight += gb.Height
        Next
        Me.Height = MENU_FORM_MIN_HEIGHT + menuHeight
    End Sub

    Private Function GetGroupBoxHeight(gb As GroupBox) As Integer
        Dim gbHeight As Integer = gb.Height
        For Each ctrl As Control In gb.Controls
            If TypeOf ctrl Is FlowLayoutPanel Then
                Dim flp As FlowLayoutPanel = DirectCast(ctrl, FlowLayoutPanel)
                If flp.Height = 0 Then
                    'GroupBox中に「Visible = True」のボタンがない
                    gbHeight = 0
                Else
                    'GroupBox中に「Visible = True」のボタンが1個以上ある
                    gbHeight = GROUP_BOX_MIN_HEIGHT + flp.Height
                End If
            End If
        Next
        Return gbHeight
    End Function


    Private Sub SetupMenuButton()
        ''出荷指示
        'btnG002.Tag = ConstValue.DP_SHIP_INSTRUCT  '画面デザインID
        'AddHandler btnG002.Click, AddressOf ButtonMenu_Click 'ボタンクリックイベント

    End Sub

    Private Sub ShowWorkForm(btn As Button)
        '画面デザインID
        Dim designParam As New DesignParameters With {
            .DesignId = CStr(btn.Tag)
            }
        '機能画面
        Dim frm As CustomBaseForm

        'Select Case designParam.DesignId
        '    Case ConstValue.DP_SHIP_INSTRUCT
        '        frm = New G002(designParam)
        '    Case Else
        '        Return
        'End Select

        'メニュー画面非表示
        Me.Hide()

        ' 機能画面表示
        Using frm
            frm.ShowDialog(Me)
        End Using

        'メニュー画面再表示
        Me.Show()
    End Sub
End Class
