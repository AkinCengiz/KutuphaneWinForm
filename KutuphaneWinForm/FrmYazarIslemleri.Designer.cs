namespace KutuphaneWinForm;

partial class FrmYazarIslemleri
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
        gbxYazarEkleme = new GroupBox();
        btnKaydet = new Button();
        dtpDogumTarihi = new DateTimePicker();
        lblDogumYili = new Label();
        txtSoyad = new TextBox();
        lblSoyad = new Label();
        txtDagumYeri = new TextBox();
        lblDogumYeri = new Label();
        txtAd = new TextBox();
        lblAdi = new Label();
        gbxYazarlar = new GroupBox();
        dgvYazarlar = new DataGridView();
        groupBox1 = new GroupBox();
        txtId = new TextBox();
        label1 = new Label();
        btnSil = new Button();
        btnGuncelle = new Button();
        dtpDagumYiliGuncelle = new DateTimePicker();
        lblDogumYiliGuncelle = new Label();
        txtDıgumYeriGuncelle = new TextBox();
        lblSoyadiGuncelle = new Label();
        txtSoyadiGuncele = new TextBox();
        lblDogumYeriGuncelle = new Label();
        txtAdiGuncelle = new TextBox();
        lblAdiGuncelle = new Label();
        dgvDeneme = new DataGridView();
        gbxYazarEkleme.SuspendLayout();
        gbxYazarlar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvYazarlar).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDeneme).BeginInit();
        SuspendLayout();
        // 
        // gbxYazarEkleme
        // 
        gbxYazarEkleme.Controls.Add(btnKaydet);
        gbxYazarEkleme.Controls.Add(dtpDogumTarihi);
        gbxYazarEkleme.Controls.Add(lblDogumYili);
        gbxYazarEkleme.Controls.Add(txtSoyad);
        gbxYazarEkleme.Controls.Add(lblSoyad);
        gbxYazarEkleme.Controls.Add(txtDagumYeri);
        gbxYazarEkleme.Controls.Add(lblDogumYeri);
        gbxYazarEkleme.Controls.Add(txtAd);
        gbxYazarEkleme.Controls.Add(lblAdi);
        gbxYazarEkleme.Location = new Point(12, 12);
        gbxYazarEkleme.Name = "gbxYazarEkleme";
        gbxYazarEkleme.Size = new Size(743, 130);
        gbxYazarEkleme.TabIndex = 0;
        gbxYazarEkleme.TabStop = false;
        gbxYazarEkleme.Text = "Yazar Ekle";
        gbxYazarEkleme.Enter += gbxYazarEkleme_Enter;
        // 
        // btnKaydet
        // 
        btnKaydet.Location = new Point(582, 23);
        btnKaydet.Name = "btnKaydet";
        btnKaydet.Size = new Size(140, 34);
        btnKaydet.TabIndex = 8;
        btnKaydet.Text = "Kaydet";
        btnKaydet.UseVisualStyleBackColor = true;
        btnKaydet.Click += btnKaydet_Click;
        // 
        // dtpDogumTarihi
        // 
        dtpDogumTarihi.Format = DateTimePickerFormat.Short;
        dtpDogumTarihi.Location = new Point(417, 67);
        dtpDogumTarihi.Name = "dtpDogumTarihi";
        dtpDogumTarihi.Size = new Size(159, 29);
        dtpDogumTarihi.TabIndex = 7;
        // 
        // lblDogumYili
        // 
        lblDogumYili.AutoSize = true;
        lblDogumYili.Location = new Point(297, 70);
        lblDogumYili.Name = "lblDogumYili";
        lblDogumYili.Size = new Size(114, 21);
        lblDogumYili.TabIndex = 6;
        lblDogumYili.Text = "Doğum Tarihi : ";
        // 
        // txtSoyad
        // 
        txtSoyad.Location = new Point(417, 27);
        txtSoyad.Name = "txtSoyad";
        txtSoyad.Size = new Size(159, 29);
        txtSoyad.TabIndex = 5;
        // 
        // lblSoyad
        // 
        lblSoyad.AutoSize = true;
        lblSoyad.Location = new Point(297, 30);
        lblSoyad.Name = "lblSoyad";
        lblSoyad.Size = new Size(68, 21);
        lblSoyad.TabIndex = 4;
        lblSoyad.Text = "Soyadı : ";
        // 
        // txtDagumYeri
        // 
        txtDagumYeri.Location = new Point(115, 67);
        txtDagumYeri.Name = "txtDagumYeri";
        txtDagumYeri.Size = new Size(159, 29);
        txtDagumYeri.TabIndex = 3;
        // 
        // lblDogumYeri
        // 
        lblDogumYeri.AutoSize = true;
        lblDogumYeri.Location = new Point(6, 70);
        lblDogumYeri.Name = "lblDogumYeri";
        lblDogumYeri.Size = new Size(103, 21);
        lblDogumYeri.TabIndex = 2;
        lblDogumYeri.Text = "Doğum Yeri : ";
        // 
        // txtAd
        // 
        txtAd.Location = new Point(115, 32);
        txtAd.Name = "txtAd";
        txtAd.Size = new Size(159, 29);
        txtAd.TabIndex = 1;
        // 
        // lblAdi
        // 
        lblAdi.AutoSize = true;
        lblAdi.Location = new Point(6, 35);
        lblAdi.Name = "lblAdi";
        lblAdi.Size = new Size(44, 21);
        lblAdi.TabIndex = 0;
        lblAdi.Text = "Adı : ";
        // 
        // gbxYazarlar
        // 
        gbxYazarlar.Controls.Add(dgvYazarlar);
        gbxYazarlar.Location = new Point(12, 148);
        gbxYazarlar.Name = "gbxYazarlar";
        gbxYazarlar.Size = new Size(743, 470);
        gbxYazarlar.TabIndex = 1;
        gbxYazarlar.TabStop = false;
        gbxYazarlar.Text = "Yazar Listesi";
        // 
        // dgvYazarlar
        // 
        dgvYazarlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvYazarlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvYazarlar.Dock = DockStyle.Fill;
        dgvYazarlar.Location = new Point(3, 25);
        dgvYazarlar.Name = "dgvYazarlar";
        dgvYazarlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvYazarlar.Size = new Size(737, 442);
        dgvYazarlar.TabIndex = 0;
        dgvYazarlar.CellDoubleClick += dgvYazarlar_CellDoubleClick;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtId);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(btnSil);
        groupBox1.Controls.Add(btnGuncelle);
        groupBox1.Controls.Add(dtpDagumYiliGuncelle);
        groupBox1.Controls.Add(lblDogumYiliGuncelle);
        groupBox1.Controls.Add(txtDıgumYeriGuncelle);
        groupBox1.Controls.Add(lblSoyadiGuncelle);
        groupBox1.Controls.Add(txtSoyadiGuncele);
        groupBox1.Controls.Add(lblDogumYeriGuncelle);
        groupBox1.Controls.Add(txtAdiGuncelle);
        groupBox1.Controls.Add(lblAdiGuncelle);
        groupBox1.Location = new Point(761, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(317, 318);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Yazar Günceleme ve Silme";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(138, 35);
        txtId.Name = "txtId";
        txtId.Size = new Size(159, 29);
        txtId.TabIndex = 15;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(18, 38);
        label1.Name = "label1";
        label1.Size = new Size(36, 21);
        label1.TabIndex = 14;
        label1.Text = "ID : ";
        // 
        // btnSil
        // 
        btnSil.Enabled = false;
        btnSil.Location = new Point(138, 256);
        btnSil.Name = "btnSil";
        btnSil.Size = new Size(159, 34);
        btnSil.TabIndex = 13;
        btnSil.Text = "Sil";
        btnSil.UseVisualStyleBackColor = true;
        btnSil.Click += btnSil_Click;
        // 
        // btnGuncelle
        // 
        btnGuncelle.Enabled = false;
        btnGuncelle.Location = new Point(138, 216);
        btnGuncelle.Name = "btnGuncelle";
        btnGuncelle.Size = new Size(159, 34);
        btnGuncelle.TabIndex = 12;
        btnGuncelle.Text = "Güncelle";
        btnGuncelle.UseVisualStyleBackColor = true;
        btnGuncelle.Click += btnGuncelle_Click;
        // 
        // dtpDagumYiliGuncelle
        // 
        dtpDagumYiliGuncelle.Format = DateTimePickerFormat.Short;
        dtpDagumYiliGuncelle.Location = new Point(138, 181);
        dtpDagumYiliGuncelle.Name = "dtpDagumYiliGuncelle";
        dtpDagumYiliGuncelle.Size = new Size(159, 29);
        dtpDagumYiliGuncelle.TabIndex = 11;
        // 
        // lblDogumYiliGuncelle
        // 
        lblDogumYiliGuncelle.AutoSize = true;
        lblDogumYiliGuncelle.Location = new Point(18, 187);
        lblDogumYiliGuncelle.Name = "lblDogumYiliGuncelle";
        lblDogumYiliGuncelle.Size = new Size(114, 21);
        lblDogumYiliGuncelle.TabIndex = 10;
        lblDogumYiliGuncelle.Text = "Doğum Tarihi : ";
        // 
        // txtDıgumYeriGuncelle
        // 
        txtDıgumYeriGuncelle.Location = new Point(138, 141);
        txtDıgumYeriGuncelle.Name = "txtDıgumYeriGuncelle";
        txtDıgumYeriGuncelle.Size = new Size(159, 29);
        txtDıgumYeriGuncelle.TabIndex = 9;
        // 
        // lblSoyadiGuncelle
        // 
        lblSoyadiGuncelle.AutoSize = true;
        lblSoyadiGuncelle.Location = new Point(18, 108);
        lblSoyadiGuncelle.Name = "lblSoyadiGuncelle";
        lblSoyadiGuncelle.Size = new Size(68, 21);
        lblSoyadiGuncelle.TabIndex = 8;
        lblSoyadiGuncelle.Text = "Soyadı : ";
        // 
        // txtSoyadiGuncele
        // 
        txtSoyadiGuncele.Location = new Point(138, 105);
        txtSoyadiGuncele.Name = "txtSoyadiGuncele";
        txtSoyadiGuncele.Size = new Size(159, 29);
        txtSoyadiGuncele.TabIndex = 7;
        // 
        // lblDogumYeriGuncelle
        // 
        lblDogumYeriGuncelle.AutoSize = true;
        lblDogumYeriGuncelle.Location = new Point(18, 144);
        lblDogumYeriGuncelle.Name = "lblDogumYeriGuncelle";
        lblDogumYeriGuncelle.Size = new Size(103, 21);
        lblDogumYeriGuncelle.TabIndex = 6;
        lblDogumYeriGuncelle.Text = "Doğum Yeri : ";
        // 
        // txtAdiGuncelle
        // 
        txtAdiGuncelle.Location = new Point(138, 70);
        txtAdiGuncelle.Name = "txtAdiGuncelle";
        txtAdiGuncelle.Size = new Size(159, 29);
        txtAdiGuncelle.TabIndex = 5;
        // 
        // lblAdiGuncelle
        // 
        lblAdiGuncelle.AutoSize = true;
        lblAdiGuncelle.Location = new Point(18, 73);
        lblAdiGuncelle.Name = "lblAdiGuncelle";
        lblAdiGuncelle.Size = new Size(44, 21);
        lblAdiGuncelle.TabIndex = 4;
        lblAdiGuncelle.Text = "Adı : ";
        // 
        // dgvDeneme
        // 
        dgvDeneme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvDeneme.Location = new Point(791, 357);
        dgvDeneme.Name = "dgvDeneme";
        dgvDeneme.Size = new Size(240, 150);
        dgvDeneme.TabIndex = 3;
        // 
        // FrmYazarIslemleri
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1090, 630);
        Controls.Add(dgvDeneme);
        Controls.Add(groupBox1);
        Controls.Add(gbxYazarlar);
        Controls.Add(gbxYazarEkleme);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmYazarIslemleri";
        Text = "Yazar Islemleri";
        Load += FrmYazarIslemleri_Load;
        gbxYazarEkleme.ResumeLayout(false);
        gbxYazarEkleme.PerformLayout();
        gbxYazarlar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvYazarlar).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvDeneme).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox gbxYazarEkleme;
    private Label lblDogumYili;
    private TextBox txtSoyad;
    private Label lblSoyad;
    private TextBox txtDagumYeri;
    private Label lblDogumYeri;
    private TextBox txtAd;
    private Label lblAdi;
    private Button btnKaydet;
    private DateTimePicker dtpDogumTarihi;
    private GroupBox gbxYazarlar;
    private DataGridView dgvYazarlar;
    private GroupBox groupBox1;
    private Button btnGuncelle;
    private DateTimePicker dtpDagumYiliGuncelle;
    private Label lblDogumYiliGuncelle;
    private TextBox txtDıgumYeriGuncelle;
    private Label lblSoyadiGuncelle;
    private TextBox txtSoyadiGuncele;
    private Label lblDogumYeriGuncelle;
    private TextBox txtAdiGuncelle;
    private Label lblAdiGuncelle;
    private Button btnSil;
    private DataGridView dgvDeneme;
    private TextBox txtId;
    private Label label1;
}