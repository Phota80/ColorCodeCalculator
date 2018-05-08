##Color Code Calculator##

#Description
This app implements an color code calculator for registor based on the information found here on Wikipedia and the interface provided below:

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

##How to run the color-code-calculator project
Step 1: Down the the project zip or clone the project
Step2: Open the Solution file in Visual studio 2013 or above
Step3: Build & run the solution