using Microsoft.VisualBasic.Devices;

namespace CSProject2
{
    public partial class ImageDisplayer : Form
    {

        public ImageDisplayer()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DisplayImage.Image = imageList1.Images[comboBox1.SelectedIndex]; ///display the selected image from an image list
            }
            else
            {
                MessageBox.Show("Please select an image", "Error!", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("SelectContent.txt"))   ///Reads through a text file and adds them to the combo box if the file exists
            {
                string[] CollectionAppend = File.ReadAllLines("SelectContent.txt");
                for (int i = 0; i < CollectionAppend.Length; i++)
                {
                    comboBox1.Items.Add(CollectionAppend[i]);
                }
            }
            else  ///give an error message and crashes if file doesn't exist
            {
                MessageBox.Show("Target file not found!", "Error: File not found!", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}