using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_crypto_city
{
    class Necessesities
    {
        protected int Pow(int a,int b) { int ans = 1;for(int i = 0; i < b; i++) { ans *= a; } return ans; }
        protected int Mod(int a, int b) { while (a < b) { a += b; } return a % b; }

        //for 96 chars filter
        protected int Char_to_ascii_96(char c)
        {
            if ((int)c == 10) { return 0; }
            else if ((int)c >= 32 && (int)c <= 126) { return (int)c - 31; }
            else { return Mod((int)c, 96); }
        }
        protected string Ascii_to_char_96(int a)
        {
            if (a == 0) { return "\r\n"; }
            else { return ((char)(a + 31)).ToString(); }
        }

        //for 64 chars filter
        protected int Char_to_ascii_64(char c)
        {
            if ((int)c == 10) { return 0; }
            else if ((int)c >= 32 && (int)c <= 91) { return (int)c - 31; }
            else if ((int)c >= 93 && (int)c <= 95) { return (int)c - 93 + 61; }
            else { return Mod((int)c, 64); }
        }
        protected string Ascii_to_char_64(int c)
        {
            if (c == 0) { return "\r\n"; }
            else if (c >= 1 && c <= 60) { return ((char)(c + 31)).ToString(); }
            else if ((int)c >= 61 && (int)c <= 63) { return ((char)(c - 61 + 93)).ToString(); }
            else { return ((char)Mod(c, 64)).ToString(); }
        }

        protected string Remove_Enter(string input)
        {
            string output = "";
            for(int i = 0;i<input.Length;i++)
            {
                if (input[i] == '\r') { continue; }
                output += input[i];
            }
            return output;
        }

        public virtual string Check_input_96(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\r') { continue; }
                output += Ascii_to_char_96(Char_to_ascii_96(input[i]));
            }
            return output;
        }

        public string Check_input_64(string input)
        {
            string output = "";
            input = Remove_Enter(input.ToUpper());
            for (int i = 0; i < input.Length; i++)
            {
                output += Ascii_to_char_64(Char_to_ascii_64(input[i]));
            }
            return output;
        }

        protected int[,] Cofactor(int[,] a, int row_ignore,int column_ignore)
        {
            int[,] cofactor = new int[a.GetLength(0) - 1, a.GetLength(1) - 1];
            int row = -1,column= 0;
            for(int i=0;i<a.GetLength(0);i++)
            {
                
                if(i!=row_ignore)
                {
                    row++;
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if(j!=column_ignore)
                        {
                            cofactor[row,column] = a[i,j];
                            column++;
                        }
                    }
                    column = 0;
                }   
            }
            return cofactor;
        }

        protected int[,] Multiply(int[,] a, int[,]b)
        {
            int[,] output = new int[a.GetLength(0), a.GetLength(1)];
            for (int i =0;i<a.GetLength(0);i++)
            {
                for(int j =0;j<a.GetLength(1);j++)
                {
                    for(int k = 0;k<b.GetLength(0);k++)
                    {
                        output[i,j] += a[i, k] * b[k,j];
                    }
                }
            }
            return output;
        }
        
        protected int Determinant(int[,]a,int b=0)
        {
            if(b<=1)
            {
                if (a.GetLength(0) == 2) { return a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0]; }
                else if (a.GetLength(0) == 1) { return a[0, 0]; }
                else if ((a.GetLength(0) == 0)) { return 0; }

                int sum = 0;
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    sum += a[0, i] * Pow(-1, i) * Determinant(Cofactor(a, 0, i));
                }
                return sum;
            }
            else
            {
                if (a.GetLength(0) == 2) { return Mod(Mod(a[0, 0] * a[1, 1],b)+ Mod(- a[0, 1] * a[1, 0],b),b); }
                else if (a.GetLength(0) == 1) { return a[0, 0]; }
                else if ((a.GetLength(0) == 0)) { return 0; }

                int sum = 0;
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    sum += Mod(a[0, i] * Pow(-1, i) * Determinant(Cofactor(a, 0, i),b),b);
                    sum = Mod(sum,b);
                }
                return sum;
            }
        }

        protected bool Has_modulic_inverse(int a,int b)
        {
            if (a == 0) { return false; }
            int c;
            while (b>1) { c = Mod(a, b);a = b;b = c; }

            if (b == 1) { return true; }
            else { return false; }
        }

        protected int Modulic_inv(int a,int b)
        {
            a = Mod(a, b);
            for(int i = 0; i < b; i++) { if (Mod(a * i, b) == 1) { return i; } }
            return 0;
        }

        protected int[,] Int_inverse(int[,]a,int b)
        {
            int d = Determinant(a,b);
            int mod_inv = Modulic_inv(d, b);
            int [,]output = new int[a.GetLength(0),a.GetLength(1)];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    output[j, i] = Pow(-1, i + j) * mod_inv * Determinant(Cofactor(a, i, j),b);
                }
            }
            return output;
        }

    }



    class Caeser_cipher:Necessesities
    {
        private int Key=0;
        public string Process(string input,bool encript=true)
        {
            int ed = 1;
            string output = "";
            if (!encript) { ed = -1; }
            input = Remove_Enter(input);
            for(int i=0;i<input.Length;i++) 
            {
                output+= Ascii_to_char_96(Mod(Char_to_ascii_96(input[i])+Key*ed,96));
            }
            return output;
        }

        public string Set_key(string input)
        {
            input = Remove_Enter(input);
            if (input == "") { Key = 0;return input; }
            try{ Key=int.Parse(input);return Mod(Key,96).ToString();}
            catch (Exception) { Key = Char_to_ascii_96(input[0]);return Key.ToString(); }
        }
        public string Generate()
        {
            Key = new Random(Guid.NewGuid().GetHashCode()).Next(0,95);
            return Key.ToString();
        }

    }

    class Vernam_cipher:Necessesities
    {
        private string Key = "";

        public string Set_key(string input)
        {
            Key = "";
            input=Remove_Enter(input.ToUpper());
            for (int i = 0; i < input.Length; i++)
            {
                Key += Ascii_to_char_64(Char_to_ascii_64(input[i]));
            }
            return Key;
        }
        public string Process(string input)
        {
            if (Key.Length == 0 || input.Length==0) { return (char)244 + "Error: Set key and plain text first"; }
            input=input.ToUpper();
            input = Remove_Enter(input);
            string Key_use= Remove_Enter(Key), output = "";
            for(int i=0;i<input.Length;i++)
            {
                output+= Ascii_to_char_64(Char_to_ascii_64(input[i]) ^ Char_to_ascii_64(Key_use[Mod(i,Key_use.Length)]));
            }
            return output;
        }

        public string Generate(string input)
        {
            if(input.Length== 0) { return input; }

            Key = "";
            for(int i = 0; i <input.Length;i++)
            {
                Key += Ascii_to_char_64(new Random(Guid.NewGuid().GetHashCode()).Next(0, 63));
            }   
            return Key;
        }

        
    }

    class Hill_cipher:Necessesities
    {
        private int[,] Key = new int[0, 0];
        private bool key_set = false;

        public string Set_key(string input,bool alternative)
        {
            if (input.Length<=2) { key_set=false; return (char)244 + "Error: length key must be greater than 2"; }
            string input_use = Remove_Enter(input);
            key_set = false;
            int dimension = (int)Math.Ceiling(Math.Sqrt(input_use.Length)),inc=0;
            Key = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if(alternative){Key[j, i] = Char_to_ascii_96(input_use[Mod(inc, input_use.Length)]);inc++;}
                    else{Key[i, j] = Char_to_ascii_96(input_use[Mod(inc, input_use.Length)]);inc++;}   
                }
            }
            if(Has_modulic_inverse(96, Mod(Determinant(Key), 96))) {key_set=true;}
            else { return (char)244 + "Error: no modulus inverse exist"; }

            return input;
        }

        public string Generate(int l)
        {
            Key = new int[l, l];
            string output="";
            while(!Has_modulic_inverse(96,Mod(Determinant(Key),96)))
            {
                output = "";
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        Key[i, j] = new Random(Guid.NewGuid().GetHashCode()).Next(0, 95);
                        output += Ascii_to_char_96(Key[i, j]);
                    }
                }
            }
            key_set=true;
            return output;
        }

        public string Process(string input,bool encript,bool Alternative_plaintext)
        {
            if (!key_set) { return (char)244 + "Error: Set Key first"; }

            input = Remove_Enter(input);
            int n = (int)Math.Ceiling((double)input.Length / (double)Key.GetLength(0)),inc=0;
            int[,] pt = new int[n, Key.GetLength(0)];

            string output = "";
            if (Alternative_plaintext)
            {
                for(int i=0;i<Key.GetLength(0);i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        pt[j, i] = Char_to_ascii_96(input[Mod(inc,input.Length)]);
                        inc++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < Key.GetLength(0); j++)
                    {
                        pt[i, j] = Char_to_ascii_96(input[Mod(inc, input.Length)]);
                        inc++;
                    }
                }
            }

            int[,] ct;
            if (encript) { ct = Multiply(pt, Key); }
            else { ct = Multiply(pt, Int_inverse(Key, 96)); }

            if (Alternative_plaintext)
            {
                for (int i = 0; i < Key.GetLength(0); i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        output += Ascii_to_char_96(Mod(ct[j, i], 96));
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < Key.GetLength(0); j++)
                    {
                        output += Ascii_to_char_96(Mod(ct[i, j], 96));
                    }
                }
            }
            return output;
        }
    }

    class Vignere_cipher:Necessesities
    {
        private string Key = "";

        public string Set_key(string input)
        {
            Key = "";
            input = Remove_Enter(input.ToUpper());
            for (int i = 0; i < input.Length; i++)
            {
                Key += Ascii_to_char_96(Char_to_ascii_96(input[i]));
            }
            return Key;
        }

        public string Process(string input,bool encript)
        {
            if (Key.Length == 0 || input.Length == 0) { return (char)244 + "Error: Set key and plain text first"; }
            input = Remove_Enter(input);
            string Key_use =Remove_Enter(Key);
            int ed = 1;
            if (!encript) { ed = -1; }
            if (Key_use.Length == 0 || input.Length == 0) { return input; }
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += Ascii_to_char_96( Mod( Char_to_ascii_96(input[i]) +ed* Char_to_ascii_96(Key_use[Mod(i, Key_use.Length)]),96 ) );
            }
            return output;
        }

        public string Generate(string input)
        {
            if (input.Length == 0) { return input; }

            Key = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] == 13) { continue; }
                Key += Ascii_to_char_96(new Random(Guid.NewGuid().GetHashCode()).Next(0, 64));
            }

            return Key;
        }
    }

    class Rail_fence_cipher:Necessesities
    {
        private int Key = 1;
        private bool key_set = false;

        public string Set_key(string input,string input2)
        {
            key_set = false;
            if (input == "" ||input2 =="") { Key = 1; return (char)244 + "Error: Set key and plaintext first"; }

            try {Key = int.Parse(input);}
            catch{Key = 1 + (int)input[0];}

            if (Key >= input2.Length) { Key = 1; return (char)244 + "Error: key greater than or equal to input text length doesn't hold meaning"; }
            if (Key <= 0) { Key = 1; return (char)244 + "Error: key less than 1 holds no meaning"; }
            key_set = true;
            return Key.ToString();
        }

        public string Generate(string input)
        {
            if (input.Length <= 3) { return input; }

            Key = new Random(Guid.NewGuid().GetHashCode()).Next(2, input.Length-1);

            return Key.ToString();
        }

        public string Process(string input,bool encript)
        {
            if(!key_set) { Key = 1; return (char)244 + "Error: Set key first"; }

            input = Remove_Enter(input);
            string output = "";
            if (encript)
            {
                int index = -1, inc = 1;
                string[] array_of_string = new string[Key];
                for(int i=0;i<input.Length;i++)
                {
                    index += inc;
                    if (index == 0) { inc = 1; }
                    else if (index == (Key - 1)){ inc = -1; }

                    array_of_string[index] += Ascii_to_char_96(Char_to_ascii_96(input[i]));

                }
                for(int i=0;i<Key;i++){output += array_of_string[i];}

                return output;
            }
            else
            {
                string []pt = new string[input.Length];
                bool a_flag=true;
                int row_index = 0,a=2*Key-2,b=0, index = row_index, inc;
                for (int i=0;i<input.Length;i++)
                {
                    if(index>=input.Length)
                    {
                        a_flag = true;
                        a -= 2;
                        b += 2;
                        row_index++;
                        index = row_index;
                    }
                       
                    pt[index] = Ascii_to_char_96(Char_to_ascii_96(input[i]));
                    
                    if (a == 0 || b == 0) { inc = a + b; }
                    else
                    {
                        if (a_flag) { inc = a; a_flag = false; }
                        else { inc = b;a_flag= true; }
                    }
                    index += inc;
                }

                for (int i = 0; i < input.Length; i++){output += pt[i]; }
                return output;
            }
        }
    }

    class Play_fair_cipher:Necessesities
    {
        private int[,]Key_matrix = new int[8,8];
        private bool key_set=false;
        public string Set_key(string input)
        {
            key_set = false;
            //need to reset to know if place is vacant else just a waste of time
            for (int i = 0; i < 8; i++){for(int j=0;j<8;j++){Key_matrix[i, j] = -1;} }
            bool break_loop;

            string input_use = Remove_Enter(input);
            for(int i = 0; i < input_use.Length; i++)
            {
                break_loop = false;
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        if (Key_matrix[row, column] == Char_to_ascii_64(input[i])) { break_loop = true; break; }
                        else if (Key_matrix[row, column] == -1) { Key_matrix[row, column] = Char_to_ascii_64(input[i]); break_loop = true; break; }
                    }
                    if (break_loop) { break; }
                }
            }

            
            for(int i = 0;i<64;i++)
            {
                break_loop = false;
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        if (Key_matrix[row,column]==i) { break_loop=true; break; }
                        else if (Key_matrix[row,column]==-1) { Key_matrix[row, column] = i; break_loop=true; break; }
                    }
                    if(break_loop) { break; }
                }
            }
            key_set = true;
            return input;
        }

        public string Generate()
        {
            string output = "";
            int random_length = new Random(Guid.NewGuid().GetHashCode()).Next(1,64);
            for(int i = 0;i<random_length;i++)
            {
                output += Ascii_to_char_64(new Random(Guid.NewGuid().GetHashCode()).Next(0, 63));
            }
            return Set_key(output);
        }

        public string Process(string input,bool encript, int rowx=1,int rowy=0,int columnx=0,int columny=1,int diagx = 0,int diagy = 0,bool alter_shift_diag=false)
        {
            if(!key_set) { return (char)244 + "Error: Set key first";}

            if(!encript){rowx *= -1;rowy*=-1;columnx*=-1;columny*=-1;diagx*=-1;diagy *= -1;}

            input = Remove_Enter(input.ToUpper());

            string digram_input = "";
            for(int i=0;i<input.Length;i+=2) 
            {
                if(i+1<input.Length)
                {
                    if (input[i] == input[i + 1] && (int)input[i] == 95){digram_input += input[i] + " " + input[i + 1] + " "; }
                    else if (input[i] == input[i + 1] && (int)input[i] != 95){digram_input += input[i] + "_" + input[i + 1] + "_";}
                    else{digram_input += input[i];digram_input += input[i + 1];}
                }
                else
                {
                    if ((int)input[i]==95){digram_input += input[i]+" ";}
                    else { digram_input += input[i] + "_"; }
                } 
            }

            int ax=0,ay=0,bx=0,by = 0;
            bool afound, bfound;
            string output = "";
            for(int i = 0; i < digram_input.Length; i+=2)
            {
                afound= false;bfound= false;
                for(int row = 0; row < 8; row++)
                {
                    for(int column=0; column < 8; column++)
                    {
                        if (Char_to_ascii_64(digram_input[i]) == Key_matrix[row,column]){ax = row; ay = column; afound= true;}
                        if (Char_to_ascii_64(digram_input[i+1]) == Key_matrix[row, column]){bx = row; by = column; bfound = true;}
                        if(afound&& bfound) { break; }
                    }
                    if (afound && bfound) { break; }
                }

                if(ax == bx) 
                {
                    output += Ascii_to_char_64(Key_matrix[Mod(ax + rowx,8),Mod(ay + rowy,8)]);
                    output += Ascii_to_char_64(Key_matrix[Mod(bx + rowx,8), Mod(by + rowy,8)]);
                }
                else if (ay == by) 
                {
                    output += Ascii_to_char_64(Key_matrix[Mod(ax + columnx,8), Mod(ay + columny,8)]);
                    output += Ascii_to_char_64(Key_matrix[Mod(bx + columnx,8), Mod(by + columny,8)]);
                }
                else
                {
                    if(alter_shift_diag)
                    {
                        output += Ascii_to_char_64(Key_matrix[Mod(ax + diagx,8), Mod(by + diagy,8)]);
                        output += Ascii_to_char_64(Key_matrix[Mod(bx + diagx,8), Mod(ay + diagy,8)]);
                    }
                    else
                    {
                        output += Ascii_to_char_64(Key_matrix[Mod(bx + diagx,8), Mod(ay + diagy,8)]);
                        output += Ascii_to_char_64(Key_matrix[Mod(ax + diagx,8), Mod(by + diagy,8)]);
                    } 
                }
            }
            return output;
        }

    }





}
