using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace DESCrypterWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
        String stored_text;
        byte[] raw_data;

        private void создатьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.DefaultExt = ".bin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                KeyFileHandler.save(DES.Key, sfd.FileName);
                MessageBox.Show("Ключ успешно сохранен", "Создание ключа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void загрузитьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "key files (*.bin)|*.bin|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DES.Key = KeyFileHandler.load(ofd.FileName);
                MessageBox.Show("Ключ успешно загружен", "Загрузка ключа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void зашифроватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) raw_data = TextFileHandler.load(ofd.FileName, 0);
            stored_text = Encoding.UTF8.GetString(raw_data);

            ICryptoTransform transform = DES.CreateEncryptor();
            String crypted_filename = Path.ChangeExtension(ofd.FileName, "crypt");
            using (FileStream fileStream = new FileStream(crypted_filename, FileMode.OpenOrCreate))
            {
                // Запись случайного вектора инициализации без его шифрования
                fileStream.Write(DES.IV, 0, DES.IV.Length);
                // Создание криптографического потока в режиме записи
                using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
                {
                    // Создание объекта записи текста, который будет преобразовывать текст в
                    // двоичные данные
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        // Запись зашифрованной информации и очистка буфера памяти
                        streamWriter.Write(stored_text);
                        streamWriter.Flush();

                        // В конце операции шифрования необходимо дополнить заключительный частичный
                        // блок нулями и записать его в файл
                        cryptoStream.FlushFinalBlock();
                    }
                }
                raw_data = TextFileHandler.load(crypted_filename, DES.IV.Length);
                cryptedTextBox.Text = Encoding.UTF8.GetString(TextFileHandler.load(crypted_filename, DES.IV.Length));
                MessageBox.Show("Шифртекст успешно сохранен!", "Шифрование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void отобразитьШифрованнуюИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "crypt files (*.crypt)|*.crypt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                raw_data = TextFileHandler.load(ofd.FileName, DES.IV.Length);
                cryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
            }
        }

        private void расшифроватьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(ofd.FileName, FileMode.Open))
                {
                    // Чтение вектора инициализации
                    Byte[] iv = new byte[DES.IV.Length];
                    fileStream.Read(iv, 0, iv.Length);
                    DES.IV = iv;
                    // Создание интерфейса преобразования для дешифрования по алгоритму DES
                    ICryptoTransform transform = DES.CreateDecryptor();
                    // Создание криптографического потока в режиме записи. Этот поток будет
                    // декодировать двоичные данные сразу после их чтения из файла
                    using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Read))
                    {
                        // Создание объекта чтения из текста. Он будет преобразовывать дешифрованные
                        // данные из последовательности байт в строку
                        using (StreamReader sr = new StreamReader(cryptoStream))
                        {
                            decryptedTextBox.Text = sr.ReadToEnd();
                        }
                    }
                    MessageBox.Show("Сообщение успешно расшифровано!", "Дешифрование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            cryptedTextBox.Text = Encoding.UTF8.GetString(DESEncryptionDecryption.crypt(DES, decryptedTextBox.Text));

        }
    }
    public class KeyFileHandler
    {
        public static byte[] load(string filename)
        {
            byte[] key = new byte[8];
            FileStream fs = new FileStream(filename, FileMode.Open);
            fs.Read(key, 0, key.Length);
            fs.Close();
            return key;
        }
        public static void save(byte[] key, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            fs.Write(key, 0, key.Length);
            fs.Close();
        }
    }
    public class TextFileHandler
    {
        public static byte[] load(string filename, int offset)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            byte[] data = new byte[fs.Length - offset];
            fs.Read(data, offset, data.Length);
            fs.Close();
            return data;
        }
        public static void save(string text, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(text);
            fs.Close();
            sw.Close();
        }
    }
    public class DESEncryptionDecryption{
        public static byte[] crypt(DESCryptoServiceProvider DES, string text)
        {
            byte[] crypted;
            ICryptoTransform transform = DES.CreateEncryptor();
            using (MemoryStream ms = new MemoryStream())
            {
                // Запись случайного вектора инициализации без его шифрования
                ms.Write(DES.IV, 0, DES.IV.Length);
                // Создание криптографического потока в режиме записи
                using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                {
                    // Создание объекта записи текста, который будет преобразовывать текст в
                    // двоичные данные
                    using (StreamWriter sw= new StreamWriter(cs))
                    {
                        // Запись зашифрованной информации и очистка буфера памяти
                        sw.Write(text);
                        sw.Flush();
                        
                        // В конце операции шифрования необходимо дополнить заключительный частичный
                        // блок нулями и записать его в файл
                        cs.FlushFinalBlock();
                    }
                }
                crypted = ms.ToArray();
            }
            return crypted;
        }
    }
}
