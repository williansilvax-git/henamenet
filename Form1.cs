namespace HenameNet
{
    public partial class Form1 : Form
    {
        public string Diretorio { get; set; }
        public Form1()
        {
            InitializeComponent();
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
            var caminho = @"./backupFiles";
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
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
    }
}
