namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeExemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificadorDeNumeroImparOuParToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDeTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificadorDeIdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraDeIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validadorDeNumerosNegativospositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparadorDeNúmerosSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparadorDeNúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparadorDeNúmerosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.validadorDeNúmerosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraDeMédiaEscolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificadorCPFOuCNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.exerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // exerciciosToolStripMenuItem
            // 
            this.exerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWorldToolStripMenuItem,
            this.calculoDeExemploToolStripMenuItem,
            this.calculadoraSimplesToolStripMenuItem,
            this.verificadorDeNumeroImparOuParToolStripMenuItem,
            this.conversorDeTemperaturaToolStripMenuItem,
            this.verificadorDeIdadeToolStripMenuItem,
            this.calculadoraDeIMCToolStripMenuItem,
            this.validadorDeNumerosNegativospositivosToolStripMenuItem,
            this.comparadorDeNúmerosSimplesToolStripMenuItem,
            this.comparadorDeNúmerosToolStripMenuItem,
            this.comparadorDeNúmerosToolStripMenuItem1,
            this.validadorDeNúmerosPrimosToolStripMenuItem,
            this.calculadoraDeMédiaEscolarToolStripMenuItem,
            this.verificadorCPFOuCNPJToolStripMenuItem});
            this.exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            this.exerciciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exerciciosToolStripMenuItem.Text = "Exercicios";
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.helloWorldToolStripMenuItem.Text = "Hello world";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // calculoDeExemploToolStripMenuItem
            // 
            this.calculoDeExemploToolStripMenuItem.Name = "calculoDeExemploToolStripMenuItem";
            this.calculoDeExemploToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.calculoDeExemploToolStripMenuItem.Text = "Calculo de exemplo";
            this.calculoDeExemploToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // calculadoraSimplesToolStripMenuItem
            // 
            this.calculadoraSimplesToolStripMenuItem.Name = "calculadoraSimplesToolStripMenuItem";
            this.calculadoraSimplesToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.calculadoraSimplesToolStripMenuItem.Text = "Calculadora simples";
            this.calculadoraSimplesToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // verificadorDeNumeroImparOuParToolStripMenuItem
            // 
            this.verificadorDeNumeroImparOuParToolStripMenuItem.Name = "verificadorDeNumeroImparOuParToolStripMenuItem";
            this.verificadorDeNumeroImparOuParToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.verificadorDeNumeroImparOuParToolStripMenuItem.Text = "Verificador de numero impar ou par";
            this.verificadorDeNumeroImparOuParToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // conversorDeTemperaturaToolStripMenuItem
            // 
            this.conversorDeTemperaturaToolStripMenuItem.Name = "conversorDeTemperaturaToolStripMenuItem";
            this.conversorDeTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.conversorDeTemperaturaToolStripMenuItem.Text = "Conversor de Temperatura";
            this.conversorDeTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // verificadorDeIdadeToolStripMenuItem
            // 
            this.verificadorDeIdadeToolStripMenuItem.Name = "verificadorDeIdadeToolStripMenuItem";
            this.verificadorDeIdadeToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.verificadorDeIdadeToolStripMenuItem.Text = "Verificador de idade";
            this.verificadorDeIdadeToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // calculadoraDeIMCToolStripMenuItem
            // 
            this.calculadoraDeIMCToolStripMenuItem.Name = "calculadoraDeIMCToolStripMenuItem";
            this.calculadoraDeIMCToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.calculadoraDeIMCToolStripMenuItem.Text = "Calculadora de IMC";
            this.calculadoraDeIMCToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // validadorDeNumerosNegativospositivosToolStripMenuItem
            // 
            this.validadorDeNumerosNegativospositivosToolStripMenuItem.Name = "validadorDeNumerosNegativospositivosToolStripMenuItem";
            this.validadorDeNumerosNegativospositivosToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.validadorDeNumerosNegativospositivosToolStripMenuItem.Text = "Validador de numeros negativos/positivos";
            this.validadorDeNumerosNegativospositivosToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // comparadorDeNúmerosSimplesToolStripMenuItem
            // 
            this.comparadorDeNúmerosSimplesToolStripMenuItem.Name = "comparadorDeNúmerosSimplesToolStripMenuItem";
            this.comparadorDeNúmerosSimplesToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.comparadorDeNúmerosSimplesToolStripMenuItem.Text = "Comparador de números simples";
            this.comparadorDeNúmerosSimplesToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // comparadorDeNúmerosToolStripMenuItem
            // 
            this.comparadorDeNúmerosToolStripMenuItem.Name = "comparadorDeNúmerosToolStripMenuItem";
            this.comparadorDeNúmerosToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.comparadorDeNúmerosToolStripMenuItem.Text = "Comparador de números";
            this.comparadorDeNúmerosToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // comparadorDeNúmerosToolStripMenuItem1
            // 
            this.comparadorDeNúmerosToolStripMenuItem1.Name = "comparadorDeNúmerosToolStripMenuItem1";
            this.comparadorDeNúmerosToolStripMenuItem1.Size = new System.Drawing.Size(295, 22);
            this.comparadorDeNúmerosToolStripMenuItem1.Text = "Verificador de ano bissexto";
            // 
            // validadorDeNúmerosPrimosToolStripMenuItem
            // 
            this.validadorDeNúmerosPrimosToolStripMenuItem.Name = "validadorDeNúmerosPrimosToolStripMenuItem";
            this.validadorDeNúmerosPrimosToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.validadorDeNúmerosPrimosToolStripMenuItem.Text = "Validador de números primos";
            // 
            // calculadoraDeMédiaEscolarToolStripMenuItem
            // 
            this.calculadoraDeMédiaEscolarToolStripMenuItem.Name = "calculadoraDeMédiaEscolarToolStripMenuItem";
            this.calculadoraDeMédiaEscolarToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.calculadoraDeMédiaEscolarToolStripMenuItem.Text = "Calculadora de média escolar";
            // 
            // verificadorCPFOuCNPJToolStripMenuItem
            // 
            this.verificadorCPFOuCNPJToolStripMenuItem.Name = "verificadorCPFOuCNPJToolStripMenuItem";
            this.verificadorCPFOuCNPJToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.verificadorCPFOuCNPJToolStripMenuItem.Text = "Verificador CPF ou CNPJ";
            this.verificadorCPFOuCNPJToolStripMenuItem.Click += new System.EventHandler(this.on_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 425);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeExemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificadorDeNumeroImparOuParToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDeTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificadorDeIdadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraDeIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validadorDeNumerosNegativospositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparadorDeNúmerosSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparadorDeNúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparadorDeNúmerosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem validadorDeNúmerosPrimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraDeMédiaEscolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificadorCPFOuCNPJToolStripMenuItem;
    }
}

