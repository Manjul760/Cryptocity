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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_crypto_city
{
    public partial class Form1 : Form
    {
        //declaring form !!!!!!!!!!DO NOT TOUCH!!!!!!!!!!
        public Form1(){InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e)
        {
            Algorithm.SelectedIndex = 0;
            Process.SelectedIndex = 0;
            for(int i = 2; i <9; i++)
            {
                Size_matrix.Items.Add(i.ToString());
            }
            Size_matrix.SelectedIndex= 0;
            Error_message.Text = (char)244 + "Error Message:";
            Row_x_index.SelectedIndex=1;
            Row_y_index.SelectedIndex=0;
            Column_x_index.SelectedIndex=0;
            Column_y_index.SelectedIndex=1;
            Diag_x_index.SelectedIndex=0;
            Diag_y_index.SelectedIndex=0;

        }
        //Globals for file
        private string File_input_text="";


        //flags 
        private bool Encript = true;
        private bool Hill_cipher_content_hidden = true;
        private bool Play_fair_content_hiddden=true;

        //encription decription classes
        private Hill_cipher Hill_Cipher = new Hill_cipher();
        private  Vernam_cipher Vernam_Cipher = new Vernam_cipher();
        private Caeser_cipher Caeser_Cipher = new Caeser_cipher();
        private Vignere_cipher Vignere_Cipher= new Vignere_cipher();
        private Rail_fence_cipher Rail_Fence_Cipher = new Rail_fence_cipher();
        private Play_fair_cipher Play_Fair_Cipher = new Play_fair_cipher();

        //designed for text need copy pastiing for file
        private void Encript_button_Click(object sender, EventArgs e)
        {
            if (Input_text.Text.Length <=3) {Error_message.Text= (char)244 + "Error: Enter atleast 3 input text"; return; }

            string text = "";
            if (Algorithm.Text == "Caeser Cipher") { text = Caeser_Cipher.Process(Input_text.Text, Encript); }
            else if (Algorithm.Text == "Vernam Cipher"){text = Vernam_Cipher.Process(Input_text.Text);}
            else if (Algorithm.Text == "Vignere Cipher"){text = Vignere_Cipher.Process(Input_text.Text, Encript);}
            else if (Algorithm.Text == "Hill Cipher"){text = Hill_Cipher.Process(Input_text.Text, Encript, Alternate_text.Checked);}
            else if (Algorithm.Text == "Rail Fence Cipher") { text = Rail_Fence_Cipher.Process(Input_text.Text,Encript); }
            else if (Algorithm.Text == "Play Fair Cipher") 
            {
                text = Play_Fair_Cipher.Process(
                    Input_text.Text, Encript,
                    int.Parse(Row_x_index.Text),int.Parse(Row_y_index.Text),
                    int.Parse(Column_x_index.Text),int.Parse(Column_y_index.Text),
                    int.Parse(Diag_x_index.Text),int.Parse(Diag_y_index.Text),
                    Alternate_diag_use.Checked
                    ); 
            }

            if (text.StartsWith((char)244 + "Error:")) { Error_message.Text = text; }
            else { Output_text.Text = text; }
        }
        private void Set_key_button_Click(object sender, EventArgs e)
        {
            if (Input_text.Text == "") { Error_message.Text = "Enter text first"; }

            string text;
            if (Algorithm.Text == "Hill Cipher")
            {
                text = Hill_Cipher.Set_key(Key.Text,Alternate_matrix.Checked);
                if (text.StartsWith(((char)244)+"Error:")) { Error_message.Text = text;return; }
                Key.Text = text; Error_message.Text = "Key set";return; 
            }
            else if(Algorithm.Text == "Play Fair Cipher")
            {
                text = Play_Fair_Cipher.Set_key(Key.Text);
                if (text.StartsWith(((char)244) + "Error:")) { Error_message.Text = text; return; }
                Key.Text = text; Error_message.Text = "Key set"; return;
            }
            else
            {
                Error_message.Text = "Key set";
            }

        }

        //on change generate output as well and pt filters according to need
        private void Input_text_TextChanged(object sender, EventArgs e)
        {
            if (Algorithm.Text == "Caeser Cipher" || Algorithm.Text == "Hill Cipher" || Algorithm.Text=="Vignere Cipher" || Algorithm.Text=="Rail Fence Cipher") 
            {
                Input_text.Text = Caeser_Cipher.Check_input_96(Input_text.Text); 
            }
            else if (Algorithm.Text == "Vernam Cipher" || Algorithm.Text=="Play Fair Cipher")
            {
                Input_text.Text = Vernam_Cipher.Check_input_64(Input_text.Text);
            }
            Input_text.SelectionStart = Input_text.TextLength;
        }

        //on change generate output as well and key filter according to need
        private void Key_TextChanged(object sender, EventArgs e)
        {
            if (Main_input_output.SelectedIndex == 1 && File_input_text.Length <= 3) { Key.Text = ""; Error_message.Text = "File not selected or file doesnt have sufficient length of text"; return; }
            else if (Main_input_output.SelectedIndex == 0 && Input_text.Text.Length<=3){ Key.Text = ""; Error_message.Text = "Please enter input text of length greater than 3 before setting key cause most algorithm require the plain text to set key";return;}

            string text="";
            if (Algorithm.Text == "Caeser Cipher") { text = Caeser_Cipher.Set_key(Key.Text); }
            else if (Algorithm.Text == "Hill Cipher") { text = Hill_Cipher.Check_input_96(Key.Text); }
            else if (Algorithm.Text == "Vernam Cipher"){ text = Vernam_Cipher.Set_key(Key.Text); }
            else if (Algorithm.Text == "Vignere Cipher") { text = Vignere_Cipher.Set_key(Key.Text); }
            else if (Algorithm.Text == "Rail Fence Cipher") 
            {
                if(Main_input_output.SelectedIndex==1){text = Rail_Fence_Cipher.Set_key(Key.Text, File_input_text);}
                else{text = Rail_Fence_Cipher.Set_key(Key.Text, Input_text.Text);}   
            }
            else if (Algorithm.Text == "Play Fair Cipher") { text = Play_Fair_Cipher.Check_input_64(Key.Text); }

            if (text.StartsWith((char)244 + "Error:")) { Error_message.Text = text; }

            Key.Text = text;
            Key.SelectionStart = Key.Text.Length;
        }

        //Generate random key according to algorithm
        private void Generate_key_Click(object sender, EventArgs e)
        {
            if (Main_input_output.SelectedIndex == 0 && Input_text.Text.Length <= 3) { Error_message.Text = (char)244 + "Error: Non empty input of length greater than 3 required! Because, most algorithm depend on input text to generate key";return; }
            if (Main_input_output.SelectedIndex==1 && File_input_text.Length <= 3) { Error_message.Text = "File not selected or file doesnt have sufficient length of text"; return; }
            
            if (Algorithm.Text == "Caeser Cipher") { Key.Text = Caeser_Cipher.Generate(); }
            else if (Algorithm.Text == "Vernam Cipher") 
            {
                if (Main_input_output.SelectedIndex==1) { Key.Text = Vernam_Cipher.Generate(File_input_text); }
                else { Key.Text = Vernam_Cipher.Generate(Input_text.Text); }
                
            }
            else if (Algorithm.Text == "Hill Cipher") { Key.Text = Hill_Cipher.Generate(int.Parse(Size_matrix.Text)); }
            else if (Algorithm.Text == "Vignere Cipher") 
            {
                if (Main_input_output.SelectedIndex==1) { Key.Text = Vignere_Cipher.Generate(File_input_text); }
                else { Key.Text = Vignere_Cipher.Generate(Input_text.Text); }
                 
            }
            else if (Algorithm.Text == "Rail Fence Cipher") 
            {
                if (Main_input_output.SelectedIndex==1) { Key.Text = Rail_Fence_Cipher.Generate(File_input_text); }
                else { Key.Text = Rail_Fence_Cipher.Generate(Input_text.Text); }
                
            }
            else if (Algorithm.Text == "Play Fair Cipher") { Key.Text = Play_Fair_Cipher.Generate(); }

            //Kepping cursor at end incase of editing
            Key.SelectionStart = Key.Text.Length;
            
            
        }

        //incase change of algorithm option
        private void Algorithm_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if(!Hill_cipher_content_hidden)
            {
                Key.MaxLength = default;
                Size_matrix.Hide();
                Alternate_text.Hide();
                Alternate_matrix.Hide();
                Hill_cipher_content_hidden = true;
            }

            if(!Play_fair_content_hiddden)
            {
                Rowxy.Hide();
                Columnxy.Hide();
                Diagxy.Hide();
                Row_x_index.Hide();
                Row_y_index.Hide();
                Column_x_index.Hide();
                Column_y_index.Hide();
                Diag_x_index.Hide();
                Diag_y_index.Hide();
                Alternate_diag_use.Hide();
                Play_fair_content_hiddden= true;
            }
            
            if (Algorithm.Text == "Caeser Cipher") 
            {
                Note.Text = "Only, numbers can be used as key. Chars used = 96";
                Caeser_Cipher = new Caeser_cipher(); 
            }
            else if (Algorithm.Text == "Vernam Cipher") 
            {
                Note.Text = "Anything can be used as key within the selected range of ascii. Chars used = 64";
                Vernam_Cipher = new Vernam_cipher(); 
            }
            else if (Algorithm.Text == "Vignere Cipher") 
            {
                Note.Text = "Typeable chars within selected range can be used as key. Chars used = 96";
                Vignere_Cipher = new Vignere_cipher(); 
            }
            else if (Algorithm.Text == "Rail Fence Cipher") 
            {
                Note.Text = "Only, numbers can be used as key within plaintext range. Chars used = 96";
                Rail_Fence_Cipher = new Rail_fence_cipher(); 
            }
            else if (Algorithm.Text == "Play Fair Cipher") 
            {
                Note.Text = "Typeable chars within selected range can be used as key. Chars used = 96. Please dont forget to set key after each change!! as it is not possible to set key during runtime";
                if (Play_fair_content_hiddden)
                {
                    Rowxy.Show();
                    Columnxy.Show();
                    Diagxy.Show();
                    Row_x_index.Show();
                    Row_y_index.Show();
                    Column_x_index.Show();
                    Column_y_index.Show();
                    Diag_x_index.Show();
                    Diag_y_index.Show();
                    Alternate_diag_use.Show();
                    Play_Fair_Cipher = new Play_fair_cipher();
                    Play_fair_content_hiddden=false;
                }
                 
            }
            else if (Algorithm.Text == "Hill Cipher") 
            {
                Note.Text = "Typeable chars within selected range can be used as key. Chars used = 96. Please dont forget to set key after each change!! as it is not possible to set key during runtime.";
                if (Hill_cipher_content_hidden)
                {
                    Key.MaxLength = (6*6);
                    Size_matrix.Show();
                    Alternate_text.Show();
                    Alternate_matrix.Show();
                    Hill_Cipher = new Hill_cipher();
                    Hill_cipher_content_hidden = false;
                }  
            }
            Clear_text();
            Input_text.Focus();
            Error_message.Text = (char)244 + "Error Message:"; 
        }


        //consistes of flag change clearing text shifting text and such
        //Doesnt Change much reguardless any action in form or change in algorithm so stays same
        private void Shift_text_Click(object sender, EventArgs e) { Input_text.Text = Output_text.Text; }
        private void Process_SelectedIndexChanged(object sender, EventArgs e){if (Process.Text == "Encript") { Encript = false; }else { Encript = true; }}
        private void Clear_input_text_Click(object sender, EventArgs e) { Clear_text(); }
        private void Clear_text(){ Input_text.Text = "";Key.Text = "";Output_text.Text = ""; }

        // for file inserted in last so is in last
        private void File_input_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog File_select = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (File_select.ShowDialog() == DialogResult.OK){Input_file_path.Text = File_select.FileName;}
            else{Input_file_path.Text = "";}

            if (Input_file_path.Text == "") { Error_message.Text = (char)244 + "Error: No File Detected!"; return; }

            File_process_details.Text = "Reading File";
            File_input_text =File.ReadAllText(Input_file_path.Text);
            File_process_details.Text = "Reading File complete";
        }
        private void File_output_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Folder_select = new FolderBrowserDialog();
            // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
            if (Folder_select.ShowDialog() == DialogResult.OK){Output_file_path.Text = Folder_select.SelectedPath;}
            else{Output_file_path.Text = "";}

            if (Output_file_path.Text == "") { Error_message.Text = (char)244 + "Error: No directory selected"; return; }
            File_process_details.Text = "Output path selected";
        }

        private void Generate_output_file_Click(object sender, EventArgs e)
        {

            if (Input_file_path.Text == "" || Output_file_path.Text == "") { Error_message.Text = (char)244 + "Error: Please choose file path to input and output text."; return; }

            File_process_details.Text = "Reading File";
            if (!File.Exists(Input_file_path.Text)) { File_process_details.Text = "No file to read";return; }
            File_input_text = File.ReadAllText(Input_file_path.Text);

            File_process_details.Text = "Filtering text";
            if (Algorithm.Text == "Caeser Cipher" || Algorithm.Text == "Hill Cipher" || Algorithm.Text == "Vignere Cipher" || Algorithm.Text == "Rail Fence Cipher")
            {
                File_input_text = Caeser_Cipher.Check_input_96(File_input_text);
            }
            else if (Algorithm.Text == "Vernam Cipher" || Algorithm.Text == "Play Fair Cipher")
            {
                File_input_text = Vernam_Cipher.Check_input_64(File_input_text);
            }

            if (File_input_text.Length <= 3) { Error_message.Text = (char)244 + "Error: Non empty input file of length greater than 3 required! Because, most algorithm depend on input text to generate key";return; }
            File_process_details.Text = "Performing selected process might take some time";
            string text = "";
            if (Algorithm.Text == "Caeser Cipher") { text = Caeser_Cipher.Process(File_input_text, Encript); }
            else if (Algorithm.Text == "Vernam Cipher") { text = Vernam_Cipher.Process(File_input_text); }
            else if (Algorithm.Text == "Vignere Cipher") { text = Vignere_Cipher.Process(File_input_text, Encript); }
            else if (Algorithm.Text == "Hill Cipher") { text = Hill_Cipher.Process(File_input_text, Encript, Alternate_text.Checked); }
            else if (Algorithm.Text == "Rail Fence Cipher") { text = Rail_Fence_Cipher.Process(File_input_text, Encript); }
            else if (Algorithm.Text == "Play Fair Cipher")
            {
                text = Play_Fair_Cipher.Process(
                    File_input_text, Encript,
                    int.Parse(Row_x_index.Text), int.Parse(Row_y_index.Text),
                    int.Parse(Column_x_index.Text), int.Parse(Column_y_index.Text),
                    int.Parse(Diag_x_index.Text), int.Parse(Diag_y_index.Text),
                    Alternate_diag_use.Checked
                    );
            }

            
            if (text.StartsWith((char)244 + "Error:")) { Error_message.Text = text;File_process_details.Text = "Error  occured!!";return; }
            else 
            {
                string output_file = Output_file_path.Text + "\\Output_crypto_city_" + Process.Text + ".txt";
                File_process_details.Text = "Selecting file to output";
                if (File.Exists(output_file)) 
                {
                    int i = 0;
                    output_file = Output_file_path.Text + "\\Output_crypto_city_"+Process.Text+i+".txt";
                    while (File.Exists(output_file)) { output_file = Output_file_path.Text + "\\Output_crypto_city_"+Process.Text+i+".txt"; i++; }
                }
                File_process_details.Text = "Writing in file: "+output_file;

                File.WriteAllText(output_file, text);
                File_process_details.Text = "Writing in file: " + output_file +" Complete!!. "+"Everything is reset";
                File_input_text = "";
                Input_file_path.Text = "";
                Output_file_path.Text = "";

            }
        }
    }
}
