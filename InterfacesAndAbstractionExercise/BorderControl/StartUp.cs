﻿using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RunControl();
        }

        private static void RunControl()
        {
            var tryingToPass = new HashSet<string>();
            var input = Console.ReadLine().Trim();

            while (input != "End")
            {
                tryingToPass.Add(input);
                input = Console.ReadLine().Trim();
            }

            var fakeIdsEndsWith = Console.ReadLine().Trim();
            PritnDetainedIds(tryingToPass, ref fakeIdsEndsWith);
        }

        private static void PritnDetainedIds(HashSet<string> tryingToPass, ref string fakeIdsEndsWith)
        {
            foreach (var entityData in tryingToPass)
            {
                if (entityData.EndsWith(fakeIdsEndsWith))
                {
                    Console.WriteLine(entityData.Substring(entityData.LastIndexOf(' ') + 1));
                }
            }
        }
    }
}
