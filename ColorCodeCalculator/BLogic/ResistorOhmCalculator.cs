using ColorCodeCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColorCodeCalculator.BLogic
{
    public class ResistorOhmCalculator: IOhmValueCalculator
    {

        public float CalculateOhmValue(int bandAColor, int bandBColor, float multiplier, float tolerance)
        {
            //add Logic to calculate Resistor value
            var baseOhmValue = ((bandAColor * 10) + bandBColor) * multiplier;
            return baseOhmValue;
        }

        public List<BandColor> getColorBand1List()
        {
            List<BandColor> colBrand1 = new List<BandColor>();
            colBrand1.Add(new BandColor { Color = "Brown", ResistanceValue = 1 });
            colBrand1.Add(new BandColor { Color = "Red", ResistanceValue = 2 });
            colBrand1.Add(new BandColor { Color = "Orange", ResistanceValue = 3 });
            colBrand1.Add(new BandColor { Color = "Yellow", ResistanceValue = 4 });
            colBrand1.Add(new BandColor { Color = "Green", ResistanceValue = 5 });
            colBrand1.Add(new BandColor { Color = "Blue", ResistanceValue = 6 });
            colBrand1.Add(new BandColor { Color = "Violet", ResistanceValue = 7 });
            colBrand1.Add(new BandColor { Color = "Gray", ResistanceValue = 8 });
            colBrand1.Add(new BandColor { Color = "White", ResistanceValue = 9 });

            return colBrand1;
        }

        public List<BandColor> getColorBand2List()
        {
            List<BandColor> colBrand2 = new List<BandColor>();
            colBrand2.Add(new BandColor { Color = "Black", ResistanceValue = 0 });
            colBrand2.Add(new BandColor { Color = "Brown", ResistanceValue = 1 });
            colBrand2.Add(new BandColor { Color = "Red", ResistanceValue = 2 });
            colBrand2.Add(new BandColor { Color = "Orange", ResistanceValue = 3 });
            colBrand2.Add(new BandColor { Color = "Yellow", ResistanceValue = 4 });
            colBrand2.Add(new BandColor { Color = "Green", ResistanceValue = 5 });
            colBrand2.Add(new BandColor { Color = "Blue", ResistanceValue = 6 });
            colBrand2.Add(new BandColor { Color = "Violet", ResistanceValue = 7 });
            colBrand2.Add(new BandColor { Color = "Gray", ResistanceValue = 8 });
            colBrand2.Add(new BandColor { Color = "White", ResistanceValue = 9 });
            return colBrand2;
        }

        public List<BandColor> getColorBand3List()
        {
            List<BandColor> colBrand3 = new List<BandColor>();
            colBrand3.Add(new BandColor { Color = "Black", ResistanceValue = 1 });
            colBrand3.Add(new BandColor { Color = "Brown", ResistanceValue = 10 });
            colBrand3.Add(new BandColor { Color = "Red", ResistanceValue = 100 });
            colBrand3.Add(new BandColor { Color = "Orange", ResistanceValue = 1000 });
            colBrand3.Add(new BandColor { Color = "Yellow", ResistanceValue = 10000 });
            colBrand3.Add(new BandColor { Color = "Green", ResistanceValue = 100000 });
            colBrand3.Add(new BandColor { Color = "Blue", ResistanceValue = 1000000 });
            colBrand3.Add(new BandColor { Color = "Violet", ResistanceValue = 10000000 });
            colBrand3.Add(new BandColor { Color = "Gray", ResistanceValue = 100000000 });
            colBrand3.Add(new BandColor { Color = "White", ResistanceValue = 1000000000 });
            colBrand3.Add(new BandColor { Color = "Gold", ResistanceValue = 0.1f });
            colBrand3.Add(new BandColor { Color = "Silver", ResistanceValue = 0.01f });
            colBrand3.Add(new BandColor { Color = "Pink", ResistanceValue = 0.001f });
            return colBrand3;
        }

        public List<BandColor> getColorBand4List()
        {
            List<BandColor> colBrand4 = new List<BandColor>();

            colBrand4.Add(new BandColor { Color = "Brown", ResistanceValue = 1 });
            colBrand4.Add(new BandColor { Color = "Red", ResistanceValue = 2 });
            colBrand4.Add(new BandColor { Color = "Green", ResistanceValue = 0.5f });
            colBrand4.Add(new BandColor { Color = "Blue", ResistanceValue = 0.25f });
            colBrand4.Add(new BandColor { Color = "Violet", ResistanceValue = 0.1f });
            colBrand4.Add(new BandColor { Color = "Gray", ResistanceValue = 0.05f });
            colBrand4.Add(new BandColor { Color = "Gold", ResistanceValue = 5 });
            colBrand4.Add(new BandColor { Color = "Silver", ResistanceValue = 10 });

            return colBrand4;

        }
    }
}