namespace Mem
{
    partial class MemoryAllocator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryAllocator));
            this.First_fit = new System.Windows.Forms.RadioButton();
            this.Best_fit = new System.Windows.Forms.RadioButton();
            this.Size = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.TextBox();
            this.Allocation_button = new System.Windows.Forms.Button();
            this.Deallocation_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Hole_address = new System.Windows.Forms.MaskedTextBox();
            this.Hole_size = new System.Windows.Forms.MaskedTextBox();
            this.Add_hole = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Worst_fit = new System.Windows.Forms.RadioButton();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Holes_view = new System.Windows.Forms.DataGridView();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Holes_view_box = new System.Windows.Forms.GroupBox();
            this.Memory_view_box = new System.Windows.Forms.GroupBox();
            this.Memory_view = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Holes_view)).BeginInit();
            this.Holes_view_box.SuspendLayout();
            this.Memory_view_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Memory_view)).BeginInit();
            this.SuspendLayout();
            // 
            // First_fit
            // 
            this.First_fit.AutoSize = true;
            this.First_fit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_fit.Location = new System.Drawing.Point(37, 46);
            this.First_fit.Name = "First_fit";
            this.First_fit.Size = new System.Drawing.Size(70, 28);
            this.First_fit.TabIndex = 1;
            this.First_fit.TabStop = true;
            this.First_fit.Text = "First-fit";
            this.First_fit.UseVisualStyleBackColor = true;
            this.First_fit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Best_fit
            // 
            this.Best_fit.AutoSize = true;
            this.Best_fit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Best_fit.Location = new System.Drawing.Point(37, 80);
            this.Best_fit.Name = "Best_fit";
            this.Best_fit.Size = new System.Drawing.Size(70, 28);
            this.Best_fit.TabIndex = 2;
            this.Best_fit.TabStop = true;
            this.Best_fit.Text = "Best-fit";
            this.Best_fit.UseVisualStyleBackColor = true;
            this.Best_fit.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(152, 91);
            this.Size.Mask = "00000";
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(100, 30);
            this.Size.TabIndex = 3;
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Size.ValidatingType = typeof(int);
            this.Size.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size";
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(152, 40);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(100, 30);
            this.PID.TabIndex = 7;
            this.PID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Allocation_button
            // 
            this.Allocation_button.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allocation_button.ForeColor = System.Drawing.Color.Blue;
            this.Allocation_button.Location = new System.Drawing.Point(6, 166);
            this.Allocation_button.Name = "Allocation_button";
            this.Allocation_button.Size = new System.Drawing.Size(126, 30);
            this.Allocation_button.TabIndex = 9;
            this.Allocation_button.Text = "Allocate";
            this.Allocation_button.UseVisualStyleBackColor = true;
            this.Allocation_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deallocation_button
            // 
            this.Deallocation_button.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deallocation_button.ForeColor = System.Drawing.Color.Red;
            this.Deallocation_button.Location = new System.Drawing.Point(152, 166);
            this.Deallocation_button.Name = "Deallocation_button";
            this.Deallocation_button.Size = new System.Drawing.Size(126, 30);
            this.Deallocation_button.TabIndex = 9;
            this.Deallocation_button.Text = "Deallocate";
            this.Deallocation_button.UseVisualStyleBackColor = true;
            this.Deallocation_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hole size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Start Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Hole_address);
            this.groupBox1.Controls.Add(this.Hole_size);
            this.groupBox1.Controls.Add(this.Add_hole);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Holes";
            // 
            // Hole_address
            // 
            this.Hole_address.Location = new System.Drawing.Point(140, 33);
            this.Hole_address.Mask = "00000";
            this.Hole_address.Name = "Hole_address";
            this.Hole_address.Size = new System.Drawing.Size(100, 30);
            this.Hole_address.TabIndex = 14;
            this.Hole_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hole_address.ValidatingType = typeof(int);
            this.Hole_address.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Hole_address_MaskInputRejected);
            // 
            // Hole_size
            // 
            this.Hole_size.Location = new System.Drawing.Point(360, 33);
            this.Hole_size.Mask = "00000";
            this.Hole_size.Name = "Hole_size";
            this.Hole_size.Size = new System.Drawing.Size(100, 30);
            this.Hole_size.TabIndex = 13;
            this.Hole_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hole_size.ValidatingType = typeof(int);
            this.Hole_size.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Hole_size_MaskInputRejected);
            // 
            // Add_hole
            // 
            this.Add_hole.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_hole.ForeColor = System.Drawing.Color.Green;
            this.Add_hole.Location = new System.Drawing.Point(186, 92);
            this.Add_hole.Name = "Add_hole";
            this.Add_hole.Size = new System.Drawing.Size(126, 31);
            this.Add_hole.TabIndex = 12;
            this.Add_hole.Text = "Add Hole";
            this.Add_hole.UseVisualStyleBackColor = true;
            this.Add_hole.Click += new System.EventHandler(this.Add_hole_Click);
            // 
            // Start_button
            // 
            this.Start_button.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button.ForeColor = System.Drawing.Color.DarkViolet;
            this.Start_button.Location = new System.Drawing.Point(12, 178);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(485, 51);
            this.Start_button.TabIndex = 12;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Size);
            this.groupBox2.Controls.Add(this.Deallocation_button);
            this.groupBox2.Controls.Add(this.Allocation_button);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PID);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 221);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process info.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Worst_fit);
            this.groupBox3.Controls.Add(this.First_fit);
            this.groupBox3.Controls.Add(this.Best_fit);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(284, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 162);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allocation type";
            // 
            // Worst_fit
            // 
            this.Worst_fit.AutoSize = true;
            this.Worst_fit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Worst_fit.Location = new System.Drawing.Point(37, 114);
            this.Worst_fit.Name = "Worst_fit";
            this.Worst_fit.Size = new System.Drawing.Size(77, 28);
            this.Worst_fit.TabIndex = 3;
            this.Worst_fit.TabStop = true;
            this.Worst_fit.Text = "Worst-fit";
            this.Worst_fit.UseVisualStyleBackColor = true;
            this.Worst_fit.CheckedChanged += new System.EventHandler(this.Worst_fit_CheckedChanged);
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Reset_button.Location = new System.Drawing.Point(11, 496);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(485, 46);
            this.Reset_button.TabIndex = 14;
            this.Reset_button.Text = "RESET";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Holes_view
            // 
            this.Holes_view.AllowUserToAddRows = false;
            this.Holes_view.AllowUserToResizeColumns = false;
            this.Holes_view.AllowUserToResizeRows = false;
            this.Holes_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Holes_view.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Holes_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Holes_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Memory,
            this.Location_size});
            this.Holes_view.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Holes_view.Location = new System.Drawing.Point(6, 34);
            this.Holes_view.Name = "Holes_view";
            this.Holes_view.RowHeadersVisible = false;
            this.Holes_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Holes_view.Size = new System.Drawing.Size(348, 497);
            this.Holes_view.TabIndex = 15;
            this.Holes_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Memory_view_CellContentClick);
            // 
            // Memory
            // 
            this.Memory.HeaderText = "Start Address";
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            this.Memory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Memory.Width = 172;
            // 
            // Location_size
            // 
            this.Location_size.HeaderText = "Hole size";
            this.Location_size.Name = "Location_size";
            this.Location_size.ReadOnly = true;
            this.Location_size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Location_size.Width = 173;
            // 
            // Holes_view_box
            // 
            this.Holes_view_box.Controls.Add(this.Holes_view);
            this.Holes_view_box.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Holes_view_box.Location = new System.Drawing.Point(519, 12);
            this.Holes_view_box.Name = "Holes_view_box";
            this.Holes_view_box.Size = new System.Drawing.Size(360, 531);
            this.Holes_view_box.TabIndex = 16;
            this.Holes_view_box.TabStop = false;
            this.Holes_view_box.Text = "Holes view";
            this.Holes_view_box.Enter += new System.EventHandler(this.Holes_view_box_Enter);
            // 
            // Memory_view_box
            // 
            this.Memory_view_box.Controls.Add(this.Memory_view);
            this.Memory_view_box.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory_view_box.Location = new System.Drawing.Point(901, 12);
            this.Memory_view_box.Name = "Memory_view_box";
            this.Memory_view_box.Size = new System.Drawing.Size(360, 531);
            this.Memory_view_box.TabIndex = 17;
            this.Memory_view_box.TabStop = false;
            this.Memory_view_box.Text = "Memory view";
            this.Memory_view_box.Enter += new System.EventHandler(this.Memory_view_box_Enter);
            // 
            // Memory_view
            // 
            this.Memory_view.AllowUserToAddRows = false;
            this.Memory_view.AllowUserToResizeColumns = false;
            this.Memory_view.AllowUserToResizeRows = false;
            this.Memory_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Memory_view.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Memory_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Memory_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Process_name,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.Memory_view.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Memory_view.Location = new System.Drawing.Point(6, 34);
            this.Memory_view.Name = "Memory_view";
            this.Memory_view.RowHeadersVisible = false;
            this.Memory_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Memory_view.Size = new System.Drawing.Size(348, 497);
            this.Memory_view.TabIndex = 15;
            this.Memory_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Memory_view_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Flag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // Process_name
            // 
            this.Process_name.HeaderText = "PID";
            this.Process_name.Name = "Process_name";
            this.Process_name.ReadOnly = true;
            this.Process_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Process_name.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Start Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Process size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // MemoryAllocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 560);
            this.Controls.Add(this.Memory_view_box);
            this.Controls.Add(this.Holes_view_box);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemoryAllocator";
            this.Text = "Memory Allocator";
            this.Load += new System.EventHandler(this.MemoryAllocator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Holes_view)).EndInit();
            this.Holes_view_box.ResumeLayout(false);
            this.Memory_view_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Memory_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton First_fit;
        private System.Windows.Forms.RadioButton Best_fit;
        private System.Windows.Forms.MaskedTextBox Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PID;
        private System.Windows.Forms.Button Allocation_button;
        private System.Windows.Forms.Button Deallocation_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_hole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox Hole_address;
        private System.Windows.Forms.MaskedTextBox Hole_size;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.DataGridView Holes_view;
        private System.Windows.Forms.GroupBox Holes_view_box;
        private System.Windows.Forms.GroupBox Memory_view_box;
        private System.Windows.Forms.DataGridView Memory_view;
        private System.Windows.Forms.RadioButton Worst_fit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

