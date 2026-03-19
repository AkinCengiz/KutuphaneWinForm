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
public partial class FrmYazarIslemleri : Form
{
    public FrmYazarIslemleri()
    {
        InitializeComponent();
    }

    private YazarManager _manager;
    private void btnKaydet_Click(object sender, EventArgs e)
    {
        Yazar yazar = new Yazar();
        yazar.Adi = txtAd.Text;
        yazar.Soyadi = txtSoyad.Text;
        yazar.DogumYeri = txtDagumYeri.Text;
        yazar.DogumYili = dtpDogumTarihi.Value;
        _manager.YazarEkle(yazar);
        MessageBox.Show("Yazar başarıyla eklendi...");
        DataGridFill();
        InsertClear();

    }

    private void FrmYazarIslemleri_Load(object sender, EventArgs e)
    {
        _manager = new YazarManager();

        DataGridFill();
        GridConfiguration();


    }

    private void GridConfiguration()
    {
        dgvYazarlar.Columns["Id"].DisplayIndex = 0;
        dgvYazarlar.Columns["Id"].HeaderText = "ID";
        dgvYazarlar.Columns["Adi"].HeaderText = "Yazar Adı";
        dgvYazarlar.Columns["Soyadi"].HeaderText = "Yazar Soyadı";
        dgvYazarlar.Columns["DogumYili"].HeaderText = "Doğum Tarihi";
        dgvYazarlar.Columns["DogumYeri"].HeaderText = "Doğum Yeri";
    }

    private void DataGridFill()
    {
        dgvYazarlar.DataSource = _manager.YazarlariListele();
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        Yazar yazar = new Yazar();
        yazar.Id = Convert.ToInt32(txtId.Text);
        yazar.Adi = txtAdiGuncelle.Text;
        yazar.Soyadi = txtSoyadiGuncele.Text;
        yazar.DogumYeri = txtDıgumYeriGuncelle.Text;
        yazar.DogumYili = dtpDagumYiliGuncelle.Value;
        _manager.YazarGuncelle(yazar);
        DataGridFill();
        btnGuncelle.Enabled = false;
        btnSil.Enabled = false;
        UpdateClear();
    }

    private void dgvYazarlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        txtId.Text = dgvYazarlar.CurrentRow.Cells["Id"].Value.ToString();
        txtAdiGuncelle.Text = dgvYazarlar.CurrentRow.Cells["Adi"].Value.ToString();
        txtSoyadiGuncele.Text = dgvYazarlar.CurrentRow.Cells["Soyadi"].Value.ToString();
        txtDıgumYeriGuncelle.Text = dgvYazarlar.CurrentRow.Cells["DogumYeri"].Value.ToString();
        dtpDagumYiliGuncelle.Value = Convert.ToDateTime(dgvYazarlar.CurrentRow.Cells["DogumYili"].Value);
        btnGuncelle.Enabled = true;
        btnSil.Enabled = true;
    }

    void InsertClear()
    {
        txtAd.Clear();
        txtDagumYeri.Clear();
        txtSoyad.Clear();
        dtpDogumTarihi.Value = DateTime.Now;
    }

    void UpdateClear()
    {
        txtId.Clear();
        txtAdiGuncelle.Clear();
        txtDıgumYeriGuncelle.Clear();
        dtpDagumYiliGuncelle.Value = DateTime.Now;
        txtSoyadiGuncele.Clear();
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
        _manager.YazarSil(Convert.ToInt32(txtId.Text));
        DataGridFill();
        UpdateClear();
    }

    private void gbxYazarEkleme_Enter(object sender, EventArgs e)
    {

    }
}
