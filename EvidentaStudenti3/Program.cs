﻿using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ionescu");
            //s.SetNote("");

            int[] noteStd;
            noteStd = new int[5];
            int linii = 4; 
            string[][] noteTablou = new string[linii][];
            for (int i = 0; i < linii; i++)
                noteTablou[i] = new string[0];
            Student tab = new Student("Tablou");


            bool validare = true;
            while (validare)
            {
                Console.Clear();
                Console.WriteLine("S.Citeste note de la tastatura ca un sir de caractere");
                Console.WriteLine("T.Citeste note de la tastatura(cate o nota pe rand)");
                Console.WriteLine("C.Citeste note din linia de comanda");
                Console.WriteLine("A.Afisare note");
                Console.WriteLine("I.Info autor");
                Console.WriteLine("X.Iesire.");
                Console.WriteLine("\nSelectati o optiune : ");


                switch (Console.ReadLine())
                {
                    case "S":
                        Console.WriteLine("Introduceti notele ca un sir de caractere: ");
                        string notes = Console.ReadLine();
                        tab.SetNote(notes);
                        tab.ConversieLaSir();
                        Console.ReadKey();
                        break;
                    case "T":
                        Console.WriteLine("Introduceti notele de la tastatura(cate o nota pe rand):");
                        int[] nota;
                        for (int i = 0; i < linii; i++)
                        {
                            Console.WriteLine("Introduceti numarul de note din anul {0}", i);
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduceti cate o nota pe rand :");
                            nota = new int[n];
                            for (int j = 0; j < n; j++)
                            {
                                nota[j] = Convert.ToInt32(Console.ReadLine());
                            }
                            tab.SetNoteRand(nota, n, i);
                        }
                       
                        Console.ReadKey();
                        break;
                    case "C":
                        string NoteCmd = "Nu exista note in linia de comanda";
                        NoteCmd = string.Join(" ", args);
                        Console.WriteLine(NoteCmd);
                        Console.ReadKey();
                        break;
                    default:
                        validare = false;
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
