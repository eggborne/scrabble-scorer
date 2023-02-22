using System.Collections.Generic;
using System;

namespace NumbersToWords.Models
{
  public class Number 
  {
    
    public Number(int arabicNumber) 
    {
      this.arabicNumber = arabicNumber;
    }

    public string produceNumberString() 
    {
      String myNumber = this.arabicNumber.ToString();
      int myLength = myNumber.Length();
      int frontPart = myLength % 3;
      int currentNumber;
      String returnNumber = "";
      for (int i=0; i<myLength; i++){
        currentNumber = myNumber[i];
        if(currentNumber == 0 && myLength == 1){
          return "Zero";
        } else if (currentNumber == 0){
          continue;
        } else if (currentNumber == 1){
          returnNumber += "One";
          if(frontPart )
        }
      }



      String numString = "Blargh";

      return numString;
    }
  }
}