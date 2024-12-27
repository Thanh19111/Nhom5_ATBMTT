#include <iostream>
#include <string>
#include <vector>
#include <random>
#include <algorithm>
#include <cstring>

using namespace std;

class AES_Encryption {
private:
    string mess;
    const int KEY_SIZE = 32; // 256 bits
    const int BLOCK_SIZE = 16; // 128 bits

    vector<uint8_t> generateRandomKey() {
        vector<uint8_t> key(KEY_SIZE);
        random_device rd;
        mt19937 gen(rd());
        uniform_int_distribution<> dis(0, 255);

        generate(key.begin(), key.end(), [&]() { return dis(gen); });
        return key;
    }

    string base64_encode(const vector<uint8_t>& input) {
        const string base64_chars =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        string encoded;
        int i = 0;
        int j = 0;
        uint8_t char_array_3[3];
        uint8_t char_array_4[4];

        for (uint8_t c : input) {
            char_array_3[i++] = c;
            if (i == 3) {
                char_array_4[0] = (char_array_3[0] & 0xfc) >> 2;
                char_array_4[1] = ((char_array_3[0] & 0x03) << 4) + ((char_array_3[1] & 0xf0) >> 4);
                char_array_4[2] = ((char_array_3[1] & 0x0f) << 2) + ((char_array_3[2] & 0xc0) >> 6);
                char_array_4[3] = char_array_3[2] & 0x3f;

                for(i = 0; i < 4; i++)
                    encoded += base64_chars[char_array_4[i]];
                i = 0;
            }
        }

        if (i) {
            for(j = i; j < 3; j++)
                char_array_3[j] = '\0';

            char_array_4[0] = (char_array_3[0] & 0xfc) >> 2;
            char_array_4[1] = ((char_array_3[0] & 0x03) << 4) + ((char_array_3[1] & 0xf0) >> 4);
            char_array_4[2] = ((char_array_3[1] & 0x0f) << 2) + ((char_array_3[2] & 0xc0) >> 6);
            char_array_4[3] = char_array_3[2] & 0x3f;

            for (j = 0; j < i + 1; j++)
                encoded += base64_chars[char_array_4[j]];

            while(i++ < 3)
                encoded += '=';
        }

        return encoded;
    }

    vector<uint8_t> base64_decode(const string& encoded_string) {
        const string base64_chars =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        int in_len = encoded_string.size();
        int i = 0;
        int j = 0;
        int in_ = 0;
        uint8_t char_array_4[4], char_array_3[3];
        vector<uint8_t> ret;

        while (in_len-- && (encoded_string[in_] != '=') && (isalnum(encoded_string[in_]) || (encoded_string[in_] == '+') || (encoded_string[in_] == '/'))) {
            char_array_4[i++] = encoded_string[in_]; in_++;
            if (i == 4) {
                for (i = 0; i < 4; i++)
                    char_array_4[i] = base64_chars.find(char_array_4[i]);

                char_array_3[0] = (char_array_4[0] << 2) + ((char_array_4[1] & 0x30) >> 4);
                char_array_3[1] = ((char_array_4[1] & 0xf) << 4) + ((char_array_4[2] & 0x3c) >> 2);
                char_array_3[2] = ((char_array_4[2] & 0x3) << 6) + char_array_4[3];

                for (i = 0; (i < 3); i++)
                    ret.push_back(char_array_3[i]);
                i = 0;
            }
        }

        if (i) {
            for (j = i; j < 4; j++)
                char_array_4[j] = 0;

            for (j = 0; j < 4; j++)
                char_array_4[j] = base64_chars.find(char_array_4[j]);

            char_array_3[0] = (char_array_4[0] << 2) + ((char_array_4[1] & 0x30) >> 4);
            char_array_3[1] = ((char_array_4[1] & 0xf) << 4) + ((char_array_4[2] & 0x3c) >> 2);
            char_array_3[2] = ((char_array_4[2] & 0x3) << 6) + char_array_4[3];

            for (j = 0; (j < i - 1); j++) ret.push_back(char_array_3[j]);
        }

        return ret;
    }

    // Simplified AES encryption (not secure, for demonstration only)
    vector<uint8_t> aes_encrypt(const string& plaintext, const vector<uint8_t>& key) {
        vector<uint8_t> ciphertext(plaintext.begin(), plaintext.end());
        for (size_t i = 0; i < ciphertext.size(); ++i) {
            ciphertext[i] ^= key[i % key.size()];
        }
        return ciphertext;
    }

    // Simplified AES decryption (not secure, for demonstration only)
    string aes_decrypt(const vector<uint8_t>& ciphertext, const vector<uint8_t>& key) {
        vector<uint8_t> plaintext = ciphertext;
        for (size_t i = 0; i < plaintext.size(); ++i) {
            plaintext[i] ^= key[i % key.size()];
        }
        return string(plaintext.begin(), plaintext.end());
    }

public:
    void encrypt() {
        string inputText, keyString;
        cout << "Enter the message to encrypt: ";
        getline(cin, inputText);
        mess = inputText;

        cout << "Enter the key (leave blank for random key): ";
        getline(cin, keyString);

        if (inputText.empty()) {
            cout << "Error: The message cannot be empty." << endl;
            return;
        }

        vector<uint8_t> key;
        if (keyString.empty()) {
            key = generateRandomKey();
            cout << "Generated key: " << base64_encode(key) << endl;
        } else {
            key = base64_decode(keyString);
        }

        try {
            vector<uint8_t> ciphertext = aes_encrypt(inputText, key);
            string encryptedText = base64_encode(ciphertext);
            cout << "Encrypted text: " << encryptedText << endl;
            cout << "Encryption successful." << endl;
        }
        catch (const exception& e) {
            cout << "Error occurred during encryption: " << e.what() << endl;
        }
    }

    void decrypt() {
        string inputText, keyString;
        cout << "Enter the text to decrypt: ";
        getline(cin, inputText);

        cout << "Enter the key: ";
        getline(cin, keyString);

        if (inputText.empty()) {
            cout << "Error: The ciphertext cannot be empty." << endl;
            return;
        }

        if (keyString.empty()) {
            cout << "Error: The key cannot be empty." << endl;
            return;
        }

        try {
            vector<uint8_t> ciphertext = base64_decode(inputText);
            vector<uint8_t> key = base64_decode(keyString);
            string decryptedText = aes_decrypt(ciphertext, key);

            if (!decryptedText.empty() && decryptedText != mess) {
                cout << "Warning: The ciphertext has been modified." << endl;
            }
            else {
                cout << "Decrypted text: " << decryptedText << endl;
                cout << "Decryption successful." << endl;
            }
        }
        catch (const exception& e) {
            cout << "Error occurred during decryption: " << e.what() << endl;
        }
    }
};

int main() {
    AES_Encryption aes;
    int choice;

    do {
        cout << "\n1. Encrypt\n2. Decrypt\n3. Exit\nEnter your choice: ";
        cin >> choice;
        cin.ignore();

        switch (choice) {
            case 1:
                aes.encrypt();
                break;
            case 2:
                aes.decrypt();
                break;
            case 3:
                cout << "Exiting..." << endl;
                break;
            default:
                cout << "Invalid choice. Please try again." << endl;
        }
    } while (choice != 3);

    return 0;
}
