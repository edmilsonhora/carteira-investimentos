﻿using ESH_CarteiraInvestimentos.ApplicationService;
using ESH_CarteiraInvestimentos.ApplicationService.Views;

namespace ESH_CarteiraInvestimentos.Win32
{
    public partial class Inicial : Form
    {
        private IFacade _facade;
        public Inicial()
        {
            _facade = new Facade();
            InitializeComponent();
            AtualizarCotacao();
            gridAtivos.AutoGenerateColumns = false;
            CarregarDropsTickers();
            CarregarGridAtivos();
            AtualizarData();
        }

        private void AtualizarCotacao()
        {
            _ = _facade.Cotacoes.ObterUltimasCotacoes();
        }

        private void AtualizarData()
        {
            var hoje = DateTime.Now;
            txtDataCompra.Value = hoje;
            txtDataProvento.Value = hoje;
            txtDataVenda.Value = hoje;
        }

        private void CarregarGridAtivos()
        {
            var lista = _facade.Ativos.ObterTodos();
            gridAtivos.DataSource = null;
            gridAtivos.DataSource = lista;
            lblTotalProvRecebidos.Text = lista.Sum(p => p.TotalProventos).ToString("C");
            lblTotalInvestido.Text = lista.Sum(p => p.TotalInvestido).ToString("C");
            lblTotalResgatado.Text = lista.Sum(p => p.TotalResgatado).ToString("C");
            lblTotalSaldoAtual.Text = lista.Sum(p => p.SaldoAtual).ToString("C");
            lblTotalGanhaPerde.Text = lista.Sum(p => p.GanhaPerde).ToString("C");
        }

        private void CarregarDropsTickers()
        {
            dropTicker.DataSource = _facade.Ativos.ObterTodos();
            dropTicker.DisplayMember = "Ticker";
            dropTicker.ValueMember = "Id";
            dropTicker.SelectedIndex = -1;

            dropTicker2.DataSource = _facade.Ativos.ObterTodos();
            dropTicker2.DisplayMember = "Ticker";
            dropTicker2.ValueMember = "Id";
            dropTicker2.SelectedIndex = -1;

            dropTicker3.DataSource = _facade.Ativos.ObterTodos();
            dropTicker3.DisplayMember = "Ticker";
            dropTicker3.ValueMember = "Id";
            dropTicker3.SelectedIndex = -1;
        }

        private AporteView ObterNovoAporte()
        {
            int qtdCompra = 0;
            decimal vlCompra = 0;

            int.TryParse(txtQuantidade.Value.ToString(), out qtdCompra);
            decimal.TryParse(textValorCompra.Text, out vlCompra);

            return new AporteView()
            {
                AtivoId = Convert.ToInt32(dropTicker.SelectedValue),
                DtCompra = txtDataCompra.Value,
                QtdCompra = qtdCompra,
                VlCompra = vlCompra
            };
        }

        private ProventoView ObterNovoProvento()
        {
            int qtdCotas = 0;
            decimal vlUnProvento = 0;

            int.TryParse(txtQuantidadeCotas.Value.ToString(), out qtdCotas);
            decimal.TryParse(textVlUnProvento.Text, out vlUnProvento);

            return new ProventoView()
            {
                AtivoId = Convert.ToInt32(dropTicker2.SelectedValue),
                Data = txtDataProvento.Value,
                VlUnProvento = vlUnProvento,
                QtdCotas = qtdCotas,
            };
        }

        private VendaView ObterNovaVenda()
        {
            int qtdCotas = 0;
            decimal vlUnVenda = 0;

            int.TryParse(txtQuantidadeCotasVenda.Value.ToString(), out qtdCotas);
            decimal.TryParse(textVlUnVenda.Text, out vlUnVenda);

            return new VendaView()
            {
                AtivoId = Convert.ToInt32(dropTicker3.SelectedValue),
                DtVenda = txtDataProvento.Value,
                VlVenda = vlUnVenda,
                QtdVenda = qtdCotas,
            };
        }
        private void LimparAporte()
        {
            dropTicker.SelectedIndex = -1;
            txtQuantidade.Value = 1;
            textValorCompra.Text = string.Empty;
        }

        private void LimparProvento()
        {
            dropTicker2.SelectedIndex = -1;
            txtQuantidadeCotas.Value = 1;
            textVlUnProvento.Text = string.Empty;
        }

        private void LimparVenda()
        {
            dropTicker3.SelectedIndex = -1;
            txtQuantidadeCotasVenda.Value = 1;
            textVlUnVenda.Text = string.Empty;
        }

        private void btnSalvarAportes_Click(object sender, EventArgs e)
        {
            try
            {
                AporteView view = ObterNovoAporte();

                _facade.Aportes.Salvar(view);
                _facade.SaveChanges();
                CarregarGridAtivos();
                LimparAporte();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarProventos_Click(object sender, EventArgs e)
        {
            try
            {
                ProventoView view = ObterNovoProvento();

                _facade.Proventos.Salvar(view);
                _facade.SaveChanges();
                CarregarGridAtivos();
                LimparProvento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Vendas_Click(object sender, EventArgs e)
        {
            try
            {
                VendaView view = ObterNovaVenda();

                _facade.Vendas.Salvar(view);
                _facade.SaveChanges();
                CarregarGridAtivos();
                LimparVenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridAtivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {


                if (Convert.ToDecimal(e.Value) < 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Green;
                }

                e.CellStyle.Format = "C";
            }
        }
    }
}
