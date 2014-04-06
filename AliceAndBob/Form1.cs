// AliceAndBob.cs
// By Ryan Ries, September 2012
//
// This app is useful for nothing except entertainment purposes.
// It demonstrates a very basic Diffie-Hellman key exchange, where a secret
// message can be communicated between Alice and Bob, even when Eve has
// tapped the line of communication. This is possible through private secrets
// that are never transmitted across the wire, and some clever modular arithmetic.
// It requires a prime modulus and a generator. The generator is a primitive root of the prime modulus.
// Technically the generator does not have to be a primitive root of the prime modulus, but
// it increases the overall security of the system because if a primitive root of the prime
// modulus is not used, the algorithm will only generate a subset of the full potential of results.
// With a primitive root of the modulus as a generator, the results will be evenly distributed across
// the entire field of 0-p.

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics; // For biginteger

namespace AliceAndBob
{
    public partial class Form1 : Form
    {
        static int primesRange = 10000000;
        public Form1()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.Text = Application.ProductName + " v" + Application.ProductVersion;
            this.Icon = Properties.Resources.key_icon;
            DateTime start = DateTime.Now;
            List<int> allPrimes = findPrimes(primesRange);
            List<int> safePrimes = new List<int>();
            // From Wikipedia: A safe prime is a prime number of the form 2p + 1, where p is also a prime
            foreach (int p in allPrimes)
            {
                if (IsPrime( (p-1)/2 ))
                    safePrimes.Add(p);
            }
            DateTime end = DateTime.Now;
            TimeSpan elapsed = end - start;
            eveListBox.Items.Add("I've wiretapped Alice and Bob's conversation. In " + Math.Round(elapsed.TotalSeconds, 2) + " seconds, I found " + allPrimes.Count + " primes, " + safePrimes.Count + " of which are safe primes.");
            foreach (int p in safePrimes)
                primeModComboBox.Items.Add(p.ToString());

            Random rnd = new Random();
            alicesPKTextBox.Text = (rnd.Next(1, 1000).ToString());
            bobsPKTextBox.Text = (rnd.Next(1, 1000).ToString());
        }

        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

        private void aliceSendButton_Click(object sender, EventArgs e)
        {
            if (alicesMessageTextBox.Text.Length < 1)
            {
                MessageBox.Show("Alice has no message to send.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // p (prime modulus) and g (generator) are already publically known            
            BigInteger p = BigInteger.Parse(primeModComboBox.Text);
            BigInteger g = BigInteger.Parse(generatorComboBox.Text);
            
            // Alice computes A = (g^a) mod p and sends her result to Bob            
            int a = int.Parse(alicesPKTextBox.Text);            
            BigInteger A = BigInteger.Pow(g,a) % p;                       
            aliceRecvListBox.Items.Add("To Bob: A = (g^a) mod p");
            eveListBox.Items.Add("From Alice to Bob: A = (g^a) mod p");
            bobRecvListBox.Items.Add("From Alice: A = (g^a) mod p");

            aliceRecvListBox.Items.Add("To Bob: " + A + " = (" + g + "^a) mod " + p);
            eveListBox.Items.Add("From Alice to Bob: " + A + " = (" + g + "^a) mod " + p);
            bobRecvListBox.Items.Add("From Alice: " + A + " = (" + g + "^a) mod " + p);

            // Bob computes B = (g^b) mod p and sends his result to Alice
            int b = int.Parse(bobsPKTextBox.Text);
            BigInteger B = BigInteger.Pow(g, b) % p;

            bobRecvListBox.Items.Add("To Alice: B = (g^b) mod p");
            eveListBox.Items.Add("From Bob to Alice: B = (g^b) mod p");
            aliceRecvListBox.Items.Add("From Bob: B = (g^b) mod p");

            bobRecvListBox.Items.Add("To Alice: " + B + " = (" + g + "^b) mod " + p);
            eveListBox.Items.Add("From Bob to Alice: " + B + " = (" + g + "^b) mod " + p);
            aliceRecvListBox.Items.Add("From Bob: " + B + " = (" + g + "^b) mod " + p);

            eveListBox.Items.Add("Eve: I don't know a or b and will have to resort to trial and error to find the secret.");

            // Using Bob's result, Alice computes:
            BigInteger s = BigInteger.Pow(B, a) % p;
            aliceRecvListBox.Items.Add("Using Bob's result, I can compute s = (B^a) mod p.");
            aliceRecvListBox.Items.Add("The secret is " + s);

            // Using Alice's result, Bob computes:
            BigInteger t = BigInteger.Pow(A, b) % p;
            bobRecvListBox.Items.Add("Using Alice's result, I can compute t = (A^b) mod p.");
            bobRecvListBox.Items.Add("The secret is " + t);

            aliceRecvListBox.Items.Add("Encrypting message using shared secret...");
            string msg = Encrypt(alicesMessageTextBox.Text, s.ToString());
            aliceRecvListBox.Items.Add("To Bob: " + msg);
            eveListBox.Items.Add("From Alice to Bob: " + msg);
            bobRecvListBox.Items.Add("Decrypting message using shared secret...");
            bobRecvListBox.Items.Add("From Alice: " + Decrypt(msg, t.ToString()));

            aliceRecvListBox.SelectedIndex = aliceRecvListBox.Items.Count - 1;
            bobRecvListBox.SelectedIndex = bobRecvListBox.Items.Count - 1;
            eveListBox.SelectedIndex = eveListBox.Items.Count - 1;
        }

        private void bobSendButton_Click(object sender, EventArgs e)
        {
            if (bobsMessageTextBox.Text.Length < 1)
            {
                MessageBox.Show("Bob has no message to send.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // p (prime modulus) and g (generator) are already publically known
            BigInteger p = BigInteger.Parse(primeModComboBox.Text);
            BigInteger g = BigInteger.Parse(generatorComboBox.Text);

            // Bob computes B = (g^b) mod p and sends his result to Alice
            int b = int.Parse(bobsPKTextBox.Text);
            BigInteger B = BigInteger.Pow(g, b) % p;

            bobRecvListBox.Items.Add("To Alice: B = (g^b) mod p");
            eveListBox.Items.Add("From Bob to Alice: B = (g^b) mod p");
            aliceRecvListBox.Items.Add("From Bob: B = (g^b) mod p");

            bobRecvListBox.Items.Add("To Alice: " + B + " = (" + g + "^b) mod " + p);
            eveListBox.Items.Add("From Bob to Alice: " + B + " = (" + g + "^b) mod " + p);
            aliceRecvListBox.Items.Add("From Bob: " + B + " = (" + g + "^b) mod " + p);

            // Alice computes A = (g^a) mod p and sends her result to Bob
            int a = int.Parse(alicesPKTextBox.Text);
            BigInteger A = BigInteger.Pow(g, a) % p;

            aliceRecvListBox.Items.Add("To Bob: A = (g^a) mod p");
            eveListBox.Items.Add("From Alice to Bob: A = (g^a) mod p");
            bobRecvListBox.Items.Add("From Alice: A = (g^a) mod p");

            aliceRecvListBox.Items.Add("To Bob: " + A + " = (" + g + "^a) mod " + p);
            eveListBox.Items.Add("From Alice to Bob: " + A + " = (" + g + "^a) mod " + p);
            bobRecvListBox.Items.Add("From Alice: " + A + " = (" + g + "^a) mod " + p);

            eveListBox.Items.Add("Eve: I don't know a or b and will have to resort to trial and error to find the secret.");

            // Using Alice's result, Bob computes:
            BigInteger t = BigInteger.Pow(A, b) % p;
            bobRecvListBox.Items.Add("Using Alice's result, I can compute t = (A^b) mod p.");
            bobRecvListBox.Items.Add("The secret is " + t);

            // Using Bob's result, Alice computes:
            BigInteger s = BigInteger.Pow(B, a) % p;
            aliceRecvListBox.Items.Add("Using Bob's result, I can compute s = (B^a) mod p.");
            aliceRecvListBox.Items.Add("The secret is " + s);

            bobRecvListBox.Items.Add("Encrypting message using shared secret...");
            string msg = Encrypt(bobsMessageTextBox.Text, t.ToString());
            bobRecvListBox.Items.Add("To Alice: " + msg);
            eveListBox.Items.Add("From Bob to Alice: " + msg);
            aliceRecvListBox.Items.Add("Decrypting message using shared secret...");
            aliceRecvListBox.Items.Add("From Alice: " + Decrypt(msg, s.ToString()));

            aliceRecvListBox.SelectedIndex = aliceRecvListBox.Items.Count - 1;
            bobRecvListBox.SelectedIndex = bobRecvListBox.Items.Count - 1;
            eveListBox.SelectedIndex = eveListBox.Items.Count - 1;
        }

        static List<int> findPrimes(int max)
        {
            var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(max);
            var eliminated = new BitArray(max + 1);
            vals.Add(2);
            for (int i = 3; i <= max; i += 2)
            {
                if (!eliminated[i])
                {
                    if (i < maxSquareRoot)
                    {
                        for (int j = i * i; j <= max; j += 2 * i)
                            eliminated[j] = true;
                    }
                    vals.Add(i);
                }
            }
            return vals;
        }

        private string Decrypt(string encryptedString, string strKey)
        {
            try
            {
                TripleDESCryptoServiceProvider objDESCrypto = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
                byte[] byteHash, byteBuff;
                string strTempKey = strKey;
                byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
                objHashMD5 = null;
                objDESCrypto.Key = byteHash;
                objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
                byteBuff = Convert.FromBase64String(encryptedString);
                string strDecrypted = ASCIIEncoding.ASCII.GetString
                (objDESCrypto.CreateDecryptor().TransformFinalBlock
                (byteBuff, 0, byteBuff.Length));
                objDESCrypto = null;
                return strDecrypted;
            }
            catch (Exception ex)
            {
                return "Error decrypting! " + ex.Message;
            }
        }

        private string Encrypt(string strToEncrypt, string strKey)
        {
            try
            {
                TripleDESCryptoServiceProvider objDESCrypto = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
                byte[] byteHash, byteBuff;
                string strTempKey = strKey;
                byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
                objHashMD5 = null;
                objDESCrypto.Key = byteHash;
                objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
                byteBuff = ASCIIEncoding.ASCII.GetBytes(strToEncrypt);
                return Convert.ToBase64String(objDESCrypto.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            }
            catch (Exception ex)
            {
                return "Error encrypting! " + ex.Message;
            }
        }

        private void alicesMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (bobsPKTextBox.Text.Length > 0 && primeModComboBox.Text.Length > 0 && generatorComboBox.Text.Length > 0 && alicesPKTextBox.Text.Length > 0 && (bobsMessageTextBox.Text.Length > 0 || alicesMessageTextBox.Text.Length > 0))
            {
                bobSendButton.Enabled = true;
                aliceSendButton.Enabled = true;
            }
            else
            {
                bobSendButton.Enabled = false;
                aliceSendButton.Enabled = false;
            }
        }

        private void alicesPKTextBox_TextChanged(object sender, EventArgs e)
        {
            if (bobsPKTextBox.Text.Length > 0 && primeModComboBox.Text.Length > 0 && generatorComboBox.Text.Length > 0 && alicesPKTextBox.Text.Length > 0 && (bobsMessageTextBox.Text.Length > 0 || alicesMessageTextBox.Text.Length > 0))
            {
                bobSendButton.Enabled = true;
                aliceSendButton.Enabled = true;
            }
            else
            {
                bobSendButton.Enabled = false;
                aliceSendButton.Enabled = false;
            }
        }

        void alicesPKTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            
                e.Handled = true;            
        }

        void bobsPKTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void bobsMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (bobsPKTextBox.Text.Length > 0 && primeModComboBox.Text.Length > 0 && generatorComboBox.Text.Length > 0 && alicesPKTextBox.Text.Length > 0 && (bobsMessageTextBox.Text.Length > 0 || alicesMessageTextBox.Text.Length > 0))
            {
                bobSendButton.Enabled = true;
                aliceSendButton.Enabled = true;
            }
            else
            {
                bobSendButton.Enabled = false;
                aliceSendButton.Enabled = false;
            }
        }

        private void bobsPKTextBox_TextChanged(object sender, EventArgs e)
        {
            if (bobsPKTextBox.Text.Length > 0 && primeModComboBox.Text.Length > 0 && generatorComboBox.Text.Length > 0 && alicesPKTextBox.Text.Length > 0 && (bobsMessageTextBox.Text.Length > 0 || alicesMessageTextBox.Text.Length > 0))
            {
                bobSendButton.Enabled = true;
                aliceSendButton.Enabled = true;
            }
            else
            {
                bobSendButton.Enabled = false;
                aliceSendButton.Enabled = false;
            }
        }

        private void primeModComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generatorComboBox.Items.Clear();
            aliceRecvListBox.Items.Add("Alice changed the prime modulus to " + primeModComboBox.Text + ".");
            eveListBox.Items.Add("Alice changed the prime modulus to " + primeModComboBox.Text + ".");
            bobRecvListBox.Items.Add("Alice changed the prime modulus to " + primeModComboBox.Text + ".");
            GeneratorGenerator(); // Because it generates generators, see?
            newGeneratorButton.Enabled = true;
        }


        /// <summary>
        /// From Stackoverflow:
        /// Then, to get the "generator" g, we can just use any random integer modulo p: the probability that q is not a divisor of the order of a random non-zero 
        /// integer modulo p if 1/q, i.e. so small that you will not hit it in practice (the overall security of Diffie-Hellman relies on the practical impossibility 
        /// of obtaining events which are billions of times more probable than that). Nevertheless, some people get nervous in the face of probabilities, and will feel 
        /// safer if we test the generator. The procedure then becomes: create a random integer u modulo p and compute g=u^((p−1)/qmodp). If g=1, then try again with a new 
        /// random u (this is the very improbable event that you will not get in practice); otherwise, it can easily be shown that g has order exactly q, and thus is a 
        /// good generator for Diffie-Hellman.
        /// </summary>
        private void GeneratorGenerator()
        {
            Random rnd = new Random();
            int gen = 0;
            // From crypto.stackexchange.com: hence every g between 2 and p−2 (inclusive) is a fine DH generator and ensures optimal security
            tryAgain:
            gen = rnd.Next(1, primesRange) % int.Parse(primeModComboBox.Text);
            if (gen < 2 || gen > (int.Parse(primeModComboBox.Text) - 2)) goto tryAgain;
            if (GCD(gen, int.Parse(primeModComboBox.Text)) != 1) goto tryAgain; // I think this is redundant and already implied but oh well

            generatorComboBox.Items.Add(gen);
            generatorComboBox.SelectedIndex = generatorComboBox.Items.Count - 1;
            aliceRecvListBox.Items.Add("Alice changed the generator to " + generatorComboBox.Text + ".");
            eveListBox.Items.Add("Alice changed the generator to " + generatorComboBox.Text + ".");
            bobRecvListBox.Items.Add("Alice changed the generator to " + generatorComboBox.Text + ".");
            aliceRecvListBox.SelectedIndex = aliceRecvListBox.Items.Count - 1;
            bobRecvListBox.SelectedIndex = bobRecvListBox.Items.Count - 1;
            eveListBox.SelectedIndex = eveListBox.Items.Count - 1;
            if (bobsPKTextBox.Text.Length > 0 && primeModComboBox.Text.Length > 0 && generatorComboBox.Text.Length > 0 && alicesPKTextBox.Text.Length > 0 && (bobsMessageTextBox.Text.Length > 0 || alicesMessageTextBox.Text.Length > 0))
            {
                bobSendButton.Enabled = true;
                aliceSendButton.Enabled = true;
            }
            else
            {
                bobSendButton.Enabled = false;
                aliceSendButton.Enabled = false;
            }
        }

        static int GCD(int a, int b)
        {
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        private void newGeneratorButton_Click(object sender, EventArgs e)
        {
            GeneratorGenerator();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            aliceRecvListBox.Items.Clear();
            bobRecvListBox.Items.Clear();
            eveListBox.Items.Clear();
        }

        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
