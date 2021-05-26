﻿using System;
using System.Diagnostics;

namespace Metaphor_Antivirus.Common
{
    class Helper
    {
        public static void RunCommand(string command)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;

                try
                {
                    process.Start(); // start a command prompt

                    process.StandardInput.WriteLine(command); // run the command
                    process.StandardInput.Close();
                    process.WaitForExit();
                }
                catch (Exception) { }
            }
        }

        public static string RunCommandReturn(string command)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;

                try
                {
                    process.Start(); // start a command prompt

                    process.StandardInput.WriteLine(command); // run the command
                    process.StandardInput.Close();
                    process.WaitForExit();

                    return process.StandardOutput.ReadToEnd();
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }

            return null;
        }
    }
}
