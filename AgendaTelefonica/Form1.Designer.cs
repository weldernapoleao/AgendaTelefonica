namespace AgendaTelefonica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label nomecontatoLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label ultimocontatoLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agendaDBDataSet = new AgendaTelefonica.AgendaDBDataSet();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatoTableAdapter = new AgendaTelefonica.AgendaDBDataSetTableAdapters.contatoTableAdapter();
            this.tableAdapterManager = new AgendaTelefonica.AgendaDBDataSetTableAdapters.TableAdapterManager();
            this.contatoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contatoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomecontatoTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.ultimocontatoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nomecontatoLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ultimocontatoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingNavigator)).BeginInit();
            this.contatoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(646, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // agendaDBDataSet
            // 
            this.agendaDBDataSet.DataSetName = "AgendaDBDataSet";
            this.agendaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataMember = "contato";
            this.contatoBindingSource.DataSource = this.agendaDBDataSet;
            // 
            // contatoTableAdapter
            // 
            this.contatoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.contatoTableAdapter = this.contatoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AgendaTelefonica.AgendaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contatoBindingNavigator
            // 
            this.contatoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contatoBindingNavigator.BindingSource = this.contatoBindingSource;
            this.contatoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contatoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contatoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contatoBindingNavigatorSaveItem});
            this.contatoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contatoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contatoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contatoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contatoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contatoBindingNavigator.Name = "contatoBindingNavigator";
            this.contatoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contatoBindingNavigator.Size = new System.Drawing.Size(821, 25);
            this.contatoBindingNavigator.TabIndex = 1;
            this.contatoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // contatoBindingNavigatorSaveItem
            // 
            this.contatoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contatoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contatoBindingNavigatorSaveItem.Image")));
            this.contatoBindingNavigatorSaveItem.Name = "contatoBindingNavigatorSaveItem";
            this.contatoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.contatoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.contatoBindingNavigatorSaveItem.Click += new System.EventHandler(this.contatoBindingNavigatorSaveItem_Click);
            // 
            // nomecontatoLabel
            // 
            nomecontatoLabel.AutoSize = true;
            nomecontatoLabel.Location = new System.Drawing.Point(98, 89);
            nomecontatoLabel.Name = "nomecontatoLabel";
            nomecontatoLabel.Size = new System.Drawing.Size(38, 13);
            nomecontatoLabel.TabIndex = 4;
            nomecontatoLabel.Text = "Nome:";
            nomecontatoLabel.Click += new System.EventHandler(this.nomecontatoLabel_Click);
            // 
            // nomecontatoTextBox
            // 
            this.nomecontatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "nomecontato", true));
            this.nomecontatoTextBox.Location = new System.Drawing.Point(177, 86);
            this.nomecontatoTextBox.Name = "nomecontatoTextBox";
            this.nomecontatoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomecontatoTextBox.TabIndex = 5;
            this.nomecontatoTextBox.TextChanged += new System.EventHandler(this.nomecontatoTextBox_TextChanged);
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(98, 115);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(51, 13);
            empresaLabel.TabIndex = 6;
            empresaLabel.Text = "Empresa:";
            empresaLabel.Click += new System.EventHandler(this.empresaLabel_Click);
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(177, 112);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.empresaTextBox.TabIndex = 7;
            this.empresaTextBox.TextChanged += new System.EventHandler(this.empresaTextBox_TextChanged);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(98, 141);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(38, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "E-mail:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(177, 138);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(98, 167);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 10;
            telefoneLabel.Text = "Telefone:";
            telefoneLabel.Click += new System.EventHandler(this.telefoneLabel_Click);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(177, 164);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneTextBox.TabIndex = 11;
            this.telefoneTextBox.TextChanged += new System.EventHandler(this.telefoneTextBox_TextChanged);
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(98, 195);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(54, 13);
            clienteLabel.TabIndex = 12;
            clienteLabel.Text = "É cliente?";
            clienteLabel.Click += new System.EventHandler(this.clienteLabel_Click);
            // 
            // clienteCheckBox
            // 
            this.clienteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contatoBindingSource, "cliente", true));
            this.clienteCheckBox.Location = new System.Drawing.Point(177, 190);
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.Size = new System.Drawing.Size(200, 24);
            this.clienteCheckBox.TabIndex = 13;
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            this.clienteCheckBox.CheckedChanged += new System.EventHandler(this.clienteCheckBox_CheckedChanged);
            // 
            // ultimocontatoLabel
            // 
            ultimocontatoLabel.AutoSize = true;
            ultimocontatoLabel.Location = new System.Drawing.Point(98, 224);
            ultimocontatoLabel.Name = "ultimocontatoLabel";
            ultimocontatoLabel.Size = new System.Drawing.Size(76, 13);
            ultimocontatoLabel.TabIndex = 14;
            ultimocontatoLabel.Text = "Ultimo Contato";
            ultimocontatoLabel.Click += new System.EventHandler(this.ultimocontatoLabel_Click);
            // 
            // ultimocontatoDateTimePicker
            // 
            this.ultimocontatoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contatoBindingSource, "ultimocontato", true));
            this.ultimocontatoDateTimePicker.Location = new System.Drawing.Point(177, 220);
            this.ultimocontatoDateTimePicker.Name = "ultimocontatoDateTimePicker";
            this.ultimocontatoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ultimocontatoDateTimePicker.TabIndex = 15;
            this.ultimocontatoDateTimePicker.ValueChanged += new System.EventHandler(this.ultimocontatoDateTimePicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 470);
            this.Controls.Add(nomecontatoLabel);
            this.Controls.Add(this.nomecontatoTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteCheckBox);
            this.Controls.Add(ultimocontatoLabel);
            this.Controls.Add(this.ultimocontatoDateTimePicker);
            this.Controls.Add(this.contatoBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingNavigator)).EndInit();
            this.contatoBindingNavigator.ResumeLayout(false);
            this.contatoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private AgendaDBDataSet agendaDBDataSet;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private AgendaDBDataSetTableAdapters.contatoTableAdapter contatoTableAdapter;
        private AgendaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contatoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contatoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomecontatoTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.DateTimePicker ultimocontatoDateTimePicker;
    }
}

