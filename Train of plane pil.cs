using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Console;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics.Tracing;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace cs
{
    public delegate void rate_change(int rate);
    public delegate void height_change(int height);
    [Serializable]
    public class Plane
    {
        public Plane()
        {

        }
        public int pitch, time, rate = 0, height = 0;//скорость и высота
        public void rapidity(int rate)
        {
            WriteLine($"скорость={rate}");
        }
        public void elevation(int height)
        {
            WriteLine($"высота={height}");
        }
        public void form_key_down(object sender, BinaryWriter writer, int spacing, int distance, Dispatcher supervisor, Dispatcher manager, Random rand_val, int pace, string name, string behalf)
        {
            while (spacing < (distance / 2))
            {
                WriteLine("клавиша");
                ReadKey();
                WriteLine($"пройденное расстояние={spacing}");
                if (spacing == 0) supervisor.n = rand_val.Next(-200, 201);
                WriteLine($"корректировка погодных условий={supervisor.n}");
                writer.Write($"traveled distance={spacing}");
                writer.Write($"adjustment of wheather conditions={supervisor.n}");
                if (ReadKey().Key == ConsoleKey.D)
                {
                    rate += 50;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("   +");
                    WriteLine("   ++");
                    WriteLine("++++++");
                    WriteLine("   ++");
                    WriteLine("   +");
                    writer.Write("   +");
                    writer.Write("   ++");
                    writer.Write("++++++");
                    writer.Write("   ++");
                    writer.Write("   +");
                    if (rate > pace)
                    {
                        supervisor.pen_points += 100;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        supervisor.decline();
                        WriteLine("снижение");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                        writer.Write($"decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.A)
                {
                    rate -= 50;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("  -");
                    WriteLine(" --");
                    WriteLine("------");
                    WriteLine(" --");
                    WriteLine("  -");
                    writer.Write("  -");
                    writer.Write(" --");
                    writer.Write("------");
                    writer.Write(" --");
                    writer.Write("  -");
                    if (rate > pace)
                    {
                        supervisor.pen_points += 100;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        supervisor.decline();
                        WriteLine("снижение");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                        writer.Write($"decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.E)
                {
                    rate += 150;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("   +");
                    WriteLine("   ++");
                    WriteLine("++++++");
                    WriteLine("   ++");
                    WriteLine("   +");
                    WriteLine("   +");
                    WriteLine("   ++");
                    WriteLine("++++++");
                    WriteLine("   ++");
                    WriteLine("   +");
                    writer.Write("   +");
                    writer.Write("   ++");
                    writer.Write("++++++");
                    writer.Write("   ++");
                    writer.Write("   +");
                    writer.Write("   +");
                    writer.Write("   ++");
                    writer.Write("++++++");
                    writer.Write("   ++");
                    writer.Write("   +");
                    if (rate > pace)
                    {
                        supervisor.pen_points += 100;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        supervisor.decline();
                        WriteLine("снижение");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                        writer.Write($"decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.Q)
                {
                    rate -= 150;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("  -");
                    WriteLine(" --");
                    WriteLine("------");
                    WriteLine(" --");
                    WriteLine("  -");
                    WriteLine("  -");
                    WriteLine(" --");
                    WriteLine("------");
                    WriteLine(" --");
                    WriteLine("  -");
                    writer.Write("  -");
                    writer.Write(" --");
                    writer.Write("------");
                    writer.Write(" --");
                    writer.Write("  -");
                    writer.Write("  -");
                    writer.Write(" --");
                    writer.Write("------");
                    writer.Write(" --");
                    writer.Write("  -");
                    if (rate > pace)
                    {
                        supervisor.pen_points += 100;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        supervisor.decline();
                        WriteLine("снижение");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                        writer.Write($"decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.W)
                {
                    height += 250;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + supervisor.n;
                    WriteLine("  +  ");
                    WriteLine(" +++ ");
                    WriteLine("+++++");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    writer.Write("  +  ");
                    writer.Write(" +++ ");
                    writer.Write("+++++");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        supervisor.pen_points += 25;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        supervisor.pen_points += 50;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        supervisor.crash();
                        WriteLine("крушение");
                        writer.Write("crash");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.S)
                {
                    height -= 250;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + supervisor.n;
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("-----");
                    WriteLine(" --- ");
                    WriteLine("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("-----");
                    writer.Write(" --- ");
                    writer.Write("  -  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        supervisor.pen_points += 25;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        supervisor.pen_points += 50;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        supervisor.crash();
                        WriteLine("крушение");
                        writer.Write("crash");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.F)
                {
                    height += 500;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + supervisor.n;
                    WriteLine("  +  ");
                    WriteLine(" +++ ");
                    WriteLine("+++++");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine(" +++ ");
                    WriteLine("+++++");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    writer.Write("  +  ");
                    writer.Write(" +++ ");
                    writer.Write("+++++");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write(" +++ ");
                    writer.Write("+++++");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        supervisor.pen_points += 25;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        supervisor.pen_points += 50;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        supervisor.crash();
                        WriteLine("крушение");
                        writer.Write("crash");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                if (ReadKey().Key == ConsoleKey.X)
                {
                    height -= 500;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + supervisor.n;
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("-----");
                    WriteLine(" --- ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("-----");
                    WriteLine(" --- ");
                    WriteLine("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("-----");
                    writer.Write(" --- ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("-----");
                    writer.Write(" --- ");
                    writer.Write("  -  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        supervisor.pen_points += 25;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        supervisor.pen_points += 50;
                        WriteLine($"количество штрафных очков={supervisor.pen_points}");
                        writer.Write($"amount of penalty points={supervisor.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        supervisor.crash();
                        WriteLine("крушение");
                        writer.Write("crash");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                if (spacing == 0)
                {
                    WriteLine($"первый диспетчер {name}");
                    writer.Write($"first dispatcher {name}");
                }
                if (rate > 50 && rate < 1000)
                {
                    WriteLine(supervisor.takeoff);
                    writer.Write(supervisor.takeoff);
                }
                if (height < 0) supervisor.crash();
                if (rate < pace)
                {
                    WriteLine($"для набора высоты нужно достигнуть скорости {pace}");
                    writer.Write($"it's needed to achieve {pace} rate for height set");
                }
                if (rate <= 0) rate = 250;
                //time = (distance - spacing) / rate;
                //WriteLine($"время={time}");
                //writer.Write($"время={time}");
                if (rate < supervisor.velocity)
                {
                    WriteLine("низкая скорость");
                    writer.Write("low rate");
                }
                else if (rate > supervisor.velocity)
                {
                    WriteLine("превышение скорости");
                    writer.Write("rate exceeding");
                }
                if (supervisor.pen_points == 1000)
                {
                    //Clear();
                    //supervisor.rejection();
                    //WriteLine("отказ");
                    //writer.Write("отказ");
                }
                if (spacing != 0 || spacing != distance) if (height == 0 || rate == 0)
                    {
                        //Clear();
                        //supervisor.rejection();
                        //WriteLine("отказ");
                        //writer.Write("отказ");
                    }
                spacing++;
                Thread.Sleep(time);
                Thread.Sleep(1000);
                Clear();
            }
            while (spacing >= (distance / 2) && spacing <= distance)
            {
                WriteLine("клавиша");
                ReadKey();
                WriteLine($"пройденное расстояние={spacing}");
                writer.Write($"traveled distance={spacing}");
                if (spacing == (distance / 2))
                {
                    WriteLine($"второй диспетчер {behalf}");
                    writer.Write($"second dispatcher {behalf}");
                    manager.n = rand_val.Next(-200, 201);
                }
                WriteLine($"корректировка погодных условий={manager.n}");
                writer.Write($"adjustment of wheather conditions={manager.n}");
                rate = distance;
                if (ReadKey().Key == ConsoleKey.D)
                {
                    rate += 50;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("   +");
                    WriteLine("   ++");
                    WriteLine("++++++");
                    WriteLine("   ++");
                    WriteLine("   +");
                    writer.Write("   +");
                    writer.Write("   ++");
                    writer.Write("++++++");
                    writer.Write("   ++");
                    writer.Write("   +");
                    if (rate > pace)
                    {
                        manager.pen_points += 100;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                        manager.decline();
                        WriteLine("снижение");
                        writer.Write("decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.A)
                {
                    rate -= 50;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("  -");
                    WriteLine(" --");
                    WriteLine("------");
                    WriteLine(" --");
                    WriteLine("  -");
                    writer.Write("  -");
                    writer.Write(" --");
                    writer.Write("------");
                    writer.Write(" --");
                    writer.Write("  -");
                    if (rate > pace)
                    {
                        manager.pen_points += 100;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                        manager.decline();
                        WriteLine("снижение");
                        writer.Write("decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.E)
                {
                    rate += 150;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("   +");
                    WriteLine("   ++");
                    WriteLine("++++++");
                    WriteLine("   ++");
                    WriteLine("   +");
                    WriteLine("   +");
                    WriteLine("   ++");
                    WriteLine("++++++");
                    WriteLine("   ++");
                    WriteLine("   +");
                    writer.Write("   +");
                    writer.Write("   ++");
                    writer.Write("++++++");
                    writer.Write("   ++");
                    writer.Write("   +");
                    writer.Write("   +");
                    writer.Write("   ++");
                    writer.Write("++++++");
                    writer.Write("   ++");
                    writer.Write("   +");
                    if (rate > pace)
                    {
                        manager.pen_points += 100;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                        manager.decline();
                        WriteLine("снижение");
                        writer.Write("decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.Q)
                {
                    rate -= 150;
                    supervisor.shift += rapidity;
                    supervisor.rapidity(rate);
                    supervisor.shift -= rapidity;
                    WriteLine("  -");
                    WriteLine(" --");
                    WriteLine("------");
                    WriteLine(" --");
                    WriteLine("  -");
                    WriteLine("  -");
                    WriteLine(" --");
                    WriteLine("------");
                    WriteLine(" --");
                    WriteLine("  -");
                    writer.Write("  -");
                    writer.Write(" --");
                    writer.Write("------");
                    writer.Write(" --");
                    writer.Write("  -");
                    writer.Write("  -");
                    writer.Write(" --");
                    writer.Write("------");
                    writer.Write(" --");
                    writer.Write("  -");
                    if (rate > pace)
                    {
                        manager.pen_points += 100;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                        manager.decline();
                        WriteLine("снижение");
                        writer.Write("decline");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.W)
                {
                    height += 250;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + manager.n;
                    WriteLine("  +  ");
                    WriteLine(" +++ ");
                    WriteLine("+++++");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    writer.Write("  +  ");
                    writer.Write(" +++ ");
                    writer.Write("+++++");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        manager.pen_points += 25;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        manager.pen_points += 50;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        manager.crash();
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.S)
                {
                    height -= 250;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + manager.n;
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("-----");
                    WriteLine(" --- ");
                    WriteLine("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("-----");
                    writer.Write(" --- ");
                    writer.Write("  -  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        manager.pen_points += 25;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        manager.pen_points += 50;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        manager.crash();
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.F)
                {
                    height += 500;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + manager.n;
                    WriteLine("  +  ");
                    WriteLine(" +++ ");
                    WriteLine("+++++");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine(" +++ ");
                    WriteLine("+++++");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    WriteLine("  +  ");
                    writer.Write("  +  ");
                    writer.Write(" +++ ");
                    writer.Write("+++++");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write(" +++ ");
                    writer.Write("+++++");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    writer.Write("  +  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        manager.pen_points += 25;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        manager.pen_points += 50;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        manager.crash();
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                else if (ReadKey().Key == ConsoleKey.X)
                {
                    height -= 500;
                    supervisor.altitude += elevation;
                    supervisor.elevation(height);
                    supervisor.altitude -= elevation;
                    pitch = 7 * rate + manager.n;
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("-----");
                    WriteLine(" --- ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("  -  ");
                    WriteLine("-----");
                    WriteLine(" --- ");
                    WriteLine("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("-----");
                    writer.Write(" --- ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("  -  ");
                    writer.Write("-----");
                    writer.Write(" --- ");
                    writer.Write("  -  ");
                    if (pitch > 0)
                    {
                        WriteLine($"рекомендуемая высота={pitch}");
                        writer.Write($"recomended height={pitch}");
                    }
                    if ((pitch - height) >= 300 || (pitch - height) < 600)
                    {
                        manager.pen_points += 25;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) >= 600 || (pitch - height) < 1000)
                    {
                        manager.pen_points += 50;
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    else if ((pitch - height) > 1000)
                    {
                        Clear();
                        manager.crash();
                        WriteLine($"количество штрафных очков={manager.pen_points}");
                        writer.Write($"amount of penalty points={manager.pen_points}");
                    }
                    if (height < pitch)
                    {
                        WriteLine("нужно поднять самолёт до рекомендуемой высоты");
                        writer.Write("it's needed to raise plane to a recomended height");
                    }
                    else if (height > pitch)
                    {
                        WriteLine("нужно спуститься до рекомендуемой высоты");
                        writer.Write("it's needed to go down to recomended height");
                    }
                }
                if (spacing == (distance / 2))
                {
                    WriteLine($"второй диспетчер {behalf}");
                    writer.Write($"second dispatcher {behalf}");
                }
                WriteLine($"нужная скорость={manager.velocity}");
                writer.Write($"needed rate={manager.velocity}");
                int time = (distance - spacing) / rate;
                if (rate < manager.velocity)
                {
                    WriteLine("низкая скорость");
                    writer.Write("low rate");
                }
                else if (rate > manager.velocity)
                {
                    WriteLine("превышение скорости");
                    writer.Write("rate exceeding");
                }
                if (rate < 50)
                {
                    WriteLine(manager.landing);
                    writer.Write(manager.landing);
                }
                if (manager.pen_points == 1000)
                {
                    //Clear();
                    //manager.rejection();
                    //WriteLine("отказ");
                    //writer.Write("отказ");
                }
                if (spacing != 0 || spacing != distance) if (height == 0 || rate == 0)
                    {
                        Clear();
                        manager.rejection();
                        WriteLine("отказ");
                        writer.Write("rejection");
                    }
                Thread.Sleep(time);
                Thread.Sleep(1000);
                if (spacing < distance) Clear();
                if (spacing == distance)
                {
                    WriteLine($"количество штрафных очков={manager.pen_points}");
                    writer.Write($"amount of penalty points={manager.pen_points}");
                }
                spacing++;
            }
        }
    }
    public class Dispatcher
    {
        public int n, pen_points = 0;//штрафные очки
        public Dispatcher()
        {

        }
        public string takeoff = "взлёт", landing = "посадка";//поля диспетчера
        public void crash()
        {
            Clear();
            WriteLine("самолёт разбился");
        }
        public void rejection()
        {
            //Clear();
            //WriteLine("полёт завершён преждевременно из-за большого количества штрафов");
        }
        public void decline()
        {
            WriteLine("нужно снизить скорость");
        }
        public event rate_change shift;
        public void rapidity(int rate)
        {
            if (shift != null) shift(rate);
        }
        public event height_change altitude;
        public void elevation(int height)
        {
            if (altitude != null) altitude(height);
        }
        public int velocity = 1000;
    }
    internal class Train_of_plane_pil
    {
        static void Main(string[] args)
        {
            WriteLine("A - уменьшение скорости на 50 км/ч");
            WriteLine("D - увеличение скорости на 50 км/ч");
            WriteLine("E - увеличение скорости на 150 км/ч");
            WriteLine("Q - уменьшение скорости на 150 км/ч");
            WriteLine("W - увеличение высоты на 250 м");
            WriteLine("S - уменьшение высоты на 250 м");
            WriteLine("F - увеличение высоты на 500 м");
            WriteLine("X - уменьшение высоты на 500 м");
            Plane aircraft = new Plane();
            object sender = 0;//сигнатура метода нажатия клавиши
            WriteLine("первый диспетчер");
            string name = ReadLine();
            WriteLine("второй диспетчер");
            string behalf = ReadLine();
            Dispatcher supervisor = new Dispatcher(), manager = new Dispatcher();//первый и второй диспетчеры
            int distance = 100, pace = 1000, spacing = 0;//пройденное расстояние
            Random rand_val = new Random();
            WriteLine($"расстояние={distance}");
            string file_path = "\\\\Keenetic-9922\\внешний диск\\c#\\cs\\cs\\логи.dat";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(file_path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (BinaryWriter writer = new BinaryWriter(stream, Encoding.Unicode))
                {
                    formatter.Serialize(stream, aircraft);
                    aircraft.form_key_down(sender, writer, spacing, distance, supervisor, manager, rand_val, pace, name, behalf);
                }
            }
        }
    }
}