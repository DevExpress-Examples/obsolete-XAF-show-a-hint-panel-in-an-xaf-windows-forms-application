using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Utils.Frames;
using DevExpress.ExpressApp.Templates;
using System.Windows.Forms;

namespace WinSample.Module.Win {
    public partial class WindowHintController : WindowController {
        public WindowHintController() {
            InitializeComponent();
            RegisterActions(components);
        }
        protected override void OnActivated() {
            base.OnActivated();
            Window.TemplateViewChanged += new EventHandler(Window_TemplateViewChanged);
        }
        private NotePanelEx hintPanel;
        public NotePanelEx HintPanel {
            get {
                return hintPanel;
            }
        }
        void Window_TemplateViewChanged(object sender, EventArgs e) {
            if (Frame.Template is IViewSiteTemplate) {
                PlaceHintPanel();
            }
        }
        public event EventHandler<HintPanelReadyEventArgs> HintPanelReady;
        private void PlaceHintPanel() {
            hintPanel = new NotePanelEx();
            hintPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            hintPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            hintPanel.MinimumSize = new System.Drawing.Size(350, 33);
            hintPanel.Visible = false;
            Control viewSiteControl = (Frame.Template as IViewSiteTemplate).ViewSiteControl as Control;
            viewSiteControl.Controls.Add(hintPanel);
            DoHintPanelReady(hintPanel);
        }
        private void DoHintPanelReady(NotePanelEx hintPanel) {
            if (HintPanelReady != null) {
                HintPanelReady(this, new HintPanelReadyEventArgs(hintPanel));
            }
        }
    }
    public class HintPanelReadyEventArgs : EventArgs {
        public HintPanelReadyEventArgs(NotePanelEx hintPanel) : base() {
            this.hintPanel = hintPanel;
        }
        private NotePanelEx hintPanel;
        public NotePanelEx HintPanel {
            get {
                return hintPanel;
            }
        }
    }
}
