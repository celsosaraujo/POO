using System;

namespace TesteCorinthiano
{
    public partial class FRMTesteCorinthiano : Form
    {
        Random random = new Random();
        public FRMTesteCorinthiano()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNao_MouseEnter(object sender, EventArgs e)
        {
            // Limites do cliente
            int maxX = Math.Max(0, this.ClientSize.Width - btnNao.Width);
            int maxY = Math.Max(0, this.ClientSize.Height - btnNao.Height);

            if (maxX == 0 && maxY == 0) return;

            int novaX, novaY;
            int tentativas = 0;
            do
            {
                novaX = random.Next(0, maxX + 1);
                novaY = random.Next(0, maxY + 1);
                tentativas++;
            } while ((novaX == btnNao.Location.X && novaY == btnNao.Location.Y) && tentativas < 10);

            btnNao.Location = new Point(novaX, novaY);
            btnNao.BringToFront();
        }
    }
}
