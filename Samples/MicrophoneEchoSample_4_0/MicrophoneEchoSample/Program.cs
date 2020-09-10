#region File Information
//-----------------------------------------------------------------------------
// Program.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion
using System;

namespace MicrophoneEchoSample
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (MicrophoneEchoSampleGame game = new MicrophoneEchoSampleGame())
            {
                game.Run();
            }
        }
    }
#endif
}

