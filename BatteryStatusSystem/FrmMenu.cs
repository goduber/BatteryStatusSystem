using System.Windows.Forms;

namespace BatteryStatusSystem
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            notifyBattery.Icon = this.Icon;
            notifyBattery.ContextMenuStrip = menuBattery;
            notifyBattery.Text = Application.ProductName;
            notifyBattery.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            TimeBattery.Enabled = true;
            this.Visible = false;
        }

        private void TimeBattery_Tick(object sender, EventArgs e)
        {
            BatteryStatus batteryStatus = new BatteryStatus();
            string statusBatterys;
            if (batteryStatus.LevelBaterry() == 100 && batteryStatus.ChargingStatus() == true && TimeMessage.Enabled == false)
                TimeMessage.Enabled = true;
            item1ToolStripMenuItem.Text = batteryStatus.LevelBaterry().ToString();
            if (batteryStatus.ChargingStatus())
                statusBatterys = "Cargando";
            else
                statusBatterys = "Bateria";
            item2ToolStripMenuItem.Text = statusBatterys;
            notifyBattery.Text = Application.ProductName + " - " + statusBatterys;
        }

        private void TimeMessage_Tick(object sender, EventArgs e)
        {
            BatteryStatus batteryStatus = new BatteryStatus();
            if (batteryStatus.LevelBaterry() == 100 && batteryStatus.ChargingStatus() == false)
                TimeMessage.Enabled = false;
            else
                notifyBattery.ShowBalloonTip(2000, "Battery Status System", "Carga Completa, desconectar fuente de poder",ToolTipIcon.Info);
        }
    }
}
