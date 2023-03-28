namespace ObjectOrientedPatterns.Structural.Facade
{
    public class Cpu
    {
        public void Freeze() => Console.WriteLine("Freeze CPU");
        public void Jump(long pos) => Console.WriteLine("Jump " + pos);
        public void Execute() => Console.WriteLine("Execute");
    }

    public class HardDrive
    {
        public void Read(long lba, int size) => Console.WriteLine("Read at " + lba + " of size " + size);
    }

    public class Memory
    {
        public void Load(long pos) => Console.WriteLine("Loading at " + pos);
    }

    public class ComputerFacade
    {
        public ComputerFacade(Cpu cpu, HardDrive hardDrive, Memory memory)
        {
            myCpu = cpu;
            myHardDrive = hardDrive;
            myMemory = memory;
        }
        public void Start()
        {
            var bootSector = 7;
            var sectorSize = 42;
            var bootAddress = 1234;
            myCpu.Freeze();
            myHardDrive.Read(bootSector, sectorSize);
            myMemory.Load(bootAddress);
            myCpu.Jump(bootAddress);
            myCpu.Execute();
        }
        private readonly Cpu myCpu;
        private readonly HardDrive myHardDrive;
        private readonly Memory myMemory;
    }
}
