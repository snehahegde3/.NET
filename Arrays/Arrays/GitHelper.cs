using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitVersion;
using LibGit2Sharp;

namespace Arrays
{
    public class GitHelper
    {
        public static string pathToRepo = Directory.GetCurrentDirectory();
        public static string[] GetShortCommitSha()
        {
            // navigate to the Git repository directory
            var processStartInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = $"log -1 --pretty=format:%h%n%cd",
                WorkingDirectory = pathToRepo,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string[] outputLines = output.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                return outputLines;
            }
        }

        public static void Lib2GitHelper()
        {
            using (var repo = new Repository(pathToRepo))
            {
                var commit = repo.Head.Tip;
                Console.WriteLine($"Commit SHA: {commit.Sha}");
                Console.WriteLine($"Commit time: {commit.Author.When.ToLocalTime()}");
            }
        }

    }
}
