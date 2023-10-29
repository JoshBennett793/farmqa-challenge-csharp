# FarmQA Clock Code Challenge in C#

## First approach
In the first method, titled GetClockAngle, I aimed to solve the problem as it stood during the time of my interview. This approach does not consider the offset of the hour hand created as the minute hand increases.

## Second Approach
In the second method, titled GetPreciseClockAngle, I aimed to improve on the accuracy of the first method. The hour hand moves forward ever so slightly as the minute hand increase. The hour hand is 3/4 of the way 
past the top of the hour when the minute hand is 3/4 of the way around the clock (i.e. 45 minute mark). 

In this method, the angle of the hour hand from the 0 degree point is calculated by determining how many degrees from the 0 degree point 
the hour hand has moved due to the offset created by the minute hand. The modulo operation is performed to ensure that the resulting angle is within the range of 0 to 359.999 degrees by effectively "wrapping" the angle around if it exceeds 
360 degrees which accounts for the cyclical nature of a clock. 

The absolute difference between the two angles is calculated and the final result is determined conditionally on whether the angle is greater or less than 180 degrees. If the 
angle difference is greater than 180 degrees, the difference is subtracted from 360 to provide the smallest angle from the hour hand to the minute hand. If the angle difference is less or equal to 180 degrees, the angle difference is already 
the smallest angle and is subsequently returned.

## Why C#?
I have typically used javascript as my language of choice when solving coding challenges. Writing in C# provides a new challenge in writing with new syntax and taking into consideration the range of data types provided in C#. Writing in C# 
also provides a preview of the learning to come if I am selected for the position at FarmQA. FarmQA writes in what seems to be primarily C# on the backend of the stack. I want to expand my knowledge base to more backend languages and concepts 
to aid in my goal of becoming a well-rounded developer.

## What's Next?
I aim to build out a test file using xUnit as a testing framework over the next 2-3 days while balancing school work obligations.
