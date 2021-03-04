using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Office.Utils
{
    public class RandomImage
    {
        public static string[] RandomizeImages()
        {
            string[] fotos = Directory.GetFiles("wwwroot/img/home");
            var randomFotos = new List<string>();

            Random rand = new Random();

            var randomNumbers = Enumerable.Range(0, fotos.Length).OrderBy(x => rand.Next()).Take(fotos.Length).ToList();

            for (int i = 0; i < fotos.Length; i++)
            {
                randomFotos.Add(Path.GetFileName(fotos[randomNumbers[i]]));
            }
            
            return randomFotos.ToArray();
        }
    }
}
