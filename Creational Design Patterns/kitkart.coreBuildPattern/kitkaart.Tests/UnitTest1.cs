using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kitkart.coreBuildPattern;

namespace kitkaart.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var computer = new Computer
            {
                AmountOfCores = 64,
                AmountOfRam = 256,
                CpuFrequency = 3.4m,
                DriveType = "ssd"
            };
            var builder = new SuperComputerBuilder();
            builder.SetCores();
            builder.SetCpuFrequency();
            builder.SetRam();
            builder.SetDriveType();

            var superComputer = builder.GetComputer();

            Assert.AreEqual(superComputer.AmountOfCores,computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }

        [TestMethod]
        public void SuperComputer()
        {
            var computer = new Computer
            {
                AmountOfCores = 64,
                AmountOfRam = 256,
                CpuFrequency = 3.4m,
                DriveType = "ssd"
            };

            var store = new KitkartComputerStore();
            var builder = new SuperComputerBuilder();

            var superComputer = store.Build(builder);

            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }

        [TestMethod]
        public void NormalComputer()
        {
            var computer = new Computer
            {
                AmountOfCores = 1,
                AmountOfRam = 2,
                CpuFrequency = 2.0m,
                DriveType = "hdd"
            };

            var store = new KitkartComputerStore();
            var builder = new NormalComputerBuilder();

            var normalComputer = store.Build(builder);

            Assert.AreEqual(normalComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(normalComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(normalComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(normalComputer.DriveType, computer.DriveType);
        }
    }
}
