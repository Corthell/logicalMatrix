
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace logicalMatrix
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<string[]> nazwyLogiczne;
		bool mode;
		
		
		public MainForm()
		{
			
//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			nazwyLogiczne = new List<string[]>();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			mode = true;

			nazwyLogiczne.Add(new string[7] {"p ⊕ q","Alternatywa wykluczająca", "0","1", "1", "0", "TAK: albo p albo q"});
			nazwyLogiczne.Add(new string[7] {"~p", "Negacja", "0","0", "1", "1", "nie p"});
			nazwyLogiczne.Add(new string[7] {"p ˅ q", "Alternatywa", "1", "1", "1", "0", "TAK: jeśli p albo q"});
			nazwyLogiczne.Add(new string[7] {"p | q", "Dysjunkcja", "0", "1", "1", "1", "NIE: jak p i q"});
			nazwyLogiczne.Add(new string[7] {"p ⇒ q", "Implikacja", "1", "0", "1", "1", "NIE: jeśli p a q nie"});
			nazwyLogiczne.Add(new string[7] {"p ↓ q", "Binegacja", "0", "0", "0", "1", "TAK: ani p ani q"});
			nazwyLogiczne.Add(new string[7] {"p ⇔ q", "Równoważność", "1", "0", "0", "1", "TAK: p = q"});
			nazwyLogiczne.Add(new string[7] {"p ˄ q", "Koniunkcja", "1", "0", "0", "0", "TAK: i p i q"});

            toolStripStatusLabel1.Text = "                                                                                                 WSZIB [ 20151k132 group ] RuleZ ;)";
			
            comboBox9.Visible = comboBox10.Visible = comboBox11.Visible = comboBox12.Visible =
        	comboBox13.Visible = comboBox14.Visible = comboBox15.Visible = comboBox16.Visible = false;

            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            groupBox7.Enabled = false;

            label17.Visible = label18.Visible = label19.Visible = label20.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mode = true;

            groupBox3.Enabled = true;
            groupBox5.Enabled = true;
            groupBox7.Enabled = true;

            label17.Visible = label18.Visible = label19.Visible = label20.Visible = true;

            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text =
            comboBox5.Text = comboBox6.Text = comboBox7.Text = comboBox8.Text = "";

            comboBox9.Visible = comboBox10.Visible = comboBox11.Visible = comboBox12.Visible =
            comboBox13.Visible = comboBox14.Visible = comboBox15.Visible = comboBox16.Visible = false;

            label1.Visible = label2.Visible = label3.Visible = label4.Visible =
            label5.Visible = label6.Visible = label7.Visible = label8.Visible = true;

            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text =
            button7.Text = button8.Text = "Sprawdź";

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text =
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox16.Text =
            textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text =
            textBox17.Text = textBox18.Text = textBox19.Text = textBox20.Text = textBox21.Text =
            textBox22.Text = textBox23.Text = textBox24.Text = textBox25.Text = textBox26.Text =
            textBox27.Text = textBox28.Text = textBox29.Text = textBox30.Text = textBox31.Text =
            textBox32.Text = "";

            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text =
            button7.Text = button8.Text = "Sprawdź";

            comboBox1.SelectedItem = "";

            if (checkBox2.Checked)
            {
                RandomNoRep listaIndexow = new RandomNoRep(8);

                label1.Text = nazwyLogiczne[listaIndexow.zwrocIndex(0)][0];
                label2.Text = nazwyLogiczne[listaIndexow.zwrocIndex(1)][0];
                label3.Text = nazwyLogiczne[listaIndexow.zwrocIndex(2)][0];
                label4.Text = nazwyLogiczne[listaIndexow.zwrocIndex(3)][0];
                label5.Text = nazwyLogiczne[listaIndexow.zwrocIndex(4)][0];
                label6.Text = nazwyLogiczne[listaIndexow.zwrocIndex(5)][0];
                label7.Text = nazwyLogiczne[listaIndexow.zwrocIndex(6)][0];
                label8.Text = nazwyLogiczne[listaIndexow.zwrocIndex(7)][0];
            }
            else
            {
                Random randomizer = new Random();

                label1.Text = nazwyLogiczne[randomizer.Next(7)][0];
                label2.Text = nazwyLogiczne[randomizer.Next(7)][0];
                label3.Text = nazwyLogiczne[randomizer.Next(7)][0];
                label4.Text = nazwyLogiczne[randomizer.Next(7)][0];
                label5.Text = nazwyLogiczne[randomizer.Next(7)][0];
                label6.Text = nazwyLogiczne[randomizer.Next(7)][0];
                label7.Text = nazwyLogiczne[randomizer.Next(7)][0];
                label8.Text = nazwyLogiczne[randomizer.Next(7)][0];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
        	mode = false;

            groupBox3.Enabled = true;
            groupBox5.Enabled = true;
            groupBox7.Enabled = true;

            label17.Visible = label18.Visible = label19.Visible = label20.Visible = true;

            comboBox9.Visible = comboBox10.Visible = comboBox11.Visible = comboBox12.Visible =
        	comboBox13.Visible = comboBox14.Visible = comboBox15.Visible = comboBox16.Visible = true;

			comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text =
        	comboBox5.Text = comboBox6.Text = comboBox7.Text = comboBox8.Text =
        	comboBox9.Text = comboBox10.Text = comboBox11.Text = comboBox12.Text =
        	comboBox13.Text = comboBox14.Text = comboBox15.Text = comboBox16.Text = "";      	
        	
        	label1.Visible = label2.Visible = label3.Visible = label4.Visible =
        	label5.Visible = label6.Visible = label7.Visible = label8.Visible = false;
        	
        	button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text =
            button7.Text = button8.Text = "Sprawdź";
        	
        	if(checkBox2.Checked)
            {
                RandomNoRep listaIndexow = new RandomNoRep(8);

                textBox1.Text = nazwyLogiczne[listaIndexow.zwrocIndex(0)][2];
                textBox2.Text = nazwyLogiczne[listaIndexow.zwrocIndex(0)][3];
                textBox3.Text = nazwyLogiczne[listaIndexow.zwrocIndex(0)][4];
                textBox4.Text = nazwyLogiczne[listaIndexow.zwrocIndex(0)][5];

                textBox5.Text = nazwyLogiczne[listaIndexow.zwrocIndex(1)][2];
                textBox6.Text = nazwyLogiczne[listaIndexow.zwrocIndex(1)][3];
                textBox7.Text = nazwyLogiczne[listaIndexow.zwrocIndex(1)][4];
                textBox8.Text = nazwyLogiczne[listaIndexow.zwrocIndex(1)][5];

                textBox9.Text = nazwyLogiczne[listaIndexow.zwrocIndex(2)][2];
                textBox10.Text = nazwyLogiczne[listaIndexow.zwrocIndex(2)][3];
                textBox11.Text = nazwyLogiczne[listaIndexow.zwrocIndex(2)][4];
                textBox12.Text = nazwyLogiczne[listaIndexow.zwrocIndex(2)][5];

                textBox13.Text = nazwyLogiczne[listaIndexow.zwrocIndex(3)][2];
                textBox14.Text = nazwyLogiczne[listaIndexow.zwrocIndex(3)][3];
                textBox15.Text = nazwyLogiczne[listaIndexow.zwrocIndex(3)][4];
                textBox16.Text = nazwyLogiczne[listaIndexow.zwrocIndex(3)][5];

                textBox17.Text = nazwyLogiczne[listaIndexow.zwrocIndex(4)][2];
                textBox18.Text = nazwyLogiczne[listaIndexow.zwrocIndex(4)][3];
                textBox19.Text = nazwyLogiczne[listaIndexow.zwrocIndex(4)][4];
                textBox20.Text = nazwyLogiczne[listaIndexow.zwrocIndex(4)][5];

                textBox21.Text = nazwyLogiczne[listaIndexow.zwrocIndex(5)][2];
                textBox22.Text = nazwyLogiczne[listaIndexow.zwrocIndex(5)][3];
                textBox23.Text = nazwyLogiczne[listaIndexow.zwrocIndex(5)][4];
                textBox24.Text = nazwyLogiczne[listaIndexow.zwrocIndex(5)][5];

                textBox25.Text = nazwyLogiczne[listaIndexow.zwrocIndex(6)][2];
                textBox26.Text = nazwyLogiczne[listaIndexow.zwrocIndex(6)][3];
                textBox27.Text = nazwyLogiczne[listaIndexow.zwrocIndex(6)][4];
                textBox28.Text = nazwyLogiczne[listaIndexow.zwrocIndex(6)][5];

                textBox29.Text = nazwyLogiczne[listaIndexow.zwrocIndex(7)][2];
                textBox30.Text = nazwyLogiczne[listaIndexow.zwrocIndex(7)][3];
                textBox31.Text = nazwyLogiczne[listaIndexow.zwrocIndex(7)][4];
                textBox32.Text = nazwyLogiczne[listaIndexow.zwrocIndex(7)][5];
            }
            else
            {
                Random randomizer = new Random();
                int count = randomizer.Next(7);

                textBox1.Text = nazwyLogiczne[count][2];
                textBox2.Text = nazwyLogiczne[count][3];
                textBox3.Text = nazwyLogiczne[count][4];
                textBox4.Text = nazwyLogiczne[count][5];

                count = randomizer.Next(7);

                textBox5.Text = nazwyLogiczne[count][2];
                textBox6.Text = nazwyLogiczne[count][3];
                textBox7.Text = nazwyLogiczne[count][4];
                textBox8.Text = nazwyLogiczne[count][5];

                count = randomizer.Next(7);

                textBox9.Text = nazwyLogiczne[count][2];
                textBox10.Text = nazwyLogiczne[count][3];
                textBox11.Text = nazwyLogiczne[count][4];
                textBox12.Text = nazwyLogiczne[count][5];

                count = randomizer.Next(8);

                textBox13.Text = nazwyLogiczne[count][2];
                textBox14.Text = nazwyLogiczne[count][3];
                textBox15.Text = nazwyLogiczne[count][4];
                textBox16.Text = nazwyLogiczne[count][5];

                count = randomizer.Next(7);

                textBox17.Text = nazwyLogiczne[count][2];
                textBox18.Text = nazwyLogiczne[count][3];
                textBox19.Text = nazwyLogiczne[count][4];
                textBox20.Text = nazwyLogiczne[count][5];

                count = randomizer.Next(8);

                textBox21.Text = nazwyLogiczne[count][2];
                textBox22.Text = nazwyLogiczne[count][3];
                textBox23.Text = nazwyLogiczne[count][4];
                textBox24.Text = nazwyLogiczne[count][5];

                count = randomizer.Next(7);

                textBox25.Text = nazwyLogiczne[count][2];
                textBox26.Text = nazwyLogiczne[count][3];
                textBox27.Text = nazwyLogiczne[count][4];
                textBox28.Text = nazwyLogiczne[count][5];

                count = randomizer.Next(7);

                textBox29.Text = nazwyLogiczne[count][2];
                textBox30.Text = nazwyLogiczne[count][3];
                textBox31.Text = nazwyLogiczne[count][4];
                textBox32.Text = nazwyLogiczne[count][5];
            }
        	
        }

        private void button1_Click(object sender, EventArgs e)
        {
        	string wartosci = "";
	        string wartosci_matrix = "";
        	
        	if(mode)
        	{
	            for (int i = 0; i < 8; i++)
	            {
	                if (label1.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;
						wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	                    
	                    if (comboBox1.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button1.Text = "DOBRZE";
	                        
	                         if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    else
	                    {
	                        button1.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
        	}
        	else
        	{
        		wartosci = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
	                    if (comboBox1.SelectedItem == nazwyLogiczne[i][1] && comboBox9.SelectedItem == nazwyLogiczne[i][0] )
	                    {
	                        button1.Text = "DOBRZE";
	                        
	                         if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
	                    else
	                    {
	                        button1.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
        	}
        	
        	checkBox1.Checked = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        	string wartosci = "";
	        string wartosci_matrix = "";
        	
        	if(mode)
        	{
	            for (int i = 0; i < 8; i++)
	            {
	                if (label2.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text;
	                    wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	
	                    if (comboBox2.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button2.Text = "DOBRZE";
	                        
	                         if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
	                    else
	                    {
	                        button2.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
        	}
        	else
        	{
        		wartosci = textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
                        if (comboBox2.SelectedItem == nazwyLogiczne[i][1] && comboBox10.SelectedItem == nazwyLogiczne[i][0])
                        {
                            button2.Text = "DOBRZE";

                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }

                        else
                        {
                            button2.Text = "ŹLE";

                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    break;
	                }
	            }
        	}
        	
        	checkBox1.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string wartosci = "";
            string wartosci_matrix = "";

            if(mode)
            {
	            for (int i = 0; i < 8; i++)
	            {
	                if (label3.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox9.Text + textBox10.Text + textBox11.Text + textBox12.Text;
	                    wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	
	                    if (comboBox3.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button3.Text = "DOBRZE";
	                        
	                         if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
                        else
	                    {
	                        button3.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            else
            {
            	wartosci = textBox9.Text + textBox10.Text + textBox11.Text + textBox12.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
	                    if (comboBox3.SelectedItem == nazwyLogiczne[i][1] && comboBox11.SelectedItem == nazwyLogiczne[i][0] )
	                    {
	                        button3.Text = "DOBRZE";
	                        
	                         if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
                        else
	                    {
	                        button3.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            
            checkBox1.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string wartosci = "";
            string wartosci_matrix = "";

            if(mode)
            {
            	for (int i = 0; i < 8; i++)
            	{
	                if (label4.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox13.Text + textBox14.Text + textBox15.Text + textBox16.Text;
	                    wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	
	                    if (comboBox4.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button4.Text = "DOBRZE";
	                        
	                         if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
	                    else
	                    {
	                        button4.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            else
            {
            	wartosci = textBox13.Text + textBox14.Text + textBox15.Text + textBox16.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
	                    if (comboBox4.SelectedItem == nazwyLogiczne[i][1] && comboBox12.SelectedItem == nazwyLogiczne[i][0] )
	                    {
	                        button4.Text = "DOBRZE";
	                        
	                         if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
	                    else
	                    {
	                        button4.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            
            checkBox1.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string wartosci = "";
            string wartosci_matrix = "";

            if(mode)
            {
            	for (int i = 0; i < 8; i++)
            	{
	                if (label5.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox17.Text + textBox18.Text + textBox19.Text + textBox20.Text;
	                    wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	
	                    if (comboBox5.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button5.Text = "DOBRZE";
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
	                    else
	                    {
	                        button5.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            else
            {
            	wartosci = textBox17.Text + textBox18.Text + textBox19.Text + textBox20.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
	                    if (comboBox5.SelectedItem == nazwyLogiczne[i][1] && comboBox13.SelectedItem == nazwyLogiczne[i][0] )
	                    {
	                        button5.Text = "DOBRZE";
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");

                        }
	                    else
	                    {
	                        button5.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            
            checkBox1.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string wartosci = "";
            string wartosci_matrix = "";
			
            if(mode)
            {
            	for (int i = 0; i < 8; i++)
            	{
	                if (label6.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox21.Text + textBox22.Text + textBox23.Text + textBox24.Text;
	                    wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	
	                    if (comboBox6.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button6.Text = "DOBRZE";
                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    else
	                    {
	                        button6.Text = "ŹLE";
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    break;
	                }
	
	            }
            }
            else
            {
            	wartosci = textBox21.Text + textBox22.Text + textBox23.Text + textBox24.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
	                    if (comboBox6.SelectedItem == nazwyLogiczne[i][1] && comboBox14.SelectedItem == nazwyLogiczne[i][0] )
	                    {
	                        button6.Text = "DOBRZE";
                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    else
	                    {
	                        button6.Text = "ŹLE";
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            
            checkBox1.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string wartosci = "";
            string wartosci_matrix = "";

            if(mode)
            {
            	for (int i = 0; i < 8; i++)
            	{
	                if (label7.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox25.Text + textBox26.Text + textBox27.Text + textBox28.Text;
	                    wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	
	                    if (comboBox7.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button7.Text = "DOBRZE";
                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    else
	                    {
	                        button7.Text = "ŹLE";
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            else
            {
            	wartosci = textBox25.Text + textBox26.Text + textBox27.Text + textBox28.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
	                    if (comboBox7.SelectedItem == nazwyLogiczne[i][1] && comboBox15.SelectedItem == nazwyLogiczne[i][0] )
	                    {
	                        button7.Text = "DOBRZE";
                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    else
	                    {
	                        button7.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            
            checkBox1.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string wartosci = "";
            string wartosci_matrix = "";

            if(mode)
            {
            	for (int i = 0; i < 8; i++)
            	{
	                if (label8.Text == nazwyLogiczne[i][0])
	                {
	                    wartosci = textBox29.Text + textBox30.Text + textBox31.Text + textBox32.Text;
	                    wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
	
	                    if (comboBox8.SelectedItem == nazwyLogiczne[i][1] && wartosci == wartosci_matrix)
	                    {
	                        button8.Text = "DOBRZE";
                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    else
	                    {
	                        button8.Text = "ŹLE";
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            else
            {
            	wartosci = textBox29.Text + textBox30.Text + textBox31.Text + textBox32.Text;
        		
        		for (int i = 0; i < 8; i++)
	            {
					wartosci_matrix = nazwyLogiczne[i][2] + nazwyLogiczne[i][3] + nazwyLogiczne[i][4] + nazwyLogiczne[i][5];
        			
        			if (wartosci == wartosci_matrix)
	                {
	                    if (comboBox8.SelectedItem == nazwyLogiczne[i][1] && comboBox16.SelectedItem == nazwyLogiczne[i][0] )
	                    {
	                        button8.Text = "DOBRZE";
                            if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
                        }
	                    else
	                    {
	                        button8.Text = "ŹLE";
	
	                        if (checkBox1.Checked) MessageBox.Show("Odpowiedź to:   " + nazwyLogiczne[i][1] + " , " + wartosci_matrix + "\n\nOpis: [ " + nazwyLogiczne[i][6] + " ]");
	                    }
	                    break;
	                }
	            }
            }
            
            checkBox1.Checked = false;
        }    
		
		void ZakończToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void OProgramieToolStripMenuItemClick(object sender, EventArgs e)
		{
			About about = new About();
			about.Show();
		}
    }
}
