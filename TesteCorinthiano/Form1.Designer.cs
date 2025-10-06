namespace TesteCorinthiano
{
    partial class FRMTesteCorinthiano
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
            pctCorinthians = new PictureBox();
            lblCorinthians = new Label();
            btnSim = new Button();
            btnNao = new Button();
            ((System.ComponentModel.ISupportInitialize)pctCorinthians).BeginInit();
            SuspendLayout();
            // 
            // pctCorinthians
            // 
            pctCorinthians.Image = Properties.Resources.Logo_do_Corinthians;
            pctCorinthians.Location = new Point(439, 86);
            pctCorinthians.Name = "pctCorinthians";
            pctCorinthians.Size = new Size(339, 338);
            pctCorinthians.SizeMode = PictureBoxSizeMode.StretchImage;
            pctCorinthians.TabIndex = 0;
            pctCorinthians.TabStop = false;            
            // 
            // lblCorinthians
            // 
            lblCorinthians.AutoSize = true;
            lblCorinthians.Font = new Font("Segoe UI", 23F);
            lblCorinthians.Location = new Point(454, 455);
            lblCorinthians.Name = "lblCorinthians";
            lblCorinthians.Size = new Size(292, 42);
            lblCorinthians.TabIndex = 1;
            lblCorinthians.Text = "Você é Corinthiano?";
            // 
            // btnSim
            // 
            btnSim.Location = new Point(439, 542);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(142, 52);
            btnSim.TabIndex = 2;
            btnSim.Text = "SIM";
            btnSim.UseVisualStyleBackColor = true;
            btnSim.Click += btnSim_Click;
            // 
            // btnNao
            // 
            btnNao.Location = new Point(636, 542);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(142, 52);
            btnNao.TabIndex = 2;
            btnNao.Text = "NÃO";
            btnNao.UseVisualStyleBackColor = true;            
            btnNao.MouseEnter += btnNao_MouseEnter;
            // 
            // FRMTesteCorinthiano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1042, 655);
            Controls.Add(btnNao);
            Controls.Add(btnSim);
            Controls.Add(lblCorinthians);
            Controls.Add(pctCorinthians);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRMTesteCorinthiano";
            Text = "Teste Corinthiano";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pctCorinthians).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctCorinthians;
        private Label lblCorinthians;
        private Button btnSim;
        private Button btnNao;
    }
}
