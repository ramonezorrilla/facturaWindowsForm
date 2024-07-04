namespace facturaWindowsForm
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
            dataGridView1 = new DataGridView();
            ITEM = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            PU = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            btnguardar = new Button();
            btncancelar = new Button();
            btnborrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ITEM, CANTIDAD, DESCRIPCION, PU });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(680, 150);
            dataGridView1.TabIndex = 0;
            // 
            // ITEM
            // 
            ITEM.HeaderText = "ITEM";
            ITEM.Name = "ITEM";
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.Name = "CANTIDAD";
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.Name = "DESCRIPCION";
            // 
            // PU
            // 
            PU.HeaderText = "PU";
            PU.Name = "PU";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 192);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(680, 150);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellEndEdit += dataGridView2_CellEndEdit;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(605, 381);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "GUARDAR";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(503, 381);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "CANCELAR";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(392, 381);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(75, 23);
            btnborrar.TabIndex = 4;
            btnborrar.Text = "BORRAR";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnborrar);
            Controls.Add(btncancelar);
            Controls.Add(btnguardar);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ITEM;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn PU;
        private DataGridView dataGridView2;
        private Button btnguardar;
        private Button btncancelar;
        private Button btnborrar;
    }
}
