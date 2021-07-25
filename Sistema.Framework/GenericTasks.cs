using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using Sistema.Domain.Entities.Entity;
using System.Collections.Generic;
using DevExpress.XtraBars.Navigation;

namespace Sistema.Framework
{
    public static class GenericTasks
    {
        public static void ShowFormInContainer(Control.ControlCollection container, Form form)
        {
            container.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            container.Add(form);
            form.Show();
        }

        public static bool ValuesIsValidInFields(Control.ControlCollection fields)
        {
            bool valid = true;

            foreach (Control field in fields)
            {
                if (isControlText(field) && string.IsNullOrEmpty(field.Text))
                {
                    MessageShow("INFORMÇÃO", "Preencha o campo " + getNameCurrect(field.Name) + "!");
                    valid = false;
                    break;
                }
                if (isControlCombo(field) && !isSelected(field))
                {
                    MessageShow("INFORMÇÃO", "Preencha o campo " + getNameCurrect(field.Name) + "!");
                    valid = false;
                    break;
                }
                if (isControlDate(field) && isDataNull(field))
                {
                    MessageShow("INFORMÇÃO", "Preencha o campo " + getNameCurrect(field.Name) + "!");
                    valid = false;
                    break;
                }
            }

            return valid;
        }

        public static void Mensagem(string msg, MessageBoxIcon icon, MessageBoxButtons botao)
        {
            MessageBox.Show(msg, "MENSAGEM", botao, icon);
        }
        public static void Mensagem(string msg, MessageBoxIcon icon)
        {
            MessageBox.Show(msg, "MENSAGEM", MessageBoxButtons.OK, icon);
        }
        public static void Mensagem(string msg)
        {
            MessageBox.Show(msg, "MENSAGEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool IsNull(object objecto)
        {
            return string.IsNullOrEmpty(objecto + "") || Equals(objecto, null); 
        }
        private static bool isDataNull(Control field)
        {
            object valueDate = null;
            if (field.GetType().Name == "DateTimePicker")
            {
                valueDate = (field as DateTimePicker).Value;
            }
            
            if (field.GetType().Name == "DateEdit")
            {
                valueDate = (field as DateEdit).EditValue;
            }

            return Equals(valueDate, null);
            
        }

        private static bool isControlDate(Control field)
        {
            return field.GetType().Name.Contains("Date");
        }

        private static string getNameCurrect(string name)
        {
            string nomeCurrecto = string.Empty;
            
            name = name.Replace("textEdit", string.Empty)
                       .Replace("comboBoxEdit", string.Empty)
                       .Replace("dateEdit", string.Empty)
                       .Replace("comboBox", string.Empty)
                       .Replace("textBox", string.Empty);
            foreach (var item in name)
            {
                if (StringManipulation.IsMaiuscula(item))
                {
                    nomeCurrecto += " " + char.ToUpper(item);
                }
                else
                {
                    nomeCurrecto += item;
                }
            }
            return nomeCurrecto;

        }

        public static int GetIndexGridCurrnet(object objGrid, Point mousePosition)
        {
            return GetGridInfoCurrnet(objGrid, mousePosition).RowHandle;
        }

        private static GridHitInfo GetGridInfoCurrnet(object objGrid, Point mousePosition)
        {
            GridView view = (GridView)objGrid;
            Point ponto = view.GridControl.PointToClient(mousePosition);
            GridHitInfo gridInfo = view.CalcHitInfo(ponto);
            return gridInfo;
        }

        private static void MessageShow(string title, string massage)
        {
            MessageBox.Show(
                massage,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information 
            );
        }
        private static void MessageShow(string title, string massage, MessageBoxIcon icon)
        {
            MessageBox.Show(
                massage,
                title,
                MessageBoxButtons.OK,
                icon
            );
        }
        public static void MudarPageFrame(object sender, NavigationFrame navigationFrameDataEntity, string tipoControle)
        {
            var namePage = (sender as Control).Name.Replace(tipoControle, "page");
            navigationFrameDataEntity.SelectedPage = (NavigationPage)navigationFrameDataEntity.Controls[namePage];
        }
        private static bool isSelected(Control field)
        {
            var index = -1;
            if (field.GetType().Name.Equals("ComboBox"))
            {
                index = (field as System.Windows.Forms.ComboBox).SelectedIndex;
            }
            if (field.GetType().Name.Equals("ComboBoxEdit"))
            {
                index = (field as ComboBoxEdit).SelectedIndex;
            }

            return index >= 0;
            
        }

        private static bool isControlCombo(Control field)
        {
            return (field.GetType().Name.Contains("ComboBox"));
        }

        private static bool isControlText(Control field)
        {
            return field.GetType().Name.Contains("Text");
        }

        public static void ClearValuesInFields(Control.ControlCollection fields)
        {
            foreach (Control field in fields)
            {
                if (isControlText(field))
                {
                    field.Text = string.Empty;
                    break;
                } 
                if (isControlCombo(field))
                {
                    field.GetType().GetProperty("SelectedIndex").SetValue(field, 0);
                    break;
                }
                if (isControlDate(field) && isDataNull(field))
                {
                    field.GetType().GetProperty("EditValue").SetValue(field, null);
                    break;
                }
            }
        }

        public static bool IsValidList<Entity>(List<Entity> list) 
        {
            return !Equals(list, null) && list.Count > 0;
        }
        public static DateTime GetDataLimiteDeIntervaloDias(int intervaloDias)
        {
            var timeSubstruct = new TimeSpan(-intervaloDias, 0, 0, 0, 0);
            var datalimite = DateTime.Now.Subtract(timeSubstruct);
            
            return datalimite;
        }
    }
}
