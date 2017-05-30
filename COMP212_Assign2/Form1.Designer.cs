namespace RestaurantBillCalc
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxBev = new System.Windows.Forms.ComboBox();
            this.foodItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxApp = new System.Windows.Forms.ComboBox();
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.comboBoxDessert = new System.Windows.Forms.ComboBox();
            this.bevLabel = new System.Windows.Forms.Label();
            this.appLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.dessertLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subtotalBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBev
            // 
            this.comboBoxBev.DataSource = this.foodItemBindingSource;
            this.comboBoxBev.DisplayMember = "name";
            this.comboBoxBev.FormattingEnabled = true;
            this.comboBoxBev.Location = new System.Drawing.Point(12, 42);
            this.comboBoxBev.Name = "comboBoxBev";
            this.comboBoxBev.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBev.TabIndex = 0;
            this.comboBoxBev.ValueMember = "price";
            this.comboBoxBev.SelectedIndexChanged += new System.EventHandler(this.comboBoxBev_SelectedIndexChanged);
            // 
            // foodItemBindingSource
            // 
            this.foodItemBindingSource.DataSource = typeof(RestaurantBillCalc.FoodItem);
            // 
            // comboBoxApp
            // 
            this.comboBoxApp.DataSource = this.foodItemBindingSource;
            this.comboBoxApp.DisplayMember = "name";
            this.comboBoxApp.FormattingEnabled = true;
            this.comboBoxApp.Location = new System.Drawing.Point(163, 42);
            this.comboBoxApp.Name = "comboBoxApp";
            this.comboBoxApp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxApp.TabIndex = 1;
            this.comboBoxApp.ValueMember = "price";
            this.comboBoxApp.SelectedIndexChanged += new System.EventHandler(this.comboBoxApp_SelectedIndexChanged);
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.DataSource = this.foodItemBindingSource;
            this.comboBoxMain.DisplayMember = "name";
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Location = new System.Drawing.Point(309, 42);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMain.TabIndex = 2;
            this.comboBoxMain.ValueMember = "price";
            this.comboBoxMain.SelectedIndexChanged += new System.EventHandler(this.comboBoxMain_SelectedIndexChanged);
            // 
            // comboBoxDessert
            // 
            this.comboBoxDessert.DataSource = this.foodItemBindingSource;
            this.comboBoxDessert.DisplayMember = "name";
            this.comboBoxDessert.FormattingEnabled = true;
            this.comboBoxDessert.Location = new System.Drawing.Point(454, 42);
            this.comboBoxDessert.Name = "comboBoxDessert";
            this.comboBoxDessert.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDessert.TabIndex = 3;
            this.comboBoxDessert.ValueMember = "price";
            this.comboBoxDessert.SelectedIndexChanged += new System.EventHandler(this.comboBoxDessert_SelectedIndexChanged);
            // 
            // bevLabel
            // 
            this.bevLabel.AutoSize = true;
            this.bevLabel.Location = new System.Drawing.Point(29, 26);
            this.bevLabel.Name = "bevLabel";
            this.bevLabel.Size = new System.Drawing.Size(86, 13);
            this.bevLabel.TabIndex = 5;
            this.bevLabel.Text = "Select Beverage";
            this.bevLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.Location = new System.Drawing.Point(181, 26);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(84, 13);
            this.appLabel.TabIndex = 6;
            this.appLabel.Text = "Select Appetizer";
            this.appLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(322, 26);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(99, 13);
            this.mainLabel.TabIndex = 7;
            this.mainLabel.Text = "Select Main Course";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dessertLabel
            // 
            this.dessertLabel.AutoSize = true;
            this.dessertLabel.Location = new System.Drawing.Point(476, 26);
            this.dessertLabel.Name = "dessertLabel";
            this.dessertLabel.Size = new System.Drawing.Size(76, 13);
            this.dessertLabel.TabIndex = 8;
            this.dessertLabel.Text = "Select Dessert";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(366, 205);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // subtotalBox
            // 
            this.subtotalBox.Location = new System.Drawing.Point(44, 338);
            this.subtotalBox.Name = "subtotalBox";
            this.subtotalBox.ReadOnly = true;
            this.subtotalBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalBox.TabIndex = 10;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(248, 338);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(100, 20);
            this.taxBox.TabIndex = 11;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(439, 338);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(464, 148);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear Bill";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Location = new System.Drawing.Point(464, 216);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(75, 23);
            this.checkoutBtn.TabIndex = 17;
            this.checkoutBtn.Text = "Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 411);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.subtotalBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dessertLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.bevLabel);
            this.Controls.Add(this.comboBoxDessert);
            this.Controls.Add(this.comboBoxMain);
            this.Controls.Add(this.comboBoxApp);
            this.Controls.Add(this.comboBoxBev);
            this.Name = "Form1";
            this.Text = "Restaurant Bill Calculator";
            this.Controls.SetChildIndex(this.comboBoxBev, 0);
            this.Controls.SetChildIndex(this.comboBoxApp, 0);
            this.Controls.SetChildIndex(this.comboBoxMain, 0);
            this.Controls.SetChildIndex(this.comboBoxDessert, 0);
            this.Controls.SetChildIndex(this.bevLabel, 0);
            this.Controls.SetChildIndex(this.appLabel, 0);
            this.Controls.SetChildIndex(this.mainLabel, 0);
            this.Controls.SetChildIndex(this.dessertLabel, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.subtotalBox, 0);
            this.Controls.SetChildIndex(this.taxBox, 0);
            this.Controls.SetChildIndex(this.totalBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.clearBtn, 0);
            this.Controls.SetChildIndex(this.checkoutBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.foodItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBev;
        private System.Windows.Forms.BindingSource foodItemBindingSource;
        private System.Windows.Forms.ComboBox comboBoxApp;
        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.ComboBox comboBoxDessert;
        private System.Windows.Forms.Label bevLabel;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label dessertLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox subtotalBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button checkoutBtn;
    }
}

