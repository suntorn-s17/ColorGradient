using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ColorGradient
{
    public partial class menu : Form
    {
        string HexCode = string.Empty;
        public menu()
        {
            InitializeComponent();
            ChangeColor(1);
            ChangeColor(2);
            ChangeColor(3);
            ChangeColor(4);
        }

        private void gunaTrackBarRed1_ValueChanged(object sender, EventArgs e)
        {
            tbRedValue1.Text = gunaTrackBarRed1.Value.ToString();
        }

        private void gunaTrackBarGreen1_ValueChanged(object sender, EventArgs e)
        {
            tbGreenValue1.Text = gunaTrackBarGreen1.Value.ToString();
        }

        private void gunaTrackBarBlue1_ValueChanged(object sender, EventArgs e)
        {
            tbBlueValue1.Text = gunaTrackBarBlue1.Value.ToString();
        }

        private void gunaTrackBarRed2_ValueChanged(object sender, EventArgs e)
        {
            tbRedValue2.Text = gunaTrackBarRed2.Value.ToString();
        }

        private void gunaTrackBarGreen2_ValueChanged(object sender, EventArgs e)
        {
            tbGreenValue2.Text = gunaTrackBarGreen2.Value.ToString();
        }

        private void gunaTrackBarBlue2_ValueChanged(object sender, EventArgs e)
        {
            tbBlueValue2.Text = gunaTrackBarBlue2.Value.ToString();
        }

        private void gunaTrackBarRed3_ValueChanged(object sender, EventArgs e)
        {
            tbRedValue3.Text = gunaTrackBarRed3.Value.ToString();
        }

        private void gunaTrackBarGreen3_ValueChanged(object sender, EventArgs e)
        {
            tbGreenValue3.Text = gunaTrackBarGreen3.Value.ToString();
        }

        private void gunaTrackBarBlue3_ValueChanged(object sender, EventArgs e)
        {
            tbBlueValue3.Text = gunaTrackBarBlue3.Value.ToString();
        }

        private void gunaTrackBarRed4_ValueChanged(object sender, EventArgs e)
        {
            tbRedValue4.Text = gunaTrackBarRed4.Value.ToString();
        }

        private void gunaTrackBarGreen4_ValueChanged(object sender, EventArgs e)
        {
            tbGreenValue4.Text = gunaTrackBarGreen4.Value.ToString();
        }

        private void gunaTrackBarBlue4_ValueChanged(object sender, EventArgs e)
        {
            tbBlueValue4.Text = gunaTrackBarBlue4.Value.ToString();
        }

        private void tbRedValue1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbRedValue1.Text.Trim()) > 255)
            {
                tbRedValue1.Text = "255";
            }
            ChangeColor(1);
        }

        private void tbGreenValue1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbGreenValue1.Text.Trim()) > 255)
            {
                tbGreenValue1.Text = "255";
            }
            ChangeColor(1);
        }

        private void tbBlueValue1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbBlueValue1.Text.Trim()) > 255)
            {
                tbBlueValue1.Text = "255";
            }
            ChangeColor(1);
        }

        private void tbRedValue2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbRedValue2.Text.Trim()) > 255)
            {
                tbRedValue2.Text = "255";
            }
            ChangeColor(2);
        }

        private void tbGreenValue2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbGreenValue2.Text.Trim()) > 255)
            {
                tbGreenValue2.Text = "255";
            }
            ChangeColor(2);
        }

        private void tbBlueValue2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbBlueValue2.Text.Trim()) > 255)
            {
                tbBlueValue2.Text = "255";
            }
            ChangeColor(2);
        }

        private void tbRedValue3_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbRedValue3.Text.Trim()) > 255)
            {
                tbRedValue3.Text = "255";
            }
            ChangeColor(3);
        }

        private void tbGreenValue3_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbGreenValue3.Text.Trim()) > 255)
            {
                tbGreenValue3.Text = "255";
            }
            ChangeColor(3);
        }

        private void tbBlueValue3_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbBlueValue3.Text.Trim()) > 255)
            {
                tbBlueValue3.Text = "255";
            }
            ChangeColor(3);
        }

        private void tbRedValue4_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbRedValue4.Text.Trim()) > 255)
            {
                tbRedValue4.Text = "255";
            }
            ChangeColor(4);
        }

        private void tbGreenValue4_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbGreenValue4.Text.Trim()) > 255)
            {
                tbGreenValue4.Text = "255";
            }
            ChangeColor(4);
        }

        private void tbBlueValue4_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbBlueValue4.Text.Trim()) > 255)
            {
                tbBlueValue4.Text = "255";
            }
            ChangeColor(4);
        }

        private void ChangeColor(int panelColor)
        {
            switch (panelColor)
            {
                case 1:
                    gunaPanelColor1.BackColor = Color.FromArgb(Convert.ToInt32(tbRedValue1.Text), Convert.ToInt32(tbGreenValue1.Text), Convert.ToInt32(tbBlueValue1.Text));
                    lbHex1.Text = $"#{Convert.ToInt32(tbRedValue1.Text):X2}{Convert.ToInt32(tbGreenValue1.Text):X2}{Convert.ToInt32(tbBlueValue1.Text):X2}";
                    break;
                case 2:
                    gunaPanelColor2.BackColor = Color.FromArgb(Convert.ToInt32(tbRedValue2.Text), Convert.ToInt32(tbGreenValue2.Text), Convert.ToInt32(tbBlueValue2.Text));
                    lbHex2.Text = $"#{Convert.ToInt32(tbRedValue2.Text):X2}{Convert.ToInt32(tbGreenValue2.Text):X2}{Convert.ToInt32(tbBlueValue2.Text):X2}";
                    break;
                case 3:
                    gunaPanelColor3.BackColor = Color.FromArgb(Convert.ToInt32(tbRedValue3.Text), Convert.ToInt32(tbGreenValue3.Text), Convert.ToInt32(tbBlueValue3.Text));
                    lbHex3.Text = $"#{Convert.ToInt32(tbRedValue3.Text):X2}{Convert.ToInt32(tbGreenValue3.Text):X2}{Convert.ToInt32(tbBlueValue3.Text):X2}";
                    break;
                case 4:
                    gunaPanelColor4.BackColor = Color.FromArgb(Convert.ToInt32(tbRedValue4.Text), Convert.ToInt32(tbGreenValue4.Text), Convert.ToInt32(tbBlueValue4.Text));
                    lbHex4.Text = $"#{Convert.ToInt32(tbRedValue4.Text):X2}{Convert.ToInt32(tbGreenValue4.Text):X2}{Convert.ToInt32(tbBlueValue4.Text):X2}";
                    break;
                default: break;
            }
            ChangeColorGredient();
        }

        private void ChangeColorGredient()
        {
            gunaGradientPanel1.GradientColor1 = Color.FromArgb(Convert.ToInt32(tbRedValue1.Text), Convert.ToInt32(tbGreenValue1.Text), Convert.ToInt32(tbBlueValue1.Text));
            gunaGradientPanel1.GradientColor2 = Color.FromArgb(Convert.ToInt32(tbRedValue2.Text), Convert.ToInt32(tbGreenValue2.Text), Convert.ToInt32(tbBlueValue2.Text));
            gunaGradientPanel1.GradientColor3 = Color.FromArgb(Convert.ToInt32(tbRedValue3.Text), Convert.ToInt32(tbGreenValue3.Text), Convert.ToInt32(tbBlueValue3.Text));
            gunaGradientPanel1.GradientColor4 = Color.FromArgb(Convert.ToInt32(tbRedValue4.Text), Convert.ToInt32(tbGreenValue4.Text), Convert.ToInt32(tbBlueValue4.Text));
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int red1 = rnd.Next(1, 255);
            int green1 = rnd.Next(1, 255);
            int blue1 = rnd.Next(1, 255);
            int red2 = rnd.Next(1, 255);
            int green2 = rnd.Next(1, 255);
            int blue2 = rnd.Next(1, 255);
            int red3 = rnd.Next(1, 255);
            int green3 = rnd.Next(1, 255);
            int blue3 = rnd.Next(1, 255);
            int red4 = rnd.Next(1, 255);
            int green4 = rnd.Next(1, 255);
            int blue4 = rnd.Next(1, 255);
            gunaTrackBarRed1.Value = red1;
            gunaTrackBarGreen1.Value = green1;
            gunaTrackBarBlue1.Value = blue1;
            gunaTrackBarRed2.Value = red2;
            gunaTrackBarGreen2.Value = green2;
            gunaTrackBarBlue2.Value = blue2;
            gunaTrackBarRed3.Value = red3;
            gunaTrackBarGreen3.Value = green3;
            gunaTrackBarBlue3.Value = blue3;
            gunaTrackBarRed4.Value = red4;
            gunaTrackBarGreen4.Value = green4;
            gunaTrackBarBlue4.Value = blue4;
            ChangeColor(1);
            ChangeColor(2);
            ChangeColor(3);
            ChangeColor(4);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            gunaTrackBarRed1.Value = 1;
            gunaTrackBarGreen1.Value = 1;
            gunaTrackBarBlue1.Value = 1;
            gunaTrackBarRed2.Value = 1;
            gunaTrackBarGreen2.Value = 1;
            gunaTrackBarBlue2.Value = 1;
            gunaTrackBarRed3.Value = 1;
            gunaTrackBarGreen3.Value = 1;
            gunaTrackBarBlue3.Value = 1;
            gunaTrackBarRed4.Value = 1;
            gunaTrackBarGreen4.Value = 1;
            gunaTrackBarBlue4.Value = 1;
            ChangeColor(1);
            ChangeColor(2);
            ChangeColor(3);
            ChangeColor(4);
        }

        private void tbRedValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGreenValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBlueValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRedValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGreenValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBlueValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRedValue3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGreenValue3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBlueValue3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRedValue4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbGreenValue4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBlueValue4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gunaPanelColor1_Click(object sender, EventArgs e)
        {
            try
            {
                HexCode = Interaction.InputBox("Enter Your Hex Code Below.", "Color Gradient Tools (Color Gradient 1)", default);
                if (HexCode == string.Empty)
                    return;
                int red = Convert.ToInt32(HexCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(HexCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(HexCode.Substring(5, 2), 16);
                tbRedValue1.Text = red.ToString();
                tbGreenValue1.Text = green.ToString();
                tbBlueValue1.Text = blue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Hex color codes.\r\n{ex.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaPanelColor2_Click(object sender, EventArgs e)
        {
            try
            {
                HexCode = Interaction.InputBox("Enter Your Hex Code Below.", "Color Gradient Tools (Color Gradient 2)", default);
                if (HexCode == string.Empty)
                    return;
                int red = Convert.ToInt32(HexCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(HexCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(HexCode.Substring(5, 2), 16);
                tbRedValue2.Text = red.ToString();
                tbGreenValue2.Text = green.ToString();
                tbBlueValue2.Text = blue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Hex color codes.\r\n{ex.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaPanelColor3_Click(object sender, EventArgs e)
        {
            try
            {
                HexCode = Interaction.InputBox("Enter Your Hex Code Below.", "Color Gradient Tools (Color Gradient 3)", default);
                if (HexCode == string.Empty)
                    return;
                int red = Convert.ToInt32(HexCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(HexCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(HexCode.Substring(5, 2), 16);
                tbRedValue3.Text = red.ToString();
                tbGreenValue3.Text = green.ToString();
                tbBlueValue3.Text = blue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Hex color codes.\r\n{ex.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaPanelColor4_Click(object sender, EventArgs e)
        {
            try
            {
                HexCode = Interaction.InputBox("Enter Your Hex Code Below.", "Color Gradient Tools (Color Gradient 4)", default);
                if (HexCode == string.Empty)
                    return;
                int red = Convert.ToInt32(HexCode.Substring(1, 2), 16);
                int green = Convert.ToInt32(HexCode.Substring(3, 2), 16);
                int blue = Convert.ToInt32(HexCode.Substring(5, 2), 16);
                tbRedValue4.Text = red.ToString();
                tbGreenValue4.Text = green.ToString();
                tbBlueValue4.Text = blue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Hex color codes.\r\n{ex.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbHex1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbHex1.Text);
        }

        private void lbHex2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbHex2.Text);
        }

        private void lbHex3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbHex3.Text);
        }

        private void lbHex4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbHex4.Text);
        }
    }
}
