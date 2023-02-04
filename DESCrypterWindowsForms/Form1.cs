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
        byte[] encrypted_data;

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
            if (ofd.ShowDialog() == DialogResult.OK) {
                // Чтение файла в массив байтов
                raw_data = File.ReadAllBytes(ofd.FileName);
                // Шифрование данных
                encrypted_data = DESEncryptionDecryption.crypt(DES, raw_data);
                // Вывод зашифрованных данных в текстовое поле
                cryptedTextBox.Text = Encoding.UTF8.GetString(encrypted_data);
                // Сохранение зашифрованных данных в файл
                File.WriteAllBytes(ofd.FileName + ".crypt", encrypted_data);
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
            if (ofd.ShowDialog() == DialogResult.OK) {
                // Чтение файла в массив байтов
                encrypted_data = File.ReadAllBytes(ofd.FileName);
                // Расшифрование данных
                raw_data = DESEncryptionDecryption.decrypt(DES, encrypted_data);
                // Вывод расшифрованных данных в текстовое поле
                decryptedTextBox.Text = Encoding.UTF8.GetString(raw_data);
                MessageBox.Show("Сообщение успешно расшифровано!", "Дешифрование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            cryptedTextBox.Text = Encoding.UTF8.GetString(DESEncryptionDecryption.crypt(DES, raw_data));

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
            // Чтение файла в массив байтов
            byte[] data = File.ReadAllBytes(filename);
            // Создание массива для хранения данных без вектора инициализации
            byte[] result = new byte[data.Length - offset];
            // Копирование данных без вектора инициализации
            Array.Copy(data, offset, result, 0, result.Length);
            return result;
        }
        public static void save(byte[] data, string filename)
        {
            File.WriteAllBytes(filename, data);
        }
    }
    public class DESEncryptionDecryption{
        public static byte[] crypt(DESCryptoServiceProvider DES, byte[] data)
        {
            byte[] crypted_data;
            ICryptoTransform transform = DES.CreateEncryptor();
            using (MemoryStream ms = new MemoryStream())
            {
                // Запись случайного вектора инициализации без его шифрования
                ms.Write(DES.IV, 0, DES.IV.Length);
                // Создание криптографического потока в режиме записи
                using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.Flush();
                    cs.FlushFinalBlock();
                }
                crypted_data = ms.ToArray();
            }
            return crypted_data;
        }
        public static byte[] decrypt(DESCryptoServiceProvider DES, byte[] data)
        {
            byte[] decrypted_data;
            using (MemoryStream ms = new MemoryStream(data))
            {
                // Чтение вектора инициализации из потока
                Byte[] iv = new byte[DES.IV.Length];
                ms.Read(iv, 0, iv.Length);
                DES.IV = iv;
                // Создание интерфейса преобразования для дешифрования по алгоритму DES
                ICryptoTransform transform = DES.CreateDecryptor();
                // Создание криптографического потока в режиме записи. Этот поток будет
                // декодировать двоичные данные сразу после их чтения из потока
                using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Read))
                {
                    decrypted_data = new byte[ms.Length];
                    cs.Read(decrypted_data, 0, decrypted_data.Length);
                }
            return decrypted_data;
            }

        }
    }
}
