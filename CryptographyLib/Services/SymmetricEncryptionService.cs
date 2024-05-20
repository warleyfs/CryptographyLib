using CryptographyLib.Models;
using CryptographyLib.Services.Contracts;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CryptographyLib.Services
{
    public class SymmetricEncryptionService : ISymmetricEncryptionService
    {
        public Task<DecryptedResult> Decrypt(string cipherText)
        {
            throw new NotImplementedException();
        }

        public async Task<DecryptedResult> DecryptAsync(string cipherText)
        {
            try
            {
                return await Task.Run<DecryptedResult>(async () => {
                    using (FileStream fileStream = new FileStream("TestData.txt", FileMode.Open))
                    {
                        using (Aes aes = Aes.Create())
                        {
                            byte[] iv = new byte[aes.IV.Length];
                            int numBytesToRead = aes.IV.Length;
                            int numBytesRead = 0;
                            while (numBytesToRead > 0)
                            {
                                int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                                if (n == 0) break;

                                numBytesRead += n;
                                numBytesToRead -= n;
                            }

                            byte[] key =
                            {
                                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                            };

                            using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                            {
                                // By default, the StreamReader uses UTF-8 encoding.
                                // To change the text encoding, pass the desired encoding as the second parameter.
                                // For example, new StreamReader(cryptoStream, Encoding.Unicode).
                                using (StreamReader decryptReader = new StreamReader(cryptoStream))
                                {
                                    string decryptedMessage = await decryptReader.ReadToEndAsync();
                                    Console.WriteLine($"The decrypted original message: {decryptedMessage}");
                                }
                            }
                        }
                    }

                    return new DecryptedResult();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The decryption failed. {ex}");
                return new DecryptedResult();
            }
        }

        public Task<EncryptedResult> Encrypt(string plainText)
        {
            throw new NotImplementedException();
        }

        public async Task<EncryptedResult> EncryptAsync(string inName, string outName, byte[] aesKey, byte[] aesIV)
        {
            try
            {
                return await Task.Run<EncryptedResult>(async () =>
                {

                    //Create the file streams to handle the input and output files.
                    FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                    FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                    fout.SetLength(0);

                    //Create variables to help with read and write.
                    byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                    long rdlen = 0;              //This is the total number of bytes written.
                    long totlen = fin.Length;    //This is the total length of the input file.
                    int len;                     //This is the number of bytes to be written at a time.

                    Aes aes = Aes.Create();
                    CryptoStream encStream = new CryptoStream(fout, aes.CreateEncryptor(aesKey, aesIV), CryptoStreamMode.Write);

                    Console.WriteLine("Encrypting...");

                    //Read from the input file, then encrypt and write to the output file.
                    while (rdlen < totlen)
                    {
                        len = fin.Read(bin, 0, 100);
                        encStream.Write(bin, 0, len);
                        rdlen += len;
                        Console.WriteLine("{0} bytes processed", rdlen);
                    }

                    encStream.Close();
                    fout.Close();
                    fin.Close();

                    return new EncryptedResult();
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The encryption failed. {ex}");
                return new EncryptedResult();
            }
        }

        public Task<EncryptedResult> EncryptAsync(string plainText)
        {
            throw new NotImplementedException();
        }
    }
}
