﻿namespace Effectz
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_startid = new System.Windows.Forms.Label();
            this.nmr_startid = new System.Windows.Forms.NumericUpDown();
            this.lbl_stopid = new System.Windows.Forms.Label();
            this.nmr_stopid = new System.Windows.Forms.NumericUpDown();
            this.lbl_interval = new System.Windows.Forms.Label();
            this.nmr_interval = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.lbl_currentid = new System.Windows.Forms.Label();
            this.chk_loop = new System.Windows.Forms.CheckBox();
            this.txt_currentid = new System.Windows.Forms.TextBox();
            this.btn_applycurrent = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_mass_apply = new System.Windows.Forms.Button();
            this.lbl_ms = new System.Windows.Forms.Label();
            this.lbl_index = new System.Windows.Forms.Label();
            this.nmr_index = new System.Windows.Forms.NumericUpDown();
            this.nmr_entities = new System.Windows.Forms.NumericUpDown();
            this.nmr_delay = new System.Windows.Forms.NumericUpDown();
            this.lbl_entities = new System.Windows.Forms.Label();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_startid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_stopid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_entities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_startid
            // 
            this.lbl_startid.AutoSize = true;
            this.lbl_startid.Location = new System.Drawing.Point(12, 9);
            this.lbl_startid.Name = "lbl_startid";
            this.lbl_startid.Size = new System.Drawing.Size(43, 13);
            this.lbl_startid.TabIndex = 0;
            this.lbl_startid.Text = "Start ID";
            // 
            // nmr_startid
            // 
            this.nmr_startid.Location = new System.Drawing.Point(61, 7);
            this.nmr_startid.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmr_startid.Name = "nmr_startid";
            this.nmr_startid.Size = new System.Drawing.Size(57, 20);
            this.nmr_startid.TabIndex = 1;
            this.nmr_startid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_stopid
            // 
            this.lbl_stopid.AutoSize = true;
            this.lbl_stopid.Location = new System.Drawing.Point(12, 35);
            this.lbl_stopid.Name = "lbl_stopid";
            this.lbl_stopid.Size = new System.Drawing.Size(43, 13);
            this.lbl_stopid.TabIndex = 0;
            this.lbl_stopid.Text = "Stop ID";
            // 
            // nmr_stopid
            // 
            this.nmr_stopid.Location = new System.Drawing.Point(61, 33);
            this.nmr_stopid.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmr_stopid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_stopid.Name = "nmr_stopid";
            this.nmr_stopid.Size = new System.Drawing.Size(57, 20);
            this.nmr_stopid.TabIndex = 1;
            this.nmr_stopid.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lbl_interval
            // 
            this.lbl_interval.AutoSize = true;
            this.lbl_interval.Location = new System.Drawing.Point(12, 61);
            this.lbl_interval.Name = "lbl_interval";
            this.lbl_interval.Size = new System.Drawing.Size(42, 13);
            this.lbl_interval.TabIndex = 0;
            this.lbl_interval.Text = "Interval";
            // 
            // nmr_interval
            // 
            this.nmr_interval.Location = new System.Drawing.Point(61, 59);
            this.nmr_interval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nmr_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_interval.Name = "nmr_interval";
            this.nmr_interval.Size = new System.Drawing.Size(57, 20);
            this.nmr_interval.TabIndex = 1;
            this.nmr_interval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 111);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(108, 111);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(90, 23);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "⏸Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Visible = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // lbl_currentid
            // 
            this.lbl_currentid.AutoSize = true;
            this.lbl_currentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentid.Location = new System.Drawing.Point(125, 7);
            this.lbl_currentid.Name = "lbl_currentid";
            this.lbl_currentid.Size = new System.Drawing.Size(50, 37);
            this.lbl_currentid.TabIndex = 3;
            this.lbl_currentid.Text = "ID";
            // 
            // chk_loop
            // 
            this.chk_loop.AutoSize = true;
            this.chk_loop.Location = new System.Drawing.Point(124, 48);
            this.chk_loop.Name = "chk_loop";
            this.chk_loop.Size = new System.Drawing.Size(50, 17);
            this.chk_loop.TabIndex = 4;
            this.chk_loop.Text = "Loop";
            this.chk_loop.UseVisualStyleBackColor = true;
            // 
            // txt_currentid
            // 
            this.txt_currentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txt_currentid.Location = new System.Drawing.Point(124, 7);
            this.txt_currentid.Name = "txt_currentid";
            this.txt_currentid.Size = new System.Drawing.Size(66, 41);
            this.txt_currentid.TabIndex = 5;
            // 
            // btn_applycurrent
            // 
            this.btn_applycurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_applycurrent.Location = new System.Drawing.Point(190, 7);
            this.btn_applycurrent.Name = "btn_applycurrent";
            this.btn_applycurrent.Size = new System.Drawing.Size(17, 41);
            this.btn_applycurrent.TabIndex = 6;
            this.btn_applycurrent.Text = ">";
            this.btn_applycurrent.UseVisualStyleBackColor = true;
            this.btn_applycurrent.Click += new System.EventHandler(this.btn_applycurrent_Click);
            // 
            // btn_mass_apply
            // 
            this.btn_mass_apply.Location = new System.Drawing.Point(12, 140);
            this.btn_mass_apply.Name = "btn_mass_apply";
            this.btn_mass_apply.Size = new System.Drawing.Size(90, 40);
            this.btn_mass_apply.TabIndex = 2;
            this.btn_mass_apply.Text = "Mass apply";
            this.toolTip.SetToolTip(this.btn_mass_apply, "Apply the effect to everyone in the room");
            this.btn_mass_apply.UseVisualStyleBackColor = true;
            this.btn_mass_apply.Click += new System.EventHandler(this.btn_mass_apply_Click);
            // 
            // lbl_ms
            // 
            this.lbl_ms.AutoSize = true;
            this.lbl_ms.Location = new System.Drawing.Point(116, 63);
            this.lbl_ms.Name = "lbl_ms";
            this.lbl_ms.Size = new System.Drawing.Size(20, 13);
            this.lbl_ms.TabIndex = 0;
            this.lbl_ms.Text = "ms";
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(12, 87);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(33, 13);
            this.lbl_index.TabIndex = 0;
            this.lbl_index.Text = "Index";
            // 
            // nmr_index
            // 
            this.nmr_index.Location = new System.Drawing.Point(61, 85);
            this.nmr_index.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmr_index.Name = "nmr_index";
            this.nmr_index.Size = new System.Drawing.Size(57, 20);
            this.nmr_index.TabIndex = 1;
            // 
            // nmr_entities
            // 
            this.nmr_entities.Location = new System.Drawing.Point(150, 140);
            this.nmr_entities.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nmr_entities.Name = "nmr_entities";
            this.nmr_entities.Size = new System.Drawing.Size(57, 20);
            this.nmr_entities.TabIndex = 7;
            this.nmr_entities.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // nmr_delay
            // 
            this.nmr_delay.Location = new System.Drawing.Point(150, 160);
            this.nmr_delay.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nmr_delay.Name = "nmr_delay";
            this.nmr_delay.Size = new System.Drawing.Size(57, 20);
            this.nmr_delay.TabIndex = 8;
            // 
            // lbl_entities
            // 
            this.lbl_entities.AutoSize = true;
            this.lbl_entities.Location = new System.Drawing.Point(108, 143);
            this.lbl_entities.Name = "lbl_entities";
            this.lbl_entities.Size = new System.Drawing.Size(40, 13);
            this.lbl_entities.TabIndex = 9;
            this.lbl_entities.Text = "entities";
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Location = new System.Drawing.Point(116, 164);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(32, 13);
            this.lbl_delay.TabIndex = 9;
            this.lbl_delay.Text = "delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "____________________________________";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 192);
            this.Controls.Add(this.lbl_delay);
            this.Controls.Add(this.lbl_entities);
            this.Controls.Add(this.nmr_delay);
            this.Controls.Add(this.nmr_entities);
            this.Controls.Add(this.btn_applycurrent);
            this.Controls.Add(this.chk_loop);
            this.Controls.Add(this.btn_mass_apply);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.nmr_interval);
            this.Controls.Add(this.lbl_ms);
            this.Controls.Add(this.lbl_interval);
            this.Controls.Add(this.nmr_index);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.nmr_stopid);
            this.Controls.Add(this.lbl_stopid);
            this.Controls.Add(this.nmr_startid);
            this.Controls.Add(this.lbl_startid);
            this.Controls.Add(this.txt_currentid);
            this.Controls.Add(this.lbl_currentid);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI";
            this.Text = "Effectz";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_startid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_stopid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_entities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startid;
        private System.Windows.Forms.NumericUpDown nmr_startid;
        private System.Windows.Forms.Label lbl_stopid;
        private System.Windows.Forms.NumericUpDown nmr_stopid;
        private System.Windows.Forms.Label lbl_interval;
        private System.Windows.Forms.NumericUpDown nmr_interval;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Label lbl_currentid;
        private System.Windows.Forms.CheckBox chk_loop;
        private System.Windows.Forms.TextBox txt_currentid;
        private System.Windows.Forms.Button btn_applycurrent;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbl_ms;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.NumericUpDown nmr_index;
        private System.Windows.Forms.Button btn_mass_apply;
        private System.Windows.Forms.NumericUpDown nmr_entities;
        private System.Windows.Forms.NumericUpDown nmr_delay;
        private System.Windows.Forms.Label lbl_entities;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.Label label3;
    }
}

