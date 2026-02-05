namespace MusicHub
{
    partial class ArtistList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvArtist = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvArtist).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(229, 231, 235);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(1144, 48);
            label1.TabIndex = 0;
            label1.Text = "ARTISTS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvArtist
            // 
            dgvArtist.AllowUserToAddRows = false;
            dgvArtist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtist.Location = new Point(28, 76);
            dgvArtist.MultiSelect = false;
            dgvArtist.Name = "dgvArtist";
            dgvArtist.RowHeadersVisible = false;
            dgvArtist.RowHeadersWidth = 51;
            dgvArtist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtist.Size = new Size(1100, 500);
            dgvArtist.TabIndex = 4;
            dgvArtist.CellDoubleClick += dgvArtist_CellDoubleClick;
            // 
            // ArtistList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            Controls.Add(dgvArtist);
            Controls.Add(label1);
            Name = "ArtistList";
            Size = new Size(1150, 600);
            ((System.ComponentModel.ISupportInitialize)dgvArtist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvArtist;
    }
}
