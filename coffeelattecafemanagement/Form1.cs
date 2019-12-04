using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace coffeelattecafemanagement
{
    
    public partial class Form1 : Form

    {
         
        public Form1()
        {
            
            InitializeComponent();
        }
       
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label16.Text = "0";
            label12.Text = "1.25";
            checkBox1.Checked = false;
            chkCafeMisto.Checked = false;
                chkCappuccino.Checked =false;
                    chkFlatWhite.Checked=false;
            chkCaramelBruleeLatte.Checked =false;
                chkEspresso.Checked =false;

                    chkMocha.Checked =false;
                        chkWhiteChocomocha.Checked=false;
                            chkEggSandwich.Checked =false;
                                chkHamSandwich.Checked=false;
                                    chkWrap.Checked =false;
                                        chkOatmeal.Checked =false;
                                            chkCheeseDanish.Checked =false;
                                                chkSnowmanCookie.Checked =false;
                                                    chkCranberryBar.Checked =false;
                                                    chkChocolatePop.Checked = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label16.Text = "0";
            label12.Text = "1.25";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            checkBox1.Checked = false;
            chkCafeMisto.Checked = false;
            chkCappuccino.Checked = false;
            chkFlatWhite.Checked = false;
            chkCaramelBruleeLatte.Checked = false;
            chkEspresso.Checked = false;

            chkMocha.Checked = false;
            chkWhiteChocomocha.Checked = false;
            chkEggSandwich.Checked = false;
            chkHamSandwich.Checked = false;
            chkWrap.Checked = false;
            chkOatmeal.Checked = false;
            chkCheeseDanish.Checked = false;
            chkSnowmanCookie.Checked = false;
            chkCranberryBar.Checked = false;
            chkChocolatePop.Checked = false;

            //date and time
            label18.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

           
           
         
            
            
         


        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;

            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();

        }

        private void chkCafeMisto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafeMisto.Checked == true)
            {
                textBox2.Enabled = true;

            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                textBox4.Enabled = true;

            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Focus();
        }

        private void chkFlatWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFlatWhite.Checked == true)
            {
                textBox3.Enabled = true;

            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void chkCaramelBruleeLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaramelBruleeLatte.Checked == true)
            {
                textBox6.Enabled = true;

            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Focus();
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                textBox5.Enabled = true;

            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.Focus();
        }

        private void chkMocha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMocha.Checked == true)
            {
                textBox8.Enabled = true;

            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox8.Focus();

        }

        private void chkWhiteChocomocha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhiteChocomocha.Checked== true)
            {
                textBox7.Enabled = true;

            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox7.Focus();
        }

        private void chkEggSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEggSandwich.Checked == true)
            {
                textBox16.Enabled = true;

            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
            textBox16.Focus();
        }

        private void chkHamSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHamSandwich.Checked== true)
            {
                textBox15.Enabled = true;

            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
            textBox15.Focus();
        }

        private void chkWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWrap.Checked == true)
            {
                textBox14.Enabled = true;

            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }

        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox14.Focus();
        }

        private void chkOatmeal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOatmeal.Checked == true)
            {
                textBox13.Enabled = true;

            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox13.Focus();
        }

        private void chkChocolatePop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolatePop.Checked == true)
            {
                textBox12.Enabled = true;

            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }

        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox12.Focus();
        }

        private void chkCranberryBar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCranberryBar.Checked == true)
            {
                textBox11.Enabled = true;

            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }

        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox11.Focus();
        }

        private void chkSnowmanCookie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSnowmanCookie.Checked == true)
            {
                textBox10.Enabled = true;

            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox10.Focus();
        }

        private void chkCheeseDanish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheeseDanish.Checked == true)
            {
                textBox9.Enabled = true;

            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox9.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("sanserif", 16, FontStyle.Regular), Brushes.Black, 180, 180);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Text Files(.*txt)|*.txt|All files(*.*)|*.*";
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(openfile.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Notepad Text";
            savefile.Filter = "Text Files(.*txt)|*.txt|All files(*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))
                    sw.WriteLine(richTextBox1.Text);

            }
        }

       

       
            
            


            

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double latte, cmisto, cappino, flat, caramel, espress, mo_cha, whtchoco, chocopop, cberry, sman, cheedan, eggsdwch, hamsad, spisadwch, otmeal;
            latte = 1.23; cmisto = 2.4; cappino = 3.5; flat = 1.5; caramel = 3.2; espress = 2.7; mo_cha = 5.6; whtchoco = 4.2; chocopop = 5; cberry = 3.4; eggsdwch = 3; hamsad = 2.5;
            spisadwch = 3.5; otmeal = 5.4; cheedan = 3.4; sman = 2.8;

            double tax;
            tax = .55;
            //costofcoffee-label6.text
            double caffelatte = Convert.ToDouble(textBox1.Text) ;
            double cafemisto = Convert.ToDouble(textBox2.Text) ;
            double cappachino = Convert.ToDouble(textBox4.Text);
            double flatwhite = Convert.ToDouble(textBox3.Text);
            double caramellatte = Convert.ToDouble(textBox6.Text);
            double espresso = Convert.ToDouble(textBox5.Text);
            double mocha = Convert.ToDouble(textBox8.Text);
            double whitechocolate = Convert.ToDouble(textBox7.Text);
            //cost of cake

            double chocolatepop = Convert.ToDouble(textBox12.Text);
            double canberry = Convert.ToDouble(textBox11.Text);
            double snowman = Convert.ToDouble(textBox10.Text);
            double cheesedanish = Convert.ToDouble(textBox9.Text);

            //cost of sandwich
            double eggsandwich = Convert.ToDouble(textBox16.Text);
            double hamsandwich = Convert.ToDouble(textBox15.Text);
            double spinach = Convert.ToDouble(textBox14.Text);
            double oatmeal = Convert.ToDouble(textBox13.Text);


            Cafe newcafe = new Cafe(caffelatte, cafemisto, cappachino, flatwhite, caramellatte, espresso, mocha, whitechocolate, chocolatepop, canberry, snowman, cheesedanish, eggsandwich, hamsandwich, spinach, oatmeal);


            double costofcofee = (caffelatte * latte) + cafemisto*cmisto + cappachino*cappino + flatwhite*flat + caramellatte*caramel + espresso*espress + mocha*mo_cha + whitechocolate*whtchoco;
            label6.Text = Convert.ToString(costofcofee);

            double costofcake = chocolatepop*chocopop + canberry*cberry + snowman*sman + cheesedanish*cheedan;
            label4.Text = Convert.ToString(costofcake);

            double costofsandwich = eggsandwich*eggsdwch + hamsandwich*hamsad + spinach*spisadwch + oatmeal*otmeal;
            label5.Text = Convert.ToString(costofsandwich);
            label10.Text = Convert.ToString(tax);


            double servicecharge = Convert.ToDouble(label12.Text);

            label11.Text = Convert.ToString(costofcofee + costofcake + costofsandwich);
            label10.Text = Convert.ToString(((costofcofee + costofcake + costofsandwich) * tax) / 100);
            double itax = Convert.ToDouble(label10.Text);
            label16.Text = Convert.ToString(costofcofee + costofcake + costofsandwich + itax + servicecharge);

            label6.Text = String.Format("{0:C}", costofcofee);
            label4.Text = String.Format("{0:C}",costofcake);
            label5.Text = String.Format("{0:C}",costofsandwich);
            label12.Text = String.Format("{0:C}", servicecharge);
            label11.Text = String.Format("{0:C}", costofcofee + costofcake + costofsandwich);
            label10.Text = String.Format("{0:C}", itax);
            label16.Text = String.Format("{0:C}", costofcofee + costofcake + costofsandwich + itax + servicecharge);
        }




             private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("\t\t\t" + "CaffeLatte" + Environment.NewLine);
            richTextBox1.AppendText("..................................................." + Environment.NewLine);

            if (checkBox1.Checked)
            {
                richTextBox1.AppendText("Caffee Americano \t\t\t\t\t"+textBox1.Text+"\t\t"+Environment.NewLine);
            }
           if (chkCafeMisto.Checked)
            {
                richTextBox1.AppendText("Caffee Misto \t\t\t\t\t"+textBox2.Text+"\t\t"+Environment.NewLine);
            }
              if (chkCappuccino.Checked)
            {
                richTextBox1.AppendText("Cappucino \t\t\t\t\t"+textBox4.Text+"\t\t"+Environment.NewLine);
            }
                if (chkFlatWhite.Checked)
            {
                richTextBox1.AppendText("Flat White \t\t\t\t\t"+textBox3.Text+"\t\t"+Environment.NewLine);
            }
                if (  chkCaramelBruleeLatte.Checked)
            {
                richTextBox1.AppendText("Caramel Bruelatte \t\t\t\t\t"+textBox6.Text+"\t\t"+Environment.NewLine);
            }
                 if (chkEspresso.Checked)
            {
                richTextBox1.AppendText("Espresso \t\t\t\t\t"+textBox5.Text+"\t\t"+Environment.NewLine);
            }
                 if (chkMocha.Checked)
            {
                richTextBox1.AppendText("Peppermint Chocomocha \t\t\t\t\t"+textBox8.Text+"\t\t"+Environment.NewLine);
            }
                  if (chkWhiteChocomocha.Checked )
            {
                richTextBox1.AppendText("White chocomocha\t\t\t\t\t"+textBox7.Text+"\t\t"+Environment.NewLine);
            }
                if (chkEggSandwich.Checked )
            {
                richTextBox1.AppendText("Eggsandwich \t\t\t\t\t"+textBox16.Text+"\t\t"+Environment.NewLine);
            }
              if (chkHamSandwich.Checked )
            {
                richTextBox1.AppendText("Caffee Americano \t\t\t\t\t"+textBox15.Text+"\t\t"+Environment.NewLine);
            }
             if (chkWrap.Checked )
            {
                richTextBox1.AppendText("Chicken wrap \t\t\t\t\t"+textBox14.Text+"\t\t"+Environment.NewLine);
            }
               if (chkOatmeal.Checked  )
            {
                richTextBox1.AppendText("Oatmeal \t\t\t\t\t\t"+textBox13.Text+"\t\t"+Environment.NewLine);
            }
              if (chkCheeseDanish.Checked)
            {
                richTextBox1.AppendText("Cheese Danish \t\t\t\t\t"+textBox12.Text+"\t\t"+Environment.NewLine);
            }
                if( chkSnowmanCookie.Checked )
            {
                richTextBox1.AppendText("Snowman Cookie \t\t\t\t\t"+textBox11.Text+"\t\t"+Environment.NewLine);
            }
                if (chkCranberryBar.Checked)
            {
                richTextBox1.AppendText("Cranberry \t\t\t\t\t"+textBox10.Text+"\t\t"+Environment.NewLine);
            }
                if( chkChocolatePop.Checked)
            {
                richTextBox1.AppendText("Chocolate pop \t\t\t\t\t"+textBox9.Text+"\t\t"+Environment.NewLine);
            }
                 richTextBox1.AppendText("........................................................."+Environment.NewLine);
                 richTextBox1.AppendText("Tax \t\t\t\t"+label10.Text+Environment.NewLine);

                 richTextBox1.AppendText("Subtotal \t\t\t\t"+label11.Text+Environment.NewLine);

                 richTextBox1.AppendText("Total \t\t\t\t"+label16.Text+Environment.NewLine);

                 richTextBox1.AppendText("........................................................."+Environment.NewLine);

                 richTextBox1.AppendText(label17.Text+ "\t\t"+label18.Text+Environment.NewLine);


                  
                  
                  
               
                    
          
                

                    
                            
                                 
                                        
                                                   
                                                    
        }

        }

        

       

        

       

        

       
    }

