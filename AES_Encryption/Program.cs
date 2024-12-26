using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES_Encryption
{
    internal class Program
    {
        static byte[,] SBox = new byte[16, 16]
        {
            {0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76},
            {0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0},
            {0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15},
            {0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75},
            {0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84},
            {0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf},
            {0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8},
            {0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2},
            {0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73},
            {0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb},
            {0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79},
            {0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08},
            {0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a},
            {0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e},
            {0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf},
            {0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16}
        };

        static void Main(string[] args)
        {
            byte[,] plaintext = new byte[4, 4]
            {
                { 0x32, 0x43, 0xf6, 0xa8 },
                { 0x88, 0x5a, 0x30, 0x8d },
                { 0x31, 0x31, 0x98, 0xa2 },
                { 0xe0, 0x37, 0x07, 0x34 }
            };

            byte[] key = new byte[16]
            {
                0x2b, 0x7e, 0x15, 0x16,
                0x28, 0xae, 0xd2, 0xa6,
                0xab, 0xf7, 0x4d, 0x3b,
                0x88, 0x3c, 0xee, 0x6d
            };

            byte[,] ciphertext = EncryptAES(plaintext, key);

            Console.WriteLine("Ciphertext:");
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write($"{ciphertext[row, col]:X2} ");
                }
                Console.WriteLine();
            }
        }

        public static void ShiftRows(byte[,] state)
        {
            byte temp;

            // Dòng 1: không thay đổi
            // Dòng 2: Dịch vòng 1 byte
            temp = state[1, 0];
            for (int i = 0; i < 3; i++)
                state[1, i] = state[1, i + 1];
            state[1, 3] = temp;

            // Dòng 3: Dịch vòng 2 byte
            byte temp1 = state[2, 0], temp2 = state[2, 1];
            state[2, 0] = state[2, 2];
            state[2, 1] = state[2, 3];
            state[2, 2] = temp1;
            state[2, 3] = temp2;

            // Dòng 4: Dịch vòng 3 byte
            temp = state[3, 3];
            for (int i = 3; i > 0; i--)
                state[3, i] = state[3, i - 1];
            state[3, 0] = temp;
        }
        public static void MixColumns(byte[,] state)
        {
            for (int c = 0; c < 4; c++)
            {
                byte[] col = new byte[4];
                for (int i = 0; i < 4; i++)
                    col[i] = state[i, c];

                state[0, c] = (byte)(GFMul(0x02, col[0]) ^ GFMul(0x03, col[1]) ^ col[2] ^ col[3]);
                state[1, c] = (byte)(col[0] ^ GFMul(0x02, col[1]) ^ GFMul(0x03, col[2]) ^ col[3]);
                state[2, c] = (byte)(col[0] ^ col[1] ^ GFMul(0x02, col[2]) ^ GFMul(0x03, col[3]));
                state[3, c] = (byte)(GFMul(0x03, col[0]) ^ col[1] ^ col[2] ^ GFMul(0x02, col[3]));
            }
        }

        public static byte GFMul(byte a, byte b)
        {
            byte result = 0;
            for (int i = 0; i < 8; i++)
            {
                if ((b & 1) != 0)
                    result ^= a;
                bool hiBitSet = (a & 0x80) != 0;
                a <<= 1;
                if (hiBitSet)
                    a ^= 0x1B; // Giảm đa thức AES
                b >>= 1;
            }
            return result;
        }
        public static void AddRoundKey(byte[,] state, byte[,] roundKey)
        {
            for (int r = 0; r < 4; r++)
                for (int c = 0; c < 4; c++)
                    state[r, c] ^= roundKey[r, c];
        }

        public static byte[,] GetRoundKey(byte[,] expandedKey, int round)
        {
            byte[,] roundKey = new byte[4, 4];
            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 4; row++)
                {
                    roundKey[row, col] = expandedKey[row, round * 4 + col];
                }
            }
            return roundKey;
        }


        public static byte[,] EncryptAES(byte[,] plaintext, byte[] key)
        {
            // Sinh tất cả các khóa con
            byte[,] expandedKey = KeyExpansion(key);

            byte[,] state = (byte[,])plaintext.Clone(); // Sao chép trạng thái

            // Thêm khóa vòng ban đầu
            AddRoundKey(state, GetRoundKey(expandedKey, 0));

            // 9 vòng cho AES-128
            for (int round = 1; round <= 9; round++)
            {
                SubByte(state);
                ShiftRows(state);
                MixColumns(state);
                AddRoundKey(state, GetRoundKey(expandedKey, round));
            }

            // Vòng cuối cùng (không MixColumns)
            SubByte(state);
            ShiftRows(state);
            AddRoundKey(state, GetRoundKey(expandedKey, 10));

            return state;
        }


        public static byte[,] KeyExpansion(byte[] key)
        {
            if (key.Length != 16) // AES-128
                throw new ArgumentException("Key length must be 16 bytes for AES-128.");

            int Nb = 4; // Số cột trong trạng thái (4x4)
            int Nk = 4; // Số từ (word) trong khóa ban đầu
            int Nr = 10; // Số vòng (AES-128 có 10 vòng)
            int totalWords = Nb * (Nr + 1); // Tổng số từ sau khi mở rộng

            byte[,] expandedKey = new byte[4, totalWords]; // Kết quả mở rộng khóa
            byte[] temp = new byte[4]; // Biến tạm lưu từng từ

            // Sao chép khóa ban đầu vào expandedKey
            for (int i = 0; i < Nk; i++)
            {
                expandedKey[0, i] = key[4 * i];
                expandedKey[1, i] = key[4 * i + 1];
                expandedKey[2, i] = key[4 * i + 2];
                expandedKey[3, i] = key[4 * i + 3];
            }

            // Mở rộng khóa
            for (int i = Nk; i < totalWords; i++)
            {
                // Lấy từ trước đó
                temp[0] = expandedKey[0, i - 1];
                temp[1] = expandedKey[1, i - 1];
                temp[2] = expandedKey[2, i - 1];
                temp[3] = expandedKey[3, i - 1];

                // Với các từ tại vị trí chia hết cho Nk, áp dụng SubWord và RotWord
                if (i % Nk == 0)
                {
                    temp = SubWord(RotWord(temp)); // Áp dụng RotWord và SubWord
                    temp[0] ^= Rcon(i / Nk); // XOR với Rcon
                }

                // XOR với từ Nk trước đó
                for (int j = 0; j < 4; j++)
                {
                    expandedKey[j, i] = (byte)(expandedKey[j, i - Nk] ^ temp[j]);
                }
            }

            return expandedKey;
        }

        public static byte[] RotWord(byte[] word)
        {
            return new byte[] { word[1], word[2], word[3], word[0] };
        }
        public static byte[] SubWord(byte[] word)
        {
            for (int i = 0; i < 4; i++)
            {
                word[i] = SubByte(word[i]);
            }
            return word;
        }

        public static byte Rcon(int round)
        {
            byte[] rcon = new byte[256];
            rcon[1] = 0x01;

            for (int i = 2; i < 256; i++)
            {
                // Nếu bit cao (MSB) của rcon[i - 1] được thiết lập, XOR với 0x1B
                rcon[i] = (byte)((rcon[i - 1] << 1) ^ ((rcon[i - 1] & 0x80) != 0 ? 0x1B : 0x00));
            }

            return rcon[round];
        }


        public static void SubByte(byte[,] state)
        {
            int rows = state.GetLength(0);
            int cols = state.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    state[r, c] = SubByte(state[r, c]);
                }
            }
        }

        public static byte SubByte(byte input)
        {
            int row = (input >> 4) & 0x0F; // Lấy 4 bit cao
            int col = input & 0x0F;        // Lấy 4 bit thấp
            return SBox[row, col];         // Truy xuất giá trị từ S-box
        }


    }
}
