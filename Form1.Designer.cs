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
            txtDiretorio.BackColor = Color.White;
            txtDiretorio.Enabled = false;
            txtDiretorio.Location = new Point(125, 10);
            txtDiretorio.Margin = new Padding(3, 2, 3, 2);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.PlaceholderText = "Selecione o diretório...";
            txtDiretorio.Size = new Size(956, 22);
            txtDiretorio.TabIndex = 1;
            // 
            // btnSelecionarDiretorio
            // 
            btnSelecionarDiretorio.Location = new Point(11, 10);
            btnSelecionarDiretorio.Margin = new Padding(3, 2, 3, 2);
            btnSelecionarDiretorio.Name = "btnSelecionarDiretorio";
            btnSelecionarDiretorio.Size = new Size(106, 21);
            btnSelecionarDiretorio.TabIndex = 2;
            btnSelecionarDiretorio.Text = "Diretório";
            btnSelecionarDiretorio.UseVisualStyleBackColor = true;
            btnSelecionarDiretorio.Click += btnSelecionarDiretorio_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listArquivos);
            groupBox1.Location = new Point(11, 35);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1070, 199);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arquivos do diretório";
            // 
            // listArquivos
            // 
            listArquivos.Dock = DockStyle.Fill;
            listArquivos.FormattingEnabled = true;
            listArquivos.ItemHeight = 14;
            listArquivos.Location = new Point(3, 17);
            listArquivos.Margin = new Padding(3, 2, 3, 2);
            listArquivos.Name = "listArquivos";
            listArquivos.Size = new Size(1064, 180);
            listArquivos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1095, 482);
            Controls.Add(groupBox1);
            Controls.Add(btnSelecionarDiretorio);
            Controls.Add(txtDiretorio);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
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
