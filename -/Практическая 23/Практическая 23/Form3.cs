using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_23
{
    public partial class Form3 : Form
    {
        Color colorResult;
        public delegate void ColorSelectedEventHandler(Color color);
        public event ColorSelectedEventHandler ColorSelected;
        private Color currentColor;
        private Color previousColor;

        public Form3(Color color)
        {        
            InitializeComponent();
            // сохраняем текущий цвет и присваиваем элементам управления на форме
            currentColor = color;
            previousColor = color;

            HSBRed.Tag = NUDRed;
            HSBGreen.Tag = NUDGreen;
            HSBBlue.Tag = NUDBlue;
            NUDRed.Tag = HSBRed;
            NUDGreen.Tag = HSBGreen;
            NUDBlue.Tag = HSBBlue;
            NUDRed.Value = color.R;
            NUDGreen.Value = color.G;
            NUDBlue.Value = color.B;

            UpdateColor();
        }
        private void UpdateColor()
        {
              colorResult = Color.FromArgb(HSBRed.Value, HSBGreen.Value,HSBBlue.Value);
              PBColors.BackColor = colorResult;
        }
        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (ColorSelected != null)
            {
                ColorSelected(colorResult);
            }
            this.Close();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            // возврат к предыдущему цвету
            currentColor = previousColor;
            NUDRed.Value = currentColor.R;
            NUDGreen.Value = currentColor.G;
            NUDBlue.Value = currentColor.B;
            HSBRed.Value = currentColor.R;
            HSBGreen.Value = currentColor.G;
            HSBBlue.Value = currentColor.B;
            UpdateColor();
        }


        private void HSBRed_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }
        private void NUDRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void HSBGreen_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
        }
        private void NUDGreen_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        private void HSBBlue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;

        }
        private void NUDBlue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
        }
        //Смешивание
        private void HSBRed_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void HSBGreen_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void HSBBlue_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void btnOtherColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                HSBRed.Value = colorDialog.Color.R;
                HSBGreen.Value = colorDialog.Color.G;
                HSBBlue.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;

                UpdateColor();
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
