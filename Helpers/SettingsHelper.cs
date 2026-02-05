using System;
using System.Collections.Generic;
using System.Text;

namespace MusicHub.Helpers
{
    public static class SettingsHelper
    {
        //Nastavenie pre Forms
        public static void ApplyStandardSettingsForm(Form form)
        {
            form.Size = new Size(1000, 800); // nastavíš podľa potreby
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = true; // môžeš ponechať
            form.Font = new Font("Segoe UI", 10); // jednotný font
        }
        //Nastavenie pre UserControls
        public static void ApplyStandardSettingsControl(UserControl ctrl)
        {
            ctrl.Dock = DockStyle.Fill; 
            ctrl.BackColor = Color.WhiteSmoke;
            ctrl.Font = new Font("Snap ITC", 12, FontStyle.Bold);
        }
        public static void ApplyStandardSettingsGrid(DataGridView grid)
        {
            // Základné správanie
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.RowHeadersVisible = false;

            // DÔLEŽITÉ – inak sa neaplikujú vlastné farby hlavičky
            grid.EnableHeadersVisualStyles = false;

            // ===== HLAVIČKA =====
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grid.ColumnHeadersHeight = 48;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 189, 248);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = grid.ColumnHeadersDefaultCellStyle.BackColor;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = grid.ColumnHeadersDefaultCellStyle.ForeColor;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            grid.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            grid.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            grid.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

            // ===== BUNKY =====
            grid.DefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(229, 231, 235);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 231, 235);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(56, 189, 248);
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);

            // Mriežka
            grid.GridColor = Color.FromArgb(229, 231, 235);
            grid.BackgroundColor = Color.FromArgb(30, 41, 59);
            grid.BorderStyle = BorderStyle.None;
        }
    }
}
