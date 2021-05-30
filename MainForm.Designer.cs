
namespace painter
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.figure_info = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_height_size = new System.Windows.Forms.TrackBar();
            this.tb_width_size = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_canvas_clear = new System.Windows.Forms.Button();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_height_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_width_size)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 312);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // figure_info
            // 
            this.figure_info.AutoSize = true;
            this.figure_info.Location = new System.Drawing.Point(12, 318);
            this.figure_info.Name = "figure_info";
            this.figure_info.Size = new System.Drawing.Size(35, 13);
            this.figure_info.TabIndex = 3;
            this.figure_info.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(620, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.cmb_figures_DropDownClosed);
            // 
            // tb_height_size
            // 
            this.tb_height_size.LargeChange = 10;
            this.tb_height_size.Location = new System.Drawing.Point(620, 116);
            this.tb_height_size.Maximum = 100;
            this.tb_height_size.Minimum = 10;
            this.tb_height_size.Name = "tb_height_size";
            this.tb_height_size.Size = new System.Drawing.Size(168, 45);
            this.tb_height_size.SmallChange = 5;
            this.tb_height_size.TabIndex = 5;
            this.tb_height_size.TickFrequency = 10;
            this.tb_height_size.Value = 10;
            this.tb_height_size.ValueChanged += new System.EventHandler(this.tb_height_size_ValueChanged);
            // 
            // tb_width_size
            // 
            this.tb_width_size.LargeChange = 10;
            this.tb_width_size.Location = new System.Drawing.Point(620, 65);
            this.tb_width_size.Maximum = 100;
            this.tb_width_size.Minimum = 10;
            this.tb_width_size.Name = "tb_width_size";
            this.tb_width_size.Size = new System.Drawing.Size(168, 45);
            this.tb_width_size.SmallChange = 5;
            this.tb_width_size.TabIndex = 6;
            this.tb_width_size.TickFrequency = 10;
            this.tb_width_size.Value = 10;
            this.tb_width_size.ValueChanged += new System.EventHandler(this.tb_width_size_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Change Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_change_figure_color);
            // 
            // btn_canvas_clear
            // 
            this.btn_canvas_clear.Location = new System.Drawing.Point(620, 213);
            this.btn_canvas_clear.Name = "btn_canvas_clear";
            this.btn_canvas_clear.Size = new System.Drawing.Size(168, 40);
            this.btn_canvas_clear.TabIndex = 7;
            this.btn_canvas_clear.Text = "Clear Canvas";
            this.btn_canvas_clear.UseVisualStyleBackColor = true;
            this.btn_canvas_clear.Click += new System.EventHandler(this.btn_canvas_clear_Click);
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(635, 48);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(38, 13);
            this.lbl_width.TabIndex = 8;
            this.lbl_width.Text = "Width:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(635, 97);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(41, 13);
            this.lbl_height.TabIndex = 8;
            this.lbl_height.Text = "Height:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.btn_canvas_clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_width_size);
            this.Controls.Add(this.tb_height_size);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.figure_info);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_height_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_width_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label figure_info;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar tb_height_size;
        private System.Windows.Forms.TrackBar tb_width_size;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_canvas_clear;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
    }
}

