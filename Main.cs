using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathHomework
{
    public partial class Main : Form
    {

        /// <summary>
        /// 计算数字大小
        /// </summary>
        private string _lenght = "1-10";

        /// <summary>
        /// 计算符
        /// </summary>
        private string _operator = "减法";


        /// <summary>
        /// 计算符数量
        /// </summary>
        private int _num = 1;


        /// <summary>
        /// 保存路径
        /// </summary>
        private string _savePath = "";


        /// <summary>
        /// 构造函数
        /// </summary>
        public Main()
        {
            InitializeComponent();
            this.comboBoxLenght.SelectedItem = this._lenght;
            this.comboBoxNum.SelectedItem = this._num.ToString();
            this.comboBoxOperator.SelectedItem = this._operator;
            //  this._savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this._savePath = Application.StartupPath;

            //Application.StartPath
        }




        /// <summary>
        /// 生成一组题目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnBuild_Click(object sender, EventArgs e)
        {
            this.btnBuild.Enabled = false;
            List<string> calculationStr = new List<string>();
            List<string> answerStr = new List<string>();


            int pageLine = int.Parse(this.printPageSize.Text);
            for (int i = 0; i < pageLine; i++)
            {
                var list = GetList();
                string calculationString = "";
                int index = 0;

                switch (this._operator)
                {

                    case "加法":
                        #region 加法
                        foreach (var item in list)
                        {
                            //最后一个
                            if (index == list.Count - 1)
                            {
                                index = 99;
                            }

                            switch (index)
                            {
                                case 0:
                                    calculationString = item.ToString();
                                    break;
                                case 99:
                                    calculationString = calculationString + " + " + item.ToString() + " = ";
                                    break;
                                default:
                                    calculationString = calculationString + " + " + item.ToString();
                                    break;

                            }
                            index++;
                        }
                        answerStr.Add(list.Sum().ToString());
                        calculationStr.Add(calculationString);
                        #endregion
                        break;
                    case "减法":
                        #region 减法
                        while (true)
                        {
                            if (this.checkBoxFixNegative.Checked)
                            {
                                list.Sort((x, y) => -x.CompareTo(y));
                            }
                            foreach (var item in list)
                            {

                                //最后一个
                                if (index == list.Count - 1)
                                {
                                    index = 99;
                                }

                                switch (index)
                                {
                                    case 0:
                                        calculationString = item.ToString();
                                        break;
                                    case 99:
                                        calculationString = calculationString + " - " + item.ToString() + " = ";
                                        break;
                                    default:
                                        calculationString = calculationString + " - " + item.ToString();
                                        break;

                                }
                                index++;

                            }

                            int computed = 0;
                            for (int y = 0; y < list.Count; y++)
                            {

                                if (y == 0)
                                {
                                    computed = list[y];
                                    continue;
                                }
                                computed = computed - list[y];

                            }
                            if (this.checkBoxFixNegative.Checked)
                            {
                                if (computed >= 0)
                                {
                                    answerStr.Add(computed.ToString());
                                    calculationStr.Add(calculationString);
                                    break;
                                }
                                list = GetList();
                                calculationString = "";
                                computed = 0;
                                index = 0;

                            }
                            else
                            {
                                answerStr.Add(computed.ToString());
                                calculationStr.Add(calculationString);
                                break;

                            }

                        }
                        #endregion
                        break;
                    case "乘法":
                        #region 乘法

                        foreach (var item in list)
                        {
                            //最后一个
                            if (index == list.Count - 1)
                            {
                                index = 99;
                            }

                            switch (index)
                            {
                                case 0:
                                    calculationString = item.ToString();
                                    break;
                                case 99:
                                    calculationString = calculationString + " x " + item.ToString() + " = ";
                                    break;
                                default:
                                    calculationString = calculationString + " x " + item.ToString();
                                    break;

                            }
                            index++;
                        }


                        int computedx = 0;
                        for (int y = 0; y < list.Count; y++)
                        {

                            if (y == 0)
                            {
                                computedx = list[y];
                                continue;
                            }
                            computedx = computedx * list[y];

                        }

                        answerStr.Add(computedx.ToString());
                        calculationStr.Add(calculationString);

                        #endregion
                        break;
                    case "除法":
                        #region 除法
                        string answ = "";
                        while (true)
                        {

                            if (this.checkBoxFixNegative.Checked)
                            {
                                list.Sort((x, y) => -x.CompareTo(y));
                            }

                            //计算结果
                            decimal computedy = 0;
                            for (int y = 0; y < 2; y++)
                            {

                                if (y == 0)
                                {
                                    computedy = list[y];
                                    continue;
                                }
                                computedy = computedy / list[y];
                            }
                            if (computedy < 1)
                            {
                                continue;
                            }
                            answ = Math.Floor(Convert.ToDecimal(list[0] / list[1])).ToString();

                            if ((list[0] % list[1]) != 0)
                            {
                                answ = answ + " ... " + (list[0] % list[1]).ToString();
                            }

                            foreach (var item in list)
                            {
                                if (index > 1)
                                {
                                    break;
                                }

                                switch (index)
                                {
                                    case 0:
                                        calculationString = item.ToString();
                                        break;
                                    case 1:
                                        calculationString = calculationString + " ÷ " + item.ToString() + " = ";
                                        break;
                                    default:
                                        break;

                                }
                                index++;

                            }

                            answerStr.Add(answ);
                            calculationStr.Add(calculationString);
                            break;
                        }
                        #endregion

                        break;
                    default:
                        //混合
                        #region 混合
                        var ranMethod = new string[] { "加法", "减法", "乘法", "除法" };
                        var r = new Random().Next(0, 4);
                        var bm = BlendMethod(ranMethod[r]);
                        if (bm.Count > 0)
                        {
                            answerStr.Add(bm[0]);
                            calculationStr.Add(bm[1]);
                        }

                        #endregion
                        break;
                }





            }






            //输出题目
            StringBuilder str = new StringBuilder();


            int tmNum = 1;
            foreach (var tm in calculationStr)
            {

                string appText = "(" + tmNum.ToString("D2") + ")   " + tm;

                //补长度
                int maxlen = 35;

                //符号多,少点列
                int mod = 2;

                int getByteLength = Encoding.UTF8.GetBytes(appText).Length;
                if (getByteLength < maxlen)
                {
                    while (true)
                    {

                        appText = appText + " ";
                        if (Encoding.UTF8.GetBytes(appText).Length == maxlen)
                        {
                            break;
                        }
                    }
                }



                str.Append(appText);
                if (tmNum % mod == 0 && tmNum != 1)
                {
                    if (tmNum != int.Parse(this.printPageSize.Text)) {
                        str.AppendLine();
                        str.AppendLine();
                    }
                }
                tmNum++;

            }




            string fileName = _savePath + "\\题目" + DateTime.Now.ToString("MMddHHMMsss") + ".txt";
            using (var sw = new StreamWriter(fileName, false))
            {
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();//写入

            }

            //输出答案
            if (this.checkBoxOutAnswer.Checked)
            {
                StringBuilder strAnswer = new StringBuilder();
                string fileNameAnswer = _savePath+ "\\题目" + DateTime.Now.ToString("MMddHHMMsss") + "(答案).txt";

                int amsNum = 1;
                foreach (var ans in answerStr)
                {

                    string appText = "(" + amsNum.ToString("D2") + ")   " + ans + "   ";
                    amsNum++;

                    strAnswer.Append(appText);
                    if (amsNum % 5 == 0 && amsNum != 1)
                    {
                        strAnswer.AppendLine();
                        strAnswer.AppendLine();
                    }

                }






                using (var swAnswer = new StreamWriter(fileNameAnswer, false))
                {
                    swAnswer.WriteLine(strAnswer);
                    swAnswer.Flush();
                    swAnswer.Close();//写入

                }

            }
            this.btnBuild.Enabled = true;
        }




        /// <summary>
        /// 产生一个随机数
        /// </summary>
        /// <returns></returns>
        private int GetRandom()
        {
            string[] ranText = this._lenght.Split("-");
            int startNum = int.Parse(ranText[0]);
            int endNum = int.Parse(ranText[1]);
            return new Random().Next(startNum, endNum);
        }

        private List<int> GetList()
        {

            //计算的数
            List<int> list = new List<int>();

            for (int k = 0; k < this._num + 1; k++)
            {
                list.Add(GetRandom());
            }

            return list;
        }



        private List<string> BlendMethod(string method)
        {
            List<string> result = new List<string>();
            var list = GetList();
            string calculationString = "";
            int index = 0;

            switch (method)
            {

                case "加法":
                    #region 加法
                    foreach (var item in list)
                    {
                        //最后一个
                        if (index == list.Count - 1)
                        {
                            index = 99;
                        }

                        switch (index)
                        {
                            case 0:
                                calculationString = item.ToString();
                                break;
                            case 99:
                                calculationString = calculationString + " + " + item.ToString() + " = ";
                                break;
                            default:
                                calculationString = calculationString + " + " + item.ToString();
                                break;

                        }
                        index++;
                    }
                    result.Add(list.Sum().ToString());
                    result.Add(calculationString);
                    #endregion
                    break;
                case "减法":
                    #region 减法
                    while (true)
                    {
                        if (this.checkBoxFixNegative.Checked)
                        {
                            list.Sort((x, y) => -x.CompareTo(y));
                        }
                        foreach (var item in list)
                        {

                            //最后一个
                            if (index == list.Count - 1)
                            {
                                index = 99;
                            }

                            switch (index)
                            {
                                case 0:
                                    calculationString = item.ToString();
                                    break;
                                case 99:
                                    calculationString = calculationString + " - " + item.ToString() + " = ";
                                    break;
                                default:
                                    calculationString = calculationString + " - " + item.ToString();
                                    break;

                            }
                            index++;

                        }

                        int computed = 0;
                        for (int y = 0; y < list.Count; y++)
                        {

                            if (y == 0)
                            {
                                computed = list[y];
                                continue;
                            }
                            computed = computed - list[y];

                        }
                        if (this.checkBoxFixNegative.Checked)
                        {
                            if (computed >= 0)
                            {
                                result.Add(computed.ToString());
                                result.Add(calculationString);
                                break;
                            }
                            list = GetList();
                            calculationString = "";
                            computed = 0;
                            index = 0;

                        }
                        else
                        {
                            result.Add(computed.ToString());
                            result.Add(calculationString);
                            break;

                        }

                    }
                    #endregion
                    break;
                case "乘法":
                    #region 乘法

                    foreach (var item in list)
                    {
                        //最后一个
                        if (index == list.Count - 1)
                        {
                            index = 99;
                        }

                        switch (index)
                        {
                            case 0:
                                calculationString = item.ToString();
                                break;
                            case 99:
                                calculationString = calculationString + " x " + item.ToString() + " = ";
                                break;
                            default:
                                calculationString = calculationString + " x " + item.ToString();
                                break;

                        }
                        index++;
                    }


                    int computedx = 0;
                    for (int y = 0; y < list.Count; y++)
                    {

                        if (y == 0)
                        {
                            computedx = list[y];
                            continue;
                        }
                        computedx = computedx * list[y];

                    }

                    result.Add(computedx.ToString());
                    result.Add(calculationString);

                    #endregion
                    break;
                case "除法":
                    #region 除法
                    //除法只有两位数
                    string answ = "";
                    while (true)
                    {

                        if (this.checkBoxFixNegative.Checked)
                        {
                            list.Sort((x, y) => -x.CompareTo(y));
                        }

                        //计算结果
                        decimal computedy = 0;
                        for (int y = 0; y < 2; y++)
                        {

                            if (y == 0)
                            {
                                computedy = list[y];
                                continue;
                            }
                            computedy = computedy / list[y];
                        }
                        if (computedy < 1)
                        {
                            continue;
                        }
                        answ = Math.Floor(Convert.ToDecimal(list[0] / list[1])).ToString();

                        if ((list[0] % list[1]) != 0)
                        {
                            answ = answ + " ... " + (list[0] % list[1]).ToString();
                        }

                        foreach (var item in list)
                        {
                            if (index > 1)
                            {
                                break;
                            }

                            switch (index)
                            {
                                case 0:
                                    calculationString = item.ToString();
                                    break;
                                case 1:
                                    calculationString = calculationString + " ÷ " + item.ToString() + " = ";
                                    break;
                                default:
                                    break;

                            }
                            index++;

                        }

                        result.Add(answ);
                        result.Add(calculationString);
                        break;
                    }
                    #endregion

                    break;
                default:
                    break;
            }


            return result;

        }



        /// <summary>
        /// 选择题目的长度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLenght_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._lenght = this.comboBoxLenght.Text;
        }



        /// <summary>
        /// 选择保存路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = System.Environment.SpecialFolder.Desktop;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtSavePath.Text = folderDialog.SelectedPath;
                this._savePath= folderDialog.SelectedPath;
            }

        }


        /// <summary>
        /// 选择运算符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._operator = this.comboBoxOperator.Text;
        }



        /// <summary>
        /// 多少个计算符号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._num = int.Parse(comboBoxNum.Text);
        }

        private void printPageSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}
