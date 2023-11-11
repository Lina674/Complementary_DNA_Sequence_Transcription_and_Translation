using System;

class Program {

    static void Main(string[] args) {

        Console.WriteLine("DNA/RNA"+"\n");
        string choice=Console.ReadLine();

        switch (choice) {
            case "DNA":
            string input=Console.ReadLine();
            char [] input1=input.ToCharArray();
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

        case "RNA":
            string inpuT=Console.ReadLine();
            char [] input2=inpuT.ToCharArray();
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
        break;

        }
        Console.ReadKey();

    }
}
