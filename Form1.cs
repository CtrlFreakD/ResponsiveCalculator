using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string currentCalculation = "";
        Rectangle originalFormSize;
        Rectangle originalBtn0Size;
        Rectangle originalBtn1Size;
        Rectangle originalBtn2Size;
        Rectangle originalBtn3Size;
        Rectangle originalBtn4Size;
        Rectangle originalBtn5Size;
        Rectangle originalBtn6Size;
        Rectangle originalBtn7Size;
        Rectangle originalBtn8Size;
        Rectangle originalBtn9Size;
        Rectangle originalBtnLeftBracketSize;
        Rectangle originalBtnRightBracketSize;
        Rectangle originalBtnClearSize;
        Rectangle originalBtnBackspaceSize;
        Rectangle originalBtnDivSize;
        Rectangle originalBtnMultSize;
        Rectangle originalBtnAddSize;
        Rectangle originalBtnSubtractSize;
        Rectangle originalBtnPointSize;
        Rectangle originalBtnEqualSize;
        Rectangle originalTextResultSize;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString().Replace("x", "*");
            try
            {
                currentCalculation = new DataTable().Compute(formattedCalculation, null).ToString();
                TextResult.Text = currentCalculation;
            }
            catch (Exception ex)
            {
                currentCalculation = "";
                TextResult.Text = "0"+"\n"+ex.Message;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            currentCalculation = "";
            TextResult.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            TextResult.Text = currentCalculation;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            TextResult.Text = currentCalculation;
        }

        private void resizeControl(Rectangle r, Control c) 
        {
            if (originalFormSize.Width>0 && originalFormSize.Height>0) {
                float xRatio = (float)(this.Width / this.originalFormSize.Width);
                float yRatio = (float)(this.Height / this.originalFormSize.Height);
                int newX = (int)(xRatio * r.X);
                int newY = (int)(yRatio * r.Y);
                int newWidth = (int)(xRatio * r.Width);
                int newHeight = (int)(yRatio * r.Height);
                c.Location = new Point(newX, newY);
                c.Size = new Size(newWidth, newHeight);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(originalBtn0Size, btn0);
            resizeControl(originalBtn1Size, btn1);
            resizeControl(originalBtn2Size, btn2);
            resizeControl(originalBtn3Size, btn3);
            resizeControl(originalBtn4Size, btn4);
            resizeControl(originalBtn5Size, btn5);
            resizeControl(originalBtn6Size, btn6);
            resizeControl(originalBtn7Size, btn7);
            resizeControl(originalBtn8Size, btn8);
            resizeControl(originalBtn9Size, btn9);
            resizeControl(originalBtnLeftBracketSize, BtnLeftBracket);
            resizeControl(originalBtnRightBracketSize, BtnRightBracket);
            resizeControl(originalBtnClearSize, BtnClear);
            resizeControl(originalBtnBackspaceSize, btnBackspace);
            resizeControl(originalBtnDivSize, btnDiv);
            resizeControl(originalBtnMultSize, btnMult);
            resizeControl(originalBtnAddSize, btnAdd);
            resizeControl(originalBtnSubtractSize, btnSubtract);
            resizeControl(originalBtnPointSize, btnPoint);
            resizeControl(originalBtnEqualSize, btnEqual);
            resizeControl(originalTextResultSize, TextResult);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X,this.Location.Y,this.Size.Width,this.Size.Height);
            originalBtn0Size = new Rectangle(btn0.Location.X, btn0.Location.Y, btn0.Width, btn0.Height);
            originalBtn1Size = new Rectangle(btn1.Location.X,btn1.Location.Y,btn1.Width,btn1.Height);
            originalBtn2Size = new Rectangle(btn2.Location.X, btn2.Location.Y, btn2.Width, btn2.Height);
            originalBtn3Size = new Rectangle(btn3.Location.X, btn3.Location.Y, btn3.Width, btn3.Height);
            originalBtn4Size = new Rectangle(btn4.Location.X, btn4.Location.Y, btn4.Width, btn4.Height);
            originalBtn5Size = new Rectangle(btn5.Location.X, btn5.Location.Y, btn5.Width, btn5.Height);
            originalBtn6Size = new Rectangle(btn6.Location.X, btn6.Location.Y, btn6.Width, btn6.Height);
            originalBtn7Size = new Rectangle(btn7.Location.X, btn7.Location.Y, btn7.Width, btn7.Height);
            originalBtn8Size = new Rectangle(btn8.Location.X, btn8.Location.Y, btn8.Width, btn8.Height);
            originalBtn9Size = new Rectangle(btn9.Location.X, btn9.Location.Y, btn9.Width, btn9.Height);
            originalBtnLeftBracketSize = new Rectangle(BtnLeftBracket.Location.X, BtnLeftBracket.Location.Y, BtnLeftBracket.Width, BtnLeftBracket.Height);
            originalBtnRightBracketSize = new Rectangle(BtnRightBracket.Location.X, BtnRightBracket.Location.Y, BtnRightBracket.Width, BtnRightBracket.Height);
            originalBtnClearSize = new Rectangle(BtnClear.Location.X, BtnClear.Location.Y, BtnClear.Width, BtnClear.Height);
            originalBtnBackspaceSize = new Rectangle(btnBackspace.Location.X, btnBackspace.Location.Y, btnBackspace.Width, btnBackspace.Height);
            originalBtnDivSize = new Rectangle(btnDiv.Location.X, btnDiv.Location.Y, btnDiv.Width, btnDiv.Height);
            originalBtnMultSize = new Rectangle(btnMult.Location.X, btnMult.Location.Y, btnMult.Width, btnMult.Height);
            originalBtnAddSize = new Rectangle(btnAdd.Location.X, btnAdd.Location.Y, btnAdd.Width, btnAdd.Height);
            originalBtnSubtractSize = new Rectangle(btnSubtract.Location.X, btnSubtract.Location.Y, btnSubtract.Width, btnSubtract.Height);
            originalBtnPointSize = new Rectangle(btnPoint.Location.X, btnPoint.Location.Y, btnPoint.Width, btnPoint.Height);
            originalBtnEqualSize = new Rectangle(btnEqual.Location.X, btnEqual.Location.Y, btnEqual.Width, btnEqual.Height);
            originalTextResultSize = new Rectangle(TextResult.Location.X, TextResult.Location.Y, TextResult.Width, TextResult.Height);
        }
    }
}
