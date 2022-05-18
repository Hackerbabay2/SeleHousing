
namespace SaleHousing_Chupin_
{
    partial class SaleHouseing
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
            this.salesListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disctrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseСharacteristic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appartamentCharacteristic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.needingPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.layout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.houseCharactiristicBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SquareBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.apartmentCharactiristicBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contactDetailsBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LayoutBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.needingPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.floorNumeric = new System.Windows.Forms.NumericUpDown();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.fromNumeric = new System.Windows.Forms.NumericUpDown();
            this.toNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.needingPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // salesListView
            // 
            this.salesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.disctrict,
            this.address,
            this.houseСharacteristic,
            this.appartamentCharacteristic,
            this.needingPrice,
            this.area,
            this.layout,
            this.stage,
            this.contactDetails});
            this.salesListView.GridLines = true;
            this.salesListView.HideSelection = false;
            this.salesListView.Location = new System.Drawing.Point(587, 12);
            this.salesListView.Name = "salesListView";
            this.salesListView.Size = new System.Drawing.Size(461, 464);
            this.salesListView.TabIndex = 0;
            this.salesListView.UseCompatibleStateImageBehavior = false;
            this.salesListView.View = System.Windows.Forms.View.Details;
            this.salesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 34;
            // 
            // disctrict
            // 
            this.disctrict.Text = "Район";
            // 
            // address
            // 
            this.address.Text = "Адрес";
            this.address.Width = 157;
            // 
            // houseСharacteristic
            // 
            this.houseСharacteristic.Text = "Характеристика дома";
            this.houseСharacteristic.Width = 158;
            // 
            // appartamentCharacteristic
            // 
            this.appartamentCharacteristic.Text = "Характеристика квартиры";
            this.appartamentCharacteristic.Width = 192;
            // 
            // needingPrice
            // 
            this.needingPrice.Text = "Запрашиваемая стоимость";
            this.needingPrice.Width = 195;
            // 
            // area
            // 
            this.area.Text = "Площадь";
            this.area.Width = 76;
            // 
            // layout
            // 
            this.layout.Text = "планировка";
            this.layout.Width = 92;
            // 
            // stage
            // 
            this.stage.Text = "Этаж";
            this.stage.Width = 51;
            // 
            // contactDetails
            // 
            this.contactDetails.Text = "Координаты заявителя";
            this.contactDetails.Width = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Район";
            // 
            // districtBox
            // 
            this.districtBox.Location = new System.Drawing.Point(13, 9);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(118, 22);
            this.districtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // houseCharactiristicBox
            // 
            this.houseCharactiristicBox.Location = new System.Drawing.Point(13, 65);
            this.houseCharactiristicBox.Name = "houseCharactiristicBox";
            this.houseCharactiristicBox.Size = new System.Drawing.Size(118, 22);
            this.houseCharactiristicBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Характеристика дома";
            // 
            // SquareBox
            // 
            this.SquareBox.Location = new System.Drawing.Point(13, 149);
            this.SquareBox.Name = "SquareBox";
            this.SquareBox.Size = new System.Drawing.Size(118, 22);
            this.SquareBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Площадь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Запрашиваемая стоимость";
            // 
            // apartmentCharactiristicBox
            // 
            this.apartmentCharactiristicBox.Location = new System.Drawing.Point(13, 93);
            this.apartmentCharactiristicBox.Name = "apartmentCharactiristicBox";
            this.apartmentCharactiristicBox.Size = new System.Drawing.Size(118, 22);
            this.apartmentCharactiristicBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Характеристика квартиры";
            // 
            // contactDetailsBox
            // 
            this.contactDetailsBox.Location = new System.Drawing.Point(13, 233);
            this.contactDetailsBox.Name = "contactDetailsBox";
            this.contactDetailsBox.Size = new System.Drawing.Size(118, 22);
            this.contactDetailsBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Координаты заявтеля";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Этаж";
            // 
            // LayoutBox
            // 
            this.LayoutBox.Location = new System.Drawing.Point(13, 177);
            this.LayoutBox.Name = "LayoutBox";
            this.LayoutBox.Size = new System.Drawing.Size(118, 22);
            this.LayoutBox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Планировка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // needingPriceNumeric
            // 
            this.needingPriceNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.needingPriceNumeric.Location = new System.Drawing.Point(13, 122);
            this.needingPriceNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.needingPriceNumeric.Name = "needingPriceNumeric";
            this.needingPriceNumeric.Size = new System.Drawing.Size(118, 22);
            this.needingPriceNumeric.TabIndex = 20;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(13, 40);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(118, 22);
            this.addressBox.TabIndex = 21;
            this.addressBox.Text = "ул. дом. кв.";
            // 
            // floorNumeric
            // 
            this.floorNumeric.Location = new System.Drawing.Point(13, 205);
            this.floorNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.floorNumeric.Name = "floorNumeric";
            this.floorNumeric.Size = new System.Drawing.Size(118, 22);
            this.floorNumeric.TabIndex = 22;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(463, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(118, 22);
            this.searchBox.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Загрузить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Редактировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(463, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // idNumeric
            // 
            this.idNumeric.Location = new System.Drawing.Point(489, 65);
            this.idNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.Size = new System.Drawing.Size(91, 22);
            this.idNumeric.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(465, 453);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 23);
            this.button7.TabIndex = 31;
            this.button7.Text = "Обновить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(465, 416);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 29);
            this.button8.TabIndex = 32;
            this.button8.Text = "Спрос";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // fromNumeric
            // 
            this.fromNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fromNumeric.Location = new System.Drawing.Point(465, 360);
            this.fromNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.fromNumeric.Name = "fromNumeric";
            this.fromNumeric.Size = new System.Drawing.Size(118, 22);
            this.fromNumeric.TabIndex = 33;
            // 
            // toNumeric
            // 
            this.toNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.toNumeric.Location = new System.Drawing.Point(465, 388);
            this.toNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.toNumeric.Name = "toNumeric";
            this.toNumeric.Size = new System.Drawing.Size(118, 22);
            this.toNumeric.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "от";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "до";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Цена";
            // 
            // SaleHouseing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1060, 488);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toNumeric);
            this.Controls.Add(this.fromNumeric);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idNumeric);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.floorNumeric);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.needingPriceNumeric);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contactDetailsBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LayoutBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SquareBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apartmentCharactiristicBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.houseCharactiristicBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.districtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesListView);
            this.Name = "SaleHouseing";
            this.Text = "Продажа жилья";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.needingPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView salesListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader disctrict;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader houseСharacteristic;
        private System.Windows.Forms.ColumnHeader appartamentCharacteristic;
        private System.Windows.Forms.ColumnHeader needingPrice;
        private System.Windows.Forms.ColumnHeader area;
        private System.Windows.Forms.ColumnHeader layout;
        private System.Windows.Forms.ColumnHeader stage;
        private System.Windows.Forms.ColumnHeader contactDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox houseCharactiristicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SquareBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apartmentCharactiristicBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactDetailsBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LayoutBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown needingPriceNumeric;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.NumericUpDown floorNumeric;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown fromNumeric;
        private System.Windows.Forms.NumericUpDown toNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
    }
}

