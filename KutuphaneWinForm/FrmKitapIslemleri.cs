using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneWinForm;
public partial class FrmKitapIslemleri : Form
{
    private YazarManager _yazarManager;
    private KitapManager _kitapManager;

    public FrmKitapIslemleri()
    {
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        FrmYazarIslemleri frmYazar = new FrmYazarIslemleri();
        frmYazar.ShowDialog();
    }

    private void FrmKitapIslemleri_Load(object sender, EventArgs e)
    {

        _kitapManager = new KitapManager();
        ComboFill();
        DataGridFill();
        DataGridConfiguration();

    }

    void ComboFill()
    {
        _yazarManager = new YazarManager();
        //var data = _yazarManager.YazarlariListele().Select(y => new YazarDto()
        //{
        //    Id = y.Id,
        //    Adi = y.Adi,
        //    Soyadi = y.Soyadi
        //}).ToList();
        var data = _yazarManager.YazarlariListele().Select(y => new
        {
            Id = y.Id,
            FullName = y.Adi + " " + y.Soyadi
        }).ToList();
        cmbYazarlar.DataSource = data;
        cmbYazarlar.DisplayMember = "FullName";
        cmbYazarlar.ValueMember = "Id";
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        Kitap kitap = new Kitap();
        kitap.Baslik = txtBaslik.Text;
        kitap.BasimYili = Convert.ToInt32(mtbBasimYili.Text);
        kitap.SayfaSayisi = Convert.ToInt32(nudSayfaSayisi.Value);
        kitap.Stok = Convert.ToByte(nudStok.Value);
        kitap.YazarId = Convert.ToInt32(cmbYazarlar.SelectedValue);

        _kitapManager.KitapEkle(kitap);
        MessageBox.Show("Kitap başarıyla eklendi...");
        DataGridFill();
    }

    void DataGridFill()
    {
        dgvKitaplar.DataSource = _kitapManager.KitaplariListele();
    }

    void DataGridConfiguration()
    {
        //dgvKitaplar.Columns.Add("Baslik","Kitap Adı");
        //dgvKitaplar.Columns.Add("Id", "ID");
        //dgvKitaplar.Columns.Add("BasimYili", "Basım Yılı");
        dgvKitaplar.Columns["Id"].DisplayIndex = 0;
        dgvKitaplar.Columns["Baslik"].HeaderText = "Kitap Adı";
        dgvKitaplar.Columns["BasimYili"].HeaderText = "Basım Yılı";
        dgvKitaplar.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
        dgvKitaplar.Columns["Stok"].HeaderText = "Stok Sayısı";
        dgvKitaplar.Columns["YazarId"].HeaderText = "Yazar";
        //dgvKitaplar.Columns["VarMi"].HeaderText = "Mevcut Mu?";

    }
}