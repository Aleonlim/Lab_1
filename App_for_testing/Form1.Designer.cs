namespace App_for_testing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.billBox = new System.Windows.Forms.TextBox();
            this.visitorsBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.visitors = new System.Windows.Forms.Label();
            this.seats = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.owner = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seatsBox = new System.Windows.Forms.TextBox();
            this.starsBox = new System.Windows.Forms.TextBox();
            this.ownerBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cafe_info_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vsBox = new System.Windows.Forms.TextBox();
            this.newstarsBox = new System.Windows.Forms.TextBox();
            this.newownBox = new System.Windows.Forms.TextBox();
            this.pickedCafeBox = new System.Windows.Forms.TextBox();
            this.vsButton = new System.Windows.Forms.Button();
            this.ordButton = new System.Windows.Forms.Button();
            this.mnyButton = new System.Windows.Forms.Button();
            this.infButton = new System.Windows.Forms.Button();
            this.strButton = new System.Windows.Forms.Button();
            this.ownButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.billBox);
            this.panel1.Controls.Add(this.visitorsBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.visitors);
            this.panel1.Controls.Add(this.seats);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.owner);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.seatsBox);
            this.panel1.Controls.Add(this.starsBox);
            this.panel1.Controls.Add(this.ownerBox);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 573);
            this.panel1.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Lavender;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(187, 482);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(130, 44);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(296, 205);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(130, 26);
            this.billBox.TabIndex = 14;
            // 
            // visitorsBox
            // 
            this.visitorsBox.Location = new System.Drawing.Point(296, 293);
            this.visitorsBox.Name = "visitorsBox";
            this.visitorsBox.Size = new System.Drawing.Size(130, 26);
            this.visitorsBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(291, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Средний чек (руб.):";
            // 
            // visitors
            // 
            this.visitors.AutoSize = true;
            this.visitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitors.Location = new System.Drawing.Point(291, 265);
            this.visitors.Name = "visitors";
            this.visitors.Size = new System.Drawing.Size(203, 25);
            this.visitors.TabIndex = 11;
            this.visitors.Text = "Число посетителей:";
            // 
            // seats
            // 
            this.seats.AutoSize = true;
            this.seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seats.Location = new System.Drawing.Point(42, 380);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(300, 25);
            this.seats.TabIndex = 10;
            this.seats.Text = "Количество посадочных мест:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(291, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество звезд:";
            // 
            // owner
            // 
            this.owner.AutoSize = true;
            this.owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.owner.Location = new System.Drawing.Point(42, 265);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(170, 25);
            this.owner.TabIndex = 8;
            this.owner.Text = "ФИО владельца:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название:";
            // 
            // seatsBox
            // 
            this.seatsBox.Location = new System.Drawing.Point(47, 408);
            this.seatsBox.Name = "seatsBox";
            this.seatsBox.Size = new System.Drawing.Size(214, 26);
            this.seatsBox.TabIndex = 5;
            // 
            // starsBox
            // 
            this.starsBox.Location = new System.Drawing.Point(296, 120);
            this.starsBox.Name = "starsBox";
            this.starsBox.Size = new System.Drawing.Size(130, 26);
            this.starsBox.TabIndex = 4;
            // 
            // ownerBox
            // 
            this.ownerBox.Location = new System.Drawing.Point(47, 293);
            this.ownerBox.Multiline = true;
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(214, 64);
            this.ownerBox.TabIndex = 3;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(47, 205);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(214, 26);
            this.addressBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(47, 120);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(214, 26);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание объекта кафе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.cafe_info_button);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.vsBox);
            this.panel2.Controls.Add(this.newstarsBox);
            this.panel2.Controls.Add(this.newownBox);
            this.panel2.Controls.Add(this.pickedCafeBox);
            this.panel2.Controls.Add(this.vsButton);
            this.panel2.Controls.Add(this.ordButton);
            this.panel2.Controls.Add(this.mnyButton);
            this.panel2.Controls.Add(this.infButton);
            this.panel2.Controls.Add(this.strButton);
            this.panel2.Controls.Add(this.ownButton);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(529, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 573);
            this.panel2.TabIndex = 1;
            // 
            // cafe_info_button
            // 
            this.cafe_info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cafe_info_button.Location = new System.Drawing.Point(532, 490);
            this.cafe_info_button.Name = "cafe_info_button";
            this.cafe_info_button.Size = new System.Drawing.Size(195, 68);
            this.cafe_info_button.TabIndex = 18;
            this.cafe_info_button.Text = "Получить сведения о кафе";
            this.cafe_info_button.UseVisualStyleBackColor = true;
            this.cafe_info_button.Click += new System.EventHandler(this.cafe_info_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(247, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Новое кол-во звезд:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(467, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кафе для сравнения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(3, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Новое ФИО владельца:";
            // 
            // vsBox
            // 
            this.vsBox.Location = new System.Drawing.Point(472, 223);
            this.vsBox.Multiline = true;
            this.vsBox.Name = "vsBox";
            this.vsBox.Size = new System.Drawing.Size(226, 69);
            this.vsBox.TabIndex = 14;
            // 
            // newstarsBox
            // 
            this.newstarsBox.Location = new System.Drawing.Point(241, 326);
            this.newstarsBox.Name = "newstarsBox";
            this.newstarsBox.Size = new System.Drawing.Size(195, 26);
            this.newstarsBox.TabIndex = 13;
            // 
            // newownBox
            // 
            this.newownBox.Location = new System.Drawing.Point(18, 223);
            this.newownBox.Multiline = true;
            this.newownBox.Name = "newownBox";
            this.newownBox.Size = new System.Drawing.Size(191, 69);
            this.newownBox.TabIndex = 12;
            // 
            // pickedCafeBox
            // 
            this.pickedCafeBox.Location = new System.Drawing.Point(217, 59);
            this.pickedCafeBox.Multiline = true;
            this.pickedCafeBox.Name = "pickedCafeBox";
            this.pickedCafeBox.Size = new System.Drawing.Size(247, 36);
            this.pickedCafeBox.TabIndex = 11;
            // 
            // vsButton
            // 
            this.vsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vsButton.Location = new System.Drawing.Point(489, 298);
            this.vsButton.Name = "vsButton";
            this.vsButton.Size = new System.Drawing.Size(189, 68);
            this.vsButton.TabIndex = 8;
            this.vsButton.Text = "Сравнить кафе";
            this.vsButton.UseVisualStyleBackColor = true;
            this.vsButton.Click += new System.EventHandler(this.vsButton_Click);
            // 
            // ordButton
            // 
            this.ordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordButton.Location = new System.Drawing.Point(406, 490);
            this.ordButton.Name = "ordButton";
            this.ordButton.Size = new System.Drawing.Size(119, 68);
            this.ordButton.TabIndex = 7;
            this.ordButton.Text = "Принять заказ";
            this.ordButton.UseVisualStyleBackColor = true;
            this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
            // 
            // mnyButton
            // 
            this.mnyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mnyButton.Location = new System.Drawing.Point(252, 490);
            this.mnyButton.Name = "mnyButton";
            this.mnyButton.Size = new System.Drawing.Size(148, 68);
            this.mnyButton.TabIndex = 6;
            this.mnyButton.Text = "Рассчитать выручку";
            this.mnyButton.UseVisualStyleBackColor = true;
            this.mnyButton.Click += new System.EventHandler(this.mnyButton_Click);
            // 
            // infButton
            // 
            this.infButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infButton.Location = new System.Drawing.Point(3, 490);
            this.infButton.Name = "infButton";
            this.infButton.Size = new System.Drawing.Size(243, 68);
            this.infButton.TabIndex = 5;
            this.infButton.Text = "Получить информацию о владельце";
            this.infButton.UseVisualStyleBackColor = true;
            this.infButton.Click += new System.EventHandler(this.infButton_Click);
            // 
            // strButton
            // 
            this.strButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strButton.Location = new System.Drawing.Point(252, 358);
            this.strButton.Name = "strButton";
            this.strButton.Size = new System.Drawing.Size(177, 68);
            this.strButton.TabIndex = 4;
            this.strButton.Text = "Изменить кол-во звезд";
            this.strButton.UseVisualStyleBackColor = true;
            this.strButton.Click += new System.EventHandler(this.strButton_Click);
            // 
            // ownButton
            // 
            this.ownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownButton.Location = new System.Drawing.Point(35, 298);
            this.ownButton.Name = "ownButton";
            this.ownButton.Size = new System.Drawing.Size(164, 68);
            this.ownButton.TabIndex = 3;
            this.ownButton.Text = "Изменить владельца";
            this.ownButton.UseVisualStyleBackColor = true;
            this.ownButton.Click += new System.EventHandler(this.ownButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(183, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Выберите действие:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(29, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(645, 84);
            this.label9.TabIndex = 0;
            this.label9.Text = "Введите название кафе для совершения действий:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label visitors;
        private System.Windows.Forms.Label seats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label owner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seatsBox;
        private System.Windows.Forms.TextBox starsBox;
        private System.Windows.Forms.TextBox ownerBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.TextBox visitorsBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox pickedCafeBox;
        private System.Windows.Forms.Button vsButton;
        private System.Windows.Forms.Button ordButton;
        private System.Windows.Forms.Button mnyButton;
        private System.Windows.Forms.Button infButton;
        private System.Windows.Forms.Button strButton;
        private System.Windows.Forms.Button ownButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vsBox;
        private System.Windows.Forms.TextBox newstarsBox;
        private System.Windows.Forms.TextBox newownBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cafe_info_button;
    }
}

