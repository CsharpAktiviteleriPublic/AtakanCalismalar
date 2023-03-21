using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WfaCrud.Models;

namespace WfaCrud
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext _db = new NorthwindContext();
        Customer customer = new Customer();
        DialogResult dr;
        string id, sirketAdi;
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = _db.Customers.ToList();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OzellikleriBelirle();
                CustomerDuzenle(customer);    
                _db.Customers.Add(customer);
                dbKaydet();
                dgvGoster();
            }
            catch
            {
                dgvGoster();
                _db.Customers.Remove(customer);
                dbKaydet();
                MessageBox.Show("Ayn� Id'ye sahip m��teri eklenemez..!");
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {            
            dr = MessageBox.Show($"{txtID.Text} ID sine sahip m��teri g�ncellenecek.\n\n Emin misiniz?", "Bilgilendirme Mesaji", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                foreach (Customer cst in _db.Customers.ToList())
                {
                    if (cst.CustomerId == txtID.Text)
                    {
                        cst.CompanyName = txtSirketAdi.Text;
                        dbKaydet();
                        MessageBox.Show("G�ncelleme ba�ar�l�");
                        dgvGoster();                       
                    }
                }    
            }
            else
            {
                MessageBox.Show("G�ncelleme iptal edildi.");
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            index = dgvTable.SelectedRows[0].Index;
            dr = MessageBox.Show($"{_db.Customers.ToList()[index].CompanyName} adl� �irket kal�c� olarak silinecektir. \n\n Emin misiniz ?", "Bilgilendirme Mesaji", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    _db.Customers.Remove(_db.Customers.ToList()[index]);
                    dbKaydet();
                    MessageBox.Show("Kullan�c� ba�ar�yla silindi.");
                    dgvGoster();
                }
                catch 
                {
                    MessageBox.Show("Silme esnas�nda bir hata olu�tu.");
                }                
            }
        }
        private void dbKaydet()
        {
            _db.SaveChanges();
        }
        private void dgvGoster()
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = _db.Customers.ToList();
        }
        private void OzellikleriBelirle()
        {
            id = txtID.Text;
            sirketAdi = txtSirketAdi.Text;
        }
        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvTable.SelectedRows[0].Cells[0].Value.ToString();
            sirketAdi = dgvTable.SelectedRows[0].Cells[1].Value.ToString();
            txtID.Text = id;
            txtSirketAdi.Text = sirketAdi;
        }
        private void CustomerDuzenle(Customer customer)
        {
            customer.CustomerId = id;
            customer.CompanyName = sirketAdi;
        }
    }
}