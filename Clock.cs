using System;
class Clock
{
  static int GetClockAngle(int hr, int min)
  {
    hr = hr == 12 ? 0 : hr;

    int minAngle = min * 6;
    int hrAngle = hr * 30;

    int hrInverseAngle = hrAngle + 180;

    int result = minAngle > hrInverseAngle 
      ? 360 + hrAngle - minAngle 
      : 360 - hrAngle - (360 - minAngle);

    return result;
  }

  static double GetPreciseClockAngle(int hr, int min) 
  {
    hr = hr == 12 ? 0 : hr;

    // determine angle of min hand from 0 deg point
    double minAngle = min * 6.0;
    // determine precise angle of hour hand from 0 deg point
    double hrAngle = (hr * 30.0 + minAngle / 12.0) % 360.0;
    
    // determine absolute difference between both angles
    double angleDifference = Math.Abs(minAngle - hrAngle);

    // if diff is over 180, angle will be calculated 
    double result = angleDifference > 180
      ? 360 - angleDifference
      : angleDifference;

    return result;
  }
  public static void Main(string[] args)
  {
    int angle2 = GetClockAngle(12, 15);
    int angle1 = GetClockAngle(12, 45);

    double preciseAngle1 = GetPreciseClockAngle(12, 15);
    double preciseAngle2 = GetPreciseClockAngle(12, 45);

    // GetClockAngle
    Console.WriteLine($"Angle1: {angle1}"); // 90
    Console.WriteLine($"Angle2: {angle2}"); // 90

    // GetPreciseClockAngle
    Console.WriteLine($"preciseAngle1: {preciseAngle1}"); // 82.5
    Console.WriteLine($"preciseAngle2: {preciseAngle2}"); // 112.5
  }
}