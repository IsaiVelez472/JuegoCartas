namespace JuegoCartas
{
    partial class Frmjuego
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
            ListViewItem listViewItem1 = new ListViewItem("", 0);
            ListViewItem listViewItem2 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmjuego));
            toolStrip1 = new ToolStrip();
            BtnRepartir = new ToolStripButton();
            BtnVerificar = new ToolStripButton();
            TcJugadores = new TabControl();
            tabPage1 = new TabPage();
            lvJugador1 = new ListView();
            IlCartas = new ImageList(components);
            tabPage2 = new TabPage();
            lvJugador2 = new ListView();
            toolStrip1.SuspendLayout();
            TcJugadores.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnRepartir, BtnVerificar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 135);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // BtnRepartir
            // 
            BtnRepartir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnRepartir.Image = Properties.Resources.Icon;
            BtnRepartir.ImageScaling = ToolStripItemImageScaling.None;
            BtnRepartir.ImageTransparentColor = Color.Magenta;
            BtnRepartir.Name = "BtnRepartir";
            BtnRepartir.Size = new Size(132, 132);
            BtnRepartir.Text = "toolStripButton1";
            BtnRepartir.ToolTipText = "Repartir";
            BtnRepartir.Click += btnRepartir_Click;
            // 
            // BtnVerificar
            // 
            BtnVerificar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnVerificar.Image = Properties.Resources.Check;
            BtnVerificar.ImageScaling = ToolStripItemImageScaling.None;
            BtnVerificar.ImageTransparentColor = Color.Magenta;
            BtnVerificar.Name = "BtnVerificar";
            BtnVerificar.Size = new Size(132, 132);
            BtnVerificar.Text = "toolStripButton1";
            BtnVerificar.ToolTipText = "Verificar Grupos";
            BtnVerificar.Click += BtnVerificar_Click;
            // 
            // TcJugadores
            // 
            TcJugadores.Controls.Add(tabPage1);
            TcJugadores.Controls.Add(tabPage2);
            TcJugadores.Dock = DockStyle.Fill;
            TcJugadores.Location = new Point(0, 135);
            TcJugadores.Name = "TcJugadores";
            TcJugadores.SelectedIndex = 0;
            TcJugadores.Size = new Size(800, 315);
            TcJugadores.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.IndianRed;
            tabPage1.Controls.Add(lvJugador1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 287);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Jugador 1";
            // 
            // lvJugador1
            // 
            lvJugador1.Dock = DockStyle.Fill;
            lvJugador1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvJugador1.LargeImageList = IlCartas;
            lvJugador1.Location = new Point(3, 3);
            lvJugador1.Name = "lvJugador1";
            lvJugador1.Size = new Size(786, 281);
            lvJugador1.TabIndex = 0;
            lvJugador1.UseCompatibleStateImageBehavior = false;
            // 
            // IlCartas
            // 
            IlCartas.ColorDepth = ColorDepth.Depth32Bit;
            IlCartas.ImageStream = (ImageListStreamer)resources.GetObject("IlCartas.ImageStream");
            IlCartas.TransparentColor = Color.Transparent;
            IlCartas.Images.SetKeyName(0, "CARTA1.JPG");
            IlCartas.Images.SetKeyName(1, "CARTA2.JPG");
            IlCartas.Images.SetKeyName(2, "CARTA3.JPG");
            IlCartas.Images.SetKeyName(3, "CARTA4.JPG");
            IlCartas.Images.SetKeyName(4, "CARTA5.JPG");
            IlCartas.Images.SetKeyName(5, "CARTA6.JPG");
            IlCartas.Images.SetKeyName(6, "CARTA7.JPG");
            IlCartas.Images.SetKeyName(7, "CARTA8.JPG");
            IlCartas.Images.SetKeyName(8, "CARTA9.JPG");
            IlCartas.Images.SetKeyName(9, "CARTA10.JPG");
            IlCartas.Images.SetKeyName(10, "CARTA11.JPG");
            IlCartas.Images.SetKeyName(11, "CARTA12.JPG");
            IlCartas.Images.SetKeyName(12, "CARTA13.JPG");
            IlCartas.Images.SetKeyName(13, "CARTA14.JPG");
            IlCartas.Images.SetKeyName(14, "CARTA15.JPG");
            IlCartas.Images.SetKeyName(15, "CARTA16.JPG");
            IlCartas.Images.SetKeyName(16, "CARTA17.JPG");
            IlCartas.Images.SetKeyName(17, "CARTA18.JPG");
            IlCartas.Images.SetKeyName(18, "CARTA19.JPG");
            IlCartas.Images.SetKeyName(19, "CARTA20.JPG");
            IlCartas.Images.SetKeyName(20, "CARTA21.JPG");
            IlCartas.Images.SetKeyName(21, "CARTA22.JPG");
            IlCartas.Images.SetKeyName(22, "CARTA23.JPG");
            IlCartas.Images.SetKeyName(23, "CARTA24.JPG");
            IlCartas.Images.SetKeyName(24, "CARTA25.JPG");
            IlCartas.Images.SetKeyName(25, "CARTA26.JPG");
            IlCartas.Images.SetKeyName(26, "CARTA27.JPG");
            IlCartas.Images.SetKeyName(27, "CARTA28.JPG");
            IlCartas.Images.SetKeyName(28, "CARTA29.JPG");
            IlCartas.Images.SetKeyName(29, "CARTA30.JPG");
            IlCartas.Images.SetKeyName(30, "CARTA31.JPG");
            IlCartas.Images.SetKeyName(31, "CARTA32.JPG");
            IlCartas.Images.SetKeyName(32, "CARTA33.JPG");
            IlCartas.Images.SetKeyName(33, "CARTA34.JPG");
            IlCartas.Images.SetKeyName(34, "CARTA35.JPG");
            IlCartas.Images.SetKeyName(35, "CARTA36.JPG");
            IlCartas.Images.SetKeyName(36, "CARTA37.JPG");
            IlCartas.Images.SetKeyName(37, "CARTA38.JPG");
            IlCartas.Images.SetKeyName(38, "CARTA39.JPG");
            IlCartas.Images.SetKeyName(39, "CARTA40.JPG");
            IlCartas.Images.SetKeyName(40, "CARTA41.JPG");
            IlCartas.Images.SetKeyName(41, "CARTA42.JPG");
            IlCartas.Images.SetKeyName(42, "CARTA43.JPG");
            IlCartas.Images.SetKeyName(43, "CARTA44.JPG");
            IlCartas.Images.SetKeyName(44, "CARTA45.JPG");
            IlCartas.Images.SetKeyName(45, "CARTA46.JPG");
            IlCartas.Images.SetKeyName(46, "CARTA47.JPG");
            IlCartas.Images.SetKeyName(47, "CARTA48.JPG");
            IlCartas.Images.SetKeyName(48, "CARTA49.JPG");
            IlCartas.Images.SetKeyName(49, "Carta50.JPG");
            IlCartas.Images.SetKeyName(50, "CARTA51.JPG");
            IlCartas.Images.SetKeyName(51, "CARTA52.JPG");
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Salmon;
            tabPage2.Controls.Add(lvJugador2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 287);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Jugador 2";
            // 
            // lvJugador2
            // 
            lvJugador2.Dock = DockStyle.Fill;
            lvJugador2.LargeImageList = IlCartas;
            lvJugador2.Location = new Point(3, 3);
            lvJugador2.Name = "lvJugador2";
            lvJugador2.Size = new Size(786, 281);
            lvJugador2.TabIndex = 0;
            lvJugador2.UseCompatibleStateImageBehavior = false;
            // 
            // Frmjuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TcJugadores);
            Controls.Add(toolStrip1);
            Name = "Frmjuego";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            TcJugadores.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton BtnRepartir;
        private ToolStripButton BtnVerificar;
        private TabControl TcJugadores;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList IlCartas;
        private ListView lvJugador1;
        private ListView lvJugador2;
    }
}
