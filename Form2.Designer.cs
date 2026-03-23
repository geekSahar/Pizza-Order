namespace Pizza_Order
{
    partial class Form2
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
            this.grSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lbFill = new System.Windows.Forms.Label();
            this.grToppings = new System.Windows.Forms.GroupBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chExtra = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.grCrust = new System.Windows.Forms.GroupBox();
            this.rbThik = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.grWhere = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btOrder = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.grSummary = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCrust = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grSize.SuspendLayout();
            this.grToppings.SuspendLayout();
            this.grCrust.SuspendLayout();
            this.grWhere.SuspendLayout();
            this.grSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grSize
            // 
            this.grSize.Controls.Add(this.rbLarge);
            this.grSize.Controls.Add(this.rbMedium);
            this.grSize.Controls.Add(this.rbSmall);
            this.grSize.Location = new System.Drawing.Point(12, 101);
            this.grSize.Name = "grSize";
            this.grSize.Size = new System.Drawing.Size(200, 100);
            this.grSize.TabIndex = 0;
            this.grSize.TabStop = false;
            this.grSize.Text = "Size";
            this.grSize.Enter += new System.EventHandler(this.grSize_Enter_1);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(70, 66);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(70, 43);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(70, 20);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // lbFill
            // 
            this.lbFill.AutoSize = true;
            this.lbFill.Font = new System.Drawing.Font("French Script MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFill.ForeColor = System.Drawing.Color.Green;
            this.lbFill.Location = new System.Drawing.Point(276, 9);
            this.lbFill.Name = "lbFill";
            this.lbFill.Size = new System.Drawing.Size(234, 42);
            this.lbFill.TabIndex = 1;
            this.lbFill.Text = "Fill In The Form";
            // 
            // grToppings
            // 
            this.grToppings.BackColor = System.Drawing.SystemColors.Control;
            this.grToppings.Controls.Add(this.chTomatoes);
            this.grToppings.Controls.Add(this.chExtra);
            this.grToppings.Controls.Add(this.chOlives);
            this.grToppings.Controls.Add(this.chOnion);
            this.grToppings.Location = new System.Drawing.Point(310, 101);
            this.grToppings.Name = "grToppings";
            this.grToppings.Size = new System.Drawing.Size(200, 100);
            this.grToppings.TabIndex = 2;
            this.grToppings.TabStop = false;
            this.grToppings.Text = "Toppings";
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Location = new System.Drawing.Point(16, 67);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chTomatoes.TabIndex = 6;
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chExtra
            // 
            this.chExtra.AutoSize = true;
            this.chExtra.Location = new System.Drawing.Point(16, 21);
            this.chExtra.Name = "chExtra";
            this.chExtra.Size = new System.Drawing.Size(83, 17);
            this.chExtra.TabIndex = 3;
            this.chExtra.Text = "Extra Chees";
            this.chExtra.UseVisualStyleBackColor = true;
            this.chExtra.CheckedChanged += new System.EventHandler(this.chExtra_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Location = new System.Drawing.Point(125, 20);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(55, 17);
            this.chOlives.TabIndex = 4;
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Location = new System.Drawing.Point(126, 67);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(54, 17);
            this.chOnion.TabIndex = 5;
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // grCrust
            // 
            this.grCrust.Controls.Add(this.rbThik);
            this.grCrust.Controls.Add(this.rbThin);
            this.grCrust.Location = new System.Drawing.Point(114, 275);
            this.grCrust.Name = "grCrust";
            this.grCrust.Size = new System.Drawing.Size(200, 100);
            this.grCrust.TabIndex = 3;
            this.grCrust.TabStop = false;
            this.grCrust.Text = "Crust Type";
            // 
            // rbThik
            // 
            this.rbThik.AutoSize = true;
            this.rbThik.Location = new System.Drawing.Point(13, 52);
            this.rbThik.Name = "rbThik";
            this.rbThik.Size = new System.Drawing.Size(46, 17);
            this.rbThik.TabIndex = 1;
            this.rbThik.TabStop = true;
            this.rbThik.Text = "Thik";
            this.rbThik.UseVisualStyleBackColor = true;
            this.rbThik.CheckedChanged += new System.EventHandler(this.rbThik_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(13, 29);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(46, 17);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // grWhere
            // 
            this.grWhere.Controls.Add(this.rbTakeOut);
            this.grWhere.Controls.Add(this.rbEatIn);
            this.grWhere.Location = new System.Drawing.Point(450, 275);
            this.grWhere.Name = "grWhere";
            this.grWhere.Size = new System.Drawing.Size(234, 100);
            this.grWhere.TabIndex = 4;
            this.grWhere.TabStop = false;
            this.grWhere.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(120, 29);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(70, 17);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(6, 29);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(53, 17);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.DarkGreen;
            this.btOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.Location = new System.Drawing.Point(242, 394);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(157, 40);
            this.btOrder.TabIndex = 5;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.Maroon;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(436, 394);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(158, 40);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // grSummary
            // 
            this.grSummary.Controls.Add(this.label8);
            this.grSummary.Controls.Add(this.label4);
            this.grSummary.Controls.Add(this.label2);
            this.grSummary.Controls.Add(this.label7);
            this.grSummary.Controls.Add(this.label6);
            this.grSummary.Controls.Add(this.label5);
            this.grSummary.Controls.Add(this.lbCrust);
            this.grSummary.Controls.Add(this.label3);
            this.grSummary.Controls.Add(this.lbToppings);
            this.grSummary.Controls.Add(this.label1);
            this.grSummary.Controls.Add(this.lbSize);
            this.grSummary.Location = new System.Drawing.Point(587, 54);
            this.grSummary.Name = "grSummary";
            this.grSummary.Size = new System.Drawing.Size(200, 223);
            this.grSummary.TabIndex = 7;
            this.grSummary.TabStop = false;
            this.grSummary.Text = "Summary";
            this.grSummary.Enter += new System.EventHandler(this.grSummary_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Where To Eat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust.Location = new System.Drawing.Point(26, 105);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(82, 16);
            this.lbCrust.TabIndex = 4;
            this.lbCrust.Text = "Crust Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(27, 49);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(73, 16);
            this.lbToppings.TabIndex = 2;
            this.lbToppings.Text = "Toppings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(27, 20);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(41, 16);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Order.Properties.Resources.istockphoto_1391293808_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(799, 446);
            this.Controls.Add(this.grSummary);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.grWhere);
            this.Controls.Add(this.grCrust);
            this.Controls.Add(this.grToppings);
            this.Controls.Add(this.lbFill);
            this.Controls.Add(this.grSize);
            this.MaximumSize = new System.Drawing.Size(815, 485);
            this.MinimumSize = new System.Drawing.Size(815, 485);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grSize.ResumeLayout(false);
            this.grSize.PerformLayout();
            this.grToppings.ResumeLayout(false);
            this.grToppings.PerformLayout();
            this.grCrust.ResumeLayout(false);
            this.grCrust.PerformLayout();
            this.grWhere.ResumeLayout(false);
            this.grWhere.PerformLayout();
            this.grSummary.ResumeLayout(false);
            this.grSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.Label lbFill;
        private System.Windows.Forms.GroupBox grToppings;
        private System.Windows.Forms.CheckBox chExtra;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.GroupBox grCrust;
        private System.Windows.Forms.RadioButton rbThik;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox grWhere;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox grSummary;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCrust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}