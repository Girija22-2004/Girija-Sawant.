using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();  
        Console.WriteLine(" *** STRING PROGRAMS *** ");
        Console.WriteLine(" Choose the following String Program ");
        Console.WriteLine();
        Console.WriteLine("1. Length of String");
        Console.WriteLine("2. Copy String");
        Console.WriteLine("3. Concatenate Strings");
        Console.WriteLine("4. Compare Strings");
        Console.WriteLine("5. Lowercase to Uppercase");
        Console.WriteLine("6. Uppercase to Lowercase");
        Console.WriteLine("7. Toggle Case");
        Console.WriteLine("8. Count Alphabets, Digits, Special Characters");
        Console.WriteLine("9. Count Vowels and Consonants");
        Console.WriteLine("10. Count Words");
        Console.WriteLine("11. Reverse String");
        Console.WriteLine("12. Check Palindrome");
        Console.WriteLine("13. Reverse Order of Words");
        Console.WriteLine("14. First Occurrence of Character");
        Console.WriteLine("15. Last Occurrence of Character");
        Console.WriteLine("16. All Occurrences of Character");
        Console.WriteLine("17. Count Occurrences of Character");
        Console.WriteLine("18. Highest Frequency Character");
        Console.WriteLine("19. Lowest Frequency Character");
        Console.WriteLine("20. Frequency of Each Character");
        Console.WriteLine("21. Remove First Occurrence");
        Console.WriteLine("22. Remove Last Occurrence");
        Console.WriteLine("23. Remove All Occurrences");
        Console.WriteLine("24. Remove Repeated Characters");
        Console.WriteLine("25. Replace First Occurrence");
        Console.WriteLine("26. Replace Last Occurrence");
        Console.WriteLine("27. Replace All Occurrences");
        Console.WriteLine("28. Trim Leading Spaces");
        Console.WriteLine("29. Trim Trailing Spaces");
        Console.WriteLine("30. Trim Both Sides");
        Console.WriteLine("31. Remove Extra Spaces");
        Console.WriteLine();

        int choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
             Length();
              break;
            case 2:
             Copy();
              break;
            case 3:
             Concatenate();
              break;
            case 4:
             Compare();
              break;
            case 5:
             ToUpper();
              break;
            case 6:
             ToLower();
              break;
            case 7: 
             Toggle();
              break;
            case 8:
             CountTypes();
              break;
            case 9:
             VowelsConsonants();
              break;
            case 10:
             WordCount();
              break;
            case 11:
             Reverse();
              break;
            case 12:
             Palindrome();
              break;
            case 13:
             ReverseWords();
              break;
            case 14:
             FirstOccur();
              break;
            case 15:
             LastOccur();
              break;
            case 16:
             AllOccur();
              break;
            case 17:
             CountOccur();
              break;
            case 18:
             HighestFreq();
              break;
            case 19:
             LowestFreq();
              break;
            case 20:
             CharFrequency();
              break;
            case 21:
             RemoveFirst();
              break;
            case 22:
             RemoveLast();
              break;
            case 23:
             RemoveAll();
              break;
            case 24:
             RemoveRepeated();
              break;
            case 25:
             ReplaceFirst();
              break;
            case 26:
             ReplaceLast();
              break;
            case 27:
             ReplaceAll();
              break;
            case 28:
             TrimStart();
              break;
            case 29:
             TrimEnd();
              break;
            case 30:
             TrimBoth();
              break;
            case 31:
             RemoveExtraSpaces(); break;
            default: Console.WriteLine("Invalid Choice"); break;
        }
    }

    static string Read()
        {
             Console.Write("Enter string: ");
              return
               Console.ReadLine()!;
        }
  
    static void Length() => Console.WriteLine("Length = " + Read().Length);

    static void Copy() 
        {
             string s = Read(); string c = string.Copy(s);
                Console.WriteLine("Copied = " + c);
        }
    static void Concatenate()
        {
             Console.WriteLine(Read() + Read()); 
        }
    static void Compare()
        {
             Console.WriteLine(Read() == Read() ? "Equal" : "Not Equal"); 
        }

    static void ToUpper() => Console.WriteLine(Read().ToUpper());
    static void ToLower() => Console.WriteLine(Read().ToLower());

    static void Toggle()
    {
        string s = Read(); char[] c = s.ToCharArray();
        for (int i = 0; i < c.Length; i++)
            c[i] = char.IsUpper(c[i]) ? char.ToLower(c[i]) : char.ToUpper(c[i]);
        Console.WriteLine(new string(c));
    }

    static void CountTypes()
    {
        string s = Read(); int a = 0, d = 0, sp = 0;
        foreach (char c in s)
            if (char.IsLetter(c)) a++;
            else if (char.IsDigit(c)) d++;
            else sp++;
        Console.WriteLine($"Alphabets={a}, Digits={d}, Special={sp}");
    }

    static void VowelsConsonants()
    {
        string s = Read().ToLower(); int v = 0, c = 0;
        foreach (char ch in s)
            if ("aeiou".Contains(ch)) v++;
            else if (char.IsLetter(ch)) c++;
        Console.WriteLine($"Vowels={v}, Consonants={c}");
    }

    static void WordCount() => 
     Console.WriteLine("Words = " + Read().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);

    static void Reverse()
    {
        char[] c = Read().ToCharArray();
        Array.Reverse(c);
        Console.WriteLine(new string(c));
    }

    static void Palindrome()
    {
        string s = Read(); char[] c = s.ToCharArray();
        Array.Reverse(c);
        Console.WriteLine(s == new string(c) ? "Palindrome" : "Not Palindrome");
    }

    static void ReverseWords()
    {
        string[] w = Read().Split(' ');
        Array.Reverse(w);
        Console.WriteLine(string.Join(" ", w));
    }


    static void FirstOccur()
    {
        string s = Read();
        char ch = Console.ReadKey().KeyChar; 
        Console.WriteLine("\nIndex=" + s.IndexOf(ch));
    }
    static void LastOccur()
    {
        string s = Read(); char ch = Console.ReadKey().KeyChar;
        Console.WriteLine("\nIndex=" + s.LastIndexOf(ch)); 
    }

    static void AllOccur()
    {
        string s = Read(); char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();
        for (int i = 0; i < s.Length; i++)
            if (s[i] == ch) Console.Write(i + " ");
    }

    static void CountOccur()
    {
        string s = Read(); char ch = Console.ReadKey().KeyChar; int c = 0;
        foreach (char x in s) if (x == ch) c++;
        Console.WriteLine("\nCount=" + c);
    }

    static void HighestFreq()
    {
        string s = Read(); int max = 0; char res = ' ';
        foreach (char c in s)
        {
            int cnt = s.Split(c).Length - 1;
            if (cnt > max) { max = cnt; res = c; }
        }
        Console.WriteLine($"Highest: {res} ({max})");
    }

    static void LowestFreq()
    {
        string s = Read(); int min = int.MaxValue; char res = ' ';
        foreach (char c in s)
        {
            int cnt = s.Split(c).Length - 1;
            if (cnt < min && cnt > 0) { min = cnt; res = c; }
        }
        Console.WriteLine($"Lowest: {res} ({min})");
    }



    static void CharFrequency()
    {
        string s = Read();
        foreach (char c in s)
            Console.WriteLine($"{c} -> {s.Split(c).Length - 1}");
    }




static void RemoveFirst()
{
    string s = Read();
    char c = Console.ReadKey().KeyChar;
    int index = s.IndexOf(c);

    if (index != -1)
        Console.WriteLine("\n" + s.Remove(index, 1));
    else
        Console.WriteLine("\nCharacter not found ");
}

static void RemoveLast() 
{ 
    string s = Read();
    char c = Console.ReadKey().KeyChar;
   int index = s.LastIndexOf(c);

    if (index != -1)
        Console.WriteLine("\n" + s.Remove(index, 1));
    else
        Console.WriteLine("\nCharacter not found ");       
 }


static void RemoveAll() 
{
     string s = Read(); 
     char c = Console.ReadKey().KeyChar; 
    
     if (s.Contains(c))
         Console.WriteLine("\n" + s.Replace(c.ToString(), ""));
      else
         Console.WriteLine("\nCharacter not found");
}

static void RemoveRepeated()
    {
        string s = Read(); string r = "";
        foreach (char c in s) if (!r.Contains(c)) r += c;
        Console.WriteLine(r);
    }


static void ReplaceFirst()
   { 
       string s = Read();

        Console.Write("\nEnter old character: ");
        char o = Console.ReadKey().KeyChar;

        Console.Write("\nEnter new character: ");
        char n = Console.ReadKey().KeyChar;

        int index = s.IndexOf(o);

    if (index != -1)
    {
        s = s.Remove(index, 1)
             .Insert(index, n.ToString());

        Console.WriteLine("\nResult: " + s);
    }
    else
    {
        Console.WriteLine("\nCharacter not found");
    }
}
    

static void ReplaceLast()
    {
       string s = Read();

        Console.Write("\nEnter old character: ");
        char o = Console.ReadKey().KeyChar;
        
        Console.Write("\nEnter new character:");
        char n = Console.ReadKey().KeyChar;

        int index = s.LastIndexOf(o);

    if (index != -1)
    {
        s = s.Remove(index, 1)
             .Insert(index, n.ToString());

        Console.WriteLine("\nResult: " + s);
    }
    else
    {
        Console.WriteLine("\nCharacter not found");
    }
}
   


static void ReplaceAll()
{
    
    string s = Read();

    Console.Write("Enter character to replace: ");
    char o = Console.ReadKey().KeyChar;
    Console.WriteLine();

    Console.Write("Enter new character: ");
    char n = Console.ReadKey().KeyChar;
    Console.WriteLine();

    Console.WriteLine("Result: " + s.Replace(o, n));
}



static void TrimStart()
{
    Console.WriteLine(Read().TrimStart());
}

   
    static void TrimEnd() => Console.WriteLine(Read().TrimEnd());
    static void TrimBoth() => Console.WriteLine(Read().Trim());

    static void RemoveExtraSpaces()
{
    Console.WriteLine(
        string.Join(" ", Read().Split(' ', StringSplitOptions.RemoveEmptyEntries))
    );
}

}