namespace ESH_CarteiraInvestimentos.Win32
{
    partial class Inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            textValorCompra = new TextBox();
            btnSalvarAportes = new Button();
            txtQuantidade = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDataCompra = new DateTimePicker();
            label1 = new Label();
            dropTicker = new ComboBox();
            groupBox2 = new GroupBox();
            gridAtivos = new DataGridView();
            lblTotalProvRecebidos = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            textVlUnProvento = new TextBox();
            btnSalvarProventos = new Button();
            txtQuantidadeCotas = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDataProvento = new DateTimePicker();
            label8 = new Label();
            dropTicker2 = new ComboBox();
            TabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox4 = new GroupBox();
            textVlUnVenda = new TextBox();
            btnSalvar_Vendas = new Button();
            txtQuantidadeCotasVenda = new NumericUpDown();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtDataVenda = new DateTimePicker();
            label14 = new Label();
            dropTicker3 = new ComboBox();
            lblTotalInvestido = new Label();
            label11 = new Label();
            lblTotalResgatado = new Label();
            label16 = new Label();
            lblTotalSaldoAtual = new Label();
            label18 = new Label();
            Ticker = new DataGridViewTextBoxColumn();
            QtdTotal = new DataGridViewTextBoxColumn();
            TotalInvestido = new DataGridViewTextBoxColumn();
            PrecoMedio = new DataGridViewTextBoxColumn();
            TotalProventos = new DataGridViewTextBoxColumn();
            TotalResgatado = new DataGridViewTextBoxColumn();
            SaldoAtual = new DataGridViewTextBoxColumn();
            PercentualNaCarteira = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAtivos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidadeCotas).BeginInit();
            TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidadeCotasVenda).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textValorCompra);
            groupBox1.Controls.Add(btnSalvarAportes);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDataCompra);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dropTicker);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textValorCompra
            // 
            textValorCompra.Location = new Point(389, 55);
            textValorCompra.Name = "textValorCompra";
            textValorCompra.Size = new Size(125, 27);
            textValorCompra.TabIndex = 9;
            // 
            // btnSalvarAportes
            // 
            btnSalvarAportes.Location = new Point(661, 56);
            btnSalvarAportes.Name = "btnSalvarAportes";
            btnSalvarAportes.Size = new Size(94, 29);
            btnSalvarAportes.TabIndex = 8;
            btnSalvarAportes.Text = "Salvar";
            btnSalvarAportes.UseVisualStyleBackColor = true;
            btnSalvarAportes.Click += btnSalvarAportes_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(537, 55);
            txtQuantidade.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(91, 27);
            txtQuantidade.TabIndex = 7;
            txtQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 27);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Quant.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 27);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 4;
            label3.Text = "Valor Compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 27);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Data Compra:";
            // 
            // txtDataCompra
            // 
            txtDataCompra.Format = DateTimePickerFormat.Short;
            txtDataCompra.Location = new Point(194, 55);
            txtDataCompra.Name = "txtDataCompra";
            txtDataCompra.Size = new Size(157, 27);
            txtDataCompra.TabIndex = 2;
            txtDataCompra.Value = new DateTime(2023, 4, 21, 19, 46, 29, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Ticker:";
            // 
            // dropTicker
            // 
            dropTicker.FormattingEnabled = true;
            dropTicker.Location = new Point(22, 53);
            dropTicker.Name = "dropTicker";
            dropTicker.Size = new Size(153, 28);
            dropTicker.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(gridAtivos);
            groupBox2.Location = new Point(26, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1156, 387);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ativos:";
            // 
            // gridAtivos
            // 
            gridAtivos.AllowUserToAddRows = false;
            gridAtivos.AllowUserToDeleteRows = false;
            gridAtivos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridAtivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAtivos.Columns.AddRange(new DataGridViewColumn[] { Ticker, QtdTotal, TotalInvestido, PrecoMedio, TotalProventos, TotalResgatado, SaldoAtual, PercentualNaCarteira });
            gridAtivos.Location = new Point(19, 43);
            gridAtivos.Name = "gridAtivos";
            gridAtivos.ReadOnly = true;
            gridAtivos.RowHeadersWidth = 51;
            gridAtivos.RowTemplate.Height = 29;
            gridAtivos.Size = new Size(1106, 313);
            gridAtivos.TabIndex = 0;
            // 
            // lblTotalProvRecebidos
            // 
            lblTotalProvRecebidos.AutoSize = true;
            lblTotalProvRecebidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalProvRecebidos.Location = new Point(205, 649);
            lblTotalProvRecebidos.Name = "lblTotalProvRecebidos";
            lblTotalProvRecebidos.Size = new Size(176, 20);
            lblTotalProvRecebidos.TabIndex = 6;
            lblTotalProvRecebidos.Text = "[lblTotalProvRecebidos]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 649);
            label9.Name = "label9";
            label9.Size = new Size(154, 20);
            label9.TabIndex = 5;
            label9.Text = "Total Prov. Recebidos:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textVlUnProvento);
            groupBox3.Controls.Add(btnSalvarProventos);
            groupBox3.Controls.Add(txtQuantidadeCotas);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtDataProvento);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dropTicker2);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(831, 111);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // textVlUnProvento
            // 
            textVlUnProvento.Location = new Point(389, 55);
            textVlUnProvento.Name = "textVlUnProvento";
            textVlUnProvento.Size = new Size(125, 27);
            textVlUnProvento.TabIndex = 9;
            // 
            // btnSalvarProventos
            // 
            btnSalvarProventos.Location = new Point(667, 56);
            btnSalvarProventos.Name = "btnSalvarProventos";
            btnSalvarProventos.Size = new Size(94, 29);
            btnSalvarProventos.TabIndex = 8;
            btnSalvarProventos.Text = "Salvar";
            btnSalvarProventos.UseVisualStyleBackColor = true;
            btnSalvarProventos.Click += btnSalvarProventos_Click;
            // 
            // txtQuantidadeCotas
            // 
            txtQuantidadeCotas.Location = new Point(537, 55);
            txtQuantidadeCotas.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            txtQuantidadeCotas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantidadeCotas.Name = "txtQuantidadeCotas";
            txtQuantidadeCotas.Size = new Size(91, 27);
            txtQuantidadeCotas.TabIndex = 7;
            txtQuantidadeCotas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 27);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 6;
            label5.Text = "Quant. Cotas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 27);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 4;
            label6.Text = "Valor Un. Prov.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(194, 27);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 3;
            label7.Text = "Data Provento:";
            // 
            // txtDataProvento
            // 
            txtDataProvento.Format = DateTimePickerFormat.Short;
            txtDataProvento.Location = new Point(194, 55);
            txtDataProvento.Name = "txtDataProvento";
            txtDataProvento.Size = new Size(157, 27);
            txtDataProvento.TabIndex = 2;
            txtDataProvento.Value = new DateTime(2023, 4, 21, 19, 46, 29, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 27);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 1;
            label8.Text = "Ticker:";
            // 
            // dropTicker2
            // 
            dropTicker2.FormattingEnabled = true;
            dropTicker2.Location = new Point(22, 53);
            dropTicker2.Name = "dropTicker2";
            dropTicker2.Size = new Size(153, 28);
            dropTicker2.TabIndex = 0;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Controls.Add(tabPage3);
            TabControl1.Location = new Point(15, 16);
            TabControl1.Margin = new Padding(3, 4, 3, 4);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(885, 173);
            TabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(877, 140);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Aportes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(877, 140);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Proventos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(877, 140);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Vendas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(textVlUnVenda);
            groupBox4.Controls.Add(btnSalvar_Vendas);
            groupBox4.Controls.Add(txtQuantidadeCotasVenda);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtDataVenda);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(dropTicker3);
            groupBox4.Location = new Point(3, 7);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(834, 113);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // textVlUnVenda
            // 
            textVlUnVenda.Location = new Point(389, 55);
            textVlUnVenda.Name = "textVlUnVenda";
            textVlUnVenda.Size = new Size(125, 27);
            textVlUnVenda.TabIndex = 9;
            // 
            // btnSalvar_Vendas
            // 
            btnSalvar_Vendas.Location = new Point(661, 56);
            btnSalvar_Vendas.Name = "btnSalvar_Vendas";
            btnSalvar_Vendas.Size = new Size(94, 29);
            btnSalvar_Vendas.TabIndex = 8;
            btnSalvar_Vendas.Text = "Salvar";
            btnSalvar_Vendas.UseVisualStyleBackColor = true;
            btnSalvar_Vendas.Click += btnSalvar_Vendas_Click;
            // 
            // txtQuantidadeCotasVenda
            // 
            txtQuantidadeCotasVenda.Location = new Point(537, 55);
            txtQuantidadeCotasVenda.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            txtQuantidadeCotasVenda.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantidadeCotasVenda.Name = "txtQuantidadeCotasVenda";
            txtQuantidadeCotasVenda.Size = new Size(91, 27);
            txtQuantidadeCotasVenda.TabIndex = 7;
            txtQuantidadeCotasVenda.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(538, 25);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 6;
            label10.Text = "Quant. Venda:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(389, 25);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 4;
            label12.Text = "Vl Un. Venda:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(194, 25);
            label13.Name = "label13";
            label13.Size = new Size(89, 20);
            label13.TabIndex = 3;
            label13.Text = "Data Venda:";
            // 
            // txtDataVenda
            // 
            txtDataVenda.Format = DateTimePickerFormat.Short;
            txtDataVenda.Location = new Point(194, 55);
            txtDataVenda.Name = "txtDataVenda";
            txtDataVenda.Size = new Size(157, 27);
            txtDataVenda.TabIndex = 2;
            txtDataVenda.Value = new DateTime(2023, 4, 21, 19, 46, 29, 0);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 25);
            label14.Name = "label14";
            label14.Size = new Size(51, 20);
            label14.TabIndex = 1;
            label14.Text = "Ticker:";
            // 
            // dropTicker3
            // 
            dropTicker3.FormattingEnabled = true;
            dropTicker3.Location = new Point(22, 53);
            dropTicker3.Name = "dropTicker3";
            dropTicker3.Size = new Size(153, 28);
            dropTicker3.TabIndex = 0;
            // 
            // lblTotalInvestido
            // 
            lblTotalInvestido.AutoSize = true;
            lblTotalInvestido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalInvestido.Location = new Point(205, 615);
            lblTotalInvestido.Name = "lblTotalInvestido";
            lblTotalInvestido.Size = new Size(138, 20);
            lblTotalInvestido.TabIndex = 10;
            lblTotalInvestido.Text = "[lblTotalInvestido]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 615);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 9;
            label11.Text = "Total Investido:";
            // 
            // lblTotalResgatado
            // 
            lblTotalResgatado.AutoSize = true;
            lblTotalResgatado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalResgatado.Location = new Point(205, 689);
            lblTotalResgatado.Name = "lblTotalResgatado";
            lblTotalResgatado.Size = new Size(147, 20);
            lblTotalResgatado.TabIndex = 12;
            lblTotalResgatado.Text = "[lblTotalResgatado]";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(35, 689);
            label16.Name = "label16";
            label16.Size = new Size(120, 20);
            label16.TabIndex = 11;
            label16.Text = "Total Resgatado:";
            // 
            // lblTotalSaldoAtual
            // 
            lblTotalSaldoAtual.AutoSize = true;
            lblTotalSaldoAtual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalSaldoAtual.Location = new Point(205, 729);
            lblTotalSaldoAtual.Name = "lblTotalSaldoAtual";
            lblTotalSaldoAtual.Size = new Size(149, 20);
            lblTotalSaldoAtual.TabIndex = 14;
            lblTotalSaldoAtual.Text = "[lblTotalSaldoAtual]";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(35, 729);
            label18.Name = "label18";
            label18.Size = new Size(126, 20);
            label18.TabIndex = 13;
            label18.Text = "Total Saldo Atual:";
            // 
            // Ticker
            // 
            Ticker.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Ticker.DataPropertyName = "Ticker";
            Ticker.HeaderText = "Ticker";
            Ticker.MinimumWidth = 6;
            Ticker.Name = "Ticker";
            Ticker.ReadOnly = true;
            Ticker.Width = 77;
            // 
            // QtdTotal
            // 
            QtdTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            QtdTotal.DataPropertyName = "QtdTotal";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            QtdTotal.DefaultCellStyle = dataGridViewCellStyle1;
            QtdTotal.HeaderText = "Qtd. Total";
            QtdTotal.MinimumWidth = 6;
            QtdTotal.Name = "QtdTotal";
            QtdTotal.ReadOnly = true;
            QtdTotal.Width = 103;
            // 
            // TotalInvestido
            // 
            TotalInvestido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalInvestido.DataPropertyName = "TotalInvestido";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            TotalInvestido.DefaultCellStyle = dataGridViewCellStyle2;
            TotalInvestido.HeaderText = "Tot. Investido";
            TotalInvestido.MinimumWidth = 6;
            TotalInvestido.Name = "TotalInvestido";
            TotalInvestido.ReadOnly = true;
            TotalInvestido.Width = 126;
            // 
            // PrecoMedio
            // 
            PrecoMedio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PrecoMedio.DataPropertyName = "PrecoMedio";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            PrecoMedio.DefaultCellStyle = dataGridViewCellStyle3;
            PrecoMedio.HeaderText = "Preço Médio";
            PrecoMedio.MinimumWidth = 6;
            PrecoMedio.Name = "PrecoMedio";
            PrecoMedio.ReadOnly = true;
            PrecoMedio.Width = 122;
            // 
            // TotalProventos
            // 
            TotalProventos.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalProventos.DataPropertyName = "TotalProventos";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            TotalProventos.DefaultCellStyle = dataGridViewCellStyle4;
            TotalProventos.HeaderText = "Tot. Proventos";
            TotalProventos.MinimumWidth = 6;
            TotalProventos.Name = "TotalProventos";
            TotalProventos.ReadOnly = true;
            TotalProventos.Width = 131;
            // 
            // TotalResgatado
            // 
            TotalResgatado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalResgatado.DataPropertyName = "TotalResgatado";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            TotalResgatado.DefaultCellStyle = dataGridViewCellStyle5;
            TotalResgatado.HeaderText = "Tot. Resgate";
            TotalResgatado.MinimumWidth = 6;
            TotalResgatado.Name = "TotalResgatado";
            TotalResgatado.ReadOnly = true;
            TotalResgatado.Width = 119;
            // 
            // SaldoAtual
            // 
            SaldoAtual.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SaldoAtual.DataPropertyName = "SaldoAtual";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            SaldoAtual.DefaultCellStyle = dataGridViewCellStyle6;
            SaldoAtual.HeaderText = "Saldo Atual";
            SaldoAtual.MinimumWidth = 6;
            SaldoAtual.Name = "SaldoAtual";
            SaldoAtual.ReadOnly = true;
            SaldoAtual.Width = 115;
            // 
            // PercentualNaCarteira
            // 
            PercentualNaCarteira.DataPropertyName = "PercentualNaCarteira";
            PercentualNaCarteira.HeaderText = "Percent (%)";
            PercentualNaCarteira.MinimumWidth = 6;
            PercentualNaCarteira.Name = "PercentualNaCarteira";
            PercentualNaCarteira.ReadOnly = true;
            PercentualNaCarteira.Width = 125;
            // 
            // Inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 781);
            Controls.Add(lblTotalSaldoAtual);
            Controls.Add(label18);
            Controls.Add(lblTotalResgatado);
            Controls.Add(label16);
            Controls.Add(lblTotalProvRecebidos);
            Controls.Add(lblTotalInvestido);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(TabControl1);
            Controls.Add(groupBox2);
            Name = "Inicial";
            Text = "Inicial";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAtivos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidadeCotas).EndInit();
            TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidadeCotasVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvarAportes;
        private NumericUpDown txtQuantidade;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker txtDataCompra;
        private Label label1;
        private ComboBox dropTicker;
        private GroupBox groupBox2;
        private DataGridView gridAtivos;
        private TextBox textValorCompra;
        private GroupBox groupBox3;
        private TextBox textVlUnProvento;
        private Button btnSalvarProventos;
        private NumericUpDown txtQuantidadeCotas;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker txtDataProvento;
        private Label label8;
        private ComboBox dropTicker2;
        private Label lblTotalProvRecebidos;
        private Label label9;
        private TabControl TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private TextBox textVlUnVenda;
        private Button btnSalvar_Vendas;
        private NumericUpDown txtQuantidadeCotasVenda;
        private Label label10;
        private Label label12;
        private Label label13;
        private DateTimePicker txtDataVenda;
        private Label label14;
        private ComboBox dropTicker3;
        private Label lblTotalInvestido;
        private Label label11;
        private Label lblTotalResgatado;
        private Label label16;
        private Label lblTotalSaldoAtual;
        private Label label18;
        private DataGridViewTextBoxColumn Ticker;
        private DataGridViewTextBoxColumn QtdTotal;
        private DataGridViewTextBoxColumn TotalInvestido;
        private DataGridViewTextBoxColumn PrecoMedio;
        private DataGridViewTextBoxColumn TotalProventos;
        private DataGridViewTextBoxColumn TotalResgatado;
        private DataGridViewTextBoxColumn SaldoAtual;
        private DataGridViewTextBoxColumn PercentualNaCarteira;
    }
}