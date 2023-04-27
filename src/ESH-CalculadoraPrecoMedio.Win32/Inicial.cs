using ESH_CalculadoraPrecoMedio.ApplicationService;
using ESH_CalculadoraPrecoMedio.ApplicationService.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESH_CalculadoraPrecoMedio.Win32
{
    public partial class Inicial : Form
    {
        private IFacade _facade;
        public Inicial()
        {
            _facade = new Facade();
            InitializeComponent();
            gridAtivos.AutoGenerateColumns = false;
            CarregarDropsTickers();
            CarregarGridAtivos();
        }

        private void CarregarGridAtivos()
        {
            gridAtivos.DataSource = null;
            gridAtivos.DataSource = _facade.Ativos.ObterTodos();

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
    }
}
