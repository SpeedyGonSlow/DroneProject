# DroneProject

Code Challenge: Drone Project

Story Description:
Our company developed an automated drone to analyze the crops on a farm.
One of our framing clients granted us an opportunity to analyse his crops just
before the harvesting starts. Leaving the drone to fly and analyse the crops by
itself, we had some celebratory pizza and drinks with the farmer. Unfortunately
our monitoring system lost communication with the drone. For safety reasons
in such a situation, the drone would have landed immediately.

The (very irate) farmer will not allow us to walk into the crops to search for and
retrieve our drone. To make matters worse, he has already given instruction to
the harvesting operator to start harvesting the field in 3 hours time and is
unwilling to delay the harvesting. With all the data still on the drone we cannot
even complete the analysis for the client.

As the newest member of our team you identify an opportunity to show off your
technical ability to everyone and also hope to impress the client.
You tell the management team that you recently reviewed the algorithm used
by the drone and therefore you know the pattern which it would have followed
to navigate above the crops. For today’s analysis you configured it to fly at 1
meter per second. If someone could confirm the exact duration from when it
started flying until we lost communication, you are certain that you’ll be able to
determine it’s exact location in the crop field.

The management team agrees with your plan. After sharing it with the client,
he proposes a challenge … if you provide the location of the drone he will
communicate that to the harvesting operator allowing him to stop the
harvester just before the target location and retrieve the drone. If you are
correct, we’ll get the drone back and then he will pay for the analysis which was
performed. If however you are wrong, the harvester will destroy the drone and
we’ll be charged a clean-up & handling fee to remove the drone debris from the
harvested produce. Either way harvesting will start in 3 hours time.

You are now instructed to “quickly” develop a program which will determine
the exact location of the lost drone. As input the program will receive only the
duration (time) of the drone’s last flight. The crop field is square and at most 2^30
meters long/wide. Yes you read that correctly 1073741824 meters wide. This is
to ensure that you don’t just attempt to populate the actual path. 

Task:
While recalling what the algorithm does, you draw out the start of the path on
the back of one of the pizza boxes ... The algorithm would have started at the
corner of the field, flying 1 meter forward, 1 meter to the left, 1 meter backwards,
then 1 meter left, 2 meters forward, 2 meters right, 1 meter forward, 3 meters left,
3 meters backwards, and so on, effectively snaking deeper into the field all the
time.

...  ...  ...  ...  ...  26
...  21   22   23   24   25
...  20   13   12   11   10
...  19   14   7    8    9
...  18   15   6    3    2
...  17   16   5    4    1


You explain to the people around you that if the drone only flew for 11 seconds, it
would have landed at the location 2 meters left, 4 meters forward from the
starting position at the corner of the crop field.

While you develop the program the rest of the team carefully calculates the
exact flight time of the drone. They face their own challenges in calculating this
and eventually provide you with the total flight duration merely seconds before
the harvesting starts.

You enter it into the program and the program reports the location of the drone
to be X,Y (meaning X meters to the left, Y meters forward from the starting
position). You shout out the location to the farmer then brag to the other
developers that your program did all of this in only Z microseconds.
If you think the drone is safe, provide your source code to the team for review
along with the results (X, Y, Z) in a table summary for these inputs: 

268419078
268451837
1073709032
1073709087

[Code Challenge. Drone Project.docx](https://github.com/SpeedyGonSlow/DroneProject/files/9847606/Code.Challenge.Drone.Project.docx)
