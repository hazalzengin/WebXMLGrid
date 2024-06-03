using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Sistem
{
    public class LoginHashing
    {

        private string aesIV = @"!&+QWSDF!123126+";
        private string aesAnahtar = @"BAHAw!257()%%ert";

        public string Encrypt(string metin)
        {
            if (String.IsNullOrWhiteSpace(metin))
            {
                return "";
            }
            AesCryptoServiceProvider aesSaglayici = new AesCryptoServiceProvider();
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;

            aesSaglayici.IV = Encoding.UTF8.GetBytes(aesIV);
            aesSaglayici.Key = Encoding.UTF8.GetBytes(aesAnahtar);

            aesSaglayici.Mode = CipherMode.CBC;
            //aesSaglayici.Padding = PaddingMode.PKCS7;

            byte[] kaynak = Encoding.UTF8.GetBytes(metin);
            using (ICryptoTransform sifrele = aesSaglayici.CreateEncryptor())
            {
                byte[] hedef = sifrele.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Convert.ToBase64String(hedef);
            }
        }

        public string Decrypt(string metin)
        {
            if (String.IsNullOrWhiteSpace(metin))
            {
                return "";
            }
            AesCryptoServiceProvider aesSaglayici = new AesCryptoServiceProvider();
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;
            aesSaglayici.IV = Encoding.UTF8.GetBytes(aesIV);
            aesSaglayici.Key = Encoding.UTF8.GetBytes(aesAnahtar);
            aesSaglayici.Mode = CipherMode.CBC;
            //aesSaglayici.Padding = PaddingMode.PKCS7;
            byte[] kaynak = System.Convert.FromBase64String(metin);
            using (ICryptoTransform decrypt = aesSaglayici.CreateDecryptor())
            {
                byte[] hedef = decrypt.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Encoding.UTF8.GetString(hedef);
            }
        }


        //static readonly string PasswordHash = "P@@Sw0rd";
        //static readonly string SaltKey = "S@LT&KEY";
        //static readonly string VIKey = "@1B2c3D4e5F6g7H8";


        //public string Encrypt(string plainText)
        //{
        //    byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

        //    byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
        //    var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
        //    var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

        //    byte[] cipherTextBytes;

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
        //        {
        //            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
        //            cryptoStream.FlushFinalBlock();
        //            cipherTextBytes = memoryStream.ToArray();
        //            cryptoStream.Close();
        //        }
        //        memoryStream.Close();
        //    }
        //    return Convert.ToBase64String(cipherTextBytes);
        //}

        //public string Decrypt(string encryptedText)
        //{
        //    byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
        //    byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
        //    var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };
        //    var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
        //    var memoryStream = new MemoryStream(cipherTextBytes);
        //    var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
        //    var plainTextBytes = new byte[cipherTextBytes.Length];
        //    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
        //    memoryStream.Close();
        //    cryptoStream.Close();
        //    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        //}


    }
}
