using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Editor_De_Imagens.Classes;
using Editor_De_Imagens.Classes.Enumeradores;
using Editor_De_Imagens.Componentes;
using Editor_De_Imagens.Formularios.Ferramentas;
using Editor_De_Imagens.Formularios.Tarefas;
using Editor_De_Imagens.Servicos;

namespace Editor_De_Imagens.Formularios
{
    public partial class Principal : Form
    {
        private Trabalho _trabalho;
        private Zoom _zoom;

        public Principal()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _zoom = Zoom.Nenhum;
        }

        private void Visualiza(Image imagem)
        {
            pbImg.Image = imagem;
            SetaZoom(_zoom);

            if (_trabalho != null && _trabalho.ImagemDeTrabalho != null)
            {
                DefineLabels();
            }
        }

        public void DefineLabels()
        {
            lbTamanho.Text = string.Format("(Tamanho: {0} x {1}) (Resolução: {2} x {3}) (Formato pixel: {4}) (Dimensões físicas: {5} x {6})",
                _trabalho.ImagemDeTrabalho.Width,
                _trabalho.ImagemDeTrabalho.Height,
                _trabalho.ImagemDeTrabalho.HorizontalResolution,
                _trabalho.ImagemDeTrabalho.VerticalResolution,
                _trabalho.ImagemDeTrabalho.PixelFormat,
                _trabalho.ImagemDeTrabalho.PhysicalDimension.Width,
                _trabalho.ImagemDeTrabalho.PhysicalDimension.Height);
        }


        private void AbrirArquivo()
        {
            if (ofdAbrir.ShowDialog() != DialogResult.OK) return;

            try
            {
                Trabalho.TestarSuporte(new FileInfo(ofdAbrir.FileName));
                _trabalho = new Trabalho(new FileInfo(ofdAbrir.FileName), Visualiza);
                HabilitaMenus();
                DefineLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirGif()
        {
            var opengif = new OpenFileDialog() { Filter = "*.gif|*.gif" };

            if (opengif.ShowDialog() != DialogResult.OK) return;

            try
            {
                Trabalho.TestarSuporte(new FileInfo(opengif.FileName));
                Trabalho.VerificaSeGifPodeSerAnimado(new FileInfo(opengif.FileName));
                _trabalho = new Trabalho(new FileInfo(opengif.FileName), Visualiza);
                HabilitaMenus();
                DefineLabels();

                Cursor = Cursors.WaitCursor;
                _trabalho.DecomporGif();
                Cursor = Cursors.Default;
                _trabalho.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarArquivo()
        {
            if (sfdSalvar.ShowDialog() != DialogResult.OK) return;

            try
            {
                _trabalho.Salvar(new FileInfo(sfdSalvar.FileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetaZoom(Zoom zoom)
        {
            int fator;
            Size tamanho;

            switch (zoom)
            {
                case Zoom.AjustarAltura:
                    fator = -1;
                    break;
                case Zoom.AjustarLargura:
                    fator = -2;
                    break;
                case Zoom.AjustarCaber:
                    fator = 0;
                    break;
                case Zoom._10:
                    fator = 10;
                    break;
                case Zoom._25:
                    fator = 25;
                    break;
                case Zoom._50:
                    fator = 50;
                    break;
                case Zoom._75:
                    fator = 75;
                    break;
                case Zoom._150:
                    fator = 150;
                    break;
                case Zoom._200:
                    fator = 200;
                    break;
                case Zoom._500:
                    fator = 500;
                    break;
                case Zoom._750:
                    fator = 750;
                    break;
                case Zoom._1000:
                    fator = 1000;
                    break;
                default:
                    fator = 100;
                    break;
            }

            if (fator < 1)
            {
                if (fator == -1)
                {
                    tamanho = GestorDeCalculo.AjustarAltura(pbImg.Image.Size, pnBase.Bounds);
                }
                else if (fator == -2)
                {
                    tamanho = GestorDeCalculo.AjustarLargura(pbImg.Image.Size, pnBase.Bounds);
                }
                else
                {
                    tamanho = GestorDeCalculo.AjustarParaCaber(pbImg.Image.Size, pnBase.Bounds);
                }
            }
            else
            {
                tamanho = GestorDeCalculo.CalculaZoom(pbImg.Image.Size, fator);
            }

            pbImg.Size = tamanho;
        }

        private void HabilitaMenus()
        {
            salvacomoToolStripMenuItem.Enabled = imprimirToolStripMenuItem.Enabled = ferramentasToolStripMenuItem.Enabled = editarToolStripMenuItem.Enabled = filtrosPersonalizadosToolStripMenuItem.Enabled = inserirToolStripMenuItem.Enabled = tarefasToolStripMenuItem.Enabled = btnZoom.Enabled = true;
            ferramentasToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            editarToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            inserirToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            girarToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            inverterToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            filtroDeCorToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            btnZoom.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            filtrosPersonalizadosToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            tarefasToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().AsParallel().ForAll(t => t.Enabled = true);
            pluginsToolStripMenuItem.Enabled = true;
        }

        private void Principal_Load(object sender, System.EventArgs e)
        {
            Utils.Plugins = GestorDePlugIns.CarregarTodosPlugIns();

            int c = 0;

            foreach (var p in Utils.Plugins)
            {
                var info = p.GetInfo();
                var ts = new ToolStripPlugIn(info.Nome, info.Icone, c++, ClickPlugin);
                pluginsToolStripMenuItem.DropDownItems.Add(ts);
            }
        }

        private void ClickPlugin(object sender, EventArgs eventArgs)
        {
            var i = (sender as ToolStripPlugIn).IndexPlugin;
            try
            {
                _trabalho.RunPlugIn(Utils.Plugins[i]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao executar plug in!\n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AbrirArquivo();
        }

        private void negativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            _trabalho.AplicaNegativo();

            Cursor = Cursors.Default;

            _trabalho.Commit();

        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trabalho.Desfazer();
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trabalho.Refazer();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pdImpressora.ShowDialog() != DialogResult.OK) return;

            _trabalho.Imprimir(pdImpressora.PrinterSettings);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_trabalho != null)
            {
                var resposta = MessageBox.Show("Deseja salvar o trabalho atual?", "Documento aberto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resposta == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                if (resposta == DialogResult.Yes)
                    SalvarArquivo();
            }
        }

        private void salvacomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trabalho.CopiarParaClipBoard();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _trabalho.GirarInverter(RotateFlipType.Rotate90FlipNone);
            _trabalho.Commit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _trabalho.GirarInverter(RotateFlipType.Rotate180FlipNone);
            _trabalho.Commit();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _trabalho.GirarInverter(RotateFlipType.Rotate270FlipNone);
            _trabalho.Commit();
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trabalho.GirarInverter(RotateFlipType.RotateNoneFlipY);
            _trabalho.Commit();
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trabalho.GirarInverter(RotateFlipType.RotateNoneFlipX);
            _trabalho.Commit();
        }

        private void redimencionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRedimencionar(_trabalho).ShowDialog();
        }

        private void contrasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmContraste(_trabalho).ShowDialog();
        }

        private void brilhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBrilho(_trabalho).ShowDialog();
        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGamma(_trabalho).ShowDialog();
        }

        private void vermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _trabalho.FiltroCor(ColorFilterTypes.Red);
            Cursor = Cursors.Default;
            _trabalho.Commit();
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _trabalho.FiltroCor(ColorFilterTypes.Green);
            Cursor = Cursors.Default;
            _trabalho.Commit();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _trabalho.FiltroCor(ColorFilterTypes.Blue);
            Cursor = Cursors.Default;
            _trabalho.Commit();
        }

        private void escalaEmCinzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _trabalho.EscalaDeCinza();
            Cursor = Cursors.Default;
            _trabalho.Commit();
        }

        private void desfoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDesfoque(_trabalho).ShowDialog();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRecorte(_trabalho, WindowState).ShowDialog();
        }

        private void imagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirImagem(_trabalho).ShowDialog();
        }

        private void formaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirForma(_trabalho).ShowDialog();
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInserirTexto(_trabalho).ShowDialog();
        }

        private void filtrosPersonalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFiltroPersonalizado(_trabalho).ShowDialog();
        }


        private void Principal_Resize(object sender, EventArgs e)
        {
            if (pbImg.Image == null) return;

            SetaZoom(_zoom);
        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade não implementada (ainda)!");
        }

        private void executarEmLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade não implementada (ainda)!");
        }

        private void gravarMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade não implementada (ainda)!");
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._10;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._25;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._50;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._75;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._100;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._150;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._200;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._500;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._750;
            SetaZoom(_zoom);
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            _zoom = Zoom._1000;
            SetaZoom(_zoom);
        }

        private void ajustarParaCaberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _zoom = Zoom.AjustarCaber;
            SetaZoom(_zoom);
        }

        private void ajustarALarguraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _zoom = Zoom.AjustarLargura;
            SetaZoom(_zoom);
        }

        private void ajustarAAlturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _zoom = Zoom.AjustarAltura;
            SetaZoom(_zoom);
        }

        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var galeria = new frmGaleriaFiltros();

            if (galeria.ShowDialog() == DialogResult.OK)
            {
                new frmFiltroPersonalizado(_trabalho, galeria.Matriz).ShowDialog();
            }
        }

        private void fragmentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmFragmentar(_trabalho).ShowDialog();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmgirar = new frmGirar();

            if (frmgirar.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                _trabalho.GirarAngulacao(frmgirar.Angulo, frmgirar.Cor);
                Cursor = Cursors.Default;
                _trabalho.Commit();
            }
        }

        private void decomporGIFAnimadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirGif();
        }

        private void pixelizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPixelizar(_trabalho).ShowDialog();
        }
    }
}
