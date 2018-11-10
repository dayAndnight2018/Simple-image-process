﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEnhancement
{
    class Binarization
    {
        Bitmap source;       
        int height = 0;
        int width = 0;
        public Binarization(string path)
        {
            source = new Bitmap(path);
            height = source.Height;
            width = source.Width;

        }
        public Bitmap GetBinarization()
        {
            Bitmap destation = new Bitmap(width, height);
            Color c ;
            int temp = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    temp = ((int)((source.GetPixel(i, j).R + source.GetPixel(i, j).G + source.GetPixel(i, j).B) / 3)) >= 128 ? 255 : 0;
                    c = Color.FromArgb(temp,temp,temp);
                    destation.SetPixel(i, j, c);
                }
            }
            return destation;
        }
    }
}
