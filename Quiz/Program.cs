// string name = "Micke";

// bool isAlive = name == "Micke";

Babar();

float c = 23;
float f = 32 + (c * 1.8f);
Console.WriteLine($"Fahrenheit: {f:00.00}");

Console.WriteLine("""
{f}

""");

int hp = 100;

hp = hp + 10;
hp += 10;
hp += 1;
hp++;
Console.WriteLine($"Du har {hp} hp kvar");
if (hp > 0)
{
  Console.WriteLine("yay! Du lever!");
}
Console.ReadLine();

static void Babar()
{
Console.WriteLine("""
          _  .   .   .
        .' '; '-' '-'|-.
      (     '------.'  )
        ;            \ /
        :     '   ' |/
        '._._       \    .;
        .-'   ;--.    '--' /
      /      \-'---.___.'
      |     / 7 \(>o<) /\
      |     | \ |  . \   \
      |=====|   |  .  \ |-)
      |-'-'   ./_.-._.\|"
      '-.----'        |
        |       |     |
        |     | |   | |
        |_____|_|___|_|
        (-------',----'.
          '-'-----'-----'         
    """);
}