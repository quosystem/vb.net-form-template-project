Imports Common
Imports Mysqlx.XDevAPI.CRUD

Public Class G002

#Region "定数"

#End Region
    Private Const MENU_FORM_MIN_HEIGHT As Integer = 60
    Private Const GROUP_BOX_MIN_HEIGHT As Integer = 30
    Private Const MENU_BUTTON_HEIGHT As Integer = 40


    Public Sub New(designParam As G002Parameters)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' デザインID
        Me.DesignID = designParam.DesignId

        ' フォーム画面イベントハンドラ
        AddHandler Me.Shown, AddressOf Me_Shown

    End Sub

    ''' <summary>
    ''' フォーム表示直後
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Me_Shown(sender As Object, e As EventArgs)

    End Sub
End Class
