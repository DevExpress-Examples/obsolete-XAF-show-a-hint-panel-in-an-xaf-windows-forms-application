Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Utils.Frames
Imports DevExpress.ExpressApp.Templates
Imports System.Windows.Forms

Namespace WinSample.Module.Win
	Partial Public Class WindowHintController
		Inherits WindowController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			AddHandler Window.TemplateViewChanged, AddressOf Window_TemplateViewChanged
		End Sub
		Private hintPanel_Renamed As NotePanelEx
		Public ReadOnly Property HintPanel() As NotePanelEx
			Get
				Return hintPanel_Renamed
			End Get
		End Property
		Private Sub Window_TemplateViewChanged(ByVal sender As Object, ByVal e As EventArgs)
			If TypeOf Frame.Template Is IViewSiteTemplate Then
				PlaceHintPanel()
			End If
		End Sub
		Public Event HintPanelReady As EventHandler(Of HintPanelReadyEventArgs)
		Private Sub PlaceHintPanel()
			hintPanel_Renamed = New NotePanelEx()
			hintPanel_Renamed.BackColor = System.Drawing.Color.LightGoldenrodYellow
			hintPanel_Renamed.Dock = System.Windows.Forms.DockStyle.Bottom
			hintPanel_Renamed.MinimumSize = New System.Drawing.Size(350, 33)
			hintPanel_Renamed.Visible = False
			Dim viewSiteControl As Control = TryCast((TryCast(Frame.Template, IViewSiteTemplate)).ViewSiteControl, Control)
			viewSiteControl.Controls.Add(hintPanel_Renamed)
			DoHintPanelReady(hintPanel_Renamed)
		End Sub
		Private Sub DoHintPanelReady(ByVal hintPanel As NotePanelEx)
			RaiseEvent HintPanelReady(Me, New HintPanelReadyEventArgs(hintPanel))
		End Sub
	End Class
	Public Class HintPanelReadyEventArgs
		Inherits EventArgs
		Public Sub New(ByVal hintPanel As NotePanelEx)
			MyBase.New()
			Me.hintPanel_Renamed = hintPanel
		End Sub
		Private hintPanel_Renamed As NotePanelEx
		Public ReadOnly Property HintPanel() As NotePanelEx
			Get
				Return hintPanel_Renamed
			End Get
		End Property
	End Class
End Namespace
