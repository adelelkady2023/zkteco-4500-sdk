Imports System
Imports System.Windows.Forms

Namespace zk4500
    Friend Module Program
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1()) ' Replace Form1 with your main form's class name
        End Sub
    End Module
End Namespace
