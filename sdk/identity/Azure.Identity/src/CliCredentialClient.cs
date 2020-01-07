﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Azure.Identity
{
    internal class CliCredentialClient
    {
        public virtual (string, int) CreateProcess(string extendCommand)
        {
            string fileName = string.Empty;
            string argument = string.Empty;
            int exitCode = default;

            StringBuilder stdOutput = new StringBuilder();
            StringBuilder stdError = new StringBuilder();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                fileName = "cmd";
                argument = $"/c \"{extendCommand}\"";
            }
            else
            {
                fileName = "/bin/sh";
                argument = $"-c \"{extendCommand}\"";
            }

            using (Process proc = new Process())
            {

                ProcessStartInfo procStartInfo = new ProcessStartInfo()
                {
                    FileName = fileName,
                    Arguments = argument,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                proc.StartInfo = procStartInfo;
                proc.OutputDataReceived += new DataReceivedEventHandler((sender, e) => stdOutput.AppendLine(e.Data));
                proc.ErrorDataReceived += new DataReceivedEventHandler((sender, e) => stdError.AppendLine(e.Data));

                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                proc.WaitForExit();

                exitCode = proc.ExitCode;
            }

            if (exitCode != 0)
            {
                return (stdError.ToString(), exitCode);
            }
            else
            {
                return (stdOutput.ToString(), exitCode);
            }
        }
    }
}
