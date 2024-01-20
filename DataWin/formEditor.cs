using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DataWin
{
    public static class formEditor
    {

        public static void setName(DataGridView data, string name)
        {
            data.Name = name;
        }

        public static void defaultSettings(DataGridView data)
        {
            data.AllowUserToAddRows = false;
            data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < data.Columns.Count; ++i)
                data.Columns[i].ReadOnly = true;
        }

        public static void defaultSettingsCombo(ComboBox comboBox)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public static void drawDropDownCombo(ComboBox comboBox, DrawItemEventArgs e)
        {
            string itemText = comboBox.Items[e.Index].ToString();
            Color backColor = SystemColors.Window;
            Color stringColor = SystemColors.WindowText;
            switch (itemText)
            {
                case "L":
                    {
                        backColor = Color.Green;
                        break;
                    }
                case "M":
                    {
                        backColor = Color.Yellow;
                        break;
                    }
                case "H":
                    {
                        backColor = Color.Red;
                        break;
                    }
                case "UA":
                    {
                        backColor = Color.Black;
                        stringColor = Color.White;
                        break;
                    }
            }
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            using (SolidBrush brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            using (SolidBrush textBrush = new SolidBrush(stringColor))
            {
                e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds, sf);
            }
        }

        public static void drawBackCombo(ComboBox comboBox)
        {
            string itemText = comboBox.SelectedItem as string;
            comboBox.ForeColor = Color.Black;
            switch (itemText)
            {
                case "L":
                    {
                        comboBox.BackColor = Color.Green;
                        break;
                    }
                case "M":
                    {
                        comboBox.BackColor = Color.Yellow;
                        break;
                    }
                case "H":
                    {
                        comboBox.BackColor = Color.Red;
                        break;
                    }
                case "UA":
                    {
                        comboBox.BackColor = Color.Black;
                        comboBox.ForeColor = Color.White;
                        break;
                    }
                default:
                    {
                        comboBox.BackColor = Color.White;
                        break;
                    }
            }
        }

        public static Tuple<List<string>, List<string>> getData(Control control)
        {
            List<string> baseAdd = new List<string>();
            List<string> gridAdd = new List<string>();
            foreach (Control element in control.Controls)
            {
                if (element is System.Windows.Forms.ComboBox)
                {
                    ComboBox comboBox = element as ComboBox;
                    string val = comboBox.Text;
                    baseAdd.Add(comboBox.SelectedValue.ToString());
                    gridAdd.Add(val);
                }
                else if (element is System.Windows.Forms.TextBox)
                {
                    TextBox textBox = element as TextBox;
                    string text = checkText(textBox.Text);
                    baseAdd.Add(text);
                    gridAdd.Add(text);
                }
            }
            Tuple<List<string>, List<string>> tuple = new Tuple<List<string>, List<string>>(baseAdd, gridAdd);
            return tuple;
        }

        public static Tuple<List<string>, List<string>> getData(GroupBox groupBox)
        {
            List<string> baseAdd = new List<string>();
            List<string> gridAdd = new List<string>();
            foreach (Control element in groupBox.Controls)
            {
                if (element is System.Windows.Forms.ComboBox)
                {
                    ComboBox comboBox = element as ComboBox;
                    string val = comboBox.Text;
                    baseAdd.Add(comboBox.SelectedValue.ToString());
                    gridAdd.Add(val);
                }
                else if (element is System.Windows.Forms.TextBox)
                {
                    TextBox textBox = element as TextBox;
                    string text = checkText(textBox.Text);
                    baseAdd.Add(text);
                    gridAdd.Add(text);
                }
            }
            baseAdd.Reverse();
            gridAdd.Reverse();
            Tuple<List<string>, List<string>> tuple = new Tuple<List<string>, List<string>>(baseAdd, gridAdd);
            return tuple;
        }

        public static void drawComboSettings(ComboBox comboBox)
        {

        }

        public static int addGridValue(DataGridView data, string id, string value)
        {
            return data.Rows.Add(id, value);
        }

        public static int addGridValues(DataGridView data, string id, string[] value)
        {
            DataGridViewRow row = new DataGridViewRow();
            int index = data.Rows.Add(row);
            data.Rows[index].Cells[0].Value = id;
            for (int i = 1; i <= value.Length; ++i)
                data.Rows[index].Cells[i].Value = value[i - 1];
            return index;
        }

        public static void updateValue(DataGridView data, int indexRow, string name, string value)
        {
            data.Rows[indexRow].Cells[name].Value = value;
        }

        public static void updateValues(DataGridView data, int indexRow, string[] values)
        {
            for (int j = 1; j < values.Length + 1; ++j)
                data.Rows[indexRow].Cells[j].Value = values[j - 1];
        }

        public static string formMessage(DataGridView data, int indexRow, string[] values)
        {
            string result = "Вы уверены что хотите изменить значение \n";
            for (int i = 1; i < data.Columns.Count; ++i)
            {
                string nameCol = data.Columns[i].HeaderText;
                string valData = data.Rows[indexRow].Cells[i].Value.ToString();
                string valChange = values[i - 1];
                result += $"{nameCol} --   {valData} на {valChange} \n";
            }
            return result;
        }

        public static void addGridTags(DataGridView data, int indexRow, string[] tags)
        {
            for (int j = 1; j < tags.Length + 1; ++j)
                data.Rows[indexRow].Cells[j].Tag = tags[j - 1];
        }

        public static string checkText(string text)
        {
            if (Regex.Matches(text, @"\b\w+\b").Count > 1)
                return Regex.Replace(text.Trim(), @"\s+", " ");
            return text.Trim();
        }


    }
}
