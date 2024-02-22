namespace HenameNet
{
    public partial class Form1 : Form
    {
        public string? Diretorio { get; set; }
        public string? DiretorioBackup { get; set; }
        public Form1()
        {
            InitializeComponent();
            string? exeDiretorio = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (exeDiretorio != null)
            {
                DiretorioBackup = Path.Combine(exeDiretorio, "backupFiles");
            }
        }

        private List<string> GetFilesDiretorio(string diretorio)
        {
            List<string> files = new List<string>();
            DirectoryInfo dinfo = new DirectoryInfo(diretorio);

            foreach (var file in dinfo.GetFiles())
            {
                files.Add(file.Name);
            }

            return files;
        }

        private void BackupManager()
        {
            if (!Directory.Exists(Diretorio))
            {
                MessageBox.Show("Diretório de origem não existe!");
                return;
            }

            if (!Directory.Exists(DiretorioBackup))
            {
                Directory.CreateDirectory(DiretorioBackup);
            }

            string[] arquivos = Directory.GetFiles(Diretorio);

            foreach (string arquivo in arquivos)
            {
                string nomeArquivo = Path.GetFileName(arquivo);
                string caminhoDestino = Path.Combine(DiretorioBackup, nomeArquivo);

                File.Copy(arquivo, caminhoDestino);
            }
        }

        private void btnSelecionarDiretorio_Click(object sender, EventArgs e)
        {
            txtDiretorio.Enabled = true;
            txtDiretorio.Text = "";
            listArquivos.Items.Clear();

            if (txtDiretorio.Text == "")
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Selecione o diretório";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Diretorio = dialog.SelectedPath;
                        txtDiretorio.Text = Diretorio;
                    }
                }
            }
            else
            {
                Diretorio = txtDiretorio.Text;
            }

            txtDiretorio.Enabled = false;

            GetFilesDiretorio(Diretorio).ForEach(fi => listArquivos.Items.Add(fi));
            BackupManager();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists(DiretorioBackup))
            {
                Directory.Delete(DiretorioBackup, true);
            }
        }
    }
}
