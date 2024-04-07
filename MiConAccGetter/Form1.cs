using System.IO.Ports;

namespace MiConAccGetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var portNames = SerialPort.GetPortNames();
            PortNamesBox.Items.AddRange(portNames);

            if (File.Exists("PortName.txt"))
                if (portNames.Contains(File.ReadAllText("PortName.txt").Replace("\n", "")))
                    PortNamesBox.SelectedItem = File.ReadAllText("PortName.txt").Replace("\n", "");
            // First available port
            
        }

        private void ConnectStart_Click(object sender, EventArgs e)
        {
            var sp = new SerialPort(PortNamesBox.SelectedItem?.ToString(), 115200);
            sp.Open();
            sp.WriteLine("Hello World!");
        }
    }
}
