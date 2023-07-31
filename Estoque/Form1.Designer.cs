namespace Estoque
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            txt_codigo = new TextBox();
            txt_descricao = new TextBox();
            txt_preco = new TextBox();
            txt_lucro = new TextBox();
            txt_venda = new TextBox();
            table_produtos = new DataGridView();
            list_cod = new DataGridViewTextBoxColumn();
            list_desc = new DataGridViewTextBoxColumn();
            list_valor = new DataGridViewTextBoxColumn();
            list_lucro = new DataGridViewTextBoxColumn();
            list_venda = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)table_produtos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Lucro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Valor de venda:";
            // 
            // button1
            // 
            button1.Location = new Point(5, 241);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 5;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 241);
            button2.Name = "button2";
            button2.Size = new Size(107, 31);
            button2.TabIndex = 6;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(67, 36);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(188, 23);
            txt_codigo.TabIndex = 7;
            // 
            // txt_descricao
            // 
            txt_descricao.Location = new Point(79, 74);
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(176, 23);
            txt_descricao.TabIndex = 8;
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(118, 110);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(137, 23);
            txt_preco.TabIndex = 9;
            // 
            // txt_lucro
            // 
            txt_lucro.Location = new Point(58, 149);
            txt_lucro.Name = "txt_lucro";
            txt_lucro.Size = new Size(197, 23);
            txt_lucro.TabIndex = 10;
            // 
            // txt_venda
            // 
            txt_venda.Enabled = false;
            txt_venda.Location = new Point(105, 178);
            txt_venda.Name = "txt_venda";
            txt_venda.Size = new Size(150, 23);
            txt_venda.TabIndex = 11;
            // 
            // table_produtos
            // 
            table_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_produtos.Columns.AddRange(new DataGridViewColumn[] { list_cod, list_desc, list_valor, list_lucro, list_venda });
            table_produtos.Cursor = Cursors.UpArrow;
            table_produtos.GridColor = SystemColors.ControlLightLight;
            table_produtos.Location = new Point(306, 12);
            table_produtos.Name = "table_produtos";
            table_produtos.RowTemplate.Height = 25;
            table_produtos.Size = new Size(548, 426);
            table_produtos.TabIndex = 12;
            // 
            // list_cod
            // 
            list_cod.HeaderText = "Cod";
            list_cod.Name = "list_cod";
            // 
            // list_desc
            // 
            list_desc.HeaderText = "Desc";
            list_desc.Name = "list_desc";
            // 
            // list_valor
            // 
            list_valor.HeaderText = "Valor";
            list_valor.Name = "list_valor";
            // 
            // list_lucro
            // 
            list_lucro.HeaderText = "Lucro";
            list_lucro.Name = "list_lucro";
            // 
            // list_venda
            // 
            list_venda.HeaderText = "Venda";
            list_venda.Name = "list_venda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 450);
            Controls.Add(table_produtos);
            Controls.Add(txt_venda);
            Controls.Add(txt_lucro);
            Controls.Add(txt_preco);
            Controls.Add(txt_descricao);
            Controls.Add(txt_codigo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)table_produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox txt_codigo;
        private TextBox txt_descricao;
        private TextBox txt_preco;
        private TextBox txt_lucro;
        private TextBox txt_venda;
        private DataGridView table_produtos;
        private DataGridViewTextBoxColumn list_cod;
        private DataGridViewTextBoxColumn list_desc;
        private DataGridViewTextBoxColumn list_valor;
        private DataGridViewTextBoxColumn list_lucro;
        private DataGridViewTextBoxColumn list_venda;
    }
}