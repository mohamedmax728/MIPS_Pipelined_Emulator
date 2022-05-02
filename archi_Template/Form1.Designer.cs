namespace archi_Template
{
    partial class Form1
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
            this.runCyBtn = new System.Windows.Forms.Button();
            this.StartPCTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inialBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MemGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiplGrid = new System.Windows.Forms.DataGridView();
            this.valueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MipsRegGrid = new System.Windows.Forms.DataGridView();
            this.UserCodetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // runCyBtn
            // 
            this.runCyBtn.Location = new System.Drawing.Point(622, 534);
            this.runCyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.runCyBtn.Name = "runCyBtn";
            this.runCyBtn.Size = new System.Drawing.Size(169, 70);
            this.runCyBtn.TabIndex = 23;
            this.runCyBtn.Text = "Run 1 cycle";
            this.runCyBtn.UseVisualStyleBackColor = true;
            this.runCyBtn.Click += new System.EventHandler(this.runCycleBtn_Click);
            // 
            // StartPCTxt
            // 
            this.StartPCTxt.Location = new System.Drawing.Point(57, 554);
            this.StartPCTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartPCTxt.Name = "StartPCTxt";
            this.StartPCTxt.Size = new System.Drawing.Size(116, 24);
            this.StartPCTxt.TabIndex = 21;
            this.StartPCTxt.Text = "1000";
            this.StartPCTxt.TextChanged += new System.EventHandler(this.StartPCTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "PC:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // inialBtn
            // 
            this.inialBtn.Location = new System.Drawing.Point(290, 534);
            this.inialBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inialBtn.Name = "inialBtn";
            this.inialBtn.Size = new System.Drawing.Size(169, 70);
            this.inialBtn.TabIndex = 22;
            this.inialBtn.Text = "Inisialize";
            this.inialBtn.UseVisualStyleBackColor = true;
            this.inialBtn.Click += new System.EventHandler(this.inializeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1069, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data memory";
            // 
            // MemGrid
            // 
            this.MemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.MemGrid.Location = new System.Drawing.Point(1072, 68);
            this.MemGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemGrid.Name = "MemGrid";
            this.MemGrid.ReadOnly = true;
            this.MemGrid.Size = new System.Drawing.Size(281, 459);
            this.MemGrid.TabIndex = 18;
            this.MemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemoryGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(750, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pipline registers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "MIPS registers";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Register";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PiplGrid
            // 
            this.PiplGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiplGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.PiplGrid.Location = new System.Drawing.Point(754, 68);
            this.PiplGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PiplGrid.Name = "PiplGrid";
            this.PiplGrid.ReadOnly = true;
            this.PiplGrid.Size = new System.Drawing.Size(281, 459);
            this.PiplGrid.TabIndex = 14;
            // 
            // valueCol
            // 
            this.valueCol.HeaderText = "Value";
            this.valueCol.Name = "valueCol";
            this.valueCol.ReadOnly = true;
            // 
            // registerCol
            // 
            this.registerCol.HeaderText = "Register";
            this.registerCol.Name = "registerCol";
            this.registerCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "user code";
            // 
            // MipsRegGrid
            // 
            this.MipsRegGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MipsRegGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerCol,
            this.valueCol});
            this.MipsRegGrid.Location = new System.Drawing.Point(422, 68);
            this.MipsRegGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MipsRegGrid.Name = "MipsRegGrid";
            this.MipsRegGrid.ReadOnly = true;
            this.MipsRegGrid.Size = new System.Drawing.Size(282, 459);
            this.MipsRegGrid.TabIndex = 13;
            this.MipsRegGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MipsRegisterGrid_CellContentClick);
            // 
            // UserCodetxt
            // 
            this.UserCodetxt.Location = new System.Drawing.Point(19, 68);
            this.UserCodetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserCodetxt.Multiline = true;
            this.UserCodetxt.Name = "UserCodetxt";
            this.UserCodetxt.Size = new System.Drawing.Size(370, 458);
            this.UserCodetxt.TabIndex = 12;
            this.UserCodetxt.TextChanged += new System.EventHandler(this.UserCodetxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 646);
            this.Controls.Add(this.runCyBtn);
            this.Controls.Add(this.StartPCTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inialBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PiplGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MipsRegGrid);
            this.Controls.Add(this.UserCodetxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runCyBtn;
        private System.Windows.Forms.TextBox StartPCTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button inialBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView MemGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView PiplGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MipsRegGrid;
        private System.Windows.Forms.TextBox UserCodetxt;
    }
}

