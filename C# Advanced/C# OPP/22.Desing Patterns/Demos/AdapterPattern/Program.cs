using System;
//2
namespace DemosPatterns
{
    public interface IDevice
    {
        public int Charger();
    }

    public class BgDevice : IDevice
    {
        public int Charger()
        {
            return 2;
        }
    }

    public class EnglandDevice : IDevice
    {
        public int Charger()
        {
            return 3;
        }
    }

    public class BgLaptop : BgDevice
    {
    }

    public class BgTelephone : BgDevice
    {
    }

    public class EnglandLaptop : EnglandDevice
    {
    }

    public class EnglandTelephone : EnglandDevice
    {
    }

    public interface IAdapter
    {
        public int CountHoles { get; }
    }

    class Adapter : IAdapter
    {
        private IDevice device;

        public Adapter(IDevice device)
        {
            this.device = device;
        }

        public int CountHoles => this.device.Charger();
    }

    public class StartUp
    {
        public static void Main()
        {
            Adapter adapter = new Adapter(new BgLaptop());
            Console.WriteLine(adapter.CountHoles);

            adapter = new Adapter(new EnglandLaptop());
            Console.WriteLine(adapter.CountHoles);
        }
    }
}
