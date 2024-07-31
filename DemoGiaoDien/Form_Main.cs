using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGiaoDien
{
    public partial class Form_Main : Form
    {
        public Form_Main() // Constructor
        {
            InitializeComponent();
        }

        private void btn_FormA_Click(object sender, EventArgs e)
        {
            // Xóa hết các control hiện hữu trên panel
            pn_Interface.Controls.Clear();
            // Khi click vào Button này sẽ mở form A trên Panel
            // Bước 1: Tạo ra 1 đối tượng FormA đã
            FormA formA = new FormA();
            // Bước 2: Nhét FormA đã tạo vào panel đồng thời Set TopLevel của form về False
            formA.TopLevel = false;
            pn_Interface.Controls.Add(formA);
            formA.Show(); // ShowDialog sẽ chỉ thực hiện khi nó là toplevel
            formA.FormBorderStyle = FormBorderStyle.None;
            // Set vị trí (so với Parent - Control chứa nó)
            formA.Location = new Point(20, 20);
        }

        private void OpenFormB(object sender, EventArgs e)
        {
            pn_Interface.Controls.Clear();
            // Khi click vào Button này sẽ mở form B trên Panel
            // Khi click vào Button này sẽ mở form B trên Panel
            // Bước 1: Tạo ra 1 đối tượng FormA đã
            FormB formB = new FormB();
            // Bước 2: Nhét FormA đã tạo vào panel đồng thời Set TopLevel của form về False
            formB.TopLevel = false;
            pn_Interface.Controls.Add(formB);
            formB.Show(); // ShowDialog sẽ chỉ thực hiện khi nó là toplevel
            formB.FormBorderStyle = FormBorderStyle.None;
        }

        private void GenGiaoDien(object sender, EventArgs e)
        {
            pn_Interface.Controls.Clear();
            // Tạo 1 nút để add vào panel
            Button btn_A = new Button();
            // 2. Set thuộc tính cho Button
            btn_A.Size = new Size(129, 51);
            btn_A.Location = new Point(9, 12);
            btn_A.Text = "Mở Form A new";
            btn_A.BackColor = Color.White;
            btn_A.Font = new Font("SegoeUI", 12);
            pn_Interface.Controls.Add(btn_A);
            // Có Control rồi thì Tạo sự kiện như thế nào?
            // Gen sự kiện băng cú pháp tên_control.Loại_SK += tab tab
            btn_A.Click += Btn_A_Click; 
        }

        private void Btn_A_Click(object? sender, EventArgs e)
        {
            // Khi Click vào Nút được tạo ra nó sẽ Hiển thị ra FormA
            FormA formA = new FormA();
            // Bước 2: Nhét FormA đã tạo vào panel đồng thời Set TopLevel của form về False
            formA.TopLevel = false;
            pn_Interface.Controls.Add(formA);
            formA.Show(); // ShowDialog sẽ chỉ thực hiện khi nó là toplevel
            formA.FormBorderStyle = FormBorderStyle.None;
            // Set vị trí (so với Parent - Control chứa nó)
            formA.Location = new Point(20, 20);
            // Tôi muốn FormA nằm trong Panel cũng được ra = CODE????
        }

        private void btn_GenPanel_Click(object sender, EventArgs e)
        {
            // Tạo 1 Panel
            Panel pn_GD = new Panel();
            pn_GD.Name = "pn_GDName"; // Lưu ý, thuộc tính Name của Pnale khác tên của đối tượng
            pn_GD.Location = new Point(144, 12);
            pn_GD.Size = new Size(823, 529);
            pn_GD.BackColor = Color.Red;
            this.Controls.Add(pn_GD); // This chính là cái form mình đnag động tới
            pn_Interface.Hide(); // Ẩn panel kia đi để nó không hiện ra che mất cái mới tạo
        }

        private void btn_GenNew_Click(object sender, EventArgs e)
        {
            // Sự kiện này sẽ Gen ra 1 Button trên chính Panel màu đỏ mà ta tạo
            // Bước 1: Lấy ra chính Panel đó trên FormMain
            Panel x;
            List<Panel> listPanel = new List<Panel>();
            foreach (var item in this.Controls) // Duyệt trên tất cả các control nằm trong formMain
            {
                if(item is Panel)
                {
                    listPanel.Add(item as Panel);
                }
            }
            foreach (Panel item in listPanel)
            {
                if (item.Name == "pn_GDName")
                {
                    x = item;
                    Button btn_ANew = new Button();
                    // 2. Set thuộc tính cho Button
                    btn_ANew.Size = new Size(129, 51);
                    btn_ANew.Location = new Point(9, 12);
                    btn_ANew.Text = "Mở Form A new";
                    btn_ANew.BackColor = Color.White;
                    btn_ANew.Font = new Font("SegoeUI", 12);
                    x.Controls.Add(btn_ANew);
                    // Có Control rồi thì Tạo sự kiện như thế nào?
                    // Gen sự kiện băng cú pháp tên_control.Loại_SK += tab tab
                    btn_ANew.Click += Btn_ANew_Click;
                    break;
                }
            }         
        }
        private void Btn_ANew_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Quá là kute");
        }
    }
}
