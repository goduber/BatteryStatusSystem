namespace BatteryStatusSystem
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            TimeBattery = new System.Windows.Forms.Timer(components);
            notifyBattery = new NotifyIcon(components);
            menuBattery = new ContextMenuStrip(components);
            item1ToolStripMenuItem = new ToolStripMenuItem();
            item2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            TimeMessage = new System.Windows.Forms.Timer(components);
            menuBattery.SuspendLayout();
            SuspendLayout();
            // 
            // TimeBattery
            // 
            TimeBattery.Interval = 6000;
            TimeBattery.Tick += TimeBattery_Tick;
            // 
            // notifyBattery
            // 
            notifyBattery.Text = "notifyIcon1";
            notifyBattery.Visible = true;
            // 
            // menuBattery
            // 
            menuBattery.Items.AddRange(new ToolStripItem[] { item1ToolStripMenuItem, item2ToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            menuBattery.Name = "menuBattery";
            menuBattery.Size = new Size(105, 76);
            // 
            // item1ToolStripMenuItem
            // 
            item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            item1ToolStripMenuItem.Size = new Size(104, 22);
            item1ToolStripMenuItem.Text = "item1";
            // 
            // item2ToolStripMenuItem
            // 
            item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            item2ToolStripMenuItem.Size = new Size(104, 22);
            item2ToolStripMenuItem.Text = "item2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(101, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(104, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // TimeMessage
            // 
            TimeMessage.Interval = 30000;
            TimeMessage.Tick += TimeMessage_Tick;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            Text = "Battery Status System";
            WindowState = FormWindowState.Minimized;
            Load += FrmMenu_Load;
            menuBattery.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer TimeBattery;
        private NotifyIcon notifyBattery;
        private ContextMenuStrip menuBattery;
        private ToolStripMenuItem item1ToolStripMenuItem;
        private ToolStripMenuItem item2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer TimeMessage;
    }
}
