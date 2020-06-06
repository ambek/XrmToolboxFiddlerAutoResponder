namespace FiddlerAutoResponder
{
    partial class FiddlerAutoResponderPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.PathTextInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PathSelectButton = new System.Windows.Forms.Button();
            this.PathListBox = new System.Windows.Forms.CheckedListBox();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GetFilesButton = new System.Windows.Forms.Button();
            this.SaveButon = new System.Windows.Forms.Button();
            this.RulesDataGridView = new System.Windows.Forms.DataGridView();
            this.filesLabel = new System.Windows.Forms.Label();
            this.matchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ruleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1140, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path";
            // 
            // PathTextInput
            // 
            this.PathTextInput.Location = new System.Drawing.Point(84, 32);
            this.PathTextInput.Name = "PathTextInput";
            this.PathTextInput.Size = new System.Drawing.Size(343, 20);
            this.PathTextInput.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PathSelectButton
            // 
            this.PathSelectButton.Location = new System.Drawing.Point(433, 32);
            this.PathSelectButton.Name = "PathSelectButton";
            this.PathSelectButton.Size = new System.Drawing.Size(37, 20);
            this.PathSelectButton.TabIndex = 8;
            this.PathSelectButton.Text = "...";
            this.PathSelectButton.UseVisualStyleBackColor = true;
            this.PathSelectButton.Click += new System.EventHandler(this.PathSelectButton_Click);
            // 
            // PathListBox
            // 
            this.PathListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathListBox.FormattingEnabled = true;
            this.PathListBox.Location = new System.Drawing.Point(84, 84);
            this.PathListBox.Name = "PathListBox";
            this.PathListBox.Size = new System.Drawing.Size(386, 109);
            this.PathListBox.TabIndex = 9;
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(84, 58);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(79, 20);
            this.AddToListButton.TabIndex = 10;
            this.AddToListButton.Text = "Add";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(169, 58);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(79, 20);
            this.RemoveItemButton.TabIndex = 11;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Path list";
            // 
            // GetFilesButton
            // 
            this.GetFilesButton.Location = new System.Drawing.Point(84, 199);
            this.GetFilesButton.Name = "GetFilesButton";
            this.GetFilesButton.Size = new System.Drawing.Size(79, 20);
            this.GetFilesButton.TabIndex = 14;
            this.GetFilesButton.Text = "Get Files ";
            this.GetFilesButton.UseVisualStyleBackColor = true;
            this.GetFilesButton.Click += new System.EventHandler(this.GetFilesButton_Click);
            // 
            // SaveButon
            // 
            this.SaveButon.Location = new System.Drawing.Point(169, 199);
            this.SaveButon.Name = "SaveButon";
            this.SaveButon.Size = new System.Drawing.Size(114, 20);
            this.SaveButon.TabIndex = 15;
            this.SaveButon.Text = "Save to FARX";
            this.SaveButon.UseVisualStyleBackColor = true;
            this.SaveButon.Click += new System.EventHandler(this.SaveButon_Click);
            // 
            // RulesDataGridView
            // 
            this.RulesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesDataGridView.AutoGenerateColumns = false;
            this.RulesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.RulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.enabledDataGridViewCheckBoxColumn});
            this.RulesDataGridView.DataSource = this.ruleBindingSource;
            this.RulesDataGridView.Location = new System.Drawing.Point(84, 225);
            this.RulesDataGridView.Name = "RulesDataGridView";
            this.RulesDataGridView.Size = new System.Drawing.Size(1031, 195);
            this.RulesDataGridView.TabIndex = 18;
            // 
            // filesLabel
            // 
            this.filesLabel.AutoSize = true;
            this.filesLabel.Location = new System.Drawing.Point(15, 225);
            this.filesLabel.Name = "filesLabel";
            this.filesLabel.Size = new System.Drawing.Size(34, 13);
            this.filesLabel.TabIndex = 16;
            this.filesLabel.Text = "Rules";
            // 
            // matchDataGridViewTextBoxColumn
            // 
            this.matchDataGridViewTextBoxColumn.DataPropertyName = "Match";
            this.matchDataGridViewTextBoxColumn.HeaderText = "Match";
            this.matchDataGridViewTextBoxColumn.Name = "matchDataGridViewTextBoxColumn";
            this.matchDataGridViewTextBoxColumn.Width = 300;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.Width = 400;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.HeaderText = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            // 
            // ruleBindingSource
            // 
            this.ruleBindingSource.DataSource = typeof(FiddlerAutoResponder.Model.Rule);
            // 
            // FiddlerAutoResponderPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RulesDataGridView);
            this.Controls.Add(this.filesLabel);
            this.Controls.Add(this.SaveButon);
            this.Controls.Add(this.GetFilesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.PathListBox);
            this.Controls.Add(this.PathSelectButton);
            this.Controls.Add(this.PathTextInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "FiddlerAutoResponderPluginControl";
            this.Size = new System.Drawing.Size(1140, 444);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RulesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTextInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button PathSelectButton;
        private System.Windows.Forms.CheckedListBox PathListBox;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetFilesButton;
        private System.Windows.Forms.Button SaveButon;
        private System.Windows.Forms.DataGridView RulesDataGridView;
        private System.Windows.Forms.BindingSource ruleBindingSource;
        private System.Windows.Forms.Label filesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
    }
}
