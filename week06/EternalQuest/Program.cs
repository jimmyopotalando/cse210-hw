using System;
using System.Collections.Generic;
using System.IO;

// Entry point
// Program.cs — Eternal Quest Project
// Author: Jimmy Opot Alando
// W06 Project
//
// ❗ EXCEEDS REQUIREMENTS:
// ---------------------------------------------
// ✅ Added Leveling System (Levels increase every 1000 points)
// ✅ Added Celebration Badges when completing major goals or leveling up
// ✅ Added ASCII art for fun/visual achievement feedback
// ✅ Added Support for Negative Goals (bad habits cost points)
// ✅ Added Save/Load for both Score and Level
// ✅ Used Console art to improve user experience and engagement
// ---------------------------------------------

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🛡️ WELCOME TO THE ETERNAL QUEST 🛡️");
        Console.WriteLine("Embark on your journey to greatness!");
        Console.WriteLine("------------------------------------");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
