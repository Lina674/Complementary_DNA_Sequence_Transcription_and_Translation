using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

class Program {

    static void Main(string[] args) {

        string textFromFile = File.ReadAllText("dna.txt", Encoding.UTF8);
        Console.WriteLine(textFromFile);

        Console.WriteLine("\n"+"Complementary Base of DNA, Transcription + Translation, or RNA => Protein (C, T, P)?"+"\n");
        string choice=Console.ReadLine();
        string choice1=choice.ToUpper();

        string [] codon={"UUU", "UUC", "UUA", "UUG", "CUU", "CUC", "CUA", "CUG",
        "AUU", "AUC", "AUA", "AUG", "GUU", "GUC", "GUA", "GUG", "UCU", "UCC", "UCA",
        "UCG", "CCU", "CCC", "CCA", "CCG", "ACU", "ACC", "ACA", "ACG", "GCU",
        "GCC", "GCA", "GCG", "UAU", "UAC", "CAU", "CAC", "CAA", "CAG",
        "AAU", "AAC", "AAA", "AAG", "GAU", "GAC", "GAA", "GAG",
        "UGU", "UGC", "UGG", "CGU", "CGC", "CGA", "CGG", "AGU",
        "AGC", "AGA", "AGG", "GGU", "GGC", "GGA", "GGG"};

        string [] protein={"Phenylalanine", "Phenylalanine", "Leucine", "Leucine", "Leucine", 
        "Leucine", "Leucine", "Leucine", "Isoleucine", "Isoleucine", "Isoleucine",
        "Methionine", "Valine", "Valine", "Valine", "Valine", "Serine", "Serine",
        "Serine", "Serine", "Proline", "Proline", "Proline", "Proline",
        "Threonine", "Threonine", "Threonine", "Threonine", "Alanine", "Alanine",
        "Alanine", "Alanine", "Tyrosine", "Tyrosine", "Histidine", "Histidine", "Glutamine",
        "Glutamine", "Asparagine", "Asparagine", "Lysine", "Lysine", "Aspartic Acid",
        "Aspartic Acid", "Glutamic Acid", "Glutamic Acid", "Cysteine", "Cysteine", "Tryptophan",
        "Arginine", "Arginine", "Arginine", "Arginine", "Serine", "Serine", "Arginine", "Arginine",
        "Glycine", "Glycine", "Glycine", "Glycine"};

        switch (choice1) {
            case "C":
            string input=Console.ReadLine();
            string input0=input.ToUpper();
            char [] input1=input0.ToCharArray();
            char [] newInput=new char[input1.Length];

            for (int i=0; i<input1.Length; i++) {
                char scan=input1[i];

                switch (scan) {
                case 'A':
                newInput[i]='T';
                break;

                case 'T':
                newInput[i]='A';
                break;

                case 'G':
                newInput[i]='C';
                break;

                case 'C':
                newInput[i]='G';
                break;

                }

            }

        string finalD=string.Join("", newInput);
        Console.WriteLine("\n"+finalD);

        break;

        case "P":
            string input_=Console.ReadLine();
            string input_0=input_.ToUpper();
            char [] input_2=input_0.ToCharArray();
            char [] newInput_1=new char[input_2.Length];

            int ini_=input_0.IndexOf("AUG");
        //Console.WriteLine(ini);
        int fin_=input_0.IndexOf("UAA");
        int fin_1=input_0.IndexOf("UAG");
        int fin_2=input_0.IndexOf("UGA");
        int smallest_ = int.MaxValue;

        if (fin_!= -1 && fin_ < smallest_)
        {
            smallest_ = fin_;
        }

        if (fin_1 != -1 && fin_1 < smallest_)
        {
            smallest_ = fin_1;
        }

        if (fin_2 != -1 && fin_2 < smallest_)
        {
            smallest_ = fin_2;
        }
        
        else if (fin_==-1 && fin_1==-1 && fin_2==-1) {
            Console.WriteLine("No stop codon in the sequence.");
        }
        //Console.WriteLine(smallest);
        //string med=input_0.Substring(ini, smallest);
        if (ini_==-1) {
            Console.WriteLine("No start codon in the sequence");
        }
        else{
        string med1=input_0.Substring(ini_, smallest_-3);
        //Console.WriteLine(med);
        Console.WriteLine(med1);
        //Console.WriteLine((med1.Length)/3);

        int begin = 0;
        int end = 3;
        string[] codons= new string [(med1.Length)/3];
        
        for (int i=0; i<codons.Length; i++) {
            string cod = med1.Substring(begin, 3);
            codons[i]=cod;
            begin+=end;
            //end=end+3;
        }
        //Console.WriteLine(codons[1]);
        
        string[] protSqnc = new string[codons.Length];
        for (int j=0; j<codons.Length; j++) {
            string unit = codons[j];
            int unitPos = Array.IndexOf(codon, unit);
            string prot = protein[unitPos];
            protSqnc[j]=prot;
        }
        string sqnc = String.Join("-", protSqnc);
        Console.WriteLine("\n"+sqnc);
        
        }
        
        string input_0P=string.Join("", newInput_1);
        Console.WriteLine("\n"+input_0P);
        break;

        case "T":
            string inpuT=Console.ReadLine();
            string inpuT0=inpuT.ToUpper();
            char [] input2=inpuT0.ToCharArray();
            char [] newInput1=new char[input2.Length];

            for (int i=0; i<input2.Length; i++) {
                char scan=input2[i];

                switch (scan) {
                case 'A':
                newInput1[i]='U';
                break;

                case 'T':
                newInput1[i]='A';
                break;

                case 'G':
                newInput1[i]='C';
                break;

                case 'C':
                newInput1[i]='G';
                break;

                }

            }

        string finalR=string.Join("", newInput1);
        Console.WriteLine("\n"+finalR);
        
        //begin new
        int ini=finalR.IndexOf("AUG");
        //Console.WriteLine(ini);
        int fin=finalR.IndexOf("UAA");
        int fin1=finalR.IndexOf("UAG");
        int fin2=finalR.IndexOf("UGA");
        int smallest = int.MaxValue;

        if (fin!= -1 && fin < smallest)
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
        
        else if (fin==-1 && fin1==-1 && fin2==-1) {
            Console.WriteLine("No stop codon in the sequence.");
        }
        //Console.WriteLine(smallest);
        //string med=finalR.Substring(ini, smallest);
        if (ini==-1) {
            Console.WriteLine("No start codon in the sequence");
        }
        else{
        string med1=finalR.Substring(ini, smallest-3);
        //Console.WriteLine(med);
        Console.WriteLine(med1);
        //Console.WriteLine((med1.Length)/3);

        int begin = 0;
        int end = 3;
        string[] codons= new string [(med1.Length)/3];
        
        for (int i=0; i<codons.Length; i++) {
            string cod = med1.Substring(begin, 3);
            codons[i]=cod;
            begin+=end;
            //end=end+3;
        }
        //Console.WriteLine(codons[1]);
        
        string[] protSqnc = new string[codons.Length];
        for (int j=0; j<codons.Length; j++) {
            string unit = codons[j];
            int unitPos = Array.IndexOf(codon, unit);
            string prot = protein[unitPos];
            protSqnc[j]=prot;
        }
        string sqnc = String.Join("-", protSqnc);
        Console.WriteLine("\n"+sqnc);
        
        }
        
        break;

        }
        Console.ReadKey();

    }
}
