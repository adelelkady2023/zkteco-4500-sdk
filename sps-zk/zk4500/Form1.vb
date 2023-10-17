Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports AxZKFPEngXControl

Namespace zk4500
    Public Partial Class Form1
        Inherits Form
        Private ZkFprint As AxZKFPEngX = New AxZKFPEngX()
        Private Check As Boolean

        Public Sub New()
            InitializeComponent()

        End Sub



        Private Sub InitialAxZkfp()
            Try

                AddHandler ZkFprint.OnImageReceived, AddressOf zkFprint_OnImageReceived
                AddHandler ZkFprint.OnFeatureInfo, AddressOf zkFprint_OnFeatureInfo
                'zkFprint.OnFingerTouching 
                'zkFprint.OnFingerLeaving
                AddHandler ZkFprint.OnEnroll, AddressOf zkFprint_OnEnroll

                If ZkFprint.InitEngine() = 0 Then
                    ZkFprint.FPEngineVersion = "9"
                    ZkFprint.EnrollCount = 3
                    deviceSerial.Text += " " & ZkFprint.SensorSN & " Count: " & ZkFprint.SensorCount.ToString() & " Index: " & ZkFprint.SensorIndex.ToString()
                    ShowHintInfo("Device successfully connected")
                End If
            Catch ex As Exception
                ShowHintInfo("Device init err, error: " & ex.Message)
            End Try
        End Sub

        Private Sub zkFprint_OnImageReceived(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnImageReceivedEvent)
            Dim g As Graphics = fpicture.CreateGraphics()
            Dim bmp As Bitmap = New Bitmap(fpicture.Width, fpicture.Height)
            g = Graphics.FromImage(bmp)
            Dim dc As Integer = g.GetHdc().ToInt32()
            ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height)
            g.Dispose()
            fpicture.Image = bmp
        End Sub

        Private Sub zkFprint_OnFeatureInfo(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnFeatureInfoEvent)

            Dim strTemp = String.Empty
            If ZkFprint.EnrollIndex <> 1 Then
                If ZkFprint.IsRegister Then
                    If ZkFprint.EnrollIndex - 1 > 0 Then
                        Dim eindex = ZkFprint.EnrollIndex - 1
                        strTemp = "Please scan again ..." & eindex.ToString()
                    End If
                End If
            End If
            ShowHintInfo(strTemp)
        End Sub
        Private Sub zkFprint_OnEnroll(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnEnrollEvent)
            If e.actionResult Then


                Dim template = ZkFprint.EncodeTemplate1(e.aTemplate)
                txtTemplate.Text = template
                ShowHintInfo("Registration successful. You can verify now")
                btnregistrpf.Enabled = False
                btnVerifyfp.Enabled = True
            Else
                ShowHintInfo("Error, please register again.")

            End If
        End Sub
        Private Sub zkFprint_OnCapture(ByVal sender As Object, ByVal e As IZKFPEngXEvents_OnCaptureEvent)
            Dim template = ZkFprint.EncodeTemplate1(e.aTemplate)


            If ZkFprint.VerFingerFromStr(template, txtTemplate.Text, False, Check) Then
                ShowHintInfo("Verified")
            Else
                ShowHintInfo("Not Verified")
            End If

        End Sub



        Private Sub ShowHintInfo(ByVal s As String)
            prompt.Text = s
        End Sub


        Private Sub btnVerify_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub




        Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
            Controls.Add(ZkFprint)
            InitialAxZkfp()
        End Sub

        Private Sub btnregistrpf_Click(sender As Object, e As EventArgs) Handles btnregistrpf.Click

            ZkFprint.CancelEnroll()
            ZkFprint.EnrollCount = 3
            ZkFprint.BeginEnroll()
            ShowHintInfo("Please give fingerprint sample.")

        End Sub

        Private Sub btnVerifyfp_Click(sender As Object, e As EventArgs) Handles btnVerifyfp.Click
            If ZkFprint.IsRegister Then
                ZkFprint.CancelEnroll()
            End If
            AddHandler ZkFprint.OnCapture, AddressOf zkFprint_OnCapture
            ZkFprint.BeginCapture()
            ShowHintInfo("Please give fingerprint sample.")
        End Sub

        Private Sub btnclearfp_Click(sender As Object, e As EventArgs) Handles btnclearfp.Click
            fpicture.Image = Nothing
        End Sub
    End Class
End Namespace
