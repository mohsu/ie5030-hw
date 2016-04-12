using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R03546012許芸瑄Ass11
{
    public partial class Mainform : Form
    {
        //neural networking
        double[][] x;//neuron value
        double[][][] weights;//weights
        double[][] e;//partial derivative of error
        int layerNumber;
        int[] neuronNumbers;
        int inputDimension;
        int inputNumber;
        int numberOfTrainingVectors;
        double[,] originalInputs;
        double[,] inputs;//normalized
        double[] inputMax;
        double[] inputMin;
        int inputWidth;
        int targetDimension;
        double[,] originalTargets;
        double[,] targets;//normalized output vectors
        int[] vectorIndices;

        double Epoch_rootMeanSquare = 0.0;//root mean square of error for an epoch of data trainning
        double elasped_RMS_Error;
        int numberOfInstancesExecutedSoFar;
        double cumulatedErrorSquareInOneEpoch;
        double cumulatedErrorSquare;

        Random rnd = new Random();

        double learningRate = 0.999f;
        double eta;
        double initialEta = 0.7;

        //讀檔
        double trainingRatio;
        bool RandomlyDraw;

        //UI
        int NumberOfHiddenLayers;
        int[] HiddenNeuronNumbers;
        double InitialLearningRate;
        double ReducingFactor;
        bool AllForTraining;
        double ErrorTolerance;
        double[] Correctness;
        string InputFile_path;

        //stopping conditions
        int EpochLimit;
        double Elasped_Error_RMSLimit;

        //畫圖
        int EpochID;
        double CircleDiameter = 50;
        double SaveWidth = 20;
        double SaveHeight = 20;
        double StringWidth_Front = 40;

        public Mainform()
        {
            InitializeComponent();
            btnReset.Enabled = false;
            btnTesting.Enabled = false;
            btnTraining.Enabled = false;
        }

        //讀檔
        private void MLPOpen(object sender, EventArgs e)
        {
            //from UI
            if (rdbAllForTesting.Checked)
            {
                AllForTraining = true;
                trainingRatio = 1;
                RandomlyDraw = false;
            }
            else
            {
                AllForTraining = false;
                trainingRatio = Convert.ToDouble(txtNumeratorOfRadio.Text) / Convert.ToDouble(txtDominatorOfRadio.Text);
                if (rdbRandomlyDraw.Checked)
                    RandomlyDraw = true;
                else
                    RandomlyDraw = false;
            }
            //讀檔
            OpenFileDialog dlgOpen = new OpenFileDialog();
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)//執行一個判斷，當雙擊需要開啟的檔案的時候，執行下面的程式
            {
                btnReset.Enabled = true;
                StreamReader sr = new StreamReader(dlgOpen.FileName);//設置StreamReader的參照sr,並將其讀取檔案的路徑設置為dlgOpen.FileName
                InputFile_path = dlgOpen.FileName;
                char[] separators = new char[] { ',', ' ' };
                string s = sr.ReadLine();
                string[] items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                inputNumber = Convert.ToInt32(items[0]);
                inputDimension = Convert.ToInt32(items[1]);
                targetDimension = Convert.ToInt32(items[2]);
                inputWidth = Convert.ToInt32(items[3]);
                numberOfTrainingVectors = Convert.ToInt32(Math.Round(inputNumber * trainingRatio));

                items = new string[inputDimension + targetDimension];
                originalInputs = new double[inputNumber, inputDimension];
                originalTargets = new double[inputNumber, targetDimension];

                for (int i = 0; i < inputNumber; i++)
                {
                    s = sr.ReadLine();
                    items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < inputDimension + targetDimension; j++)
                    {
                        if (j < inputDimension)
                        {
                            originalInputs[i, j] = Convert.ToSingle(items[j]);
                        }
                        else
                        {
                            originalTargets[i, j - inputDimension] = Convert.ToSingle(items[j]);
                        }
                    }
                }

                inputMax = new double[inputDimension];
                inputMin = new double[inputDimension];

                for (int i = 0; i < inputDimension; i++)
                {
                    inputMax[i] = double.MinValue;
                    inputMin[i] = double.MaxValue;
                    for (int j = 0; j < inputNumber; j++)
                    {
                        //更新inputMax
                        if (originalInputs[j, i] > inputMax[i])
                            inputMax[i] = originalInputs[j, i];
                        //更新inputMin
                        if (originalInputs[j, i] < inputMin[i])
                            inputMin[i] = originalInputs[j, i];
                    }
                }

                //標準化 oringinalInputs
                inputs = new double[inputNumber, inputDimension];

                for (int i = 0; i < inputDimension; i++)
                    for (int j = 0; j < inputNumber; j++)
                        inputs[j, i] = (originalInputs[j, i] - inputMin[i]) / (inputMax[i] - inputMin[i]);
                targets = new double[inputNumber, targetDimension];
                for (int i = 0; i < inputNumber; i++)
                    for (int t = 0; t < targetDimension; t++)
                        targets[i, t] = originalTargets[i, t];
                //如果RandomlyDraw按鈕被按下，就對所有的Data Set進行隨機排列
                if (RandomlyDraw)
                    RandomizeIndices(inputNumber);

                //to UI
                rtbDataBackGroundInformation.Clear();
                rtbProblemInformation.Clear();
                rtbDataBackGroundInformation.AppendText(string.Format("Number of Input Vectors: {0}",inputNumber) + "\n");
                rtbDataBackGroundInformation.AppendText(string.Format("Input Dimension: {0} Output Dimension: {1}", inputDimension, targetDimension) + "\n");
                rtbProblemInformation.AppendText(string.Format("Number of Input Vectors: {0}", inputNumber) + "\n");
                rtbProblemInformation.AppendText(string.Format("Input Dimension: {0} Output Dimension: {1}",inputDimension, targetDimension) + "\n");
                if (rdbAllForTesting.Checked)
                {
                    rtbDataBackGroundInformation.AppendText(string.Format("Number of Training Vectors: {0} Number of Testing Vectors: {1}", inputNumber, inputNumber));
                    rtbProblemInformation.AppendText(string.Format("Number of Training Vectors: {0} Number of Testing Vectors: {1}", inputNumber, inputNumber));
                }
                else
                {
                    rtbDataBackGroundInformation.AppendText(string.Format("Number of Training Vectors: {0} Number of Testing Vectors: {1}", numberOfTrainingVectors,inputNumber - numberOfTrainingVectors));
                    rtbProblemInformation.AppendText(string.Format("Number of Training Vectors: {0} Number of Testing Vectors: {1}", numberOfTrainingVectors, inputNumber - numberOfTrainingVectors));
                }

                listBoxoriginalData.Items.Clear();
                string item;
                for (int i = 0; i < inputNumber; i++)
                {
                    item = "ID" + (i + 1) + ":".ToString();
                    for (int j = 0; j < inputDimension + targetDimension; j++)
                    {
                        if (j < inputDimension)
                            item += " " + originalInputs[i, j];
                        else
                            item += " " + originalTargets[i, j - inputDimension];
                    }
                    listBoxoriginalData.Items.Add(item);
                }
                //讀取完成
                MessageBox.Show("File data had been loaded.", "File Data", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please Open A File.", "Warning", MessageBoxButtons.OK);
        }

        //Randonly shuffle the orders of the data in the data set
        public void RandomizeIndices(int Pop_size)
        {
            int selectednumber = Pop_size;
            double[] temp_Input = new double[inputDimension];
            double[] temp_Target = new double[targetDimension];

            for (int i = 0; i < Pop_size; i++)
            {
                int RandomPosition = rnd.Next(selectednumber);
                for (int j = 0; j < inputDimension; j++)
                {
                    temp_Input[j] = inputs[selectednumber - 1, j];
                    inputs[selectednumber - 1, j] = inputs[RandomPosition, j];
                    inputs[RandomPosition, j] = temp_Input[j];
                }

                //換
                for (int k = 0; k < targetDimension; k++)
                {
                    temp_Target[k] = targets[selectednumber - 1, k];
                    targets[selectednumber - 1, k] = targets[RandomPosition, k];
                    targets[RandomPosition, k] = temp_Target[k];
                }

                selectednumber--;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string itemstring;
            Correctness = new double[4];

            //from UI
            NumberOfHiddenLayers = (int)numericNumberOfNeuronLayers.Value;
            HiddenNeuronNumbers = new int[NumberOfHiddenLayers];
            InitialLearningRate = Convert.ToDouble(txtInitialLearningRate.Text);
            ReducingFactor = Convert.ToDouble(txtReducingFactor.Text);
            //清空原有的線圖
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < NumberOfHiddenLayers; i++)
            {
                itemstring = lsbNeurons.Items[i].ToString();
                HiddenNeuronNumbers[i] = int.Parse(itemstring.Substring(itemstring.IndexOf(":") + 1).Trim());
            }

            if (ckbElaspedErrorRMSLimit.Checked)
                Elasped_Error_RMSLimit = Convert.ToDouble(txtElaspedErrorRMSLimit.Text);
            else
                Elasped_Error_RMSLimit = 0;

            if (ckbEpochLimit.Checked)
                EpochLimit = Convert.ToInt32(txtEpochLimit.Text);
            else
                EpochLimit = int.MaxValue;

            learningRate = InitialLearningRate;
            initialEta = ReducingFactor;

            //利用每一Hidden Layer的Neurons的個數來復原原有的NeuralNetWork,便於後期計算
            ConfigureNeuralNetwork(HiddenNeuronNumbers);
            ResetWeightsAndInitialCondition();
            
            //畫圖
            splitContainerExecution.Panel2.Refresh();

            btnTraining.Enabled = true;
        }

        public void ConfigureNeuralNetwork(int[] hiddenNeuronNumbers)
        {
            layerNumber = hiddenNeuronNumbers.Length + 2;
            neuronNumbers = new int[layerNumber];
            neuronNumbers[0] = inputDimension + 1;//第0層的神經元個數為inputDimension
            neuronNumbers[layerNumber - 1] = targetDimension + 1;//最後一層的神經元個數為targetDimension

            //中間層級的神經元個數就直接是使用者設置的神經元個數
            for (int i = 1; i < layerNumber - 1; i++)
                neuronNumbers[i] = hiddenNeuronNumbers[i - 1] + 1;
        }

        public void ResetWeightsAndInitialCondition()
        {
            //Reset
            Epoch_rootMeanSquare = 0.0f;

            //初始化EMS相關的變量
            elasped_RMS_Error = 0.0f;
            numberOfInstancesExecutedSoFar = 0;
            cumulatedErrorSquareInOneEpoch = 0.0f;
            cumulatedErrorSquare = 0.0f;

            //為x和e準備好相應的記憶空間
            x = new double[layerNumber][];
            e = new double[layerNumber][];
            for (int i = 0; i < layerNumber; i++)
            {
                x[i] = new double[neuronNumbers[i]];
                e[i] = new double[neuronNumbers[i]];
            }
            //將x[l][0]初置為1
            for (int l = 0; l < layerNumber; l++)
            {
                x[l][0] = 1.0;
            }

            //将initilEta的值赋予给eta
            eta = initialEta;

            //Randomly set values of weights between[-1,1]
            weights = new double[layerNumber][][];

            for (int l = 0; l < layerNumber; l++)
            {
                weights[l] = new double[neuronNumbers[l]][];//為weights[l]準備一個長度為neuronNumbers[l]的記憶空間，用於確定第l層神經元的個數
                for (int k = 0; k < neuronNumbers[l]; k++)
                {
                    if (l == 0)
                        continue;
                    else
                    {
                        weights[l][k] = new double[neuronNumbers[l - 1]];
                        for (int i = 0; i < neuronNumbers[l - 1]; i++)
                        {
                            weights[l][k][i] = Convert.ToSingle(2.0 * (rnd.NextDouble() - 0.5));
                        }
                    }
                }
            }

            //Randomly Shuffle
            RandomizeIndices(inputNumber);
        }

        bool Stopflag = false;
        private void btnTraining_Click(object sender, EventArgs e)
        {
            EpochID = 1;
            for (int i = 0; i < EpochLimit; i++)
            {
                if (ckbShuffleOrderOfTrainingData.Checked)
                    RandomizeIndices(numberOfTrainingVectors);

                TrainAnEpoch();

                if (elasped_RMS_Error < Elasped_Error_RMSLimit)
                    Stopflag = true;

                EpochID++;//每演化一個代次,計算器加1
            }
            MessageBox.Show("Neural Network execution complete\nTrained Data: " + numberOfInstancesExecutedSoFar + "\nElasped RMS Error: " + elasped_RMS_Error + "\nEpoches: " + (EpochID - 1) + "\nEpoch RMS Error: " + Epoch_rootMeanSquare.ToString(), "NN Stop", MessageBoxButtons.OK);
        }

        public void TrainAnEpoch()//bool AllForTrainning
        {
            double v;
            double errorSquareSum = 0.0;
            double sumation = 0.0;
            int layerNumberMinusOne = layerNumber - 1;

            cumulatedErrorSquareInOneEpoch = 0;

            //forward computing for all neuro values
            for (int p = 0; p < numberOfTrainingVectors; p++)
            {
                for (int i = 0; i < inputDimension; i++)
                {
                    x[0][i + 1] = inputs[p, i];
                }

                for (int l = 1; l < layerNumber; l++)
                {
                    for (int k = 1; k < neuronNumbers[l]; k++)
                    {
                        v = 0;
                        for (int i = 0; i < neuronNumbers[l - 1]; i++)
                            v += weights[l][k][i] * x[l - 1][i];
                        x[l][k] = Convert.ToSingle(1 / (1 + Math.Exp(-v)));
                    }
                }

                //Compute the rootMeanSquare of a testing data and Count the Tolerance-based Correctness
                errorSquareSum = 0;

                for (int i = 1; i < neuronNumbers[layerNumberMinusOne]; i++)
                {
                    errorSquareSum += (double)Math.Pow((x[layerNumberMinusOne][i] - targets[p, i - 1]), 2);
                }

                cumulatedErrorSquareInOneEpoch += errorSquareSum;

                //Compute the epsilon values for neurons on the output layer
                for (int k = 1; k < neuronNumbers[layerNumberMinusOne]; k++)
                {
                    e[layerNumberMinusOne][k] = -2 * (targets[p, k - 1] - x[layerNumberMinusOne][k]) * x[layerNumberMinusOne][k] * (1 - x[layerNumberMinusOne][k]);
                }

                //backward computing for the epsilon values(except the output layer)
                for (int l = layerNumberMinusOne - 1; l >= 1; l--)
                {
                    for (int k = 1; k < neuronNumbers[l]; k++)
                    {
                        sumation = 0;
                        for (int i = 1; i < neuronNumbers[l + 1]; i++)
                        {
                            sumation += e[l + 1][i] * weights[l + 1][i][k];
                        }
                        e[l][k] = x[l][k] * (1 - x[l][k]) * sumation;
                    }
                }

                //update weights for all weights by using epsilon and neuron values
                for (int l = 1; l < layerNumber; l++)
                    for (int k = 1; k < neuronNumbers[l]; k++)
                        for (int i = 0; i < neuronNumbers[l - 1]; i++)
                            weights[l][k][i] += -eta * e[l][k] * x[l - 1][i];

                numberOfInstancesExecutedSoFar++;
            }
            //Compute error 
            cumulatedErrorSquare += cumulatedErrorSquareInOneEpoch;
            Epoch_rootMeanSquare = (double)Math.Pow(cumulatedErrorSquareInOneEpoch / (numberOfTrainingVectors * targetDimension), 0.5);
            elasped_RMS_Error = (double)Math.Pow(cumulatedErrorSquare / (numberOfInstancesExecutedSoFar * targetDimension), 0.5);
            eta = eta * learningRate;

            //畫圖
            chart1.Series[0].Points.AddXY(EpochID, Epoch_rootMeanSquare);
        }

        public double[] Testing(double rootMeanSquareTolerance, bool allForTrainning)
        {
            int[] orders;
            int successedCount = 0;
            int Tolerance_basedsuccessedCount = 0;
            int startNumber;
            double v;
            double errorSquareSum = 0.0;
            double TotalErrorSquareSum = 0.0;
            int layerNumberMinusOne = layerNumber - 1;
            int MaxValue_OccuredPosition;
            double MaxValue;
            double[] TestingResult;

            TestingResult = new double[4];

            //如果所有的資料都拿來訓練的話,就將Testing的起始資料ID設為0
            if (allForTrainning)
                startNumber = 0;
            else
                startNumber = numberOfTrainingVectors;

            orders = new int[neuronNumbers[layerNumberMinusOne]];

            for (int p = startNumber; p < inputNumber; p++)
            {
                for (int i = 0; i < inputDimension; i++)
                {
                    x[0][i + 1] = inputs[p, i];
                }
                for (int l = 1; l < layerNumber; l++)
                {
                    for (int k = 1; k < neuronNumbers[l]; k++)
                    {
                        v = 0;
                        for (int i = 0; i < neuronNumbers[l - 1]; i++)
                        {
                            v += weights[l][k][i] * x[l - 1][i];
                        }
                        x[l][k] = Convert.ToSingle(1 / (1 + Math.Exp(-v)));
                    }
                }

                //Compute the rootMeanSquare of a testing data and Count the Tolerance-based Correctness
                errorSquareSum = 0;

                for (int i = 1; i < neuronNumbers[layerNumberMinusOne]; i++)
                {
                    errorSquareSum += (double)Math.Pow((x[layerNumberMinusOne][i] - targets[p, i - 1]), 2);
                }

                TotalErrorSquareSum += errorSquareSum;

                Epoch_rootMeanSquare = (double)Math.Pow(errorSquareSum / targetDimension, 0.5);

                if (Epoch_rootMeanSquare < rootMeanSquareTolerance)
                {
                    Tolerance_basedsuccessedCount++;
                }

                //find max
                MaxValue = double.MinValue;
                MaxValue_OccuredPosition = 0;

                for (int i = 1; i < neuronNumbers[layerNumberMinusOne]; i++)
                {
                    if (x[layerNumberMinusOne][i] > MaxValue)
                    {
                        MaxValue = x[layerNumberMinusOne][i];
                        MaxValue_OccuredPosition = i;
                    }
                }

                //Output neuron
                for (int k = 1; k < neuronNumbers[layerNumberMinusOne]; k++)
                {
                    x[layerNumberMinusOne][k] = 0;
                    if (k == MaxValue_OccuredPosition)
                    {
                        x[layerNumberMinusOne][k] = 1;
                    }
                }

                //checkiftrue
                if (x[layerNumberMinusOne][MaxValue_OccuredPosition] == targets[p, MaxValue_OccuredPosition - 1])
                {
                    successedCount++;
                }
            }
            if (allForTrainning)
            {
                Epoch_rootMeanSquare = (double)Math.Pow(TotalErrorSquareSum / (targetDimension * inputNumber), 0.5);
                TestingResult[0] = (double)successedCount / (double)inputNumber;
                TestingResult[1] = (double)Tolerance_basedsuccessedCount / (double)inputNumber;
                TestingResult[2] = (double)successedCount;
                TestingResult[3] = (double)inputNumber;
                return TestingResult;
            }
            else
            {
                Epoch_rootMeanSquare = (double)Math.Pow(TotalErrorSquareSum / (targetDimension * (inputNumber - numberOfTrainingVectors)), 0.5);
                TestingResult[0] = (double)successedCount / (double)(inputNumber - numberOfTrainingVectors);
                TestingResult[1] = (double)Tolerance_basedsuccessedCount / (double)(inputNumber - numberOfTrainingVectors);
                TestingResult[2] = (double)successedCount;
                TestingResult[3] = (double)inputNumber - numberOfTrainingVectors;
                return TestingResult;
            }
        }
        
        string ItemsString;

        private void btnTesting_Click(object sender, EventArgs e)
        {
            //from UI
            ErrorTolerance = Convert.ToDouble (numericErrorTolerance.Value);

            //reset
            rtbTestingResult.Clear();
            rtbCorrectness.Clear();

            Correctness =Testing(ErrorTolerance, AllForTraining);

            //to UI
            rtbTestingResult.AppendText("Error root mean square: " +Epoch_rootMeanSquare + "\n");
            rtbTestingResult.AppendText("Correctness Tolerance: " + Math.Round(ErrorTolerance, 4) + "\n");
            rtbTestingResult.AppendText("Tolerance-based Correctness: " + Math.Round(Correctness[1] * 100, 2) + "%");
            rtbCorrectness.AppendText(string.Format("Classification Correctness = {0}/{1} = {2}%", Correctness[2], Correctness[3], Math.Round(Correctness[0] * 100, 2)));

            rtbWeightsAndBiasesOfWellTrainedNN.Clear();
            for (int l = 1; l < layerNumber; l++)
            {
                rtbWeightsAndBiasesOfWellTrainedNN.AppendText(string.Format("Layer {0}", l) + "\n");
                for (int k = 1; k < neuronNumbers[l]; k++)
                {
                    ItemsString = null;
                    for (int i = 0; i < neuronNumbers[l - 1]; i++)
                    {
                        ItemsString += string.Format(" weights[{0}][{1}][{2}]{3}", l, k, i, weights[l][k][i]);
                    }
                    rtbWeightsAndBiasesOfWellTrainedNN.AppendText(ItemsString + "\n");
                    rtbWeightsAndBiasesOfWellTrainedNN.AppendText("\n");
                }
            }
        }

        private void splitContainerExecution_Panel2_Paint(object sender, PaintEventArgs e)
        {
            ExecuteOneInteraton_Graph(e.Graphics);
        }

        void ExecuteOneInteraton_Graph(Graphics gg)
        {
            double horizontalIncrement;
            double[] verticalIncrement;
            double[][][] NeuronPosition;
            Rectangle graph;
            Point point1;
            Point point2;

            NeuronPosition = new double[layerNumber][][];
            for (int l = 0; l < layerNumber; l++)
            {
                NeuronPosition[l] = new double[neuronNumbers[l]][];
                for (int n = 0; n <neuronNumbers[l]; n++)
                {
                    NeuronPosition[l][n] = new double[2];
                }
            }

            double ContainerWidth;
            double ContainerHeight;
            ContainerWidth = (double)splitContainerExecution.Panel2.ClientSize.Width - (double)(2 * SaveWidth + StringWidth_Front + CircleDiameter);
            ContainerHeight = (double)splitContainerExecution.Panel2.ClientSize.Height - (double)(2 * SaveHeight + CircleDiameter);

            horizontalIncrement = ContainerWidth / (layerNumber - 1);
            verticalIncrement = new double[layerNumber];

            for (int i = 0; i < layerNumber; i++)
                verticalIncrement[i] = ContainerHeight / (neuronNumbers[i] - 2);

            //準備好起始位置
            for (int l = 0; l < layerNumber; l++)
                for (int n = 1; n < neuronNumbers[l]; n++)
                    for (int x = 0; x < 2; x++)
                    {
                        if (x == 0)
                            NeuronPosition[l][n][x] = 10 + l * horizontalIncrement;
                        else
                            NeuronPosition[l][n][x] = 10 + (n - 1) * verticalIncrement[l];
                    }

            //draw circles
            for (int l = 0; l < layerNumber; l++)
                for (int n = 1; n < neuronNumbers[l]; n++)
                {
                    graph = new Rectangle((int)NeuronPosition[l][n][0], (int)NeuronPosition[l][n][1], 50, 50);
                    gg.DrawEllipse(Pens.Black, graph);
                }

            //neuro values
            for (int l = 0; l < layerNumber; l++)
                for (int n = 1; n < neuronNumbers[l]; n++)
                {
                    graph = new Rectangle((int)NeuronPosition[l][n][0] + 50, (int)NeuronPosition[l][n][1] + 20, 40, 10);
                    gg.DrawRectangle(Pens.Transparent, graph);
                    gg.DrawString(string.Format("{0:0.000}", x[l][n]), this.Font, Brushes.Red, graph);
                }

            //weight
            for (int l = 1; l <layerNumber; l++)
                for (int n = 1; n < neuronNumbers[l]; n++)
                    for (int w = 0; w < neuronNumbers[l - 1]; w++)
                    {
                        graph = new Rectangle((int)NeuronPosition[l][n][0] - 50, (int)NeuronPosition[l][n][1] + 25 - (neuronNumbers[l - 1] * 10) / 2 + w * 10, 50, 10);
                        gg.DrawRectangle(Pens.Transparent, graph);
                        gg.DrawString(string.Format("{0:0.000}", weights[l][n][w]), this.Font, Brushes.Red, graph);
                    }

            //lines
            for (int l = 0; l < layerNumber - 1; l++)
                for (int n = 1; n < neuronNumbers[l]; n++)
                {
                    point1 = new Point((int)NeuronPosition[l][n][0] + 90, (int)NeuronPosition[l][n][1] + 25);
                    for (int x = 1; x < neuronNumbers[l + 1]; x++)
                    {
                        point2 = new Point((int)NeuronPosition[l + 1][x][0] - 50, (int)NeuronPosition[l + 1][x][1] + 25);

                        gg.DrawLine(Pens.Black, point1, point2);
                    }
                }
        }
    }
}
