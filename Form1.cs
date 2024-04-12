using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace FormComs
{
    public partial class Form1 : Form
    {
        List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();

        List<List<string>> towns = new List<List<string>>();
        List<string> countries = new List<string>();

        public Form1()
        {
            InitializeComponent();

            usernames.Add("admin");
            passwords.Add(hashPassword("admin"));

            this.Text = "Log In";

            countries.Add("USA");
            countries.Add("UAE");
            countries.Add("Uganda");

            foreach (string country in countries)
            {
                comboBox1.Items.Add(country);
            }

            towns.Add(new List<string>());
            towns.Add(new List<string>());
            towns.Add(new List<string>());

            towns[0].Add("San Francisco");
            towns[0].Add("Los Angeles");
            towns[0].Add("Novato");

            towns[1].Add("Dubai");
            towns[1].Add("Abu Dhabi");
            towns[1].Add("Al Ain");

            towns[2].Add("Kampala");
            towns[2].Add("Gulu");
            towns[2].Add("Mbale");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            button2.Show();
            button3.Show();
            button4.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            this.Text = "Form2";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            comboBox2.Items.Clear();

            foreach (string item in towns[comboBox1.SelectedIndex])
            {
                comboBox2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty && !(countries.Contains(textBox1.Text)) && textBox1.Text != String.Empty)
            {
                countries.Add(textBox1.Text);
                towns.Add(new List<string>());
            }
            else if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && !(countries.Contains(textBox1.Text)))
            {
                countries.Add(textBox1.Text);
                towns.Add(new List<string>());
                towns[countries.IndexOf(textBox1.Text)].Add(textBox2.Text);
            }
            else if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            {
                if (countries.Contains(textBox1.Text))
                {
                    if (!towns[countries.IndexOf(textBox1.Text)].Contains(textBox2.Text))
                    {
                        towns[countries.IndexOf(textBox1.Text)].Add(textBox2.Text);
                    }
                }
            }
            alter_method();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != String.Empty)
            {
                if (textBox1.Text != String.Empty && textBox2.Text == String.Empty)
                {
                    if (countries.Contains(textBox1.Text))
                    {
                        countries[countries.IndexOf(textBox1.Text)] = textBox3.Text;
                    }
                }
                else if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
                {
                    towns[countries.IndexOf(textBox1.Text)][towns[countries.IndexOf(textBox1.Text)].IndexOf(textBox2.Text)] = textBox3.Text;
                }
            }
            alter_method();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text == String.Empty)
            {
                if (countries.Contains(textBox1.Text))
                {
                    towns.Remove(towns[countries.IndexOf(textBox1.Text)]);
                    countries.Remove(textBox1.Text);
                }
            }
            else if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            {
                if (countries.Contains(textBox1.Text) && towns[countries.IndexOf(textBox1.Text)].Contains(textBox2.Text))
                {
                    towns[countries.IndexOf(textBox1.Text)].Remove(textBox2.Text);
                }
            }
            alter_method();
        }

        private void alter_method()
        {
            comboBox1.Items.Clear();
            foreach (string item in countries)
            {
                if (!comboBox1.Items.Contains(item))
                {
                    comboBox1.Items.Add(item);
                }
            }
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox2.Items.Clear();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            button1.Show();
            comboBox1.Show();
            comboBox2.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            this.Text = "Form1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(textBox4.Text))
            {
                if (passwords[usernames.IndexOf(textBox4.Text)] != hashPassword(textBox5.Text))
                {
                    MessageBox.Show("Wrong Password!");
                }
                if (passwords[usernames.IndexOf(textBox4.Text)] == hashPassword(textBox5.Text))
                {
                    this.Text = "Form 1";
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();
                    button5.Hide();
                    button6.Hide();
                    button7.Hide();
                    comboBox1.Show();
                    comboBox2.Show();
                    textBox6.Hide();
                    if (textBox4.Text == "admin" && textBox5.Text == "admin")
                    {
                        button1.Show();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(textBox4.Text))
            {
                MessageBox.Show("User already exist, try logging in instead!");
            }
            else if (textBox4.Text != String.Empty && textBox5.Text != String.Empty)
            {
                string password = textBox5.Text;
                string Pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&*?])[A-Za-z0-9!@#$%_&*?]{8,}$";
                if (Regex.IsMatch(password, Pattern))
                {
                    MessageBox.Show("Valid");
                    label3.Show();
                    textBox6.Show();
                    button7.Show();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
        }

        string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                string salt = "";
                {
                    salt = DateTime.Now.ToString();
                }

                string password = textBox5.Text;

                hashPassword($"{password}{salt}");
                MessageBox.Show(hashPassword(password));
                usernames.Add(textBox4.Text);
                passwords.Add(hashPassword(textBox5.Text));
                textBox6.Text = String.Empty;
                textBox6.Hide();
                label3.Hide();
                button7.Hide();
            }
        }
    }
}