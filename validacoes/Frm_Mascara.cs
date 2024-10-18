namespace validacoes
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void Msk_TextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();

        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "$ 000,000,000.00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            RightToLeft = RightToLeft.Yes;
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            RightToLeft = RightToLeft.Yes;
        }

       

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            string input = Msk_TextBox.Text;


            if (Msk_TextBox.Mask == "00:00")
            {
                if (TimeSpan.TryParse(input, out TimeSpan time) && time.TotalHours < 24)
                {
                    Lbl_Conteudo.Text = Msk_TextBox.Text;
                }
                else
                {
                    MessageBox.Show("Hora inválida.insira uma hora válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Msk_TextBox.Focus();
                }
            }

            else if (Msk_TextBox.Mask == "00/00/0000")
            {
                if (DateTime.TryParse(input, out DateTime date))
                {
                    Lbl_Conteudo.Text = Msk_TextBox.Text;
                }
                else
                {
                    MessageBox.Show("Data inválida.insira uma data válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Msk_TextBox.Focus();
                }
            }

            else if (Msk_TextBox.UseSystemPasswordChar)
            {
                bool isValidPassword = input.Length >= 8 &&
                                       input.Any(char.IsUpper) &&
                                       input.Any(char.IsLower) &&
                                       input.Any(char.IsDigit) &&
                                       input.Any(ch => "!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\`~".Contains(ch));

                if (!isValidPassword)
                {
                    MessageBox.Show("Senha inválida.A senha precisa ter no mínimo 8 caracteres, contendo: uma letra maiúscula, uma letra minúscula, um número e um caractere especial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Msk_TextBox.Focus();
                }
                else
                {
                    Lbl_Conteudo.Text = Msk_TextBox.Text;
                }
            }
            if(Msk_TextBox.Mask == "$ 000,000,000.00")
            {
                Lbl_Conteudo.Text = Msk_TextBox.Text;
            }
            if (Msk_TextBox.Mask == " (00) 0000-0000")
            {
                Lbl_Conteudo.Text = Msk_TextBox.Text;
            }
            if (Msk_TextBox.Mask == "00000-000")
            {
                Lbl_Conteudo.Text = Msk_TextBox.Text;
            }
        }
    }
    }

