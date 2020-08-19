namespace CM_Mill_Calculator
{
    partial class CMMillCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMMillCalculator));
            this.rbInches = new System.Windows.Forms.RadioButton();
            this.rbMM = new System.Windows.Forms.RadioButton();
            this.gbUnits = new System.Windows.Forms.GroupBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.gbDirection = new System.Windows.Forms.GroupBox();
            this.rbAngle = new System.Windows.Forms.RadioButton();
            this.lbl90 = new System.Windows.Forms.Label();
            this.lbl270 = new System.Windows.Forms.Label();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.lbl180 = new System.Windows.Forms.Label();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbFront = new System.Windows.Forms.RadioButton();
            this.lbl0 = new System.Windows.Forms.Label();
            this.rbBack = new System.Windows.Forms.RadioButton();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDstTurn = new System.Windows.Forms.TextBox();
            this.lblDSTTurn = new System.Windows.Forms.Label();
            this.lblLeftWheel = new System.Windows.Forms.Label();
            this.lblRightWheel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYFD = new System.Windows.Forms.Label();
            this.lblXRD = new System.Windows.Forms.Label();
            this.lblXLD = new System.Windows.Forms.Label();
            this.txtYFW = new System.Windows.Forms.TextBox();
            this.txtXRW = new System.Windows.Forms.TextBox();
            this.txtXLW = new System.Windows.Forms.TextBox();
            this.gbWheelToDistance = new System.Windows.Forms.GroupBox();
            this.lblWDistance = new System.Windows.Forms.Label();
            this.txtWDistance = new System.Windows.Forms.TextBox();
            this.btnWCalculate = new System.Windows.Forms.Button();
            this.lblThousandths = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.txtWThousandths = new System.Windows.Forms.TextBox();
            this.txtWTurns = new System.Windows.Forms.TextBox();
            this.gbUnits.SuspendLayout();
            this.gbDirection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbWheelToDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbInches
            // 
            this.rbInches.AutoSize = true;
            this.rbInches.Location = new System.Drawing.Point(6, 21);
            this.rbInches.Name = "rbInches";
            this.rbInches.Size = new System.Drawing.Size(70, 21);
            this.rbInches.TabIndex = 0;
            this.rbInches.TabStop = true;
            this.rbInches.Text = "Inches";
            this.rbInches.UseVisualStyleBackColor = true;
            // 
            // rbMM
            // 
            this.rbMM.AutoSize = true;
            this.rbMM.Location = new System.Drawing.Point(99, 21);
            this.rbMM.Name = "rbMM";
            this.rbMM.Size = new System.Drawing.Size(95, 21);
            this.rbMM.TabIndex = 1;
            this.rbMM.TabStop = true;
            this.rbMM.Text = "Millimeters";
            this.rbMM.UseVisualStyleBackColor = true;
            // 
            // gbUnits
            // 
            this.gbUnits.Controls.Add(this.rbInches);
            this.gbUnits.Controls.Add(this.rbMM);
            this.gbUnits.Location = new System.Drawing.Point(32, 12);
            this.gbUnits.Name = "gbUnits";
            this.gbUnits.Size = new System.Drawing.Size(200, 64);
            this.gbUnits.TabIndex = 2;
            this.gbUnits.TabStop = false;
            this.gbUnits.Text = "Units";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(98, 90);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 22);
            this.txtDistance.TabIndex = 3;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(29, 93);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(63, 17);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Distance";
            // 
            // gbDirection
            // 
            this.gbDirection.Controls.Add(this.rbAngle);
            this.gbDirection.Controls.Add(this.lbl90);
            this.gbDirection.Controls.Add(this.lbl270);
            this.gbDirection.Controls.Add(this.rbRight);
            this.gbDirection.Controls.Add(this.lbl180);
            this.gbDirection.Controls.Add(this.rbLeft);
            this.gbDirection.Controls.Add(this.rbFront);
            this.gbDirection.Controls.Add(this.lbl0);
            this.gbDirection.Controls.Add(this.rbBack);
            this.gbDirection.Location = new System.Drawing.Point(50, 132);
            this.gbDirection.Name = "gbDirection";
            this.gbDirection.Size = new System.Drawing.Size(333, 218);
            this.gbDirection.TabIndex = 5;
            this.gbDirection.TabStop = false;
            this.gbDirection.Text = "Towards Direction";
            // 
            // rbAngle
            // 
            this.rbAngle.AutoSize = true;
            this.rbAngle.Checked = true;
            this.rbAngle.Location = new System.Drawing.Point(142, 107);
            this.rbAngle.Name = "rbAngle";
            this.rbAngle.Size = new System.Drawing.Size(65, 21);
            this.rbAngle.TabIndex = 10;
            this.rbAngle.TabStop = true;
            this.rbAngle.Text = "Angle";
            this.rbAngle.UseVisualStyleBackColor = true;
            this.rbAngle.CheckedChanged += new System.EventHandler(this.rbAngle_CheckedChanged);
            // 
            // lbl90
            // 
            this.lbl90.AutoSize = true;
            this.lbl90.Location = new System.Drawing.Point(302, 107);
            this.lbl90.Name = "lbl90";
            this.lbl90.Size = new System.Drawing.Size(24, 17);
            this.lbl90.TabIndex = 7;
            this.lbl90.Text = "90";
            // 
            // lbl270
            // 
            this.lbl270.AutoSize = true;
            this.lbl270.Location = new System.Drawing.Point(4, 107);
            this.lbl270.Name = "lbl270";
            this.lbl270.Size = new System.Drawing.Size(32, 17);
            this.lbl270.TabIndex = 9;
            this.lbl270.Text = "270";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(234, 105);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(62, 21);
            this.rbRight.TabIndex = 6;
            this.rbRight.Text = "Right";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.rbRight_CheckedChanged);
            // 
            // lbl180
            // 
            this.lbl180.AutoSize = true;
            this.lbl180.Location = new System.Drawing.Point(139, 180);
            this.lbl180.Name = "lbl180";
            this.lbl180.Size = new System.Drawing.Size(32, 17);
            this.lbl180.TabIndex = 8;
            this.lbl180.Text = "180";
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(42, 105);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(53, 21);
            this.rbLeft.TabIndex = 6;
            this.rbLeft.Text = "Left";
            this.rbLeft.UseVisualStyleBackColor = true;
            this.rbLeft.CheckedChanged += new System.EventHandler(this.rbLeft_CheckedChanged);
            // 
            // rbFront
            // 
            this.rbFront.AutoSize = true;
            this.rbFront.Location = new System.Drawing.Point(142, 150);
            this.rbFront.Name = "rbFront";
            this.rbFront.Size = new System.Drawing.Size(62, 21);
            this.rbFront.TabIndex = 6;
            this.rbFront.Text = "Front";
            this.rbFront.UseVisualStyleBackColor = true;
            this.rbFront.CheckedChanged += new System.EventHandler(this.rbFront_CheckedChanged);
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(139, 35);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(16, 17);
            this.lbl0.TabIndex = 6;
            this.lbl0.Text = "0";
            // 
            // rbBack
            // 
            this.rbBack.AutoSize = true;
            this.rbBack.Location = new System.Drawing.Point(142, 64);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(60, 21);
            this.rbBack.TabIndex = 6;
            this.rbBack.Text = "Back";
            this.rbBack.UseVisualStyleBackColor = true;
            this.rbBack.CheckedChanged += new System.EventHandler(this.rbBack_CheckedChanged);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(275, 90);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(88, 22);
            this.txtAngle.TabIndex = 6;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(221, 93);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(44, 17);
            this.lblAngle.TabIndex = 7;
            this.lblAngle.Text = "Angle";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(131, 356);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDstTurn
            // 
            this.txtDstTurn.Location = new System.Drawing.Point(350, 19);
            this.txtDstTurn.Name = "txtDstTurn";
            this.txtDstTurn.Size = new System.Drawing.Size(51, 22);
            this.txtDstTurn.TabIndex = 11;
            this.txtDstTurn.Text = "0.166667";
            // 
            // lblDSTTurn
            // 
            this.lblDSTTurn.AutoSize = true;
            this.lblDSTTurn.Location = new System.Drawing.Point(249, 22);
            this.lblDSTTurn.Name = "lblDSTTurn";
            this.lblDSTTurn.Size = new System.Drawing.Size(95, 17);
            this.lblDSTTurn.TabIndex = 12;
            this.lblDSTTurn.Text = "DST per Turn";
            // 
            // lblLeftWheel
            // 
            this.lblLeftWheel.AutoSize = true;
            this.lblLeftWheel.Location = new System.Drawing.Point(18, 36);
            this.lblLeftWheel.Name = "lblLeftWheel";
            this.lblLeftWheel.Size = new System.Drawing.Size(98, 17);
            this.lblLeftWheel.TabIndex = 13;
            this.lblLeftWheel.Text = "X - Left Wheel";
            // 
            // lblRightWheel
            // 
            this.lblRightWheel.AutoSize = true;
            this.lblRightWheel.Location = new System.Drawing.Point(277, 36);
            this.lblRightWheel.Name = "lblRightWheel";
            this.lblRightWheel.Size = new System.Drawing.Size(107, 17);
            this.lblRightWheel.TabIndex = 14;
            this.lblRightWheel.Text = "X - Right Wheel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Y - Front Wheel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblYFD);
            this.groupBox1.Controls.Add(this.lblXRD);
            this.groupBox1.Controls.Add(this.lblXLD);
            this.groupBox1.Controls.Add(this.txtYFW);
            this.groupBox1.Controls.Add(this.txtXRW);
            this.groupBox1.Controls.Add(this.txtXLW);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRightWheel);
            this.groupBox1.Controls.Add(this.lblLeftWheel);
            this.groupBox1.Location = new System.Drawing.Point(419, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 200);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wheel Movement";
            // 
            // lblYFD
            // 
            this.lblYFD.AutoSize = true;
            this.lblYFD.Location = new System.Drawing.Point(175, 161);
            this.lblYFD.Name = "lblYFD";
            this.lblYFD.Size = new System.Drawing.Size(30, 17);
            this.lblYFD.TabIndex = 21;
            this.lblYFD.Text = "CW";
            // 
            // lblXRD
            // 
            this.lblXRD.AutoSize = true;
            this.lblXRD.Location = new System.Drawing.Point(312, 80);
            this.lblXRD.Name = "lblXRD";
            this.lblXRD.Size = new System.Drawing.Size(30, 17);
            this.lblXRD.TabIndex = 20;
            this.lblXRD.Text = "CW";
            // 
            // lblXLD
            // 
            this.lblXLD.AutoSize = true;
            this.lblXLD.Location = new System.Drawing.Point(45, 80);
            this.lblXLD.Name = "lblXLD";
            this.lblXLD.Size = new System.Drawing.Size(39, 17);
            this.lblXLD.TabIndex = 19;
            this.lblXLD.Text = "CCW";
            // 
            // txtYFW
            // 
            this.txtYFW.Location = new System.Drawing.Point(143, 136);
            this.txtYFW.Name = "txtYFW";
            this.txtYFW.Size = new System.Drawing.Size(100, 22);
            this.txtYFW.TabIndex = 18;
            // 
            // txtXRW
            // 
            this.txtXRW.Location = new System.Drawing.Point(280, 55);
            this.txtXRW.Name = "txtXRW";
            this.txtXRW.Size = new System.Drawing.Size(100, 22);
            this.txtXRW.TabIndex = 17;
            // 
            // txtXLW
            // 
            this.txtXLW.Location = new System.Drawing.Point(16, 55);
            this.txtXLW.Name = "txtXLW";
            this.txtXLW.Size = new System.Drawing.Size(100, 22);
            this.txtXLW.TabIndex = 16;
            // 
            // gbWheelToDistance
            // 
            this.gbWheelToDistance.Controls.Add(this.lblWDistance);
            this.gbWheelToDistance.Controls.Add(this.txtWDistance);
            this.gbWheelToDistance.Controls.Add(this.btnWCalculate);
            this.gbWheelToDistance.Controls.Add(this.lblThousandths);
            this.gbWheelToDistance.Controls.Add(this.lblTurns);
            this.gbWheelToDistance.Controls.Add(this.txtWThousandths);
            this.gbWheelToDistance.Controls.Add(this.txtWTurns);
            this.gbWheelToDistance.Location = new System.Drawing.Point(462, 19);
            this.gbWheelToDistance.Name = "gbWheelToDistance";
            this.gbWheelToDistance.Size = new System.Drawing.Size(359, 114);
            this.gbWheelToDistance.TabIndex = 19;
            this.gbWheelToDistance.TabStop = false;
            this.gbWheelToDistance.Text = "Wheel to Distance";
            // 
            // lblWDistance
            // 
            this.lblWDistance.AutoSize = true;
            this.lblWDistance.Location = new System.Drawing.Point(168, 34);
            this.lblWDistance.Name = "lblWDistance";
            this.lblWDistance.Size = new System.Drawing.Size(63, 17);
            this.lblWDistance.TabIndex = 6;
            this.lblWDistance.Text = "Distance";
            // 
            // txtWDistance
            // 
            this.txtWDistance.Location = new System.Drawing.Point(237, 31);
            this.txtWDistance.Name = "txtWDistance";
            this.txtWDistance.Size = new System.Drawing.Size(100, 22);
            this.txtWDistance.TabIndex = 5;
            // 
            // btnWCalculate
            // 
            this.btnWCalculate.Location = new System.Drawing.Point(237, 66);
            this.btnWCalculate.Name = "btnWCalculate";
            this.btnWCalculate.Size = new System.Drawing.Size(91, 32);
            this.btnWCalculate.TabIndex = 4;
            this.btnWCalculate.Text = "Calculate";
            this.btnWCalculate.UseVisualStyleBackColor = true;
            this.btnWCalculate.Click += new System.EventHandler(this.btnWCalculate_Click);
            // 
            // lblThousandths
            // 
            this.lblThousandths.AutoSize = true;
            this.lblThousandths.Location = new System.Drawing.Point(3, 64);
            this.lblThousandths.Name = "lblThousandths";
            this.lblThousandths.Size = new System.Drawing.Size(91, 17);
            this.lblThousandths.TabIndex = 3;
            this.lblThousandths.Text = "Thousandths";
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Location = new System.Drawing.Point(49, 36);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(45, 17);
            this.lblTurns.TabIndex = 2;
            this.lblTurns.Text = "Turns";
            // 
            // txtWThousandths
            // 
            this.txtWThousandths.Location = new System.Drawing.Point(100, 61);
            this.txtWThousandths.Name = "txtWThousandths";
            this.txtWThousandths.Size = new System.Drawing.Size(62, 22);
            this.txtWThousandths.TabIndex = 1;
            // 
            // txtWTurns
            // 
            this.txtWTurns.Location = new System.Drawing.Point(100, 33);
            this.txtWTurns.Name = "txtWTurns";
            this.txtWTurns.Size = new System.Drawing.Size(62, 22);
            this.txtWTurns.TabIndex = 0;
            // 
            // CMMillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 423);
            this.Controls.Add(this.gbWheelToDistance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDSTTurn);
            this.Controls.Add(this.txtDstTurn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.gbDirection);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.gbUnits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CMMillCalculator";
            this.Text = "Central Machine Mill Calculator v1.05";
            this.gbUnits.ResumeLayout(false);
            this.gbUnits.PerformLayout();
            this.gbDirection.ResumeLayout(false);
            this.gbDirection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbWheelToDistance.ResumeLayout(false);
            this.gbWheelToDistance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInches;
        private System.Windows.Forms.RadioButton rbMM;
        private System.Windows.Forms.GroupBox gbUnits;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.GroupBox gbDirection;
        private System.Windows.Forms.Label lbl90;
        private System.Windows.Forms.Label lbl270;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.Label lbl180;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.RadioButton rbFront;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.RadioButton rbBack;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDstTurn;
        private System.Windows.Forms.Label lblDSTTurn;
        private System.Windows.Forms.Label lblLeftWheel;
        private System.Windows.Forms.Label lblRightWheel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtXRW;
        private System.Windows.Forms.TextBox txtXLW;
        private System.Windows.Forms.TextBox txtYFW;
        private System.Windows.Forms.RadioButton rbAngle;
        private System.Windows.Forms.Label lblYFD;
        private System.Windows.Forms.Label lblXRD;
        private System.Windows.Forms.Label lblXLD;
        private System.Windows.Forms.GroupBox gbWheelToDistance;
        private System.Windows.Forms.Label lblWDistance;
        private System.Windows.Forms.TextBox txtWDistance;
        private System.Windows.Forms.Button btnWCalculate;
        private System.Windows.Forms.Label lblThousandths;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.TextBox txtWThousandths;
        private System.Windows.Forms.TextBox txtWTurns;
    }
}

