using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Templates;
using System.Windows.Forms;
using DevExpress.Utils.Frames;

namespace WinSample.Module.Win {
    public partial class ViewHintController : ViewController {
        public ViewHintController() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewType = ViewType.ListView;
        }
        protected override void OnActivated() {
            base.OnActivated();
            Frame.GetController<WindowHintController>().HintPanelReady += new EventHandler<HintPanelReadyEventArgs>(ViewHintController_HintPanelReady);
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            Frame.GetController<WindowHintController>().HintPanelReady -= new EventHandler<HintPanelReadyEventArgs>(ViewHintController_HintPanelReady);
        }
        void ViewHintController_HintPanelReady(object sender, HintPanelReadyEventArgs e) {
            e.HintPanel.Text = View.Id;
            e.HintPanel.Visible = true;
        }
    }
}
