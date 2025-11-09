Imports System.Deployment.Application
Imports Common
Imports Common.Constants
Imports Common.DB.Connections
Imports Common.DbServices.Common
Imports Common.Log.Manager

Module AppStartUp
    <STAThread()>
    Public Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
#If DEBUG Then
        If ApplicationDeployment.IsNetworkDeployed Then
            ConfigManager.SystemVer = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
            ConfigManager.RunEnvironment = CommonConstants.EnvironmentType.Staging
        Else
            ConfigManager.RunEnvironment = CommonConstants.EnvironmentType.Development
            ConfigManager.SystemVer = "-"
        End If
#Else
        ConfigManager.SystemVer = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        ConfigManager.RunEnvironment = CommonConstants.EnvironmentType.Production
#End If

        ConfigManager.SystemID = ""
        ConfigManager.SystemIcon = My.Resources.ICON
        ConfigManager.SystemIconImg = My.Resources.ICON.ToBitmap()
        ConfigManager.HostName = System.Environment.MachineName

        Try
            ConfigManager.ProActive = New DbCommonService(DatabaseType.oracle, TargetType.proactive)
            ConfigManager.QuoSystem = New DbCommonService(DatabaseType.oracle, TargetType.quo_system)
            ConfigManager.Quopadb = New DbCommonService(DatabaseType.oracle, TargetType.quopadb)
            ConfigManager.ConstManager = New ConstantManager(DatabaseType.oracle, TargetType.quo_system, ConfigManager.SystemID)
            ConfigManager.SystemLogFolder = ConfigManager.ConstManager.GetConstant("LOG", "LOG_FOLDER")
            SetSystemCommonConfig(CommonConstants.SYSTEM_USER_ID)
            Using frmLogin As New Common.GK01
                If frmLogin.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    SetSystemCommonConfig(ConfigManager.UserId)
                    Using frmMenu As New G001("G001A")
                        frmMenu.ShowDialog()
                        Application.Exit()
                    End Using
                Else
                    Application.Exit()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "アプリ起動", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

    End Sub


    Private Sub SetSystemCommonConfig(userId As String)
        ConfigManager.Logger = LogFactory.CreateLogManager(DatabaseType.oracle,
                                                            TargetType.quo_system,
                                                            ConfigManager.SystemID,
                                                            ConfigManager.SystemName,
                                                            ConfigManager.SystemVer,
                                                            ConfigManager.SystemLogFolder,
                                                            ConfigManager.HostName,
                                                            userId)
        ConfigManager.ProActive.SetLogger(ConfigManager.Logger)
        ConfigManager.QuoSystem.SetLogger(ConfigManager.Logger)
        ConfigManager.Quopadb.SetLogger(ConfigManager.Logger)
        ConfigManager.MsgBox = New MessageManager(ConfigManager.Logger)
    End Sub

End Module


