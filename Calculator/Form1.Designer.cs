namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.standardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReturn0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnInX = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btn1X = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnPrecent = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.boxTemperature = new System.Windows.Forms.GroupBox();
            this.boxSelect = new System.Windows.Forms.GroupBox();
            this.kevin = new System.Windows.Forms.RadioButton();
            this.fahrenheitCelsius = new System.Windows.Forms.RadioButton();
            this.celsiusFahrenheit = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCovert = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.boxMultiplication = new System.Windows.Forms.GroupBox();
            this.btnResetMultiply = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.txtMultiply = new System.Windows.Forms.TextBox();
            this.listForMultiplication = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.boxTemperature.SuspendLayout();
            this.boxSelect.SuspendLayout();
            this.boxMultiplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(883, 39);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardMenu,
            this.scientificMenu,
            this.temperatureMenu,
            this.multiplicationMenu,
            this.exitToolStripMenuItem});
            this.menu.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.Navy;
            this.menu.Image = global::Calculator.Properties.Resources.iconfinder_menu_1814109;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(35, 35);
            this.menu.ToolTipText = "Menu";
            // 
            // standardMenu
            // 
            this.standardMenu.ForeColor = System.Drawing.Color.Navy;
            this.standardMenu.Name = "standardMenu";
            this.standardMenu.Size = new System.Drawing.Size(164, 22);
            this.standardMenu.Text = "Standard";
            this.standardMenu.Click += new System.EventHandler(this.standardMenu_Click);
            // 
            // scientificMenu
            // 
            this.scientificMenu.ForeColor = System.Drawing.Color.Navy;
            this.scientificMenu.Name = "scientificMenu";
            this.scientificMenu.Size = new System.Drawing.Size(164, 22);
            this.scientificMenu.Text = "Scientific";
            this.scientificMenu.Click += new System.EventHandler(this.scientificMenu_Click);
            // 
            // temperatureMenu
            // 
            this.temperatureMenu.ForeColor = System.Drawing.Color.Navy;
            this.temperatureMenu.Name = "temperatureMenu";
            this.temperatureMenu.Size = new System.Drawing.Size(164, 22);
            this.temperatureMenu.Text = "Temperature";
            this.temperatureMenu.Click += new System.EventHandler(this.temperatureMenu_Click);
            // 
            // multiplicationMenu
            // 
            this.multiplicationMenu.ForeColor = System.Drawing.Color.Navy;
            this.multiplicationMenu.Name = "multiplicationMenu";
            this.multiplicationMenu.Size = new System.Drawing.Size(164, 22);
            this.multiplicationMenu.Text = "Multiplication";
            this.multiplicationMenu.Click += new System.EventHandler(this.multiplicationMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.ForeColor = System.Drawing.Color.Navy;
            this.txtBox.Location = new System.Drawing.Point(12, 42);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(482, 46);
            this.txtBox.TabIndex = 1;
            this.txtBox.Text = "0";
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Navy;
            this.btnRemove.Location = new System.Drawing.Point(12, 103);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(53, 46);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(71, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReturn0
            // 
            this.btnReturn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReturn0.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn0.ForeColor = System.Drawing.Color.Navy;
            this.btnReturn0.Location = new System.Drawing.Point(130, 102);
            this.btnReturn0.Name = "btnReturn0";
            this.btnReturn0.Size = new System.Drawing.Size(53, 46);
            this.btnReturn0.TabIndex = 4;
            this.btnReturn0.Text = "C";
            this.btnReturn0.UseVisualStyleBackColor = false;
            this.btnReturn0.Click += new System.EventHandler(this.btnReturn0_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlusMinus.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.ForeColor = System.Drawing.Color.Navy;
            this.btnPlusMinus.Location = new System.Drawing.Point(189, 102);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(53, 46);
            this.btnPlusMinus.TabIndex = 5;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Navy;
            this.btn7.Location = new System.Drawing.Point(12, 154);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 46);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Navy;
            this.btn8.Location = new System.Drawing.Point(71, 154);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 46);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Navy;
            this.btn9.Location = new System.Drawing.Point(130, 154);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 46);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlus.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Navy;
            this.btnPlus.Location = new System.Drawing.Point(189, 154);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 46);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMultiplication.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.Navy;
            this.btnMultiplication.Location = new System.Drawing.Point(189, 258);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(53, 46);
            this.btnMultiplication.TabIndex = 17;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Navy;
            this.btn3.Location = new System.Drawing.Point(130, 258);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 46);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Navy;
            this.btn2.Location = new System.Drawing.Point(71, 258);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 46);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Navy;
            this.btn1.Location = new System.Drawing.Point(12, 258);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 46);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMinus.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Navy;
            this.btnMinus.Location = new System.Drawing.Point(189, 206);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 46);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Navy;
            this.btn6.Location = new System.Drawing.Point(130, 206);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 46);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Navy;
            this.btn5.Location = new System.Drawing.Point(71, 206);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 46);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Navy;
            this.btn4.Location = new System.Drawing.Point(12, 206);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 46);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btnInX
            // 
            this.btnInX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInX.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInX.ForeColor = System.Drawing.Color.Navy;
            this.btnInX.Location = new System.Drawing.Point(441, 258);
            this.btnInX.Name = "btnInX";
            this.btnInX.Size = new System.Drawing.Size(53, 46);
            this.btnInX.TabIndex = 33;
            this.btnInX.Text = "In x";
            this.btnInX.UseVisualStyleBackColor = false;
            this.btnInX.Click += new System.EventHandler(this.btnInX_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHex.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHex.ForeColor = System.Drawing.Color.Navy;
            this.btnHex.Location = new System.Drawing.Point(382, 258);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(53, 46);
            this.btnHex.TabIndex = 32;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.ForeColor = System.Drawing.Color.Navy;
            this.btnTan.Location = new System.Drawing.Point(323, 258);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(53, 46);
            this.btnTan.TabIndex = 31;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTanh.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanh.ForeColor = System.Drawing.Color.Navy;
            this.btnTanh.Location = new System.Drawing.Point(264, 258);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(53, 46);
            this.btnTanh.TabIndex = 30;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btn1X
            // 
            this.btn1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn1X.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1X.ForeColor = System.Drawing.Color.Navy;
            this.btn1X.Location = new System.Drawing.Point(441, 206);
            this.btn1X.Name = "btn1X";
            this.btn1X.Size = new System.Drawing.Size(53, 46);
            this.btn1X.TabIndex = 29;
            this.btn1X.Text = "1/x";
            this.btn1X.UseVisualStyleBackColor = false;
            this.btn1X.Click += new System.EventHandler(this.btn1X_Click);
            // 
            // btnBin
            // 
            this.btnBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBin.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBin.ForeColor = System.Drawing.Color.Navy;
            this.btnBin.Location = new System.Drawing.Point(382, 206);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(53, 46);
            this.btnBin.TabIndex = 28;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.Color.Navy;
            this.btnCos.Location = new System.Drawing.Point(323, 206);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(53, 46);
            this.btnCos.TabIndex = 27;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCosh.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosh.ForeColor = System.Drawing.Color.Navy;
            this.btnCosh.Location = new System.Drawing.Point(264, 206);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(53, 46);
            this.btnCosh.TabIndex = 26;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnX3
            // 
            this.btnX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnX3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX3.ForeColor = System.Drawing.Color.Navy;
            this.btnX3.Location = new System.Drawing.Point(441, 154);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(53, 46);
            this.btnX3.TabIndex = 25;
            this.btnX3.Text = "x^3";
            this.btnX3.UseVisualStyleBackColor = false;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDec.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.ForeColor = System.Drawing.Color.Navy;
            this.btnDec.Location = new System.Drawing.Point(382, 154);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(53, 46);
            this.btnDec.TabIndex = 24;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSin.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.Color.Navy;
            this.btnSin.Location = new System.Drawing.Point(323, 154);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(53, 46);
            this.btnSin.TabIndex = 23;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSinh.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinh.ForeColor = System.Drawing.Color.Navy;
            this.btnSinh.Location = new System.Drawing.Point(264, 154);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(53, 46);
            this.btnSinh.TabIndex = 22;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnX2
            // 
            this.btnX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnX2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.ForeColor = System.Drawing.Color.Navy;
            this.btnX2.Location = new System.Drawing.Point(441, 102);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(53, 46);
            this.btnX2.TabIndex = 21;
            this.btnX2.Text = "x^2";
            this.btnX2.UseVisualStyleBackColor = false;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSqrt.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.Navy;
            this.btnSqrt.Location = new System.Drawing.Point(382, 102);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(53, 46);
            this.btnSqrt.TabIndex = 20;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLog.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.Navy;
            this.btnLog.Location = new System.Drawing.Point(323, 102);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(53, 46);
            this.btnLog.TabIndex = 19;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPi.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.Navy;
            this.btnPi.Location = new System.Drawing.Point(264, 102);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(53, 46);
            this.btnPi.TabIndex = 18;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnPrecent
            // 
            this.btnPrecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrecent.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecent.ForeColor = System.Drawing.Color.Navy;
            this.btnPrecent.Location = new System.Drawing.Point(441, 310);
            this.btnPrecent.Name = "btnPrecent";
            this.btnPrecent.Size = new System.Drawing.Size(53, 46);
            this.btnPrecent.TabIndex = 41;
            this.btnPrecent.Text = "%";
            this.btnPrecent.UseVisualStyleBackColor = false;
            this.btnPrecent.Click += new System.EventHandler(this.btnPrecent_Click);
            // 
            // btnOct
            // 
            this.btnOct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOct.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOct.ForeColor = System.Drawing.Color.Navy;
            this.btnOct.Location = new System.Drawing.Point(382, 310);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(53, 46);
            this.btnOct.TabIndex = 40;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = false;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMod.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.Navy;
            this.btnMod.Location = new System.Drawing.Point(323, 310);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(53, 46);
            this.btnMod.TabIndex = 39;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExp.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.Color.Navy;
            this.btnExp.Location = new System.Drawing.Point(264, 310);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(53, 46);
            this.btnExp.TabIndex = 38;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDivision.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.Navy;
            this.btnDivision.Location = new System.Drawing.Point(189, 310);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(53, 46);
            this.btnDivision.TabIndex = 37;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.ArithmeticOperator);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEquals.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Navy;
            this.btnEquals.Location = new System.Drawing.Point(130, 310);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(53, 46);
            this.btnEquals.TabIndex = 36;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPoint.Font = new System.Drawing.Font("Franklin Gothic Medium", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.Navy;
            this.btnPoint.Location = new System.Drawing.Point(71, 310);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(53, 46);
            this.btnPoint.TabIndex = 35;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.buttons_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn0.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Navy;
            this.btn0.Location = new System.Drawing.Point(12, 310);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 46);
            this.btn0.TabIndex = 34;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.buttons_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label.Location = new System.Drawing.Point(12, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 21);
            this.label.TabIndex = 42;
            // 
            // boxTemperature
            // 
            this.boxTemperature.Controls.Add(this.boxSelect);
            this.boxTemperature.Controls.Add(this.txtResult);
            this.boxTemperature.Controls.Add(this.txtEnter);
            this.boxTemperature.Controls.Add(this.btnReset);
            this.boxTemperature.Controls.Add(this.btnCovert);
            this.boxTemperature.Controls.Add(this.labelResult);
            this.boxTemperature.Controls.Add(this.labelEnter);
            this.boxTemperature.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTemperature.ForeColor = System.Drawing.Color.Navy;
            this.boxTemperature.Location = new System.Drawing.Point(519, 45);
            this.boxTemperature.Name = "boxTemperature";
            this.boxTemperature.Size = new System.Drawing.Size(355, 311);
            this.boxTemperature.TabIndex = 43;
            this.boxTemperature.TabStop = false;
            this.boxTemperature.Text = "Temperature";
            // 
            // boxSelect
            // 
            this.boxSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.boxSelect.Controls.Add(this.kevin);
            this.boxSelect.Controls.Add(this.fahrenheitCelsius);
            this.boxSelect.Controls.Add(this.celsiusFahrenheit);
            this.boxSelect.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSelect.ForeColor = System.Drawing.Color.Navy;
            this.boxSelect.Location = new System.Drawing.Point(6, 80);
            this.boxSelect.Name = "boxSelect";
            this.boxSelect.Size = new System.Drawing.Size(343, 132);
            this.boxSelect.TabIndex = 10;
            this.boxSelect.TabStop = false;
            this.boxSelect.Text = "Select Temperature for Conversion";
            // 
            // kevin
            // 
            this.kevin.AutoSize = true;
            this.kevin.Location = new System.Drawing.Point(6, 94);
            this.kevin.Name = "kevin";
            this.kevin.Size = new System.Drawing.Size(62, 21);
            this.kevin.TabIndex = 5;
            this.kevin.TabStop = true;
            this.kevin.Text = "Kevin";
            this.kevin.UseVisualStyleBackColor = true;
            this.kevin.CheckedChanged += new System.EventHandler(this.kevin_CheckedChanged);
            // 
            // fahrenheitCelsius
            // 
            this.fahrenheitCelsius.AutoSize = true;
            this.fahrenheitCelsius.Location = new System.Drawing.Point(6, 67);
            this.fahrenheitCelsius.Name = "fahrenheitCelsius";
            this.fahrenheitCelsius.Size = new System.Drawing.Size(163, 21);
            this.fahrenheitCelsius.TabIndex = 4;
            this.fahrenheitCelsius.TabStop = true;
            this.fahrenheitCelsius.Text = "Fahrenheit to Celsius";
            this.fahrenheitCelsius.UseVisualStyleBackColor = true;
            this.fahrenheitCelsius.CheckedChanged += new System.EventHandler(this.fahrenheitCelsius_CheckedChanged);
            // 
            // celsiusFahrenheit
            // 
            this.celsiusFahrenheit.AutoSize = true;
            this.celsiusFahrenheit.Location = new System.Drawing.Point(6, 40);
            this.celsiusFahrenheit.Name = "celsiusFahrenheit";
            this.celsiusFahrenheit.Size = new System.Drawing.Size(163, 21);
            this.celsiusFahrenheit.TabIndex = 3;
            this.celsiusFahrenheit.TabStop = true;
            this.celsiusFahrenheit.Text = "Celsius to Fahrenheit";
            this.celsiusFahrenheit.UseVisualStyleBackColor = true;
            this.celsiusFahrenheit.CheckedChanged += new System.EventHandler(this.celsiusFahrenheit_CheckedChanged);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.ForeColor = System.Drawing.Color.Navy;
            this.txtResult.Location = new System.Drawing.Point(226, 218);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 19);
            this.txtResult.TabIndex = 9;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnter.ForeColor = System.Drawing.Color.Navy;
            this.txtEnter.Location = new System.Drawing.Point(226, 38);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(121, 19);
            this.txtEnter.TabIndex = 8;
            this.txtEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(247, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCovert
            // 
            this.btnCovert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCovert.Location = new System.Drawing.Point(6, 265);
            this.btnCovert.Name = "btnCovert";
            this.btnCovert.Size = new System.Drawing.Size(102, 40);
            this.btnCovert.TabIndex = 6;
            this.btnCovert.Text = "Convert";
            this.btnCovert.UseVisualStyleBackColor = false;
            this.btnCovert.Click += new System.EventHandler(this.btnCovert_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(1, 218);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(208, 21);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Result of Converted Value";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(6, 41);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(183, 21);
            this.labelEnter.TabIndex = 0;
            this.labelEnter.Text = "Enter Value to Convert";
            // 
            // boxMultiplication
            // 
            this.boxMultiplication.Controls.Add(this.btnResetMultiply);
            this.boxMultiplication.Controls.Add(this.btnMultiply);
            this.boxMultiplication.Controls.Add(this.txtMultiply);
            this.boxMultiplication.Controls.Add(this.listForMultiplication);
            this.boxMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxMultiplication.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMultiplication.ForeColor = System.Drawing.Color.Navy;
            this.boxMultiplication.Location = new System.Drawing.Point(6, 375);
            this.boxMultiplication.Name = "boxMultiplication";
            this.boxMultiplication.Size = new System.Drawing.Size(242, 362);
            this.boxMultiplication.TabIndex = 44;
            this.boxMultiplication.TabStop = false;
            this.boxMultiplication.Text = " Multiplication";
            // 
            // btnResetMultiply
            // 
            this.btnResetMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResetMultiply.Location = new System.Drawing.Point(147, 67);
            this.btnResetMultiply.Name = "btnResetMultiply";
            this.btnResetMultiply.Size = new System.Drawing.Size(89, 31);
            this.btnResetMultiply.TabIndex = 3;
            this.btnResetMultiply.Text = "Reset";
            this.btnResetMultiply.UseVisualStyleBackColor = false;
            this.btnResetMultiply.Click += new System.EventHandler(this.btnResetMultiply_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMultiply.Location = new System.Drawing.Point(6, 67);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(89, 31);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // txtMultiply
            // 
            this.txtMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMultiply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMultiply.Location = new System.Drawing.Point(62, 25);
            this.txtMultiply.Name = "txtMultiply";
            this.txtMultiply.Size = new System.Drawing.Size(119, 19);
            this.txtMultiply.TabIndex = 1;
            this.txtMultiply.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listForMultiplication
            // 
            this.listForMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listForMultiplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listForMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listForMultiplication.FormattingEnabled = true;
            this.listForMultiplication.ItemHeight = 21;
            this.listForMultiplication.Location = new System.Drawing.Point(6, 104);
            this.listForMultiplication.Name = "listForMultiplication";
            this.listForMultiplication.Size = new System.Drawing.Size(230, 252);
            this.listForMultiplication.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(883, 749);
            this.Controls.Add(this.boxMultiplication);
            this.Controls.Add(this.boxTemperature);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnPrecent);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnInX);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btn1X);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnReturn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.menuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.boxTemperature.ResumeLayout(false);
            this.boxTemperature.PerformLayout();
            this.boxSelect.ResumeLayout(false);
            this.boxSelect.PerformLayout();
            this.boxMultiplication.ResumeLayout(false);
            this.boxMultiplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem standardMenu;
        private System.Windows.Forms.ToolStripMenuItem scientificMenu;
        private System.Windows.Forms.ToolStripMenuItem temperatureMenu;
        private System.Windows.Forms.ToolStripMenuItem multiplicationMenu;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturn0;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnInX;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btn1X;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnPrecent;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox boxTemperature;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCovert;
        private System.Windows.Forms.RadioButton kevin;
        private System.Windows.Forms.RadioButton fahrenheitCelsius;
        private System.Windows.Forms.RadioButton celsiusFahrenheit;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.GroupBox boxSelect;
        private System.Windows.Forms.GroupBox boxMultiplication;
        private System.Windows.Forms.ListBox listForMultiplication;
        private System.Windows.Forms.Button btnResetMultiply;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TextBox txtMultiply;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

