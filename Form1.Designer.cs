namespace BackPropagation
{
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
            createBPNN = new Button();
            trainNeuralNet = new Button();
            btnTest = new Button();
            tbA = new TextBox();
            tbB = new TextBox();
            tbOutput = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnAndTest = new Button();
            label5 = new Label();
            tbAndHiddenNeurons = new TextBox();
            lblAndOutput = new Label();
            tbAndOutput = new TextBox();
            btnAndTrain = new Button();
            btnAndCreateBPNN = new Button();
            tbAndD = new TextBox();
            tbAndC = new TextBox();
            tbAndB = new TextBox();
            tbAndA = new TextBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // createBPNN
            // 
            createBPNN.Location = new Point(41, 238);
            createBPNN.Name = "createBPNN";
            createBPNN.Size = new Size(174, 61);
            createBPNN.TabIndex = 0;
            createBPNN.Text = "Create BPNN";
            createBPNN.UseVisualStyleBackColor = true;
            createBPNN.Click += createBPNN_Click;
            // 
            // trainNeuralNet
            // 
            trainNeuralNet.Location = new Point(313, 238);
            trainNeuralNet.Name = "trainNeuralNet";
            trainNeuralNet.Size = new Size(174, 61);
            trainNeuralNet.TabIndex = 1;
            trainNeuralNet.Text = "Train the Neural Net";
            trainNeuralNet.UseVisualStyleBackColor = true;
            trainNeuralNet.Click += trainNeuralNet_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(562, 238);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(174, 61);
            btnTest.TabIndex = 2;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // tbA
            // 
            tbA.Location = new Point(41, 50);
            tbA.Name = "tbA";
            tbA.Size = new Size(346, 25);
            tbA.TabIndex = 3;
            // 
            // tbB
            // 
            tbB.Location = new Point(41, 149);
            tbB.Name = "tbB";
            tbB.Size = new Size(346, 25);
            tbB.TabIndex = 4;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(393, 99);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(343, 25);
            tbOutput.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 426);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(createBPNN);
            tabPage1.Controls.Add(tbOutput);
            tabPage1.Controls.Add(trainNeuralNet);
            tabPage1.Controls.Add(tbB);
            tabPage1.Controls.Add(btnTest);
            tabPage1.Controls.Add(tbA);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(778, 396);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "2-Input OR Gate";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 129);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 8;
            label3.Text = "Input B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 30);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 7;
            label2.Text = "Input A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 79);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 6;
            label1.Text = "Output";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAndTest);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbAndHiddenNeurons);
            tabPage2.Controls.Add(lblAndOutput);
            tabPage2.Controls.Add(tbAndOutput);
            tabPage2.Controls.Add(btnAndTrain);
            tabPage2.Controls.Add(btnAndCreateBPNN);
            tabPage2.Controls.Add(tbAndD);
            tabPage2.Controls.Add(tbAndC);
            tabPage2.Controls.Add(tbAndB);
            tabPage2.Controls.Add(tbAndA);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 396);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "4-Input AND Gate";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAndTest
            // 
            btnAndTest.Location = new Point(479, 204);
            btnAndTest.Name = "btnAndTest";
            btnAndTest.Size = new Size(184, 61);
            btnAndTest.TabIndex = 14;
            btnAndTest.Text = "Test";
            btnAndTest.UseVisualStyleBackColor = true;
            btnAndTest.Click += btnAndTest_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 58);
            label5.Name = "label5";
            label5.Size = new Size(184, 17);
            label5.TabIndex = 13;
            label5.Text = "Number of Hidden Neurons";
            // 
            // tbAndHiddenNeurons
            // 
            tbAndHiddenNeurons.Location = new Point(413, 86);
            tbAndHiddenNeurons.Name = "tbAndHiddenNeurons";
            tbAndHiddenNeurons.Size = new Size(322, 25);
            tbAndHiddenNeurons.TabIndex = 12;
            tbAndHiddenNeurons.Text = "4";
            // 
            // lblAndOutput
            // 
            lblAndOutput.AutoSize = true;
            lblAndOutput.Location = new Point(543, 138);
            lblAndOutput.Name = "lblAndOutput";
            lblAndOutput.Size = new Size(52, 17);
            lblAndOutput.TabIndex = 11;
            lblAndOutput.Text = "Output";
            // 
            // tbAndOutput
            // 
            tbAndOutput.Location = new Point(413, 158);
            tbAndOutput.Name = "tbAndOutput";
            tbAndOutput.Size = new Size(322, 25);
            tbAndOutput.TabIndex = 10;
            // 
            // btnAndTrain
            // 
            btnAndTrain.Location = new Point(217, 204);
            btnAndTrain.Name = "btnAndTrain";
            btnAndTrain.Size = new Size(170, 61);
            btnAndTrain.TabIndex = 9;
            btnAndTrain.Text = "Train the NeuralNet";
            btnAndTrain.UseVisualStyleBackColor = true;
            btnAndTrain.Click += btnAndTrain_Click;
            // 
            // btnAndCreateBPNN
            // 
            btnAndCreateBPNN.Location = new Point(41, 204);
            btnAndCreateBPNN.Name = "btnAndCreateBPNN";
            btnAndCreateBPNN.Size = new Size(170, 61);
            btnAndCreateBPNN.TabIndex = 8;
            btnAndCreateBPNN.Text = "Create BPNN";
            btnAndCreateBPNN.UseVisualStyleBackColor = true;
            btnAndCreateBPNN.Click += btnAndCreateBPNN_Click;
            // 
            // tbAndD
            // 
            tbAndD.Location = new Point(41, 158);
            tbAndD.Name = "tbAndD";
            tbAndD.Size = new Size(346, 25);
            tbAndD.TabIndex = 7;
            // 
            // tbAndC
            // 
            tbAndC.Location = new Point(41, 122);
            tbAndC.Name = "tbAndC";
            tbAndC.Size = new Size(346, 25);
            tbAndC.TabIndex = 6;
            // 
            // tbAndB
            // 
            tbAndB.Location = new Point(41, 86);
            tbAndB.Name = "tbAndB";
            tbAndB.Size = new Size(346, 25);
            tbAndB.TabIndex = 5;
            // 
            // tbAndA
            // 
            tbAndA.Location = new Point(41, 50);
            tbAndA.Name = "tbAndA";
            tbAndA.Size = new Size(346, 25);
            tbAndA.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 30);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 0;
            label4.Text = "Inputs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Back Propagation";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button createBPNN;
        private Button trainNeuralNet;
        private Button btnTest;
        private TextBox tbA;
        private TextBox tbB;
        private TextBox tbOutput;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnAndTrain;
        private Button btnAndCreateBPNN;
        private TextBox tbAndD;
        private TextBox tbAndC;
        private TextBox tbAndB;
        private TextBox tbAndA;
        private Label label5;
        private TextBox tbAndHiddenNeurons;
        private Label lblAndOutput;
        private TextBox tbAndOutput;
        private Button btnAndTest;
    }
}
