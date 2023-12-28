namespace HizTesti
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
            btnEntity = new Button();
            dataGridView1 = new DataGridView();
            btnDapper = new Button();
            btnTemizle = new Button();
            lblDapperTime = new Label();
            lblEFTime = new Label();
            txtProductName = new TextBox();
            txtStock = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnEkleEF = new Button();
            btnGuncelleEF = new Button();
            btnEkleDapper = new Button();
            btnGuncelleDapper = new Button();
            lblEkleEF = new Label();
            lblGuncelleEF = new Label();
            lblEkleDapper = new Label();
            lblGuncelleDapper = new Label();
            txtId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEntity
            // 
            btnEntity.Location = new Point(12, 12);
            btnEntity.Name = "btnEntity";
            btnEntity.Size = new Size(102, 48);
            btnEntity.TabIndex = 0;
            btnEntity.Text = "EF ile Listele";
            btnEntity.UseVisualStyleBackColor = true;
            btnEntity.Click += btnEntity_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(395, 451);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDapper
            // 
            btnDapper.Location = new Point(12, 66);
            btnDapper.Name = "btnDapper";
            btnDapper.Size = new Size(102, 48);
            btnDapper.TabIndex = 2;
            btnDapper.Text = "Dapper İle Listele";
            btnDapper.UseVisualStyleBackColor = true;
            btnDapper.Click += btnDapper_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(327, 12);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(122, 48);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblDapperTime
            // 
            lblDapperTime.AutoSize = true;
            lblDapperTime.Location = new Point(131, 83);
            lblDapperTime.Name = "lblDapperTime";
            lblDapperTime.Size = new Size(0, 15);
            lblDapperTime.TabIndex = 4;
            // 
            // lblEFTime
            // 
            lblEFTime.AutoSize = true;
            lblEFTime.Location = new Point(120, 29);
            lblEFTime.Name = "lblEFTime";
            lblEFTime.Size = new Size(0, 15);
            lblEFTime.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(512, 123);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(137, 23);
            txtProductName.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(512, 161);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(137, 23);
            txtStock.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 131);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 7;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 164);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Stock:";
            // 
            // btnEkleEF
            // 
            btnEkleEF.Location = new Point(437, 213);
            btnEkleEF.Name = "btnEkleEF";
            btnEkleEF.Size = new Size(94, 35);
            btnEkleEF.TabIndex = 8;
            btnEkleEF.Text = "EF ile Ekle";
            btnEkleEF.UseVisualStyleBackColor = true;
            btnEkleEF.Click += btnEkle_Click;
            // 
            // btnGuncelleEF
            // 
            btnGuncelleEF.Location = new Point(437, 275);
            btnGuncelleEF.Name = "btnGuncelleEF";
            btnGuncelleEF.Size = new Size(94, 47);
            btnGuncelleEF.TabIndex = 8;
            btnGuncelleEF.Text = "EF ile Güncelle";
            btnGuncelleEF.UseVisualStyleBackColor = true;
            btnGuncelleEF.Click += btnGuncelleEF_Click;
            // 
            // btnEkleDapper
            // 
            btnEkleDapper.Location = new Point(437, 340);
            btnEkleDapper.Name = "btnEkleDapper";
            btnEkleDapper.Size = new Size(94, 52);
            btnEkleDapper.TabIndex = 8;
            btnEkleDapper.Text = "Dapper ile Ekle";
            btnEkleDapper.UseVisualStyleBackColor = true;
            btnEkleDapper.Click += DapperIleEkle;
            // 
            // btnGuncelleDapper
            // 
            btnGuncelleDapper.Location = new Point(437, 414);
            btnGuncelleDapper.Name = "btnGuncelleDapper";
            btnGuncelleDapper.Size = new Size(94, 48);
            btnGuncelleDapper.TabIndex = 8;
            btnGuncelleDapper.Text = "Dapper ile Güncelle";
            btnGuncelleDapper.UseVisualStyleBackColor = true;
            btnGuncelleDapper.Click += btnGuncelleDapper_Click;
            // 
            // lblEkleEF
            // 
            lblEkleEF.AutoSize = true;
            lblEkleEF.Location = new Point(557, 213);
            lblEkleEF.Name = "lblEkleEF";
            lblEkleEF.Size = new Size(0, 15);
            lblEkleEF.TabIndex = 9;
            // 
            // lblGuncelleEF
            // 
            lblGuncelleEF.AutoSize = true;
            lblGuncelleEF.Location = new Point(557, 278);
            lblGuncelleEF.Name = "lblGuncelleEF";
            lblGuncelleEF.Size = new Size(0, 15);
            lblGuncelleEF.TabIndex = 9;
            // 
            // lblEkleDapper
            // 
            lblEkleDapper.AutoSize = true;
            lblEkleDapper.Location = new Point(557, 350);
            lblEkleDapper.Name = "lblEkleDapper";
            lblEkleDapper.Size = new Size(0, 15);
            lblEkleDapper.TabIndex = 9;
            // 
            // lblGuncelleDapper
            // 
            lblGuncelleDapper.AutoSize = true;
            lblGuncelleDapper.Location = new Point(557, 431);
            lblGuncelleDapper.Name = "lblGuncelleDapper";
            lblGuncelleDapper.Size = new Size(0, 15);
            lblGuncelleDapper.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Location = new Point(512, 91);
            txtId.Name = "txtId";
            txtId.Size = new Size(137, 23);
            txtId.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 99);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 7;
            label1.Text = "Id:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 602);
            Controls.Add(lblGuncelleDapper);
            Controls.Add(lblEkleDapper);
            Controls.Add(lblGuncelleEF);
            Controls.Add(lblEkleEF);
            Controls.Add(btnGuncelleDapper);
            Controls.Add(btnEkleDapper);
            Controls.Add(btnGuncelleEF);
            Controls.Add(btnEkleEF);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtStock);
            Controls.Add(txtId);
            Controls.Add(txtProductName);
            Controls.Add(lblEFTime);
            Controls.Add(lblDapperTime);
            Controls.Add(btnTemizle);
            Controls.Add(btnDapper);
            Controls.Add(dataGridView1);
            Controls.Add(btnEntity);
            Name = "Form1";
            Text = "EFvsDapper";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntity;
        private DataGridView dataGridView1;
        private Button btnDapper;
        private Button btnTemizle;
        private Label lblDapperTime;
        private Label lblEFTime;
        private TextBox txtProductName;
        private TextBox txtStock;
        private Label label2;
        private Label label3;
        private Button btnEkleEF;
        private Button btnGuncelleEF;
        private Button btnEkleDapper;
        private Button btnGuncelleDapper;
        private Label lblEkleEF;
        private Label lblGuncelleEF;
        private Label lblEkleDapper;
        private Label lblGuncelleDapper;
        private TextBox txtId;
        private Label label1;
    }
}