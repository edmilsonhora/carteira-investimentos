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
            lblTotalInvestido = new Label();
            label11 = new Label();
            lblTotalProvRecebidos = new Label();
            label9 = new Label();
            gridAtivos = new DataGridView();
            Ticker = new DataGridViewTextBoxColumn();
            QtdTotal = new DataGridViewTextBoxColumn();
            TotalInvestido = new DataGridViewTextBoxColumn();
            PrecoMedio = new DataGridViewTextBoxColumn();
            TotalProventos = new DataGridViewTextBoxColumn();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAtivos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidadeCotas).BeginInit();
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
            groupBox1.Location = new Point(24, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aportes:";
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
            btnSalvarAportes.Location = new Point(660, 56);
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
            dropTicker.Location = new Point(22, 54);
            dropTicker.Name = "dropTicker";
            dropTicker.Size = new Size(153, 28);
            dropTicker.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblTotalInvestido);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(lblTotalProvRecebidos);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(gridAtivos);
            groupBox2.Location = new Point(26, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(873, 423);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ativos:";
            // 
            // lblTotalInvestido
            // 
            lblTotalInvestido.AutoSize = true;
            lblTotalInvestido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalInvestido.Location = new Point(141, 377);
            lblTotalInvestido.Name = "lblTotalInvestido";
            lblTotalInvestido.Size = new Size(138, 20);
            lblTotalInvestido.TabIndex = 8;
            lblTotalInvestido.Text = "[lblTotalInvestido]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 377);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 7;
            label11.Text = "Total Investido:";
            // 
            // lblTotalProvRecebidos
            // 
            lblTotalProvRecebidos.AutoSize = true;
            lblTotalProvRecebidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalProvRecebidos.Location = new Point(693, 380);
            lblTotalProvRecebidos.Name = "lblTotalProvRecebidos";
            lblTotalProvRecebidos.Size = new Size(176, 20);
            lblTotalProvRecebidos.TabIndex = 6;
            lblTotalProvRecebidos.Text = "[lblTotalProvRecebidos]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(533, 380);
            label9.Name = "label9";
            label9.Size = new Size(154, 20);
            label9.TabIndex = 5;
            label9.Text = "Total Prov. Recebidos:";
            // 
            // gridAtivos
            // 
            gridAtivos.AllowUserToAddRows = false;
            gridAtivos.AllowUserToDeleteRows = false;
            gridAtivos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gridAtivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAtivos.Columns.AddRange(new DataGridViewColumn[] { Ticker, QtdTotal, TotalInvestido, PrecoMedio, TotalProventos });
            gridAtivos.Location = new Point(19, 43);
            gridAtivos.Name = "gridAtivos";
            gridAtivos.ReadOnly = true;
            gridAtivos.RowHeadersWidth = 51;
            gridAtivos.RowTemplate.Height = 29;
            gridAtivos.Size = new Size(823, 313);
            gridAtivos.TabIndex = 0;
            // 
            // Ticker
            // 
            Ticker.DataPropertyName = "Ticker";
            Ticker.HeaderText = "Ticker";
            Ticker.MinimumWidth = 6;
            Ticker.Name = "Ticker";
            Ticker.ReadOnly = true;
            Ticker.Width = 125;
            // 
            // QtdTotal
            // 
            QtdTotal.DataPropertyName = "QtdTotal";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            QtdTotal.DefaultCellStyle = dataGridViewCellStyle1;
            QtdTotal.HeaderText = "Qtd. Total";
            QtdTotal.MinimumWidth = 6;
            QtdTotal.Name = "QtdTotal";
            QtdTotal.ReadOnly = true;
            QtdTotal.Width = 125;
            // 
            // TotalInvestido
            // 
            TotalInvestido.DataPropertyName = "TotalInvestido";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            TotalInvestido.DefaultCellStyle = dataGridViewCellStyle2;
            TotalInvestido.HeaderText = "Tot. Investido";
            TotalInvestido.MinimumWidth = 6;
            TotalInvestido.Name = "TotalInvestido";
            TotalInvestido.ReadOnly = true;
            TotalInvestido.Width = 155;
            // 
            // PrecoMedio
            // 
            PrecoMedio.DataPropertyName = "PrecoMedio";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            PrecoMedio.DefaultCellStyle = dataGridViewCellStyle3;
            PrecoMedio.HeaderText = "Preço Médio";
            PrecoMedio.MinimumWidth = 6;
            PrecoMedio.Name = "PrecoMedio";
            PrecoMedio.ReadOnly = true;
            PrecoMedio.Width = 125;
            // 
            // TotalProventos
            // 
            TotalProventos.DataPropertyName = "TotalProventos";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            TotalProventos.DefaultCellStyle = dataGridViewCellStyle4;
            TotalProventos.HeaderText = "Tot. Proventos";
            TotalProventos.MinimumWidth = 6;
            TotalProventos.Name = "TotalProventos";
            TotalProventos.ReadOnly = true;
            TotalProventos.Width = 155;
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
            groupBox3.Location = new Point(29, 573);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(875, 111);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Proventos:";
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
            btnSalvarProventos.Location = new Point(668, 56);
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
            dropTicker2.Location = new Point(22, 54);
            dropTicker2.Name = "dropTicker2";
            dropTicker2.Size = new Size(153, 28);
            dropTicker2.TabIndex = 0;
            // 
            // Inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 722);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Inicial";
            Text = "Inicial";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridAtivos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidadeCotas).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn Ticker;
        private DataGridViewTextBoxColumn QtdTotal;
        private DataGridViewTextBoxColumn TotalInvestido;
        private DataGridViewTextBoxColumn PrecoMedio;
        private DataGridViewTextBoxColumn TotalProventos;
        private Label lblTotalProvRecebidos;
        private Label label9;
        private Label lblTotalInvestido;
        private Label label11;
    }
}