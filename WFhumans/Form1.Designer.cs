namespace WFhumans
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dobav = new System.Windows.Forms.Button();
            this.GW1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GW1)).BeginInit();
            this.SuspendLayout();
            // 
            // dobav
            // 
            this.dobav.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dobav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dobav.Location = new System.Drawing.Point(21, 229);
            this.dobav.Name = "dobav";
            this.dobav.Size = new System.Drawing.Size(137, 41);
            this.dobav.TabIndex = 0;
            this.dobav.Text = "Добавить";
            this.dobav.UseVisualStyleBackColor = false;
            this.dobav.Click += new System.EventHandler(this.button1_Click);
            // 
            // GW1
            // 
            this.GW1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.GW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GW1.Location = new System.Drawing.Point(21, 9);
            this.GW1.Name = "GW1";
            this.GW1.Size = new System.Drawing.Size(621, 200);
            this.GW1.TabIndex = 3;
            this.GW1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GW1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLoad.Location = new System.Drawing.Point(257, 229);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(129, 41);
            this.btLoad.TabIndex = 5;
            this.btLoad.Text = "Загрузить";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(257, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btSort
            // 
            this.btSort.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSort.Location = new System.Drawing.Point(497, 229);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(145, 41);
            this.btSort.TabIndex = 7;
            this.btSort.Text = "Сортировать";
            this.btSort.UseVisualStyleBackColor = false;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSearch.Location = new System.Drawing.Point(497, 299);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(145, 41);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Найти";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Location = new System.Drawing.Point(394, 359);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(72, 17);
            this.cbName.TabIndex = 9;
            this.cbName.Text = "По имени";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(475, 356);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(167, 21);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.Text = "Имя для поиска";
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(681, 420);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GW1);
            this.Controls.Add(this.dobav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GW1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dobav;
        private System.Windows.Forms.DataGridView GW1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

