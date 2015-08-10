using System.Windows.Forms;

namespace AIOSystemUtility3
{
    public partial class PartitionControl : UserControl
    {
        public Partition partition = null;
        public PartitionControl(Partition partition)
        {
            this.partition = partition;
            InitializeComponent();
            Update(partition);
        }

        public void Update(Partition partition)
        {
            BackColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][1];
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    ((Label)c).ForeColor = Colours.COLOURS[Colours.SELECTED_COLOUR_SCHEME][4];
                }
            }
            NameTxt.Text = partition.Name + " " + (partition.VolumeName.Length == 0 ? "Local Disk" : partition.VolumeName);
            FileSystemTxt.Text = partition.FileSystem;
            CapacityTxt.Text = partition.Capacity.ToString("0.## GB");
            FreeTxt.Text = partition.FreeSpace.ToString("0.## GB");
            SystemDriveTxt.Text = partition.SystemPartition ? "True" : "False";
        }
    }
}
