##Color Code Calculator##
(ASP.NET MVC Application)

#Description
This app implements an color code calculator for registor based on the information found [here](http://en.wikipedia.org/wiki/Electronic_color_code) on Wikipedia and the interface provided below:

public interface IOhmValueCalculator

{

   /// <summary>

   /// Calculates the Ohm value of a resistor based on the band colors.

   /// </summary>

   /// <param name="bandAColor">The color of the first figure of component value band.</param>

   /// <param name="bandBColor">The color of the second significant figure band.</param>

   /// <param name="bandCColor">The color of the decimal multiplier band.</param>

   /// <param name="bandDColor">The color of the tolerance value band.</param>

   float CalculateOhmValue(int bandAColor, int bandBColor, float bandCColor, float bandDColor);

}

##How to run the color-code-calculator project/n

Step 1: Download the zip or clone the project with HTTPs url/n
Step2: Open the Solution file in Visual studio 2013 or above/n
Step3: Build & run the solution