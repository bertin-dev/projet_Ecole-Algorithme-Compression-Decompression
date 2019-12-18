using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace projet_Ecole_Algorithme_Compression_Decompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Huffman Code avec fichier, by bertin.dev and Michel";

            Console.WriteLine("S'il vous plait entrer une Chaine de caractère:");
            string input = Console.ReadLine();
            HuffmanTree huffmanTree = new HuffmanTree();

            // Build the Huffman tree
            huffmanTree.Build(input);

            // Encodage
            BitArray encoded = huffmanTree.Encode(input);

            Console.Write("Encodage: ");
            foreach (bool bit in encoded)
            {
                Console.Write((bit ? 1 : 0) + "");
            }
            Console.WriteLine();

            // Decode
            string decoded = huffmanTree.Decode(encoded);

            Console.WriteLine("Decodage: " + decoded);

            Console.ReadLine();
        }


    }
}
