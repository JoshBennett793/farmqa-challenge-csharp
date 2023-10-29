using System;
class Clock
{
  static int GetClockAngle(int hr, int min)
  {
    hr = hr == 12 ? 0 : hr;

    int minAngle = min * 6;
    int hrAngle = hr * 30;

    int hrInverseDeg = hrAngle + 180;

    int result = minAngle > hrInverseDeg 
      ? 360 + hrAngle - minAngle 
      : 360 - hrAngle - (360 - minAngle);

    return result;
  }
  public static void Main(string[] args)
  {
    int Angle1 = GetClockAngle(12, 45); // 90
    int Angle2 = GetClockAngle(12, 15); // 90
    Console.WriteLine(Angle1);
    Console.WriteLine(Angle2);
  }
}