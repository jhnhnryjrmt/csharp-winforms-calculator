namespace calculator;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        numberTextBox = new TextBox();
        textAndButtonsTableLayoutPanel = new TableLayoutPanel();
        flowLayoutPanel1 = new FlowLayoutPanel();
        divisionBtn = new Button();
        multiplyBtn = new Button();
        subtractBtn = new Button();
        clearBtn = new Button();
        sevenBtn = new Button();
        eightBtn = new Button();
        nineBtn = new Button();
        clearAllBtn = new Button();
        fourBtn = new Button();
        fiveBtn = new Button();
        sixBtn = new Button();
        addBtn = new Button();
        oneBtn = new Button();
        twoBtn = new Button();
        threeBtn = new Button();
        equalsBtn = new Button();
        zeroBtn = new Button();
        decimalBtn = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        label1 = new Label();
        textAndButtonsTableLayoutPanel.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // numberTextBox
        // 
        numberTextBox.BackColor = SystemColors.ButtonHighlight;
        numberTextBox.Dock = DockStyle.Fill;
        numberTextBox.Enabled = false;
        numberTextBox.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
        numberTextBox.ForeColor = Color.Black;
        numberTextBox.Location = new Point(3, 58);
        numberTextBox.Name = "numberTextBox";
        numberTextBox.ReadOnly = true;
        numberTextBox.RightToLeft = RightToLeft.No;
        numberTextBox.Size = new Size(327, 93);
        numberTextBox.TabIndex = 0;
        numberTextBox.Text = "0";
        numberTextBox.TextAlign = HorizontalAlignment.Right;
        // 
        // textAndButtonsTableLayoutPanel
        // 
        textAndButtonsTableLayoutPanel.ColumnCount = 1;
        textAndButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        textAndButtonsTableLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 1);
        textAndButtonsTableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
        textAndButtonsTableLayoutPanel.Dock = DockStyle.Fill;
        textAndButtonsTableLayoutPanel.Location = new Point(0, 0);
        textAndButtonsTableLayoutPanel.Name = "textAndButtonsTableLayoutPanel";
        textAndButtonsTableLayoutPanel.RowCount = 2;
        textAndButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.4719353F));
        textAndButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 66.52807F));
        textAndButtonsTableLayoutPanel.Size = new Size(339, 481);
        textAndButtonsTableLayoutPanel.TabIndex = 1;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(divisionBtn);
        flowLayoutPanel1.Controls.Add(multiplyBtn);
        flowLayoutPanel1.Controls.Add(subtractBtn);
        flowLayoutPanel1.Controls.Add(clearBtn);
        flowLayoutPanel1.Controls.Add(sevenBtn);
        flowLayoutPanel1.Controls.Add(eightBtn);
        flowLayoutPanel1.Controls.Add(nineBtn);
        flowLayoutPanel1.Controls.Add(clearAllBtn);
        flowLayoutPanel1.Controls.Add(fourBtn);
        flowLayoutPanel1.Controls.Add(fiveBtn);
        flowLayoutPanel1.Controls.Add(sixBtn);
        flowLayoutPanel1.Controls.Add(addBtn);
        flowLayoutPanel1.Controls.Add(oneBtn);
        flowLayoutPanel1.Controls.Add(twoBtn);
        flowLayoutPanel1.Controls.Add(threeBtn);
        flowLayoutPanel1.Controls.Add(equalsBtn);
        flowLayoutPanel1.Controls.Add(zeroBtn);
        flowLayoutPanel1.Controls.Add(decimalBtn);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.Location = new Point(3, 164);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(333, 314);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // divisionBtn
        // 
        divisionBtn.Location = new Point(3, 3);
        divisionBtn.Name = "divisionBtn";
        divisionBtn.Size = new Size(75, 54);
        divisionBtn.TabIndex = 0;
        divisionBtn.Text = "/";
        divisionBtn.UseVisualStyleBackColor = true;
        // 
        // multiplyBtn
        // 
        multiplyBtn.Location = new Point(84, 3);
        multiplyBtn.Name = "multiplyBtn";
        multiplyBtn.Size = new Size(75, 54);
        multiplyBtn.TabIndex = 1;
        multiplyBtn.Text = "*";
        multiplyBtn.UseVisualStyleBackColor = true;
        // 
        // subtractBtn
        // 
        subtractBtn.Location = new Point(165, 3);
        subtractBtn.Name = "subtractBtn";
        subtractBtn.Size = new Size(75, 54);
        subtractBtn.TabIndex = 2;
        subtractBtn.Text = "-";
        subtractBtn.UseVisualStyleBackColor = true;
        // 
        // clearBtn
        // 
        clearBtn.Location = new Point(246, 3);
        clearBtn.Name = "clearBtn";
        clearBtn.Size = new Size(75, 54);
        clearBtn.TabIndex = 3;
        clearBtn.Text = "C";
        clearBtn.UseVisualStyleBackColor = true;
        clearBtn.Click += clearBtn_Click;
        // 
        // sevenBtn
        // 
        sevenBtn.Location = new Point(3, 63);
        sevenBtn.Name = "sevenBtn";
        sevenBtn.Size = new Size(75, 54);
        sevenBtn.TabIndex = 4;
        sevenBtn.Text = "7";
        sevenBtn.UseVisualStyleBackColor = true;
        sevenBtn.Click += sevenBtn_Click;
        // 
        // eightBtn
        // 
        eightBtn.Location = new Point(84, 63);
        eightBtn.Name = "eightBtn";
        eightBtn.Size = new Size(75, 54);
        eightBtn.TabIndex = 5;
        eightBtn.Text = "8";
        eightBtn.UseVisualStyleBackColor = true;
        eightBtn.Click += eightBtn_Click;
        // 
        // nineBtn
        // 
        nineBtn.Location = new Point(165, 63);
        nineBtn.Name = "nineBtn";
        nineBtn.Size = new Size(75, 54);
        nineBtn.TabIndex = 6;
        nineBtn.Text = "9";
        nineBtn.UseVisualStyleBackColor = true;
        nineBtn.Click += nineBtn_Click;
        // 
        // clearAllBtn
        // 
        clearAllBtn.Location = new Point(246, 63);
        clearAllBtn.Name = "clearAllBtn";
        clearAllBtn.Size = new Size(75, 54);
        clearAllBtn.TabIndex = 7;
        clearAllBtn.Text = "CE";
        clearAllBtn.UseVisualStyleBackColor = true;
        // 
        // fourBtn
        // 
        fourBtn.Location = new Point(3, 123);
        fourBtn.Name = "fourBtn";
        fourBtn.Size = new Size(75, 54);
        fourBtn.TabIndex = 8;
        fourBtn.Text = "4";
        fourBtn.UseVisualStyleBackColor = true;
        fourBtn.Click += fourBtn_Click;
        // 
        // fiveBtn
        // 
        fiveBtn.Location = new Point(84, 123);
        fiveBtn.Name = "fiveBtn";
        fiveBtn.Size = new Size(75, 54);
        fiveBtn.TabIndex = 9;
        fiveBtn.Text = "5";
        fiveBtn.UseVisualStyleBackColor = true;
        fiveBtn.Click += fiveBtn_Click;
        // 
        // sixBtn
        // 
        sixBtn.Location = new Point(165, 123);
        sixBtn.Name = "sixBtn";
        sixBtn.Size = new Size(75, 54);
        sixBtn.TabIndex = 10;
        sixBtn.Text = "6";
        sixBtn.UseVisualStyleBackColor = true;
        sixBtn.Click += sixBtn_Click;
        // 
        // addBtn
        // 
        addBtn.Location = new Point(246, 123);
        addBtn.Name = "addBtn";
        addBtn.Size = new Size(75, 54);
        addBtn.TabIndex = 11;
        addBtn.Text = "+";
        addBtn.UseVisualStyleBackColor = true;
        // 
        // oneBtn
        // 
        oneBtn.Location = new Point(3, 183);
        oneBtn.Name = "oneBtn";
        oneBtn.Size = new Size(75, 54);
        oneBtn.TabIndex = 12;
        oneBtn.Text = "1";
        oneBtn.UseVisualStyleBackColor = true;
        oneBtn.Click += oneBtn_Click;
        // 
        // twoBtn
        // 
        twoBtn.Location = new Point(84, 183);
        twoBtn.Name = "twoBtn";
        twoBtn.Size = new Size(75, 54);
        twoBtn.TabIndex = 13;
        twoBtn.Text = "2";
        twoBtn.UseVisualStyleBackColor = true;
        twoBtn.Click += twoBtn_Click;
        // 
        // threeBtn
        // 
        threeBtn.Location = new Point(165, 183);
        threeBtn.Name = "threeBtn";
        threeBtn.Size = new Size(75, 54);
        threeBtn.TabIndex = 14;
        threeBtn.Text = "3";
        threeBtn.UseVisualStyleBackColor = true;
        threeBtn.Click += threeBtn_Click;
        // 
        // equalsBtn
        // 
        equalsBtn.Location = new Point(246, 183);
        equalsBtn.Name = "equalsBtn";
        equalsBtn.Size = new Size(75, 54);
        equalsBtn.TabIndex = 15;
        equalsBtn.Text = "=";
        equalsBtn.UseVisualStyleBackColor = true;
        // 
        // zeroBtn
        // 
        zeroBtn.Location = new Point(3, 243);
        zeroBtn.Name = "zeroBtn";
        zeroBtn.Size = new Size(237, 59);
        zeroBtn.TabIndex = 16;
        zeroBtn.Text = "0";
        zeroBtn.UseVisualStyleBackColor = true;
        zeroBtn.Click += zeroBtn_Click;
        // 
        // decimalBtn
        // 
        decimalBtn.Location = new Point(246, 243);
        decimalBtn.Name = "decimalBtn";
        decimalBtn.Size = new Size(75, 59);
        decimalBtn.TabIndex = 17;
        decimalBtn.Text = ".";
        decimalBtn.UseVisualStyleBackColor = true;
        decimalBtn.Click += decimalBtn_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AllowDrop = true;
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(numberTextBox, 0, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.48387F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.51613F));
        tableLayoutPanel1.Size = new Size(333, 155);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // label1
        // 
        label1.AllowDrop = true;
        label1.Dock = DockStyle.Fill;
        label1.Location = new Point(3, 0);
        label1.Name = "label1";
        label1.Size = new Size(327, 55);
        label1.TabIndex = 1;
        label1.Text = "label1";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(339, 481);
        Controls.Add(textAndButtonsTableLayoutPanel);
        Name = "Form1";
        Text = "Calculator";
        textAndButtonsTableLayoutPanel.ResumeLayout(false);
        textAndButtonsTableLayoutPanel.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TextBox numberTextBox;
    private TableLayoutPanel textAndButtonsTableLayoutPanel;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button divisionBtn;
    private Button multiplyBtn;
    private Button subtractBtn;
    private Button clearBtn;
    private Button sevenBtn;
    private Button eightBtn;
    private Button nineBtn;
    private Button clearAllBtn;
    private Button fourBtn;
    private Button fiveBtn;
    private Button sixBtn;
    private Button addBtn;
    private Button oneBtn;
    private Button twoBtn;
    private Button threeBtn;
    private Button equalsBtn;
    private Button zeroBtn;
    private Button decimalBtn;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
}
