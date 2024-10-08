using QRCoder;

namespace QRGenerator_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LinkTextBox.Text) || string.IsNullOrWhiteSpace(LinkTextBox.Text) || LinkTextBox.Text == null || LinkTextBox.Text == "")
            {
                try
                {
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();

                    QRCodeData data = qrGenerator.CreateQrCode(LinkTextBox.Text.Trim(), QRCodeGenerator.ECCLevel.Q);

                    QRCode qrCode = new QRCode(data);

                    Bitmap qrCodeImage = qrCode.GetGraphic(5);

                    QRPictureBox.Image = new Bitmap(qrCodeImage, QRPictureBox.Width, QRPictureBox.Height);
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��������� QR-����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("���� ����� �� ������ ���� ������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            LinkTextBox.Clear();
            QRPictureBox.Image = null;
        }
    }
}
