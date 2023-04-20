using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            txtData.Text = sr.ReadToEnd();
            string data = txtData.Text.ToString();
            string[] subtokens = data.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries); // Chia dữ liệu thành từng phần riêng khi gặp xuống dòng
            foreach (string subtoken in subtokens)
            {
                txtDataKQ.Text += " ";

                string[] tokens = subtoken.Split(' ');
                Stack<double> numbers = new Stack<double>();
                Stack<char> operators = new Stack<char>();
                foreach (string token in tokens)
                {
                    if (double.TryParse(token, out double num))
                    {
                        numbers.Push(num);
                    }
                    else if (token == "(")
                    {
                        operators.Push(token[0]);
                    }
                    else if (token == ")" && operators.Count > 0)
                    {
                        while (operators.Peek() != '(')
                        {
                            char op = operators.Pop();
                            double num2 = numbers.Pop();
                            double num1 = numbers.Pop();
                            double result = PerformOperation(op, num1, num2);
                            numbers.Push(result);
                        }
                        operators.Pop();
                    }
                    else if (IsOperator(token))
                    {
                        while (operators.Count > 0 && IsOperator(operators.Peek().ToString()) && GetPrecedence(token) <= GetPrecedence(operators.Peek().ToString()))
                        {
                            char op = operators.Pop();
                            double num2 = numbers.Pop();
                            double num1 = numbers.Pop();
                            double result = PerformOperation(op, num1, num2);
                            numbers.Push(result);
                        }
                        operators.Push(token[0]);
                    }
                }

                while (operators.Count > 0)
                {
                    char op = operators.Pop();
                    double num2 = numbers.Pop();
                    double num1 = numbers.Pop();
                    double result = PerformOperation(op, num1, num2);
                    numbers.Push(result);
                }

                if (numbers.Count > 0)
                {
                    double finalResult = numbers.Pop();
                    txtDataKQ.Text += subtoken.ToString() + " = " + finalResult.ToString() + "\r\n";
                }
            }
        }

        bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        int GetPrecedence(string token)
        {
            switch (token)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }

        double PerformOperation(char op, double num1, double num2)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return 0;
            }
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.ShowDialog();
            try
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    string a = txtDataKQ.Text;
                    writer.WriteLine(a);
                }
                MessageBox.Show("Bạn tạo file Output thành công ", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập tên file", "Thông báo");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
