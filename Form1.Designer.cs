namespace HenameNet
{
    partial class Form1
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
            txtDiretorio = new TextBox();
            btnSelecionarDiretorio = new Button();
            groupBox1 = new GroupBox();
            listArquivos = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiretorio
            // 
            txtDiretorio.BackColor = SystemColors.Control;
            txtDiretorio.Location = new Point(109, 12);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.PlaceholderText = "Selecione o diretório...";
            txtDiretorio.Size = new Size(837, 25);
            txtDiretorio.TabIndex = 1;
            // 
            // btnSelecionarDiretorio
            // 
            btnSelecionarDiretorio.Location = new Point(10, 12);
            btnSelecionarDiretorio.Name = "btnSelecionarDiretorio";
            btnSelecionarDiretorio.Size = new Size(93, 25);
            btnSelecionarDiretorio.TabIndex = 2;
            btnSelecionarDiretorio.Text = "Diretório";
            btnSelecionarDiretorio.UseVisualStyleBackColor = true;
            btnSelecionarDiretorio.Click += btnSelecionarDiretorio_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listArquivos);
            groupBox1.Location = new Point(10, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 242);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arquivos do diretório";
            // 
            // listArquivos
            // 
            listArquivos.Dock = DockStyle.Fill;
            listArquivos.FormattingEnabled = true;
            listArquivos.ItemHeight = 17;
            listArquivos.Location = new Point(3, 21);
            listArquivos.Name = "listArquivos";
            listArquivos.Size = new Size(930, 218);
            listArquivos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(958, 585);
            Controls.Add(groupBox1);
            Controls.Add(btnSelecionarDiretorio);
            Controls.Add(txtDiretorio);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDiretorio;
        private Button btnSelecionarDiretorio;
        private GroupBox groupBox1;
        private ListBox listArquivos;
    }
}
