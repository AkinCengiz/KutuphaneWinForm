namespace KutuphaneWinForm;

partial class FrmKitapIslemleri
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
        groupBox1 = new GroupBox();
        button2 = new Button();
        comboBox2 = new ComboBox();
        label1 = new Label();
        maskedTextBox1 = new MaskedTextBox();
        numericUpDown4 = new NumericUpDown();
        numericUpDown5 = new NumericUpDown();
        button3 = new Button();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        textBox1 = new TextBox();
        label5 = new Label();
        gbxYazarlar = new GroupBox();
        dgvKitaplar = new DataGridView();
        gbxYazarEkleme = new GroupBox();
        nudSayfaSayisi = new NumericUpDown();
        nudStok = new NumericUpDown();
        button1 = new Button();
        cmbYazarlar = new ComboBox();
        lblYazar = new Label();
        mtbBasimYili = new MaskedTextBox();
        numericUpDown1 = new NumericUpDown();
        btnKaydet = new Button();
        lblStok = new Label();
        lblBasimYili = new Label();
        lblSayfaSayisi = new Label();
        txtBaslik = new TextBox();
        lblBaslik = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
        gbxYazarlar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
        gbxYazarEkleme.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSayfaSayisi).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.Chocolate;
        groupBox1.Controls.Add(button2);
        groupBox1.Controls.Add(comboBox2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(maskedTextBox1);
        groupBox1.Controls.Add(numericUpDown4);
        groupBox1.Controls.Add(numericUpDown5);
        groupBox1.Controls.Add(button3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBox1);
        groupBox1.Controls.Add(label5);
        groupBox1.Location = new Point(12, 302);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(380, 284);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kitap Günceleme ve Silme";
        // 
        // button2
        // 
        button2.Location = new Point(6, 210);
        button2.Name = "button2";
        button2.Size = new Size(152, 34);
        button2.TabIndex = 27;
        button2.Text = "Yazar Ekle";
        button2.UseVisualStyleBackColor = true;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(189, 174);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(159, 29);
        comboBox2.TabIndex = 26;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 177);
        label1.Name = "label1";
        label1.Size = new Size(58, 21);
        label1.TabIndex = 25;
        label1.Text = "Yazar : ";
        // 
        // maskedTextBox1
        // 
        maskedTextBox1.Location = new Point(189, 63);
        maskedTextBox1.Mask = "0000";
        maskedTextBox1.Name = "maskedTextBox1";
        maskedTextBox1.Size = new Size(159, 29);
        maskedTextBox1.TabIndex = 24;
        maskedTextBox1.ValidatingType = typeof(int);
        // 
        // numericUpDown4
        // 
        numericUpDown4.Location = new Point(189, 98);
        numericUpDown4.Name = "numericUpDown4";
        numericUpDown4.Size = new Size(159, 29);
        numericUpDown4.TabIndex = 23;
        // 
        // numericUpDown5
        // 
        numericUpDown5.Location = new Point(189, 133);
        numericUpDown5.Name = "numericUpDown5";
        numericUpDown5.Size = new Size(159, 29);
        numericUpDown5.TabIndex = 22;
        // 
        // button3
        // 
        button3.Location = new Point(189, 210);
        button3.Name = "button3";
        button3.Size = new Size(159, 34);
        button3.TabIndex = 21;
        button3.Text = "Kaydet";
        button3.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 100);
        label2.Name = "label2";
        label2.Size = new Size(51, 21);
        label2.TabIndex = 20;
        label2.Text = "Stok : ";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 67);
        label3.Name = "label3";
        label3.Size = new Size(88, 21);
        label3.TabIndex = 19;
        label3.Text = "Basım Yılı : ";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 135);
        label4.Name = "label4";
        label4.Size = new Size(103, 21);
        label4.TabIndex = 18;
        label4.Text = "Sayfa Sayısı : ";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(189, 28);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(159, 29);
        textBox1.TabIndex = 17;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(6, 32);
        label5.Name = "label5";
        label5.Size = new Size(61, 21);
        label5.TabIndex = 16;
        label5.Text = "Başlık : ";
        // 
        // gbxYazarlar
        // 
        gbxYazarlar.BackColor = Color.LightSeaGreen;
        gbxYazarlar.Controls.Add(dgvKitaplar);
        gbxYazarlar.Location = new Point(398, 12);
        gbxYazarlar.Name = "gbxYazarlar";
        gbxYazarlar.Size = new Size(743, 574);
        gbxYazarlar.TabIndex = 4;
        gbxYazarlar.TabStop = false;
        gbxYazarlar.Text = "Kitap Listesi";
        // 
        // dgvKitaplar
        // 
        dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvKitaplar.Dock = DockStyle.Fill;
        dgvKitaplar.Location = new Point(3, 25);
        dgvKitaplar.Name = "dgvKitaplar";
        dgvKitaplar.Size = new Size(737, 546);
        dgvKitaplar.TabIndex = 0;
        // 
        // gbxYazarEkleme
        // 
        gbxYazarEkleme.BackColor = Color.DarkGreen;
        gbxYazarEkleme.Controls.Add(nudSayfaSayisi);
        gbxYazarEkleme.Controls.Add(nudStok);
        gbxYazarEkleme.Controls.Add(button1);
        gbxYazarEkleme.Controls.Add(cmbYazarlar);
        gbxYazarEkleme.Controls.Add(lblYazar);
        gbxYazarEkleme.Controls.Add(mtbBasimYili);
        gbxYazarEkleme.Controls.Add(numericUpDown1);
        gbxYazarEkleme.Controls.Add(btnKaydet);
        gbxYazarEkleme.Controls.Add(lblStok);
        gbxYazarEkleme.Controls.Add(lblBasimYili);
        gbxYazarEkleme.Controls.Add(lblSayfaSayisi);
        gbxYazarEkleme.Controls.Add(txtBaslik);
        gbxYazarEkleme.Controls.Add(lblBaslik);
        gbxYazarEkleme.Location = new Point(12, 12);
        gbxYazarEkleme.Name = "gbxYazarEkleme";
        gbxYazarEkleme.Size = new Size(380, 284);
        gbxYazarEkleme.TabIndex = 3;
        gbxYazarEkleme.TabStop = false;
        gbxYazarEkleme.Text = "Kitap Ekle";
        // 
        // nudSayfaSayisi
        // 
        nudSayfaSayisi.Location = new Point(189, 139);
        nudSayfaSayisi.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
        nudSayfaSayisi.Name = "nudSayfaSayisi";
        nudSayfaSayisi.Size = new Size(159, 29);
        nudSayfaSayisi.TabIndex = 17;
        nudSayfaSayisi.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // nudStok
        // 
        nudStok.Location = new Point(189, 104);
        nudStok.Name = "nudStok";
        nudStok.Size = new Size(159, 29);
        nudStok.TabIndex = 16;
        nudStok.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // button1
        // 
        button1.Location = new Point(6, 214);
        button1.Name = "button1";
        button1.Size = new Size(152, 34);
        button1.TabIndex = 15;
        button1.Text = "Yazar Ekle";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // cmbYazarlar
        // 
        cmbYazarlar.FormattingEnabled = true;
        cmbYazarlar.Location = new Point(189, 178);
        cmbYazarlar.Name = "cmbYazarlar";
        cmbYazarlar.Size = new Size(159, 29);
        cmbYazarlar.TabIndex = 14;
        // 
        // lblYazar
        // 
        lblYazar.AutoSize = true;
        lblYazar.Location = new Point(6, 181);
        lblYazar.Name = "lblYazar";
        lblYazar.Size = new Size(58, 21);
        lblYazar.TabIndex = 13;
        lblYazar.Text = "Yazar : ";
        // 
        // mtbBasimYili
        // 
        mtbBasimYili.Location = new Point(189, 67);
        mtbBasimYili.Mask = "0000";
        mtbBasimYili.Name = "mtbBasimYili";
        mtbBasimYili.Size = new Size(159, 29);
        mtbBasimYili.TabIndex = 12;
        mtbBasimYili.ValidatingType = typeof(int);
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(20, 473);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(120, 29);
        numericUpDown1.TabIndex = 9;
        // 
        // btnKaydet
        // 
        btnKaydet.Location = new Point(189, 214);
        btnKaydet.Name = "btnKaydet";
        btnKaydet.Size = new Size(159, 34);
        btnKaydet.TabIndex = 8;
        btnKaydet.Text = "Kaydet";
        btnKaydet.UseVisualStyleBackColor = true;
        btnKaydet.Click += btnKaydet_Click;
        // 
        // lblStok
        // 
        lblStok.AutoSize = true;
        lblStok.Location = new Point(6, 104);
        lblStok.Name = "lblStok";
        lblStok.Size = new Size(51, 21);
        lblStok.TabIndex = 6;
        lblStok.Text = "Stok : ";
        // 
        // lblBasimYili
        // 
        lblBasimYili.AutoSize = true;
        lblBasimYili.Location = new Point(6, 71);
        lblBasimYili.Name = "lblBasimYili";
        lblBasimYili.Size = new Size(88, 21);
        lblBasimYili.TabIndex = 4;
        lblBasimYili.Text = "Basım Yılı : ";
        // 
        // lblSayfaSayisi
        // 
        lblSayfaSayisi.AutoSize = true;
        lblSayfaSayisi.Location = new Point(6, 139);
        lblSayfaSayisi.Name = "lblSayfaSayisi";
        lblSayfaSayisi.Size = new Size(103, 21);
        lblSayfaSayisi.TabIndex = 2;
        lblSayfaSayisi.Text = "Sayfa Sayısı : ";
        // 
        // txtBaslik
        // 
        txtBaslik.Location = new Point(189, 32);
        txtBaslik.Name = "txtBaslik";
        txtBaslik.Size = new Size(159, 29);
        txtBaslik.TabIndex = 1;
        // 
        // lblBaslik
        // 
        lblBaslik.AutoSize = true;
        lblBaslik.Location = new Point(6, 36);
        lblBaslik.Name = "lblBaslik";
        lblBaslik.Size = new Size(61, 21);
        lblBaslik.TabIndex = 0;
        lblBaslik.Text = "Başlık : ";
        // 
        // FrmKitapIslemleri
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1152, 597);
        Controls.Add(groupBox1);
        Controls.Add(gbxYazarlar);
        Controls.Add(gbxYazarEkleme);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmKitapIslemleri";
        Text = "Kitap İşlemleri";
        Load += FrmKitapIslemleri_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
        gbxYazarlar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
        gbxYazarEkleme.ResumeLayout(false);
        gbxYazarEkleme.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSayfaSayisi).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button btnSil;
    private Button btnGuncelle;
    private DateTimePicker dtpDagumYiliGuncelle;
    private Label lblDogumYiliGuncelle;
    private TextBox txtDıgumYeriGuncelle;
    private Label lblSoyadiGuncelle;
    private TextBox txtSoyadiGuncele;
    private Label lblDogumYeriGuncelle;
    private TextBox txtAdiGuncelle;
    private Label lblAdiGuncelle;
    private GroupBox gbxYazarlar;
    private DataGridView dgvKitaplar;
    private GroupBox gbxYazarEkleme;
    private Button btnKaydet;
    private Label lblStok;
    private Label lblBasimYili;
    private Label lblSayfaSayisi;
    private TextBox txtBaslik;
    private Label lblBaslik;
    private Label lblYazar;
    private MaskedTextBox mtbBasimYili;
    private NumericUpDown numericUpDown3;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown1;
    private ComboBox cmbYazarlar;
    private Button button1;
    private Button button2;
    private ComboBox comboBox2;
    private Label label1;
    private MaskedTextBox maskedTextBox1;
    private NumericUpDown numericUpDown4;
    private NumericUpDown numericUpDown5;
    private Button button3;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private Label label5;
    private NumericUpDown nudSayfaSayisi;
    private NumericUpDown nudStok;
}