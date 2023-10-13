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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.ownerBox = new System.Windows.Forms.TextBox();
            this.starsBox = new System.Windows.Forms.TextBox();
            this.seatsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.owner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.seats = new System.Windows.Forms.Label();
            this.visitors = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.visitorsBox = new System.Windows.Forms.TextBox();
            this.billBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.changingLabel = new System.Windows.Forms.Label();
            this.ownButton = new System.Windows.Forms.Button();
            this.strButton = new System.Windows.Forms.Button();
            this.infButton = new System.Windows.Forms.Button();
            this.mnyButton = new System.Windows.Forms.Button();
            this.ordButton = new System.Windows.Forms.Button();
            this.vsButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pickCafeBox = new System.Windows.Forms.TextBox();
            this.showBox = new System.Windows.Forms.TextBox();
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
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(47, 120);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(214, 26);
            this.nameBox.TabIndex = 1;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(47, 205);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(214, 26);
            this.addressBox.TabIndex = 2;
            // 
            // ownerBox
            // 
            this.ownerBox.Location = new System.Drawing.Point(47, 293);
            this.ownerBox.Multiline = true;
            this.ownerBox.Name = "ownerBox";
            this.ownerBox.Size = new System.Drawing.Size(214, 64);
            this.ownerBox.TabIndex = 3;
            // 
            // starsBox
            // 
            this.starsBox.Location = new System.Drawing.Point(296, 120);
            this.starsBox.Name = "starsBox";
            this.starsBox.Size = new System.Drawing.Size(130, 26);
            this.starsBox.TabIndex = 4;
            // 
            // seatsBox
            // 
            this.seatsBox.Location = new System.Drawing.Point(47, 408);
            this.seatsBox.Name = "seatsBox";
            this.seatsBox.Size = new System.Drawing.Size(214, 26);
            this.seatsBox.TabIndex = 5;
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
            // visitorsBox
            // 
            this.visitorsBox.Location = new System.Drawing.Point(296, 293);
            this.visitorsBox.Name = "visitorsBox";
            this.visitorsBox.Size = new System.Drawing.Size(130, 26);
            this.visitorsBox.TabIndex = 13;
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(296, 205);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(130, 26);
            this.billBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.showBox);
            this.panel2.Controls.Add(this.pickCafeBox);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.vsButton);
            this.panel2.Controls.Add(this.ordButton);
            this.panel2.Controls.Add(this.mnyButton);
            this.panel2.Controls.Add(this.infButton);
            this.panel2.Controls.Add(this.strButton);
            this.panel2.Controls.Add(this.ownButton);
            this.panel2.Controls.Add(this.changingLabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(545, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 573);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(620, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Выберете кафе для совершения действий:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(159, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Выберите действие:";
            // 
            // changingLabel
            // 
            this.changingLabel.AutoSize = true;
            this.changingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changingLabel.Location = new System.Drawing.Point(22, 325);
            this.changingLabel.Name = "changingLabel";
            this.changingLabel.Size = new System.Drawing.Size(303, 32);
            this.changingLabel.TabIndex = 2;
            this.changingLabel.Text = "ропблполрппропрпр";
            // 
            // ownButton
            // 
            this.ownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownButton.Location = new System.Drawing.Point(28, 177);
            this.ownButton.Name = "ownButton";
            this.ownButton.Size = new System.Drawing.Size(164, 59);
            this.ownButton.TabIndex = 3;
            this.ownButton.Text = "Изменить владельца";
            this.ownButton.UseVisualStyleBackColor = true;
            // 
            // strButton
            // 
            this.strButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strButton.Location = new System.Drawing.Point(209, 177);
            this.strButton.Name = "strButton";
            this.strButton.Size = new System.Drawing.Size(177, 59);
            this.strButton.TabIndex = 4;
            this.strButton.Text = "Изменить кол-во звезд";
            this.strButton.UseVisualStyleBackColor = true;
            // 
            // infButton
            // 
            this.infButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infButton.Location = new System.Drawing.Point(326, 248);
            this.infButton.Name = "infButton";
            this.infButton.Size = new System.Drawing.Size(265, 59);
            this.infButton.TabIndex = 5;
            this.infButton.Text = "Получить информацию о владельце";
            this.infButton.UseVisualStyleBackColor = true;
            // 
            // mnyButton
            // 
            this.mnyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mnyButton.Location = new System.Drawing.Point(28, 248);
            this.mnyButton.Name = "mnyButton";
            this.mnyButton.Size = new System.Drawing.Size(137, 59);
            this.mnyButton.TabIndex = 6;
            this.mnyButton.Text = "Рассчитать выручку";
            this.mnyButton.UseVisualStyleBackColor = true;
            // 
            // ordButton
            // 
            this.ordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordButton.Location = new System.Drawing.Point(179, 248);
            this.ordButton.Name = "ordButton";
            this.ordButton.Size = new System.Drawing.Size(134, 59);
            this.ordButton.TabIndex = 7;
            this.ordButton.Text = "Принять заказ";
            this.ordButton.UseVisualStyleBackColor = true;
            // 
            // vsButton
            // 
            this.vsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vsButton.Location = new System.Drawing.Point(402, 177);
            this.vsButton.Name = "vsButton";
            this.vsButton.Size = new System.Drawing.Size(189, 59);
            this.vsButton.TabIndex = 8;
            this.vsButton.Text = "Сравнить кафе";
            this.vsButton.UseVisualStyleBackColor = true;
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
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(264, 511);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 47);
            this.button8.TabIndex = 9;
            this.button8.Text = "Сделать";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pickCafeBox
            // 
            this.pickCafeBox.Location = new System.Drawing.Point(179, 71);
            this.pickCafeBox.Multiline = true;
            this.pickCafeBox.Name = "pickCafeBox";
            this.pickCafeBox.Size = new System.Drawing.Size(247, 36);
            this.pickCafeBox.TabIndex = 11;
            // 
            // showBox
            // 
            this.showBox.Location = new System.Drawing.Point(28, 371);
            this.showBox.Multiline = true;
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(563, 134);
            this.showBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 597);
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
        private System.Windows.Forms.TextBox showBox;
        private System.Windows.Forms.TextBox pickCafeBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button vsButton;
        private System.Windows.Forms.Button ordButton;
        private System.Windows.Forms.Button mnyButton;
        private System.Windows.Forms.Button infButton;
        private System.Windows.Forms.Button strButton;
        private System.Windows.Forms.Button ownButton;
        private System.Windows.Forms.Label changingLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

