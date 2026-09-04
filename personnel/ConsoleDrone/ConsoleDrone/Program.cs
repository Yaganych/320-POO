using ConsoleApp1;
Console.CursorVisible = false;

Drone[] drones =
[
    new Drone (0,0,50),
    new Drone (0, 10, 50),
    new Drone (0, 20, 50),
];

while (DroneIsAlive(drones))
{
    foreach (Drone drone in drones)
    {
        drone.ConsoleToShow();
        drone.StatusChange();
    }
    Thread.Sleep(1);
    Console.Clear();
}

foreach (Drone drone in drones)
{
    drone.ToDieMessage();
}
Console.ReadKey();

bool DroneIsAlive(Drone[] drones)
{
    foreach (Drone drone in drones)
    {
        if (drone.battery >= 0) return true;
    }

    return false;
}
