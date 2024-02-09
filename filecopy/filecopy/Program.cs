using System;

namespace FileCopy
{
    class filecopy
    {
        static void Main(String[] args)
        {
            FileStream f1 = new FileStream("F:\\T001_A\\MIS\\Analytical Software linked with video for precise game judgement.docx", FileMode.OpenOrCreate);
            FileStream f2 = new FileStream("F:\\T001_A\\MIS\\copied.docx", FileMode.OpenOrCreate);
            int i;
            while ((i = f1.ReadByte()) != -1)
            {
                f2.WriteByte((byte)i);
            }
            Console.WriteLine("File copied");
            f1.Close();
            f2.Close();
            Console.ReadKey();
        }
    }
}

