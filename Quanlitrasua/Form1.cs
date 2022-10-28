using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlitrasua
{
    public partial class Quanlitrasua : Form
    {
        public Quanlitrasua()
        {
            InitializeComponent();
        }
        // Giá size M
        int giaTs1M = 25;
        int giaTs2M = 26;
        int giaTs3M = 27;
        int giaTs4M = 28;
        int giaTs5M = 29;
        int giaTs6M = 30;

        // biến để lấy ra giá và số lượng sau khi khách hàng đã chọn 1 món
        //1
        int giaTS1;
        int soluong1;
        int soluongcuoi1;
        //2
        int giaTS2;
        int soluong2;
        int soluongcuoi2;
        //3
        int giaTS3;
        int soluong3;
        int soluongcuoi3;
        //4
        int giaTS4;
        int soluong4;
        int soluongcuoi4;
        //5
        int giaTS5;
        int soluong5;
        int soluongcuoi5;
        //6
        int giaTS6;
        int soluong6;
        int soluongcuoi6;

        // Biến tổng tiền của từng món sau khi chọn  
        int tongtienTS1;
        int tongtienTS2;
        int tongtienTS3;
        int tongtienTS4;
        int tongtienTS5;
        int tongtienTS6;

        //biến lưu tạm giá trị số lượng
        int sl1, sl2, sl3, sl4, sl5, sl6;
        
        //biến lưu tổng tiền phải trả của từng bàn;
        int tongban1, tongban2, tongban3, tongban4, tongban5, tongban6;


        // Chon SIZE
        private void sizeTs1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs1.SelectedItem == "M")
            {
                giaTs1.Text = (giaTs1M).ToString();
                giaTS1 = int.Parse(giaTs1.Text);
            }
            if (sizeTs1.SelectedItem == "L")
            {
                giaTs1.Text = (giaTs1M + 4).ToString();
                giaTS1 = int.Parse(giaTs1.Text);
            }
            else if (sizeTs1.SelectedItem == "XL")
            {
                giaTs1.Text = (giaTs1M + 8).ToString();
                giaTS1 = int.Parse(giaTs1.Text);
            }
        }

        private void sizeTs2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs2.SelectedItem == "M")
            {
                giaTs2.Text = (giaTs2M).ToString();
                giaTS2 = int.Parse(giaTs2.Text);
            }
            if (sizeTs2.SelectedItem == "L")
            {
                giaTs2.Text = (giaTs2M + 4).ToString();
                giaTS2 = int.Parse(giaTs2.Text);
            }
            else if (sizeTs2.SelectedItem == "XL")
            {
                giaTs2.Text = (giaTs2M + 8).ToString();
                giaTS2 = int.Parse(giaTs2.Text);
            }
        }

        private void sizeTs3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs3.SelectedItem == "M")
            {
                giaTs3.Text = (giaTs3M).ToString();
                giaTS3 = int.Parse(giaTs3.Text);
            }

            if (sizeTs3.SelectedItem == "L")
            {
                giaTs3.Text = (giaTs3M + 4).ToString();
                giaTS3 = int.Parse(giaTs3.Text);
            }
            else if (sizeTs3.SelectedItem == "XL")
            {
                giaTs3.Text = (giaTs3M + 8).ToString();
                giaTS3 = int.Parse(giaTs3.Text);
            }
        }

        private void sizeTs4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs4.SelectedItem == "M")
            {
                giaTs4.Text = (giaTs4M).ToString();
                giaTS4 = int.Parse(giaTs4.Text);
            }
            if (sizeTs4.SelectedItem == "L")
            {
                giaTs4.Text = (giaTs4M + 4).ToString();
                giaTS4 = int.Parse(giaTs4.Text);
            }
            else if (sizeTs4.SelectedItem == "XL")
            {
                giaTs4.Text = (giaTs4M + 8).ToString();
                giaTS4 = int.Parse(giaTs4.Text);
            }
        }

        private void sizeTs5_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs5.SelectedItem == "M")
            {
                giaTs5.Text = (giaTs5M).ToString();
                giaTS5 = int.Parse(giaTs5.Text);
            }
            if (sizeTs5.SelectedItem == "L")
            {
                giaTs5.Text = (giaTs5M + 4).ToString();
                giaTS5 = int.Parse(giaTs5.Text);
            }
            else if (sizeTs5.SelectedItem == "XL")
            {
                giaTs5.Text = (giaTs5M + 8).ToString();
                giaTS5 = int.Parse(giaTs5.Text);
            }
        }

        private void sizeTs6_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sizeTs6.SelectedItem == "M")
            {
                giaTs6.Text = (giaTs6M).ToString();
                giaTS6 = int.Parse(giaTs6.Text);
            }
            if (sizeTs6.SelectedItem == "L")
            {
                giaTs6.Text = (giaTs6M + 4).ToString();
                giaTS6 = int.Parse(giaTs6.Text);
            }
            else if (sizeTs6.SelectedItem == "XL")
            {
                giaTs6.Text = (giaTs6M + 8).ToString();
                giaTS6 = int.Parse(giaTs6.Text);
            }
        }


        // Form Load
        public void Quanlitrasua_Load(object sender, EventArgs e)
        {
            SoluongTs1.Text = "0";
            SoluongTs2.Text = "0";
            SoluongTs3.Text = "0";
            SoluongTs4.Text = "0";
            SoluongTs5.Text = "0";
            SoluongTs6.Text = "0";
            Ban1.Checked = true;
            SoBanhientai.TextAlign = ContentAlignment.MiddleCenter;
            listViewTS2.Visible = false;
            listViewTS3.Visible = false;
            listViewTS4.Visible = false;
            listViewTS5.Visible = false;
            listViewTS6.Visible = false;
            listViewTS.Visible = true;
            // this.SoluongTs1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //
            tongban1 = 0; tongban2= 0; tongban3 = 0; tongban4 = 0; tongban5 = 0; tongban6 = 0;

        }


        // Tăng số lượng trà sữa

        // gọi chung sự kiện .click thì làm gì đó
        /*private void soluongTs_TextChanged( object sender, EventArgs e)
       {
           TextBox soluongTsx = (TextBox)sender;
           int soluong = int.Parse(soluongTsx.Text);
           soluong += 1;
           soluongTsx.Text = soluong.ToString();
       }*/

        private void btnAddSL1_Click(object sender, EventArgs e)
        {
            //btnAddSL1.Click += soluongTs_TextChanged;
            sl1 = int.Parse(SoluongTs1.Text);
            if (SoluongTs1.Text ==" ")
            {
                sl1 = 0;
            }
            sl1 += 1;
            SoluongTs1.Text = sl1.ToString();
        }

        private void btnAddSL2_Click(object sender, EventArgs e)
        {
            sl2 = int.Parse(SoluongTs2.Text);
            if (SoluongTs2.Text == " ")
            {
                sl2 = 0;
            }
            sl2 += 1;
            SoluongTs2.Text = sl2.ToString();
        }

        private void btnAddSL3_Click(object sender, EventArgs e)
        {
            sl3 = int.Parse(SoluongTs3.Text);
            if (SoluongTs3.Text == " ")
            {
                sl3 = 0;
            }
            sl3 += 1;
            SoluongTs3.Text = sl3.ToString();
        }

        private void btnAddSL4_Click(object sender, EventArgs e)
        {
            sl4 = int.Parse(SoluongTs4.Text);
            if (SoluongTs4.Text == " ")
            {
                sl4 = 0;
            }
            sl4 += 1;
            SoluongTs4.Text = sl4.ToString();
        }

        private void btnAddSL5_Click(object sender, EventArgs e)
        {
            sl5 = int.Parse(SoluongTs5.Text);
            if (SoluongTs5.Text == " ")
            {
                sl5 = 0;
            }
            sl5 += 1;
            SoluongTs5.Text = sl5.ToString();
        }

        private void btnAddSL6_Click(object sender, EventArgs e)
        {
            sl6 = int.Parse(SoluongTs6.Text);
            if (SoluongTs6.Text == " ")
            {
                sl6 = 0;
            }
            sl6 += 1;
            SoluongTs6.Text = sl6.ToString();
        }


        // Giảm số lượng trà sữa
        private void btnTruSL1_Click(object sender, EventArgs e)
        {
            sl1 = int.Parse(SoluongTs1.Text);
            sl1 -= 1;
            SoluongTs1.Text = sl1.ToString();
            if (sl1 < 0)
            {
                SoluongTs1.Text = "0";
            }
        }

        private void btnTruSL2_Click(object sender, EventArgs e)
        {
            sl2 = int.Parse(SoluongTs2.Text);
            sl2 -= 1;
            SoluongTs2.Text = sl2.ToString();
            if (sl2 < 0)
            {
                SoluongTs2.Text = "0";
            }
        }

        private void btnTruSL3_Click(object sender, EventArgs e)
        {
            sl3 = int.Parse(SoluongTs3.Text);
            sl3 -= 1;
            SoluongTs3.Text = sl3.ToString();
            if (sl3 < 0)
            {
                SoluongTs3.Text = "0";
            }
        }

        private void btnTruSL4_Click(object sender, EventArgs e)
        {
            sl4 = int.Parse(SoluongTs4.Text);
            sl4 -= 1;
            SoluongTs4.Text = sl4.ToString();
            if (sl4 < 0)
            {
                SoluongTs4.Text = "0";
            }
        }

        private void btnTruSL5_Click(object sender, EventArgs e)
        {
            sl5 = int.Parse(SoluongTs5.Text);
            sl5 -= 1;
            SoluongTs5.Text = sl5.ToString();
            if (sl5 < 0)
            {
                SoluongTs5.Text = "0";
            }
        }

        private void btnTruSL6_Click(object sender, EventArgs e)
        {
            sl6 = int.Parse(SoluongTs6.Text);
            sl6 -= 1;
            SoluongTs6.Text = sl6.ToString();
            if (sl6 < 0)
            {
                SoluongTs6.Text = "0";
            }
        }


        // Lay ra gia va so luong tra sua de tinh tien

        // Hàm lấy giá trị số lượng nhập vào hoặc tăng giảm.
        private int getValueInput(TextBox soluong)
        {
            int valuetextbox = int.Parse(soluong.Text);
            if (soluong.Text == "0")
            {
                valuetextbox = 0;
            }
            return valuetextbox;
        }
       
        //Hàm lấy ra số lượng cuối cùng sau xử lý 
        private int getValueSL(CheckBox trasuaX, int soluongtam, int soluongcuoi,TextBox soluongTS)
        {
            if(trasuaX.Checked == true)
            {
                soluongtam = getValueInput(soluongTS);
                soluongcuoi = soluongtam;
            }
            else
            {
                soluongtam = 0;
                soluongcuoi = soluongtam;
            }
            return soluongcuoi;
        }
        
        //



            // Them mon duoc chon vao list view
        // Tra sua 1
        private void trasua1_CheckedChanged(object sender, EventArgs e)
        { 
            soluongcuoi1 = getValueSL(trasua1, sl1, soluong1, SoluongTs1);
            if(trasua1.Checked == true)
            {
                btnAddSL1.Enabled = true;
                btnTruSL1.Enabled = true;
            }
            else
            {
                btnAddSL1.Enabled = false;
                btnTruSL1.Enabled = false;
            }
        }
        private void SoluongTs1_TextChanged(object sender, EventArgs e)
        {
            if(trasua1.Checked == false)
            {
                sl1 = 0;
            }
            else
            {
               if ( SoluongTs1.Text == "")
                {
                    sl1 = soluongcuoi1;
                }
               else
                {
                    soluongcuoi1 = sl1+(int.Parse(SoluongTs1.Text) - sl1 );
                }
            }
        }



        


        // Tra sua 2
        private void trasua2_CheckedChanged(object sender, EventArgs e)
        {
            soluongcuoi2 = getValueSL(trasua2, sl2, soluong2, SoluongTs2);
            if (trasua2.Checked == true)
            {
                btnAddSL2.Enabled = true;
                btnTruSL2.Enabled = true;
            }
            else
            {
                btnAddSL2.Enabled = false;
                btnTruSL2.Enabled = false;
            }
        }
        private void SoluongTs2_TextChanged(object sender, EventArgs e)
        {
            if (trasua2.Checked == false)
            {
                sl2 = 0;
            }
            else
            {
                if (SoluongTs2.Text == "")
                {
                    sl2 = soluongcuoi2;
                }
                else
                {
                    soluongcuoi2= sl2 + (int.Parse(SoluongTs2.Text) - sl2);
                }
            }
        }


        // Tra sua 3
        private void trasua3_CheckedChanged(object sender, EventArgs e)
        {
            soluongcuoi3 = getValueSL(trasua3, sl3, soluong3, SoluongTs3);
            if (trasua3.Checked == true)
            {
                btnAddSL3.Enabled = true;
                btnTruSL3.Enabled = true;
            }
            else
            {
                btnAddSL3.Enabled = false;
                btnTruSL3.Enabled = false;
            }
        }
        private void SoluongTs3_TextChanged(object sender, EventArgs e)
        {
            if (trasua3.Checked == false)
            {
                sl3 = 0;
            }
            else
            {
                if (SoluongTs3.Text == "")
                {
                    sl3 = soluongcuoi3;
                }
                else
                {
                    soluongcuoi3 = sl3 + (int.Parse(SoluongTs3.Text) - sl3);
                }
            }
        }


        // Tra sua 4
        private void trasua4_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua4.Checked == true)
            {
                btnAddSL4.Enabled = true;
                btnTruSL4.Enabled = true;
            }
            else
            {
                btnAddSL4.Enabled = false;
                btnTruSL4.Enabled = false;
            }
            soluongcuoi4 = getValueSL(trasua4, sl4, soluong4, SoluongTs4);
        }
        private void SoluongTs4_TextChanged(object sender, EventArgs e)
        {
            if (trasua4.Checked == false)
            {
                sl4 = 0;
            }
            else
            {
                if (SoluongTs4.Text == "")
                {
                    sl4 = soluongcuoi4;
                }
                else
                {
                    soluongcuoi4 = sl4 + (int.Parse(SoluongTs4.Text) - sl4);
                }
            }
        }


        //Tra sua 5
        private void trasua5_CheckedChanged(object sender, EventArgs e)
        {
            soluongcuoi5 = getValueSL(trasua5, sl5, soluong5, SoluongTs5);
            if (trasua5.Checked == true)
            {
                btnAddSL5.Enabled = true;
                btnTruSL5.Enabled = true;
            }
            else
            {
                btnAddSL5.Enabled = false;
                btnTruSL5.Enabled = false;
            }
        }
        private void SoluongTs5_TextChanged(object sender, EventArgs e)
        {
            if (trasua5.Checked == false)
            {
                sl5 = 0;
            }
            else
            {
                if (SoluongTs5.Text == "")
                {
                    sl5 = soluongcuoi5;
                }
                else
                {
                    soluongcuoi5 = sl5 + (int.Parse(SoluongTs5.Text) - sl5);
                }
            }
        }


        //Tra sua 6
        private void trasua6_CheckedChanged(object sender, EventArgs e)
        {
            soluongcuoi6 = getValueSL(trasua6, sl6, soluong6, SoluongTs6);
            if (trasua6.Checked == true)
            {
                btnAddSL6.Enabled = true;
                btnTruSL6.Enabled = true;
            }
            else
            {
                btnAddSL6.Enabled = false;
                btnTruSL6.Enabled = false;
            }
        }


        private void SoluongTs6_TextChanged(object sender, EventArgs e)
        {
            if (trasua6.Checked == false)
            {
                sl6 = 0;
            }
            else
            {
                if (SoluongTs6.Text == "")
                {
                    sl6 = soluongcuoi6;
                }
                else
                {
                    soluongcuoi6 = sl6 + (int.Parse(SoluongTs6.Text) - sl6);
                }
            }
        }

        /*private void button1_Click_1(object sender, EventArgs e)
        {
            TestGia.Text = giaTS6.ToString();
        }*/


        // Xóa dòng được chọn trong ListView khi người dùng cần xóa 

        private void RemoveMon_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection list = listViewTS.SelectedItems;
            foreach (ListViewItem item in list)
            {
                listViewTS.Items.Remove(item);
            }
        }

        // Hiển thị số bàn theo số bàn chọn để quản lí
        private void Ban1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton soban = (RadioButton)sender;
            SoBanhientai.Text = soban.Text;
            ResetMenu();


            //Chọn bàn nào thì listView của bàn đó hiện lên
            if (Ban1.Checked == true)
            {
                listViewTS.Visible = true;
                listViewTS3.Visible = false;
                listViewTS2.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban1.ToString() + ".000 VNĐ";
            }
            if (Ban2.Checked == true)
            {
                listViewTS2.Visible = true;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban2.ToString() + ".000 VNĐ";
            }
            if (Ban3.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = true;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban3.ToString() + ".000 VNĐ";
            }
            if (Ban4.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = true;
                listViewTS5.Visible = false;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban4.ToString() + ".000 VNĐ";
            }
            if (Ban5.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = true;
                listViewTS6.Visible = false;
                TongBantxt.Text = tongban5.ToString() + ".000 VNĐ";
            }
            if (Ban6.Checked == true)
            {
                listViewTS2.Visible = false;
                listViewTS3.Visible = false;
                listViewTS.Visible = false;
                listViewTS4.Visible = false;
                listViewTS5.Visible = false;
                listViewTS6.Visible = true;
                TongBantxt.Text = tongban6.ToString() + ".000 VNĐ";
            }
        }

        //Tính tiền khi khách hàng gọi
        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            if (Ban1.Checked == true)
            {
                tongban1 = TinhTienBan(listViewTS, tongban1);
                if(checkThanThiet.Checked == true)
                {
                    tongban1 = tongban1 - (tongban1 * 5 / 100);
                }
                TongBantxt.Text = tongban1.ToString() + ".000 VNĐ";
            }
            if (Ban2.Checked == true)
            {
                tongban2 = TinhTienBan(listViewTS2, tongban2);
                if (checkThanThiet.Checked == true)
                {
                    tongban2 = tongban2 - (tongban2 * 5 / 100);
                }
                TongBantxt.Text = tongban2.ToString() + ".000 VNĐ";
            }
            if (Ban3.Checked == true)
            {
                tongban3 = TinhTienBan(listViewTS3, tongban3);
                if (checkThanThiet.Checked == true)
                {
                    tongban3 = tongban3 - (tongban3 * 5 / 100);
                }
                TongBantxt.Text = tongban3.ToString() + ".000 VNĐ";
            }
            if (Ban4.Checked == true)
            {
                tongban4 = TinhTienBan(listViewTS4, tongban4);
                if (checkThanThiet.Checked == true)
                {
                    tongban4 = tongban4 - (tongban4 * 5 / 100);
                }
                TongBantxt.Text = tongban4.ToString() + ".000 VNĐ";
            }
            if (Ban5.Checked == true)
            {
                tongban5 = TinhTienBan(listViewTS5, tongban5);
                if (checkThanThiet.Checked == true)
                {
                    tongban5 = tongban5 - (tongban5 * 5 / 100);
                }
                TongBantxt.Text = tongban5.ToString() + ".000 VNĐ";
            }
            if (Ban6.Checked == true)
            {
                tongban6 = TinhTienBan(listViewTS6, tongban6);
                if (checkThanThiet.Checked == true)
                {
                    tongban6 = tongban6 - (tongban6 * 5 / 100);
                }
                TongBantxt.Text = tongban6.ToString() + ".000 VNĐ";
            }

        }

        // Hàm để tính tiền từng bàn
        private int TinhTienBan(ListView lv, int tongban)
        {
            tongban = 0;
            foreach(ListViewItem item in lv.Items)
            {
                tongban += int.Parse(item.SubItems[2].Text.Substring(0, 2));
            }
            return tongban;
        }



        //Reset khi đổi bàn
        private void ResetMenu()
        {
            foreach (Control chk in Menu.Controls)
            {
                if (chk is CheckBox)
                    ((CheckBox)chk).Checked = false;

            }

            foreach (Control tbx in Menu.Controls)
            {
                if (tbx is TextBox)
                    ((TextBox)tbx).Text = "0";
            }
            foreach (Control size in Menu.Controls)
            {
                if (size is ComboBox)
                    ((ComboBox)size).Text = " ";
            }
        }
        
        
        
        // reset listView khi đổi bàn 
        private void ResetListView (ListView lv)
        {
            lv.Items.Clear();
        }

        //Hàm thêm món vào list khi check
        private void AddFoodListView(CheckBox trasuaX, ListView lv, ListViewItem item)
        {
            if (trasuaX.Checked == true)
            {
                item.Text = trasuaX.Text;
                lv.Items.Add(item);
                trasuaX.Checked = false;
            }
        }

        private void AddMon_Click(object sender, EventArgs e)
        {

            //lv1
            // Add món 1
            try
            {
                if (Ban1.Checked == true)
                {
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS1 = TinhTong(giaTS1, soluongcuoi1, tongtienTS1);
                        TestGia.Text = tongtienTS1.ToString();
                        ListViewItem itemlv11 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS, itemlv11);
                        itemlv11.SubItems.Add(SoluongTs1.Text);
                        itemlv11.SubItems.Add(TestGia.Text + ".000đ");
                        
                     }



                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }

                        tongtienTS2 = TinhTong(giaTS2, soluongcuoi2, tongtienTS2);
                        TestGia.Text = tongtienTS2.ToString();
                        ListViewItem itemlv12 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS, itemlv12);
                        itemlv12.SubItems.Add(SoluongTs2.Text);
                        itemlv12.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS3 = TinhTong(giaTS3, soluongcuoi3, tongtienTS3);
                        TestGia.Text = tongtienTS3.ToString();
                        ListViewItem itemlv13 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS, itemlv13);
                        itemlv13.SubItems.Add(SoluongTs3.Text);
                        itemlv13.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS4 = TinhTong(giaTS4, soluongcuoi4, tongtienTS4);
                        TestGia.Text = tongtienTS4.ToString();
                        ListViewItem itemlv14 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS, itemlv14);
                        itemlv14.SubItems.Add(SoluongTs4.Text);
                        itemlv14.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS5 = TinhTong(giaTS5, soluongcuoi5, tongtienTS5);
                        TestGia.Text = tongtienTS5.ToString();
                        ListViewItem itemlv15 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS, itemlv15);
                        itemlv15.SubItems.Add(SoluongTs5.Text);
                        itemlv15.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS6 = TinhTong(giaTS6, soluongcuoi6, tongtienTS6);
                        TestGia.Text = tongtienTS6.ToString();
                        ListViewItem itemlv16 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS, itemlv16);
                        itemlv16.SubItems.Add(SoluongTs6.Text);
                        itemlv16.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //
            /// Lv2
            /// // Add món 1
            ///

            try
            {
                if (Ban2.Checked == true)
                {

                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS1 = TinhTong(giaTS1, soluongcuoi1, tongtienTS1);
                        TestGia.Text = tongtienTS1.ToString();
                        ListViewItem itemlv21 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS2, itemlv21);
                        itemlv21.SubItems.Add(SoluongTs1.Text);
                        itemlv21.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS2 = TinhTong(giaTS2, soluongcuoi2, tongtienTS2);
                        TestGia.Text = tongtienTS2.ToString();
                        ListViewItem itemlv22 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS2, itemlv22);
                        itemlv22.SubItems.Add(SoluongTs2.Text);
                        itemlv22.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS3 = TinhTong(giaTS3, soluongcuoi3, tongtienTS3);
                        TestGia.Text = tongtienTS3.ToString();
                        ListViewItem itemlv23 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS2, itemlv23);
                        itemlv23.SubItems.Add(SoluongTs3.Text);
                        itemlv23.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS4 = TinhTong(giaTS4, soluongcuoi4, tongtienTS4);
                        TestGia.Text = tongtienTS4.ToString();
                        ListViewItem itemlv24 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS2, itemlv24);
                        itemlv24.SubItems.Add(SoluongTs4.Text);
                        itemlv24.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS5 = TinhTong(giaTS5, soluongcuoi5, tongtienTS5);
                        TestGia.Text = tongtienTS5.ToString();
                        ListViewItem itemlv25 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS2, itemlv25);
                        itemlv25.SubItems.Add(SoluongTs5.Text);
                        itemlv25.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS6 = TinhTong(giaTS6, soluongcuoi6, tongtienTS6);
                        TestGia.Text = tongtienTS6.ToString();
                        ListViewItem itemlv26 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS2, itemlv26);
                        itemlv26.SubItems.Add(SoluongTs6.Text);
                        itemlv26.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            //
            //lv3
            //Add mon lv3
            try
            {
                if (Ban3.Checked == true)
                {
                    if(trasua1.Checked == true)
                    {
                        if(SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS1 = TinhTong(giaTS1, soluongcuoi1, tongtienTS1);
                    TestGia.Text = tongtienTS1.ToString();
                    ListViewItem itemlv31 = new ListViewItem();
                    AddFoodListView(trasua1, listViewTS3, itemlv31);
                    itemlv31.SubItems.Add(SoluongTs1.Text);
                    itemlv31.SubItems.Add(TestGia.Text + ".000đ");
                    }
                    // Add món 1

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS2 = TinhTong(giaTS2, soluongcuoi2, tongtienTS2);
                        TestGia.Text = tongtienTS2.ToString();
                        ListViewItem itemlv32 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS3, itemlv32);
                        itemlv32.SubItems.Add(SoluongTs2.Text);
                        itemlv32.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS3 = TinhTong(giaTS3, soluongcuoi3, tongtienTS3);
                        TestGia.Text = tongtienTS3.ToString();
                        ListViewItem itemlv33 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS3, itemlv33);
                        itemlv33.SubItems.Add(SoluongTs3.Text);
                        itemlv33.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS4 = TinhTong(giaTS4, soluongcuoi4, tongtienTS4);
                        TestGia.Text = tongtienTS4.ToString();
                        ListViewItem itemlv34 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS3, itemlv34);
                        itemlv34.SubItems.Add(SoluongTs4.Text);
                        itemlv34.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS5 = TinhTong(giaTS5, soluongcuoi5, tongtienTS5);
                        TestGia.Text = tongtienTS5.ToString();
                        ListViewItem itemlv35 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS3, itemlv35);
                        itemlv35.SubItems.Add(SoluongTs5.Text);
                        itemlv35.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS6 = TinhTong(giaTS6, soluongcuoi6, tongtienTS6);
                        TestGia.Text = tongtienTS6.ToString();
                        ListViewItem itemlv36 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS3, itemlv36);
                        itemlv36.SubItems.Add(SoluongTs6.Text);
                        itemlv36.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //
            //lv4
            try
            {
                if (Ban4.Checked == true)
                {
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS1 = TinhTong(giaTS1, soluongcuoi1, tongtienTS1);
                        TestGia.Text = tongtienTS1.ToString();
                        ListViewItem itemlv41 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS4, itemlv41);
                        itemlv41.SubItems.Add(SoluongTs1.Text);
                        itemlv41.SubItems.Add(TestGia.Text + ".000đ");
                    }
                    // Add món 1

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS2 = TinhTong(giaTS2, soluongcuoi2, tongtienTS2);
                        TestGia.Text = tongtienTS2.ToString();
                        ListViewItem itemlv42 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS4, itemlv42);
                        itemlv42.SubItems.Add(SoluongTs2.Text);
                        itemlv42.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS3 = TinhTong(giaTS3, soluongcuoi3, tongtienTS3);
                        TestGia.Text = tongtienTS3.ToString();
                        ListViewItem itemlv43 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS4, itemlv43);
                        itemlv43.SubItems.Add(SoluongTs3.Text);
                        itemlv43.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS4 = TinhTong(giaTS4, soluongcuoi4, tongtienTS4);
                        TestGia.Text = tongtienTS4.ToString();
                        ListViewItem itemlv44 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS4, itemlv44);
                        itemlv44.SubItems.Add(SoluongTs4.Text);
                        itemlv44.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS5 = TinhTong(giaTS5, soluongcuoi5, tongtienTS5);
                        TestGia.Text = tongtienTS5.ToString();
                        ListViewItem itemlv45 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS4, itemlv45);
                        itemlv45.SubItems.Add(SoluongTs5.Text);
                        itemlv45.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS6 = TinhTong(giaTS6, soluongcuoi6, tongtienTS6);
                        TestGia.Text = tongtienTS6.ToString();
                        ListViewItem itemlv46 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS4, itemlv46);
                        itemlv46.SubItems.Add(SoluongTs6.Text);
                        itemlv46.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //
            //lv5 
            //Add mon ban 5
            try
            {
                if (Ban5.Checked == true)
                {
                    // Add món 1
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS1 = TinhTong(giaTS1, soluongcuoi1, tongtienTS1);
                        TestGia.Text = tongtienTS1.ToString();
                        ListViewItem itemlv51 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS5, itemlv51);
                        itemlv51.SubItems.Add(SoluongTs1.Text);
                        itemlv51.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS2 = TinhTong(giaTS2, soluongcuoi2, tongtienTS2);
                        TestGia.Text = tongtienTS2.ToString();
                        ListViewItem itemlv52 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS5, itemlv52);
                        itemlv52.SubItems.Add(SoluongTs2.Text);
                        itemlv52.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS3 = TinhTong(giaTS3, soluongcuoi3, tongtienTS3);
                        TestGia.Text = tongtienTS3.ToString();
                        ListViewItem itemlv53 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS5, itemlv53);
                        itemlv53.SubItems.Add(SoluongTs3.Text);
                        itemlv53.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS4 = TinhTong(giaTS4, soluongcuoi4, tongtienTS4);
                        TestGia.Text = tongtienTS4.ToString();
                        ListViewItem itemlv54 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS5, itemlv54);
                        itemlv54.SubItems.Add(SoluongTs4.Text);
                        itemlv54.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS5 = TinhTong(giaTS5, soluongcuoi5, tongtienTS5);
                        TestGia.Text = tongtienTS5.ToString();
                        ListViewItem itemlv55 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS5, itemlv55);
                        itemlv55.SubItems.Add(SoluongTs5.Text);
                        itemlv55.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS6 = TinhTong(giaTS6, soluongcuoi6, tongtienTS6);
                        TestGia.Text = tongtienTS6.ToString();
                        ListViewItem itemlv56 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS5, itemlv56);
                        itemlv56.SubItems.Add(SoluongTs6.Text);
                        itemlv56.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //
            //lv6
            //Add mon ban 6
            try
            {
                if (Ban6.Checked == true)
                {
                    // Add món 1
                    if (trasua1.Checked == true)
                    {
                        if (SoluongTs1.Text == " " || SoluongTs1.Text == "0")
                        {
                            trasua1.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS1 = TinhTong(giaTS1, soluongcuoi1, tongtienTS1);
                        TestGia.Text = tongtienTS1.ToString();
                        ListViewItem itemlv61 = new ListViewItem();
                        AddFoodListView(trasua1, listViewTS6, itemlv61);
                        itemlv61.SubItems.Add(SoluongTs1.Text);
                        itemlv61.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 2
                    if (trasua2.Checked == true)
                    {
                        if (SoluongTs2.Text == " " || SoluongTs2.Text == "0")
                        {
                            trasua2.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS2 = TinhTong(giaTS2, soluongcuoi2, tongtienTS2);
                        TestGia.Text = tongtienTS2.ToString();
                        ListViewItem itemlv62 = new ListViewItem();
                        AddFoodListView(trasua2, listViewTS6, itemlv62);
                        itemlv62.SubItems.Add(SoluongTs2.Text);
                        itemlv62.SubItems.Add(TestGia.Text + ".000đ");
                    }

                    //Add món 3
                    if (trasua3.Checked == true)
                    {
                        if (SoluongTs3.Text == " " || SoluongTs3.Text == "0")
                        {
                            trasua3.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS3 = TinhTong(giaTS3, soluongcuoi3, tongtienTS3);
                        TestGia.Text = tongtienTS3.ToString();
                        ListViewItem itemlv63 = new ListViewItem();
                        AddFoodListView(trasua3, listViewTS6, itemlv63);
                        itemlv63.SubItems.Add(SoluongTs3.Text);
                        itemlv63.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 4
                    if (trasua4.Checked == true)
                    {
                        if (SoluongTs4.Text == " " || SoluongTs4.Text == "0")
                        {
                            trasua4.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS4 = TinhTong(giaTS4, soluongcuoi4, tongtienTS4);
                        TestGia.Text = tongtienTS4.ToString();
                        ListViewItem itemlv64 = new ListViewItem();
                        AddFoodListView(trasua4, listViewTS6, itemlv64);
                        itemlv64.SubItems.Add(SoluongTs4.Text);
                        itemlv64.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 5
                    if (trasua5.Checked == true)
                    {
                        if (SoluongTs5.Text == " " || SoluongTs5.Text == "0")
                        {
                            trasua5.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS5 = TinhTong(giaTS5, soluongcuoi5, tongtienTS5);
                        TestGia.Text = tongtienTS5.ToString();
                        ListViewItem itemlv65 = new ListViewItem();
                        AddFoodListView(trasua5, listViewTS6, itemlv65);
                        itemlv65.SubItems.Add(SoluongTs5.Text);
                        itemlv65.SubItems.Add(TestGia.Text + ".000đ");

                    }

                    //Add món 6

                    if (trasua6.Checked == true)
                    {
                        if (SoluongTs6.Text == " " || SoluongTs6.Text == "0")
                        {
                            trasua6.Checked = false;
                            throw new Exception("Bạn phải nhập số lượng");
                        }
                        tongtienTS6 = TinhTong(giaTS6, soluongcuoi6, tongtienTS6);
                        TestGia.Text = tongtienTS6.ToString();
                        ListViewItem itemlv66 = new ListViewItem();
                        AddFoodListView(trasua6, listViewTS6, itemlv66);
                        itemlv66.SubItems.Add(SoluongTs6.Text);
                        itemlv66.SubItems.Add(TestGia.Text + ".000đ");

                    }

                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
           }

        }


        // Hàm tính tổng tiền của mỗi món sau khi chọn xong
        private int TinhTong ( int giats, int soluong,int tong)
        {
            tong = giats * soluong;
            return tong;
        }
    }


 }// 1523 dong 
