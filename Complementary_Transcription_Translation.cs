using System.Text;

class Program
{

    static void Main(string[] args)
    {

        string textFromFile = File.ReadAllText("dna.txt", Encoding.UTF8);
        Console.WriteLine(textFromFile);

        Console.WriteLine("\n" + "Complementary Base of DNA, Transcription + Translation, T + T (without start codon), RNA => Protein, or R => P (without start codon) (C, T, TW, P, PW)?" + "\n");
        string choice = Console.ReadLine();
        string choice1 = choice.ToUpper();

        string[] codon ={"UUU", "UUC", "UUA", "UUG", "CUU", "CUC", "CUA", "CUG",
        "AUU", "AUC", "AUA", "AUG", "GUU", "GUC", "GUA", "GUG", "UCU", "UCC", "UCA",
        "UCG", "CCU", "CCC", "CCA", "CCG", "ACU", "ACC", "ACA", "ACG", "GCU",
        "GCC", "GCA", "GCG", "UAU", "UAC", "CAU", "CAC", "CAA", "CAG",
        "AAU", "AAC", "AAA", "AAG", "GAU", "GAC", "GAA", "GAG",
        "UGU", "UGC", "UGG", "CGU", "CGC", "CGA", "CGG", "AGU",
        "AGC", "AGA", "AGG", "GGU", "GGC", "GGA", "GGG", "UAA", "UGA", "UAG"};

        string[] protein ={"Phenylalanine", "Phenylalanine", "Leucine", "Leucine", "Leucine",
        "Leucine", "Leucine", "Leucine", "Isoleucine", "Isoleucine", "Isoleucine",
        "Methionine", "Valine", "Valine", "Valine", "Valine", "Serine", "Serine",
        "Serine", "Serine", "Proline", "Proline", "Proline", "Proline",
        "Threonine", "Threonine", "Threonine", "Threonine", "Alanine", "Alanine",
        "Alanine", "Alanine", "Tyrosine", "Tyrosine", "Histidine", "Histidine", "Glutamine",
        "Glutamine", "Asparagine", "Asparagine", "Lysine", "Lysine", "Aspartic Acid",
        "Aspartic Acid", "Glutamic Acid", "Glutamic Acid", "Cysteine", "Cysteine", "Tryptophan",
        "Arginine", "Arginine", "Arginine", "Arginine", "Serine", "Serine", "Arginine", "Arginine",
        "Glycine", "Glycine", "Glycine", "Glycine", "", "", ""};

        switch (choice1)
        {
            case "C":
                Console.Write("\nInsert DNA sequence: ");
                string input = Console.ReadLine();
                string input0 = input.ToUpper();
                char[] input1 = input0.ToCharArray();
                char[] newInput = new char[input1.Length];

                for (int i = 0; i < input1.Length; i++)
                {
                    char scan = input1[i];

                    switch (scan)
                    {
                        case 'A':
                            newInput[i] = 'T';
                            break;

                        case 'T':
                            newInput[i] = 'A';
                            break;

                        case 'G':
                            newInput[i] = 'C';
                            break;

                        case 'C':
                            newInput[i] = 'G';
                            break;

                    }

                }

                string finalD = string.Join("", newInput);
                Console.WriteLine("\nThe complementary DNA sequence is: " + finalD);

                break;
            case "PW":
                Console.Write("\nInsert RNA sequence: ");
                string input0_ = Console.ReadLine();
                string input_00 = input0_.ToUpper();

                string[] triplets_0 = new string[(input_00.Length) / 3];
                int ini0 = 0;

                for (int i = 0; ini0 < input_00.Length; i++)
                {
                    string str0 = input_00.Substring(ini0, 3);
                    triplets_0[i] = str0;
                    ini0 += 3;
                }
                string[] protSqnc_0 = new string[triplets_0.Length];

                for (int j = 0; j < triplets_0.Length; j++)
                {
                    string unit = triplets_0[j];
                    int unitPos = Array.IndexOf(codon, unit);
                    string prot = protein[unitPos];
                    protSqnc_0[j] = prot;
                }
                string sqnc0 = String.Join("-", protSqnc_0);
                Console.WriteLine("\nThe protein sequence is: " + sqnc0);

                break;
            case "P":
                Console.Write("\nInsert RNA sequence: ");
                string input_ = Console.ReadLine();
                string input_0 = input_.ToUpper();


                int ini = input_0.IndexOf("AUG");
                if (ini == -1)
                {
                    Console.WriteLine("No start codon in the sequence.");
                }
                else
                {
                    string[] triplets_ = new string[100];

                    for (int i = 0; ini < input_0.Length; i++)
                    {
                        string str = input_0.Substring(ini, 3);
                        triplets_[i] = str;
                        ini += 3;
                    }

                    int fin = Array.IndexOf(triplets_, "UAA");
                    int fin1 = Array.IndexOf(triplets_, "UAG");
                    int fin2 = Array.IndexOf(triplets_, "UGA");
                    int smallest = int.MaxValue;

                    if (fin != -1 && fin < smallest)
                    {
                        smallest = fin;
                    }

                    if (fin1 != -1 && fin1 < smallest)
                    {
                        smallest = fin1;
                    }

                    if (fin2 != -1 && fin2 < smallest)
                    {
                        smallest = fin2;
                    }

                    else if (fin == -1 && fin1 == -1 && fin2 == -1)
                    {
                        Console.WriteLine("No stop codon in the sequence.");
                    }

                    string[] tripNew_ = new string[smallest];
                    Array.Copy(triplets_, 0, tripNew_, 0, smallest);

                    string[] protSqnc = new string[tripNew_.Length];

                    for (int j = 0; j < tripNew_.Length; j++)
                    {
                        string unit = tripNew_[j];
                        int unitPos = Array.IndexOf(codon, unit);
                        string prot = protein[unitPos];
                        protSqnc[j] = prot;
                    }
                    string sqnc = String.Join("-", protSqnc);
                    Console.WriteLine("\nThe protein sequence is: " + sqnc);
                }
                break;
            case "TW":
                Console.Write("\nInsert the DNA sequence: ");
                string inpuTm_ = Console.ReadLine();
                string inpuT0m_ = inpuTm_.ToUpper();
                char[] input2m_ = inpuT0m_.ToCharArray();
                char[] newInput1m_ = new char[input2m_.Length];

                for (int i = 0; i < input2m_.Length; i++)
                {
                    char scan = input2m_[i];

                    switch (scan)
                    {
                        case 'A':
                            newInput1m_[i] = 'U';
                            break;

                        case 'T':
                            newInput1m_[i] = 'A';
                            break;

                        case 'G':
                            newInput1m_[i] = 'C';
                            break;

                        case 'C':
                            newInput1m_[i] = 'G';
                            break;

                    }

                }

                string finalRm_ = string.Join("", newInput1m_);
                Console.WriteLine("\nThe RNA sequence is: " + finalRm_);


                string[] triplets1 = new string[(inpuTm_.Length) / 3];
                int ini1 = 0;

                for (int i = 0; ini1 < finalRm_.Length; i++)
                {
                    string str1 = finalRm_.Substring(ini1, 3);
                    triplets1[i] = str1;
                    ini1 += 3;
                }


                string[] protSqnc1 = new string[triplets1.Length];

                for (int j = 0; j < triplets1.Length; j++)
                {
                    string unit = triplets1[j];
                    int unitPos = Array.IndexOf(codon, unit);
                    string prot = protein[unitPos];
                    protSqnc1[j] = prot;
                }
                string sqnc1 = String.Join("-", protSqnc1);
                Console.WriteLine("\nThe protein sequence is: " + sqnc1);


                break;
            case "T":
                Console.Write("\nInsert the DNA sequence: ");
                string inpuTm = Console.ReadLine();
                string inpuT0m = inpuTm.ToUpper();
                char[] input2m = inpuT0m.ToCharArray();
                char[] newInput1m = new char[input2m.Length];

                for (int i = 0; i < input2m.Length; i++)
                {
                    char scan = input2m[i];

                    switch (scan)
                    {
                        case 'A':
                            newInput1m[i] = 'U';
                            break;

                        case 'T':
                            newInput1m[i] = 'A';
                            break;

                        case 'G':
                            newInput1m[i] = 'C';
                            break;

                        case 'C':
                            newInput1m[i] = 'G';
                            break;

                    }

                }

                string finalRm = string.Join("", newInput1m);
                Console.WriteLine("\nThe RNA sequence is: " + finalRm);

                int inim = finalRm.IndexOf("AUG");
                if (inim == -1)
                {
                    Console.WriteLine("No start codon in the sequence.");
                }
                else
                {
                    string[] triplets = new string[100];

                    for (int i = 0; inim < finalRm.Length; i++)
                    {
                        string str = finalRm.Substring(inim, 3);
                        triplets[i] = str;
                        inim += 3;
                    }

                    int finm = Array.IndexOf(triplets, "UAA");
                    int fin1m = Array.IndexOf(triplets, "UAG");
                    int fin2m = Array.IndexOf(triplets, "UGA");
                    int smallestm = int.MaxValue;

                    if (finm != -1 && finm < smallestm)
                    {
                        smallestm = finm;
                    }

                    if (fin1m != -1 && fin1m < smallestm)
                    {
                        smallestm = fin1m;
                    }

                    if (fin2m != -1 && fin2m < smallestm)
                    {
                        smallestm = fin2m;
                    }

                    else if (finm == -1 && fin1m == -1 && fin2m == -1)
                    {
                        Console.WriteLine("No stop codon in the sequence.");
                    }

                    string[] tripNew = new string[smallestm];
                    Array.Copy(triplets, 0, tripNew, 0, smallestm);

                    string[] protSqnc = new string[tripNew.Length];

                    for (int j = 0; j < tripNew.Length; j++)
                    {
                        string unit = tripNew[j];
                        int unitPos = Array.IndexOf(codon, unit);
                        string prot = protein[unitPos];
                        protSqnc[j] = prot;
                    }
                    string sqnc = String.Join("-", protSqnc);
                    Console.WriteLine("\nThe protein sequence is: " + sqnc);
                }
                Console.WriteLine("\nRemember! There is no such thing as a stop amino acid.");

                break;
        }
        Console.ReadKey();
    }
}
