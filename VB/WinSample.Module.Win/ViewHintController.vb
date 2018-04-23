Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Templates
Imports System.Windows.Forms
Imports DevExpress.Utils.Frames

Namespace WinSample.Module.Win
	Partial Public Class ViewHintController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewType = ViewType.ListView
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			AddHandler Frame.GetController(Of WindowHintController)().HintPanelReady, AddressOf ViewHintController_HintPanelReady
		End Sub
		Protected Overrides Sub OnDeactivated()
			MyBase.OnDeactivated()
			RemoveHandler Frame.GetController(Of WindowHintController)().HintPanelReady, AddressOf ViewHintController_HintPanelReady
		End Sub
		Private Sub ViewHintController_HintPanelReady(ByVal sender As Object, ByVal e As HintPanelReadyEventArgs)
			e.HintPanel.Text = View.Id
			e.HintPanel.Visible = True
		End Sub
	End Class
End Namespace
