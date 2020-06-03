/*
Copyright 2018 - Leonardo Piga

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerNumberConverter
{
    public partial class FrmMain : Form
    {
        private static bool updating_text_ = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private unsafe uint IntToUIntBin(int val)
        {
            return *((uint*)&val);
        }
        private unsafe float IntToFloatBin(int val)
        {
            return *((float*)&val);
        }
        private unsafe int UIntToIntBin(uint val)
        {
            return (int)val;
        }
        private unsafe float UIntToFloatBin(uint val)
        {
            return *((float*)&val);
        }
        private unsafe int FloatToIntBin(float val)
        {
            return *((int*)&val);
        }
        private unsafe uint FloatToUIntBin(float val)
        {
            return *((uint*)&val);
        }
        private unsafe ulong LongToULongBin(long val)
        {
            return *((ulong*)&val);
        }
        private unsafe double LongToDoubleBin(long val)
        {
            return *((double*)&val);
        }
        private unsafe long ULongToLongBin(ulong val)
        {
            return *((long*)&val);
        }
        private unsafe double ULongToDoubleBin(ulong val)
        {
            return *((double*)&val);
        }
        private unsafe long DoubleToLongBin(double val)
        {
            return *((long*)&val);
        }
        private unsafe ulong DoubleToULongBin(double val)
        {
            return *((ulong*)&val);
        }
        private void BinaryToChecks(ulong number)
        {
            string str_binary = Convert.ToString((long)number,2).PadLeft(64,'0');
            Chk0.Checked = str_binary[63 - 0] == '1';
            Chk1.Checked = str_binary[63 - 1] == '1';
            Chk2.Checked = str_binary[63 - 2] == '1';
            Chk3.Checked = str_binary[63 - 3] == '1';
            Chk4.Checked = str_binary[63 - 4] == '1';
            Chk5.Checked = str_binary[63 - 5] == '1';
            Chk6.Checked = str_binary[63 - 6] == '1';
            Chk7.Checked = str_binary[63 - 7] == '1';
            Chk8.Checked = str_binary[63 - 8] == '1';
            Chk9.Checked = str_binary[63 - 9] == '1';
            Chk10.Checked = str_binary[63 - 10] == '1';
            Chk11.Checked = str_binary[63 - 11] == '1';
            Chk12.Checked = str_binary[63 - 12] == '1';
            Chk13.Checked = str_binary[63 - 13] == '1';
            Chk14.Checked = str_binary[63 - 14] == '1';
            Chk15.Checked = str_binary[63 - 15] == '1';
            Chk16.Checked = str_binary[63 - 16] == '1';
            Chk17.Checked = str_binary[63 - 17] == '1';
            Chk18.Checked = str_binary[63 - 18] == '1';
            Chk19.Checked = str_binary[63 - 19] == '1';
            Chk20.Checked = str_binary[63 - 20] == '1';
            Chk21.Checked = str_binary[63 - 21] == '1';
            Chk22.Checked = str_binary[63 - 22] == '1';
            Chk23.Checked = str_binary[63 - 23] == '1';
            Chk24.Checked = str_binary[63 - 24] == '1';
            Chk25.Checked = str_binary[63 - 25] == '1';
            Chk26.Checked = str_binary[63 - 26] == '1';
            Chk27.Checked = str_binary[63 - 27] == '1';
            Chk28.Checked = str_binary[63 - 28] == '1';
            Chk29.Checked = str_binary[63 - 29] == '1';
            Chk30.Checked = str_binary[63 - 30] == '1';
            Chk31.Checked = str_binary[63 - 31] == '1';
            Chk32.Checked = str_binary[63 - 32] == '1';
            Chk33.Checked = str_binary[63 - 33] == '1';
            Chk34.Checked = str_binary[63 - 34] == '1';
            Chk35.Checked = str_binary[63 - 35] == '1';
            Chk36.Checked = str_binary[63 - 36] == '1';
            Chk37.Checked = str_binary[63 - 37] == '1';
            Chk38.Checked = str_binary[63 - 38] == '1';
            Chk39.Checked = str_binary[63 - 39] == '1';
            Chk40.Checked = str_binary[63 - 40] == '1';
            Chk41.Checked = str_binary[63 - 41] == '1';
            Chk42.Checked = str_binary[63 - 42] == '1';
            Chk43.Checked = str_binary[63 - 43] == '1';
            Chk44.Checked = str_binary[63 - 44] == '1';
            Chk45.Checked = str_binary[63 - 45] == '1';
            Chk46.Checked = str_binary[63 - 46] == '1';
            Chk47.Checked = str_binary[63 - 47] == '1';
            Chk48.Checked = str_binary[63 - 48] == '1';
            Chk49.Checked = str_binary[63 - 49] == '1';
            Chk50.Checked = str_binary[63 - 50] == '1';
            Chk51.Checked = str_binary[63 - 51] == '1';
            Chk52.Checked = str_binary[63 - 52] == '1';
            Chk53.Checked = str_binary[63 - 53] == '1';
            Chk54.Checked = str_binary[63 - 54] == '1';
            Chk55.Checked = str_binary[63 - 55] == '1';
            Chk56.Checked = str_binary[63 - 56] == '1';
            Chk57.Checked = str_binary[63 - 57] == '1';
            Chk58.Checked = str_binary[63 - 58] == '1';
            Chk59.Checked = str_binary[63 - 59] == '1';
            Chk60.Checked = str_binary[63 - 60] == '1';
            Chk61.Checked = str_binary[63 - 61] == '1';
            Chk62.Checked = str_binary[63 - 62] == '1';
            Chk63.Checked = str_binary[63 - 63] == '1';
        }

        private void UpdateTextBox(ulong val)
        {
            updating_text_ = true;
            uint val32 = (uint)(val & 0xffffffff);
            if (!TxtSignedDecimal32.Focused) { TxtSignedDecimal32.Text = Convert.ToString(UIntToIntBin(val32)); }
            if (!TxtUnsignedDecimal32.Focused) { TxtUnsignedDecimal32.Text = Convert.ToString(val32); }
            if (!TxtFloat.Focused) { TxtFloat.Text = Convert.ToString(UIntToFloatBin(val32)); }
            if (!Txt32BitHex.Focused) { Txt32BitHex.Text = Convert.ToString(val32, 16); }
            if (!TxtBinary32.Focused) { TxtBinary32.Text = Convert.ToString(val32, 2); }

            if (!TxtSignedDecimal64.Focused) { TxtSignedDecimal64.Text = Convert.ToString(ULongToLongBin(val)); }
            if (!TxtUnsignedDecimal64.Focused) { TxtUnsignedDecimal64.Text = Convert.ToString(val); }
            if (!TxtDouble.Focused) { TxtDouble.Text = Convert.ToString(ULongToDoubleBin(val)); }
            if (!Txt64BitHex.Focused) { Txt64BitHex.Text = Convert.ToString((long)val, 16); }
            if (!TxtBinary64.Focused) { TxtBinary64.Text = Convert.ToString((long)val, 2); }
            updating_text_ = false;
        }

        private void TxtSignedDecimal32_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (updating_text_) return;
            int.TryParse(TxtSignedDecimal32.Text, out val);
            UpdateTextBox(IntToUIntBin(val));
            BinaryToChecks(IntToUIntBin(val));
        }

        private void TxtUnsignedDecimal32_TextChanged(object sender, EventArgs e)
        {
            uint val;
            if (updating_text_) return;
            uint.TryParse(TxtUnsignedDecimal32.Text, out val);
            UpdateTextBox(val);
            BinaryToChecks(val);
        }

        private void TxtFloat_TextChanged(object sender, EventArgs e)
        {
            float val;
            if (updating_text_) return;
            float.TryParse(TxtFloat.Text, out val);
            UpdateTextBox(FloatToUIntBin(val));
            BinaryToChecks(FloatToUIntBin(val));
        }

        private void Txt32BitHex_TextChanged(object sender, EventArgs e)
        {
            if (updating_text_) return;
            try
            {
                uint val = Convert.ToUInt32(Txt32BitHex.Text, 16);
                UpdateTextBox(val);
                BinaryToChecks(val);
            } catch
            {}
        }

        private void TxtBinary32_TextChanged(object sender, EventArgs e)
        {
            if (updating_text_) return;
            try
            {
                uint val = Convert.ToUInt32(TxtBinary32.Text, 2);
                UpdateTextBox(val);
                BinaryToChecks(val);
            }
            catch { }
        }

        private void TxtSignedDecimal64_TextChanged(object sender, EventArgs e)
        {
            long val;
            if (updating_text_) return;
            long.TryParse(TxtSignedDecimal64.Text, out val);
            UpdateTextBox(LongToULongBin(val));
            BinaryToChecks(LongToULongBin(val));
        }

        private void TxtUnsignedDecimal64_TextChanged(object sender, EventArgs e)
        {
            UInt64 val;
            if (updating_text_) return;
            UInt64.TryParse(TxtUnsignedDecimal64.Text, out val);
            UpdateTextBox(val);
            BinaryToChecks(val);
        }

        private void TxtDouble_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (updating_text_) return;
            double.TryParse(TxtDouble.Text, out val);
            UpdateTextBox(DoubleToULongBin(val));
            BinaryToChecks(DoubleToULongBin(val));
        }

        private void Txt64BitHex_TextChanged(object sender, EventArgs e)
        {
            if (updating_text_) return;
            try
            {
                ulong val = Convert.ToUInt64(Txt64BitHex.Text, 16);
                UpdateTextBox(val);
                BinaryToChecks(val);
            }
            catch
            { }
        }

        private void TxtBinary64_TextChanged(object sender, EventArgs e)
        {
            if (updating_text_) return;
            try
            {
                ulong val = Convert.ToUInt64(TxtBinary64.Text, 2);
                UpdateTextBox(val);
                BinaryToChecks(val);
            }
            catch
            { }
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            uint[] bit_array = new uint[64];
            bit_array[0] = Chk0.Checked ? 1u : 0u;
            bit_array[1] = Chk1.Checked ? 1u : 0u;
            bit_array[2] = Chk2.Checked ? 1u : 0u;
            bit_array[3] = Chk3.Checked ? 1u : 0u;
            bit_array[4] = Chk4.Checked ? 1u : 0u;
            bit_array[5] = Chk5.Checked ? 1u : 0u;
            bit_array[6] = Chk6.Checked ? 1u : 0u;
            bit_array[7] = Chk7.Checked ? 1u : 0u;
            bit_array[8] = Chk8.Checked ? 1u : 0u;
            bit_array[9] = Chk9.Checked ? 1u : 0u;
            bit_array[10] = Chk10.Checked ? 1u : 0u;
            bit_array[11] = Chk11.Checked ? 1u : 0u;
            bit_array[12] = Chk12.Checked ? 1u : 0u;
            bit_array[13] = Chk13.Checked ? 1u : 0u;
            bit_array[14] = Chk14.Checked ? 1u : 0u;
            bit_array[15] = Chk15.Checked ? 1u : 0u;
            bit_array[16] = Chk16.Checked ? 1u : 0u;
            bit_array[17] = Chk17.Checked ? 1u : 0u;
            bit_array[18] = Chk18.Checked ? 1u : 0u;
            bit_array[19] = Chk19.Checked ? 1u : 0u;
            bit_array[20] = Chk20.Checked ? 1u : 0u;
            bit_array[21] = Chk21.Checked ? 1u : 0u;
            bit_array[22] = Chk22.Checked ? 1u : 0u;
            bit_array[23] = Chk23.Checked ? 1u : 0u;
            bit_array[24] = Chk24.Checked ? 1u : 0u;
            bit_array[25] = Chk25.Checked ? 1u : 0u;
            bit_array[26] = Chk26.Checked ? 1u : 0u;
            bit_array[27] = Chk27.Checked ? 1u : 0u;
            bit_array[28] = Chk28.Checked ? 1u : 0u;
            bit_array[29] = Chk29.Checked ? 1u : 0u;
            bit_array[30] = Chk30.Checked ? 1u : 0u;
            bit_array[31] = Chk31.Checked ? 1u : 0u;
            bit_array[32] = Chk32.Checked ? 1u : 0u;
            bit_array[33] = Chk33.Checked ? 1u : 0u;
            bit_array[34] = Chk34.Checked ? 1u : 0u;
            bit_array[35] = Chk35.Checked ? 1u : 0u;
            bit_array[36] = Chk36.Checked ? 1u : 0u;
            bit_array[37] = Chk37.Checked ? 1u : 0u;
            bit_array[38] = Chk38.Checked ? 1u : 0u;
            bit_array[39] = Chk39.Checked ? 1u : 0u;
            bit_array[40] = Chk40.Checked ? 1u : 0u;
            bit_array[41] = Chk41.Checked ? 1u : 0u;
            bit_array[42] = Chk42.Checked ? 1u : 0u;
            bit_array[43] = Chk43.Checked ? 1u : 0u;
            bit_array[44] = Chk44.Checked ? 1u : 0u;
            bit_array[45] = Chk45.Checked ? 1u : 0u;
            bit_array[46] = Chk46.Checked ? 1u : 0u;
            bit_array[47] = Chk47.Checked ? 1u : 0u;
            bit_array[48] = Chk48.Checked ? 1u : 0u;
            bit_array[49] = Chk49.Checked ? 1u : 0u;
            bit_array[50] = Chk50.Checked ? 1u : 0u;
            bit_array[51] = Chk51.Checked ? 1u : 0u;
            bit_array[52] = Chk52.Checked ? 1u : 0u;
            bit_array[53] = Chk53.Checked ? 1u : 0u;
            bit_array[54] = Chk54.Checked ? 1u : 0u;
            bit_array[55] = Chk55.Checked ? 1u : 0u;
            bit_array[56] = Chk56.Checked ? 1u : 0u;
            bit_array[57] = Chk57.Checked ? 1u : 0u;
            bit_array[58] = Chk58.Checked ? 1u : 0u;
            bit_array[59] = Chk59.Checked ? 1u : 0u;
            bit_array[60] = Chk60.Checked ? 1u : 0u;
            bit_array[61] = Chk61.Checked ? 1u : 0u;
            bit_array[62] = Chk62.Checked ? 1u : 0u;
            bit_array[63] = Chk63.Checked ? 1u : 0u;
            ulong val = 0;
            for (int i = 63; i >=0; i--)
            {
                val = val << 1;
                val |= (ulong) bit_array[i];
            }
            UpdateTextBox(val);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout f = new FrmAbout();
            f.Show();
        }
    }
}
