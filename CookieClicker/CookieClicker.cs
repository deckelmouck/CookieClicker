using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class CookieClicker : Form
    {
        int _Cookies = 0;
        int _Cookies10 = 0;
        int _Cookies25 = 0;
        int _Cookies50 = 0;
        int _Cookies100 = 0;
        int _timercount = 0;

        public CookieClicker()
        {
            InitializeComponent();
        }

        private void CookieClickButton_Click(object sender, EventArgs e)
        {
            _Cookies += 1;
            CookiePoints.Text = _Cookies.ToString() + " Cookies";
        }

        private void Cookies10_Click(object sender, EventArgs e)
        {
            if(_Cookies >= 10)
            {
                _Cookies -= 10;
                CookiePoints.Text = _Cookies.ToString() + " Cookies";
                _Cookies10 += 1;
                Cookies10.Text = "10 Cookies - " + _Cookies10.ToString();
            }
            else
            {
                MessageBox.Show("oops, not enough Cookies");
            }
        }

        private void Cookies25_Click(object sender, EventArgs e)
        {
            if (_Cookies >= 25)
            {
                _Cookies -= 25;
                CookiePoints.Text = _Cookies.ToString() + " Cookies";
                _Cookies25 += 1;
                Cookies25.Text = "25 Cookies - " + _Cookies25.ToString();
            }
            else
            {
                MessageBox.Show("oops, not enough Cookies");
            }
        }

        private void Cookies50_Click(object sender, EventArgs e)
        {
            if (_Cookies >= 50)
            {
                _Cookies -= 50;
                CookiePoints.Text = _Cookies.ToString() + " Cookies";
                _Cookies50 += 1;
                Cookies50.Text = "50 Cookies - " + _Cookies50.ToString();
            }
            else
            {
                MessageBox.Show("oops, not enough Cookies");
            }
        }

        private void Cookies100_Click(object sender, EventArgs e)
        {
            if (_Cookies >= 100)
            {
                _Cookies -= 100;
                CookiePoints.Text = _Cookies.ToString() + " Cookies";
                _Cookies100 += 1;
                Cookies100.Text = "100 Cookies - " + _Cookies100.ToString();
            }
            else
            {
                MessageBox.Show("oops, not enough Cookies");
            }
        }

        private void CookieTimer_Tick(object sender, EventArgs e)
        {
            _timercount += 1;

            _Cookies += _Cookies100;

            if(_timercount % 4 == 0)
            {
                _Cookies += _Cookies50;
            }

            if (_timercount % 10 == 0)
            {
                _Cookies += _Cookies25;
            }

            if (_timercount % 20 == 0)
            {
                _Cookies += _Cookies10;
            }

            CookiePoints.Text = _Cookies.ToString() + " Cookies";

        }
    }
}
