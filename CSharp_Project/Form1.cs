using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Application.Run(new Form2());
            DataManager.selectQuery(int.Parse(label_main_tablenum.Text));
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            refreshScreen();

            string record = dateTimePicker1.Value.ToString();
            string[] records = record.Split(' ');
            DataManager.selectQuery_mtotal(records[0]);
            dataGridView5.DataSource = DataManager.totalCals;
        }
        void insert_null()
        {
            textBox_mainmenu1.Text = null;
            textBox_mainmenu2.Text = null;
            textBox_mainmenu3.Text = null;
            textBox_mainmenu4.Text = null;
            textBox_mainmenu5.Text = null;
            textBox_mainmenu6.Text = null;
            textBox_mainmenu7.Text = null;
            textBox_mainmenu8.Text = null;

            textBox_sidemenu1.Text = null;
            textBox_sidemenu2.Text = null;
            textBox_sidemenu3.Text = null;
            textBox_sidemenu4.Text = null;
            textBox_sidemenu5.Text = null;
            textBox_sidemenu6.Text = null;
            textBox_sidemenu7.Text = null;
            textBox_sidemenu8.Text = null;

            textBox_bavemenu1.Text = null;
            textBox_bavemenu2.Text = null;
            textBox_bavemenu3.Text = null;
            textBox_bavemenu4.Text = null;
            textBox_bavemenu5.Text = null;
            textBox_bavemenu6.Text = null;
            textBox_bavemenu7.Text = null;
            textBox_bavemenu8.Text = null;

            textBox_addmenu1.Text = null;
            textBox_addmenu2.Text = null;
            textBox_addmenu3.Text = null;
            textBox_addmenu4.Text = null;
            textBox_addmenu5.Text = null;
            textBox_addmenu6.Text = null;
            textBox_addmenu7.Text = null;
            textBox_addmenu8.Text = null;

        }
        void refreshScreen()
        {
            dataGridView1.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView1.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView2.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView2.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView3.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView3.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            dataGridView4.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView4.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView7.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView7.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //메인 버튼부 -------------------------------------------------------------( btn_parking_close_Click  주석풀어주기)
        private void btn_order_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_order.Visible = false;
            btn_order_close.Visible = true;
            panel_lab1.Visible = true;

            //다른 버튼 실행 끄기
            btn_table_close_Click(sender, e);
            btn_calculate_close_Click(sender, e);
            btn_parking_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab2.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            //내부의 데이타그리드뷰 초기화
            dataGridView7.DataSource = null;

            //버튼교체
            btn_table.Visible = false;
            btn_table_close.Visible = true;
            panel_lab2.Visible = true;

            //다른 버튼 실행 끄기
            btn_order_close_Click(sender, e);
            btn_calculate_close_Click(sender, e);
            btn_parking_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab1.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
            
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //버튼교체
            Form3 form3 = new Form3();
            form3.ShowDialog();

            /*
            //다른 버튼 실행 끄기
            btn_order_close_Click(sender, e);
            btn_table_close_Click(sender, e);
            btn_parking_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab1.Visible = false;
            panel_lab2.Visible = false;
            panel_lab4.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
            */
        }

        private void btn_parking_Click(object sender, EventArgs e)
        {
            //버튼교체

            //다른 버튼 실행 끄기
            btn_order_close_Click(sender, e);
            btn_table_close_Click(sender, e);
            btn_calculate_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab1.Visible = false;
            panel_lab2.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
        }

        private void btn_order_close_Click(object sender, EventArgs e)
        {
            btn_order_close.Visible = false;
            btn_order.Visible = true;
            panel_lab1.Visible = false;

            //메뉴 내용들 끄기
            panel_mainmenu.Visible = false;
            panel_sidemenu.Visible = false;
            panel_baverage.Visible = false;
            panel_addmenu.Visible = false;
        }

        private void btn_table_close_Click(object sender, EventArgs e)
        {
            btn_table_close.Visible = false;
            btn_table.Visible = true;
            panel_lab2.Visible = false;
        }

        private void btn_calculate_close_Click(object sender, EventArgs e)
        {
            btn_calculate_close.Visible = false;
            btn_calculate.Visible = true;
        }

        private void btn_parking_close_Click(object sender, EventArgs e)
        {
            /*btn_parking_close.Visible = false;
            btn_parking.Visible = true;
            panel_lab4.Visible = false;*/
        }



        //주문 버튼부---------------------------------------------------------------------
        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_mainmenu.Visible = false;
            btn_mainmenu_close.Visible = true;
            panel_mainmenu.Visible = true;

            //다른 버튼 실행 끄기
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);


            //다른 판넬 끄기
            panel_sidemenu.Visible = false;
            panel_baverage.Visible = false;
            panel_addmenu.Visible = false;

            //첫실행 데이터뷰끄기
            dataGridView1.DataSource = null;
        }

        private void btn_sidemenu_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_sidemenu.Visible = false;
            btn_sidemenu_close.Visible = true;
            panel_sidemenu.Visible = true;

            //다른 버튼 실행 끄기
            btn_mainmenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);

            //다른 판넬 끄기
            panel_mainmenu.Visible = false;
            panel_baverage.Visible = false;
            panel_addmenu.Visible = false;

            //첫실행 데이터뷰끄기
            dataGridView2.DataSource = null;
        }

        private void btn_beverage_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_beverage.Visible = false;
            btn_beverage_close.Visible = true;
            panel_baverage.Visible = true;

            //다른 버튼 실행 끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);

            //다른 판넬 끄기
            panel_mainmenu.Visible = false;
            panel_sidemenu.Visible = false;
            panel_addmenu.Visible = false;

            //첫실행 데이터뷰 끄기
            dataGridView3.DataSource = null;
        }

        private void btn_addmenu_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_addmenu.Visible = false;
            btn_addmenu_close.Visible = true;
            panel_addmenu.Visible = true;

            //다른 버튼 실행 끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);

            //다른 판넬 끄기
            panel_mainmenu.Visible = false;
            panel_sidemenu.Visible = false;
            panel_baverage.Visible = false;

            //첫실행 데이터뷰 끄기
            dataGridView4.DataSource = null;
        }

        private void btn_mainmenu_close_Click(object sender, EventArgs e)
        {
            btn_mainmenu.Visible = true;
            btn_mainmenu_close.Visible = false;
            panel_mainmenu.Visible = false;
        }

        private void btn_sidemenu_close_Click(object sender, EventArgs e)
        {
            btn_sidemenu.Visible = true;
            btn_sidemenu_close.Visible = false;
            panel_sidemenu.Visible = false;
        }

        private void btn_beverage_close_Click(object sender, EventArgs e)
        {
            btn_beverage.Visible = true;
            btn_beverage_close.Visible = false;
            panel_baverage.Visible = false;
        }

        private void btn_addmenu_close_Click(object sender, EventArgs e)
        {
            btn_addmenu.Visible = true;
            btn_addmenu_close.Visible = false;
            panel_addmenu.Visible = false;
        }

        //창닫기 버튼--------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //주문부 테이블 선택버튼---------------------------------------------------------
        //
        //테이블 선택버튼(메인메뉴)
        private void btn_main_tablenum1_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "1번 테이블";
        }

        private void btn_main_tablenum2_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "2번 테이블";
        }

        private void btn_main_tablenum3_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "3번 테이블";
        }

        private void btn_main_tablenum4_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "4번 테이블";
        }

        private void btn_main_tablenum5_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "5번 테이블";
        }

        private void btn_main_tablenum6_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "6번 테이블";
        }

        private void btn_main_tablenum7_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "7번 테이블";
        }

        private void btn_main_tablenum8_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "8번 테이블";
        }

        private void btn_main_tablenum9_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "9번 테이블";
        }

        private void btn_main_tablenum10_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "10번 테이블";
        }

        private void btn_main_tablenum11_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "11번 테이블";
        }

        private void btn_main_tablenum12_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "12번 테이블";
        }

        private void btn_main_tablenum13_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "13번 테이블";
        }

        private void btn_main_tablenum14_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "14번 테이블";
        }

        private void btn_main_tablenum15_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "15번 테이블";
        }

        private void btn_main_tablenum16_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "16번 테이블";
        }

        //
        //테이블 선택버튼(사이드 메뉴)
        private void btn_side_tablenum1_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "1번 테이블";
        }

        private void btn_side_tablenum2_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "2번 테이블";
        }

        private void btn_side_tablenum3_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "3번 테이블";
        }

        private void btn_side_tablenum4_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "4번 테이블";
        }

        private void btn_side_tablenum5_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "5번 테이블";
        }

        private void btn_side_tablenum6_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "6번 테이블";
        }

        private void btn_side_tablenum7_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "7번 테이블";
        }

        private void btn_side_tablenum8_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "8번 테이블";
        }

        private void btn_side_tablenum9_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "9번 테이블";
        }

        private void btn_side_tablenum10_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "10번 테이블";
        }

        private void btn_side_tablenum11_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "11번 테이블";
        }

        private void btn_side_tablenum12_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "12번 테이블";
        }

        private void btn_side_tablenum13_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "13번 테이블";
        }

        private void btn_side_tablenum14_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "14번 테이블";
        }

        private void btn_side_tablenum15_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "15번 테이블";
        }

        private void btn_side_tablenum16_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "16번 테이블";
        }

        //
        //테이블 선택버튼(음료 메뉴)
        private void btn_bave_tablenum1_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "1번 테이블";
        }

        private void btn_bave_tablenum2_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "2번 테이블";
        }

        private void btn_bave_tablenum3_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "3번 테이블";
        }

        private void btn_bave_tablenum4_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "4번 테이블";
        }

        private void btn_bave_tablenum5_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "5번 테이블";
        }

        private void btn_bave_tablenum6_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "6번 테이블";
        }

        private void btn_bave_tablenum7_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "7번 테이블";
        }

        private void btn_bave_tablenum8_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "8번 테이블";
        }

        private void btn_bave_tablenum9_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "9번 테이블";
        }

        private void btn_bave_tablenum10_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "10번 테이블";
        }

        private void btn_bave_tablenum11_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "11번 테이블";
        }

        private void btn_bave_tablenum12_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "12번 테이블";
        }

        private void btn_bave_tablenum13_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "13번 테이블";
        }

        private void btn_bave_tablenum14_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "14번 테이블";
        }

        private void btn_bave_tablenum15_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "15번 테이블";
        }

        private void btn_bave_tablenum16_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "16번 테이블";
        }

        //
        //테이블 선택버튼(추가메뉴)
        private void btn_add_tablenum1_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "1번 테이블";
        }

        private void btn_add_tablenum2_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "2번 테이블";
        }

        private void btn_add_tablenum3_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "3번 테이블";
        }

        private void btn_add_tablenum4_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "4번 테이블";
        }

        private void btn_add_tablenum5_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "5번 테이블";
        }

        private void btn_add_tablenum6_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "6번 테이블";
        }

        private void btn_add_tablenum7_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "7번 테이블";
        }

        private void btn_add_tablenum8_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "8번 테이블";
        }

        private void btn_add_tablenum9_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "9번 테이블";
        }

        private void btn_add_tablenum10_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "10번 테이블";
        }

        private void btn_add_tablenum11_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "11번 테이블";
        }

        private void btn_add_tablenum12_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "12번 테이블";
        }

        private void btn_add_tablenum13_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "13번 테이블";
        }

        private void btn_add_tablenum14_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "14번 테이블";
        }

        private void btn_add_tablenum15_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "15번 테이블";
        }

        private void btn_add_tablenum16_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "16번 테이블";
        }

        //
        //메인메뉴 주문 버튼----------------------------------------------------------------
        
        private void btn_mainmenu_add_Click(object sender, EventArgs e)
        {
            List<string> mainmenus = new List<string>();
            mainmenus.Add(mainmenu1.Text);
            mainmenus.Add(mainmenu2.Text);
            mainmenus.Add(mainmenu3.Text);
            mainmenus.Add(mainmenu4.Text);
            mainmenus.Add(mainmenu5.Text);
            mainmenus.Add(mainmenu6.Text);
            mainmenus.Add(mainmenu7.Text);
            mainmenus.Add(mainmenu8.Text);

            List<string> tbox_mainmenus = new List<string>();
            tbox_mainmenus.Add(textBox_mainmenu1.Text);
            tbox_mainmenus.Add(textBox_mainmenu2.Text);
            tbox_mainmenus.Add(textBox_mainmenu3.Text);
            tbox_mainmenus.Add(textBox_mainmenu4.Text);
            tbox_mainmenus.Add(textBox_mainmenu5.Text);
            tbox_mainmenus.Add(textBox_mainmenu6.Text);
            tbox_mainmenus.Add(textBox_mainmenu7.Text);
            tbox_mainmenus.Add(textBox_mainmenu8.Text);
            if (label_main_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if(label_main_tablenum.Text != "0")
            {
                for(int i =1; i<17; i++)
                {
                    if(label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for(int j =0; j<8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_mainmenus[j])))
                            {
                                //DataManager.executeQuery("delete", mainmenus[j],tbox_mainmenus[j], i.ToString());
                                DataManager.executeQuery("insert",$"{i} - "+mainmenus[j],tbox_mainmenus[j] ,i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_main_tablenum.Text = "0";
            label_main_tablenum.Visible = false;
            insert_null();
        }
        private void btn_mainmenu_delete_Click(object sender, EventArgs e)
        {
            List<string> mainmenus = new List<string>();
            mainmenus.Add(mainmenu1.Text);
            mainmenus.Add(mainmenu2.Text);
            mainmenus.Add(mainmenu3.Text);
            mainmenus.Add(mainmenu4.Text);
            mainmenus.Add(mainmenu5.Text);
            mainmenus.Add(mainmenu6.Text);
            mainmenus.Add(mainmenu7.Text);
            mainmenus.Add(mainmenu8.Text);

            List<string> tbox_mainmenus = new List<string>();
            tbox_mainmenus.Add(textBox_mainmenu1.Text);
            tbox_mainmenus.Add(textBox_mainmenu2.Text);
            tbox_mainmenus.Add(textBox_mainmenu3.Text);
            tbox_mainmenus.Add(textBox_mainmenu4.Text);
            tbox_mainmenus.Add(textBox_mainmenu5.Text);
            tbox_mainmenus.Add(textBox_mainmenu6.Text);
            tbox_mainmenus.Add(textBox_mainmenu7.Text);
            tbox_mainmenus.Add(textBox_mainmenu8.Text);
            if (label_main_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_main_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_mainmenus[j])))
                            {
                                DataManager.executeQuery("delete", $"{i} - " + mainmenus[j],tbox_mainmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_main_tablenum.Text = "0";
            label_main_tablenum.Visible = false;
            insert_null();
        }

        private void btn_mainmenu_update_Click(object sender, EventArgs e)
        {
            List<string> mainmenus = new List<string>();
            mainmenus.Add(mainmenu1.Text);
            mainmenus.Add(mainmenu2.Text);
            mainmenus.Add(mainmenu3.Text);
            mainmenus.Add(mainmenu4.Text);
            mainmenus.Add(mainmenu5.Text);
            mainmenus.Add(mainmenu6.Text);
            mainmenus.Add(mainmenu7.Text);
            mainmenus.Add(mainmenu8.Text);

            List<string> tbox_mainmenus = new List<string>();
            tbox_mainmenus.Add(textBox_mainmenu1.Text);
            tbox_mainmenus.Add(textBox_mainmenu2.Text);
            tbox_mainmenus.Add(textBox_mainmenu3.Text);
            tbox_mainmenus.Add(textBox_mainmenu4.Text);
            tbox_mainmenus.Add(textBox_mainmenu5.Text);
            tbox_mainmenus.Add(textBox_mainmenu6.Text);
            tbox_mainmenus.Add(textBox_mainmenu7.Text);
            tbox_mainmenus.Add(textBox_mainmenu8.Text);
            if (label_main_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_main_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_mainmenus[j])))
                            {
                                DataManager.executeQuery("update", $"{i} - " + mainmenus[j], tbox_mainmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_main_tablenum.Text = "0";
            label_main_tablenum.Visible = false;
            insert_null();
        }

        //사이드메뉴 버튼---------------------------------------------------------------------------------
        private void btn_sidemenu_add_Click(object sender, EventArgs e)
        {
            List<string> sidemenus = new List<string>();
            sidemenus.Add(sidemenu1.Text);
            sidemenus.Add(sidemenu2.Text);
            sidemenus.Add(sidemenu3.Text);
            sidemenus.Add(sidemenu4.Text);
            sidemenus.Add(sidemenu5.Text);
            sidemenus.Add(sidemenu6.Text);
            sidemenus.Add(sidemenu7.Text);
            sidemenus.Add(sidemenu8.Text);

            List<string> tbox_sidemenus = new List<string>();
            tbox_sidemenus.Add(textBox_sidemenu1.Text);
            tbox_sidemenus.Add(textBox_sidemenu2.Text);
            tbox_sidemenus.Add(textBox_sidemenu3.Text);
            tbox_sidemenus.Add(textBox_sidemenu4.Text);
            tbox_sidemenus.Add(textBox_sidemenu5.Text);
            tbox_sidemenus.Add(textBox_sidemenu6.Text);
            tbox_sidemenus.Add(textBox_sidemenu7.Text);
            tbox_sidemenus.Add(textBox_sidemenu8.Text);

            if (label_side_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_side_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_side_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_sidemenus[j])))
                            {
                                DataManager.executeQuery("insert", $"{i} - " + sidemenus[j], tbox_sidemenus[j],i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_side_tablenum.Text = "0";
            label_side_tablenum.Visible = false;
            insert_null();
        }
        private void btn_sidemenu_delete_Click(object sender, EventArgs e)
        {
            List<string> sidemenus = new List<string>();
            sidemenus.Add(sidemenu1.Text);
            sidemenus.Add(sidemenu2.Text);
            sidemenus.Add(sidemenu3.Text);
            sidemenus.Add(sidemenu4.Text);
            sidemenus.Add(sidemenu5.Text);
            sidemenus.Add(sidemenu6.Text);
            sidemenus.Add(sidemenu7.Text);
            sidemenus.Add(sidemenu8.Text);

            List<string> tbox_sidemenus = new List<string>();
            tbox_sidemenus.Add(textBox_sidemenu1.Text);
            tbox_sidemenus.Add(textBox_sidemenu2.Text);
            tbox_sidemenus.Add(textBox_sidemenu3.Text);
            tbox_sidemenus.Add(textBox_sidemenu4.Text);
            tbox_sidemenus.Add(textBox_sidemenu5.Text);
            tbox_sidemenus.Add(textBox_sidemenu6.Text);
            tbox_sidemenus.Add(textBox_sidemenu7.Text);
            tbox_sidemenus.Add(textBox_sidemenu8.Text);

            if (label_side_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_side_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_side_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_sidemenus[j])))
                            {
                                DataManager.executeQuery("delete", $"{i} - " + sidemenus[j], tbox_sidemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_side_tablenum.Text = "0";
            label_side_tablenum.Visible = false;
            insert_null();
        }

        private void btn_sidemenu_update_Click(object sender, EventArgs e)
        {
            List<string> sidemenus = new List<string>();
            sidemenus.Add(sidemenu1.Text);
            sidemenus.Add(sidemenu2.Text);
            sidemenus.Add(sidemenu3.Text);
            sidemenus.Add(sidemenu4.Text);
            sidemenus.Add(sidemenu5.Text);
            sidemenus.Add(sidemenu6.Text);
            sidemenus.Add(sidemenu7.Text);
            sidemenus.Add(sidemenu8.Text);

            List<string> tbox_sidemenus = new List<string>();
            tbox_sidemenus.Add(textBox_sidemenu1.Text);
            tbox_sidemenus.Add(textBox_sidemenu2.Text);
            tbox_sidemenus.Add(textBox_sidemenu3.Text);
            tbox_sidemenus.Add(textBox_sidemenu4.Text);
            tbox_sidemenus.Add(textBox_sidemenu5.Text);
            tbox_sidemenus.Add(textBox_sidemenu6.Text);
            tbox_sidemenus.Add(textBox_sidemenu7.Text);
            tbox_sidemenus.Add(textBox_sidemenu8.Text);

            if (label_side_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_side_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_side_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_sidemenus[j])))
                            {
                                DataManager.executeQuery("update", $"{i} - " + sidemenus[j], tbox_sidemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_side_tablenum.Text = "0";
            label_side_tablenum.Visible = false;
            insert_null();
        }

        //음료메뉴 버튼 -------------------------------------------------------------------------------------
        private void btn_bavemenu_add_Click(object sender, EventArgs e)
        {
            List<string> bavemenus = new List<string>();
            bavemenus.Add(bavemenu1.Text);
            bavemenus.Add(bavemenu2.Text);
            bavemenus.Add(bavemenu3.Text);
            bavemenus.Add(bavemenu4.Text);
            bavemenus.Add(bavemenu5.Text);
            bavemenus.Add(bavemenu6.Text);
            bavemenus.Add(bavemenu7.Text);
            bavemenus.Add(bavemenu8.Text);

            List<string> tbox_bavemenus = new List<string>();
            tbox_bavemenus.Add(textBox_bavemenu1.Text);
            tbox_bavemenus.Add(textBox_bavemenu2.Text);
            tbox_bavemenus.Add(textBox_bavemenu3.Text);
            tbox_bavemenus.Add(textBox_bavemenu4.Text);
            tbox_bavemenus.Add(textBox_bavemenu5.Text);
            tbox_bavemenus.Add(textBox_bavemenu6.Text);
            tbox_bavemenus.Add(textBox_bavemenu7.Text);
            tbox_bavemenus.Add(textBox_bavemenu8.Text);

            if (label_bave_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_bave_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_bave_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_bavemenus[j])))
                            {
                                DataManager.executeQuery("insert", $"{i} - " + bavemenus[j], tbox_bavemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_bave_tablenum.Text = "0";
            label_bave_tablenum.Visible = false;
            insert_null();
        }
        private void btn_bavemenu_delete_Click(object sender, EventArgs e)
        {
            List<string> bavemenus = new List<string>();
            bavemenus.Add(bavemenu1.Text);
            bavemenus.Add(bavemenu2.Text);
            bavemenus.Add(bavemenu3.Text);
            bavemenus.Add(bavemenu4.Text);
            bavemenus.Add(bavemenu5.Text);
            bavemenus.Add(bavemenu6.Text);
            bavemenus.Add(bavemenu7.Text);
            bavemenus.Add(bavemenu8.Text);

            List<string> tbox_bavemenus = new List<string>();
            tbox_bavemenus.Add(textBox_bavemenu1.Text);
            tbox_bavemenus.Add(textBox_bavemenu2.Text);
            tbox_bavemenus.Add(textBox_bavemenu3.Text);
            tbox_bavemenus.Add(textBox_bavemenu4.Text);
            tbox_bavemenus.Add(textBox_bavemenu5.Text);
            tbox_bavemenus.Add(textBox_bavemenu6.Text);
            tbox_bavemenus.Add(textBox_bavemenu7.Text);
            tbox_bavemenus.Add(textBox_bavemenu8.Text);

            if (label_bave_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_bave_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_bave_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_bavemenus[j])))
                            {
                                DataManager.executeQuery("delete", $"{i} - " + bavemenus[j], tbox_bavemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_bave_tablenum.Text = "0";
            label_bave_tablenum.Visible = false;
            insert_null();
        }

        private void btn_bavemenu_update_Click(object sender, EventArgs e)
        {
            List<string> bavemenus = new List<string>();
            bavemenus.Add(bavemenu1.Text);
            bavemenus.Add(bavemenu2.Text);
            bavemenus.Add(bavemenu3.Text);
            bavemenus.Add(bavemenu4.Text);
            bavemenus.Add(bavemenu5.Text);
            bavemenus.Add(bavemenu6.Text);
            bavemenus.Add(bavemenu7.Text);
            bavemenus.Add(bavemenu8.Text);

            List<string> tbox_bavemenus = new List<string>();
            tbox_bavemenus.Add(textBox_bavemenu1.Text);
            tbox_bavemenus.Add(textBox_bavemenu2.Text);
            tbox_bavemenus.Add(textBox_bavemenu3.Text);
            tbox_bavemenus.Add(textBox_bavemenu4.Text);
            tbox_bavemenus.Add(textBox_bavemenu5.Text);
            tbox_bavemenus.Add(textBox_bavemenu6.Text);
            tbox_bavemenus.Add(textBox_bavemenu7.Text);
            tbox_bavemenus.Add(textBox_bavemenu8.Text);

            if (label_bave_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_bave_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_bave_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_bavemenus[j])))
                            {
                                DataManager.executeQuery("update", $"{i} - " + bavemenus[j], tbox_bavemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_bave_tablenum.Text = "0";
            label_bave_tablenum.Visible = false;
            insert_null();
        }

        //추가메뉴 버튼 -------------------------------------------------------------------------------------
        private void btn_addmenu_add_Click(object sender, EventArgs e)
        {
            List<string> addmenus = new List<string>();
            addmenus.Add(addmenu1.Text);
            addmenus.Add(addmenu2.Text);
            addmenus.Add(addmenu3.Text);
            addmenus.Add(addmenu4.Text);
            addmenus.Add(addmenu5.Text);
            addmenus.Add(addmenu6.Text);
            addmenus.Add(addmenu7.Text);
            addmenus.Add(addmenu8.Text);

            List<string> tbox_addmenus = new List<string>();
            tbox_addmenus.Add(textBox_addmenu1.Text);
            tbox_addmenus.Add(textBox_addmenu2.Text);
            tbox_addmenus.Add(textBox_addmenu3.Text);
            tbox_addmenus.Add(textBox_addmenu4.Text);
            tbox_addmenus.Add(textBox_addmenu5.Text);
            tbox_addmenus.Add(textBox_addmenu6.Text);
            tbox_addmenus.Add(textBox_addmenu7.Text);
            tbox_addmenus.Add(textBox_addmenu8.Text);

            if (label_add_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_add_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_add_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_addmenus[j])))
                            {
                                DataManager.executeQuery("insert", $"{i} - " + addmenus[j], tbox_addmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_add_tablenum.Text = "0";
            label_add_tablenum.Visible = false;
            insert_null();
        }
        private void btn_addmenu_delete_Click(object sender, EventArgs e)
        {
            List<string> addmenus = new List<string>();
            addmenus.Add(addmenu1.Text);
            addmenus.Add(addmenu2.Text);
            addmenus.Add(addmenu3.Text);
            addmenus.Add(addmenu4.Text);
            addmenus.Add(addmenu5.Text);
            addmenus.Add(addmenu6.Text);
            addmenus.Add(addmenu7.Text);
            addmenus.Add(addmenu8.Text);

            List<string> tbox_addmenus = new List<string>();
            tbox_addmenus.Add(textBox_addmenu1.Text);
            tbox_addmenus.Add(textBox_addmenu2.Text);
            tbox_addmenus.Add(textBox_addmenu3.Text);
            tbox_addmenus.Add(textBox_addmenu4.Text);
            tbox_addmenus.Add(textBox_addmenu5.Text);
            tbox_addmenus.Add(textBox_addmenu6.Text);
            tbox_addmenus.Add(textBox_addmenu7.Text);
            tbox_addmenus.Add(textBox_addmenu8.Text);

            if (label_add_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_add_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_add_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_addmenus[j])))
                            {
                                DataManager.executeQuery("delete", $"{i} - " + addmenus[j], tbox_addmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_add_tablenum.Text = "0";
            label_add_tablenum.Visible = false;
            insert_null();
        }

        private void btn_addmenu_update_Click(object sender, EventArgs e)
        {
            List<string> addmenus = new List<string>();
            addmenus.Add(addmenu1.Text);
            addmenus.Add(addmenu2.Text);
            addmenus.Add(addmenu3.Text);
            addmenus.Add(addmenu4.Text);
            addmenus.Add(addmenu5.Text);
            addmenus.Add(addmenu6.Text);
            addmenus.Add(addmenu7.Text);
            addmenus.Add(addmenu8.Text);

            List<string> tbox_addmenus = new List<string>();
            tbox_addmenus.Add(textBox_addmenu1.Text);
            tbox_addmenus.Add(textBox_addmenu2.Text);
            tbox_addmenus.Add(textBox_addmenu3.Text);
            tbox_addmenus.Add(textBox_addmenu4.Text);
            tbox_addmenus.Add(textBox_addmenu5.Text);
            tbox_addmenus.Add(textBox_addmenu6.Text);
            tbox_addmenus.Add(textBox_addmenu7.Text);
            tbox_addmenus.Add(textBox_addmenu8.Text);

            if (label_add_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_add_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_add_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (!(String.IsNullOrWhiteSpace(tbox_addmenus[j])))
                            {
                                DataManager.executeQuery("update", $"{i} - " + addmenus[j], tbox_addmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_add_tablenum.Text = "0";
            label_add_tablenum.Visible = false;
            insert_null();
        }


        //테이블 계산대 테이블별 주문-----------------------------------------------------------------------------------------
        private void btn_cal_table1_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(1);
            refreshScreen();
        }

        private void btn_cal_table2_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(2);
            refreshScreen();
        }

        private void btn_cal_table3_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(3);
            refreshScreen();
        }

        private void btn_cal_table4_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(4);
            refreshScreen();
        }

        private void btn_cal_table5_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(5);
            refreshScreen();
        }

        private void btn_cal_table6_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(6);
            refreshScreen();
        }

        private void btn_cal_table7_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(7);
            refreshScreen();
        }

        private void btn_cal_table8_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(8);
            refreshScreen();
        }

        private void btn_cal_table9_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(9);
            refreshScreen();
        }

        private void btn_cal_table10_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(10);
            refreshScreen();
        }

        private void btn_cal_table11_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(11);
            refreshScreen();
        }

        private void btn_cal_table12_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(12);
            refreshScreen();
        }

        private void btn_cal_table13_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(13);
            refreshScreen();
        }

        private void btn_cal_table14_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(14);
            refreshScreen();
        }

        private void btn_cal_table15_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(15);
            refreshScreen();
        }

        private void btn_cal_table16_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery(16);
            refreshScreen();
        }

        //테이블 값
        static int alnum;
        //메뉴 현금결제 버튼----------------------------------------------------------------------------------------------------
        private void btn_menu_cashpay_Click(object sender, EventArgs e)
        {
            List<int> all_add = new List<int>();
            MenuCalculate mc = new MenuCalculate();
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                for(int j = 1; j<9; j++)
                {
                    if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"mainmenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.maincal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.maincal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.maincal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.maincal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.maincal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.maincal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.maincal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.maincal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                    else if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"sidemenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.sidecal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.sidecal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.sidecal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.sidecal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.sidecal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.sidecal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.sidecal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.sidecal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                    else if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"bavemenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.bevecal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.bevecal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.bevecal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.bevecal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.bevecal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.bevecal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.bevecal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.bevecal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                    else if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"addmenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.addcal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.addcal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.addcal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.addcal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.addcal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.addcal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.addcal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.addcal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            for(int i=0; i<all_add.Count; i++)
            {
                alnum += all_add[i];
            }
            if (dataGridView5.RowCount == 0)
            {
                DataManager.executeQuery_mtotal("insert", alnum.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
            }
            else if (dataGridView5.RowCount > 0)
            {
                DataManager.executeQuery_mtotal("update", alnum.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
            }
            DataManager.executeQuery_cal_tb("delete", dataGridView7.Rows[0].Cells[2].Value.ToString());

            label_cash_pay.Text = alnum.ToString();
            
            alnum = 0;
            dataGridView7.DataSource = null;
            string mm = DateTime.Now.ToString("yyyy-MM-dd");
            DataManager.selectQuery_mtotal(mm);

            label_total_pay.Text = (int.Parse(label_total_pay.Text) + int.Parse(label_cash_pay.Text)).ToString();

            label_card_pay.Text = "0";

            string record = dateTimePicker1.Value.ToString();
            string[] records = record.Split(' ');
            DataManager.selectQuery_mtotal(records[0]);
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = DataManager.totalCals;
        }

        //메뉴 카드결제 부분--------------------------------------------------------------------------------------------------------
        private void btn_menu_cardpay_Click(object sender, EventArgs e)
        {
            List<int> all_add = new List<int>();
            MenuCalculate mc = new MenuCalculate();
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"mainmenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.maincal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.maincal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.maincal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.maincal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.maincal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.maincal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.maincal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.maincal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                    else if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"sidemenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.sidecal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.sidecal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.sidecal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.sidecal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.sidecal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.sidecal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.sidecal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.sidecal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                    else if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"bavemenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.bevecal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.bevecal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.bevecal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.bevecal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.bevecal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.bevecal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.bevecal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.bevecal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                    else if (dataGridView7.Rows[i].Cells[0].Value.ToString().Contains($"addmenu{j}"))
                    {
                        switch (j)
                        {
                            case 1:
                                all_add.Add(mc.addcal1(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 2:
                                all_add.Add(mc.addcal2(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 3:
                                all_add.Add(mc.addcal3(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 4:
                                all_add.Add(mc.addcal4(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 5:
                                all_add.Add(mc.addcal5(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 6:
                                all_add.Add(mc.addcal6(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 7:
                                all_add.Add(mc.addcal7(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            case 8:
                                all_add.Add(mc.addcal8(int.Parse(dataGridView7.Rows[i].Cells[1].Value.ToString())));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            for (int i = 0; i < all_add.Count; i++)
            {
                alnum += all_add[i];
            }
            if (dataGridView5.RowCount == 0)
            {
                DataManager.executeQuery_mtotal("insert", alnum.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
            }
            else if(dataGridView5.RowCount > 0)
            {
                DataManager.executeQuery_mtotal("update", alnum.ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
            }
            DataManager.executeQuery_cal_tb("delete", dataGridView7.Rows[0].Cells[2].Value.ToString());
            
            label_card_pay.Text = alnum.ToString();

            alnum = 0;
            dataGridView7.DataSource = null;
            string mm = DateTime.Now.ToString("yyyy-MM-dd");
            DataManager.selectQuery_mtotal(mm);
            
            label_total_pay.Text = (int.Parse(label_total_pay.Text) + int.Parse(label_cash_pay.Text)).ToString();

            label_cash_pay.Text = "0";

            string record = dateTimePicker1.Value.ToString();
            string[] records = record.Split(' ');
            DataManager.selectQuery_mtotal(records[0]);
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = DataManager.totalCals;
        }
    }
}


//((DataTable)dataGridView1.DataSource).Rows.Clear();   //데이터뷰 컬럼명 놔두고 사라지게하는코드

/*
 else if(label_main_tablenum.Text != "0")
            {
                for(int i =1; i<17; i++)
                {
                    if(label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for(int j =1; j<9; j++)
                        {
                            if ($"textBox_mainmenu{j}.Text" != null)
                            {
                                DataManager.executeQuery("insert",mainmenu1.Text,textBox_mainmenu1.Text, i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                        MessageBox.Show("성공");
                    }
                }
            }
데이터그리드뷰에 테이블별로 화면뿌리는 코드
*/