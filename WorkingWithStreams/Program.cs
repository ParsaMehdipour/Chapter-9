﻿using System.Xml;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using static System.Console;

WorkWithText();

static void WorkWithText()
{
    // define a file to write to
    string textFile = Combine(CurrentDirectory, "streams.txt");
    // create a text file and return a helper writer
    StreamWriter text = File.CreateText(textFile);
    // enumerate the strings, writing each one
    // to the stream on a separate line
    foreach (string item in Viper.Callsigns)
    {
        text.WriteLine(item);
    }
    text.Close(); // release resources
                  // output the contents of the file

    TextReader textReader = new StreamReader(textFile);

    WriteLine("{0} contains {1:N0} bytes.",
    arg0: textFile,
    arg1: new FileInfo(textFile).Length);
    WriteLine(textReader.ReadToEnd());
}

static class Viper
{
    // define an array of Viper pilot call signs
    public static string[] Callsigns = new[]
    {
        "Husker", "Starbuck", "Apollo", "Boomer",
        "Bulldog", "Athena", "Helo", "Racetrack"
    };
}