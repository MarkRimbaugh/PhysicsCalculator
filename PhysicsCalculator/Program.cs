// See https://aka.ms/new-console-template for more information

bool runAgain = true;
const long SPEED_OF_LIGHT = 299792458;

while (runAgain)
{
    DisplayMenu();

    int choice = GetValidNumber(1, 5);

    switch (choice)
    {
        case 1:
            GetDensity();
            break;

        case 2:
            GetEnergy();
            break;

        case 3:
            GetForce();
            break;

        case 4:
            GetMomentum();
            break;

        case 5:
            GetSpeed();
            break;

        default:
            Console.WriteLine("Invalid Entry");
            break;
    }

    RunAgain();
}

void DisplayMenu()
{
    Console.WriteLine(" ***** Physics Calculator ***** ");
    Console.WriteLine("1. Density");
    Console.WriteLine("2. Energy");
    Console.WriteLine("3. Force");
    Console.WriteLine("4. Momemtum");
    Console.WriteLine("5. Speed");
}

static int GetValidNumber(int min, int max)
{
    bool isValid = false;
    int number = 0;
    string? input;

    while (!isValid)
    {
        Console.Write($"\nEnter a number between {min} and {max} -> ");
        input = Console.ReadLine();

        isValid = Int32.TryParse(input, out number) && (number >= min && number <= max);

        if (isValid)
        {
            if (ConfirmInput(number) == false)
            {
                isValid = false;
            }
        }

        if (!isValid)
        {
            Console.WriteLine("Please make another choice.");
        }
    }
    return number;
}

static bool ConfirmInput(int x)
{
    string input;
    bool confirmed = false;
    bool validChoice = false;

    while (!validChoice)
    {
        Console.Write($"You entered: {x}. Is that correct? Y/N -> ");
        input = Console.ReadLine();

        if (input?.ToLower() == "y")
        {
            validChoice = true;
            confirmed = true;
        }
        else if (input?.ToLower() == "n")
        {
            validChoice = true;
            confirmed = false;
        }
        else
        {
            validChoice = false;
            Console.WriteLine("Invalid entry, please choose Y or N");
        }
    }

    return confirmed;

}

void RunAgain()
{
    Console.WriteLine("\n1. Run again");
    Console.WriteLine("2. Quit");
    Console.Write("\nChoice: ");
    string choice = Console.ReadLine();
    if (choice == "1")
    {
        runAgain = true;
    }
    else
    {
        runAgain = false;
    }
}

void GetEnergy()
{
    bool inputConfirmed = false;
    bool isNumber = false;
    long energy = 0;
    int mass = 0;
    Console.WriteLine("\n***** Energy Calculator *****");
    while (!inputConfirmed)
    {
        while (!isNumber)
        {
            Console.Write("\nEnter mass -> ");
            isNumber = Int32.TryParse(Console.ReadLine(), out mass);

            if (!isNumber)
            {
                Console.WriteLine("Invalid entry, please enter a number.");
            }
        }

        if (ConfirmInput(mass) == true)
        {
            inputConfirmed = true;
            energy = mass * SPEED_OF_LIGHT;
        }
    }
    Console.WriteLine($"Energy: mass x speed of light ({SPEED_OF_LIGHT}) = {energy}");
}

void GetSpeed()
{
    // = distanceTravelled / time

    bool inputConfirmed = false;
    bool isNumber = false;
    int speed = 0;
    int distance = 0;
    int time = 0;

    Console.WriteLine("\n***** Speed Calculator *****");
    while (!inputConfirmed)
    {
        while (!isNumber)
        {
            Console.Write("\nEnter distance travelled -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out distance) && ConfirmInput(distance);

            Console.Write("\nEnter elapsed time -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out time) && ConfirmInput(time);

            if (!isNumber)
            {
                Console.WriteLine("Invalid entry, please enter a number.");
            }
        }

        speed = distance / time;
    }
    Console.WriteLine($"\nSpeed: mass x velocity = {speed}");
}

void GetMomentum()
{
    bool inputConfirmed = false;
    bool isNumber = false;
    int momentum = 0;
    int mass = 0;
    int velocity = 0;

    Console.WriteLine("\n***** Momentum Calculator *****");
    while (!inputConfirmed)
    {
        while (!isNumber)
        {
            Console.Write("\nEnter mass -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out mass) && ConfirmInput(mass);

            Console.Write("\nEnter velocity -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out velocity) && ConfirmInput(velocity);

            if (!isNumber)
            {
                Console.WriteLine("Invalid entry, please enter a number.");
            }
        }

        momentum = mass * velocity;
    }
    Console.WriteLine($"\nMomentum: mass x velocity = {momentum}");
}

void GetForce()
{
    bool inputConfirmed = false;
    bool isNumber = false;
    int force = 0;
    int mass = 0;
    int acceleration = 0;

    Console.WriteLine("\n***** Force Calculator *****");
    while (!inputConfirmed)
    {
        while (!isNumber)
        {
            Console.Write("\nEnter mass -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out mass) && ConfirmInput(mass);

            Console.Write("\nEnter acceleration -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out acceleration) && ConfirmInput(acceleration);

            if (!isNumber)
            {
                Console.WriteLine("Invalid entry, please enter a number.");
            }
        }

        force = mass * acceleration;
    }
    Console.WriteLine($"\nForce: mass x acceleration = {force}");
}

void GetDensity()
{
    bool inputConfirmed = false;
    bool isNumber = false;
    int density = 0;
    int mass = 0;
    int volume = 0;

    Console.WriteLine("\n***** Density Calculator *****");
    while (!inputConfirmed)
    {
        while (!isNumber)
        {
            Console.Write("\nEnter mass -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out mass) && ConfirmInput(mass);

            Console.Write("\nEnter volume -> ");
            inputConfirmed = isNumber = Int32.TryParse(Console.ReadLine(), out volume) && ConfirmInput(volume);

            if (!isNumber)
            {
                Console.WriteLine("Invalid entry, please enter a number.");
            }
        }

        density = mass * volume;
    }
    Console.WriteLine($"\nDensity: mass / volume = {density}");
}






