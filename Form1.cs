using Backprop;

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        const int OR_HIDDEN = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void createBPNN_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(2, OR_HIDDEN, 1);
        }

        private void trainNeuralNet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(tbA.Text));
            nn.setInputs(1, Convert.ToDouble(tbB.Text));
            nn.run();
            tbOutput.Text = "" + nn.getOuputData(0);
        }



        NeuralNet ann;
        int andHidden = 4;

        private void btnAndCreateBPNN_Click(object sender, EventArgs e)
        {
            andHidden = Convert.ToInt16(tbAndHiddenNeurons.Text);
            ann = new NeuralNet(4, andHidden, 1);
        }
        private void btnAndTest_Click(object sender, EventArgs e)
        {
            ann.setInputs(0, Convert.ToDouble(tbAndA.Text));
            ann.setInputs(1, Convert.ToDouble(tbAndB.Text));
            ann.setInputs(2, Convert.ToDouble(tbAndC.Text));
            ann.setInputs(3, Convert.ToDouble(tbAndD.Text));
            ann.run();
            tbAndOutput.Text = "" + ann.getOuputData(0);
        }
        private void btnAndTrain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                for (byte data = 0; data < 15; data++)
                {
                    ann.setInputs(0, getBit(data, 0b00000001));
                    ann.setInputs(1, getBit(data, 0b00000010));
                    ann.setInputs(2, getBit(data, 0b00000100));
                    ann.setInputs(3, getBit(data, 0b00001000));

                    ann.setDesiredOutput(0, 0.0);
                    ann.learn();
                }
                ann.setInputs(0, 1.0);
                ann.setInputs(1, 1.0);
                ann.setInputs(2, 1.0);
                ann.setInputs(3, 1.0);
                ann.setDesiredOutput(0, 1.0);
                ann.learn();
            }
        }
        private double getBit(byte data, byte mask)
        {
            int res = (data & mask);
            if (res == 0)
                return 0.0;
            else
                return 1.0;
        }

        
    }
}
